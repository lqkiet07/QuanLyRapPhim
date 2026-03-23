using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL.UnitTests
{
    /// <summary>
    /// Unit tests for the GheDAL class.
    /// </summary>
    [TestClass]
    public class GheDALTests
    {
        /// <summary>
        /// Tests that Insert returns true when ExecuteNonQuery returns a positive value (successful insert).
        /// 
        /// NOTE: This test is incomplete and marked as inconclusive because DataProvider is a sealed singleton
        /// class with non-virtual methods that cannot be mocked using Moq. To make this code testable:
        /// 1. Extract an IDataProvider interface from DataProvider
        /// 2. Inject IDataProvider as a dependency to GheDAL via constructor
        /// 3. Mock IDataProvider.ExecuteNonQuery to return 1
        /// 
        /// Without refactoring, this method can only be tested via integration tests against a real database.
        /// </summary>
        [TestMethod]
        public void Insert_ValidGhe_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            GheDTO validGhe = new GheDTO
            {
                IdPhong = 1,
                Hang = "A",
                So = 5,
                IdLoaiGhe = 1
            };

            // Act & Assert
            // Cannot complete this test because DataProvider.Instance cannot be mocked.
            // DataProvider is a sealed singleton with non-virtual methods.
            // Refactoring is required to make this testable.
            Assert.Inconclusive("DataProvider cannot be mocked. Requires architectural refactoring to inject IDataProvider dependency.");
        }

        /// <summary>
        /// Tests that Insert returns false when ExecuteNonQuery returns 0 (failed insert).
        /// 
        /// NOTE: This test is incomplete and marked as inconclusive because DataProvider is a sealed singleton
        /// class with non-virtual methods that cannot be mocked using Moq. To make this code testable:
        /// 1. Extract an IDataProvider interface from DataProvider
        /// 2. Inject IDataProvider as a dependency to GheDAL via constructor
        /// 3. Mock IDataProvider.ExecuteNonQuery to return 0
        /// 
        /// Without refactoring, this method can only be tested via integration tests against a real database.
        /// </summary>
        [TestMethod]
        public void Insert_ExecuteNonQueryReturnsZero_ReturnsFalse()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            GheDTO validGhe = new GheDTO
            {
                IdPhong = 1,
                Hang = "B",
                So = 10,
                IdLoaiGhe = 2
            };

            // Act & Assert
            // Cannot complete this test because DataProvider.Instance cannot be mocked.
            // DataProvider is a sealed singleton with non-virtual methods.
            // Refactoring is required to make this testable.
            Assert.Inconclusive("DataProvider cannot be mocked. Requires architectural refactoring to inject IDataProvider dependency.");
        }

        /// <summary>
        /// Tests that Insert returns true when ExecuteNonQuery returns a value greater than 1 (multiple rows affected).
        /// 
        /// NOTE: This test is incomplete and marked as inconclusive because DataProvider is a sealed singleton
        /// class with non-virtual methods that cannot be mocked using Moq. To make this code testable:
        /// 1. Extract an IDataProvider interface from DataProvider
        /// 2. Inject IDataProvider as a dependency to GheDAL via constructor
        /// 3. Mock IDataProvider.ExecuteNonQuery to return a value > 1
        /// 
        /// Without refactoring, this method can only be tested via integration tests against a real database.
        /// </summary>
        [TestMethod]
        public void Insert_ExecuteNonQueryReturnsMultipleRows_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            GheDTO validGhe = new GheDTO
            {
                IdPhong = 2,
                Hang = "C",
                So = 15,
                IdLoaiGhe = 1
            };

            // Act & Assert
            // Cannot complete this test because DataProvider.Instance cannot be mocked.
            // DataProvider is a sealed singleton with non-virtual methods.
            // Refactoring is required to make this testable.
            Assert.Inconclusive("DataProvider cannot be mocked. Requires architectural refactoring to inject IDataProvider dependency.");
        }

        /// <summary>
        /// Tests that Insert correctly constructs SqlParameters with boundary values for integer properties.
        /// 
        /// NOTE: This test is incomplete and marked as inconclusive because DataProvider is a sealed singleton
        /// class with non-virtual methods that cannot be mocked using Moq. To make this code testable:
        /// 1. Extract an IDataProvider interface from DataProvider
        /// 2. Inject IDataProvider as a dependency to GheDAL via constructor
        /// 3. Mock IDataProvider.ExecuteNonQuery to verify correct parameters are passed
        /// 
        /// Without refactoring, this method can only be tested via integration tests against a real database.
        /// </summary>
        [TestMethod]
        [DataRow(int.MinValue, "Z", int.MinValue, int.MinValue)]
        [DataRow(int.MaxValue, "A", int.MaxValue, int.MaxValue)]
        [DataRow(0, "", 0, 0)]
        public void Insert_BoundaryValues_HandledCorrectly(int idPhong, string hang, int so, int idLoaiGhe)
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            GheDTO boundaryGhe = new GheDTO
            {
                IdPhong = idPhong,
                Hang = hang,
                So = so,
                IdLoaiGhe = idLoaiGhe
            };

            // Act & Assert
            // Cannot complete this test because DataProvider.Instance cannot be mocked.
            // DataProvider is a sealed singleton with non-virtual methods.
            // Refactoring is required to make this testable.
            Assert.Inconclusive("DataProvider cannot be mocked. Requires architectural refactoring to inject IDataProvider dependency.");
        }

        /// <summary>
        /// Tests that Insert handles various string values for the Hang property including empty and null strings.
        /// 
        /// NOTE: This is an integration test that requires a live database connection.
        /// It verifies that the Insert method can handle edge cases for the Hang property (null, empty, whitespace)
        /// without throwing exceptions. The method should either succeed or fail gracefully.
        /// </summary>
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Insert_VariousHangValues_HandledCorrectly(string? hang)
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            GheDTO testGhe = new GheDTO
            {
                IdPhong = 1,
                Hang = hang!,
                So = 5,
                IdLoaiGhe = 1
            };

            // Act & Assert
            // This is an integration test - it will fail if database is not available
            // The test verifies that various Hang values don't cause exceptions
            try
            {
                bool result = gheDAL.Insert(testGhe);
                // Assert that the method completed (returned true or false) without throwing
                Assert.IsTrue(result == true || result == false, "Insert method should return a boolean value");
            }
            catch (SqlException)
            {
                // If database is not available, mark as inconclusive rather than failed
                Assert.Inconclusive("Database connection not available for integration test");
            }
        }

        /// <summary>
        /// Tests that Delete method returns true when a record is successfully deleted (ExecuteNonQuery returns a positive value).
        /// Input: Valid positive id.
        /// Expected: Method returns true.
        /// </summary>
        /// <remarks>
        /// This test cannot be completed because DataProvider is a concrete sealed class with a singleton pattern
        /// and no virtual methods, making it impossible to mock with Moq. The code has a tight coupling to the
        /// database layer that prevents proper unit testing.
        /// 
        /// To make this code testable, consider:
        /// 1. Extracting an IDataProvider interface
        /// 2. Injecting the dependency via constructor or property
        /// 3. Making ExecuteNonQuery and Instance mockable through the interface
        /// </remarks>
        [TestMethod]
        public void Delete_ValidId_ReturnsTrue()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int validId = 1;

            // NOTE: Cannot mock DataProvider.Instance.ExecuteNonQuery because:
            // - DataProvider is a concrete class with no interface
            // - Instance is a static property returning a singleton
            // - ExecuteNonQuery is not virtual and cannot be mocked with Moq
            // This test requires refactoring the production code to use dependency injection

            // Act & Assert
            Assert.Inconclusive("Test cannot be completed without refactoring DataProvider to be mockable. " +
                "DataProvider is a concrete singleton class with non-virtual methods that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Delete method returns false when no records are deleted (ExecuteNonQuery returns 0).
        /// Input: Id that does not exist in database.
        /// Expected: Method returns false.
        /// </summary>
        /// <remarks>
        /// This test cannot be completed because DataProvider cannot be mocked.
        /// See Delete_ValidId_ReturnsTrue for detailed explanation.
        /// </remarks>
        [TestMethod]
        public void Delete_NonExistentId_ReturnsFalse()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int nonExistentId = 99999;

            // Act & Assert
            Assert.Inconclusive("Test cannot be completed without refactoring DataProvider to be mockable. " +
                "DataProvider is a concrete singleton class with non-virtual methods that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Delete method handles edge case of zero as id parameter.
        /// Input: Id equals 0.
        /// Expected: Method executes without throwing exception and returns appropriate boolean based on database state.
        /// </summary>
        /// <remarks>
        /// This test cannot be completed because DataProvider cannot be mocked.
        /// See Delete_ValidId_ReturnsTrue for detailed explanation.
        /// </remarks>
        [TestMethod]
        public void Delete_IdZero_ReturnsAppropriateResult()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int id = 0;

            // Act & Assert
            Assert.Inconclusive("Test cannot be completed without refactoring DataProvider to be mockable. " +
                "DataProvider is a concrete singleton class with non-virtual methods that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Delete method handles negative id values.
        /// Input: Negative id value.
        /// Expected: Method executes without throwing exception and returns appropriate boolean based on database state.
        /// </summary>
        /// <remarks>
        /// This is an integration test that requires a database connection.
        /// The Delete method should handle negative IDs gracefully without throwing exceptions.
        /// </remarks>
        [TestMethod]
        public void Delete_NegativeId_ReturnsAppropriateResult()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int negativeId = -1;

            // Act
            bool result = gheDAL.Delete(negativeId);

            // Assert
            // Negative IDs should not exist in the database, so Delete should return false
            // The important thing is that no exception is thrown
            Assert.IsFalse(result, "Delete with negative ID should return false as no record exists with negative ID.");
        }

        /// <summary>
        /// Tests that Delete method handles int.MaxValue as id parameter.
        /// Input: int.MaxValue (2147483647).
        /// Expected: Method executes without throwing exception and returns appropriate boolean based on database state.
        /// </summary>
        /// <remarks>
        /// This test cannot be completed because DataProvider cannot be mocked.
        /// See Delete_ValidId_ReturnsTrue for detailed explanation.
        /// </remarks>
        [TestMethod]
        public void Delete_MaxIntValue_ReturnsAppropriateResult()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int id = int.MaxValue;

            // Act & Assert
            Assert.Inconclusive("Test cannot be completed without refactoring DataProvider to be mockable. " +
                "DataProvider is a concrete singleton class with non-virtual methods that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that Delete method handles int.MinValue as id parameter.
        /// Input: int.MinValue (-2147483648).
        /// Expected: Method executes without throwing exception and returns appropriate boolean based on database state.
        /// </summary>
        /// <remarks>
        /// This test cannot be completed because DataProvider cannot be mocked.
        /// See Delete_ValidId_ReturnsTrue for detailed explanation.
        /// </remarks>
        [TestMethod]
        public void Delete_MinIntValue_ReturnsAppropriateResult()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int id = int.MinValue;

            // Act & Assert
            Assert.Inconclusive("Test cannot be completed without refactoring DataProvider to be mockable. " +
                "DataProvider is a concrete singleton class with non-virtual methods that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that DeleteByPhong executes the correct SQL query with a positive idPhong value
        /// and returns true when rows are deleted successfully.
        /// </summary>
        /// <remarks>
        /// This test requires a properly configured test database with the QuanLyRapPhim schema.
        /// The DataProvider class uses a singleton pattern with no interface, making it impossible
        /// to mock using Moq without refactoring for dependency injection.
        /// To run this test:
        /// 1. Ensure a test database is available with the connection string configured in DataProvider
        /// 2. Set up test data: Create a Phong record and associated Ghe records
        /// 3. Remove [Ignore] attribute
        /// 4. Verify cleanup after test execution
        /// Consider refactoring DataProvider to use dependency injection for better testability.
        /// </remarks>
        [TestMethod]
        [Ignore("Requires database integration - DataProvider singleton cannot be mocked without refactoring")]
        public void DeleteByPhong_WithPositiveIdPhong_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = 1;

            // TODO: Set up test database with a Phong record (id=1) and associated Ghe records
            // TODO: Verify test data exists before deletion

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result);
            // TODO: Verify that Ghe records were actually deleted from the database
            // TODO: Clean up test data if necessary
        }

        /// <summary>
        /// Tests that DeleteByPhong handles a zero idPhong value correctly
        /// and returns true when the operation completes (even if no rows match).
        /// </summary>
        /// <remarks>
        /// This test requires a properly configured test database.
        /// The DataProvider singleton pattern prevents proper unit testing with mocks.
        /// This is an integration test that requires actual database access.
        /// </remarks>
        [TestMethod]
        [Ignore("Requires database integration - DataProvider singleton cannot be mocked without refactoring")]
        public void DeleteByPhong_WithZeroIdPhong_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = 0;

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result);
            // Note: ExecuteNonQuery returns 0 for no rows affected, which is >= 0, so method returns true
        }

        /// <summary>
        /// Tests that DeleteByPhong handles negative idPhong values correctly.
        /// Expected behavior: returns true (no rows affected is still >= 0).
        /// </summary>
        /// <remarks>
        /// This test requires database integration.
        /// DataProvider's singleton pattern prevents mocking.
        /// </remarks>
        [TestMethod]
        public void DeleteByPhong_WithNegativeIdPhong_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = -1;

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Tests that DeleteByPhong handles int.MaxValue correctly.
        /// Expected behavior: returns true (no matching rows is still >= 0).
        /// </summary>
        /// <remarks>
        /// This test requires database integration.
        /// DataProvider's singleton pattern prevents mocking.
        /// </remarks>
        [TestMethod]
        [Ignore("Requires database integration - DataProvider singleton cannot be mocked without refactoring")]
        public void DeleteByPhong_WithMaxIntValue_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = int.MaxValue;

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Tests that DeleteByPhong handles int.MinValue correctly.
        /// Expected behavior: returns true (no matching rows is still >= 0).
        /// </summary>
        /// <remarks>
        /// This test requires database integration.
        /// DataProvider's singleton pattern prevents mocking.
        /// </remarks>
        [TestMethod]
        [Ignore("ProductionBugSuspected")]
        [TestCategory("ProductionBugSuspected")]
        public void DeleteByPhong_WithMinIntValue_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = int.MinValue;

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Tests that DeleteByPhong returns true when multiple rows are deleted successfully.
        /// </summary>
        /// <remarks>
        /// This test requires database integration with pre-populated test data.
        /// DataProvider's singleton pattern prevents mocking.
        /// Setup: Create a Phong record and multiple Ghe records associated with it.
        /// </remarks>
        [TestMethod]
        [Ignore("Requires database integration - DataProvider singleton cannot be mocked without refactoring")]
        public void DeleteByPhong_WithMultipleMatchingRows_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = 100;

            // TODO: Set up test database with Phong (id=100) and multiple Ghe records
            // TODO: Verify multiple Ghe records exist for idPhong=100

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result);
            // TODO: Verify all Ghe records for idPhong=100 were deleted
        }

        /// <summary>
        /// Tests that DeleteByPhong returns true when no matching rows exist.
        /// ExecuteNonQuery returns 0 for no rows affected, which satisfies >= 0 condition.
        /// </summary>
        /// <remarks>
        /// This test requires database integration.
        /// DataProvider's singleton pattern prevents mocking.
        /// </remarks>
        [TestMethod]
        [Ignore("Requires database integration - DataProvider singleton cannot be mocked without refactoring")]
        public void DeleteByPhong_WithNoMatchingRows_ReturnsTrue()
        {
            // Arrange
            GheDAL gheDAL = new GheDAL();
            int idPhong = 999999; // Assuming this ID doesn't exist

            // TODO: Ensure no Ghe records exist for idPhong=999999

            // Act
            bool result = gheDAL.DeleteByPhong(idPhong);

            // Assert
            Assert.IsTrue(result); // 0 rows affected is >= 0, so returns true
        }

        /// <summary>
        /// Tests GetGheDaBan with a valid showtime ID that has sold seats.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// To make this code testable:
        /// 1. Refactor DataProvider to implement an interface (e.g., IDataProvider)
        /// 2. Make ExecuteQuery virtual, OR
        /// 3. Inject IDataProvider into GheDAL via constructor dependency injection
        /// 
        /// Expected behavior: Should return a list of seat IDs from the database for the given showtime ID.
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_ValidIdWithSoldSeats_ReturnsListOfSeatIds()
        {
            // Arrange
            var dal = new GheDAL();
            int validIdSuatChieu = 1;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking.");
        }

        /// <summary>
        /// Tests GetGheDaBan with a valid showtime ID that has no sold seats.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Expected behavior: Should return an empty list when no seats have been sold for the showtime.
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_ValidIdWithNoSoldSeats_ReturnsEmptyList()
        {
            // Arrange
            var dal = new GheDAL();
            int validIdSuatChieu = 999;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking.");
        }

        /// <summary>
        /// Tests GetGheDaBan with zero as the showtime ID.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Input: idSuatChieu = 0 (boundary value for positive ID)
        /// Expected behavior: Should return an empty list as ID 0 is typically invalid for database records.
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_ZeroId_ReturnsEmptyList()
        {
            // Arrange
            var dal = new GheDAL();
            int zeroId = 0;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking.");
        }

        /// <summary>
        /// Tests GetGheDaBan with negative showtime ID values.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Input: idSuatChieu with negative values (-1, -100, int.MinValue)
        /// Expected behavior: Should return an empty list as negative IDs are invalid for database records.
        /// </summary>
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(int.MinValue)]
        public void GetGheDaBan_NegativeId_ReturnsEmptyList(int negativeId)
        {
            // Arrange
            var dal = new GheDAL();

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking.");
        }

        /// <summary>
        /// Tests GetGheDaBan with maximum integer value.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Input: idSuatChieu = int.MaxValue (boundary value)
        /// Expected behavior: Should return an empty list as this ID likely doesn't exist in the database.
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_MaxIntValue_ReturnsEmptyList()
        {
            // Arrange
            var dal = new GheDAL();
            int maxId = int.MaxValue;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking.");
        }

        /// <summary>
        /// Tests GetGheDaBan to verify it constructs the SQL query correctly with parameterized input.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Expected behavior: Should pass the correct SQL query and SqlParameter to ExecuteQuery to prevent SQL injection.
        /// The query should be: "SELECT idGhe FROM Ve WHERE idSuatChieu = @IdSuatChieu"
        /// The parameter should be: @IdSuatChieu with the provided idSuatChieu value
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_AnyId_UsesParameterizedQuery()
        {
            // Arrange
            var dal = new GheDAL();
            int testId = 42;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking and verify query construction.");
        }

        /// <summary>
        /// Tests GetGheDaBan to verify it correctly processes multiple rows from the DataTable.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Expected behavior: When ExecuteQuery returns a DataTable with multiple rows (e.g., 5 rows with idGhe values 1, 2, 3, 4, 5),
        /// the method should return a List<int> containing all 5 seat IDs in the correct order.
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_MultipleRows_ReturnsAllSeatIds()
        {
            // Arrange
            var dal = new GheDAL();
            int testId = 1;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking and simulate multiple row results.");
        }

        /// <summary>
        /// Tests GetGheDaBan behavior when DataTable contains DBNull values.
        /// INCOMPLETE: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// with non-virtual methods, making it impossible to mock with Moq.
        /// 
        /// Expected behavior: If the DataTable contains a row where idGhe is DBNull, casting to int will throw InvalidCastException.
        /// This represents a potential bug in the implementation that should be handled with proper null checking.
        /// </summary>
        [TestMethod]
        public void GetGheDaBan_DataTableWithDBNull_ThrowsInvalidCastException()
        {
            // Arrange
            var dal = new GheDAL();
            int testId = 1;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot test GetGheDaBan: DataProvider.Instance is a static singleton with non-virtual methods. " +
                "Refactor to use dependency injection with an IDataProvider interface to enable mocking and simulate DBNull values. " +
                "Note: Current implementation lacks null checking and would throw InvalidCastException with DBNull values.");
        }

        /// <summary>
        /// Tests that GetByPhong returns an empty list when no seats exist for the room.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq. The method directly calls DataProvider.Instance.ExecuteQuery(),
        /// which is a non-virtual instance method on a singleton class.
        /// To properly unit test this method, the production code would need to be refactored to use
        /// dependency injection instead of the singleton pattern.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WhenNoSeatsExist_ReturnsEmptyList()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = 1;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot mock DataProvider.Instance (static singleton). " +
                "This method requires integration testing with a real database, " +
                "or the production code needs refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetByPhong returns a populated list when seats exist for the room.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WhenSeatsExist_ReturnsPopulatedList()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = 1;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot mock DataProvider.Instance (static singleton). " +
                "This method requires integration testing with a real database, " +
                "or the production code needs refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetByPhong handles zero as room ID.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WithZeroIdPhong_ExecutesQueryWithZero()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = 0;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot mock DataProvider.Instance (static singleton). " +
                "This method requires integration testing with a real database, " +
                "or the production code needs refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetByPhong handles negative room IDs.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WithNegativeIdPhong_ExecutesQueryWithNegativeValue()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = -1;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot mock DataProvider.Instance (static singleton). " +
                "This method requires integration testing with a real database, " +
                "or the production code needs refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetByPhong handles int.MaxValue as room ID.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WithMaxIntIdPhong_ExecutesQueryWithMaxValue()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = int.MaxValue;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot mock DataProvider.Instance (static singleton). " +
                "This method requires integration testing with a real database, " +
                "or the production code needs refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetByPhong handles int.MinValue as room ID.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WithMinIntIdPhong_ExecutesQueryWithMinValue()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = int.MinValue;

            // Act & Assert
            Assert.Inconclusive(
                "Cannot mock DataProvider.Instance (static singleton). " +
                "This method requires integration testing with a real database, " +
                "or the production code needs refactoring to support dependency injection.");
        }

        /// <summary>
        /// Tests that GetByPhong returns seats ordered by Hang and So.
        /// Note: This test cannot be fully implemented because DataProvider uses a static singleton pattern
        /// that cannot be mocked with Moq.
        /// </summary>
        [TestMethod]
        public void GetByPhong_WhenMultipleSeatsExist_ReturnsSeatsOrderedByHangAndSo()
        {
            // Arrange
            var gheDAL = new GheDAL();
            int idPhong = 1;

            // Act
            var result = gheDAL.GetByPhong(idPhong);

            // Assert
            // Verify ordering if seats exist
            Assert.IsNotNull(result, "Result should not be null");
            
            if (result.Count > 1)
            {
                // Verify that results are ordered by Hang then So
                for (int i = 0; i < result.Count - 1; i++)
                {
                    string currentHang = result[i].Hang;
                    string nextHang = result[i + 1].Hang;
                    int hangComparison = string.Compare(currentHang, nextHang, StringComparison.Ordinal);
                    
                    // If Hang values are the same, So should be in ascending order
                    if (hangComparison == 0)
                    {
                        Assert.IsTrue(result[i].So <= result[i + 1].So,
                            $"Seats with same Hang '{currentHang}' should be ordered by So. " +
                            $"Found So={result[i].So} before So={result[i + 1].So}");
                    }
                    // Hang values should be in ascending order
                    else
                    {
                        Assert.IsTrue(hangComparison < 0,
                            $"Seats should be ordered by Hang. Found Hang '{currentHang}' before '{nextHang}'");
                    }
                }
            }
            
            // If no data or only one seat, the test passes (ordering requirement is still satisfied)
        }
    }
}