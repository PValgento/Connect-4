using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Connect4
{
	/// <summary>
	/// Interaction logic for GamePlayingPage.xaml
	/// </summary>
	public partial class GamePlayingPage : Page
	{
		GameBoard board = new GameBoard();

		String[] names;
		bool[] AI;

		public GamePlayingPage( String[] names, bool[] AI ) {
			InitializeComponent();

			this.names = names;
			this.AI = AI;
		}
	}
}
