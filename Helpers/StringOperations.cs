// ***********************************************************************
// Assembly         : Zeroit.Framework.CodeExplorer
// Author           : ZEROIT
// Created          : 02-16-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 01-05-2019
// ***********************************************************************
// <copyright file="StringOperations.cs" company="Zeroit Dev Technologies">
//    This program is for creating a program for viewing code.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ZeroitDevColorPicker
{
    internal static class StringOperations
    {
        public static bool IncludesAny(this string str, params string[] values)
        {
            if (!string.IsNullOrEmpty(str) || values.Length == 0)
            {
                foreach (string value in values)
                {
                    if (str.Contains(value))
                        return true;
                }
            }

            return false;
        }

        public static bool ContainsAny(this string theString, char[] characters)
        {
            foreach (char character in characters)
            {
                if (theString.Contains(character.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns a string with alternated letter casing (upper/lower). First character of the string stays the same.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public static string AlternateCases(this string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            if (input.Length == 1) return input; //Nothing to alternate

            char[] inputChars = input.ToCharArray(); //character array representing the string
            bool toUpper = !char.IsUpper(inputChars[0]);

            for (int i = 1; i < inputChars.Length; i++) //start with the section character
            {
                if (toUpper)
                    inputChars[i] = char.ToUpper(inputChars[i]);
                else
                    inputChars[i] = char.ToLower(inputChars[i]);

                toUpper = !toUpper; //alternate
            }

            return new string(inputChars);
        }

        /// <summary>
        /// Returns a string with the opposite letter casing for each character.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public static string SwapCases(this string input)
        {
            //Validate input
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            char[] inputChars = input.ToCharArray();

            for (int i = 0; i < inputChars.Length; i++)
            {
                //Apply the opposite letter casing
                if (char.IsUpper(inputChars[i]))
                    inputChars[i] = char.ToLower(inputChars[i]);
                else
                    inputChars[i] = char.ToUpper(inputChars[i]);
            }

            return new string(inputChars);
        }

        /// <summary>
        /// Capitalizes the first character in a string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            if (input.Length == 1) return input.ToUpper();

            return input[0].ToString().ToUpper() + input.Substring(1);
        }

        /// <summary>
        /// Capitalises the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>System.String.</returns>
        public static string Capitalise(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
