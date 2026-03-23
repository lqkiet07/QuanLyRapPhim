using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DTO.UnitTests
{
    [TestClass]
    public class NhanVienDTOTests
    {
        /// <summary>
        /// Tests that ToString returns null when HoTen is null.
        /// Input: HoTen is null.
        /// Expected: ToString returns null.
        /// </summary>
        [TestMethod]
        public void ToString_WhenHoTenIsNull_ReturnsNull()
        {
            // Arrange
            var nhanVien = new NhanVienDTO
            {
                HoTen = null!
            };

            // Act
            var result = nhanVien.ToString();

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Tests that ToString returns the exact value of HoTen for various string inputs.
        /// Input: Various string values for HoTen including empty, whitespace, normal, and special characters.
        /// Expected: ToString returns the exact HoTen value.
        /// </summary>
        [TestMethod]
        [DataRow("", DisplayName = "Empty string")]
        [DataRow(" ", DisplayName = "Single space")]
        [DataRow("   ", DisplayName = "Multiple spaces")]
        [DataRow("\t", DisplayName = "Tab character")]
        [DataRow("\n", DisplayName = "Newline character")]
        [DataRow("\r\n", DisplayName = "Carriage return and newline")]
        [DataRow("Nguyen Van A", DisplayName = "Normal Vietnamese name")]
        [DataRow("John Doe", DisplayName = "Normal English name")]
        [DataRow("A", DisplayName = "Single character")]
        [DataRow("Nguyễn Văn Á", DisplayName = "Name with Vietnamese diacritics")]
        [DataRow("Test@#$%^&*()", DisplayName = "Name with special characters")]
        [DataRow("Test\nMultiline\nName", DisplayName = "Name with newlines")]
        [DataRow("   Leading and trailing spaces   ", DisplayName = "Name with leading and trailing spaces")]
        [DataRow("Test\0Null", DisplayName = "Name with null character")]
        [DataRow("🙂😀", DisplayName = "Name with emojis")]
        public void ToString_WithVariousHoTenValues_ReturnsExactHoTenValue(string hoTen)
        {
            // Arrange
            var nhanVien = new NhanVienDTO
            {
                HoTen = hoTen
            };

            // Act
            var result = nhanVien.ToString();

            // Assert
            Assert.AreEqual(hoTen, result);
        }

        /// <summary>
        /// Tests that ToString returns the full string when HoTen is very long.
        /// Input: Very long string (1000 characters).
        /// Expected: ToString returns the complete long string.
        /// </summary>
        [TestMethod]
        public void ToString_WhenHoTenIsVeryLong_ReturnsFullString()
        {
            // Arrange
            var longName = new string('A', 1000);
            var nhanVien = new NhanVienDTO
            {
                HoTen = longName
            };

            // Act
            var result = nhanVien.ToString();

            // Assert
            Assert.AreEqual(longName, result);
            Assert.AreEqual(1000, result.Length);
        }

        /// <summary>
        /// Tests that ToString returns HoTen value regardless of other properties.
        /// Input: NhanVienDTO with all properties set, including different IdLoai values.
        /// Expected: ToString returns only HoTen value, ignoring other properties.
        /// </summary>
        [TestMethod]
        [DataRow(1, DisplayName = "IdLoai = 1 (Manager)")]
        [DataRow(2, DisplayName = "IdLoai = 2 (Non-manager)")]
        [DataRow(0, DisplayName = "IdLoai = 0")]
        [DataRow(-1, DisplayName = "IdLoai = -1")]
        [DataRow(int.MaxValue, DisplayName = "IdLoai = MaxValue")]
        public void ToString_WithAllPropertiesSet_ReturnsOnlyHoTen(int idLoai)
        {
            // Arrange
            var expectedHoTen = "Test Employee";
            var nhanVien = new NhanVienDTO
            {
                Id = 123,
                HoTen = expectedHoTen,
                TaiKhoan = "testuser",
                MatKhau = "password123",
                IdLoai = idLoai,
                TenLoaiNV = "Manager"
            };

            // Act
            var result = nhanVien.ToString();

            // Assert
            Assert.AreEqual(expectedHoTen, result);
        }

        /// <summary>
        /// Tests the IsQuanLy property returns the correct value based on IdLoai.
        /// When IdLoai equals 1, IsQuanLy should return true.
        /// For all other IdLoai values, IsQuanLy should return false.
        /// </summary>
        /// <param name="idLoai">The IdLoai value to test.</param>
        /// <param name="expectedIsQuanLy">The expected result of the IsQuanLy property.</param>
        [TestMethod]
        [DataRow(1, true, DisplayName = "IsQuanLy returns true when IdLoai equals 1")]
        [DataRow(0, false, DisplayName = "IsQuanLy returns false when IdLoai is 0")]
        [DataRow(2, false, DisplayName = "IsQuanLy returns false when IdLoai is 2")]
        [DataRow(-1, false, DisplayName = "IsQuanLy returns false when IdLoai is -1")]
        [DataRow(int.MinValue, false, DisplayName = "IsQuanLy returns false when IdLoai is int.MinValue")]
        [DataRow(int.MaxValue, false, DisplayName = "IsQuanLy returns false when IdLoai is int.MaxValue")]
        public void IsQuanLy_VariousIdLoaiValues_ReturnsExpectedResult(int idLoai, bool expectedIsQuanLy)
        {
            // Arrange
            var nhanVien = new NhanVienDTO
            {
                IdLoai = idLoai
            };

            // Act
            bool actualIsQuanLy = nhanVien.IsQuanLy;

            // Assert
            Assert.AreEqual(expectedIsQuanLy, actualIsQuanLy);
        }
    }
}