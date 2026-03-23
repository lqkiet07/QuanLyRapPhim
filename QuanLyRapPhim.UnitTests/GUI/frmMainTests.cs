using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim;
using QuanLyRapPhim.DTO;


namespace QuanLyRapPhim.UnitTests
{
    /// <summary>
    /// Unit tests for the frmMain class.
    /// </summary>
    [TestClass]
    public partial class frmMainTests
    {
        /// <summary>
        /// Tests that the constructor successfully creates an instance when provided with a valid NhanVienDTO object.
        /// Input: A valid NhanVienDTO instance with populated properties.
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_ValidUser_CreatesInstanceSuccessfully()
        {
            // Arrange
            var user = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "nguyenvana",
                MatKhau = "password123",
                IdLoai = 1,
                TenLoaiNV = "Quan Ly"
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor accepts a null user parameter without throwing an exception during construction.
        /// Input: null user parameter.
        /// Expected: The frmMain instance is created, though this may cause issues in subsequent operations.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_NullUser_CreatesInstanceWithoutException()
        {
            // Arrange
            NhanVienDTO? user = null;

            // Act
            var form = new frmMain(user!);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor successfully creates an instance with a user having minimum valid property values.
        /// Input: A NhanVienDTO with Id = 0, empty strings, and IdLoai = 0.
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_UserWithMinimumValues_CreatesInstanceSuccessfully()
        {
            // Arrange
            var user = new NhanVienDTO
            {
                Id = 0,
                HoTen = "",
                TaiKhoan = "",
                MatKhau = "",
                IdLoai = 0,
                TenLoaiNV = ""
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor successfully creates an instance with a user having maximum integer values.
        /// Input: A NhanVienDTO with Id = int.MaxValue and IdLoai = int.MaxValue.
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_UserWithMaximumIntegerValues_CreatesInstanceSuccessfully()
        {
            // Arrange
            var user = new NhanVienDTO
            {
                Id = int.MaxValue,
                HoTen = "Test User",
                TaiKhoan = "testuser",
                MatKhau = "password",
                IdLoai = int.MaxValue,
                TenLoaiNV = "Test Type"
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor successfully creates an instance with a user having negative integer values.
        /// Input: A NhanVienDTO with Id = -1 and IdLoai = -1.
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_UserWithNegativeIntegerValues_CreatesInstanceSuccessfully()
        {
            // Arrange
            var user = new NhanVienDTO
            {
                Id = -1,
                HoTen = "Test User",
                TaiKhoan = "testuser",
                MatKhau = "password",
                IdLoai = -1,
                TenLoaiNV = "Test Type"
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor successfully creates an instance with a user having null string properties.
        /// Input: A NhanVienDTO with null values for all string properties.
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_UserWithNullStringProperties_CreatesInstanceSuccessfully()
        {
            // Arrange
            var user = new NhanVienDTO
            {
                Id = 1,
                HoTen = null!,
                TaiKhoan = null!,
                MatKhau = null!,
                IdLoai = 1,
                TenLoaiNV = null!
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor successfully creates an instance with a user having very long string properties.
        /// Input: A NhanVienDTO with extremely long string values (10000 characters).
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_UserWithVeryLongStringProperties_CreatesInstanceSuccessfully()
        {
            // Arrange
            var longString = new string('A', 10000);
            var user = new NhanVienDTO
            {
                Id = 1,
                HoTen = longString,
                TaiKhoan = longString,
                MatKhau = longString,
                IdLoai = 1,
                TenLoaiNV = longString
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }

        /// <summary>
        /// Tests that the constructor successfully creates an instance with a user having special characters in string properties.
        /// Input: A NhanVienDTO with special characters including Unicode, control characters, and symbols.
        /// Expected: The frmMain instance is created without throwing an exception.
        /// </summary>
        [TestMethod]
        [STAThread]
        public void FrmMain_UserWithSpecialCharactersInStrings_CreatesInstanceSuccessfully()
        {
            // Arrange
            var user = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyễn Văn A!@#$%^&*()",
                TaiKhoan = "user<>\"'\\",
                MatKhau = "pass\t\n\r",
                IdLoai = 1,
                TenLoaiNV = "Loại\u0000NV"
            };

            // Act
            var form = new frmMain(user);

            // Assert
            Assert.IsNotNull(form);
        }
    }
}