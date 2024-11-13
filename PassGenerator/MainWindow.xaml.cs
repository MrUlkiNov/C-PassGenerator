using System;
using System.Text;
using System.Windows;

namespace GreekPasswordGenerator
{
    public partial class MainWindow : Window
    {
        private readonly char[] greekLetters = new char[]
        {
            'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω'
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GeneratePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PasswordLengthTextBox.Text, out int length) && length > 0)
            {
                PasswordTextBox.Text = GeneratePassword(length);
            }
            else
            {
                MessageBox.Show("Please enter a valid password length.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string GeneratePassword(int length)
        {
            var random = new Random();
            var password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char randomChar = greekLetters[random.Next(greekLetters.Length)];
                password.Append(randomChar);
            }

            return password.ToString();
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(PasswordTextBox.Text);
            MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
