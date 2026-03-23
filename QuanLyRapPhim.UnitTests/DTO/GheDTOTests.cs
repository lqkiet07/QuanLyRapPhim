using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DTO.UnitTests
{
    /// <summary>
    /// Unit tests for the GheDTO class.
    /// </summary>
    [TestClass]
    public class GheDTOTests
    {
        /// <summary>
        /// Tests that MaGhe returns the correct concatenated value of Hang and So.
        /// </summary>
        /// <param name="hang">The row identifier.</param>
        /// <param name="so">The seat number.</param>
        /// <param name="expected">The expected MaGhe value.</param>
        [TestMethod]
        [DataRow("A", 1, "A1", DisplayName = "MaGhe with single letter row and single digit number")]
        [DataRow("A", 10, "A10", DisplayName = "MaGhe with single letter row and double digit number")]
        [DataRow("B", 99, "B99", DisplayName = "MaGhe with different row and two digit number")]
        [DataRow("AA", 5, "AA5", DisplayName = "MaGhe with multi-character row")]
        [DataRow("ABC", 123, "ABC123", DisplayName = "MaGhe with long row identifier")]
        [DataRow("", 5, "5", DisplayName = "MaGhe with empty string row")]
        [DataRow(" ", 5, " 5", DisplayName = "MaGhe with whitespace row")]
        [DataRow("  ", 10, "  10", DisplayName = "MaGhe with multiple whitespace row")]
        [DataRow("@", 1, "@1", DisplayName = "MaGhe with special character row")]
        [DataRow("A*", 2, "A*2", DisplayName = "MaGhe with row containing special character")]
        [DataRow("1", 5, "15", DisplayName = "MaGhe with numeric row identifier")]
        public void MaGhe_WithVariousHangAndSoValues_ReturnsCorrectConcatenation(string? hang, int so, string expected)
        {
            // Arrange
            var ghe = new GheDTO
            {
                Hang = hang!,
                So = so
            };

            // Act
            var result = ghe.MaGhe;

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that MaGhe handles null Hang correctly by treating it as empty string.
        /// </summary>
        [TestMethod]
        public void MaGhe_WithNullHang_ReturnsSeatNumberOnly()
        {
            // Arrange
            var ghe = new GheDTO
            {
                Hang = null!,
                So = 5
            };

            // Act
            var result = ghe.MaGhe;

            // Assert
            Assert.AreEqual("5", result);
        }

        /// <summary>
        /// Tests that MaGhe handles boundary values for the So property correctly.
        /// </summary>
        /// <param name="so">The seat number boundary value.</param>
        /// <param name="expected">The expected MaGhe value.</param>
        [TestMethod]
        [DataRow(0, "A0", DisplayName = "MaGhe with So equal to zero")]
        [DataRow(-1, "A-1", DisplayName = "MaGhe with negative So")]
        [DataRow(-100, "A-100", DisplayName = "MaGhe with large negative So")]
        [DataRow(2147483647, "A2147483647", DisplayName = "MaGhe with So equal to int.MaxValue")]
        [DataRow(-2147483648, "A-2147483648", DisplayName = "MaGhe with So equal to int.MinValue")]
        public void MaGhe_WithBoundarySoValues_ReturnsCorrectConcatenation(int so, string expected)
        {
            // Arrange
            var ghe = new GheDTO
            {
                Hang = "A",
                So = so
            };

            // Act
            var result = ghe.MaGhe;

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that MaGhe handles very long Hang strings correctly.
        /// </summary>
        [TestMethod]
        public void MaGhe_WithVeryLongHangString_ReturnsCorrectConcatenation()
        {
            // Arrange
            var longHang = new string('X', 1000);
            var ghe = new GheDTO
            {
                Hang = longHang,
                So = 42
            };

            // Act
            var result = ghe.MaGhe;

            // Assert
            Assert.AreEqual(longHang + "42", result);
            Assert.AreEqual(1002, result.Length);
        }

        /// <summary>
        /// Tests that MaGhe handles Hang with Unicode characters correctly.
        /// </summary>
        [TestMethod]
        [DataRow("Ä", 1, "Ä1", DisplayName = "MaGhe with accented character")]
        [DataRow("行", 5, "行5", DisplayName = "MaGhe with Chinese character")]
        [DataRow("א", 10, "א10", DisplayName = "MaGhe with Hebrew character")]
        [DataRow("😀", 3, "😀3", DisplayName = "MaGhe with emoji")]
        public void MaGhe_WithUnicodeCharactersInHang_ReturnsCorrectConcatenation(string hang, int so, string expected)
        {
            // Arrange
            var ghe = new GheDTO
            {
                Hang = hang,
                So = so
            };

            // Act
            var result = ghe.MaGhe;

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests ToString method returns the correct seat code (MaGhe) for various combinations of Hang and So values.
        /// Verifies normal cases, empty strings, whitespace, and boundary integer values.
        /// Expected result is the concatenation of Hang and So (e.g., "A5").
        /// </summary>
        [TestMethod]
        [DataRow("A", 1, "A1")]
        [DataRow("B", 10, "B10")]
        [DataRow("Z", 0, "Z0")]
        [DataRow("", 5, "5")]
        [DataRow("AA", 100, "AA100")]
        [DataRow(" ", 1, " 1")]
        [DataRow("X", -1, "X-1")]
        [DataRow("Y", int.MaxValue, "Y2147483647")]
        [DataRow("Z", int.MinValue, "Z-2147483648")]
        [DataRow("ABC", 999, "ABC999")]
        [DataRow("\t", 2, "\t2")]
        [DataRow("  ", 3, "  3")]
        public void ToString_VariousHangAndSoValues_ReturnsCorrectMaGhe(string hang, int so, string expected)
        {
            // Arrange
            var ghe = new GheDTO { Hang = hang, So = so };

            // Act
            string result = ghe.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests ToString method when Hang property is null.
        /// Expected result is the So value converted to string (e.g., "5").
        /// </summary>
        [TestMethod]
        [DataRow(0, "0")]
        [DataRow(1, "1")]
        [DataRow(5, "5")]
        [DataRow(-10, "-10")]
        [DataRow(int.MaxValue, "2147483647")]
        [DataRow(int.MinValue, "-2147483648")]
        public void ToString_NullHang_ReturnsSoAsString(int so, string expected)
        {
            // Arrange
            var ghe = new GheDTO { Hang = null!, So = so };

            // Act
            string result = ghe.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests ToString method with special characters in Hang property.
        /// Verifies that special characters are properly concatenated with So value.
        /// Expected result is the special character followed by So value.
        /// </summary>
        [TestMethod]
        [DataRow("@", 1, "@1")]
        [DataRow("#", 2, "#2")]
        [DataRow("$", 3, "$3")]
        [DataRow("*", 0, "*0")]
        [DataRow("!", -5, "!-5")]
        [DataRow("%", int.MaxValue, "%2147483647")]
        public void ToString_SpecialCharactersInHang_ReturnsCorrectMaGhe(string hang, int so, string expected)
        {
            // Arrange
            var ghe = new GheDTO { Hang = hang, So = so };

            // Act
            string result = ghe.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests ToString method with very long Hang string.
        /// Verifies that long strings are properly handled and concatenated with So value.
        /// Expected result is the full long string followed by So value.
        /// </summary>
        [TestMethod]
        public void ToString_VeryLongHang_ReturnsCorrectMaGhe()
        {
            // Arrange
            string longHang = new string('A', 1000);
            string expected = longHang + "123";
            var ghe = new GheDTO { Hang = longHang, So = 123 };

            // Act
            string result = ghe.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}