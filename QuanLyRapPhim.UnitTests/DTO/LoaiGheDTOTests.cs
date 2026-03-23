using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim;
using QuanLyRapPhim.DTO;
using System;


namespace QuanLyRapPhim.DTO.UnitTests
{
    /// <summary>
    /// Unit tests for the LoaiGheDTO class.
    /// </summary>
    [TestClass]
    public class LoaiGheDTOTests
    {
        /// <summary>
        /// Tests that ToString returns the value of TenLoai property when TenLoai has a valid string value.
        /// </summary>
        /// <param name="tenLoai">The value to set for TenLoai property.</param>
        [TestMethod]
        [DataRow("VIP")]
        [DataRow("Thường")]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("!@#$%^&*()")]
        [DataRow("Ghế VVIP với ký tự đặc biệt: @#$")]
        [DataRow("A very long string that represents a seat type name with many characters to test the behavior of ToString method with extremely long input values")]
        public void ToString_WithVariousStringValues_ReturnsTenLoaiValue(string tenLoai)
        {
            // Arrange
            var loaiGhe = new LoaiGheDTO
            {
                Id = 1,
                TenLoai = tenLoai,
                PhuPhi = 10000m
            };

            // Act
            var result = loaiGhe.ToString();

            // Assert
            Assert.AreEqual(tenLoai, result);
        }

        /// <summary>
        /// Tests that ToString returns null when TenLoai property is null.
        /// </summary>
        [TestMethod]
        public void ToString_WhenTenLoaiIsNull_ReturnsNull()
        {
            // Arrange
            var loaiGhe = new LoaiGheDTO
            {
                Id = 1,
                TenLoai = null,
                PhuPhi = 10000m
            };

            // Act
            var result = loaiGhe.ToString();

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Tests that ToString returns TenLoai value regardless of other property values.
        /// </summary>
        [TestMethod]
        [DataRow(0, "Standard", 0)]
        [DataRow(-1, "Premium", -100.50)]
        [DataRow(int.MaxValue, "Deluxe", 999999.99)]
        [DataRow(int.MinValue, "Economy", -999999.99)]
        public void ToString_WithVariousPropertyValues_ReturnsTenLoaiOnly(int id, string tenLoai, double phuPhi)
        {
            // Arrange
            var loaiGhe = new LoaiGheDTO
            {
                Id = id,
                TenLoai = tenLoai,
                PhuPhi = (decimal)phuPhi
            };

            // Act
            var result = loaiGhe.ToString();

            // Assert
            Assert.AreEqual(tenLoai, result);
        }
    }
}