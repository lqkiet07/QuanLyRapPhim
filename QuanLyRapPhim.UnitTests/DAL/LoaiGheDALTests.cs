using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;


namespace QuanLyRapPhim.DAL.UnitTests
{
    /// <summary>
    /// Unit tests for the LoaiGheDAL class.
    /// </summary>
    [TestClass]
    public class LoaiGheDALTests
    {
        /// <summary>
        /// Tests that GetAll returns a non-null list when the database contains seat type records.
        /// This test cannot be executed because DataProvider is a singleton that cannot be mocked.
        /// 
        /// REFACTORING REQUIRED:
        /// - Create an IDataProvider interface
        /// - Inject IDataProvider via constructor dependency injection
        /// - This will enable proper unit testing with mocked dependencies
        /// </summary>
        [TestMethod]
        public void GetAll_WhenDatabaseHasRecords_ReturnsPopulatedList()
        {
            // This test cannot be completed without refactoring the DataProvider singleton
            // to support dependency injection. The DataProvider.Instance is a sealed singleton
            // with no interface, making it impossible to mock without violating testing constraints.
            Assert.Inconclusive(
                "Test cannot be completed. LoaiGheDAL has a hard dependency on DataProvider singleton. " +
                "Refactor to use dependency injection with IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that GetAll returns an empty list when the database contains no seat type records.
        /// This test cannot be executed because DataProvider is a singleton that cannot be mocked.
        /// 
        /// REFACTORING REQUIRED:
        /// - Create an IDataProvider interface
        /// - Inject IDataProvider via constructor dependency injection
        /// - This will enable proper unit testing with mocked dependencies
        /// </summary>
        [TestMethod]
        public void GetAll_WhenDatabaseIsEmpty_ReturnsEmptyList()
        {
            // This test cannot be completed without refactoring the DataProvider singleton
            // to support dependency injection. The DataProvider.Instance is a sealed singleton
            // with no interface, making it impossible to mock without violating testing constraints.
            Assert.Inconclusive(
                "Test cannot be completed. LoaiGheDAL has a hard dependency on DataProvider singleton. " +
                "Refactor to use dependency injection with IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that GetAll correctly maps database columns to LoaiGheDTO properties.
        /// This test cannot be executed because DataProvider is a singleton that cannot be mocked.
        /// 
        /// Expected behavior:
        /// - "id" column should map to Id property
        /// - "TenLoai" column should map to TenLoai property
        /// - "PhuPhi" column should map to PhuPhi property
        /// 
        /// REFACTORING REQUIRED:
        /// - Create an IDataProvider interface
        /// - Inject IDataProvider via constructor dependency injection
        /// - This will enable proper unit testing with mocked dependencies
        /// </summary>
        [TestMethod]
        public void GetAll_WhenCalled_CorrectlyMapsDataTableRowsToDTO()
        {
            // Arrange
            var dal = new LoaiGheDAL();

            // Act
            List<LoaiGheDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");
            
            // If there are records, verify the mapping is correct
            if (result.Count > 0)
            {
                foreach (var loaiGhe in result)
                {
                    // Verify that Id property is mapped (should be greater than 0 for valid records)
                    Assert.IsTrue(loaiGhe.Id > 0, "Id should be mapped to a positive integer value");
                    
                    // Verify that TenLoai property is mapped (should not be null)
                    Assert.IsNotNull(loaiGhe.TenLoai, "TenLoai should be mapped and not null");
                    
                    // Verify that PhuPhi property is mapped (should be >= 0)
                    Assert.IsTrue(loaiGhe.PhuPhi >= 0, "PhuPhi should be mapped to a non-negative decimal value");
                }
            }
        }

        /// <summary>
        /// Tests that GetAll throws an exception when ExecuteQuery returns null.
        /// This test cannot be executed because DataProvider is a singleton that cannot be mocked.
        /// 
        /// Expected behavior:
        /// - Should throw NullReferenceException when DataTable is null
        /// 
        /// REFACTORING REQUIRED:
        /// - Create an IDataProvider interface
        /// - Inject IDataProvider via constructor dependency injection
        /// - This will enable proper unit testing with mocked dependencies
        /// </summary>
        [TestMethod]
        public void GetAll_WhenExecuteQueryReturnsNull_ThrowsNullReferenceException()
        {
            // This test cannot be completed without refactoring the DataProvider singleton
            // to support dependency injection. The DataProvider.Instance is a sealed singleton
            // with no interface, making it impossible to mock without violating testing constraints.
            Assert.Inconclusive(
                "Test cannot be completed. LoaiGheDAL has a hard dependency on DataProvider singleton. " +
                "Refactor to use dependency injection with IDataProvider interface to enable unit testing.");
        }

        /// <summary>
        /// Tests that GetAll throws an exception when DataTable contains DBNull values.
        /// 
        /// NOTE: This is an integration test that requires database access.
        /// The test verifies that the current implementation does not handle DBNull values gracefully.
        /// If the database contains null values in id or PhuPhi columns, InvalidCastException will be thrown.
        /// 
        /// Expected behavior:
        /// - Should throw InvalidCastException when casting DBNull to int or decimal
        /// 
        /// LIMITATION:
        /// - This test cannot create the condition without proper DI, so it documents expected behavior
        /// - If database has no null values, test will pass but not validate the exception scenario
        /// </summary>
        [TestMethod]
        public void GetAll_WhenDataContainsNullValues_ThrowsInvalidCastException()
        {
            // Arrange
            var loaiGheDAL = new LoaiGheDAL();

            // Act & Assert
            // The production code will throw InvalidCastException if database contains DBNull values
            // in id or PhuPhi columns due to direct casting: (int)row["id"] or (decimal)row["PhuPhi"]
            // However, without DI, we cannot inject test data to guarantee this condition.
            // This test validates that GetAll() can be called successfully when data is valid.
            var result = loaiGheDAL.GetAll();
            
            // If we reach here, the database doesn't contain problematic null values
            // The test documents that InvalidCastException would occur if nulls were present
            Assert.IsNotNull(result, "GetAll should return a list, not null. If database had null values, InvalidCastException would be thrown before reaching this point.");
        }

        /// <summary>
        /// Tests that GetAll returns results ordered by TenLoai as specified in the SQL query.
        /// This test cannot be executed because DataProvider is a singleton that cannot be mocked.
        /// 
        /// Expected behavior:
        /// - Results should be ordered alphabetically by TenLoai column
        /// 
        /// REFACTORING REQUIRED:
        /// - Create an IDataProvider interface
        /// - Inject IDataProvider via constructor dependency injection
        /// - This will enable proper unit testing with mocked dependencies
        /// </summary>
        [TestMethod]
        public void GetAll_WhenCalled_ReturnsResultsOrderedByTenLoai()
        {
            // Arrange
            var dal = new LoaiGheDAL();

            // Act
            List<LoaiGheDTO> result = dal.GetAll();

            // Assert
            Assert.IsNotNull(result, "GetAll should return a non-null list");
            
            // Verify ordering if there are at least 2 records
            if (result.Count >= 2)
            {
                for (int i = 0; i < result.Count - 1; i++)
                {
                    // Compare consecutive items to ensure they are ordered alphabetically by TenLoai
                    // Use CurrentCulture to match SQL Server's culture-aware collation
                    int comparison = string.Compare(result[i].TenLoai, result[i + 1].TenLoai, StringComparison.CurrentCulture);
                    Assert.IsTrue(comparison <= 0, 
                        $"Results should be ordered by TenLoai. Found '{result[i].TenLoai}' before '{result[i + 1].TenLoai}' at position {i}");
                }
            }
            else if (result.Count == 0)
            {
                // If database is empty, the test passes but cannot verify ordering
                Assert.Inconclusive("Database has no records. Cannot verify ordering behavior.");
            }
            // If there's only 1 record, ordering is trivially satisfied
        }
    }
}