using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
	/// <summary>
	/// Basic Utility functions this program utilizes. 
	/// </summary>
	public static class Utilities
	{

		/// <summary>
		/// Returns the greater of the two given variables
		/// </summary>
		/// <returns>the greater of the two given variables</returns>
		public static int GreaterOf( int a , int b ) {
			return a > b ? a : b;
		}

		/// <summary>
		/// Returns the lesser of the two given variables
		/// </summary>
		/// <returns>the lesser of the two given variables</returns>
		public static int LesserOf( int a , int b ) {
			return a < b ? a : b;
		}
	}
}
