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

namespace WpfGameXO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[,] mat { get; set; } = new int[3, 3];
        public int counter { get; set; }
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = e.OriginalSource as Button;
            int row = (int)b.GetValue(Grid.RowProperty);
            int col = (int)b.GetValue(Grid.ColumnProperty);
            if(counter%2==0)
            {
                b.Content = "o";
                counter++;
                b.IsEnabled = false;
                if (counter >= 5)
                    CheckWiner(row,col);
                mat[row, col] = 2;

            }
            else
            {
                
                b.Content = "x";
                counter++;
                b.IsEnabled = false;
                if (counter >= 5)
                    CheckWiner(row,col);
                mat[row, col] = 1;
            }
        }
        public void CheckWiner(int row,int col)
        {
            int num = mat[row, col];
            if(row==0)
            {
                if (mat[row + 1, col] == num)
                    if (mat[row + 2, col] == num)
                            MessageBox.Show("you winer!!!!!!!!!👍✨✨✨✨✨✨✨");
            }
            if (col == 0)
            {
                if (mat[row , col+1] == num)
                    if (mat[row , col+2] == num)
                            MessageBox.Show("you winer!!!!!!!!!👍✨✨✨✨✨✨✨");
            }
            

        }
    }
}
