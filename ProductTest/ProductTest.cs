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


        // TESTSCASES  FOR ATTRIBUTES

        // Test for ProductID
        [Test]
        public void Test_ProductID_ShouldHaveValidInitialValueOrNot()
        {
            // Assert
            Assert.That(_productInstance.ProductID, Is.EqualTo(21));
        }

        [Test]
        public void Test_ProductID_WithMinimumValue()
        {

            // Assign and Act 
            _productInstance.ProductID = 1;

            // Assert test 
            Assert.That(_productInstance.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void Test_ProductID_WithMaximumValue()
        {

            // Assign and Act 
            _productInstance.ProductID = 1000;

            // Assert
            Assert.That(_productInstance.ProductID, Is.EqualTo(1000));
        }

        // TestCase for ProductName
        [Test]
        public void Test_ProductName_ValidInitialValue()
        {

            // Assert 
            Assert.That(_productInstance.ProductName, Is.EqualTo("ProductName1"));
        }

        [Test]
        public void Test_ProductName_WithEmptyString()
        {

            // Assign & Act
            _productInstance.ProductName = "";

            // Assert
            Assert.That(_productInstance.ProductName, Is.EqualTo(""));
        }

        // TestCase for Product Price
        [Test]
        public void Test_Price_ValidInitialValue()
        {
            // Assert
            Assert.That(_productInstance.Price, Is.EqualTo(55.5));
        }

        // TestCase for Price with minimum value
        [Test]
        public void Test_Price_WithMinimumValue()
        {

            // Assign & Act
            _productInstance.Price = 1.00;

            // Assert
            Assert.That(_productInstance.Price, Is.EqualTo(1.00));
        }

        // TestCase for Price with maximum value
        [Test]
        public void Test_Price_MaxValue()
        {
            // Assign & Act
            _productInstance.Price = 5000.0;

            // Assert
            Assert.That(_productInstance.Price, Is.EqualTo(5000.00));
        }

        // TestCase for stock initial value
        [Test]
        public void Test_Stock_HaveValidInitialValueOrNot()
        {
            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(45));
        }

        // TestCase for stock with minimum value
        [Test]
        public void Test_Stock_WithMinimumValue()
        {

            // Assign & Act
            _productInstance.Stock = 1;

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(1));
        }

        // TestCase for stock with maximum value
        [Test]
        public void Test_Stock_MaxValue()
        {

            // Assign & Act
            _productInstance.Stock = 1000;

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(1000));
        }


        // TESTS FOR INCREMENT METHODS

        // Increases the stock by a valid/given value.
        [Test]
        public void Test_IncreaseStock_byValidValue()
        {
            // Assign
            var increasedByValue = 10;

            // Assign & Act
            _productInstance.IncreaseStock(increasedByValue);

            // Assert 
            Assert.That(_productInstance.Stock, Is.EqualTo(55));
        }
         
        // Increases the Stock Should Not Go Below Minimum Value which is 1
        [Test]
        public void Test_IncreaseStock_LimitStockShouldNotGoBelowMinimumValue()
        {
            // Assign
            var value = -1;

            // Act
            _productInstance.IncreaseStock(value);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(45)); 
        }

        [Test]
      
        public void Test_IncreaseStock_ShouldLimitStockToMaximumValue()
        {
            // Assign
            var value = 955;

            // Act
            _productInstance.IncreaseStock(value);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(1000));
        }

        // Increases the Stock Should Not Go Below Minimum Value which is 1
        [Test]
        public void Test_IncreaseStock_LimitStockShouldNotGoAboveMaximumValue()
        {

            // Assign
            var increaseValue = 955;

            // Act
            _productInstance.IncreaseStock(increaseValue);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(1000));
        }

        // TestCase for DecreaseStock by valid/given value
        [Test]
        public void Test_DecreaseStock_NormalValue()
        {
            // Assign
            var value = 10;

            // Act
            _productInstance.DecreaseStock(value);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(35)); // default value was 45
        }

        // Test case for DecreaseStock method ensuring stock does not go below minimum value (0)
        [Test]
        public void Test_DecreaseStock_LimitStockShouldNotGoBelowMinimumValue()
        {
            // Assign
            var value = 45;

            // Act
            _productInstance.DecreaseStock(value);

            // Assert
            Assert.That(_productInstance.Stock, Is.EqualTo(0)); 
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

