﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;

using JetBrains.Annotations;

namespace CodeJam.Reflection
{
	/// <summary>
	/// Reflection extension methods.
	/// </summary>
	[PublicAPI]
	public static class ReflectionExtensions
	{
		/// <summary>
		/// Gets a value indicating whether the <paramref name="type"/> can be instantiated.
		/// </summary>
		/// <param name="type">The <see cref="Type"/> to test.</param>
		/// <returns>
		/// A value indicating whether the <paramref name="type"/> can be instantiated.
		/// </returns>
		[Pure]
		public static bool IsInstantiableType([NotNull] this Type type) =>
			!(type.IsAbstract || type.IsInterface || type.IsArray || type.ContainsGenericParameters);

		/// <summary>
		/// Gets a value indicating whether the <paramref name="type"/> is declared static.
		/// </summary>
		/// <param name="type">The <see cref="Type"/> to test.</param>
		/// <returns>
		/// A value indicating whether the <paramref name="type"/> is declared static.
		/// </returns>
		[Pure]
		public static bool IsStatic([NotNull] this Type type) =>
			type.IsClass && type.IsAbstract && type.IsSealed;

		/// <summary>
		/// Determines whether the <paramref name="type"/> derives from the specified <paramref name="check"/>.
		/// </summary>
		/// <remarks>
		/// This method also returns false if <paramref name="type"/> and the <paramref name="check"/> are equal.
		/// </remarks>
		/// <param name="type">The type to test.</param>
		/// <param name="check">The type to compare with. </param>
		/// <returns>
		/// true if the <paramref name="type"/> derives from <paramref name="check"/>; otherwise, false.
		/// </returns>
		[Pure]
		public static bool IsSubClass([NotNull] this Type type, [NotNull] Type check)
		{
			if (type == check)
				return false;

			while (true)
			{
				if (check.IsInterface)
					foreach (var interfaceType in type.GetInterfaces())
						if (interfaceType == check || interfaceType.IsSubClass(check))
							return true;

				if (type.IsGenericType && !type.IsGenericTypeDefinition)
				{
					var definition = type.GetGenericTypeDefinition();
					if (definition == check || definition.IsSubClass(check))
						return true;
				}

				type = type.BaseType;

				if (type == null)
					return false;

				if (type == check)
					return true;
			}
		}

		/// <summary>
		/// Returns custom attribute defined on this <paramref name="member"/>, identified by type <typeparamref name="T"/>,
		/// or null if there are no custom attribute of that type.
		/// </summary>
		/// <typeparam name="T">The type of the custom attribute.</typeparam>
		/// <param name="member">Member, on which custom attribute is looking for.</param>
		/// <param name="inherit">When true, look up the hierarchy chain for the inherited custom attribute.</param>
		/// <returns>An instance of custom attribute, or null.</returns>
		[CanBeNull]
		[Pure]
		public static T GetCustomAttribute<T>([NotNull] this ICustomAttributeProvider member, bool inherit = false)
			where T: Attribute
		{
			if (member == null) throw new ArgumentNullException(nameof(member));
			return member.GetCustomAttributes(typeof (T), inherit).Cast<T>().FirstOrDefault();
		}

		/// <summary>
		/// Returns an array of custom attributes defined on this <paramref name="member"/>,
		/// identified by type <typeparamref name="T"/>,  or empty array if there are no custom attribute of that type.
		/// </summary>
		/// <typeparam name="T">The type of the custom attributes.</typeparam>
		/// <param name="member">Member, on which custom attributes is looking for.</param>
		/// <param name="inherit">When true, look up the hierarchy chain for the inherited custom attributes.</param>
		/// <returns>An array of custom attributes, or empty array.</returns>
		[NotNull]
		[Pure]
		public static T[] GetCustomAttributes<T>([NotNull] this ICustomAttributeProvider member, bool inherit = false)
			where T : Attribute
		{
			if (member == null) throw new ArgumentNullException(nameof(member));
			return member.GetCustomAttributes(typeof(T), inherit).Cast<T>().ToArray();
		}

		/// <summary>
		/// Returns true if at least one attribute of type <paramref name="attrType"/> specified in <paramref name="member"/>
		/// exists.
		/// </summary>
		/// <param name="member">Member, on which custom attributes is looking for.</param>
		/// <param name="attrType">The type of the custom attribute.</param>
		/// <param name="inherit">When true, look up the hierarchy chain for the inherited custom attributes.</param>
		[Pure]
		public static bool HasCustomAttribute(
			[NotNull] this ICustomAttributeProvider member,
			[NotNull] Type attrType,
			bool inherit = false)
		{
			if (member == null) throw new ArgumentNullException(nameof(member));
			if (attrType == null) throw new ArgumentNullException(nameof(attrType));
			return member.GetCustomAttributes(attrType, inherit).Length > 0;
		}

		/// <summary>
		/// Returns true if at least one attribute of type <typeparamref name="T"/> specified in <paramref name="member"/>
		/// exists.
		/// </summary>
		/// <param name="member">Member, on which custom attributes is looking for.</param>
		/// <param name="inherit">When true, look up the hierarchy chain for the inherited custom attributes.</param>
		[Pure]
		public static bool HasCustomAttribute<T>([NotNull] this ICustomAttributeProvider member, bool inherit = false)
			where T : Attribute  =>
				member.HasCustomAttribute(typeof (T), inherit);

		/// <summary>
		/// Returns true if at least one attribute of type <paramref name="attrType"/> specified in <paramref name="member"/>
		/// corresponds to <paramref name="predicate"/>.
		/// </summary>
		/// <param name="member">Member, on which custom attributes is looking for.</param>
		/// <param name="attrType">The type of the custom attribute.</param>
		/// <param name="predicate">A function to test each attribute for a condition</param>
		/// <param name="inherit">When true, look up the hierarchy chain for the inherited custom attributes.</param>
		[Pure]
		public static bool HasCustomAttribute(
			[NotNull] this ICustomAttributeProvider member,
			[NotNull] Type attrType,
			[NotNull] Func<Attribute, bool> predicate,
			bool inherit = false)
		{
			if (member == null) throw new ArgumentNullException(nameof(member));
			if (attrType == null) throw new ArgumentNullException(nameof(attrType));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));
			return member.GetCustomAttributes(attrType, inherit).Cast<Attribute>().Any(predicate);
		}

		/// <summary>
		/// Returns true if at least one attribute of type <typeparamref name="T"/> specified in <paramref name="member"/>
		/// corresponds to <paramref name="predicate"/>.
		/// </summary>
		/// <param name="member">Member, on which custom attributes is looking for.</param>
		/// <typeparam name="T">The type of the custom attribute.</typeparam>
		/// <param name="predicate">A function to test each attribute for a condition</param>
		/// <param name="inherit">When true, look up the hierarchy chain for the inherited custom attributes.</param>
		[Pure]
		public static bool HasCustomAttribute<T>(
			[NotNull] this ICustomAttributeProvider member,
			[NotNull] Func<T, bool> predicate,
			bool inherit = false)
			where T: Attribute
		{
			if (member == null) throw new ArgumentNullException(nameof(member));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));
			return member.GetCustomAttributes<T>(inherit).Any(predicate);
		}

		/// <summary>
		/// Loads the specified manifest resource from this assembly, and checks if it exists.
		/// </summary>
		/// <param name="assembly">Resource assembly.</param>
		/// <param name="name">The case-sensitive name of the manifest resource being requested.</param>
		/// <returns>The manifest resource.</returns>
		/// <exception cref="ArgumentNullException">The name parameter is null.</exception>
		/// <exception cref="ArgumentException">Resource with specified name not found</exception>
		[NotNull]
		[Pure]
		public static Stream GetRequiredResourceStream([NotNull] this Assembly assembly, [NotNull] string name)
		{
			if (assembly == null) throw new ArgumentNullException(nameof(assembly));
			if (name.IsNullOrWhiteSpace()) throw new ArgumentNullException(nameof(name));

			var result = assembly.GetManifestResourceStream(name);
			if (result == null)
				throw new ArgumentException("Resource with specified name not found");
			return result;
		}

		/// <summary>
		/// Returns path to assembly <paramref name="asm"/> file.
		/// </summary>
		/// <param name="asm">Assembly.</param>
		[NotNull]
		[Pure]
		public static string GetAssemblyPath([NotNull] this Assembly asm)
		{
			if (asm == null) throw new ArgumentNullException(nameof(asm));
			var codeBase = asm.CodeBase;
			if (codeBase == null)
				throw new ArgumentException("Specified assembly has no physical code base.");
			var uri = new Uri(codeBase);
			if (!uri.IsFile)
				throw new ArgumentException("Specified assembly placed not on local disk.");
			return uri.AbsolutePath;
		}

		/// <summary>
		/// Returns directory part of path to assembly <paramref name="asm"/> file.
		/// </summary>
		/// <param name="asm">Assembly.</param>
		[NotNull]
		[Pure]
		public static string GetAssemblyDirectory([NotNull] this Assembly asm) =>
			Path.GetDirectoryName(GetAssemblyPath(asm)) ?? "";
	}
}