using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DTO.UnitTests
{
    /// <summary>
    /// Unit tests for the <see cref="PhongChieuDTO"/> class.
    /// </summary>
    [TestClass]
    public class PhongChieuDTOTests
    {
        /// <summary>
        /// Tests that the TinhTrangText property returns the correct Vietnamese status text
        /// based on the TinhTrang boolean property value.
        /// </summary>
        /// <param name="tinhTrang">The boolean status value to test.</param>
        /// <param name="expectedText">The expected Vietnamese status text.</param>
        [TestMethod]
        [DataRow(true, "Hoạt động")]
        [DataRow(false, "Ngừng hoạt động")]
        public void TinhTrangText_ReturnsCorrectStatusText(bool tinhTrang, string expectedText)
        {
            // Arrange
            var phongChieu = new PhongChieuDTO
            {
                TinhTrang = tinhTrang
            };

            // Act
            var result = phongChieu.TinhTrangText;

            // Assert
            Assert.AreEqual(expectedText, result);
        }

        /// <summary>
        /// Tests that ToString returns the value of TenPhong property for various string inputs.
        /// Verifies that the method correctly returns null, empty, whitespace, normal, special character, and long string values.
        /// </summary>
        /// <param name="tenPhong">The value to set for TenPhong property.</param>
        [TestMethod]
        [DataRow(null, DisplayName = "ToString with null TenPhong")]
        [DataRow("", DisplayName = "ToString with empty TenPhong")]
        [DataRow("   ", DisplayName = "ToString with whitespace TenPhong")]
        [DataRow("Phòng A1", DisplayName = "ToString with normal TenPhong")]
        [DataRow("Phòng <>&\"'@#$%", DisplayName = "ToString with special characters")]
        [DataRow("PhòngVeryLongNameWithManyCharactersToTestLongStringHandlingInTheToStringMethodImplementation123456789", DisplayName = "ToString with very long TenPhong")]
        public void ToString_WithVariousTenPhongValues_ReturnsTenPhongValue(string? tenPhong)
        {
            // Arrange
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = tenPhong!,
                SoCho = 100,
                TinhTrang = true
            };

            // Act
            var result = phongChieu.ToString();

            // Assert
            Assert.AreEqual(tenPhong, result);
        }
    }
}