using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
	/// <summary>
	/// Simple container for a player's information.
	/// </summary>
	struct Player
	{
		/// <summary>
		/// The player's name.
		/// </summary>
		public string Name;
		/// <summary>
		/// The player's color.
		/// </summary>
		public CircleState Color;
		/// <summary>
		/// Whether the player is an AI.
		/// </summary>
		public bool AI;
	}
}
