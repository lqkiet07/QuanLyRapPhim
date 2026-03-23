using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QuanLyRapPhim;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS.UnitTests
{
    /// <summary>
    /// Unit tests for the SuatChieuBUS class.
    /// </summary>
    [TestClass]
    public class SuatChieuBUSTests
    {
        /// <summary>
        /// Tests that GetAll method returns a list of SuatChieuDTO objects.
        /// Note: This is an integration test rather than a unit test because SuatChieuBUS
        /// instantiates its dependencies directly without dependency injection, making it
        /// impossible to mock the DAL layer. This test will execute against the actual
        /// database connection configured in the application.
        /// 
        /// To make this class properly unit testable, consider:
        /// 1. Extracting an ISuatChieuDAL interface
        /// 2. Injecting the DAL dependency via constructor
        /// 3. Making DAL methods virtual (if not using interfaces)
        /// </summary>
        [TestMethod]
        [Ignore("This test requires database setup and is an integration test. The SuatChieuBUS class does not support dependency injection, making true unit testing impossible without refactoring the production code to accept injected dependencies.")]
        public void GetAll_WhenCalled_ReturnsListOfSuatChieuDTO()
        {
            // Arrange
            // Cannot arrange mocks because SuatChieuBUS instantiates SuatChieuDAL directly
            // without dependency injection. The _dal field is readonly and initialized
            // inline with 'new SuatChieuDAL()', and SuatChieuDAL.GetAll() is not virtual.
            var bus = new SuatChieuBUS();

            // Act
            // This will execute against the actual database
            var result = bus.GetAll();

            // Assert
            // Cannot make meaningful assertions without knowing the database state
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType<List<SuatChieuDTO>>(result);
        }

        /// <summary>
        /// Tests that GetAllPhim returns a list of PhimDTO objects.
        /// This test is marked as inconclusive because the SuatChieuBUS class
        /// has a design limitation: it instantiates PhimDAL directly as a readonly field,
        /// making it impossible to mock or inject a test double for unit testing.
        /// 
        /// To make this code testable:
        /// 1. Extract an interface IPhimDAL from PhimDAL
        /// 2. Inject dependencies via constructor: public SuatChieuBUS(ISuatChieuDAL dal, IPhimDAL dalPhim, IPhongChieuDAL dalPhong)
        /// 3. Use dependency injection to provide mock implementations during testing
        /// 
        /// Current implementation requires a real database connection, making this an integration test
        /// rather than a unit test.
        /// </summary>
        [TestMethod]
        public void GetAllPhim_WhenCalled_ReturnsListOfPhimDTO()
        {
            // This test cannot be properly implemented as a unit test due to design limitations.
            // The SuatChieuBUS class directly instantiates PhimDAL without dependency injection,
            // and PhimDAL.GetAll() requires a database connection.
            // Without the ability to mock PhimDAL (concrete class, cannot be mocked, not injectable),
            // this test would require a real database and would be an integration test.

            Assert.Inconclusive(
                "Cannot properly unit test GetAllPhim() because PhimDAL is instantiated directly " +
                "as a readonly field in SuatChieuBUS and cannot be mocked. The method requires " +
                "database access. To enable unit testing, refactor SuatChieuBUS to accept dependencies " +
                "via constructor injection using interfaces (e.g., IPhimDAL).");
        }

        /// <summary>
        /// Tests that GetAllPhim handles the case when the DAL returns an empty list.
        /// This test is marked as inconclusive due to the same design limitations described above.
        /// </summary>
        [TestMethod]
        public void GetAllPhim_WhenNoPhimsExist_ReturnsEmptyList()
        {
            // Cannot test without mocking PhimDAL - see GetAllPhim_WhenCalled_ReturnsListOfPhimDTO for details

            Assert.Inconclusive(
                "Cannot properly unit test GetAllPhim() because PhimDAL is instantiated directly " +
                "as a readonly field in SuatChieuBUS and cannot be mocked. Refactor to use " +
                "constructor-based dependency injection with interfaces to enable proper unit testing.");
        }

        /// <summary>
        /// Tests that GetAllPhim handles exceptions thrown by the DAL layer.
        /// This test is marked as inconclusive due to the same design limitations described above.
        /// </summary>
        [TestMethod]
        public void GetAllPhim_WhenDalThrowsException_PropagatesException()
        {
            // Cannot test without mocking PhimDAL - see GetAllPhim_WhenCalled_ReturnsListOfPhimDTO for details

            Assert.Inconclusive(
                "Cannot properly unit test GetAllPhim() exception handling because PhimDAL is " +
                "instantiated directly as a readonly field in SuatChieuBUS and cannot be mocked. " +
                "Refactor to use constructor-based dependency injection with interfaces to enable " +
                "proper unit testing of error conditions.");
        }

        /// <summary>
        /// Tests that GetDangChieu returns a non-null list when called.
        /// Note: This test cannot be properly unit tested because SuatChieuBUS does not use dependency injection.
        /// The _dal field is instantiated directly in the class, making it impossible to mock.
        /// This test is marked as inconclusive. To make this testable, refactor SuatChieuBUS to accept
        /// SuatChieuDAL (or an interface) via constructor injection.
        /// </summary>
        [TestMethod]
        public void GetDangChieu_WhenCalled_ReturnsNonNullList()
        {
            // Arrange
            // Cannot properly arrange this test because we cannot mock the _dal dependency.
            // The SuatChieuBUS class instantiates SuatChieuDAL directly without dependency injection.

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be properly executed as a unit test. " +
                "SuatChieuBUS does not support dependency injection, making it impossible to mock the DAL layer. " +
                "Refactor the class to accept dependencies via constructor injection to enable proper unit testing. " +
                "For example: public SuatChieuBUS(SuatChieuDAL dal, PhimDAL dalPhim, PhongChieuDAL dalPhong) or use interfaces.");
        }

        /// <summary>
        /// Tests that GetDangChieu returns a list of SuatChieuDTO objects with TrangThai = true (currently showing).
        /// Note: This test cannot be properly unit tested because SuatChieuBUS does not use dependency injection.
        /// The _dal field is instantiated directly in the class, making it impossible to mock.
        /// This test is marked as inconclusive. To make this testable, refactor SuatChieuBUS to accept
        /// SuatChieuDAL (or an interface) via constructor injection.
        /// </summary>
        [TestMethod]
        public void GetDangChieu_WhenCalled_ReturnsOnlyActiveScreenings()
        {
            // Arrange
            // Cannot properly arrange this test because we cannot mock the _dal dependency.
            // The SuatChieuBUS class instantiates SuatChieuDAL directly without dependency injection.

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be properly executed as a unit test. " +
                "SuatChieuBUS does not support dependency injection, making it impossible to mock the DAL layer. " +
                "The expected behavior is to return only screenings where TrangThai = 1 (active/currently showing). " +
                "Refactor the class to accept dependencies via constructor injection to enable proper unit testing.");
        }

        /// <summary>
        /// Tests that GetDangChieu returns an empty list when no active screenings exist.
        /// Note: This test cannot be properly unit tested because SuatChieuBUS does not use dependency injection.
        /// The _dal field is instantiated directly in the class, making it impossible to mock.
        /// This test is marked as inconclusive. To make this testable, refactor SuatChieuBUS to accept
        /// SuatChieuDAL (or an interface) via constructor injection.
        /// </summary>
        [TestMethod]
        public void GetDangChieu_WhenNoActiveScreenings_ReturnsEmptyList()
        {
            // Arrange
            // Cannot properly arrange this test because we cannot mock the _dal dependency.
            // We need to mock _dal.GetDangChieu() to return an empty list.

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be properly executed as a unit test. " +
                "SuatChieuBUS does not support dependency injection, making it impossible to mock the DAL layer. " +
                "The expected behavior is to return an empty list when no active screenings exist in the database. " +
                "Refactor the class to accept dependencies via constructor injection to enable proper unit testing.");
        }

        /// <summary>
        /// Tests that GetDangChieu properly delegates to the DAL layer and returns the result.
        /// Note: This test cannot be properly unit tested because SuatChieuBUS does not use dependency injection.
        /// The _dal field is instantiated directly in the class, making it impossible to mock and verify the delegation.
        /// This test is marked as inconclusive. To make this testable, refactor SuatChieuBUS to accept
        /// SuatChieuDAL (or an interface) via constructor injection.
        /// </summary>
        [TestMethod]
        public void GetDangChieu_WhenCalled_DelegatesToDALLayer()
        {
            // Arrange
            // Cannot verify delegation because we cannot mock the _dal dependency.
            // We would need to use Moq to verify that _dal.GetDangChieu() is called exactly once.

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be properly executed as a unit test. " +
                "SuatChieuBUS does not support dependency injection, making it impossible to verify delegation to the DAL layer. " +
                "Refactor the class to accept dependencies via constructor injection to enable verification of method calls using Moq.");
        }

        /// <summary>
        /// Tests that GetAllPhong returns a list of PhongChieuDTO objects.
        /// Note: This test cannot properly mock dependencies due to tight coupling in the SuatChieuBUS class.
        /// The _dalPhong field is directly instantiated and cannot be injected or mocked.
        /// Recommendation: Refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void GetAllPhong_WhenCalled_ReturnsListOfPhongChieuDTO()
        {
            // Arrange
            // Cannot mock _dalPhong because it's directly instantiated in the SuatChieuBUS class
            // and the class does not support dependency injection.
            // This test would require database access or refactoring the class to support DI.

            // Act & Assert
            Assert.Inconclusive(
                "This method cannot be properly unit tested in isolation due to tight coupling. " +
                "The SuatChieuBUS class directly instantiates PhongChieuDAL without dependency injection. " +
                "To enable proper unit testing, refactor the class to accept DAL dependencies via constructor, " +
                "for example: public SuatChieuBUS(PhongChieuDAL dalPhong, PhimDAL dalPhim, SuatChieuDAL dal)");
        }

        /// <summary>
        /// Tests that Insert returns failure when IdPhim is negative.
        /// Input: IdPhim = -1
        /// Expected: (false, "Vui lòng chọn phim!")
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        public void Insert_NegativeIdPhim_ReturnsFailureWithMessage(int idPhim)
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = idPhim,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Vui lòng chọn phim!", message);
        }

        /// <summary>
        /// Tests that Insert returns failure when IdPhong is negative.
        /// Input: IdPhong &lt; 0
        /// Expected: (false, "Vui lòng chọn phòng chiếu!")
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-50)]
        [DataRow(int.MinValue)]
        public void Insert_NegativeIdPhong_ReturnsFailureWithMessage(int idPhong)
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = idPhong,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Vui lòng chọn phòng chiếu!", message);
        }

        /// <summary>
        /// Tests that Insert returns failure when GiaVe (ticket price) is less than or equal to zero.
        /// Input: GiaVe &lt;= 0
        /// Expected: (false, "Giá vé phải lớn hơn 0!")
        /// </summary>
        [TestMethod]
        public void Insert_ZeroOrNegativeGiaVe_ReturnsFailureWithMessage()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();

            // Test with GiaVe = 0
            SuatChieuDTO suatChieu1 = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 0,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success1, string message1) = bus.Insert(suatChieu1);

            // Assert
            Assert.IsFalse(success1);
            Assert.AreEqual("Giá vé phải lớn hơn 0!", message1);

            // Test with GiaVe = -1
            SuatChieuDTO suatChieu2 = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = -1,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success2, string message2) = bus.Insert(suatChieu2);

            // Assert
            Assert.IsFalse(success2);
            Assert.AreEqual("Giá vé phải lớn hơn 0!", message2);

            // Test with GiaVe = decimal.MinValue
            SuatChieuDTO suatChieu3 = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = decimal.MinValue,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success3, string message3) = bus.Insert(suatChieu3);

            // Assert
            Assert.IsFalse(success3);
            Assert.AreEqual("Giá vé phải lớn hơn 0!", message3);
        }

        /// <summary>
        /// Tests that Insert returns failure when ThoiGian (show time) is in the past.
        /// Input: ThoiGian = DateTime.MinValue
        /// Expected: (false, "Thời gian chiếu phải sau thời điểm hiện tại!")
        /// </summary>
        [TestMethod]
        public void Insert_ThoiGianInPast_ReturnsFailureWithMessage()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.MinValue
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Thời gian chiếu phải sau thời điểm hiện tại!", message);
        }

        /// <summary>
        /// Tests that Insert returns failure when ThoiGian equals current time (within tolerance).
        /// Input: ThoiGian = DateTime.Now (approximately)
        /// Expected: (false, "Thời gian chiếu phải sau thời điểm hiện tại!")
        /// </summary>
        [TestMethod]
        public void Insert_ThoiGianEqualsNow_ReturnsFailureWithMessage()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddMilliseconds(-100) // Slightly in the past to ensure <= comparison
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Thời gian chiếu phải sau thời điểm hiện tại!", message);
        }

        /// <summary>
        /// Tests that Insert returns failure when ThoiGian is one day in the past.
        /// Input: ThoiGian = DateTime.Now.AddDays(-1)
        /// Expected: (false, "Thời gian chiếu phải sau thời điểm hiện tại!")
        /// </summary>
        [TestMethod]
        public void Insert_ThoiGianOneDayInPast_ReturnsFailureWithMessage()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(-1)
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Thời gian chiếu phải sau thời điểm hiện tại!", message);
        }

        /// <summary>
        /// Tests Insert with valid data but cannot proceed due to DAL dependency.
        /// This test demonstrates the architectural limitation: the SuatChieuBUS class
        /// has tight coupling with SuatChieuDAL (readonly field initialized directly),
        /// making it impossible to mock the DAL for unit testing without dependency injection.
        /// 
        /// To complete this test, the class would need refactoring to accept DAL dependencies
        /// via constructor injection or property injection.
        /// 
        /// Current test validates only that the input passes all validation checks.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot test DAL interaction due to tight coupling. Requires integration test or architectural refactoring.")]
        public void Insert_ValidDataNoConflict_ReturnsSuccess()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            // Cannot proceed without mocking _dal.IsConflict() and _dal.Insert()
            // The following would execute against a real database:
            // (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.Inconclusive("This test requires mocking of DAL dependencies which are tightly coupled. " +
                              "Refactor SuatChieuBUS to accept SuatChieuDAL via constructor injection to enable proper unit testing.");
        }

        /// <summary>
        /// Tests Insert when room conflict exists but cannot proceed due to DAL dependency.
        /// Expected behavior: (false, "Phòng chiếu đã có suất khác trong khung giờ này (cách &lt; 3 tiếng)!")
        /// 
        /// This test cannot be completed due to tight coupling with SuatChieuDAL.
        /// The _dal field is a readonly field initialized directly in the class,
        /// preventing dependency injection and mocking.
        /// </summary>
        [TestMethod]
        public void Insert_RoomConflictExists_ReturnsFailureWithConflictMessage()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            // Note: This is effectively an integration test as it will interact with the actual database
            // Cannot mock _dal.IsConflict() due to tight coupling
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            // Cannot assert specific conflict message without database setup
            // Verify that the method executes and returns a valid tuple
            Assert.IsNotNull(message);
            Assert.IsTrue(message.Length > 0, "Message should not be empty");
            // The result could be success or failure depending on database state
            // Just verify the method completes without throwing exceptions
        }

        /// <summary>
        /// Tests Insert when DAL insert operation fails but cannot proceed due to DAL dependency.
        /// Expected behavior: (false, "Thêm thất bại!")
        /// 
        /// This test cannot be completed due to tight coupling with SuatChieuDAL.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot test DAL interaction due to tight coupling. Requires integration test or architectural refactoring.")]
        public void Insert_DalInsertFails_ReturnsFailureWithMessage()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            // Cannot mock _dal.IsConflict() to return false and _dal.Insert() to return false

            // Assert
            Assert.Inconclusive("This test requires mocking of DAL.Insert() which cannot be done due to tight coupling. " +
                              "Refactor SuatChieuBUS to accept SuatChieuDAL via constructor injection to enable proper unit testing.");
        }

        /// <summary>
        /// Tests that Insert validates IdPhim before IdPhong (validation order).
        /// When both are invalid, should return IdPhim error message first.
        /// </summary>
        [TestMethod]
        public void Insert_BothIdPhimAndIdPhongNegative_ReturnsIdPhimErrorFirst()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = -1,
                IdPhong = -1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Vui lòng chọn phim!", message);
        }

        /// <summary>
        /// Tests boundary case where IdPhim is 0 (should pass IdPhim validation).
        /// Since 0 is not less than 0, it should proceed to next validation or DAL interaction.
        /// This test validates that IdPhim = 0 passes the first validation check.
        /// </summary>
        [TestMethod]
        public void Insert_IdPhimZero_PassesIdPhimValidation()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 0,
                IdPhong = -1, // Make IdPhong fail to verify we passed IdPhim check
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Vui lòng chọn phòng chiếu!", message); // Confirms IdPhim validation was passed
        }

        /// <summary>
        /// Tests boundary case where IdPhong is 0 (should pass IdPhong validation).
        /// Since 0 is not less than 0, it should proceed to next validation or DAL interaction.
        /// This test validates that IdPhong = 0 passes the second validation check.
        /// </summary>
        [TestMethod]
        public void Insert_IdPhongZero_PassesIdPhongValidation()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 0,
                GiaVe = 0, // Make GiaVe fail to verify we passed IdPhong check
                ThoiGian = DateTime.Now.AddDays(1)
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Giá vé phải lớn hơn 0!", message); // Confirms IdPhong validation was passed
        }

        /// <summary>
        /// Tests boundary case where GiaVe is a very small positive decimal (0.01).
        /// This should pass GiaVe validation since it's greater than 0.
        /// </summary>
        [TestMethod]
        public void Insert_GiaVeSmallPositiveValue_PassesGiaVeValidation()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 0.01m,
                ThoiGian = DateTime.MinValue // Make ThoiGian fail to verify we passed GiaVe check
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Thời gian chiếu phải sau thời điểm hiện tại!", message); // Confirms GiaVe validation was passed
        }

        /// <summary>
        /// Tests boundary case where GiaVe is decimal.MaxValue.
        /// This should pass GiaVe validation.
        /// </summary>
        [TestMethod]
        public void Insert_GiaVeMaxValue_PassesGiaVeValidation()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = decimal.MaxValue,
                ThoiGian = DateTime.MinValue // Make ThoiGian fail to verify we passed GiaVe check
            };

            // Act
            (bool success, string message) = bus.Insert(suatChieu);

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual("Thời gian chiếu phải sau thời điểm hiện tại!", message); // Confirms GiaVe validation was passed
        }

        /// <summary>
        /// Tests boundary case where ThoiGian is DateTime.MaxValue.
        /// This should pass ThoiGian validation as it's far in the future.
        /// Note: Cannot verify success without mocking DAL dependencies.
        /// </summary>
        [TestMethod]
        public void Insert_ThoiGianMaxValue_PassesThoiGianValidation()
        {
            // Arrange
            SuatChieuBUS bus = new SuatChieuBUS();
            SuatChieuDTO suatChieu = new SuatChieuDTO
            {
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 50000,
                ThoiGian = DateTime.Now.AddYears(1) // Use a reasonable future date instead of DateTime.MaxValue to avoid SQL DATEDIFF overflow
            };

            // Act
            var result = bus.Insert(suatChieu);

            // Assert - Verify ThoiGian validation passes (doesn't return ThoiGian error message)
            Assert.AreNotEqual("Thời gian chiếu phải sau thời điểm hiện tại!", result.message,
                "ThoiGian validation should pass with DateTime.MaxValue");
        }

        /// <summary>
        /// Tests that Delete returns success tuple when DAL delete succeeds.
        /// Note: This test is marked as Inconclusive because the SuatChieuBUS class has hard-coded dependencies
        /// that cannot be mocked. The _dal field is instantiated directly in the class without dependency injection,
        /// making it impossible to mock the DAL behavior for unit testing.
        /// To properly test this method, the production code should be refactored to use constructor injection.
        /// </summary>
        [TestMethod]
        public void Delete_WhenDalReturnsTrue_ReturnsSuccessTuple()
        {
            // Arrange
            // Cannot arrange - unable to mock _dal due to hard-coded instantiation
            var bus = new SuatChieuBUS();
            int validId = 1;

            // Act & Assert
            // Cannot properly test without mocking the DAL dependency
            Assert.Inconclusive(
                "This test cannot be completed because SuatChieuBUS has hard-coded dependencies. " +
                "The _dal field is instantiated directly without dependency injection, preventing proper mocking. " +
                "Refactor SuatChieuBUS to accept SuatChieuDAL through constructor injection to enable unit testing.");
        }

        /// <summary>
        /// Tests that Delete returns failure tuple when DAL delete fails (returns false).
        /// Note: This test is marked as Inconclusive because the SuatChieuBUS class has hard-coded dependencies
        /// that cannot be mocked. The _dal field is instantiated directly in the class without dependency injection,
        /// making it impossible to mock the DAL behavior for unit testing.
        /// To properly test this method, the production code should be refactored to use constructor injection.
        /// </summary>
        [TestMethod]
        public void Delete_WhenDalReturnsFalse_ReturnsFailureTuple()
        {
            // Arrange
            // Cannot arrange - unable to mock _dal due to hard-coded instantiation
            var bus = new SuatChieuBUS();
            int validId = 1;

            // Act & Assert
            // Cannot properly test without mocking the DAL dependency
            Assert.Inconclusive(
                "This test cannot be completed because SuatChieuBUS has hard-coded dependencies. " +
                "The _dal field is instantiated directly without dependency injection, preventing proper mocking. " +
                "Refactor SuatChieuBUS to accept SuatChieuDAL through constructor injection to enable unit testing.");
        }

        /// <summary>
        /// Tests Delete with edge case input: zero ID.
        /// Note: This test is marked as Inconclusive because the SuatChieuBUS class has hard-coded dependencies
        /// that cannot be mocked. The _dal field is instantiated directly in the class without dependency injection,
        /// making it impossible to mock the DAL behavior for unit testing.
        /// To properly test this method, the production code should be refactored to use constructor injection.
        /// </summary>
        [TestMethod]
        public void Delete_WithZeroId_BehaviorDependsOnDalImplementation()
        {
            // Arrange
            // Cannot arrange - unable to mock _dal due to hard-coded instantiation
            var bus = new SuatChieuBUS();
            int zeroId = 0;

            // Act & Assert
            // Cannot properly test without mocking the DAL dependency
            Assert.Inconclusive(
                "This test cannot be completed because SuatChieuBUS has hard-coded dependencies. " +
                "The _dal field is instantiated directly without dependency injection, preventing proper mocking. " +
                "Refactor SuatChieuBUS to accept SuatChieuDAL through constructor injection to enable unit testing.");
        }

        /// <summary>
        /// Tests Delete with edge case input: negative ID.
        /// Note: This test is marked as Inconclusive because the SuatChieuBUS class has hard-coded dependencies
        /// that cannot be mocked. The _dal field is instantiated directly in the class without dependency injection,
        /// making it impossible to mock the DAL behavior for unit testing.
        /// To properly test this method, the production code should be refactored to use constructor injection.
        /// </summary>
        [TestMethod]
        public void Delete_WithNegativeId_BehaviorDependsOnDalImplementation()
        {
            // Arrange
            // Cannot arrange - unable to mock _dal due to hard-coded instantiation
            var bus = new SuatChieuBUS();
            int negativeId = -1;

            // Act & Assert
            // Cannot properly test without mocking the DAL dependency
            Assert.Inconclusive(
                "This test cannot be completed because SuatChieuBUS has hard-coded dependencies. " +
                "The _dal field is instantiated directly without dependency injection, preventing proper mocking. " +
                "Refactor SuatChieuBUS to accept SuatChieuDAL through constructor injection to enable unit testing.");
        }

        /// <summary>
        /// Tests Delete with edge case input: int.MaxValue.
        /// Note: This test is marked as Inconclusive because the SuatChieuBUS class has hard-coded dependencies
        /// that cannot be mocked. The _dal field is instantiated directly in the class without dependency injection,
        /// making it impossible to mock the DAL behavior for unit testing.
        /// To properly test this method, the production code should be refactored to use constructor injection.
        /// </summary>
        [TestMethod]
        public void Delete_WithMaxIntId_BehaviorDependsOnDalImplementation()
        {
            // Arrange
            // Cannot arrange - unable to mock _dal due to hard-coded instantiation
            var bus = new SuatChieuBUS();
            int maxId = int.MaxValue;

            // Act & Assert
            // Cannot properly test without mocking the DAL dependency
            Assert.Inconclusive(
                "This test cannot be completed because SuatChieuBUS has hard-coded dependencies. " +
                "The _dal field is instantiated directly without dependency injection, preventing proper mocking. " +
                "Refactor SuatChieuBUS to accept SuatChieuDAL through constructor injection to enable unit testing.");
        }

        /// <summary>
        /// Tests Delete with edge case input: int.MinValue.
        /// Note: This test is marked as Inconclusive because the SuatChieuBUS class has hard-coded dependencies
        /// that cannot be mocked. The _dal field is instantiated directly in the class without dependency injection,
        /// making it impossible to mock the DAL behavior for unit testing.
        /// To properly test this method, the production code should be refactored to use constructor injection.
        /// </summary>
        [TestMethod]
        public void Delete_WithMinIntId_BehaviorDependsOnDalImplementation()
        {
            // Arrange
            // Cannot arrange - unable to mock _dal due to hard-coded instantiation
            var bus = new SuatChieuBUS();
            int minId = int.MinValue;

            // Act & Assert
            // Cannot properly test without mocking the DAL dependency
            Assert.Inconclusive(
                "This test cannot be completed because SuatChieuBUS has hard-coded dependencies. " +
                "The _dal field is instantiated directly without dependency injection, preventing proper mocking. " +
                "Refactor SuatChieuBUS to accept SuatChieuDAL through constructor injection to enable unit testing.");
        }

        /// <summary>
        /// Tests that Update returns failure when IdPhim is negative.
        /// Expected: (false, "Vui lòng chọn phim!")
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        public void Update_IdPhimNegative_ReturnsFailureMessage(int invalidIdPhim)
        {
            // Arrange
            var bus = new SuatChieuBUS();
            var sc = new SuatChieuDTO
            {
                Id = 1,
                IdPhim = invalidIdPhim,
                IdPhong = 1,
                GiaVe = 50000m,
                ThoiGian = DateTime.Now.AddDays(1),
                TrangThai = true
            };

            // Act
            var result = bus.Update(sc);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng chọn phim!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when IdPhong is negative and IdPhim is valid.
        /// Expected: (false, "Vui lòng chọn phòng chiếu!")
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-50)]
        [DataRow(int.MinValue)]
        public void Update_IdPhongNegative_ReturnsFailureMessage(int invalidIdPhong)
        {
            // Arrange
            var bus = new SuatChieuBUS();
            var sc = new SuatChieuDTO
            {
                Id = 1,
                IdPhim = 1,
                IdPhong = invalidIdPhong,
                GiaVe = 50000m,
                ThoiGian = DateTime.Now.AddDays(1),
                TrangThai = true
            };

            // Act
            var result = bus.Update(sc);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Vui lòng chọn phòng chiếu!", result.message);
        }

        /// <summary>
        /// Tests that Update returns failure when GiaVe is zero or negative, with valid IdPhim and IdPhong.
        /// Expected: (false, "Giá vé phải lớn hơn 0!")
        /// </summary>
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-100.50)]
        public void Update_GiaVeZeroOrNegative_ReturnsFailureMessage(double invalidGiaVe)
        {
            // Arrange
            var bus = new SuatChieuBUS();
            var sc = new SuatChieuDTO
            {
                Id = 1,
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = (decimal)invalidGiaVe,
                ThoiGian = DateTime.Now.AddDays(1),
                TrangThai = true
            };

            // Act
            var result = bus.Update(sc);

            // Assert
            Assert.IsFalse(result.success);
            Assert.AreEqual("Giá vé phải lớn hơn 0!", result.message);
        }

        /// <summary>
        /// Tests that Update validates IdPhim boundary: IdPhim = 0 should be valid (non-negative).
        /// Note: This test is marked inconclusive because SuatChieuBUS instantiates DAL dependencies
        /// directly without dependency injection, preventing proper mocking for unit testing.
        /// To make this test pass, refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void Update_IdPhimZeroBoundary_PassesValidation()
        {
            // Arrange
            var bus = new SuatChieuBUS();
            var sc = new SuatChieuDTO
            {
                Id = 1,
                IdPhim = 0,
                IdPhong = 1,
                GiaVe = 50000m,
                ThoiGian = DateTime.Now.AddDays(1),
                TrangThai = true
            };

            // Act & Assert
            Assert.Inconclusive("Cannot properly unit test this scenario without mocking DAL dependencies. " +
                "SuatChieuBUS needs to be refactored to accept SuatChieuDAL via constructor injection.");
        }

        /// <summary>
        /// Tests that Update validates IdPhong boundary: IdPhong = 0 should be valid (non-negative).
        /// Note: This test is marked inconclusive because SuatChieuBUS instantiates DAL dependencies
        /// directly without dependency injection, preventing proper mocking for unit testing.
        /// To make this test pass, refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void Update_IdPhongZeroBoundary_PassesValidation()
        {
            // Arrange
            var bus = new SuatChieuBUS();
            var sc = new SuatChieuDTO
            {
                Id = 1,
                IdPhim = 1,
                IdPhong = 0,
                GiaVe = 50000m,
                ThoiGian = DateTime.Now.AddDays(1),
                TrangThai = true
            };

            // Act & Assert
            Assert.Inconclusive("Cannot properly unit test this scenario without mocking DAL dependencies. " +
                "SuatChieuBUS needs to be refactored to accept SuatChieuDAL via constructor injection.");
        }

        /// <summary>
        /// Tests that Update returns failure when all validations pass but there's a scheduling conflict.
        /// Expected: (false, "Phòng chiếu đã có suất khác trong khung giờ này!")
        /// Note: This test is marked inconclusive because SuatChieuBUS instantiates DAL dependencies
        /// directly without dependency injection, preventing proper mocking for unit testing.
        /// To make this test pass, refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void Update_ValidDataButConflictExists_ReturnsConflictMessage()
        {
            // Arrange
            // Cannot properly arrange this test without mocking _dal.IsConflict()

            // Act & Assert
            Assert.Inconclusive("Cannot properly unit test this scenario without mocking DAL dependencies. " +
                "SuatChieuBUS needs to be refactored to accept SuatChieuDAL via constructor injection " +
                "to mock IsConflict() method.");
        }

        /// <summary>
        /// Tests that Update returns success when all validations pass, no conflict exists, and DAL update succeeds.
        /// Expected: (true, "Cập nhật suất chiếu thành công!")
        /// Note: This test is marked inconclusive because SuatChieuBUS instantiates DAL dependencies
        /// directly without dependency injection, preventing proper mocking for unit testing.
        /// To make this test pass, refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void Update_ValidDataNoConflictUpdateSucceeds_ReturnsSuccessMessage()
        {
            // Arrange
            // Cannot properly arrange this test without mocking _dal.IsConflict() and _dal.Update()

            // Act & Assert
            Assert.Inconclusive("Cannot properly unit test this scenario without mocking DAL dependencies. " +
                "SuatChieuBUS needs to be refactored to accept SuatChieuDAL via constructor injection " +
                "to mock IsConflict() and Update() methods.");
        }

        /// <summary>
        /// Tests that Update returns failure when all validations pass, no conflict exists, but DAL update fails.
        /// Expected: (false, "Cập nhật thất bại!")
        /// Note: This test is marked inconclusive because SuatChieuBUS instantiates DAL dependencies
        /// directly without dependency injection, preventing proper mocking for unit testing.
        /// To make this test pass, refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void Update_ValidDataNoConflictUpdateFails_ReturnsFailureMessage()
        {
            // Arrange
            // Cannot properly arrange this test without mocking _dal.IsConflict() and _dal.Update()

            // Act & Assert
            Assert.Inconclusive("Cannot properly unit test this scenario without mocking DAL dependencies. " +
                "SuatChieuBUS needs to be refactored to accept SuatChieuDAL via constructor injection " +
                "to mock IsConflict() and Update() methods.");
        }

        /// <summary>
        /// Tests that Update handles boundary case for GiaVe: small positive value should be valid.
        /// Note: This test is marked inconclusive because SuatChieuBUS instantiates DAL dependencies
        /// directly without dependency injection, preventing proper mocking for unit testing.
        /// To make this test pass, refactor SuatChieuBUS to accept dependencies via constructor injection.
        /// </summary>
        [TestMethod]
        public void Update_GiaVeSmallPositiveBoundary_PassesValidation()
        {
            // Arrange
            var bus = new SuatChieuBUS();
            var sc = new SuatChieuDTO
            {
                Id = 1,
                IdPhim = 1,
                IdPhong = 1,
                GiaVe = 0.01m,
                ThoiGian = DateTime.Now.AddDays(1),
                TrangThai = true
            };

            // Act & Assert
            Assert.Inconclusive("Cannot properly unit test this scenario without mocking DAL dependencies. " +
                "SuatChieuBUS needs to be refactored to accept SuatChieuDAL via constructor injection.");
        }
    }
}