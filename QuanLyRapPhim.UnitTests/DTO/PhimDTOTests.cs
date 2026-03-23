using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DTO;
using System;


namespace QuanLyRapPhim.DTO.UnitTests
{
    [TestClass]
    public class PhimDTOTests
    {
        /// <summary>
        /// Tests that ToString returns the value of TenPhim property for various input conditions.
        /// </summary>
        /// <param name="tenPhim">The value to assign to TenPhim property.</param>
        /// <param name="expected">The expected return value from ToString.</param>
        [TestMethod]
        [DataRow(null, null, DisplayName = "ToString_WhenTenPhimIsNull_ReturnsNull")]
        [DataRow("", "", DisplayName = "ToString_WhenTenPhimIsEmpty_ReturnsEmpty")]
        [DataRow(" ", " ", DisplayName = "ToString_WhenTenPhimIsWhitespace_ReturnsWhitespace")]
        [DataRow("   ", "   ", DisplayName = "ToString_WhenTenPhimIsMultipleWhitespaces_ReturnsMultipleWhitespaces")]
        [DataRow("Avatar", "Avatar", DisplayName = "ToString_WhenTenPhimIsNormalString_ReturnsTenPhim")]
        [DataRow("The Lord of the Rings: The Fellowship of the Ring", "The Lord of the Rings: The Fellowship of the Ring", DisplayName = "ToString_WhenTenPhimIsLongString_ReturnsTenPhim")]
        [DataRow("Phim!@#$%^&*()", "Phim!@#$%^&*()", DisplayName = "ToString_WhenTenPhimContainsSpecialCharacters_ReturnsTenPhim")]
        [DataRow("Phim\tTab\nNewLine", "Phim\tTab\nNewLine", DisplayName = "ToString_WhenTenPhimContainsControlCharacters_ReturnsTenPhim")]
        [DataRow("Phim 123 456", "Phim 123 456", DisplayName = "ToString_WhenTenPhimContainsNumbers_ReturnsTenPhim")]
        [DataRow("Phim Tiếng Việt", "Phim Tiếng Việt", DisplayName = "ToString_WhenTenPhimContainsUnicodeCharacters_ReturnsTenPhim")]
        public void ToString_VariousInputs_ReturnsExpectedValue(string? tenPhim, string? expected)
        {
            // Arrange
            var phimDto = new PhimDTO
            {
                TenPhim = tenPhim
            };

            // Act
            var result = phimDto.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that ToString returns TenPhim even when other properties are set to various values.
        /// Verifies that ToString only depends on TenPhim and ignores other properties.
        /// </summary>
        [TestMethod]
        public void ToString_WhenOtherPropertiesAreSet_ReturnsTenPhimOnly()
        {
            // Arrange
            var phimDto = new PhimDTO
            {
                Id = 1,
                TenPhim = "Test Movie",
                ThoiLuong = 120.5,
                NgayKhoiChieu = new DateTime(2024, 1, 1),
                NgayKetThuc = new DateTime(2024, 12, 31),
                DaoDien = "Test Director",
                IdTheLoai = 5,
                TenTheLoai = "Action"
            };

            // Act
            var result = phimDto.ToString();

            // Assert
            Assert.AreEqual("Test Movie", result);
        }

        /// <summary>
        /// Tests that ToString returns updated value when TenPhim is modified after object creation.
        /// Verifies that ToString reflects the current state of TenPhim property.
        /// </summary>
        [TestMethod]
        public void ToString_WhenTenPhimIsModified_ReturnsUpdatedValue()
        {
            // Arrange
            var phimDto = new PhimDTO
            {
                TenPhim = "Original Title"
            };
            phimDto.TenPhim = "Updated Title";

            // Act
            var result = phimDto.ToString();

            // Assert
            Assert.AreEqual("Updated Title", result);
        }
    }
}