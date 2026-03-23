using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DTO.UnitTests
{
    /// <summary>
    /// Contains unit tests for the <see cref="SuatChieuDTO"/> class.
    /// </summary>
    [TestClass]
    public class SuatChieuDTOTests
    {
        /// <summary>
        /// Tests that ToString returns correctly formatted string with valid values.
        /// Input: Valid TenPhim, TenPhong, and ThoiGian values.
        /// Expected: String formatted as "{TenPhim} - {TenPhong} ({ThoiGian:dd/MM/yyyy HH:mm})".
        /// </summary>
        [TestMethod]
        [DataRow("Avatar", "Phòng 1", 2024, 1, 15, 14, 30, "Avatar - Phòng 1 (15/01/2024 14:30)")]
        [DataRow("Inception", "Phòng A", 2023, 12, 31, 23, 59, "Inception - Phòng A (31/12/2023 23:59)")]
        [DataRow("The Matrix", "VIP Room", 2024, 2, 29, 0, 0, "The Matrix - VIP Room (29/02/2024 00:00)")]
        public void ToString_ValidValues_ReturnsFormattedString(string tenPhim, string tenPhong, int year, int month, int day, int hour, int minute, string expected)
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = tenPhim,
                TenPhong = tenPhong,
                ThoiGian = new DateTime(year, month, day, hour, minute, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that ToString handles null TenPhim property.
        /// Input: TenPhim is null, other properties have valid values.
        /// Expected: String with empty string for TenPhim position.
        /// </summary>
        [TestMethod]
        public void ToString_NullTenPhim_ReturnsStringWithEmptyMovieName()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = null!,
                TenPhong = "Phòng 1",
                ThoiGian = new DateTime(2024, 1, 15, 14, 30, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(" - Phòng 1 (15/01/2024 14:30)", result);
        }

        /// <summary>
        /// Tests that ToString handles null TenPhong property.
        /// Input: TenPhong is null, other properties have valid values.
        /// Expected: String with empty string for TenPhong position.
        /// </summary>
        [TestMethod]
        public void ToString_NullTenPhong_ReturnsStringWithEmptyRoomName()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = "Avatar",
                TenPhong = null!,
                ThoiGian = new DateTime(2024, 1, 15, 14, 30, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual("Avatar -  (15/01/2024 14:30)", result);
        }

        /// <summary>
        /// Tests that ToString handles both null TenPhim and TenPhong properties.
        /// Input: Both TenPhim and TenPhong are null.
        /// Expected: String with empty strings for both movie and room names.
        /// </summary>
        [TestMethod]
        public void ToString_BothNamesNull_ReturnsStringWithEmptyNames()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = null!,
                TenPhong = null!,
                ThoiGian = new DateTime(2024, 1, 15, 14, 30, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(" -  (15/01/2024 14:30)", result);
        }

        /// <summary>
        /// Tests that ToString handles empty string values.
        /// Input: TenPhim and TenPhong are empty strings.
        /// Expected: String formatted correctly with empty strings.
        /// </summary>
        [TestMethod]
        [DataRow("", "", 2024, 1, 15, 14, 30, " -  (15/01/2024 14:30)")]
        [DataRow("", "Phòng 1", 2024, 1, 15, 14, 30, " - Phòng 1 (15/01/2024 14:30)")]
        [DataRow("Avatar", "", 2024, 1, 15, 14, 30, "Avatar -  (15/01/2024 14:30)")]
        public void ToString_EmptyStrings_ReturnsFormattedString(string tenPhim, string tenPhong, int year, int month, int day, int hour, int minute, string expected)
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = tenPhim,
                TenPhong = tenPhong,
                ThoiGian = new DateTime(year, month, day, hour, minute, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that ToString handles whitespace-only strings.
        /// Input: TenPhim and TenPhong contain only whitespace.
        /// Expected: String formatted with whitespace preserved.
        /// </summary>
        [TestMethod]
        [DataRow("   ", "   ", 2024, 1, 15, 14, 30, "    -     (15/01/2024 14:30)")]
        [DataRow(" ", "Phòng 1", 2024, 1, 15, 14, 30, "  - Phòng 1 (15/01/2024 14:30)")]
        public void ToString_WhitespaceStrings_ReturnsFormattedStringWithWhitespace(string tenPhim, string tenPhong, int year, int month, int day, int hour, int minute, string expected)
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = tenPhim,
                TenPhong = tenPhong,
                ThoiGian = new DateTime(year, month, day, hour, minute, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that ToString handles DateTime.MinValue correctly.
        /// Input: ThoiGian is DateTime.MinValue (01/01/0001 00:00:00).
        /// Expected: String with correctly formatted minimum date.
        /// </summary>
        [TestMethod]
        public void ToString_DateTimeMinValue_ReturnsFormattedStringWithMinDate()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = "Avatar",
                TenPhong = "Phòng 1",
                ThoiGian = DateTime.MinValue
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual("Avatar - Phòng 1 (01/01/0001 00:00)", result);
        }

        /// <summary>
        /// Tests that ToString handles DateTime.MaxValue correctly.
        /// Input: ThoiGian is DateTime.MaxValue (31/12/9999 23:59:59).
        /// Expected: String with correctly formatted maximum date.
        /// </summary>
        [TestMethod]
        public void ToString_DateTimeMaxValue_ReturnsFormattedStringWithMaxDate()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = "Avatar",
                TenPhong = "Phòng 1",
                ThoiGian = DateTime.MaxValue
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual("Avatar - Phòng 1 (31/12/9999 23:59)", result);
        }

        /// <summary>
        /// Tests that ToString handles special characters in string properties.
        /// Input: TenPhim and TenPhong contain special characters and Unicode.
        /// Expected: String formatted correctly with special characters preserved.
        /// </summary>
        [TestMethod]
        [DataRow("Avatar: Dòng chảy của nước", "Phòng VIP-A", 2024, 1, 15, 14, 30, "Avatar: Dòng chảy của nước - Phòng VIP-A (15/01/2024 14:30)")]
        [DataRow("Film (2024)", "Room #1", 2024, 1, 15, 14, 30, "Film (2024) - Room #1 (15/01/2024 14:30)")]
        [DataRow("Test & Test", "Room@123", 2024, 1, 15, 14, 30, "Test & Test - Room@123 (15/01/2024 14:30)")]
        public void ToString_SpecialCharacters_ReturnsFormattedStringWithSpecialChars(string tenPhim, string tenPhong, int year, int month, int day, int hour, int minute, string expected)
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = tenPhim,
                TenPhong = tenPhong,
                ThoiGian = new DateTime(year, month, day, hour, minute, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that ToString handles very long strings.
        /// Input: TenPhim and TenPhong are very long strings.
        /// Expected: String formatted correctly with full length strings preserved.
        /// </summary>
        [TestMethod]
        public void ToString_VeryLongStrings_ReturnsFormattedStringWithFullStrings()
        {
            // Arrange
            var longMovieName = new string('A', 500);
            var longRoomName = new string('B', 500);
            var dto = new SuatChieuDTO
            {
                TenPhim = longMovieName,
                TenPhong = longRoomName,
                ThoiGian = new DateTime(2024, 1, 15, 14, 30, 0)
            };
            var expected = $"{longMovieName} - {longRoomName} (15/01/2024 14:30)";

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that ToString formats time correctly for midnight (00:00).
        /// Input: ThoiGian is set to midnight.
        /// Expected: Time formatted as "00:00".
        /// </summary>
        [TestMethod]
        public void ToString_Midnight_ReturnsFormattedStringWithMidnightTime()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = "Avatar",
                TenPhong = "Phòng 1",
                ThoiGian = new DateTime(2024, 1, 15, 0, 0, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual("Avatar - Phòng 1 (15/01/2024 00:00)", result);
        }

        /// <summary>
        /// Tests that ToString formats time correctly for 23:59.
        /// Input: ThoiGian is set to 23:59.
        /// Expected: Time formatted as "23:59".
        /// </summary>
        [TestMethod]
        public void ToString_LastMinuteOfDay_ReturnsFormattedStringWithCorrectTime()
        {
            // Arrange
            var dto = new SuatChieuDTO
            {
                TenPhim = "Avatar",
                TenPhong = "Phòng 1",
                ThoiGian = new DateTime(2024, 1, 15, 23, 59, 0)
            };

            // Act
            var result = dto.ToString();

            // Assert
            Assert.AreEqual("Avatar - Phòng 1 (15/01/2024 23:59)", result);
        }

        /// <summary>
        /// Tests that the MoTa property correctly returns the value of TenPhong for various input conditions.
        /// </summary>
        /// <param name="tenPhongValue">The value to assign to TenPhong.</param>
        [TestMethod]
        [DataRow(null, DisplayName = "MoTa_WhenTenPhongIsNull_ReturnsNull")]
        [DataRow("", DisplayName = "MoTa_WhenTenPhongIsEmpty_ReturnsEmpty")]
        [DataRow("   ", DisplayName = "MoTa_WhenTenPhongIsWhitespace_ReturnsWhitespace")]
        [DataRow("Phòng A", DisplayName = "MoTa_WhenTenPhongIsNormalString_ReturnsNormalString")]
        [DataRow("Phòng Chiếu 3D", DisplayName = "MoTa_WhenTenPhongContainsVietnameseCharacters_ReturnsVietnameseCharacters")]
        [DataRow("Room@#$%123", DisplayName = "MoTa_WhenTenPhongContainsSpecialCharacters_ReturnsSpecialCharacters")]
        [DataRow("ThisIsAVeryLongRoomNameThatExceedsNormalLengthExpectationsForTestingPurposesAndShouldStillBeHandledCorrectly", DisplayName = "MoTa_WhenTenPhongIsVeryLong_ReturnsVeryLongString")]
        public void MoTa_VariousInputs_ReturnsExpectedValue(string? tenPhongValue)
        {
            // Arrange
            var suatChieu = new SuatChieuDTO
            {
                TenPhong = tenPhongValue!
            };

            // Act
            var result = suatChieu.MoTa;

            // Assert
            Assert.AreEqual(tenPhongValue, result);
        }

        /// <summary>
        /// Tests that the MoTa property updates correctly when TenPhong is changed.
        /// </summary>
        [TestMethod]
        public void MoTa_WhenTenPhongIsChanged_ReturnsUpdatedValue()
        {
            // Arrange
            var suatChieu = new SuatChieuDTO
            {
                TenPhong = "Phòng A"
            };
            var initialMoTa = suatChieu.MoTa;

            // Act
            suatChieu.TenPhong = "Phòng B";
            var updatedMoTa = suatChieu.MoTa;

            // Assert
            Assert.AreEqual("Phòng A", initialMoTa);
            Assert.AreEqual("Phòng B", updatedMoTa);
        }

        /// <summary>
        /// Tests that TrangThaiText property returns the correct Vietnamese text based on the TrangThai boolean value.
        /// Input: Various TrangThai values (true/false).
        /// Expected: Returns "Đang chiếu" when true, "Kết thúc" when false.
        /// </summary>
        /// <param name="trangThai">The status value to test.</param>
        /// <param name="expectedText">The expected Vietnamese text result.</param>
        [TestMethod]
        [DataRow(true, "Đang chiếu")]
        [DataRow(false, "Kết thúc")]
        public void TrangThaiText_VariousTrangThaiValues_ReturnsExpectedText(bool trangThai, string expectedText)
        {
            // Arrange
            var suatChieu = new SuatChieuDTO
            {
                TrangThai = trangThai
            };

            // Act
            string result = suatChieu.TrangThaiText;

            // Assert
            Assert.AreEqual(expectedText, result);
        }
    }
}