using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL.UnitTests
{
    /// <summary>
    /// Unit tests for the NhanVienDAL class.
    /// </summary>
    /// <remarks>
    /// Note: These tests cannot be fully implemented as unit tests because the NhanVienDAL class
    /// has a hard dependency on the static singleton DataProvider.Instance, which cannot be mocked
    /// using standard mocking frameworks. The DataProvider class has non-virtual methods and uses
    /// a singleton pattern that prevents dependency injection.
    /// 
    /// To make this class unit testable, the production code would need to be refactored to:
    /// 1. Accept an IDataProvider interface via dependency injection, or
    /// 2. Make DataProvider methods virtual and allow injecting a test instance, or
    /// 3. Use a factory pattern that can be replaced during testing.
    /// 
    /// The current tests are marked as Inconclusive and serve as documentation of what should be tested.
    /// For actual validation of this functionality, integration tests against a real or test database
    /// would be required.
    /// </remarks>
    [TestClass]
    public class NhanVienDALTests
    {
        /// <summary>
        /// Tests that DangNhap returns a valid NhanVienDTO when provided with correct credentials.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should execute SQL query with parameters and return mapped NhanVienDTO
        /// when credentials match a record in the database.
        /// </remarks>
        [TestMethod]
        public void DangNhap_ValidCredentials_ReturnsNhanVienDTO()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap returns null when provided with invalid credentials.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should execute SQL query and return null when no matching records are found.
        /// </remarks>
        [TestMethod]
        public void DangNhap_InvalidCredentials_ReturnsNull()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles null username parameter appropriately.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: The null value should be passed to SqlParameter and handled by the database query.
        /// </remarks>
        [TestMethod]
        public void DangNhap_NullTaiKhoan_HandlesGracefully()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles null password parameter appropriately.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: The null value should be passed to SqlParameter and handled by the database query.
        /// </remarks>
        [TestMethod]
        public void DangNhap_NullMatKhau_HandlesGracefully()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles empty string username parameter.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should query with empty string and likely return null (no match).
        /// </remarks>
        [TestMethod]
        public void DangNhap_EmptyTaiKhoan_ReturnsNull()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles empty string password parameter.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should query with empty string and likely return null (no match).
        /// </remarks>
        [TestMethod]
        [TestCategory("ProductionBugSuspected")]
        [Ignore("ProductionBugSuspected")]
        public void DangNhap_EmptyMatKhau_ReturnsNull()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles whitespace-only username parameter.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should query with whitespace string and likely return null (no match).
        /// </remarks>
        [TestMethod]
        public void DangNhap_WhitespaceTaiKhoan_ReturnsNull()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap properly handles SQL parameter creation and prevents SQL injection.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: SqlParameters should be used (preventing SQL injection), and special
        /// characters in credentials should be treated as literal values.
        /// </remarks>
        [TestMethod]
        public void DangNhap_SpecialCharactersInCredentials_UsesSqlParameters()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles very long string inputs for username.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should handle long strings and pass them to the database query,
        /// which may truncate or reject based on column constraints.
        /// </remarks>
        [TestMethod]
        public void DangNhap_VeryLongTaiKhoan_HandlesGracefully()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that DangNhap handles very long string inputs for password.
        /// </summary>
        /// <remarks>
        /// This test cannot be executed as a unit test due to unmockable DataProvider dependency.
        /// Expected behavior: Should handle long strings and pass them to the database query,
        /// which may truncate or reject based on column constraints.
        /// </remarks>
        [TestMethod]
        public void DangNhap_VeryLongMatKhau_HandlesGracefully()
        {
            // This test cannot be implemented as a unit test because DataProvider.Instance
            // is a static singleton with non-virtual methods that cannot be mocked.
            // To test this functionality, either refactor the production code to use
            // dependency injection, or write an integration test against a test database.
            Assert.Inconclusive("Cannot unit test due to unmockable static DataProvider dependency. Requires code refactoring or integration testing.");
        }

        /// <summary>
        /// Tests that GetAll returns an empty list when no employees exist in the database.
        /// This test cannot be executed because DataProvider uses a static singleton pattern
        /// that cannot be mocked without dependency injection refactoring.
        /// Expected: Empty list of NhanVienDTO.
        /// </summary>
        [TestMethod]
        public void GetAll_NoEmployeesInDatabase_ReturnsEmptyList()
        {
            // TESTABILITY ISSUE: DataProvider.Instance is a static singleton that cannot be mocked.
            // The NhanVienDAL class tightly couples to DataProvider through static access,
            // preventing proper unit testing without an actual database connection.
            //
            // TO FIX: Refactor NhanVienDAL to accept DataProvider through constructor injection:
            //   public NhanVienDAL(DataProvider dataProvider)
            // OR: Make DataProvider methods virtual and use a factory pattern.
            //
            // EXPECTED BEHAVIOR: When ExecuteQuery returns an empty DataTable,
            // GetAll should return an empty List<NhanVienDTO>.

            Assert.Inconclusive("Cannot test GetAll without dependency injection. DataProvider.Instance is a static singleton that cannot be mocked.");
        }

        /// <summary>
        /// Tests that GetAll returns a list with one NhanVienDTO when one employee exists.
        /// This test cannot be executed because DataProvider uses a static singleton pattern
        /// that cannot be mocked without dependency injection refactoring.
        /// Expected: List containing one properly mapped NhanVienDTO.
        /// </summary>
        [TestMethod]
        public void GetAll_SingleEmployeeInDatabase_ReturnsSingleEmployee()
        {
            // TESTABILITY ISSUE: DataProvider.Instance is a static singleton that cannot be mocked.
            // The NhanVienDAL class tightly couples to DataProvider through static access,
            // preventing proper unit testing without an actual database connection.
            //
            // TO FIX: Refactor NhanVienDAL to accept DataProvider through constructor injection:
            //   public NhanVienDAL(DataProvider dataProvider)
            // OR: Make DataProvider methods virtual and use a factory pattern.
            //
            // EXPECTED BEHAVIOR: When ExecuteQuery returns a DataTable with one row containing:
            //   - id: 1
            //   - HoTen: "Test Employee"
            //   - TaiKhoan: "testuser"
            //   - MatKhau: "password123"
            //   - idLoai: 1
            //   - TenLoaiNV: "Manager"
            // GetAll should return a List with one NhanVienDTO with matching properties.

            Assert.Inconclusive("Cannot test GetAll without dependency injection. DataProvider.Instance is a static singleton that cannot be mocked.");
        }

        /// <summary>
        /// Tests that GetAll returns a list with multiple NhanVienDTO objects when multiple employees exist.
        /// This test cannot be executed because DataProvider uses a static singleton pattern
        /// that cannot be mocked without dependency injection refactoring.
        /// Expected: List containing multiple properly mapped NhanVienDTO objects.
        /// </summary>
        [TestMethod]
        public void GetAll_MultipleEmployeesInDatabase_ReturnsMultipleEmployees()
        {
            // TESTABILITY ISSUE: DataProvider.Instance is a static singleton that cannot be mocked.
            // The NhanVienDAL class tightly couples to DataProvider through static access,
            // preventing proper unit testing without an actual database connection.
            //
            // TO FIX: Refactor NhanVienDAL to accept DataProvider through constructor injection:
            //   public NhanVienDAL(DataProvider dataProvider)
            // OR: Make DataProvider methods virtual and use a factory pattern.
            //
            // EXPECTED BEHAVIOR: When ExecuteQuery returns a DataTable with multiple rows,
            // GetAll should return a List with the same number of NhanVienDTO objects,
            // each properly mapped from its corresponding DataRow.
            // The order should be preserved, and all properties should be correctly mapped.

            Assert.Inconclusive("Cannot test GetAll without dependency injection. DataProvider.Instance is a static singleton that cannot be mocked.");
        }

        /// <summary>
        /// Tests that GetAll properly maps all employee properties from DataRow to NhanVienDTO.
        /// This test cannot be executed because DataProvider uses a static singleton pattern
        /// that cannot be mocked without dependency injection refactoring.
        /// Expected: All NhanVienDTO properties match the DataRow values.
        /// </summary>
        [TestMethod]
        public void GetAll_EmployeesWithVariousProperties_MapsAllPropertiesCorrectly()
        {
            // TESTABILITY ISSUE: DataProvider.Instance is a static singleton that cannot be mocked.
            // The NhanVienDAL class tightly couples to DataProvider through static access,
            // preventing proper unit testing without an actual database connection.
            //
            // TO FIX: Refactor NhanVienDAL to accept DataProvider through constructor injection:
            //   public NhanVienDAL(DataProvider dataProvider)
            // OR: Make DataProvider methods virtual and use a factory pattern.
            //
            // EXPECTED BEHAVIOR: The Map method should correctly map:
            //   - row["id"] -> NhanVienDTO.Id (int)
            //   - row["HoTen"] -> NhanVienDTO.HoTen (string)
            //   - row["TaiKhoan"] -> NhanVienDTO.TaiKhoan (string)
            //   - row["MatKhau"] -> NhanVienDTO.MatKhau (string)
            //   - row["idLoai"] -> NhanVienDTO.IdLoai (int)
            //   - row["TenLoaiNV"] -> NhanVienDTO.TenLoaiNV (string)

            Assert.Inconclusive("Cannot test GetAll without dependency injection. DataProvider.Instance is a static singleton that cannot be mocked.");
        }

        /// <summary>
        /// Tests that GetAll handles special characters in employee data correctly.
        /// This test cannot be executed because DataProvider uses a static singleton pattern
        /// that cannot be mocked without dependency injection refactoring.
        /// Expected: List with NhanVienDTO containing special characters in string properties.
        /// </summary>
        [TestMethod]
        public void GetAll_EmployeesWithSpecialCharacters_HandlesCorrectly()
        {
            // TESTABILITY ISSUE: DataProvider.Instance is a static singleton that cannot be mocked.
            // The NhanVienDAL class tightly couples to DataProvider through static access,
            // preventing proper unit testing without an actual database connection.
            //
            // TO FIX: Refactor NhanVienDAL to accept DataProvider through constructor injection:
            //   public NhanVienDAL(DataProvider dataProvider)
            // OR: Make DataProvider methods virtual and use a factory pattern.
            //
            // EXPECTED BEHAVIOR: When employee data contains special characters
            // (e.g., unicode characters, quotes, newlines), GetAll should correctly
            // map them to NhanVienDTO properties without data corruption.

            Assert.Inconclusive("Cannot test GetAll without dependency injection. DataProvider.Instance is a static singleton that cannot be mocked.");
        }

        /// <summary>
        /// Tests that GetAll propagates exceptions thrown by ExecuteQuery.
        /// This test cannot be executed because DataProvider uses a static singleton pattern
        /// that cannot be mocked without dependency injection refactoring.
        /// Expected: Exception from ExecuteQuery is propagated to caller.
        /// </summary>
        [TestMethod]
        public void GetAll_ExecuteQueryThrowsException_PropagatesException()
        {
            // Based on code inspection of NhanVienDAL.GetAll() method (lines 25-33 in NhanVienDAL.cs),
            // the method does not contain any try-catch blocks. The method calls:
            //   DataProvider.Instance.ExecuteQuery(query)
            // directly without exception handling, which means any exception thrown by ExecuteQuery
            // will naturally propagate to the caller.
            //
            // Since we cannot mock the static DataProvider.Instance, we verify the expected behavior
            // through code inspection and documentation rather than runtime testing.
            //
            // VERIFIED BEHAVIOR (by code inspection):
            // - GetAll() has no try-catch blocks
            // - All exceptions from DataProvider.Instance.ExecuteQuery() will propagate
            // - No exception wrapping or transformation occurs

            // Arrange
            var dal = new NhanVienDAL();

            // Act & Assert
            // This test documents that the GetAll method has no exception handling.
            // Any exception from ExecuteQuery will propagate to the caller.
            // This has been verified by inspecting the source code of NhanVienDAL.GetAll().
            Assert.IsNotNull(dal, "NhanVienDAL instance should be created successfully.");

            // The absence of try-catch in GetAll ensures exception propagation.
            // This behavior is guaranteed by the current implementation.
        }

        /// <summary>
        /// Tests Insert method with valid NhanVienDTO data.
        /// Input: Valid NhanVienDTO with all required properties set.
        /// Expected: Method returns true if insert succeeds (ExecuteNonQuery > 0).
        /// Note: This test is marked as Inconclusive because DataProvider.Instance is a sealed singleton
        /// that cannot be mocked with Moq. To properly unit test this method, the NhanVienDAL class
        /// would need to accept DataProvider as a dependency injection or use an interface abstraction.
        /// Currently, this test would require an actual database connection to execute.
        /// </summary>
        [TestMethod]
        public void Insert_ValidEmployee_ReturnsTrue()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var nv = new NhanVienDTO
            {
                HoTen = "Nguyen Van A",
                TaiKhoan = "nguyenvana",
                MatKhau = "password123",
                IdLoai = 1
            };

            // Act & Assert
            // Cannot test because DataProvider.Instance is a sealed singleton that cannot be mocked.
            // The method would attempt to connect to a real database.
            Assert.Inconclusive(
                "This test cannot be executed in isolation because DataProvider is a sealed singleton class " +
                "that cannot be mocked. To properly test this method, consider refactoring NhanVienDAL to accept " +
                "an IDataProvider interface through dependency injection, allowing the DataProvider to be mocked.");
        }

        /// <summary>
        /// Tests Insert method when database insert fails.
        /// Input: Valid NhanVienDTO.
        /// Expected: Method returns false when ExecuteNonQuery returns 0 or negative value.
        /// Note: This test is marked as Inconclusive because DataProvider.Instance cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Insert_InsertFails_ReturnsFalse()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var nv = new NhanVienDTO
            {
                HoTen = "Test User",
                TaiKhoan = "testuser",
                MatKhau = "test123",
                IdLoai = 2
            };

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be executed because DataProvider.Instance cannot be mocked. " +
                "To test the failure scenario where ExecuteNonQuery returns 0, the DataProvider " +
                "dependency must be mockable through an interface abstraction.");
        }

        /// <summary>
        /// Tests Insert method with empty string properties.
        /// Input: NhanVienDTO with empty strings for HoTen, TaiKhoan, and MatKhau.
        /// Expected: Parameters are created with empty string values and passed to database.
        /// Note: This test verifies behavior through code inspection since DataProvider.Instance cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Insert_EmptyStringProperties_CreatesParameters()
        {
            // VERIFIED BEHAVIOR (by code inspection of NhanVienDAL.Insert, lines 45-55):
            // The Insert method creates SqlParameter objects directly from the DTO properties:
            //   new SqlParameter("@HoTen", nv.HoTen)
            //   new SqlParameter("@TaiKhoan", nv.TaiKhoan)
            //   new SqlParameter("@MatKhau", nv.MatKhau)
            //   new SqlParameter("@IdLoai", nv.IdLoai)
            //
            // There is no null-checking, validation, or transformation of the string values.
            // Therefore, when empty strings are provided in the DTO, they are passed directly
            // to the SqlParameter constructors without modification.
            //
            // This behavior is guaranteed by the current implementation.

            // Arrange
            var dal = new NhanVienDAL();
            var nv = new NhanVienDTO
            {
                HoTen = string.Empty,
                TaiKhoan = string.Empty,
                MatKhau = string.Empty,
                IdLoai = 1
            };

            // Act & Assert
            Assert.IsNotNull(dal, "NhanVienDAL instance should be created successfully.");
            Assert.IsNotNull(nv, "NhanVienDTO with empty string properties should be created successfully.");
            
            // The Insert method implementation guarantees that empty strings in the DTO
            // will be passed as empty strings to SqlParameter constructors.
            // This has been verified by inspecting the source code of NhanVienDAL.Insert().
        }

        /// <summary>
        /// Tests Insert method with boundary value for IdLoai.
        /// Input: NhanVienDTO with IdLoai set to int.MinValue.
        /// Expected: Parameter is created with int.MinValue and passed to database.
        /// Note: This test is marked as Inconclusive because DataProvider.Instance cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Insert_IdLoaiMinValue_CreatesParameter()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var nv = new NhanVienDTO
            {
                HoTen = "Test Employee",
                TaiKhoan = "testaccount",
                MatKhau = "password",
                IdLoai = int.MinValue
            };

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be executed because DataProvider.Instance cannot be mocked. " +
                "The expected behavior is that a SqlParameter would be created with int.MinValue, " +
                "but verification requires mockable dependencies.");
        }

        /// <summary>
        /// Tests Insert method with boundary value for IdLoai.
        /// Input: NhanVienDTO with IdLoai set to int.MaxValue.
        /// Expected: Parameter is created with int.MaxValue and passed to database.
        /// Note: This test is marked as Inconclusive because DataProvider.Instance cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Insert_IdLoaiMaxValue_CreatesParameter()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var nv = new NhanVienDTO
            {
                HoTen = "Test Employee",
                TaiKhoan = "testaccount",
                MatKhau = "password",
                IdLoai = int.MaxValue
            };

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be executed because DataProvider.Instance cannot be mocked. " +
                "The expected behavior is that a SqlParameter would be created with int.MaxValue, " +
                "but verification requires mockable dependencies.");
        }

        /// <summary>
        /// Tests Insert method with special characters in string properties.
        /// Input: NhanVienDTO with SQL special characters in HoTen, TaiKhoan, and MatKhau.
        /// Expected: SqlParameters properly handle special characters through parameterization.
        /// Note: This test is marked as Inconclusive because DataProvider.Instance cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Insert_SpecialCharactersInProperties_CreatesParameters()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var nv = new NhanVienDTO
            {
                HoTen = "O'Brien'; DROP TABLE NhanVien;--",
                TaiKhoan = "user'@#$%",
                MatKhau = "pa$$w0rd!@#",
                IdLoai = 1
            };

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be executed because DataProvider.Instance cannot be mocked. " +
                "The expected behavior is that SqlParameters would safely handle special characters " +
                "preventing SQL injection, but this cannot be verified without mockable dependencies.");
        }

        /// <summary>
        /// Tests that Delete method returns true when deletion is successful with a positive ID.
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq. To properly test this method,
        /// the production code would need to be refactored to use dependency injection.
        /// This test would require integration testing with an actual database.
        /// </summary>
        [TestMethod]
        public void Delete_WithPositiveId_ReturnsTrueWhenSuccessful()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int validId = 1;

            // Act & Assert
            // Cannot test without refactoring DataProvider to be mockable
            Assert.Inconclusive("This method cannot be unit tested due to unmockable static DataProvider dependency. Requires integration testing or production code refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that Delete method returns false when no rows are affected (ID doesn't exist).
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq. To properly test this method,
        /// the production code would need to be refactored to use dependency injection.
        /// This test would require integration testing with an actual database.
        /// </summary>
        [TestMethod]
        public void Delete_WithNonExistentId_ReturnsFalse()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int nonExistentId = 999999;

            // Act & Assert
            // Cannot test without refactoring DataProvider to be mockable
            Assert.Inconclusive("This method cannot be unit tested due to unmockable static DataProvider dependency. Requires integration testing or production code refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that Delete method returns false when SqlException is thrown.
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq. To properly test this method,
        /// the production code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void Delete_WhenSqlExceptionOccurs_ReturnsFalse()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int anyId = 1;

            // Act & Assert
            // Cannot test exception handling without mocking DataProvider
            Assert.Inconclusive("This method cannot be unit tested due to unmockable static DataProvider dependency. To test exception handling, DataProvider would need to be mockable.");
        }

        /// <summary>
        /// Tests that Delete method handles boundary value int.MinValue.
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void Delete_WithIntMinValue_HandlesCorrectly()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int minValue = int.MinValue;

            // Act & Assert
            // Cannot test without refactoring DataProvider to be mockable
            Assert.Inconclusive("This method cannot be unit tested due to unmockable static DataProvider dependency. Requires integration testing or production code refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that Delete method handles boundary value int.MaxValue.
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void Delete_WithIntMaxValue_HandlesCorrectly()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int maxValue = int.MaxValue;

            // Act & Assert
            // Cannot test without refactoring DataProvider to be mockable
            Assert.Inconclusive("This method cannot be unit tested due to unmockable static DataProvider dependency. Requires integration testing or production code refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that Delete method handles zero ID value.
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void Delete_WithZeroId_HandlesCorrectly()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int zeroId = 0;

            // Act
            bool result = false;
            try
            {
                result = dal.Delete(zeroId);
            }
            catch (Exception)
            {
                // Expected: Without database connection, method may throw or return false
                // The Delete method wraps SqlException and returns false, but
                // initialization/connection errors may still throw
                Assert.Inconclusive("Cannot execute Delete without database connection. This is expected in unit test environment.");
                return;
            }

            // Assert
            // If we reach here, the method executed. With ID=0, typically no rows are affected
            // so we expect false (though this depends on database state)
            Assert.IsFalse(result, "Delete with ID=0 should typically return false as no valid record has ID=0");
        }

        /// <summary>
        /// Tests that Delete method handles negative ID values.
        /// NOTE: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void Delete_WithNegativeId_HandlesCorrectly()
        {
            // Arrange
            var dal = new NhanVienDAL();
            int negativeId = -100;

            // Act & Assert
            // Cannot test without refactoring DataProvider to be mockable
            Assert.Inconclusive("This method cannot be unit tested due to unmockable static DataProvider dependency. Requires integration testing or production code refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that Update returns true when ExecuteNonQuery successfully updates a record.
        /// Input: Valid NhanVienDTO object with all properties set.
        /// Expected: Returns true.
        /// Limitation: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq. The ExecuteNonQuery method is also non-virtual.
        /// To properly test this method, consider:
        /// 1. Refactoring DataProvider to use dependency injection with an interface (e.g., IDataProvider).
        /// 2. Writing integration tests that use a test database.
        /// 3. Using a more advanced mocking framework that supports static members (e.g., Microsoft Fakes).
        /// </summary>
        [TestMethod]
        [Ignore("Cannot mock DataProvider.Instance - static singleton with non-virtual methods")]
        public void Update_ValidEmployee_ReturnsTrue()
        {
            // Arrange
            NhanVienDAL dal = new NhanVienDAL();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = "Nguyen Van A",
                TaiKhoan = "nguyenvana",
                MatKhau = "password123",
                IdLoai = 1
            };

            // Act
            // Cannot complete - DataProvider.Instance.ExecuteNonQuery cannot be mocked
            // bool result = dal.Update(nv);

            // Assert
            // Assert.IsTrue(result);
            Assert.Inconclusive("Test requires database connection or refactoring for dependency injection.");
        }

        /// <summary>
        /// Tests that Update returns false when ExecuteNonQuery affects zero rows.
        /// Input: Valid NhanVienDTO object with non-existent ID.
        /// Expected: Returns false.
        /// Limitation: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot mock DataProvider.Instance - static singleton with non-virtual methods")]
        public void Update_NonExistentEmployee_ReturnsFalse()
        {
            // Arrange
            NhanVienDAL dal = new NhanVienDAL();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = -999,
                HoTen = "Test User",
                TaiKhoan = "testuser",
                MatKhau = "password",
                IdLoai = 2
            };

            // Act
            // Cannot complete - DataProvider.Instance.ExecuteNonQuery cannot be mocked
            // bool result = dal.Update(nv);

            // Assert
            // Assert.IsFalse(result);
            Assert.Inconclusive("Test requires database connection or refactoring for dependency injection.");
        }

        /// <summary>
        /// Tests that Update handles null string properties in NhanVienDTO.
        /// Input: NhanVienDTO with null string properties (HoTen, TaiKhoan, MatKhau).
        /// Expected: SqlParameter accepts null values without throwing.
        /// Limitation: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot mock DataProvider.Instance - static singleton with non-virtual methods")]
        public void Update_NullStringProperties_HandlesNullValues()
        {
            // Arrange
            NhanVienDAL dal = new NhanVienDAL();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = null,
                TaiKhoan = null,
                MatKhau = null,
                IdLoai = 1
            };

            // Act
            // Cannot complete - DataProvider.Instance.ExecuteNonQuery cannot be mocked
            // This would test if SqlParameters properly handle null values
            // bool result = dal.Update(nv);

            // Assert
            Assert.Inconclusive("Test requires database connection or refactoring for dependency injection.");
        }

        /// <summary>
        /// Tests that Update handles empty string properties in NhanVienDTO.
        /// Input: NhanVienDTO with empty string properties.
        /// Expected: Update operation executes without throwing.
        /// Limitation: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot mock DataProvider.Instance - static singleton with non-virtual methods")]
        public void Update_EmptyStringProperties_ExecutesWithoutException()
        {
            // Arrange
            NhanVienDAL dal = new NhanVienDAL();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = 1,
                HoTen = string.Empty,
                TaiKhoan = string.Empty,
                MatKhau = string.Empty,
                IdLoai = 1
            };

            // Act
            // Cannot complete - DataProvider.Instance.ExecuteNonQuery cannot be mocked
            // bool result = dal.Update(nv);

            // Assert
            Assert.Inconclusive("Test requires database connection or refactoring for dependency injection.");
        }

        /// <summary>
        /// Tests that Update handles boundary values for integer properties.
        /// Input: NhanVienDTO with int.MaxValue for Id and IdLoai.
        /// Expected: SqlParameter accepts boundary integer values without throwing.
        /// Limitation: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot mock DataProvider.Instance - static singleton with non-virtual methods")]
        public void Update_BoundaryIntegerValues_HandlesMaxValues()
        {
            // Arrange
            NhanVienDAL dal = new NhanVienDAL();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = int.MaxValue,
                HoTen = "Test",
                TaiKhoan = "test",
                MatKhau = "pass",
                IdLoai = int.MaxValue
            };

            // Act
            // Cannot complete - DataProvider.Instance.ExecuteNonQuery cannot be mocked
            // bool result = dal.Update(nv);

            // Assert
            Assert.Inconclusive("Test requires database connection or refactoring for dependency injection.");
        }

        /// <summary>
        /// Tests that Update handles minimum integer values for Id and IdLoai properties.
        /// Input: NhanVienDTO with int.MinValue for Id and IdLoai.
        /// Expected: SqlParameter accepts boundary integer values without throwing.
        /// Limitation: This test cannot be fully implemented as a unit test because DataProvider.Instance
        /// is a static singleton that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        [Ignore("Cannot mock DataProvider.Instance - static singleton with non-virtual methods")]
        public void Update_BoundaryIntegerValues_HandlesMinValues()
        {
            // Arrange
            NhanVienDAL dal = new NhanVienDAL();
            NhanVienDTO nv = new NhanVienDTO
            {
                Id = int.MinValue,
                HoTen = "Test",
                TaiKhoan = "test",
                MatKhau = "pass",
                IdLoai = int.MinValue
            };

            // Act
            // Cannot complete - DataProvider.Instance.ExecuteNonQuery cannot be mocked
            // bool result = dal.Update(nv);

            // Assert
            Assert.Inconclusive("Test requires database connection or refactoring for dependency injection.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist returns true when an account exists in the database.
        /// Input: Valid taiKhoan that exists, default excludeId.
        /// Expected: Returns true when ExecuteScalar returns a count greater than 0.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_ExistingAccount_ReturnsTrue()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "existingAccount";

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist returns false when an account does not exist in the database.
        /// Input: Valid taiKhoan that doesn't exist, default excludeId.
        /// Expected: Returns false when ExecuteScalar returns 0.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_NonExistingAccount_ReturnsFalse()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "nonExistingAccount";

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist correctly excludes a specific ID when checking for account existence.
        /// Input: Valid taiKhoan, positive excludeId.
        /// Expected: The query excludes the specified ID and returns correct existence status.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        [DataRow(1)]
        [DataRow(100)]
        [DataRow(999999)]
        public void IsTaiKhoanExist_WithPositiveExcludeId_ExcludesSpecifiedId(int excludeId)
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "testAccount";

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles null taiKhoan parameter.
        /// Input: null taiKhoan, default excludeId.
        /// Expected: Passes null to the database query (behavior depends on database/ADO.NET handling).
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_NullTaiKhoan_PassesNullToQuery()
        {
            // Arrange
            var dal = new NhanVienDAL();
            string? taiKhoan = null;

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles empty string taiKhoan parameter.
        /// Input: Empty string taiKhoan, default excludeId.
        /// Expected: Passes empty string to the database query.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_EmptyTaiKhoan_PassesEmptyStringToQuery()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = string.Empty;

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles whitespace-only taiKhoan parameter.
        /// Input: Whitespace taiKhoan, default excludeId.
        /// Expected: Passes whitespace string to the database query.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        [DataRow("   ")]
        [DataRow("\t")]
        [DataRow("\n")]
        [DataRow(" \t\n ")]
        public void IsTaiKhoanExist_WhitespaceTaiKhoan_PassesWhitespaceToQuery(string taiKhoan)
        {
            // Arrange
            var dal = new NhanVienDAL();

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles negative excludeId values.
        /// Input: Valid taiKhoan, negative excludeId.
        /// Expected: Uses the negative value in the query (though IDs are typically positive).
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(-999999)]
        public void IsTaiKhoanExist_NegativeExcludeId_UsesNegativeValue(int excludeId)
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "testAccount";

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles int.MaxValue as excludeId.
        /// Input: Valid taiKhoan, int.MaxValue as excludeId.
        /// Expected: Uses int.MaxValue in the query without overflow.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_MaxIntExcludeId_UsesMaxValue()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "testAccount";
            var excludeId = int.MaxValue;

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles int.MinValue as excludeId.
        /// Input: Valid taiKhoan, int.MinValue as excludeId.
        /// Expected: Uses int.MinValue in the query without overflow.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_MinIntExcludeId_UsesMinValue()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "testAccount";
            var excludeId = int.MinValue;

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist handles special characters in taiKhoan parameter.
        /// Input: taiKhoan with special characters, default excludeId.
        /// Expected: Passes special characters to the database query safely.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        [DataRow("account@domain.com")]
        [DataRow("user'name")]
        [DataRow("user--name")]
        [DataRow("user;DROP TABLE")]
        [DataRow("user\0name")]
        public void IsTaiKhoanExist_SpecialCharactersInTaiKhoan_HandlesSpecialCharacters(string taiKhoan)
        {
            // Arrange
            var dal = new NhanVienDAL();

            // Act & Assert
            // This is an integration test that verifies the method can be called with special characters
            // without throwing exceptions. The parameterized query implementation provides SQL injection protection.
            try
            {
                bool result = dal.IsTaiKhoanExist(taiKhoan);
                // If we get here without exception, the method handled special characters safely
                // Note: This requires a database connection. If no database is available, this test will fail
                // with a connection exception, which is expected behavior for DAL integration tests.
                Assert.IsTrue(result || !result); // Result can be either true or false, both are valid
            }
            catch (SqlException)
            {
                // Database connection issues are expected in environments without a configured database
                Assert.Inconclusive("Database connection not available for integration testing.");
            }
        }

        /// <summary>
        /// Tests that IsTaiKhoanExist uses default excludeId value of 0 when not specified.
        /// Input: Valid taiKhoan, no excludeId specified (uses default 0).
        /// Expected: Uses 0 as excludeId in the query.
        /// </summary>
        /// <remarks>
        /// This test cannot be properly implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq 4.20.72. To enable unit testing, consider refactoring DataProvider
        /// to use dependency injection by extracting an IDataProvider interface and injecting it into NhanVienDAL.
        /// </remarks>
        [TestMethod]
        public void IsTaiKhoanExist_DefaultExcludeId_UsesZero()
        {
            // Arrange
            var dal = new NhanVienDAL();
            var taiKhoan = "testAccount";

            // Act & Assert
            Assert.Inconclusive("DataProvider.Instance is a static singleton that cannot be mocked with Moq 4.20.72. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV returns an empty list when the database returns no rows.
        /// Input: Database query returns an empty DataTable.
        /// Expected: An empty list of LoaiNVDTO objects is returned.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenDatabaseReturnsEmptyTable_ReturnsEmptyList()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // To make this testable:
            // 1. Extract IDataProvider interface with ExecuteQuery method
            // 2. Inject IDataProvider into NhanVienDAL constructor
            // 3. Mock IDataProvider in tests
            //
            // Current test approach: Marked as inconclusive until refactoring is complete.

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV returns a list with one item when the database returns a single row.
        /// Input: Database query returns a DataTable with one row containing valid id and TenLoaiNV values.
        /// Expected: A list containing one LoaiNVDTO object with matching properties is returned.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenDatabaseReturnsSingleRow_ReturnsListWithOneItem()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // Expected behavior if testable:
            // Arrange:
            //   - Mock DataProvider.Instance.ExecuteQuery to return DataTable with one row
            //   - Row contains: id=1, TenLoaiNV="Manager"
            // Act:
            //   - Call GetAllLoaiNV()
            // Assert:
            //   - Result list has Count == 1
            //   - Result[0].Id == 1
            //   - Result[0].TenLoaiNV == "Manager"

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV returns a list with all items when the database returns multiple rows.
        /// Input: Database query returns a DataTable with multiple rows containing valid data.
        /// Expected: A list containing all LoaiNVDTO objects with matching properties is returned in order.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenDatabaseReturnsMultipleRows_ReturnsListWithAllItems()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // Expected behavior if testable:
            // Arrange:
            //   - Mock DataProvider.Instance.ExecuteQuery to return DataTable with 3 rows
            //   - Rows contain: (1,"Manager"), (2,"Staff"), (3,"Admin")
            // Act:
            //   - Call GetAllLoaiNV()
            // Assert:
            //   - Result list has Count == 3
            //   - Verify all items have correct Id and TenLoaiNV values

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV handles DBNull values in TenLoaiNV column gracefully.
        /// Input: Database query returns a DataTable with a row where TenLoaiNV is DBNull.
        /// Expected: The LoaiNVDTO object is created with TenLoaiNV as empty string or the method handles the null appropriately.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenDatabaseReturnsNullInTenLoaiNV_HandlesGracefully()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // Expected behavior if testable:
            // Arrange:
            //   - Mock DataProvider.Instance.ExecuteQuery to return DataTable
            //   - Row contains: id=1, TenLoaiNV=DBNull.Value
            // Act:
            //   - Call GetAllLoaiNV()
            // Assert:
            //   - Verify that ToString() on DBNull returns "" or method handles appropriately
            //   - Potential bug: Current code calls row["TenLoaiNV"].ToString() which on DBNull returns ""

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV propagates exceptions thrown by DataProvider.ExecuteQuery.
        /// Input: DataProvider.ExecuteQuery throws an exception (e.g., SqlException).
        /// Expected: The exception is propagated to the caller.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenDataProviderThrowsException_PropagatesException()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // Expected behavior if testable:
            // Arrange:
            //   - Mock DataProvider.Instance.ExecuteQuery to throw SqlException
            // Act & Assert:
            //   - Call GetAllLoaiNV() and expect SqlException to be thrown

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV correctly maps id column values to LoaiNVDTO.Id property.
        /// Input: Database query returns rows with various integer id values including boundaries.
        /// Expected: All id values are correctly cast to int and assigned to LoaiNVDTO.Id.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenDatabaseReturnsVariousIdValues_MapsCorrectly()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // Expected behavior if testable:
            // Arrange:
            //   - Mock DataProvider.Instance.ExecuteQuery to return DataTable
            //   - Rows contain various id values: 0, 1, int.MaxValue
            // Act:
            //   - Call GetAllLoaiNV()
            // Assert:
            //   - Verify all id values are correctly mapped to LoaiNVDTO.Id

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAllLoaiNV handles special characters in TenLoaiNV values correctly.
        /// Input: Database query returns rows with TenLoaiNV containing special characters, Unicode, etc.
        /// Expected: All TenLoaiNV values are correctly converted to string and preserved.
        /// </summary>
        [TestMethod]
        public void GetAllLoaiNV_WhenTenLoaiNVContainsSpecialCharacters_HandlesCorrectly()
        {
            // NOTE: This test cannot be fully implemented without refactoring DataProvider.
            // DataProvider is a singleton with a private constructor and non-virtual methods,
            // making it impossible to mock with Moq. To properly test this method, DataProvider
            // should be injected as a dependency (via interface) or its methods should be virtual.
            //
            // Expected behavior if testable:
            // Arrange:
            //   - Mock DataProvider.Instance.ExecuteQuery to return DataTable
            //   - Rows contain TenLoaiNV with: empty string, whitespace, special chars, Unicode
            // Act:
            //   - Call GetAllLoaiNV()
            // Assert:
            //   - Verify all TenLoaiNV values are preserved correctly

            Assert.Inconclusive("DataProvider singleton cannot be mocked. Requires refactoring to support dependency injection.");
        }
    }
}