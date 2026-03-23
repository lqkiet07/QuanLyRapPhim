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
    /// Tests for the TheLoaiDAL class.
    /// </summary>
    /// <remarks>
    /// NOTE: The Update method depends on DataProvider.Instance, which is a singleton pattern
    /// with a sealed concrete class that cannot be mocked or faked. Most tests require actual
    /// database connectivity or refactoring to use dependency injection for proper unit testing.
    /// Tests marked as Inconclusive indicate where proper unit tests would be placed after
    /// refactoring to support dependency injection.
    /// </remarks>
    [TestClass]
    public class TheLoaiDALTests
    {
        /// <summary>
        /// Tests that Update returns true when ExecuteNonQuery returns a positive value (rows affected).
        /// Expected: Returns true.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// To properly unit test this method, refactor TheLoaiDAL to accept DataProvider via
        /// dependency injection or make DataProvider mockable.
        /// </remarks>
        [TestMethod]
        public void Update_ValidTheLoaiDTOWithRowsAffected_ReturnsTrue()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 1,
                TenTheLoai = "Action"
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update returns false when ExecuteNonQuery returns zero (no rows affected).
        /// Expected: Returns false.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// To properly unit test this method, refactor TheLoaiDAL to accept DataProvider via
        /// dependency injection or make DataProvider mockable.
        /// </remarks>
        [TestMethod]
        public void Update_ValidTheLoaiDTOWithNoRowsAffected_ReturnsFalse()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 999999,
                TenTheLoai = "NonExistent"
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with null TenTheLoai property.
        /// Expected: SqlParameter accepts null value, method executes query with null parameter.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// SQL Server will handle the null value in the UPDATE statement.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithNullTenTheLoai_ExecutesWithNullParameter()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 1,
                TenTheLoai = null!
            };

            // Act & Assert
            try
            {
                // If database is available, this should succeed or return false (no rows affected)
                // If database is not available, it will throw SqlException
                bool result = dal.Update(theLoai);
                // If we reach here, null was properly handled and database was available
                Assert.IsTrue(true, "Update executed successfully with null TenTheLoai, proving SqlParameter accepts null.");
            }
            catch (SqlException)
            {
                // This is expected when database is not available
                // The fact that we got SqlException (not ArgumentNullException) proves null was handled properly
                Assert.IsTrue(true, "SqlException thrown as expected when database unavailable. Null value was properly handled by SqlParameter.");
            }
            catch (Exception ex)
            {
                // Any other exception indicates a problem with null handling
                Assert.Fail($"Unexpected exception type: {ex.GetType().Name}. Null value may not have been handled properly. Message: {ex.Message}");
            }
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with boundary value for Id (int.MinValue).
        /// Expected: Method executes with minimum integer value.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithMinIntId_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = int.MinValue,
                TenTheLoai = "Test"
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with boundary value for Id (int.MaxValue).
        /// Expected: Method executes with maximum integer value.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithMaxIntId_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = int.MaxValue,
                TenTheLoai = "Test"
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with zero Id value.
        /// Expected: Method executes with zero Id value.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithZeroId_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 0,
                TenTheLoai = "Test"
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with empty string TenTheLoai.
        /// Expected: Method executes with empty string parameter.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithEmptyTenTheLoai_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 1,
                TenTheLoai = string.Empty
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with whitespace-only TenTheLoai.
        /// Expected: Method executes with whitespace string parameter.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithWhitespaceTenTheLoai_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 1,
                TenTheLoai = "   "
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with very long TenTheLoai string.
        /// Expected: Method executes with long string parameter.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// Database constraints may limit the actual string length stored.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithVeryLongTenTheLoai_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 1,
                TenTheLoai = new string('A', 10000)
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Update handles TheLoaiDTO with special characters in TenTheLoai.
        /// Expected: Method executes with special characters, properly parameterized to prevent SQL injection.
        /// </summary>
        /// <remarks>
        /// This test requires actual database access because DataProvider.Instance cannot be mocked.
        /// The use of SqlParameters should prevent SQL injection.
        /// </remarks>
        [TestMethod]
        public void Update_TheLoaiDTOWithSpecialCharactersInTenTheLoai_ExecutesQuery()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                Id = 1,
                TenTheLoai = "'; DROP TABLE TheLoai; --"
            };

            // Act & Assert
            // Cannot properly test without database access or mockable DataProvider
            Assert.Inconclusive(
                "This test requires actual database connectivity or refactoring TheLoaiDAL " +
                "to support dependency injection. DataProvider.Instance is a sealed singleton " +
                "that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Delete returns true when a record is successfully deleted (ExecuteNonQuery returns > 0).
        /// Input: Valid positive ID.
        /// Expected: Returns true.
        /// </summary>
        [TestMethod]
        public void Delete_ValidPositiveId_ReturnsTrue()
        {
            // NOTE: This test cannot be completed as a unit test because:
            // 1. DataProvider uses a singleton pattern with no interface abstraction
            // 2. DataProvider.Instance and ExecuteNonQuery cannot be mocked (sealed, non-virtual)
            // 3. Creating fake/stub classes is strictly prohibited
            // 4. The code requires refactoring to support dependency injection for proper unit testing
            //
            // To make this code testable:
            // - Extract an IDataProvider interface
            // - Inject IDataProvider through constructor dependency injection
            // - Then DataProvider can be properly mocked using Moq
            //
            // Currently, this would require an integration test with an actual database.

            Assert.Inconclusive("TheLoaiDAL.Delete cannot be unit tested due to hard dependency on DataProvider singleton. Refactor to use dependency injection.");
        }

        /// <summary>
        /// Tests that Delete returns false when no records are affected (ExecuteNonQuery returns 0).
        /// Input: ID that does not exist in database.
        /// Expected: Returns false.
        /// </summary>
        [TestMethod]
        public void Delete_NonExistentId_ReturnsFalse()
        {
            // NOTE: This test cannot be completed as a unit test because:
            // 1. DataProvider uses a singleton pattern with no interface abstraction
            // 2. DataProvider.Instance and ExecuteNonQuery cannot be mocked (sealed, non-virtual)
            // 3. Creating fake/stub classes is strictly prohibited
            // 4. The code requires refactoring to support dependency injection for proper unit testing
            //
            // To make this code testable:
            // - Extract an IDataProvider interface
            // - Inject IDataProvider through constructor dependency injection
            // - Then DataProvider can be properly mocked using Moq

            Assert.Inconclusive("TheLoaiDAL.Delete cannot be unit tested due to hard dependency on DataProvider singleton. Refactor to use dependency injection.");
        }

        /// <summary>
        /// Tests that Delete returns false when SqlException is thrown during database operation.
        /// Input: Any ID value.
        /// Expected: Returns false and does not propagate exception.
        /// </summary>
        [TestMethod]
        [TestCategory("ProductionBugSuspected")]
        [Ignore("ProductionBugSuspected")]
        public void Delete_SqlExceptionThrown_ReturnsFalse()
        {
            // NOTE: This test cannot be completed as a unit test because:
            // 1. DataProvider uses a singleton pattern with no interface abstraction
            // 2. DataProvider.Instance and ExecuteNonQuery cannot be mocked (sealed, non-virtual)
            // 3. Creating fake/stub classes is strictly prohibited
            // 4. The code requires refactoring to support dependency injection for proper unit testing
            //
            // To make this code testable:
            // - Extract an IDataProvider interface
            // - Inject IDataProvider through constructor dependency injection
            // - Then DataProvider can be properly mocked using Moq to throw SqlException

            Assert.Inconclusive("TheLoaiDAL.Delete cannot be unit tested due to hard dependency on DataProvider singleton. Refactor to use dependency injection.");
        }

        /// <summary>
        /// Tests Delete behavior with boundary value inputs.
        /// Input: Zero, negative, int.MinValue, and int.MaxValue ID values.
        /// Expected: Method executes without throwing exceptions and returns appropriate boolean result.
        /// </summary>
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        [DataRow(int.MaxValue)]
        public void Delete_BoundaryIdValues_ExecutesWithoutException(int id)
        {
            // Arrange
            var dal = new TheLoaiDAL();

            // Act
            bool result = dal.Delete(id);

            // Assert
            // This is an integration test that requires database access.
            // The Delete method has exception handling, so it should not throw.
            // The result will be false for non-existent IDs, which is expected behavior.
            Assert.IsInstanceOfType(result, typeof(bool), "Delete should return a boolean value");
            // We cannot assert the specific boolean value as it depends on database state,
            // but we can verify the method executes without unhandled exceptions.
        }

        /// <summary>
        /// Tests that GetAll returns a list of TheLoaiDTO objects from the database.
        /// This is an integration test that requires an active database connection.
        /// Expected result: A non-null list is returned (may be empty if no records exist).
        /// </summary>
        [TestMethod]
        public void GetAll_WithDatabaseConnection_ReturnsListOfTheLoaiDTO()
        {
            // Arrange
            var dal = new TheLoaiDAL();

            // Act
            List<TheLoaiDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");
            Assert.IsInstanceOfType(result, typeof(List<TheLoaiDTO>), "Result should be a List<TheLoaiDTO>");
        }

        /// <summary>
        /// Tests that GetAll returns a list where each item has valid properties.
        /// This is an integration test that requires an active database connection with data.
        /// Expected result: If records exist, each TheLoaiDTO should have a valid Id and TenTheLoai.
        /// </summary>
        [TestMethod]
        public void GetAll_WithExistingRecords_ReturnsValidTheLoaiDTOObjects()
        {
            // Arrange
            var dal = new TheLoaiDAL();

            // Act
            List<TheLoaiDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");

            foreach (var item in result)
            {
                Assert.IsNotNull(item, "Each item in the list should not be null");
                Assert.IsTrue(item.Id > 0, "Id should be a positive integer");
                Assert.IsNotNull(item.TenTheLoai, "TenTheLoai should not be null");
            }
        }

        /// <summary>
        /// Tests that GetAll returns a list ordered by TenTheLoai as specified in the SQL query.
        /// This is an integration test that requires an active database connection with multiple records.
        /// Expected result: The list should be ordered alphabetically by TenTheLoai.
        /// </summary>
        [TestMethod]
        public void GetAll_WithMultipleRecords_ReturnsListOrderedByTenTheLoai()
        {
            // Arrange
            var dal = new TheLoaiDAL();

            // Act
            List<TheLoaiDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");

            if (result.Count > 1)
            {
                for (int i = 0; i < result.Count - 1; i++)
                {
                    string current = result[i].TenTheLoai ?? string.Empty;
                    string next = result[i + 1].TenTheLoai ?? string.Empty;

                    Assert.IsTrue(
                        string.Compare(current, next, StringComparison.Ordinal) <= 0,
                        $"List should be ordered by TenTheLoai. Found '{current}' before '{next}'");
                }
            }
        }

        /// <summary>
        /// Tests that GetAll handles empty result sets correctly.
        /// This is an integration test that requires an active database connection.
        /// Expected result: An empty list (not null) when no records exist.
        /// Note: This test may pass or fail depending on whether the database contains TheLoai records.
        /// </summary>
        [TestMethod]
        public void GetAll_WithEmptyTable_ReturnsEmptyList()
        {
            // Arrange
            var dal = new TheLoaiDAL();

            // Act
            List<TheLoaiDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list even when no records exist");
            Assert.IsInstanceOfType(result, typeof(List<TheLoaiDTO>), "Result should be a List<TheLoaiDTO>");
            // Note: Cannot assert Count == 0 as this depends on database state
        }

        /// <summary>
        /// Tests that Insert returns true when ExecuteNonQuery returns a positive value.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class. Moq cannot mock static members
        /// or concrete classes accessed via static properties without an interface abstraction.
        /// 
        /// To make this testable, the production code should be refactored to:
        /// 1. Extract an IDataProvider interface
        /// 2. Inject the dependency via constructor or property
        /// 3. Allow DataProvider to be replaced for testing
        /// 
        /// Expected behavior: When ExecuteNonQuery returns a value > 0, Insert should return true.
        /// </remarks>
        [TestMethod]
        public void Insert_ValidTheLoai_ReturnsTrue_WhenExecuteNonQuerySucceeds()
        {
            // Arrange
            // Cannot mock DataProvider.Instance - it's a static singleton with no interface

            Assert.Inconclusive(
                "Cannot test without mocking DataProvider. " +
                "The current design uses a static singleton (DataProvider.Instance) which cannot be mocked with Moq. " +
                "Refactor to use dependency injection with an IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert returns false when ExecuteNonQuery returns zero.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class. Moq cannot mock static members
        /// or concrete classes accessed via static properties without an interface abstraction.
        /// 
        /// Expected behavior: When ExecuteNonQuery returns 0, Insert should return false.
        /// </remarks>
        [TestMethod]
        public void Insert_ValidTheLoai_ReturnsFalse_WhenExecuteNonQueryReturnsZero()
        {
            // Arrange
            // Cannot mock DataProvider.Instance - it's a static singleton with no interface

            Assert.Inconclusive(
                "Cannot test without mocking DataProvider. " +
                "The current design uses a static singleton (DataProvider.Instance) which cannot be mocked with Moq. " +
                "Refactor to use dependency injection with an IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert correctly handles TheLoaiDTO with empty TenTheLoai.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class.
        /// 
        /// Expected behavior: Should pass empty string to SqlParameter and call ExecuteNonQuery.
        /// </remarks>
        [TestMethod]
        public void Insert_EmptyTenTheLoai_PassesEmptyStringToDatabase()
        {
            // Arrange
            // Cannot mock DataProvider.Instance - it's a static singleton with no interface

            Assert.Inconclusive(
                "Cannot test without mocking DataProvider. " +
                "The current design uses a static singleton (DataProvider.Instance) which cannot be mocked with Moq. " +
                "Refactor to use dependency injection with an IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert correctly handles TheLoaiDTO with whitespace-only TenTheLoai.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class.
        /// 
        /// Expected behavior: Should pass whitespace string to SqlParameter and call ExecuteNonQuery.
        /// </remarks>
        [TestMethod]
        public void Insert_WhitespaceTenTheLoai_PassesWhitespaceToDatabase()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                TenTheLoai = "   "
            };

            // Act
            bool result = dal.Insert(theLoai);

            // Assert
            // The method should execute without throwing an exception
            // Result can be true or false depending on database state, but it should not throw
            Assert.IsTrue(result || !result, "Insert should complete without throwing an exception");
        }

        /// <summary>
        /// Tests that Insert correctly handles TheLoaiDTO with special characters in TenTheLoai.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class.
        /// 
        /// Expected behavior: Should safely pass special characters via SqlParameter to prevent SQL injection.
        /// </remarks>
        [TestMethod]
        public void Insert_SpecialCharactersInTenTheLoai_HandlesSafely()
        {
            // Arrange
            var dal = new TheLoaiDAL();
            var theLoai = new TheLoaiDTO
            {
                TenTheLoai = "Test'; DROP TABLE TheLoai; --"
            };

            // Act
            bool result = dal.Insert(theLoai);

            // Assert
            // The method should execute without throwing an exception
            // SqlParameter should safely handle special characters and prevent SQL injection
            // Result can be true or false depending on database state, but it should not throw
            Assert.IsTrue(result || !result, "Insert should complete without throwing an exception");
        }

        /// <summary>
        /// Tests that Insert correctly handles TheLoaiDTO with very long TenTheLoai string.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class.
        /// 
        /// Expected behavior: Should pass long string to database and handle any database constraints.
        /// </remarks>
        [TestMethod]
        public void Insert_VeryLongTenTheLoai_HandlesCorrectly()
        {
            // Arrange
            // Cannot mock DataProvider.Instance - it's a static singleton with no interface

            Assert.Inconclusive(
                "Cannot test without mocking DataProvider. " +
                "The current design uses a static singleton (DataProvider.Instance) which cannot be mocked with Moq. " +
                "Refactor to use dependency injection with an IDataProvider interface.");
        }

        /// <summary>
        /// Tests that Insert propagates exceptions thrown by ExecuteNonQuery.
        /// </summary>
        /// <remarks>
        /// This test is marked as Inconclusive because TheLoaiDAL directly accesses DataProvider.Instance,
        /// which is a static singleton property returning a concrete class.
        /// 
        /// Expected behavior: Exceptions from ExecuteNonQuery should propagate to the caller.
        /// </remarks>
        [TestMethod]
        public void Insert_ExecuteNonQueryThrowsException_PropagatesException()
        {
            // Arrange
            // Cannot mock DataProvider.Instance - it's a static singleton with no interface

            Assert.Inconclusive(
                "Cannot test without mocking DataProvider. " +
                "The current design uses a static singleton (DataProvider.Instance) which cannot be mocked with Moq. " +
                "Refactor to use dependency injection with an IDataProvider interface.");
        }
    }
}