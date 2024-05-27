namespace ProductTests
{
    public class Tests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "Test Product", 15.30m, 50);
        }


        [Test]
        public void Assert_IsFalse_ConditionIsFalse_WithMessage()
        {
            // Arrange
            _product = new Product(2, "Test Product1", 15.30m, 0);

            // Act & Assert
            Assert.That(_product.Stock < 0, Is.False, "Stock should not be negative.");
        }
        [Test]
        public void Assert_AreEqual_ExpectedAndActualMatch()
        {
            // Arrange
            _product = new Product(2, "Test Product2", 15.30m, 0);

            // Act
            var actual = _product.ProductName;
            var expected = "Test Product2";

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "ProductName should match the expected value");
        }

        [Test]
        public void Id_MaxValue_ReturnsExpectedId()
        {
            // Arrange
            int expectedId = 60000;

            // Act
            _product.ProductID = expectedId;
            int actualId = _product.ProductID;

            // Assert
            Assert.That(actualId, Is.EqualTo(expectedId));
        }
        [Test]
        public void Stock_Minimum_ReturnsExpectedValue()
        {
            // Arrange
            int expectedStock = 6;
            _product.Stock = expectedStock;

            // Act
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void Stock_Maximum_ReturnsExpectedValue()
        {
            // Arrange
            int expectedStock = 600000;
            _product.Stock = expectedStock;

            // Act
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }
     
        public void Price_MinValue_ReturnsExpectedPrice()
        {
            // Arrange
            decimal expectedPrice = 6.00m;

            // Act
            _product.Price = expectedPrice;
            decimal actualPrice = _product.Price;

            // Assert
            Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Price_MaxValue_ReturnsExpectedPrice()
        {
            // Arrange
            decimal expectedPrice = 6000.00m;

            // Act
            _product.Price = expectedPrice;
            decimal actualPrice = _product.Price;

            // Assert
            Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void IncreaseStock_ValidAmount_IncreaseStock()
        {
            // Arrange
            int initialStock = 50;
            int increaseAmount = 100;
            int expectedStock = initialStock + increaseAmount;

            // Act
            _product.IncreaseStock(increaseAmount);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }
        [Test]
        public void IncreaseStock_WithinRange_ReturnsExpectedStock()
        {
            // Arrange
            int initialStock = 50;
            int increaseAmount = 25;
            int expectedStock = initialStock + increaseAmount;
            _product.Stock = initialStock;

            // Act
            _product.IncreaseStock(increaseAmount);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void IncreaseStock_ToMaxValue_ReturnsMaxStock()
        {
            // Arrange
            int initialStock = 600000 - 50;
            int increaseAmount = 50;
            int expectedStock = 600000;
            _product.Stock = initialStock;

            // Act
            _product.IncreaseStock(increaseAmount);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void DecreaseStock_ValidAmount_DecreaseStock()
        {
            // Arrange
            int initialStock = 50;
            int decreaseAmount = 10;
            int expectedStock = initialStock - decreaseAmount;

            // Act
            _product.DecreaseStock(decreaseAmount);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void DecreaseStock_WithinRange_ReturnsExpectedStock()
        {
            // Arrange
            int initialStock = 100;
            int decreaseAmount = 25;
            int expectedStock = initialStock - decreaseAmount;
            _product.Stock = initialStock;

            // Act
            _product.DecreaseStock(decreaseAmount);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }
        [Test]
        public void DecreaseStock_ToMinValue_ReturnsMinStock()
        {
            // Arrange
            int initialStock = 50;
            int decreaseAmount = 44;
            int expectedStock = 6;
            _product.Stock = initialStock;

            // Act
            _product.DecreaseStock(decreaseAmount);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void Equals_NullObject_ReturnsFalse()
        {
            // Arrange
            Product nullProduct = null;

            // Act
            bool areEqual = _product.Equals(nullProduct);

            // Assert
            Assert.That(areEqual, Is.False);
        }

        [Test]
        public void Equals_DifferentType_ReturnsFalse()
        {
            // Arrange
            object differentObject = new object();

            // Act
            bool areEqual = _product.Equals(differentObject);

            // Assert
            Assert.That(areEqual, Is.False);
        }
        [Test]
        public void Equals_SameObject_ReturnsTrue()
        {
            // Arrange
            Product sameProduct = _product;

            // Act
            bool areEqual = _product.Equals(sameProduct);

            // Assert
            Assert.That(areEqual, Is.True);
        }
        [Test]
        public void Price_SetAndGet_ReturnsExpectedValue()
        {
            // Arrange
            decimal expectedPrice = 20.50m;

            // Act
            _product.Price = expectedPrice;
            decimal actualPrice = _product.Price;

            // Assert
            Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Id_SetAndGet_ReturnsExpectedValue()
        {
            // Arrange
            int expectedId = 2;

            // Act
            _product.ProductID = expectedId;
            int actualId = _product.ProductID;

            // Assert
            Assert.That(actualId, Is.EqualTo(expectedId));
        }
        [Test]
        public void Stock_ZeroValue_SetsStockToZero()
        {
            // Arrange
            int expectedStock = 0;

            // Act
            _product = new Product(1, "Test Product", 15.30m, expectedStock);
            int actualStock = _product.Stock;

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        
    }
}