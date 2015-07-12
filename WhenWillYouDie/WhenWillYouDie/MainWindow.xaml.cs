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

namespace WhenWillYouDie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            String name = NameBox.Text;
            String year = BirthYearBox.Text;
            int birth_year = 0;
            int years_to_live = 0;
            try
            {
                birth_year = int.Parse(year);
                years_to_live = DieYearCalculator.CalculateDyingYear(name);
            }
            catch (FormatException)
            {
                result.Text = "Please enter a valid year";
                return;
            }
            catch (OverflowException)
            {
                result.Text = "Please enter a valid year";
                return;
            }
            catch (ArgumentException)
            {
                result.Text = "Please enter a valid name";
                return;
            }

            result.Text = (birth_year + years_to_live).ToString();

        }
    }
}
