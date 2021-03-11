using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TowersofHanoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<List<Button>> buttons;
        private Game game;

        public MainWindow()
        {
            InitializeComponent();

            game = new Game();
            buttons = new List<List<Button>>();

            for(int i = 2; i >= 0; i--) {
                buttons.Add(new List<Button>());

                Button button = new Button();
                button.Content = i + 1;

                Grid.SetRow(button, i);
                Grid.SetColumn(button, 0);
                mainGrid.Children.Add(button);

                buttons[0].Add(button);
            }

            Draw();
        }

        public async void Draw() {
            foreach(Tuple<int, int> move in game.moves) {
                await Task.Delay(1000);
                Button m = buttons[move.Item1][buttons[move.Item1].Count - 1];
                buttons[move.Item2].Add(m);
                buttons[move.Item1].Remove(m);

                Grid.SetRow(m, buttons[move.Item2].Count == 1 ? 2 : buttons[move.Item2].Count == 3 ? 0 : 1);
                Grid.SetColumn(m, move.Item2);
            }
        }
    }
}
