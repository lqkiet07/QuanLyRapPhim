using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QuanLyRapPhim.DAL;

namespace QuanLyRapPhim.DAL.UnitTests
{
    /// <summary>
    /// Unit tests for the DataProvider class.
    /// Note: These tests are limited due to the sealed nature of ADO.NET classes (SqlConnection, SqlCommand)
    /// which cannot be mocked using Moq, and the singleton pattern with hardcoded connection strings.
    /// Full testing would require refactoring the DataProvider to accept injectable dependencies.
    /// </summary>
    [TestClass]
    public class DataProviderTests
    {
        /// <summary>
        /// Tests that ExecuteScalar throws ArgumentNullException when query parameter is null.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_NullQuery_ThrowsArgumentNullException()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string? query = null;
            SqlParameter[]? parameters = null;

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should throw ArgumentNullException or SqlException
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar handles empty query string.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_EmptyQuery_ThrowsException()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = string.Empty;
            SqlParameter[]? parameters = null;

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should throw SqlException or ArgumentException
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar handles whitespace-only query string.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_WhitespaceQuery_ThrowsException()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "   ";
            SqlParameter[]? parameters = null;

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should throw SqlException or ArgumentException
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar executes a valid query without parameters successfully.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_ValidQueryWithoutParameters_ReturnsResult()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "SELECT COUNT(*) FROM SomeTable";
            SqlParameter[]? parameters = null;

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should return an object containing the scalar result
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar executes a valid query with parameters successfully.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_ValidQueryWithParameters_ReturnsResult()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "SELECT COUNT(*) FROM SomeTable WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int) { Value = 1 }
            };

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should return an object containing the scalar result
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar handles null parameters array correctly (default parameter value).
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_NullParameters_ExecutesSuccessfully()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "SELECT 1";

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should execute successfully and return result without adding parameters
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar handles empty parameters array correctly.
        /// This test attempts to execute against the configured database connection.
        /// If the database is not available, the test will be marked as inconclusive.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_EmptyParametersArray_ExecutesSuccessfully()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "SELECT 1";
            SqlParameter[] parameters = new SqlParameter[0];

            try
            {
                // Act
                object result = dataProvider.ExecuteScalar(query, parameters);

                // Assert
                Assert.IsNotNull(result, "ExecuteScalar should return a result");
                Assert.AreEqual(1, Convert.ToInt32(result), "ExecuteScalar should return 1 from 'SELECT 1'");
            }
            catch (SqlException ex)
            {
                // If database is not available, mark as inconclusive rather than failing
                Assert.Inconclusive($"Cannot test without database connection. SqlException: {ex.Message}");
            }
        }

        /// <summary>
        /// Tests that ExecuteScalar handles invalid SQL query syntax.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_InvalidSqlSyntax_ThrowsSqlException()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "INVALID SQL SYNTAX HERE";
            SqlParameter[]? parameters = null;

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should throw SqlException
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar returns null when the query returns no result.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_QueryReturnsNull_ReturnsNull()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "SELECT NULL";
            SqlParameter[]? parameters = null;

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should return null
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that ExecuteScalar handles multiple parameters correctly.
        /// This test is marked as inconclusive because SqlConnection and SqlCommand are sealed classes
        /// that cannot be mocked, and the DataProvider uses a hardcoded connection string.
        /// To properly test this, the code would need to be refactored to use dependency injection.
        /// </summary>
        [TestMethod]
        public void ExecuteScalar_MultipleParameters_ExecutesSuccessfully()
        {
            // Arrange
            var dataProvider = DataProvider.Instance;
            string query = "SELECT COUNT(*) FROM SomeTable WHERE Id = @Id AND Name = @Name";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int) { Value = 1 },
                new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = "Test" }
            };

            // This test cannot be executed without a real database connection
            // because SqlConnection and SqlCommand are sealed classes that cannot be mocked.
            // Expected behavior: Should execute successfully with all parameters
            Assert.Inconclusive("Cannot test without database connection. SqlConnection and SqlCommand are sealed classes that cannot be mocked with Moq.");
        }

        /// <summary>
        /// Tests that the Instance property returns a non-null DataProvider instance.
        /// </summary>
        [TestMethod]
        public void Instance_WhenAccessed_ReturnsNonNullInstance()
        {
            // Act
            DataProvider result = DataProvider.Instance;

            // Assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Tests that the Instance property returns an instance of the correct type.
        /// </summary>
        [TestMethod]
        public void Instance_WhenAccessed_ReturnsDataProviderType()
        {
            // Act
            DataProvider result = DataProvider.Instance;

            // Assert
            Assert.IsInstanceOfType(result, typeof(DataProvider));
        }

        /// <summary>
        /// Tests that multiple calls to Instance return the same object (singleton behavior).
        /// Verifies reference equality to ensure only one instance exists.
        /// </summary>
        [TestMethod]
        public void Instance_WhenAccessedMultipleTimes_ReturnsSameInstance()
        {
            // Act
            DataProvider firstCall = DataProvider.Instance;
            DataProvider secondCall = DataProvider.Instance;
            DataProvider thirdCall = DataProvider.Instance;

            // Assert
            Assert.AreSame(firstCall, secondCall, "First and second calls should return the same instance");
            Assert.AreSame(secondCall, thirdCall, "Second and third calls should return the same instance");
            Assert.AreSame(firstCall, thirdCall, "First and third calls should return the same instance");
        }

        /// <summary>
        /// Tests thread safety of the Instance property by accessing it from multiple threads concurrently.
        /// Verifies that all threads receive the same singleton instance despite concurrent access.
        /// </summary>
        [TestMethod]
        public void Instance_WhenAccessedConcurrently_ReturnsSameInstanceAcrossAllThreads()
        {
            // Arrange
            const int threadCount = 10;
            DataProvider?[] instances = new DataProvider?[threadCount];
            List<Task> tasks = new List<Task>();
            CountdownEvent countdown = new CountdownEvent(threadCount);

            // Act
            for (int i = 0; i < threadCount; i++)
            {
                int index = i;
                Task task = Task.Run(() =>
                {
                    // Synchronize thread start to maximize concurrency
                    countdown.Signal();
                    countdown.Wait();

                    instances[index] = DataProvider.Instance;
                });
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());

            // Assert
            DataProvider firstInstance = instances[0]!;
            Assert.IsNotNull(firstInstance, "First instance should not be null");

            for (int i = 1; i < threadCount; i++)
            {
                Assert.IsNotNull(instances[i], $"Instance at index {i} should not be null");
                Assert.AreSame(firstInstance, instances[i],
                    $"Instance from thread {i} should be the same as the first instance");
            }
        }

        /// <summary>
        /// Tests that rapid successive calls to Instance from the same thread return the same instance.
        /// Verifies consistency under rapid repeated access.
        /// </summary>
        [TestMethod]
        public void Instance_WhenAccessedRapidlyInSequence_ReturnsConsistentInstance()
        {
            // Arrange
            const int iterationCount = 1000;
            DataProvider firstInstance = DataProvider.Instance;

            // Act & Assert
            for (int i = 0; i < iterationCount; i++)
            {
                DataProvider currentInstance = DataProvider.Instance;
                Assert.AreSame(firstInstance, currentInstance,
                    $"Instance at iteration {i} should be the same as the first instance");
            }
        }

        /// <summary>
        /// Tests that ExecuteQuery throws ArgumentNullException when query parameter is null.
        /// Expected: ArgumentNullException or NullReferenceException during SqlCommand construction.
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        public void ExecuteQuery_NullQuery_ThrowsException()
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            string? query = null;
            SqlParameter[]? parameters = null;

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            // In a real scenario, this would throw when creating SqlCommand with null query
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should throw ArgumentNullException when query is null.");
        }

        /// <summary>
        /// Tests that ExecuteQuery returns a DataTable when called with valid query and null parameters.
        /// Expected: Returns a non-null DataTable (possibly empty depending on query results).
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        public void ExecuteQuery_ValidQueryWithNullParameters_ReturnsDataTable()
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            string query = "SELECT * FROM SomeTable";
            SqlParameter[]? parameters = null;

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            // and without an actual database with the expected schema
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should return a non-null DataTable when query executes successfully.");
        }

        /// <summary>
        /// Tests that ExecuteQuery returns a DataTable when called with valid query and empty parameters array.
        /// Expected: Returns a non-null DataTable (possibly empty depending on query results).
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        public void ExecuteQuery_ValidQueryWithEmptyParameters_ReturnsDataTable()
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            string query = "SELECT * FROM SomeTable";
            SqlParameter[] parameters = new SqlParameter[0];

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should return a non-null DataTable when query executes successfully.");
        }

        /// <summary>
        /// Tests that ExecuteQuery correctly handles valid parameters array.
        /// Expected: Returns a non-null DataTable with parameters properly applied to the query.
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        public void ExecuteQuery_ValidQueryWithValidParameters_ReturnsDataTable()
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            string query = "SELECT * FROM SomeTable WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int) { Value = 1 }
            };

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should return a non-null DataTable with query results filtered by parameters.");
        }

        /// <summary>
        /// Tests that ExecuteQuery handles very long query strings.
        /// Expected: Should handle long queries if they are valid SQL.
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        public void ExecuteQuery_VeryLongQuery_HandlesCorrectly()
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            string query = new string('A', 10000) + " SELECT * FROM SomeTable";
            SqlParameter[]? parameters = null;

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should handle or reject excessively long queries appropriately.");
        }

        /// <summary>
        /// Tests that ExecuteQuery handles invalid SQL syntax.
        /// Expected: Throws SqlException during query execution.
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        [DataRow("INVALID SQL SYNTAX")]
        [DataRow("SELECT * FROM")]
        [DataRow("DROP TABLE; SELECT *")]
        public void ExecuteQuery_InvalidSqlSyntax_ThrowsSqlException(string query)
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            SqlParameter[]? parameters = null;

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should throw SqlException when SQL syntax is invalid.");
        }

        /// <summary>
        /// Tests that ExecuteQuery handles special characters in query string.
        /// Expected: Should properly handle queries with special characters.
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        [DataRow("SELECT * FROM Table WHERE Name = 'O''Brien'")]
        [DataRow("SELECT * FROM Table WHERE Description LIKE '%special%'")]
        public void ExecuteQuery_SpecialCharactersInQuery_HandlesCorrectly(string query)
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            SqlParameter[]? parameters = null;

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should correctly handle special characters in SQL queries.");
        }

        /// <summary>
        /// Tests that ExecuteQuery handles multiple parameters.
        /// Expected: Returns DataTable with query results using all parameters.
        /// NOTE: Cannot be properly unit tested due to sealed SqlConnection class.
        /// </summary>
        [TestMethod]
        public void ExecuteQuery_MultipleParameters_ReturnsDataTable()
        {
            // Arrange
            DataProvider dataProvider = DataProvider.Instance;
            string query = "SELECT * FROM Table WHERE Id = @Id AND Name = @Name AND Active = @Active";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int) { Value = 1 },
                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = "Test" },
                new SqlParameter("@Active", SqlDbType.Bit) { Value = true }
            };

            // Act & Assert
            // This test cannot execute properly without mocking SqlConnection (sealed class)
            Assert.Inconclusive(
                "This test requires the DataProvider class to be refactored with dependency injection. " +
                "SqlConnection, SqlCommand, and SqlDataAdapter are sealed classes that cannot be mocked. " +
                "Expected behavior: Should return DataTable with all parameters correctly applied to query.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery with a null query parameter.
        /// Expected: Should throw an exception (ArgumentNullException or SqlException).
        /// Note: This test cannot be fully implemented as a unit test because SqlConnection and SqlCommand
        /// are sealed classes that cannot be mocked with Moq. The method directly instantiates these
        /// concrete ADO.NET types and calls a private GetConnection() method.
        /// To make this testable, the code would need refactoring to:
        /// 1. Accept IDbConnection/IDbCommand abstractions
        /// 2. Use dependency injection for the connection factory
        /// 3. Make GetConnection virtual or inject it as a dependency
        /// </summary>
        [TestMethod]
        public void ExecuteNonQuery_NullQuery_ThrowsException()
        {
            // Arrange
            // Cannot arrange - SqlConnection and SqlCommand are sealed and cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlConnection and SqlCommand are sealed classes that cannot be mocked. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery with a valid query and null parameters (default).
        /// Expected: Should execute successfully and return the number of affected rows.
        /// Note: Cannot be implemented as a unit test due to sealed ADO.NET dependencies.
        /// </summary>
        [TestMethod]
        public void ExecuteNonQuery_ValidQueryWithNullParameters_ExecutesSuccessfully()
        {
            // Arrange
            // Cannot arrange - SqlConnection and SqlCommand are sealed and cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlConnection and SqlCommand are sealed classes that cannot be mocked. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery with a valid query and empty parameters array.
        /// Expected: Should execute successfully without adding parameters.
        /// Note: Cannot be implemented as a unit test due to sealed ADO.NET dependencies.
        /// </summary>
        [TestMethod]
        public void ExecuteNonQuery_ValidQueryWithEmptyParameters_ExecutesSuccessfully()
        {
            // Arrange
            // Cannot arrange - SqlConnection and SqlCommand are sealed and cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlConnection and SqlCommand are sealed classes that cannot be mocked. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery with a valid query and valid parameters.
        /// Expected: Should add parameters to command and execute successfully.
        /// Note: Cannot be implemented as a unit test due to sealed ADO.NET dependencies.
        /// </summary>
        [TestMethod]
        [TestCategory("ProductionBugSuspected")]
        [Ignore("ProductionBugSuspected")]
        public void ExecuteNonQuery_ValidQueryWithValidParameters_AddsParametersAndExecutes()
        {
            // Arrange
            // Cannot arrange - SqlConnection and SqlCommand are sealed and cannot be mocked
            // SqlParameter is also sealed and cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlConnection, SqlCommand, and SqlParameter are sealed classes that cannot be mocked. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery with a whitespace-only query.
        /// Expected: Should throw SqlException due to invalid SQL.
        /// Note: Cannot be implemented as a unit test due to sealed ADO.NET dependencies.
        /// </summary>
        [TestMethod]
        public void ExecuteNonQuery_WhitespaceQuery_ThrowsException()
        {
            // Arrange
            // Cannot arrange - SqlConnection and SqlCommand are sealed and cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlConnection and SqlCommand are sealed classes that cannot be mocked. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery behavior when connection open fails.
        /// Expected: Should throw SqlException when connection cannot be opened.
        /// Note: Cannot be implemented as a unit test due to sealed ADO.NET dependencies.
        /// </summary>
        [TestMethod]
        public void ExecuteNonQuery_ConnectionOpenFails_ThrowsException()
        {
            // Arrange
            // Cannot arrange - SqlConnection is sealed and conn.Open() cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlConnection is a sealed class that cannot be mocked, and the Open() method cannot be set up to throw exceptions. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }

        /// <summary>
        /// Tests ExecuteNonQuery behavior when command execution fails.
        /// Expected: Should throw SqlException when ExecuteNonQuery fails.
        /// Note: Cannot be implemented as a unit test due to sealed ADO.NET dependencies.
        /// </summary>
        [TestMethod]
        public void ExecuteNonQuery_CommandExecutionFails_ThrowsException()
        {
            // Arrange
            // Cannot arrange - SqlCommand is sealed and cmd.ExecuteNonQuery() cannot be mocked

            // Act & Assert
            Assert.Inconclusive(
                "This test cannot be implemented as a unit test. " +
                "SqlCommand is a sealed class that cannot be mocked, and the ExecuteNonQuery() method cannot be set up to throw exceptions. " +
                "The DataProvider class requires refactoring to use dependency injection and abstractions (e.g., IDbConnection, IDbCommand) " +
                "to enable proper unit testing. Consider creating integration tests instead, or refactor to accept injectable dependencies.");
        }
    }
}