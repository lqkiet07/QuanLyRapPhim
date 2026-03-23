using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS.UnitTests
{
    /// <summary>
    /// Unit tests for the NhanVienBUS class.
    /// </summary>
    [TestClass]
    public class NhanVienBUSTests
    {
        /// <summary>
        /// Tests that Update returns validation error when HoTen is null.
        /// </summary>
        [TestMethod]
        public void Update_HoTenIsNull_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = null,
                TaiKhoan = "validuser",
                MatKhau = "validpass"
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when HoTen is empty string.
        /// </summary>
        [TestMethod]
        public void Update_HoTenIsEmpty_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "",
                TaiKhoan = "validuser",
                MatKhau = "validpass"
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when HoTen consists only of whitespace.
        /// </summary>
        [TestMethod]
        public void Update_HoTenIsWhitespace_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "   ",
                TaiKhoan = "validuser",
                MatKhau = "validpass"
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when TaiKhoan is null.
        /// </summary>
        [TestMethod]
        public void Update_TaiKhoanIsNull_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = null,
                MatKhau = "validpass"
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when TaiKhoan is empty string.
        /// </summary>
        [TestMethod]
        public void Update_TaiKhoanIsEmpty_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "",
                MatKhau = "validpass"
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when TaiKhoan consists only of whitespace.
        /// </summary>
        [TestMethod]
        public void Update_TaiKhoanIsWhitespace_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "   ",
                MatKhau = "validpass"
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when MatKhau is null.
        /// </summary>
        [TestMethod]
        public void Update_MatKhauIsNull_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "validuser",
                MatKhau = null
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập mật khẩu!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when MatKhau is empty string.
        /// </summary>
        [TestMethod]
        public void Update_MatKhauIsEmpty_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "validuser",
                MatKhau = ""
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập mật khẩu!", result.message);
        }

        /// <summary>
        /// Tests that Update returns validation error when MatKhau consists only of whitespace.
        /// </summary>
        [TestMethod]
        public void Update_MatKhauIsWhitespace_ReturnsValidationError()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "validuser",
                MatKhau = "   "
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập mật khẩu!", result.message);
        }

        /// <summary>
        /// Tests Update with valid inputs. This is an integration test that exercises the full Update
        /// logic including DAL interactions. Since NhanVienBUS uses tight coupling with NhanVienDAL
        /// (readonly field initialized inline), this test cannot mock the DAL and will use the real
        /// DAL implementation. This test requires a properly configured database/DAL environment.
        /// 
        /// Note: All validation logic is tested separately in other tests. This test verifies that
        /// when all validations pass, the method successfully proceeds to the DAL layer.
        /// </summary>
        [TestMethod]
        public void Update_ValidInputsWithDalDependency_InconclusiveDueToTightCoupling()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "validuser",
                MatKhau = "validpass",
                IdLoai = 1
            };

            // Act
            (bool success, string message) result = bus.Update(nv);

            // Assert
            // This is an integration test - it will call the real DAL.
            // We verify that the method returns a valid tuple with a message.
            // The actual success/failure depends on the database state.
            Assert.IsNotNull(result.message);
            Assert.IsFalse(string.IsNullOrWhiteSpace(result.message));
        }

        /// <summary>
        /// Tests that Delete returns (true, "Xóa thành công!") when the DAL successfully deletes the employee.
        /// Input: A valid positive employee ID.
        /// Expected: Returns success tuple with Vietnamese success message.
        /// NOTE: Cannot execute due to lack of dependency injection - the NhanVienDAL instance cannot be mocked.
        /// </summary>
        [TestMethod]
        [DataRow(1)]
        [DataRow(100)]
        [DataRow(int.MaxValue)]
        public void Delete_ValidIdAndDalReturnsTrue_ReturnsSuccessTupleWithMessage(int id)
        {
            // Arrange
            var bus = new NhanVienBUS();

            // Act & Assert
            // Cannot properly test due to lack of dependency injection.
            // The _dal field is directly instantiated and cannot be mocked.
            // To fix: Inject NhanVienDAL via constructor, e.g.:
            // public NhanVienBUS(NhanVienDAL dal) { _dal = dal; }
            // Or better, use an interface: public NhanVienBUS(INhanVienDAL dal)
            Assert.Inconclusive(
                "Cannot properly unit test due to lack of dependency injection. " +
                "NhanVienDAL is directly instantiated and cannot be mocked. " +
                "Expected behavior: When _dal.Delete returns true, method should return (true, \"Xóa thành công!\").");
        }

        /// <summary>
        /// Tests that Delete returns (false, "Xóa thất bại! Nhân viên đã có vé bán.") when the DAL fails to delete.
        /// Input: An employee ID that cannot be deleted (e.g., has sold tickets).
        /// Expected: Returns failure tuple with Vietnamese error message indicating employee has sold tickets.
        /// NOTE: Cannot execute due to lack of dependency injection - the NhanVienDAL instance cannot be mocked.
        /// </summary>
        [TestMethod]
        [DataRow(1)]
        [DataRow(100)]
        [DataRow(int.MaxValue)]
        public void Delete_ValidIdAndDalReturnsFalse_ReturnsFailureTupleWithMessage(int id)
        {
            // Arrange
            var bus = new NhanVienBUS();

            // Act
            var result = bus.Delete(id);

            // Assert
            // Note: Cannot mock DAL due to lack of dependency injection.
            // This test verifies the method returns a properly structured tuple.
            // The actual success/failure depends on database state.
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.message);
            
            // If delete fails, verify the error message matches expected format
            if (!result.success)
            {
                Assert.AreEqual("Xóa thất bại! Nhân viên đã có vé bán.", result.message,
                    "When delete fails, should return the expected Vietnamese error message.");
            }
        }

        /// <summary>
        /// Tests Delete behavior with boundary and edge case values for the ID parameter.
        /// Input: Edge case values including 0, negative values, int.MinValue.
        /// Expected: Method delegates to DAL and returns appropriate tuple based on DAL result.
        /// NOTE: Cannot execute due to lack of dependency injection - the NhanVienDAL instance cannot be mocked.
        /// </summary>
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        public void Delete_EdgeCaseIdValues_DelegatesToDalAndReturnsTuple(int id)
        {
            // Arrange
            var bus = new NhanVienBUS();

            // Act & Assert
            // Cannot properly test due to lack of dependency injection.
            // The _dal field is directly instantiated and cannot be mocked.
            // Edge cases like negative IDs or 0 should be tested to verify proper handling.
            Assert.Inconclusive(
                "Cannot properly unit test due to lack of dependency injection. " +
                "NhanVienDAL is directly instantiated and cannot be mocked. " +
                "Expected behavior: Method should pass the ID value to _dal.Delete and return tuple based on result. " +
                "Edge cases (0, negative, int.MinValue) should be validated by DAL layer.");
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when HoTen is null.
        /// </summary>
        [TestMethod]
        public void Insert_HoTenIsNull_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = null,
                TaiKhoan = "testuser",
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when HoTen is empty string.
        /// </summary>
        [TestMethod]
        public void Insert_HoTenIsEmpty_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "",
                TaiKhoan = "testuser",
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when HoTen is whitespace only.
        /// </summary>
        [TestMethod]
        [DataRow("   ")]
        [DataRow("\t")]
        [DataRow("\n")]
        [DataRow(" \t \n ")]
        public void Insert_HoTenIsWhitespace_ReturnsFalseWithErrorMessage(string whitespaceValue)
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = whitespaceValue,
                TaiKhoan = "testuser",
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when TaiKhoan is null.
        /// </summary>
        [TestMethod]
        public void Insert_TaiKhoanIsNull_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = null,
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when TaiKhoan is empty string.
        /// </summary>
        [TestMethod]
        public void Insert_TaiKhoanIsEmpty_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "",
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when TaiKhoan is whitespace only.
        /// </summary>
        [TestMethod]
        [DataRow("   ")]
        [DataRow("\t")]
        [DataRow("\n")]
        [DataRow(" \t \n ")]
        public void Insert_TaiKhoanIsWhitespace_ReturnsFalseWithErrorMessage(string whitespaceValue)
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = whitespaceValue,
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when MatKhau is null.
        /// </summary>
        [TestMethod]
        public void Insert_MatKhauIsNull_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "testuser",
                MatKhau = null
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập mật khẩu!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when MatKhau is empty string.
        /// </summary>
        [TestMethod]
        public void Insert_MatKhauIsEmpty_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "testuser",
                MatKhau = ""
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập mật khẩu!", result.message);
        }

        /// <summary>
        /// Tests that Insert returns false with appropriate error message when MatKhau is whitespace only.
        /// </summary>
        [TestMethod]
        [DataRow("   ")]
        [DataRow("\t")]
        [DataRow("\n")]
        [DataRow(" \t \n ")]
        public void Insert_MatKhauIsWhitespace_ReturnsFalseWithErrorMessage(string whitespaceValue)
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "testuser",
                MatKhau = whitespaceValue
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập mật khẩu!", result.message);
        }

        /// <summary>
        /// Tests validation order: HoTen validation comes before TaiKhoan validation.
        /// When both HoTen and TaiKhoan are null, the error message should be for HoTen.
        /// </summary>
        [TestMethod]
        public void Insert_HoTenAndTaiKhoanBothNull_ReturnsHoTenErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = null,
                TaiKhoan = null,
                MatKhau = "password123"
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests validation order: TaiKhoan validation comes before MatKhau validation.
        /// When both TaiKhoan and MatKhau are null, the error message should be for TaiKhoan.
        /// </summary>
        [TestMethod]
        public void Insert_TaiKhoanAndMatKhauBothNull_ReturnsTaiKhoanErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = null,
                MatKhau = null
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tài khoản!", result.message);
        }

        /// <summary>
        /// Tests validation with all required fields as null.
        /// Should return the first validation error (HoTen).
        /// </summary>
        [TestMethod]
        public void Insert_AllFieldsNull_ReturnsHoTenErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = null,
                TaiKhoan = null,
                MatKhau = null
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập họ tên nhân viên!", result.message);
        }

        /// <summary>
        /// Tests that Insert correctly handles HoTen with special characters.
        /// Special characters in names should be valid as long as the string is not null/whitespace.
        /// Note: This test will fail if the DAL layer fails since the dependency cannot be mocked.
        /// To properly test this scenario, refactor NhanVienBUS to accept NhanVienDAL via constructor injection.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot fully test without mocking DAL. NhanVienBUS has hard dependency on NhanVienDAL.")]
        public void Insert_HoTenWithSpecialCharacters_ProcessesCorrectly()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyễn Văn A-B@#$%",
                TaiKhoan = "testuser",
                MatKhau = "password123"
            };

            // Act
            // Note: This test requires mocking _dal.IsTaiKhoanExist and _dal.Insert
            // which is not possible with the current design
            var result = bus.Insert(nhanVien);

            // Assert
            // Cannot assert on result without proper mocking
            Assert.Inconclusive("Test requires DAL mocking which is not supported by current design.");
        }

        /// <summary>
        /// Tests that Insert trims TaiKhoan and MatKhau before processing.
        /// </summary>
        [TestMethod]
        public void Insert_TaiKhoanAndMatKhauWithWhitespace_TrimsBeforeProcessing()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "  testuser  ",
                MatKhau = "  password123  ",
                IdLoai = 1
            };

            // Act
            var result = bus.Insert(nhanVien);

            // Assert
            // The Insert method modifies the DTO object's properties directly (by reference)
            // If the account doesn't exist, trimming occurs at lines 31-32
            // If the account exists, method returns early before trimming
            if (result.message.Contains("Tài khoản đã tồn tại"))
            {
                // Account exists - trimming doesn't occur, early return at line 30
                Assert.AreEqual("  testuser  ", nhanVien.TaiKhoan, "TaiKhoan should not be trimmed when account exists (early return)");
                Assert.AreEqual("  password123  ", nhanVien.MatKhau, "MatKhau should not be trimmed when account exists (early return)");
            }
            else
            {
                // Account doesn't exist or other result - trimming should have occurred
                Assert.AreEqual("testuser", nhanVien.TaiKhoan, "TaiKhoan should be trimmed");
                Assert.AreEqual("password123", nhanVien.MatKhau, "MatKhau should be trimmed");
            }
        }

        /// <summary>
        /// Tests that Insert returns error when TaiKhoan already exists.
        /// Note: This test cannot be implemented without mocking DAL.IsTaiKhoanExist.
        /// To properly test this scenario, refactor NhanVienBUS to accept NhanVienDAL via constructor injection.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot test without mocking DAL. NhanVienBUS has hard dependency on NhanVienDAL.")]
        public void Insert_TaiKhoanAlreadyExists_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "existinguser",
                MatKhau = "password123"
            };

            // Act
            // Note: This test requires mocking _dal.IsTaiKhoanExist to return true
            var result = bus.Insert(nhanVien);

            // Assert
            // Expected: Assert.IsFalse(result.success);
            // Expected: Assert.AreEqual("Tài khoản đã tồn tại!", result.message);
            Assert.Inconclusive("Test requires DAL mocking which is not supported by current design.");
        }

        /// <summary>
        /// Tests that Insert returns success when all validations pass and DAL insert succeeds.
        /// Note: This test cannot be implemented without mocking DAL.Insert.
        /// To properly test this scenario, refactor NhanVienBUS to accept NhanVienDAL via constructor injection.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot test without mocking DAL. NhanVienBUS has hard dependency on NhanVienDAL.")]
        public void Insert_ValidDataAndDalInsertSucceeds_ReturnsTrueWithSuccessMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "newuser",
                MatKhau = "password123"
            };

            // Act
            // Note: This test requires mocking:
            // - _dal.IsTaiKhoanExist to return false
            // - _dal.Insert to return true
            var result = bus.Insert(nhanVien);

            // Assert
            // Expected: Assert.IsTrue(result.success);
            // Expected: Assert.AreEqual("Thêm nhân viên thành công!", result.message);
            Assert.Inconclusive("Test requires DAL mocking which is not supported by current design.");
        }

        /// <summary>
        /// Tests that Insert returns failure when all validations pass but DAL insert fails.
        /// Note: This test cannot be implemented without mocking DAL.Insert.
        /// To properly test this scenario, refactor NhanVienBUS to accept NhanVienDAL via constructor injection.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot test without mocking DAL. NhanVienBUS has hard dependency on NhanVienDAL.")]
        public void Insert_ValidDataButDalInsertFails_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "newuser",
                MatKhau = "password123"
            };

            // Act
            // Note: This test requires mocking:
            // - _dal.IsTaiKhoanExist to return false
            // - _dal.Insert to return false
            var result = bus.Insert(nhanVien);

            // Assert
            // Expected: Assert.IsFalse(result.success);
            // Expected: Assert.AreEqual("Thêm nhân viên thất bại!", result.message);
            Assert.Inconclusive("Test requires DAL mocking which is not supported by current design.");
        }

        /// <summary>
        /// Tests that GetAll returns a list of NhanVienDTO objects.
        /// NOTE: This class has a hard dependency on NhanVienDAL (instantiated inline).
        /// Proper unit testing requires refactoring to support dependency injection.
        /// Current test is marked as inconclusive because the dependency cannot be mocked.
        /// 
        /// Recommended refactoring:
        /// 1. Create an interface INhanVienDAL
        /// 2. Inject INhanVienDAL via constructor: public NhanVienBUS(INhanVienDAL dal)
        /// 3. This would allow proper mocking and isolated unit testing
        /// </summary>
        [TestMethod]
        public void GetAll_WhenCalled_ReturnsListOfNhanVienDTO()
        {
            // Arrange
            // LIMITATION: Cannot mock NhanVienDAL because it's instantiated inline in NhanVienBUS
            // The _dal field is created as: private readonly NhanVienDAL _dal = new NhanVienDAL();
            // This design prevents dependency injection and proper unit testing

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be properly implemented as a unit test. " +
                "The NhanVienBUS class has a hard dependency on NhanVienDAL that is instantiated inline. " +
                "To enable proper unit testing, refactor the class to accept NhanVienDAL (or INhanVienDAL) " +
                "via constructor dependency injection.");
        }

        /// <summary>
        /// Tests that DangNhap returns null when taiKhoan or matKhau parameters are null, empty, or whitespace.
        /// </summary>
        /// <param name="taiKhoan">The account/username parameter to test.</param>
        /// <param name="matKhau">The password parameter to test.</param>
        [TestMethod]
        [DataRow(null, "validPassword", DisplayName = "Null taiKhoan")]
        [DataRow("validUser", null, DisplayName = "Null matKhau")]
        [DataRow(null, null, DisplayName = "Both null")]
        [DataRow("", "validPassword", DisplayName = "Empty taiKhoan")]
        [DataRow("validUser", "", DisplayName = "Empty matKhau")]
        [DataRow("", "", DisplayName = "Both empty")]
        [DataRow("   ", "validPassword", DisplayName = "Whitespace-only taiKhoan")]
        [DataRow("validUser", "   ", DisplayName = "Whitespace-only matKhau")]
        [DataRow("   ", "   ", DisplayName = "Both whitespace-only")]
        [DataRow("\t", "validPassword", DisplayName = "Tab character taiKhoan")]
        [DataRow("validUser", "\t", DisplayName = "Tab character matKhau")]
        [DataRow("\n", "validPassword", DisplayName = "Newline character taiKhoan")]
        [DataRow("validUser", "\n", DisplayName = "Newline character matKhau")]
        [DataRow(" \t\n ", "validPassword", DisplayName = "Mixed whitespace taiKhoan")]
        [DataRow("validUser", " \t\n ", DisplayName = "Mixed whitespace matKhau")]
        public void DangNhap_InvalidOrEmptyCredentials_ReturnsNull(string taiKhoan, string matKhau)
        {
            // Arrange
            var bus = new NhanVienBUS();

            // Act
            var result = bus.DangNhap(taiKhoan, matKhau);

            // Assert
            Assert.IsNull(result, "Expected null when taiKhoan or matKhau is null, empty, or whitespace.");
        }

        /// <summary>
        /// Tests that DangNhap correctly handles valid credentials with leading and trailing whitespace.
        /// Note: This test requires database access or dependency injection for proper mocking.
        /// The current implementation creates NhanVienDAL directly without dependency injection,
        /// making it impossible to mock the DAL layer. This test verifies the validation logic only.
        /// For complete testing of the success path, consider refactoring to use dependency injection
        /// or perform integration testing with a test database.
        /// </summary>
        [TestMethod]
        [Ignore("Requires integration testing or refactoring for dependency injection to properly test the success path.")]
        public void DangNhap_ValidCredentialsWithWhitespace_CallsDalWithTrimmedValues()
        {
            // This test cannot be properly implemented without:
            // 1. Dependency injection to allow mocking of NhanVienDAL
            // 2. Integration testing with a real or test database
            // 
            // The method should:
            // - Trim both taiKhoan and matKhau parameters
            // - Pass trimmed values to _dal.DangNhap()
            // - Return the result from _dal.DangNhap()
            //
            // To properly test this, refactor NhanVienBUS to accept NhanVienDAL via constructor injection.

            Assert.Inconclusive("This test requires dependency injection support or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap correctly handles valid credentials without whitespace.
        /// Note: This test requires database access or dependency injection for proper mocking.
        /// </summary>
        [TestMethod]
        [Ignore("Requires integration testing or refactoring for dependency injection to properly test the success path.")]
        public void DangNhap_ValidCredentialsWithoutWhitespace_CallsDalAndReturnsResult()
        {
            // This test cannot be properly implemented without:
            // 1. Dependency injection to allow mocking of NhanVienDAL
            // 2. Integration testing with a real or test database
            //
            // The method should:
            // - Pass both parameters to _dal.DangNhap() after trimming (no change if no whitespace)
            // - Return the result from _dal.DangNhap()
            //
            // To properly test this, refactor NhanVienBUS to accept NhanVienDAL via constructor injection.

            Assert.Inconclusive("This test requires dependency injection support or integration testing.");
        }
    }
}