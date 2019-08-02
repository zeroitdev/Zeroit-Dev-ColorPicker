// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="CatColorPicker.cs" company="Zeroit Dev Technologies">
//    This program is that contains various editors for drawing and painting.
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ZeroitDevColorPicker.Helpers.Colors.WikiColors
{
    
    /// <summary>
    /// 	Class representing a color group.
    /// </summary>
	public class ColorGroup
	{

        
	    /// <summary>
	    /// 	Constructor with title.
	    /// </summary>
	    /// <param name="title">Title of color group.</param>
		public ColorGroup(string title)
		{
			this.title = title;
			this.colors = new List<Color>();
		}

		private string title;
		/// <summary>
		/// 	Gets the title of this color group.
		/// </summary>
		/// <value>
		/// 	Title of this color group.
		/// </value>
		public string Title
		{
			get { return title; }
		}

		private List<Color> colors;
		/// <summary>
		/// 	Add color to this group.
		/// </summary>
		/// <param name="color">Color to add.</param>
		public void Add(Color color)
		{
			colors.Add(color);
		}
		
		/// <summary>
		/// 	Gets the current array of colors in this group.
		/// </summary>
		/// <value>
		/// 	Array of colors in this group.
		/// </value>
		public Color[] Colors
		{
			get { return colors.ToArray(); }
		}


        public Dictionary<string, Color> AllWebColors
        {
            get { return WebColor.AllColors; }
        }


        /// <summary>
        /// 	Returns a string representation of this color group.
        /// </summary>
        /// <returns>Display string.</returns>
		public override string ToString()
		{
			return string.Format("ColorGroup {0} [{1} items]", title, colors.Count);
		}
    }
}
