using System;
using System.Text;

namespace GreekPasswordGenerator
{
    public class PasswordGenerator
    {
        private static readonly char[] GreekLetters = new char[]
        {
            'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω'
        };

        public string GeneratePassword(int length)
        {
            if (length <= 0)
                throw new ArgumentException("Password length must be greater than 0");

            var random = new Random();
            var password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char randomChar = GreekLetters[random.Next(GreekLetters.Length)];
                password.Append(randomChar);
            }

            return password.ToString();
        }
    }
}
