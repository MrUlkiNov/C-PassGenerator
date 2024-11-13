using System;
using Xunit;
using GreekPasswordGenerator;

namespace GreekPasswordGenerator.Tests
{
    public class PasswordGeneratorTests
    {
        private readonly PasswordGenerator _passwordGenerator;

        public PasswordGeneratorTests()
        {
            _passwordGenerator = new PasswordGenerator();
        }

        [Fact]
        public void GeneratePassword_WithValidLength_ReturnsCorrectLengthPassword()
        {
            // Arrange
            int length = 10;

            // Act
            var password = _passwordGenerator.GeneratePassword(length);

            // Assert
            Assert.Equal(length, password.Length);
        }

        [Fact]
        public void GeneratePassword_WithZeroOrNegativeLength_ThrowsArgumentException()
        {
            // Arrange
            int length = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _passwordGenerator.GeneratePassword(length));
        }

        [Fact]
        public void GeneratePassword_ContainsOnlyGreekLetters()
        {
            // Arrange
            int length = 10;
            var greekLetters = "αβγδεζηθικλμνξοπρστυφχψω";

            // Act
            var password = _passwordGenerator.GeneratePassword(length);

            // Assert
            foreach (var character in password)
            {
                Assert.Contains(character.ToString(), greekLetters);
            }
        }

        [Fact]
        public void GeneratePassword_DifferentInvocations_ReturnsDifferentPasswords()
        {
            // Arrange
            int length = 10;

            // Act
            var password1 = _passwordGenerator.GeneratePassword(length);
            var password2 = _passwordGenerator.GeneratePassword(length);

            // Assert
            Assert.NotEqual(password1, password2);
        }
    }
}
