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
	/// Interaction logic for NewGameSubMenuPage.xaml
	/// </summary>
	public partial class NewGameSubMenuPage : Page
	{
		bool[] AI = { false , false };
		String[] playerName = { "Player 1" , "Player 2" };

		public NewGameSubMenuPage() {
			InitializeComponent();
		}

		private void Btn_StartGame_Click( object sender , RoutedEventArgs e ) {
			playerName[0] = Txtb_Player1Name.Text;
			playerName[1] = Txtb_Player2Name.Text;
			AI[0] = ( ChBx_AIPlayer1.IsChecked == true );
			AI[1] = ( ChBx_AIPlayer2.IsChecked == true );

			this.NavigationService.Navigate( new GamePlayingPage( playerName, AI) );
		}
	}
}
