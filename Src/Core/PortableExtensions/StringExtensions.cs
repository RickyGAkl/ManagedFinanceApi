﻿using System.Collections.Generic;

namespace PortableExtensions
{
    /// <summary>
    /// Extension methods for all things string related
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     A string extension method that queries if '@str' is null or is empty.
        /// </summary>
        /// <param name="str">The str to act on.</param>
        /// <returns>true if 'str' is null or is empty, false if not.</returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        ///     A string extension method that queries if 'str' is not (null or empty).
        /// </summary>
        /// <param name="str">The str to act on.</param>
        /// <returns>true if 'str' is not (null or empty), false if not.</returns>
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Converts to a comma delimeted string
        /// </summary>
        /// <param name="strs">a List of all the strings</param>
        /// <returns></returns>
        public static string ToCsvString(this IEnumerable<string> strs)
        {
            return string.Join(",", strs.AlwaysList());
        }
    }
}
