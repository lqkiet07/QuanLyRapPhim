using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DTO;
using System;


namespace QuanLyRapPhim.DTO.UnitTests
{
    [TestClass]
    public class LoaiNVDTOTests
    {
        /// <summary>
        /// Tests that ToString returns the value of TenLoaiNV property for various input conditions.
        /// Input conditions: null, empty string, whitespace, normal value, special characters, and long strings.
        /// Expected result: ToString returns exactly the same value as TenLoaiNV property.
        /// </summary>
        [TestMethod]
        [DataRow(null, null, DisplayName = "Null TenLoaiNV returns null")]
        [DataRow("", "", DisplayName = "Empty TenLoaiNV returns empty string")]
        [DataRow("   ", "   ", DisplayName = "Whitespace TenLoaiNV returns whitespace")]
        [DataRow(" ", " ", DisplayName = "Single space TenLoaiNV returns single space")]
        [DataRow("Manager", "Manager", DisplayName = "Normal TenLoaiNV returns value")]
        [DataRow("Nhân Viên Bán Vé", "Nhân Viên Bán Vé", DisplayName = "TenLoaiNV with Vietnamese characters returns value")]
        [DataRow("Quản Lý", "Quản Lý", DisplayName = "TenLoaiNV with accented characters returns value")]
        [DataRow("Admin@#$%", "Admin@#$%", DisplayName = "TenLoaiNV with special characters returns value")]
        [DataRow("This is a very long employee type name that might be used to test the maximum length handling in the system and ensure it works correctly", "This is a very long employee type name that might be used to test the maximum length handling in the system and ensure it works correctly", DisplayName = "Very long TenLoaiNV returns value")]
        [DataRow("\t\n\r", "\t\n\r", DisplayName = "TenLoaiNV with control characters returns value")]
        public void ToString_VariousTenLoaiNVValues_ReturnsExpectedValue(string? tenLoaiNV, string? expected)
        {
            // Arrange
            var loaiNV = new LoaiNVDTO { TenLoaiNV = tenLoaiNV };

            // Act
            var result = loaiNV.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}