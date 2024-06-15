using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareQuality_Assignment_2;


namespace ProductTest
{
    [TestFixture]
    public class ProductTest
    {
        public Product _productInstance { get; set; } = null;

        [SetUp]
        public void Setup()
        {

            _productInstance = new Product(21, "ProductName1", 55.5, 45);
        }


        // TEST CASES FOR ATTRIBUTES
        // Test Product ID initial value is correct or not
        [Test]
        public void Test_ProductID_InitialValue()
        {
            // Assign
            int expectedValue = 21;

            // Act
            int actualValue = _productInstance.ProductID;

            // Assert
            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }

        // Test Case for Product ID with minimum value
        [Test]
        public void Test_ProductID_WithMinimumValue()
        {

            // Assign
            int expectedMinValue = 1;

            // Act
            _productInstance.ProductID = expectedMinValue;
            int actualMinValue = _productInstance.ProductID;

            // Assert
            Assert.That(actualMinValue, Is.EqualTo(expectedMinValue));
        }

        // Test Case for Product ID with maximum value
        [Test]
        public void Test_ProductID_WithMaximumValue()
        {

            // Assign
            int expectedMaxValue = 1000;

            // Act
            _productInstance.ProductID = expectedMaxValue;
            int actualMaxValue = _productInstance.ProductID;

            // Assert
            Assert.That(actualMaxValue, Is.EqualTo(expectedMaxValue));
        }

        // Test Case for Product name with initial value
        [Test]
        public void Test_ProductName_InitialValue()
        {

            // Assign
            string expectedProductName = "ProductName1";

            // Act
            string actualProductName = _productInstance.ProductName;

            // Assert
            Assert.That(actualProductName, Is.EqualTo(expectedProductName));
        }

        // Test Case for Product name with empty string
        [Test]
        public void Test_ProductName_WithEmptyString()
        {
            // Assign
            string expectedProductName = "";

            // Act
            _productInstance.ProductName = expectedProductName;
            string actualProductName = _productInstance.ProductName;

            // Assert
            Assert.That(actualProductName, Is.EqualTo(expectedProductName));
        }

        // Test Case for Product price with initial value
        [Test]
        public void Test_Price_InitialValueIsValidOrNot()
        {
            // Assign
            double expectedInitialValue = 55.5;

            // Act
            double actualInitialValue = _productInstance.Price;

            // Assert
            Assert.That(actualInitialValue, Is.EqualTo(expectedInitialValue));
        }

        // Test Case for Product price with minimum value
        [Test]
        public void Test_Price_MinimumValue()
        {

            // Assign
            double expectedMinimumPrice = 1.00;

            // Act
            _productInstance.Price = expectedMinimumPrice;
            double actualMinimumPrice = _productInstance.Price;

            // Assert
            Assert.That(actualMinimumPrice, Is.EqualTo(expectedMinimumPrice));
        }

        // Test Case for Product price with maximum value
        [Test]
        public void Test_Price_MaximumValue()
        {
            // Assign
            double expectedMaximumPrice = 5000.0;

            // Act
            _productInstance.Price = expectedMaximumPrice;
            double actualMaximumMaximum = _productInstance.Price;

            // Assert
            Assert.That(actualMaximumMaximum, Is.EqualTo(expectedMaximumPrice));
        }

        // TestCase for stock with initial value
        [Test]
        public void Test_Stock_InitialValue()
        {
            // Assign
            int expectedInitialStock = 45;

            // Act
            int actualInitialStock = _productInstance.Stock;

            // Assert
            Assert.That(actualInitialStock, Is.EqualTo(expectedInitialStock));
        }

        // TestCase for stock with minimum value
        [Test]
        public void Test_Stock_WithMinimumValue()
        {

            // Assign
            int expectedStockMinValue = 1;

            // Act
            _productInstance.Stock = expectedStockMinValue;
            int actualStockMinValue = _productInstance.Stock;

            // Assert
            Assert.That(actualStockMinValue, Is.EqualTo(expectedStockMinValue));
        }

        // TestCase for stock with maximum value
        [Test]
        public void Test_Stock_MaxValue()
        {
            // Assign
            int expectedStockMaxValue = 1000;

            // Act
            _productInstance.Stock = expectedStockMaxValue;
            int actualStockMaxValue = _productInstance.Stock;

            // Assert
            Assert.That(actualStockMaxValue, Is.EqualTo(expectedStockMaxValue));
        }


        // TESTCASES FOR INCREMENT METHODS

        // Increases the stock by a valid/given value.
        [Test]
        public void Test_IncreaseStock_byValidValue()
        {

            // Assign
            int increaseValue = 10;
            int expectedIncresedValue = 45 + increaseValue;

            // Act
            _productInstance.IncreaseStock(increaseValue);
            int actualValue = _productInstance.Stock;

            // Assert
            Assert.That(actualValue, Is.EqualTo(expectedIncresedValue)); 
        }
         
        // Increases the Stock Should Not Go Below Minimum Value which is 1
        [Test]
        public void Test_IncreaseStock_ByNegativeValue_DoesNotChangeStock()
        {

            // Assign
            int increaseValue = -1;
            int expectedValue = 45;

            // Act
            _productInstance.IncreaseStock(increaseValue);
            int actualValue = _productInstance.Stock;

            // Assert
            Assert.That(actualValue, Is.EqualTo(expectedValue)); // As we need to check that value should not change if we pass negative value
        }


        [Test]
        public void Test_IncreaseStock_ByMinimumValue()
        {
            // Assign
            int increaseValue = 1;
            int expected = 45 + increaseValue;

            // Act
            _productInstance.IncreaseStock(increaseValue);
            int actual = _productInstance.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
      
        public void IncreaseStock_ToMaximumValue()
        {
            // Assign
            int increaseValue = 955;
            int expectedIncresedStock = 1000; // We are Assuming 1000 is the maximum stock limit

            // Act
            _productInstance.IncreaseStock(increaseValue);
            int actual = _productInstance.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expectedIncresedStock));
        }

        // Increases the Stock Should Not Go Above Maximum Value which is 1000
        [Test]
        public void Test_IncreaseStock_LimitStockShouldNotGoAboveMaximumValue()
        {
            // Assign
            var initialStock = _productInstance.Stock;
            var increaseValue = 1055; // Increase the stock by more than the maximum value

            // Act
            _productInstance.IncreaseStock(increaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(initialStock + 1000)); // Stock should not exceed 1000
        }

        // TestCase for Decreases the stock by a valid value.
        [Test]
        public void DecreaseStock_ByValidValue()
        {
            // Assign
            int decreaseStockValue = 10; // Value by which to decrease the stock
            int expected = 45 - decreaseStockValue;

            // Act
            _productInstance.DecreaseStock(decreaseStockValue);
            int actual = _productInstance.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected)); // Verify that the stock has decreased to the expected value - 35
        }

        // TestCase for Decrease Stock up To Zero
        [Test]
        public void Test_DecreaseStock_ToZero()
        {
            // Assign
            int decreaseValue = 45;
            int expected = 0;

            // Act
            _productInstance.DecreaseStock(decreaseValue);
            int actual = _productInstance.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Testing that the stock does not go below zero.
        [Test]
        public void Test_DecreaseStock_StockDoesNotGoBelowZero()
        {
            // Assign
            int decreaseValue = 55;
            int expected = 0; // Stock should not go below zero

            // Act
            _productInstance.DecreaseStock(decreaseValue);
            int actual = _productInstance.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case for DecreaseStock method ensuring stock does not go below minimum value (45)
        [Test]
        public void Test_DecreaseStock_ShouldNotGoBelowMinimumValueOf45()
        {
            // Assign
            var value = 55;

            // Act
            _productInstance.DecreaseStock(value);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(45)); 
        }

    }
}

