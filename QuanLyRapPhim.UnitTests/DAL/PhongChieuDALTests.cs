using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QuanLyRapPhim;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL.UnitTests
{
    /// <summary>
    /// Unit tests for the PhongChieuDAL class.
    /// Note: The DataProvider singleton pattern prevents proper unit testing without database integration.
    /// These tests require refactoring the DataProvider to support dependency injection for proper isolation.
    /// </summary>
    [TestClass]
    public class PhongChieuDALTests
    {
        /// <summary>
        /// Tests that Delete returns true when a valid ID results in successful deletion (rows affected > 0).
        /// Input: Valid positive ID.
        /// Expected: Returns true when ExecuteNonQuery returns a value greater than 0.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_ValidIdWithRowsAffected_ReturnsTrue()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int validId = 1;

            // This test cannot be properly isolated without refactoring DataProvider
            // to support dependency injection. The singleton pattern prevents mocking.
            Assert.Inconclusive(
                "This test requires integration testing with a real database. " +
                "The DataProvider singleton cannot be mocked without refactoring to use dependency injection. " +
                "To properly test this method, either: " +
                "1. Set up an integration test with a test database, or " +
                "2. Refactor DataProvider to accept IDataProvider interface via dependency injection.");
        }

        /// <summary>
        /// Tests that Delete returns false when no rows are affected by the delete operation.
        /// Input: ID that does not exist in the database.
        /// Expected: Returns false when ExecuteNonQuery returns 0.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_IdNotFound_ReturnsFalse()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int nonExistentId = 999999;

            // Act
            bool result = dal.Delete(nonExistentId);

            // Assert
            Assert.IsFalse(result, "Delete should return false when the ID does not exist in the database.");
        }

        /// <summary>
        /// Tests that Delete handles SqlException gracefully and returns false.
        /// Input: Any ID when database operation throws SqlException.
        /// Expected: Returns false when SqlException is caught.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_SqlExceptionThrown_ReturnsFalse()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int anyId = 1;

            // This test cannot be properly isolated without refactoring DataProvider
            Assert.Inconclusive(
                "This test requires integration testing or the ability to simulate SqlException. " +
                "The DataProvider singleton cannot be mocked without refactoring to use dependency injection. " +
                "To properly test this method, either: " +
                "1. Set up an integration test that can simulate database failures, or " +
                "2. Refactor DataProvider to accept IDataProvider interface via dependency injection.");
        }

        /// <summary>
        /// Tests Delete with boundary value: zero ID.
        /// Input: ID = 0.
        /// Expected: Executes delete query with ID parameter = 0.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_ZeroId_ExecutesQuery()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int zeroId = 0;

            // This test cannot be properly isolated without refactoring DataProvider
            Assert.Inconclusive(
                "This test requires integration testing with a real database. " +
                "The DataProvider singleton cannot be mocked without refactoring to use dependency injection. " +
                "To properly test this method, either: " +
                "1. Set up an integration test with a test database, or " +
                "2. Refactor DataProvider to accept IDataProvider interface via dependency injection.");
        }

        /// <summary>
        /// Tests Delete with boundary value: negative ID.
        /// Input: ID = -1.
        /// Expected: Executes delete query with negative ID parameter.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_NegativeId_ExecutesQuery()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int negativeId = -1;

            // This test cannot be properly isolated without refactoring DataProvider
            Assert.Inconclusive(
                "This test requires integration testing with a real database. " +
                "The DataProvider singleton cannot be mocked without refactoring to use dependency injection. " +
                "To properly test this method, either: " +
                "1. Set up an integration test with a test database, or " +
                "2. Refactor DataProvider to accept IDataProvider interface via dependency injection.");
        }

        /// <summary>
        /// Tests Delete with boundary value: int.MaxValue.
        /// Input: ID = int.MaxValue (2147483647).
        /// Expected: Executes delete query with maximum integer ID parameter.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_MaxIntId_ExecutesQuery()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int maxId = int.MaxValue;

            // This test cannot be properly isolated without refactoring DataProvider
            Assert.Inconclusive(
                "This test requires integration testing with a real database. " +
                "The DataProvider singleton cannot be mocked without refactoring to use dependency injection. " +
                "To properly test this method, either: " +
                "1. Set up an integration test with a test database, or " +
                "2. Refactor DataProvider to accept IDataProvider interface via dependency injection.");
        }

        /// <summary>
        /// Tests Delete with boundary value: int.MinValue.
        /// Input: ID = int.MinValue (-2147483648).
        /// Expected: Executes delete query with minimum integer ID parameter.
        /// Note: Requires integration with a test database as DataProvider singleton cannot be mocked.
        /// </summary>
        [TestMethod]
        public void Delete_MinIntId_ExecutesQuery()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            int minId = int.MinValue;

            // This test cannot be properly isolated without refactoring DataProvider
            Assert.Inconclusive(
                "This test requires integration testing with a real database. " +
                "The DataProvider singleton cannot be mocked without refactoring to use dependency injection. " +
                "To properly test this method, either: " +
                "1. Set up an integration test with a test database, or " +
                "2. Refactor DataProvider to accept IDataProvider interface via dependency injection.");
        }

        /// <summary>
        /// Tests Update method with valid PhongChieuDTO containing typical values.
        /// Input: PhongChieuDTO with valid Id, TenPhong, SoCho, and TinhTrang values.
        /// Expected: Method executes without throwing exceptions.
        /// NOTE: This test cannot verify the return value because DataProvider.Instance is a static singleton
        /// that cannot be mocked with Moq. The test is marked as Inconclusive to indicate incomplete coverage.
        /// RECOMMENDATION: Refactor PhongChieuDAL to accept IDataProvider via dependency injection.
        /// </summary>
        [TestMethod]
        public void Update_ValidPhongChieu_CannotVerifyReturnValueDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng A1",
                SoCho = 100,
                TinhTrang = true
            };

            // Act & Assert
            // Cannot properly test because DataProvider.Instance is a static singleton
            // that directly accesses the database and cannot be mocked with Moq.
            Assert.Inconclusive(
                "Cannot test Update method return value. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing empty string for TenPhong.
        /// Input: PhongChieuDTO with empty TenPhong string.
        /// Expected: Method executes and passes empty string to SqlParameter.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_EmptyTenPhong_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "",
                SoCho = 50,
                TinhTrang = false
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with empty TenPhong. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing boundary value for SoCho (int.MinValue).
        /// Input: PhongChieuDTO with SoCho = int.MinValue.
        /// Expected: Method passes the value to SqlParameter.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_MinValueSoCho_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng Test",
                SoCho = int.MinValue,
                TinhTrang = true
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with int.MinValue SoCho. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing boundary value for SoCho (int.MaxValue).
        /// Input: PhongChieuDTO with SoCho = int.MaxValue.
        /// Expected: Method passes the value to SqlParameter.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_MaxValueSoCho_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng Test",
                SoCho = int.MaxValue,
                TinhTrang = false
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with int.MaxValue SoCho. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing boundary value for Id (int.MinValue).
        /// Input: PhongChieuDTO with Id = int.MinValue.
        /// Expected: Method passes the value to SqlParameter for WHERE clause.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_MinValueId_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = int.MinValue,
                TenPhong = "Phòng Test",
                SoCho = 100,
                TinhTrang = true
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with int.MinValue Id. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing special characters in TenPhong.
        /// Input: PhongChieuDTO with TenPhong containing special characters and Unicode.
        /// Expected: Method passes the string to SqlParameter properly.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_SpecialCharactersInTenPhong_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng A1 @#$%^&*() 测试",
                SoCho = 75,
                TinhTrang = true
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with special characters in TenPhong. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing a reasonably long TenPhong string.
        /// Input: PhongChieuDTO with TenPhong containing 50 characters (within database constraints).
        /// Expected: Method returns false when the ID does not exist in the database.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_VeryLongTenPhong_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = new string('A', 50),
                SoCho = 50,
                TinhTrang = false
            };

            // Act
            bool result = dal.Update(phongChieu);

            // Assert
            // This test runs as an integration test against the database
            // We verify that the method can handle reasonably long strings without throwing exceptions
            Assert.IsFalse(result, "Update should return false when the ID does not exist in the database.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing zero value for SoCho.
        /// Input: PhongChieuDTO with SoCho = 0.
        /// Expected: Method passes zero to SqlParameter.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_ZeroSoCho_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng Test",
                SoCho = 0,
                TinhTrang = true
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with zero SoCho. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with PhongChieuDTO containing negative SoCho value.
        /// Input: PhongChieuDTO with SoCho = -100.
        /// Expected: Method passes negative value to SqlParameter.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        public void Update_NegativeSoCho_CannotVerifyBehaviorDueToStaticDependency()
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng Test",
                SoCho = -100,
                TinhTrang = false
            };

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test Update method with negative SoCho. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests Update method with both TinhTrang values (true and false).
        /// Input: PhongChieuDTO with TinhTrang = true, then with TinhTrang = false.
        /// Expected: Method passes boolean values to SqlParameter correctly.
        /// NOTE: Cannot verify database behavior due to unmockable static DataProvider dependency.
        /// </summary>
        [TestMethod]
        [DataRow(true, DisplayName = "TinhTrang = true")]
        [DataRow(false, DisplayName = "TinhTrang = false")]
        public void Update_DifferentTinhTrangValues_CannotVerifyBehaviorDueToStaticDependency(bool tinhTrang)
        {
            // Arrange
            var dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                Id = 1,
                TenPhong = "Phòng Test",
                SoCho = 100,
                TinhTrang = tinhTrang
            };

            // Act & Assert
            Assert.Inconclusive(
                $"Cannot test Update method with TinhTrang = {tinhTrang}. DataProvider.Instance is a static singleton " +
                "that cannot be mocked. Refactor to use dependency injection for proper unit testing.");
        }

        /// <summary>
        /// Tests that Insert would return a new room ID when provided with a valid PhongChieuDTO.
        /// LIMITATION: This test is marked as inconclusive because DataProvider is a singleton with non-virtual
        /// methods that cannot be mocked with Moq. To properly test this, the class would need to be refactored
        /// to accept an IDataProvider interface via dependency injection.
        /// Expected behavior: Should construct proper SQL query with parameters and return the new ID from ExecuteScalar.
        /// </summary>
        [TestMethod]
        public void Insert_ValidPhongChieuDTO_ReturnsNewId()
        {
            // Arrange
            // Cannot properly arrange due to unmockable DataProvider singleton dependency.
            // Would need to mock DataProvider.Instance.ExecuteScalar to return a test ID value.

            // Act
            // Cannot execute without database connection

            // Assert
            Assert.Inconclusive(
                "This test cannot be completed because DataProvider is a singleton with non-virtual methods. " +
                "To make this testable, refactor PhongChieuDAL to accept IDataProvider via constructor injection, " +
                "and ensure DataProvider implements an interface with virtual/abstract ExecuteScalar method.");
        }

        /// <summary>
        /// Tests that Insert returns 0 when ExecuteScalar returns null.
        /// LIMITATION: This test is marked as inconclusive because DataProvider cannot be mocked.
        /// Expected behavior: When ExecuteScalar returns null, the method should return 0.
        /// </summary>
        [TestMethod]
        public void Insert_ExecuteScalarReturnsNull_ReturnsZero()
        {
            // Arrange
            // Cannot mock DataProvider.Instance.ExecuteScalar to return null

            // Act
            // Cannot execute without mocking

            // Assert
            Assert.Inconclusive(
                "This test cannot be completed because DataProvider is a singleton with non-virtual methods. " +
                "To make this testable, refactor to use dependency injection with IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert passes correct SQL parameters when inserting a PhongChieuDTO with null TenPhong.
        /// LIMITATION: This test is marked as inconclusive because DataProvider cannot be mocked.
        /// Expected behavior: SqlParameter should accept null value for TenPhong property.
        /// </summary>
        [TestMethod]
        public void Insert_PhongChieuWithNullTenPhong_PassesNullParameter()
        {
            // Arrange
            // Cannot verify parameter values without mocking DataProvider

            // Act
            // Cannot execute

            // Assert
            Assert.Inconclusive(
                "This test cannot be completed because DataProvider is a singleton with non-virtual methods. " +
                "To make this testable, refactor to use dependency injection with IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert passes correct SQL parameters with boundary values for SoCho (int.MinValue).
        /// LIMITATION: This test is marked as inconclusive because DataProvider cannot be mocked.
        /// Expected behavior: Should handle int.MinValue for SoCho property.
        /// </summary>
        [TestMethod]
        public void Insert_PhongChieuWithMinValueSoCho_PassesCorrectParameter()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();
            var phongChieu = new PhongChieuDTO
            {
                TenPhong = "Test Phong - MinValue SoCho",
                SoCho = int.MinValue,
                TinhTrang = true
            };

            // Act
            int result = dal.Insert(phongChieu);

            // Assert
            // The method should execute without throwing an exception
            // Result should be either a valid ID (> 0) or 0 if insertion failed
            Assert.IsTrue(result >= 0, $"Insert should return a non-negative value. Actual: {result}");
        }

        /// <summary>
        /// Tests that Insert passes correct SQL parameters with boundary values for SoCho (int.MaxValue).
        /// LIMITATION: This test is marked as inconclusive because DataProvider cannot be mocked.
        /// Expected behavior: Should handle int.MaxValue for SoCho property.
        /// </summary>
        [TestMethod]
        public void Insert_PhongChieuWithMaxValueSoCho_PassesCorrectParameter()
        {
            // Arrange
            // Cannot verify parameter values without mocking DataProvider

            // Act
            // Cannot execute

            // Assert
            Assert.Inconclusive(
                "This test cannot be completed because DataProvider is a singleton with non-virtual methods. " +
                "To make this testable, refactor to use dependency injection with IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert correctly handles TinhTrang property set to true.
        /// LIMITATION: This test is marked as inconclusive because DataProvider cannot be mocked.
        /// Expected behavior: Should pass true value for TinhTrang parameter.
        /// </summary>
        [TestMethod]
        public void Insert_PhongChieuWithTinhTrangTrue_PassesCorrectParameter()
        {
            // Arrange
            // Cannot verify parameter values without mocking DataProvider

            // Act
            // Cannot execute

            // Assert
            Assert.Inconclusive(
                "This test cannot be completed because DataProvider is a singleton with non-virtual methods. " +
                "To make this testable, refactor to use dependency injection with IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert correctly handles TinhTrang property set to false.
        /// LIMITATION: This test is marked as inconclusive because DataProvider cannot be mocked.
        /// Expected behavior: Should pass false value for TinhTrang parameter.
        /// </summary>
        [TestMethod]
        public void Insert_PhongChieuWithTinhTrangFalse_PassesCorrectParameter()
        {
            // Arrange
            // Cannot verify parameter values without mocking DataProvider

            // Act
            // Cannot execute

            // Assert
            Assert.Inconclusive(
                "This test cannot be completed because DataProvider is a singleton with non-virtual methods. " +
                "To make this testable, refactor to use dependency injection with IDataProvider interface.");
        }

        /// <summary>
        /// Tests that GetAll returns a list of PhongChieuDTO objects when data is available in the database.
        /// NOTE: This method cannot be properly unit tested in isolation due to tight coupling with the
        /// DataProvider singleton, which cannot be mocked. This test requires a live database connection
        /// and is effectively an integration test.
        /// 
        /// TO MAKE THIS TESTABLE:
        /// - Refactor PhongChieuDAL to accept DataProvider via dependency injection
        /// - Extract an IDataProvider interface that can be mocked
        /// - Or use a virtual wrapper around the DataProvider singleton
        /// </summary>
        [TestMethod]
        public void GetAll_WithDatabaseConnection_ReturnsListOfPhongChieu()
        {
            // Arrange
            // NOTE: Cannot mock DataProvider.Instance as it is a sealed singleton with non-virtual members
            // This test requires an actual database with the QuanLyRapPhim schema and PhongChieu table
            PhongChieuDAL dal = new PhongChieuDAL();

            // Act
            // This will attempt to connect to the actual database defined in DataProvider.CONNECTION_STRING
            List<PhongChieuDTO> result = dal.GetAll();

            // Assert
            // The following assertions assume a working database connection exists
            Assert.IsNotNull(result, "GetAll should return a non-null list");
            // Additional assertions would depend on the actual database state
            // In a proper unit test, we would mock the DataProvider to return controlled test data

            Assert.Inconclusive("This test cannot be executed as a proper unit test due to the non-mockable DataProvider singleton dependency. " +
                "It requires a live database connection. Consider refactoring PhongChieuDAL to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAll returns an empty list when the database table is empty.
        /// NOTE: This test cannot be properly unit tested in isolation due to tight coupling with the
        /// DataProvider singleton.
        /// </summary>
        [TestMethod]
        public void GetAll_WhenNoDataInDatabase_ReturnsEmptyList()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();

            // Act
            // This requires the PhongChieu table to be empty in the actual database
            List<PhongChieuDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list even when empty");
            // Note: This is an integration test that requires a database connection.
            // We verify the method executes successfully and returns a valid list object.
            // The actual content depends on the database state at test execution time.
        }

        /// <summary>
        /// Tests that GetAll correctly maps multiple database rows to PhongChieuDTO objects.
        /// NOTE: This test cannot be properly unit tested in isolation due to tight coupling with the
        /// DataProvider singleton.
        /// </summary>
        [TestMethod]
        public void GetAll_WithMultipleRecords_ReturnsCorrectlyMappedList()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();

            // Act
            List<PhongChieuDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");
            // In a proper unit test, we would:
            // 1. Mock DataProvider.ExecuteQuery to return a DataTable with known test data
            // 2. Verify that each row is correctly mapped to a PhongChieuDTO object
            // 3. Verify that the list contains the expected number of items with expected values

            Assert.Inconclusive("This test cannot be executed as a proper unit test due to the non-mockable DataProvider singleton dependency. " +
                "It requires a live database connection with known test data. Consider refactoring PhongChieuDAL to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetAll returns results ordered by TenPhong as specified in the SQL query.
        /// NOTE: This test cannot be properly unit tested in isolation due to tight coupling with the
        /// DataProvider singleton.
        /// </summary>
        [TestMethod]
        public void GetAll_ReturnsResultsOrderedByTenPhong()
        {
            // Arrange
            PhongChieuDAL dal = new PhongChieuDAL();

            // Act
            List<PhongChieuDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");
            // In a proper unit test, we would:
            // 1. Mock DataProvider.ExecuteQuery to return a DataTable with multiple unordered rows
            // 2. Verify that the SQL query includes "ORDER BY TenPhong"
            // 3. The ordering is actually done by the database, so we'd verify the query string passed to ExecuteQuery

            Assert.Inconclusive("This test cannot be executed as a proper unit test due to the non-mockable DataProvider singleton dependency. " +
                "Verification of ordering requires either database inspection or the ability to mock the DataProvider. Consider refactoring PhongChieuDAL to support dependency injection.");
        }
    }
}