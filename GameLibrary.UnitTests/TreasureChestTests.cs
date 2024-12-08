namespace GameLibrary.UnitTests;

public class TreasureChestTests
{
    // MethodName_StateUnderTest_ExpectedBehavior

    [Fact]
    public void CanOpen_ChestIsLockedAndHasKey_ReturnsTrue()
    {
        // Arrange
        var sut = new TreasureChest(true);

        // Act
        var result = sut.CanOpen(true);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanOpen_ChestIsLockedAndHasNoKey_ReturnsFalse()
    {
        // Arrange
        var sut = new TreasureChest(true);

        // Act
        var result = sut.CanOpen(false);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanOpen_ChestIsUnLockedAndHasKey_ReturnsTrue()
    {
        // Arrange
        var sut = new TreasureChest(false);

        // Act
        var result = sut.CanOpen(true);

        // Assert
        Assert.True(result);
    }    

    [Fact]
    public void CanOpen_ChestIsUnLockedAndHasNoKey_ReturnsTrue()
    {
        // Arrange
        var sut = new TreasureChest(false);

        // Act
        var result = sut.CanOpen(false);

        // Assert
        Assert.True(result);
    }       
}
