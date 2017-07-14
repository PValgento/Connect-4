using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Connect4
{

	/// <summary>
	/// Manages the board state of the game, allows accessing of rows, columns, elements, as well as adding a piece to the board.
	/// </summary>
	class GameBoard
	{
		/// <summary>
		/// The number of rows on the board
		/// </summary>
		public static readonly int NumRows = 6;
		/// <summary>
		/// The number of columns on the board
		/// </summary>
		public static readonly int NumColumns = 7;
		/// <summary>
		/// The number of items a player needs in a row to win the game.
		/// </summary>
		public static readonly int VictoryLength = 4;

		/// <summary>
		/// An array representing the board's slots' states.
		/// <seealso cref="CircleState"/>
		/// </summary>
		protected CircleState[,] board;

		/// <summary>
		/// Initializes a new instance of the <see cref="GameBoard"/> class.
		/// </summary>
		public GameBoard() {
			board = new CircleState[NumRows , NumColumns];
		}

		/// <summary>
		/// Returns an array of <see cref="CircleState" />s for the requested row.
		/// </summary>
		/// <param name="row">The row requested.</param>
		/// <returns>an array of <see cref="CircleState" />s for the requested row.</returns>
		/// <exception cref="InvalidOperationException">Invalid row requested</exception>
		public CircleState[] GetRow( int row ) {
			CircleState[] toReturn = new CircleState[NumRows];
			if ( row <= 0 || row >= NumRows )
				throw new InvalidOperationException( "Invalid row requested" );
			for ( int i = 0; i < NumColumns; ++i ) {
				toReturn[i] = board[row , i];
			}
			return toReturn;
		}

		/// <summary>
		/// Returns an array of <see cref="CircleState" />s for the requested row.
		/// </summary>
		/// <param name="column">The column requested</param>
		/// <returns>
		/// an array of <see cref="CircleState" />s for the requested row.
		/// </returns>
		/// <exception cref="InvalidOperationException">Invalid column requested</exception>
		public CircleState[] GetColumn( int column ) {
			CircleState[] toReturn = new CircleState[NumRows];
			ValidColumn( column );
			for ( int i = 0; i < NumColumns; ++i ) {
				toReturn[i] = board[i , column];
			}
			return toReturn;
		}

		/// <summary>
		/// Gets the element requested.
		/// </summary>
		/// <param name="row">The row.</param>
		/// <param name="column">The col.</param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException">Invalid element location</exception>
		public CircleState GetElement( int row , int column ) {
			ValidColumn( column );
			return board[row , column];
		}

		/// <summary>
		/// Gets the open row.
		/// </summary>
		/// <param name="column">The column to look for the open row.</param>
		/// <returns>an integer representing the open row</returns>
		/// <exception cref="InvalidOperationException">Cannot find an open row on full column</exception>
		public int GetOpenRow( int column ) {
			ValidColumn( column );
			for ( int i = 0; i < NumRows; ++i ) {
				if ( board[i , column] == CircleState.Empty )
					return i;
			}
			throw new InvalidOperationException( "Cannot find an open row on full column" );
		}

		/// <summary>
		/// Returns whether this board is full
		/// </summary>
		/// <returns>whether this board is full</returns>
		public bool Full() {
			for ( int i = 0; i < NumColumns; ++i ) {
				if ( board[NumRows - 1 , i] == CircleState.Empty )
					return false;
			}
			return true;
		}

		/// <summary>
		/// Checks whether the specified column would be a legal move.
		/// </summary>
		/// <param name="column">The column being checked</param>
		/// <returns>
		/// whether the specified column would be a legal move.
		/// </returns>
		/// <exception cref="InvalidOperationException">Invalid column requested</exception>
		public bool Legal( int column ) {
			ValidColumn( column );
			return ( board[NumRows - 1 , column] == CircleState.Empty );
		}

		/// <summary>
		/// Adds the specified color to the specified column.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <param name="color">The color.</param>
		/// <exception cref="InvalidOperationException">Attempted to make an illegal move.</exception>
		public void Add( int column , CircleState color ) {
			for ( int i = 0; i < 6; ++i ) {
				ValidColumn( column );
				if ( board[i , column] == CircleState.Empty ) {
					board[i , column] = color;
					return;
				}
			}
			throw new InvalidOperationException( "Attempted to make an illegal move." );

		}

		/// <summary>
		/// Removes the top element on the specified column.
		/// </summary>
		/// <param name="column">The column.</param>
		public void Remove( int column ) {
			ValidColumn( column );
			int row = GetOpenRow( column );

			row--;
			
			if ( row >= 0 )
				board[row , column] = CircleState.Empty;
		}

		/// <summary>
		/// Resets the board.
		/// </summary>
		public void ResetBoard() {
			for ( int i = 0; i < NumRows; ++i ) {
				for ( int j = 0; j < NumColumns; ++j ) {
					board[i , j] = CircleState.Empty;
				}
			}
		}

		private void ValidColumn(int column) {
			if ( column <= 0 || column >= NumColumns )
				throw new InvalidOperationException( "Invalid column requested" );
		}
	}
}