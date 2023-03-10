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

namespace Fixture17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Fixture f = null;

        public MainWindow()
        {
            InitializeComponent();

            Club.Initialise();
            Matchup.Initialise();
            Fixture.Initialise();
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            f = new Fixture(Convert.ToInt32(roundsText.Text));

            DisplayFixture();
        }

        private void improveButton_Click(object sender, RoutedEventArgs e)
        {
            while (f.NumberUnscheduled > Convert.ToInt32(targetText.Text))
                f.ImproveRandom();
            Console.Beep();

            DisplayFixture();
        }

        private void byeButton_Click(object sender, RoutedEventArgs e)
        {
            f.RemoveExtras();

            DisplayFixture();
        }

        private void balanceButton_Click(object sender, RoutedEventArgs e)
        {
            f.BalanceHomeAway();

            DisplayFixture();
        }

        private void DisplayFixture()
        {
            outputText.Text = f.ToString();
            fixtureCSV.Text = f.ToCSV();

            errorsLabel.Content = f.NumberUnscheduled.ToString() + " unscheduled";
            problemData.ItemsSource = null;
            problemData.ItemsSource = f.Fixtured.OrderBy(l => -Math.Abs((double)l.Count - 1.2));
        }
    }
}
