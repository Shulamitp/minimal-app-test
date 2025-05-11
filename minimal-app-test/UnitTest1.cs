namespace minimal_app_test
{
    public class UnitTest1
    {
        [Fact]
        public void GetMessage_WithValidConnectionString_ReturnsMessageWithConnection()
        {
            // Arrange
            string dbConnection = "Server=myServer;Database=myDb;";

            // Act
            var result = Logic.GetMessage(dbConnection);

            // Assert
            Assert.Equal("hello word - Server=myServer;Database=myDb;", result);
        }

        [Fact]
        public void GetMessage_WithNullConnectionString_ReturnsMessageWithNull()
        {
            // Arrange
            string? dbConnection = null;

            // Act
            var result = Logic.GetMessage(dbConnection);

            // Assert
            Assert.Equal("hello word - ", result);
        }

        [Fact]
        public void GetMessage_WithEmptyConnectionString_ReturnsMessageWithEmpty()
        {
            //test my tests ----------!!!!!!!!!!!!!
            // Arrange
            string dbConnection = "";

            // Act
            var result = Logic.GetMessage(dbConnection);

            // Assert
            Assert.Equal("hello word - ", result);
        }
    }
}