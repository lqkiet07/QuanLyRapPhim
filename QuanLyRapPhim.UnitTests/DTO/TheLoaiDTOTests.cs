using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim;
using QuanLyRapPhim.DTO;
using System;


namespace QuanLyRapPhim.DTO.UnitTests
{
    [TestClass]
    public class TheLoaiDTOTests
    {
        /// <summary>
        /// Tests that ToString returns the value of TenTheLoai property for various string inputs.
        /// Verifies that the method correctly returns normal strings, empty strings, whitespace, and special characters.
        /// </summary>
        /// <param name="tenTheLoai">The value to set for TenTheLoai property.</param>
        [TestMethod]
        [DataRow("Action")]
        [DataRow("Comedy")]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("Horror/Thriller")]
        [DataRow("Sci-Fi & Fantasy")]
        [DataRow("ホラー")]
        [DataRow("This is a very long genre name that might be used in some edge cases to test the behavior of the ToString method with lengthy strings")]
        public void ToString_WithValidStringValue_ReturnsStringValue(string tenTheLoai)
        {
            // Arrange
            var theLoai = new TheLoaiDTO { TenTheLoai = tenTheLoai };

            // Act
            var result = theLoai.ToString();

            // Assert
            Assert.AreEqual(tenTheLoai, result);
        }

        /// <summary>
        /// Tests that ToString returns null when TenTheLoai property is null.
        /// Verifies that the method does not throw an exception and correctly returns null.
        /// </summary>
        [TestMethod]
        public void ToString_WhenTenTheLoaiIsNull_ReturnsNull()
        {
            // Arrange
            var theLoai = new TheLoaiDTO { TenTheLoai = null! };

            // Act
            var result = theLoai.ToString();

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Tests that ToString returns the correct value when Id is set along with TenTheLoai.
        /// Verifies that the ToString method only depends on TenTheLoai and ignores the Id property.
        /// </summary>
        [TestMethod]
        public void ToString_WithIdAndTenTheLoaiSet_ReturnsTenTheLoaiOnly()
        {
            // Arrange
            var theLoai = new TheLoaiDTO
            {
                Id = 42,
                TenTheLoai = "Drama"
            };

            // Act
            var result = theLoai.ToString();

            // Assert
            Assert.AreEqual("Drama", result);
        }
    }
}