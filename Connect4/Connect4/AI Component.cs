using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Connect4
{
	/// <summary>
	/// Component that contains the logic the AI uses when making a decision.
	/// </summary>
	class AI_Component
	{
		/// <summary>
		/// The color the AI will assume it is when determining what move to make.
		/// </summary>
		private CircleState color;

		/// <summary>
		/// The game board the AI will be choosing a move for.
		/// </summary>
		private GameBoard board;

		/// <summary>
		/// Used to make a random choice if all other AI paths don't provide a definitive choice.
		/// </summary>
		private Random r = new Random();

		/// <summary>
		/// Initializes a new instance of the <see cref="AI_Component" /> class.
		/// </summary>
		/// <param name="color">The color the AI will test as.</param>
		/// <param name="board">The game board the AI will be choosing a move for.</param>
		/// <exception cref="InvalidOperationException">AI circles cannot be represented by the empty state</exception>
		public AI_Component( CircleState color, GameBoard board ) {
			if ( color == CircleState.Empty )
				throw new InvalidOperationException( "AI circles cannot be represented by the empty state" );
			this.color = color;
			this.board = board;
		}

		/// <summary>
		/// Chooses the move.
		/// </summary>
		/// <returns>
		/// The column of the move the AI has chosen
		/// </returns>
		/// <exception cref="InvalidOperationException">AI cannot decide a move if the board is full</exception>
		public int ChooseMove() {

			//Get available move options.
			List<int> choices = new List<int>();
			for ( int i = 0; i < GameBoard.NumColumns; ++i ) {
				if ( board.Legal( i ) )
					choices.Add( i );
			}
			if ( choices.Count == 0 )
				throw new InvalidOperationException( "AI cannot decide a move if the board is full" );

			//Check if AI can win with the next move
			foreach ( int i in choices ) {
				if ( WillWin( i , color ) )
					return i;
			}

			//Next we check if AI's opponent can win with their next move, this can't be together in one loop with checking 
			//if AI can win because there is the possible situation where there's a potential for the AI to win in a later 
			//column as where the opponent can win. 
			foreach ( int i in choices ) {
				if ( WillWin( i , ( color == CircleState.Blue ? CircleState.Red : CircleState.Blue ) ) )
					return i;
			}

			//Next we check if AI can make a move such that it guarantees a win by making 2 or more possible next moves win
			foreach ( int i in choices ) {
				if ( TwoWayWin( i , color, choices ) )
					return i;
			}

			//Otherwise return a random legal move.
			int randomNumber;
			randomNumber = r.Next( choices.Count );
			return choices[randomNumber];
		}

		/// <summary>
		/// Updates the board when the AI is expected to work on a new board.
		/// </summary>
		/// <param name="board">The game board to update the AI with.</param>
		public void UpdateBoard( GameBoard board ) {
			this.board = board;
		}

		/// <summary>
		/// Determines whether the AI could win by choosing the given column
		/// </summary>
		/// <param name="column">The column the AI is testing.</param>
		/// <param name="color">The color the AI will test as</param>
		/// <returns>
		/// whether the AI could win by choosing the given column
		/// </returns>
		private bool WillWin( int column, CircleState color ) {
			if ( VerticalTest( column , color ) || HorizontalTest( column , color ) || DiagonalTest( column , color ) )
				return true;
			return false;
		}

		/// <summary>
		/// Determines whether the AI could win by a vertical line.
		/// </summary>
		/// <param name="column">The column the AI is testing.</param>
		/// <param name="color">The color the AI will test as.</param>
		/// <returns>
		/// whether the AI could win by a vertical line.
		/// </returns>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		private bool VerticalTest( int column , CircleState color ) {

			int linedUp = 0;
			int row = board.GetOpenRow( column );

			CircleState[] columnList = board.GetColumn( column );

			for ( int i = ( row - 1 ); i >= 0; --i ) {
				if ( columnList[i] == color )
					linedUp++;
				else
					break;
			}

			return ( linedUp >= 3 );
		}


		/// <summary>
		/// Tests whether the AI could win with a horizontal line.
		/// </summary>
		/// <param name="column">The column the AI is testing.</param>
		/// <param name="color">The color the AI will test as.</param>
		/// <returns>
		/// Whether the AI could win with a horizontal line.
		/// </returns>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		private bool HorizontalTest( int column , CircleState color ) {

			int linedUp = 0;
			int row = board.GetOpenRow( column );

			CircleState[] rowList = board.GetRow( row );

			for ( int i = ( column + 1 ); i < GameBoard.NumColumns; ++i ) {
				if ( board.GetElement( row , i ) == color )
					linedUp++;
				else
					break;
			}

			for ( int i = ( column - 1 ); i >= 0; --i ) {
				if ( rowList[i] == color ) // rowList[i]
					linedUp++;
				else
					break;
			}

			return ( linedUp >= 3 );
		}

		/// <summary>
		/// Tests whether the AI could win with a diagonal line.
		/// </summary>
		/// <param name="column">The column the AI is testing.</param>
		/// <param name="color">The color the AI will test as.</param>
		/// <returns>
		/// whether the AI could win wiht a diagonal line.
		/// </returns>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		private bool DiagonalTest( int column , CircleState color ) {
			int linedUp1 = 0;
			int linedUp2 = 0;
			int row = board.GetOpenRow( column );

			int i = row + 1, j = column + 1;
			for ( ; i < GameBoard.NumRows && j < GameBoard.NumColumns; ++i, ++j ) {
				if ( board.GetElement( i , j ) == color )
					linedUp1++;
				else
					break;
			}

			i = row - 1;
			j = column - 1;
			for ( ; i >= 0 && j >= 0; --i, --j ) {
				if ( board.GetElement( i , j ) == color )
					linedUp1++;
				else
					break;
			}

			i = row + 1;
			j = column - 1;
			for ( ; i < GameBoard.NumRows && j >= 0; ++i, --j ) {
				if ( board.GetElement( i , j ) == color )
					linedUp2++;
				else
					break;
			}

			i = row - 1;
			j = column + 1;
			for ( ; i >= 0 && j < GameBoard.NumColumns; --i, ++j ) {
				if ( board.GetElement( i , j ) == color )
					linedUp2++;
				else
					break;
			}

			return ( linedUp1 >= 3 || linedUp2 >= 3 );
		}

		/// <summary>
		/// Tests whether the AI could win by creating a situation where it has two ways of winning.
		/// </summary>
		/// <param name="column">The column the AI is testing.</param>
		/// <param name="color">The color the AI will test as.</param>
		/// <param name="choices">The list of choices available to the AI to make.</param>
		/// <returns>
		/// whether the AI could win by creating a situation where it has two ways of winning.
		/// </returns>
		private bool TwoWayWin( int column , CircleState color , List<int> choices ) {

			int potentialWins = 0;
			int row = board.GetOpenRow( column );

			board.Add( column , color );

			foreach ( int i in choices ) {
				if ( WillWin( i , color ) )
					++potentialWins;
			}

			board.Remove( column );

			return ( potentialWins >= 2 );
		}
	}
}

