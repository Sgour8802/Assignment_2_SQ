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
        // Test Product ID with initial value 
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
        public void Test_Price_WithMinimumValue()
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
        public void Test_Price_WithMaximumValue()
        {
            // Assign
            double expectedMaximumPrice = 5000.0;

            // Act
            _productInstance.Price = expectedMaximumPrice;
            double actualMaximumMaximum = _productInstance.Price;

            // Assert
            Assert.That(actualMaximumMaximum, Is.EqualTo(expectedMaximumPrice));
        }

        // TEST CASES FOR METHODS - Increase AND Decrease
        // TestCase for stock with initial value
        [Test]
        public void Test_Stock_WithInitialValue()
        {
            // Assign
            int expectedInitialStock = 45;

            // Act
            int actualInitialStock = _productInstance.Stock;

            // Assert
            Assert.That(actualInitialStock, Is.EqualTo(expectedInitialStock));
        }

        // TestCase for Increase Stock By Minimum Value
        [Test]
        public void Test_IncreaseStock_ByMinimumValue()
        {
            // Assign
            int increaseValue = 1;
            int expectedStock = _productInstance.Stock + increaseValue;

            // Act
            _productInstance.IncreaseStock(increaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(expectedStock));
        }

        // TestCase for Increase Stock By Max Value
        [Test]
        public void Test_IncreaseStock_ByMaximumValue()
        {
            // Assign
            int increaseValue = 955; // Assuming maximum increase allowed
            int expectedStock = 1000; // Maximum stock value

            // Act
            _productInstance.IncreaseStock(increaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(expectedStock));
        }

        // TestCase for Increase Stock By valid Value
        [Test]
        public void Test_IncreaseStock_ByValidValue()
        {
            // Assign
            int increaseValue = 10;
            int expectedStock = _productInstance.Stock + increaseValue;

            // Act
            _productInstance.IncreaseStock(increaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(expectedStock));
        }

        // TestCase for decrease Stock By min Value
        [Test]
        public void Test_DecreaseStock_ByMinimumValue()
        {
            // Assign
            int decreaseValue = 1;
            int expectedStock = _productInstance.Stock - decreaseValue;

            // Act
            _productInstance.DecreaseStock(decreaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(expectedStock));
        }

        // TestCase for decrease Stock By max Value
        [Test]
        public void Test_DecreaseStock_ByMaximumValue()
        {
            // Assign
            int decreaseValue = 45; // Assuming current stock as the maximum value
            int expectedStock = 0; // Stock should go to zero

            // Act
            _productInstance.DecreaseStock(decreaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(expectedStock));
        }

        // TestCase for decrease Stock By valid Value
        [Test]
        public void Test_DecreaseStock_ByValidValue()
        {
            // Assign
            int decreaseValue = 10;
            int expectedStock = _productInstance.Stock - decreaseValue;

            // Act
            _productInstance.DecreaseStock(decreaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(expectedStock));
        }

    }
}

