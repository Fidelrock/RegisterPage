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

namespace RegisterPage
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
        // Event handler for RegisterButton click event
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the username and password entered by the user
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Check if the username and password are not null
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Display a message box indicating successful registration
                MessageBox.Show("Registration Successful");
            }
            else
            {
                // Display a message box indicating that all fields are required
                MessageBox.Show("All fields are required");
            }

        }
    }
}
