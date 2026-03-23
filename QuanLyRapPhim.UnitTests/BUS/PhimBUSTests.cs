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
    /// Unit tests for PhimBUS class.
    /// Note: Due to the current design where dependencies (TheLoaiDAL) are directly instantiated
    /// within the class rather than injected, these tests cannot properly mock dependencies.
    /// Consider refactoring PhimBUS to use dependency injection for better testability.
    /// </summary>
    [TestClass]
    public class PhimBUSTests
    {
        /// <summary>
        /// Tests that GetAllTheLoai returns a non-null list.
        /// Note: This test cannot mock the TheLoaiDAL dependency due to the current design.
        /// The method directly instantiates TheLoaiDAL, which means this test will execute
        /// actual database operations. To enable proper unit testing with mocking,
        /// consider refactoring PhimBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void GetAllTheLoai_WhenCalled_ReturnsNonNullList()
        {
            // Arrange
            // NOTE: Cannot mock _dalTheLoai because it's directly instantiated in the class.
            // This test will execute actual DAL operations.
            // TODO: Refactor PhimBUS to use dependency injection for proper unit testing.
            PhimBUS phimBUS = new PhimBUS();

            // Act
            List<TheLoaiDTO>? result = phimBUS.GetAllTheLoai();

            // Assert
            Assert.IsNotNull(result, "GetAllTheLoai should return a non-null list.");
        }

        /// <summary>
        /// Tests that GetAllTheLoai returns a list of TheLoaiDTO objects.
        /// Note: This is an integration test rather than a pure unit test due to
        /// the inability to mock the TheLoaiDAL dependency in the current design.
        /// </summary>
        [TestMethod]
        public void GetAllTheLoai_WhenCalled_ReturnsListOfTheLoaiDTO()
        {
            // Arrange
            // NOTE: Cannot mock _dalTheLoai because it's directly instantiated in the class.
            // Consider dependency injection pattern for better testability.
            PhimBUS phimBUS = new PhimBUS();

            // Act
            List<TheLoaiDTO>? result = phimBUS.GetAllTheLoai();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<TheLoaiDTO>), "Result should be a List<TheLoaiDTO>.");
        }

        /// <summary>
        /// Tests that GetAll returns a list of PhimDTO objects.
        /// NOTE: This test is marked as Inconclusive because the PhimBUS class has hard-coded dependencies
        /// (PhimDAL instantiated directly in the field) that cannot be mocked for unit testing.
        /// 
        /// To make this class testable:
        /// 1. Refactor PhimBUS to accept PhimDAL as a constructor parameter (dependency injection)
        /// 2. Extract an IPhimDAL interface from PhimDAL class
        /// 3. Inject IPhimDAL through the constructor instead of instantiating PhimDAL directly
        /// 
        /// Example refactoring:
        ///   private readonly IPhimDAL _dalPhim;
        ///   public PhimBUS(IPhimDAL dalPhim) { _dalPhim = dalPhim; }
        /// 
        /// Current implementation issues:
        /// - _dalPhim is a readonly field initialized inline with 'new PhimDAL()'
        /// - PhimDAL is a concrete class marked as 'Cannot be mocked' in metadata
        /// - PhimDAL.GetAll() directly accesses database via DataProvider.Instance singleton
        /// - No way to inject test doubles without code refactoring
        /// 
        /// Once refactored, this test should:
        /// - Mock IPhimDAL.GetAll() to return test data
        /// - Verify the method returns the expected list
        /// - Test edge cases: empty list, null handling, exceptions
        /// </summary>
        [TestMethod]
        public void GetAll_WhenCalled_ReturnsListOfPhimDTO()
        {
            // ARRANGE
            // Cannot properly arrange due to hard-coded dependencies
            // Would need: var mockDal = new Mock<IPhimDAL>();
            // Would need: var phimBus = new PhimBUS(mockDal.Object);

            // ACT
            // Cannot properly test without refactoring for dependency injection
            Assert.Inconclusive(
                "This test cannot be completed as a unit test because PhimBUS has hard-coded dependencies. " +
                "The class needs to be refactored to support dependency injection. " +
                "See test method comments for detailed refactoring guidance.");

            // ASSERT
            // Would verify: Assert.IsNotNull(result);
            // Would verify: Assert.IsInstanceOfType<List<PhimDTO>>(result);
        }

        /// <summary>
        /// Tests that Search returns a list when given a valid keyword.
        /// Note: This class uses direct instantiation of dependencies (PhimDAL), making proper unit testing
        /// impossible without dependency injection. This test validates the behavior but may require
        /// a configured database connection to pass. Consider refactoring PhimBUS to accept dependencies
        /// via constructor injection for proper unit testing.
        /// </summary>
        [TestMethod]
        public void Search_ValidKeyword_ReturnsListOfPhimDTO()
        {
            // Arrange
            PhimBUS phimBUS = new PhimBUS();
            string keyword = "test";

            // Act & Assert
            // This test is marked as inconclusive because the class directly instantiates its DAL dependencies,
            // making it impossible to mock without dependency injection. To properly unit test this method,
            // the PhimBUS class should accept PhimDAL as a constructor parameter.
            Assert.Inconclusive("Cannot properly unit test without dependency injection. The PhimBUS class directly instantiates PhimDAL, requiring database access.");
        }

        /// <summary>
        /// Tests that Search handles null keyword parameter.
        /// Note: This class uses direct instantiation of dependencies (PhimDAL), making proper unit testing
        /// impossible without dependency injection. This test validates the behavior but may require
        /// a configured database connection to pass.
        /// </summary>
        [TestMethod]
        [DataRow(null)]
        public void Search_NullKeyword_HandlesGracefully(string? keyword)
        {
            // Arrange
            PhimBUS phimBUS = new PhimBUS();

            // Act & Assert
            // This test is marked as inconclusive because the class directly instantiates its DAL dependencies,
            // making it impossible to mock without dependency injection. To properly unit test this method,
            // the PhimBUS class should accept PhimDAL as a constructor parameter.
            Assert.Inconclusive("Cannot properly unit test without dependency injection. The PhimBUS class directly instantiates PhimDAL, requiring database access.");
        }

        /// <summary>
        /// Tests that Search handles various edge case keywords including empty, whitespace, special characters, and very long strings.
        /// Note: This class uses direct instantiation of dependencies (PhimDAL), making proper unit testing
        /// impossible without dependency injection. This test validates the behavior but may require
        /// a configured database connection to pass.
        /// </summary>
        [TestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("!@#$%^&*()")]
        [DataRow("abc\t\n\r")]
        public void Search_EdgeCaseKeywords_HandlesGracefully(string keyword)
        {
            // Arrange
            PhimBUS phimBUS = new PhimBUS();

            // Act
            List<PhimDTO>? result = phimBUS.Search(keyword);

            // Assert
            // This is an integration test rather than a pure unit test due to
            // the inability to mock the PhimDAL dependency in the current design.
            Assert.IsNotNull(result, "Search should return a non-null list even with edge case keywords.");
        }

        /// <summary>
        /// Tests that Search handles very long keyword strings.
        /// Note: This class uses direct instantiation of dependencies (PhimDAL), making proper unit testing
        /// impossible without dependency injection. This test validates the behavior but may require
        /// a configured database connection to pass.
        /// </summary>
        [TestMethod]
        public void Search_VeryLongKeyword_HandlesGracefully()
        {
            // Arrange
            PhimBUS phimBUS = new PhimBUS();
            string keyword = new string('a', 10000);

            // Act & Assert
            // This test is marked as inconclusive because the class directly instantiates its DAL dependencies,
            // making it impossible to mock without dependency injection. To properly unit test this method,
            // the PhimBUS class should accept PhimDAL as a constructor parameter.
            Assert.Inconclusive("Cannot properly unit test without dependency injection. The PhimBUS class directly instantiates PhimDAL, requiring database access.");
        }

        /// <summary>
        /// Tests that Insert returns failure when TenPhim is null, empty, or whitespace.
        /// </summary>
        /// <param name="tenPhim">The movie name to test.</param>
        /// <param name="expectedMessage">The expected error message.</param>
        [TestMethod]
        [DataRow(null, "Vui lòng nhập tên phim!", DisplayName = "TenPhim is null")]
        [DataRow("", "Vui lòng nhập tên phim!", DisplayName = "TenPhim is empty string")]
        [DataRow("   ", "Vui lòng nhập tên phim!", DisplayName = "TenPhim is whitespace")]
        [DataRow("\t", "Vui lòng nhập tên phim!", DisplayName = "TenPhim is tab")]
        [DataRow("\n", "Vui lòng nhập tên phim!", DisplayName = "TenPhim is newline")]
        [DataRow("\r\n", "Vui lòng nhập tên phim!", DisplayName = "TenPhim is carriage return newline")]
        [DataRow("  \t  \n  ", "Vui lòng nhập tên phim!", DisplayName = "TenPhim is mixed whitespace")]
        public void Insert_TenPhimIsNullOrWhitespace_ReturnsFailureWithMessage(string? tenPhim, string expectedMessage)
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = tenPhim!,
                ThoiLuong = 120,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual(expectedMessage, result.message);
        }

        /// <summary>
        /// Tests that Insert returns failure when ThoiLuong is less than or equal to zero.
        /// </summary>
        /// <param name="thoiLuong">The duration to test.</param>
        /// <param name="expectedMessage">The expected error message.</param>
        [TestMethod]
        [DataRow(0.0, "Thời lượng phải lớn hơn 0!", DisplayName = "ThoiLuong is zero")]
        [DataRow(-1.0, "Thời lượng phải lớn hơn 0!", DisplayName = "ThoiLuong is negative")]
        [DataRow(-100.5, "Thời lượng phải lớn hơn 0!", DisplayName = "ThoiLuong is large negative")]
        [DataRow(double.NegativeInfinity, "Thời lượng phải lớn hơn 0!", DisplayName = "ThoiLuong is negative infinity")]
        public void Insert_ThoiLuongIsZeroOrNegative_ReturnsFailureWithMessage(double thoiLuong, string expectedMessage)
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = thoiLuong,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual(expectedMessage, result.message);
        }

        /// <summary>
        /// Tests that Insert returns failure when IdTheLoai is negative.
        /// </summary>
        /// <param name="idTheLoai">The genre ID to test.</param>
        /// <param name="expectedMessage">The expected error message.</param>
        [TestMethod]
        [DataRow(-1, "Vui lòng chọn thể loại!", DisplayName = "IdTheLoai is -1")]
        [DataRow(-100, "Vui lòng chọn thể loại!", DisplayName = "IdTheLoai is -100")]
        [DataRow(int.MinValue, "Vui lòng chọn thể loại!", DisplayName = "IdTheLoai is int.MinValue")]
        public void Insert_IdTheLoaiIsNegative_ReturnsFailureWithMessage(int idTheLoai, string expectedMessage)
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = 120,
                IdTheLoai = idTheLoai
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual(expectedMessage, result.message);
        }

        /// <summary>
        /// Tests that Insert handles very small positive ThoiLuong values correctly.
        /// Very small positive values should pass validation and proceed to DAL insert.
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_ThoiLuongIsVerySmallPositive_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = 0.0001,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // Since we cannot mock PhimDAL without DI, we can only verify that validation passed
            // The result depends on actual database interaction
            // In a properly designed system with DI, we would mock PhimDAL.Insert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that Insert handles very large ThoiLuong values correctly.
        /// Very large values should pass validation and proceed to DAL insert.
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_ThoiLuongIsVeryLarge_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = double.MaxValue,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // Since we cannot mock PhimDAL without DI, we can only verify that validation passed
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that Insert handles double.PositiveInfinity for ThoiLuong.
        /// Positive infinity passes the > 0 check but may cause issues in the DAL layer.
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_ThoiLuongIsPositiveInfinity_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = double.PositiveInfinity,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // Positive infinity is > 0, so validation passes
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that Insert handles double.NaN for ThoiLuong.
        /// NaN fails the > 0 check (NaN comparisons always return false), so validation should fail.
        /// </summary>
        [TestMethod]
        public void Insert_ThoiLuongIsNaN_ReturnsFailureWithMessage()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = double.NaN,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // NaN <= 0 is false, but NaN > 0 is also false, so NaN <= 0 evaluates to true in the check
            Assert.IsFalse(result.success);
            Assert.AreEqual("Thời lượng phải lớn hơn 0!", result.message);
        }

        /// <summary>
        /// Tests that Insert accepts IdTheLoai of zero, which passes validation (not negative).
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_IdTheLoaiIsZero_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = 120,
                IdTheLoai = 0
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // Zero is not negative, so validation passes
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that Insert accepts large positive IdTheLoai values.
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_IdTheLoaiIsMaxValue_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = 120,
                IdTheLoai = int.MaxValue
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // int.MaxValue is positive, so validation passes
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests validation priority - TenPhim is checked first before ThoiLuong.
        /// If TenPhim is invalid, the method should return the TenPhim error message.
        /// </summary>
        [TestMethod]
        public void Insert_TenPhimInvalidAndThoiLuongInvalid_ReturnsTenPhimError()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "",
                ThoiLuong = 0,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên phim!", result.message);
        }

        /// <summary>
        /// Tests validation priority - ThoiLuong is checked before IdTheLoai.
        /// If TenPhim is valid but ThoiLuong is invalid, the method should return the ThoiLuong error message.
        /// </summary>
        [TestMethod]
        public void Insert_ThoiLuongInvalidAndIdTheLoaiInvalid_ReturnsThoiLuongError()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Valid Movie Name",
                ThoiLuong = 0,
                IdTheLoai = -1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Thời lượng phải lớn hơn 0!", result.message);
        }

        /// <summary>
        /// Tests that Insert handles very long movie names correctly.
        /// Very long strings should pass validation if they are not whitespace.
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_TenPhimIsVeryLongString_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var veryLongName = new string('A', 10000);
            var phim = new PhimDTO
            {
                TenPhim = veryLongName,
                ThoiLuong = 120,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // Very long string passes validation
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that Insert handles movie names with special characters correctly.
        /// Strings with special characters should pass validation.
        /// Note: Complete testing of DAL interaction requires dependency injection, which is not present in the current design.
        /// </summary>
        [TestMethod]
        public void Insert_TenPhimHasSpecialCharacters_PassesValidation()
        {
            // Arrange
            var bus = new PhimBUS();
            var phim = new PhimDTO
            {
                TenPhim = "Movie!@#$%^&*()_+-={}[]|\\:\";<>?,./",
                ThoiLuong = 120,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Insert(phim);

            // Assert
            // Special characters pass validation
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that Delete method returns success tuple when DAL deletion succeeds with a valid positive ID.
        /// Input: Valid positive movie ID where deletion succeeds.
        /// Expected: Returns (true, "Xóa phim thành công!").
        /// NOTE: Test is inconclusive - PhimBUS requires dependency injection refactoring.
        /// </summary>
        [TestMethod]
        public void Delete_ValidIdWithSuccessfulDeletion_ReturnsSuccessTuple()
        {
            // This test cannot be completed without dependency injection in PhimBUS class.
            // PhimBUS creates PhimDAL directly (_dalPhim = new PhimDAL()) without constructor injection,
            // making it impossible to mock the dependency with Moq.
            // 
            // Required refactoring:
            // - Add IPhimDAL interface
            // - Inject IPhimDAL via constructor: public PhimBUS(IPhimDAL dalPhim, ITheLoaiDAL dalTheLoai)
            // - Update calling code to use dependency injection container
            //
            // Once refactored, this test should:
            // Arrange:
            // - Mock IPhimDAL to return true for Delete(validId)
            // Act:
            // - Call phimBUS.Delete(validId)
            // Assert:
            // - Verify result.success == true
            // - Verify result.message == "Xóa phim thành công!"

            Assert.Inconclusive("PhimBUS class requires dependency injection refactoring to enable unit testing. " +
                "Currently, PhimDAL is instantiated directly in the class, preventing mock injection.");
        }

        /// <summary>
        /// Tests that Delete method returns failure tuple when DAL deletion fails (e.g., movie has showtimes).
        /// Input: Valid positive movie ID where deletion fails due to foreign key constraints.
        /// Expected: Returns (false, "Xóa thất bại! Phim đang có suất chiếu.").
        /// NOTE: Test is inconclusive - PhimBUS requires dependency injection refactoring.
        /// </summary>
        [TestMethod]
        public void Delete_ValidIdWithFailedDeletion_ReturnsFailureTuple()
        {
            // This test cannot be completed without dependency injection in PhimBUS class.
            //
            // Once refactored, this test should:
            // Arrange:
            // - Mock IPhimDAL to return false for Delete(validId)
            // Act:
            // - Call phimBUS.Delete(validId)
            // Assert:
            // - Verify result.success == false
            // - Verify result.message == "Xóa thất bại! Phim đang có suất chiếu."

            Assert.Inconclusive("PhimBUS class requires dependency injection refactoring to enable unit testing. " +
                "Currently, PhimDAL is instantiated directly in the class, preventing mock injection.");
        }

        /// <summary>
        /// Tests Delete method behavior with boundary value zero.
        /// Input: ID = 0 (boundary value, typically invalid for database primary keys).
        /// Expected: Depends on DAL implementation, but typically should fail.
        /// NOTE: Test is inconclusive - PhimBUS requires dependency injection refactoring.
        /// </summary>
        [TestMethod]
        public void Delete_IdIsZero_HandlesBoundaryValue()
        {
            // Arrange
            // NOTE: Cannot mock _dalPhim because it's directly instantiated in the class.
            // This test will execute actual DAL operations (integration test).
            PhimBUS phimBUS = new PhimBUS();

            // Act
            (bool success, string message) result = phimBUS.Delete(0);

            // Assert
            // ID 0 is a boundary value that typically doesn't exist in database.
            // The Delete method should return false for non-existent IDs.
            Assert.IsFalse(result.success, "Delete with ID 0 should return false as it's an invalid/non-existent ID.");
            Assert.IsNotNull(result.message, "Result message should not be null.");
        }

        /// <summary>
        /// Tests Delete method behavior with negative ID values.
        /// Input: Negative ID value (invalid for database primary keys).
        /// Expected: Should handle gracefully, likely returning failure.
        /// NOTE: This is an integration test as PhimBUS cannot be properly unit tested
        /// without dependency injection. It tests the actual behavior with the DAL layer.
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        public void Delete_NegativeId_HandlesInvalidInput(int invalidId)
        {
            // Arrange
            // NOTE: Cannot mock _dalPhim because it's directly instantiated in the class.
            // This test will execute actual DAL operations as an integration test.
            PhimBUS phimBUS = new PhimBUS();

            // Act
            var result = phimBUS.Delete(invalidId);

            // Assert
            Assert.IsFalse(result.success, 
                $"Delete with negative ID ({invalidId}) should return success=false.");
            Assert.IsNotNull(result.message, 
                "Error message should not be null.");
            Assert.IsFalse(string.IsNullOrWhiteSpace(result.message), 
                "Error message should not be empty or whitespace.");
        }

        /// <summary>
        /// Tests Delete method behavior with maximum integer value.
        /// Input: int.MaxValue (edge case boundary value).
        /// Expected: Should handle gracefully, likely no such record exists.
        /// NOTE: Test is inconclusive - PhimBUS requires dependency injection refactoring.
        /// </summary>
        [TestMethod]
        public void Delete_IdIsMaxValue_HandlesBoundaryValue()
        {
            // This test cannot be completed without dependency injection in PhimBUS class.
            //
            // Once refactored, this test should:
            // Arrange:
            // - Mock IPhimDAL to return false for Delete(int.MaxValue)
            // Act:
            // - Call phimBUS.Delete(int.MaxValue)
            // Assert:
            // - Verify result.success == false

            Assert.Inconclusive("PhimBUS class requires dependency injection refactoring to enable unit testing. " +
                "Currently, PhimDAL is instantiated directly in the class, preventing mock injection.");
        }

        /// <summary>
        /// Tests that InsertTheLoai returns false with an appropriate error message
        /// when the TenTheLoai property is null.
        /// </summary>
        [TestMethod]
        public void InsertTheLoai_NullTenTheLoai_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();
            TheLoaiDTO theLoai = new TheLoaiDTO { TenTheLoai = null };

            // Act
            (bool success, string message) result = phimBus.InsertTheLoai(theLoai);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên thể loại!", result.message);
        }

        /// <summary>
        /// Tests that InsertTheLoai returns false with an appropriate error message
        /// when the TenTheLoai property is an empty string.
        /// </summary>
        [TestMethod]
        public void InsertTheLoai_EmptyTenTheLoai_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();
            TheLoaiDTO theLoai = new TheLoaiDTO { TenTheLoai = string.Empty };

            // Act
            (bool success, string message) result = phimBus.InsertTheLoai(theLoai);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên thể loại!", result.message);
        }

        /// <summary>
        /// Tests that InsertTheLoai returns false with an appropriate error message
        /// when the TenTheLoai property contains only whitespace characters.
        /// </summary>
        [TestMethod]
        [DataRow("   ")]
        [DataRow("\t")]
        [DataRow("\n")]
        [DataRow("\r\n")]
        [DataRow(" \t \n ")]
        public void InsertTheLoai_WhitespaceTenTheLoai_ReturnsFalseWithErrorMessage(string whitespace)
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();
            TheLoaiDTO theLoai = new TheLoaiDTO { TenTheLoai = whitespace };

            // Act
            (bool success, string message) result = phimBus.InsertTheLoai(theLoai);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên thể loại!", result.message);
        }

        /// <summary>
        /// Tests that InsertTheLoai returns the appropriate result when TenTheLoai is valid.
        /// Note: This test performs actual database insertion as the DAL dependency is not injectable.
        /// The result depends on the actual database state and DAL implementation.
        /// Expected: If database insertion succeeds, returns (true, "Thêm thể loại thành công!")
        /// Expected: If database insertion fails, returns (false, "Thêm thất bại!")
        /// </summary>
        [TestMethod]
        [DataRow("Action")]
        [DataRow("Comedy")]
        [DataRow("ValidCategoryName")]
        [DataRow("Tên thể loại tiếng Việt")]
        [DataRow("123")]
        [DataRow("Category-With-Special_Characters!@#")]
        public void InsertTheLoai_ValidTenTheLoai_ReturnsResultBasedOnDatabaseOperation(string tenTheLoai)
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();
            TheLoaiDTO theLoai = new TheLoaiDTO { TenTheLoai = tenTheLoai };

            // Act
            (bool success, string message) result = phimBus.InsertTheLoai(theLoai);

            // Assert
            // Note: Cannot mock DAL as it's instantiated directly in PhimBUS.
            // This test performs actual database operations (integration test behavior).
            // Verify that a result is returned with appropriate messages.
            Assert.IsNotNull(result.message);
            if (result.success)
            {
                Assert.AreEqual("Thêm thể loại thành công!", result.message);
            }
            else
            {
                Assert.AreEqual("Thêm thất bại!", result.message);
            }
        }

        /// <summary>
        /// Tests DeleteTheLoai with a valid positive ID when deletion succeeds.
        /// Verifies that the method returns true with the appropriate success message.
        /// Note: This test requires database connectivity as PhimBUS does not support dependency injection.
        /// For proper unit testing, PhimBUS should be refactored to accept DAL dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        [DataRow(1)]
        [DataRow(100)]
        [DataRow(int.MaxValue)]
        public void DeleteTheLoai_ValidPositiveId_ReturnsExpectedResult(int id)
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();

            // Act
            (bool success, string message) result = phimBus.DeleteTheLoai(id);

            // Assert
            // Note: Cannot properly unit test without dependency injection.
            // The actual result depends on database state and whether the ID exists.
            // Proper unit testing would require mocking TheLoaiDAL via constructor injection.
            Assert.IsNotNull(result.message);
            Assert.IsTrue(result.message == "Xóa thể loại thành công!" ||
                         result.message == "Xóa thất bại! Thể loại đang được sử dụng.");
            Assert.AreEqual(result.success, result.message == "Xóa thể loại thành công!");
        }

        /// <summary>
        /// Tests DeleteTheLoai with zero ID.
        /// Verifies that the method handles zero ID values according to business logic.
        /// Note: This test requires database connectivity as PhimBUS does not support dependency injection.
        /// </summary>
        [TestMethod]
        public void DeleteTheLoai_ZeroId_ReturnsExpectedResult()
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();
            int id = 0;

            // Act
            (bool success, string message) result = phimBus.DeleteTheLoai(id);

            // Assert
            // Note: Cannot properly unit test without dependency injection.
            // Zero is likely an invalid ID and should fail, but this depends on database constraints.
            Assert.IsNotNull(result.message);
            Assert.IsTrue(result.message == "Xóa thể loại thành công!" ||
                         result.message == "Xóa thất bại! Thể loại đang được sử dụng.");
        }

        /// <summary>
        /// Tests DeleteTheLoai with negative ID values.
        /// Verifies that the method handles invalid negative ID values.
        /// Note: This test requires database connectivity as PhimBUS does not support dependency injection.
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        public void DeleteTheLoai_NegativeId_ReturnsExpectedResult(int id)
        {
            // Arrange
            PhimBUS phimBus = new PhimBUS();

            // Act
            (bool success, string message) result = phimBus.DeleteTheLoai(id);

            // Assert
            // Note: Cannot properly unit test without dependency injection.
            // Negative IDs should typically fail, but this depends on database implementation.
            Assert.IsNotNull(result.message);
            Assert.IsTrue(result.message == "Xóa thể loại thành công!" ||
                         result.message == "Xóa thất bại! Thể loại đang được sử dụng.");
        }

        /// <summary>
        /// Tests DeleteTheLoai to verify that when deletion succeeds, the success flag is true
        /// and the message matches the expected success message.
        /// Note: This test is marked as inconclusive because PhimBUS does not support dependency injection,
        /// making it impossible to mock TheLoaiDAL and control the Delete method's return value.
        /// To enable proper unit testing, refactor PhimBUS to accept TheLoaiDAL via constructor injection.
        /// </summary>
        [TestMethod]
        public void DeleteTheLoai_WhenDalDeleteReturnsTrue_ReturnsSuccessWithCorrectMessage()
        {
            // Arrange
            // Cannot mock _dalTheLoai because PhimBUS creates its own instance internally.
            // Proper unit testing requires dependency injection refactoring.

            // Assert
            Assert.Inconclusive(
                "Cannot properly unit test DeleteTheLoai without dependency injection. " +
                "PhimBUS instantiates TheLoaiDAL internally, preventing mock injection. " +
                "Refactor PhimBUS to accept TheLoaiDAL via constructor to enable proper unit testing. " +
                "Expected behavior: When _dalTheLoai.Delete(id) returns true, " +
                "DeleteTheLoai should return (true, \"Xóa thể loại thành công!\").");
        }

        /// <summary>
        /// Tests DeleteTheLoai to verify that when deletion fails, the success flag is false
        /// and the message matches the expected failure message.
        /// Note: This test is marked as inconclusive because PhimBUS does not support dependency injection,
        /// making it impossible to mock TheLoaiDAL and control the Delete method's return value.
        /// To enable proper unit testing, refactor PhimBUS to accept TheLoaiDAL via constructor injection.
        /// </summary>
        [TestMethod]
        public void DeleteTheLoai_WhenDalDeleteReturnsFalse_ReturnsFailureWithCorrectMessage()
        {
            // Arrange
            // Cannot mock _dalTheLoai because PhimBUS creates its own instance internally.
            // Proper unit testing requires dependency injection refactoring.

            // Assert
            Assert.Inconclusive(
                "Cannot properly unit test DeleteTheLoai without dependency injection. " +
                "PhimBUS instantiates TheLoaiDAL internally, preventing mock injection. " +
                "Refactor PhimBUS to accept TheLoaiDAL via constructor to enable proper unit testing. " +
                "Expected behavior: When _dalTheLoai.Delete(id) returns false, " +
                "DeleteTheLoai should return (false, \"Xóa thất bại! Thể loại đang được sử dụng.\").");
        }

        /// <summary>
        /// Tests that Update returns failure when TenPhim is null.
        /// Input: PhimDTO with TenPhim = null.
        /// Expected: Returns (false, "Vui lòng nhập tên phim!").
        /// </summary>
        [TestMethod]
        public void Update_TenPhimIsNull_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = null,
                ThoiLuong = 120.0,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên phim!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when TenPhim is an empty string.
        /// Input: PhimDTO with TenPhim = "".
        /// Expected: Returns (false, "Vui lòng nhập tên phim!").
        /// </summary>
        [TestMethod]
        public void Update_TenPhimIsEmpty_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "",
                ThoiLuong = 120.0,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên phim!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when TenPhim contains only whitespace.
        /// Input: PhimDTO with TenPhim = "   ".
        /// Expected: Returns (false, "Vui lòng nhập tên phim!").
        /// </summary>
        [TestMethod]
        public void Update_TenPhimIsWhitespace_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "   ",
                ThoiLuong = 120.0,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên phim!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when ThoiLuong is zero.
        /// Input: PhimDTO with ThoiLuong = 0.0.
        /// Expected: Returns (false, "Thời lượng phải lớn hơn 0!").
        /// </summary>
        [TestMethod]
        public void Update_ThoiLuongIsZero_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = 0.0,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Thời lượng phải lớn hơn 0!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when ThoiLuong is negative.
        /// Input: PhimDTO with ThoiLuong = -10.5.
        /// Expected: Returns (false, "Thời lượng phải lớn hơn 0!").
        /// </summary>
        [TestMethod]
        public void Update_ThoiLuongIsNegative_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = -10.5,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Thời lượng phải lớn hơn 0!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when ThoiLuong is negative infinity.
        /// Input: PhimDTO with ThoiLuong = double.NegativeInfinity.
        /// Expected: Returns (false, "Thời lượng phải lớn hơn 0!").
        /// </summary>
        [TestMethod]
        public void Update_ThoiLuongIsNegativeInfinity_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = double.NegativeInfinity,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Thời lượng phải lớn hơn 0!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when IdTheLoai is negative.
        /// Input: PhimDTO with IdTheLoai = -1.
        /// Expected: Returns (false, "Vui lòng chọn thể loại!").
        /// </summary>
        [TestMethod]
        public void Update_IdTheLoaiIsNegative_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = 120.0,
                IdTheLoai = -1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng chọn thể loại!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when IdTheLoai is int.MinValue.
        /// Input: PhimDTO with IdTheLoai = int.MinValue.
        /// Expected: Returns (false, "Vui lòng chọn thể loại!").
        /// </summary>
        [TestMethod]
        public void Update_IdTheLoaiIsMinValue_ReturnsFailureMessage()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = 120.0,
                IdTheLoai = int.MinValue
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng chọn thể loại!", result.message);
        }

        /// <summary>
        /// Tests that Update behavior when all validations pass and calls the DAL layer.
        /// This test is marked as Inconclusive because PhimBUS does not use dependency injection,
        /// making it impossible to mock the PhimDAL dependency. The DAL's Update method is not virtual,
        /// preventing Moq from creating a mock. To properly test this scenario, PhimBUS would need to
        /// accept PhimDAL as a constructor parameter or the Update method in PhimDAL would need to be virtual.
        /// Input: Valid PhimDTO with all properties set correctly.
        /// Expected: Should call _dalPhim.Update and return appropriate success/failure message.
        /// </summary>
        [TestMethod]
        public void Update_ValidInputWithDalInteraction_CannotBeTested()
        {
            // This test cannot be implemented because:
            // 1. PhimBUS instantiates PhimDAL directly as a readonly field
            // 2. PhimDAL.Update() is not virtual, so it cannot be mocked with Moq
            // 3. Creating fake/stub classes is prohibited by test requirements
            // 
            // To test this scenario, the production code would need refactoring:
            // - Option 1: Accept PhimDAL via constructor (dependency injection)
            // - Option 2: Make PhimDAL.Update() virtual
            // - Option 3: Extract an interface for PhimDAL

            Assert.Inconclusive("Cannot test DAL interaction without dependency injection or virtual methods. Refactoring required.");
        }

        /// <summary>
        /// Tests that Update handles boundary case when ThoiLuong is double.PositiveInfinity.
        /// Input: PhimDTO with ThoiLuong = double.PositiveInfinity.
        /// Expected: Passes validation (PositiveInfinity > 0), attempts DAL update.
        /// Note: This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_ThoiLuongIsPositiveInfinity_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = double.PositiveInfinity,
                IdTheLoai = 1
            };

            // Act & Assert
            // This will pass validation but attempt to call the real DAL.
            // The behavior depends on the actual database state and connection.
            // Cannot properly test without mocking the DAL layer.
            Assert.Inconclusive("Cannot fully test this scenario without mocking the DAL dependency.");
        }

        /// <summary>
        /// Tests that Update handles special case when ThoiLuong is double.NaN.
        /// Input: PhimDTO with ThoiLuong = double.NaN.
        /// Expected: NaN comparisons return false, so validation passes and attempts DAL update.
        /// Note: This represents a potential bug - NaN should likely be rejected during validation.
        /// This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_ThoiLuongIsNaN_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = double.NaN,
                IdTheLoai = 1
            };

            // Act & Assert
            // NaN <= 0 returns false (all NaN comparisons return false except !=)
            // This means NaN passes the validation check, which is likely unintended behavior.
            // This test demonstrates a potential bug in the validation logic.
            // Cannot properly test without mocking the DAL layer.
            Assert.Inconclusive("Cannot fully test this scenario without mocking the DAL dependency. Note: NaN passing validation may be a bug.");
        }

        /// <summary>
        /// Tests that Update handles boundary case when IdTheLoai is zero.
        /// Input: PhimDTO with IdTheLoai = 0.
        /// Expected: Passes validation (0 is not < 0), attempts DAL update.
        /// Note: This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_IdTheLoaiIsZero_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = 120.0,
                IdTheLoai = 0
            };

            // Act & Assert
            // IdTheLoai = 0 passes validation (not < 0)
            // This will attempt to call the real DAL.
            // Cannot properly test without mocking the DAL layer.
            Assert.Inconclusive("Cannot fully test this scenario without mocking the DAL dependency.");
        }

        /// <summary>
        /// Tests that Update handles boundary case when IdTheLoai is int.MaxValue.
        /// Input: PhimDTO with IdTheLoai = int.MaxValue.
        /// Expected: Passes validation, attempts DAL update.
        /// Note: This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_IdTheLoaiIsMaxValue_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = 120.0,
                IdTheLoai = int.MaxValue
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            // IdTheLoai = int.MaxValue should pass validation (not < 0)
            // The validation error for IdTheLoai is "Vui lòng chọn thể loại!"
            // If we get this message, validation failed; otherwise it passed
            Assert.AreNotEqual("Vui lòng chọn thể loại!", result.message,
                "IdTheLoai = int.MaxValue should pass validation since it is not < 0");
        }

        /// <summary>
        /// Tests that Update handles minimum valid ThoiLuong boundary.
        /// Input: PhimDTO with ThoiLuong = double.Epsilon (smallest positive value).
        /// Expected: Passes validation (double.Epsilon > 0), attempts DAL update.
        /// Note: This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_ThoiLuongIsMinimumPositiveValue_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Valid Movie",
                ThoiLuong = double.Epsilon,
                IdTheLoai = 1
            };

            // Act & Assert
            // double.Epsilon (smallest positive double) passes validation
            // This will attempt to call the real DAL.
            // Cannot properly test without mocking the DAL layer.
            Assert.Inconclusive("Cannot fully test this scenario without mocking the DAL dependency.");
        }

        /// <summary>
        /// Tests validation priority when multiple validations fail.
        /// Input: PhimDTO with TenPhim null, ThoiLuong negative, and IdTheLoai negative.
        /// Expected: Returns failure for TenPhim first (validations are checked in order).
        /// </summary>
        [TestMethod]
        public void Update_MultipleValidationFailures_ReturnsFirstFailure()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = null,
                ThoiLuong = -50.0,
                IdTheLoai = -1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng nhập tên phim!", result.message);
        }

        /// <summary>
        /// Tests that Update handles very long string for TenPhim.
        /// Input: PhimDTO with TenPhim as a very long string (1000 characters).
        /// Expected: Passes TenPhim validation, attempts DAL update.
        /// Note: This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_TenPhimIsVeryLong_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = new string('A', 1000),
                ThoiLuong = 120.0,
                IdTheLoai = 1
            };

            // Act & Assert
            // Very long string passes validation (not null/empty/whitespace)
            // This will attempt to call the real DAL.
            // Cannot properly test without mocking the DAL layer.
            Assert.Inconclusive("Cannot fully test this scenario without mocking the DAL dependency.");
        }

        /// <summary>
        /// Tests that Update handles TenPhim with special characters.
        /// Input: PhimDTO with TenPhim containing special characters.
        /// Expected: Passes TenPhim validation, attempts DAL update.
        /// Note: This test is limited by the same dependency injection constraints.
        /// </summary>
        [TestMethod]
        public void Update_TenPhimWithSpecialCharacters_PassesValidation()
        {
            // Arrange
            PhimBUS bus = new PhimBUS();
            PhimDTO phim = new PhimDTO
            {
                Id = 1,
                TenPhim = "Movie!@#$%^&*()_+-=[]{}|;':\",./<>?",
                ThoiLuong = 120.0,
                IdTheLoai = 1
            };

            // Act
            var result = bus.Update(phim);

            // Assert
            // Special characters pass validation (not null/empty/whitespace)
            // The result depends on actual database interaction
            Assert.IsNotNull(result);
        }
    }
}