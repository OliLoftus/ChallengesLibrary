using ChallengeLibrary;

namespace ChallengeTests;

public class CountDuplicatesTests
{
    private readonly CountDuplicates _sut;

    public CountDuplicatesTests()
    {
        _sut = new CountDuplicates();
    }
    
    [Fact]
    public void Throws_Exception_If_Input_Is_Null_Or_Empty()
    {
        // Arrange
        string? nullInput = null;
        string empty = string.Empty;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _sut.Count(nullInput!));
        Assert.Throws<ArgumentException>(() => _sut.Count(empty));
    }

    [Fact]
    public void Counts_Character_Frequency_Correctly()
    {
        // Arrange
        string input = "aabb";
        
        // Act
        int result = _sut.Count(input);
        
        //Assert
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Sanitize_Characters_Correctly()
    {
        // Arrange
        string input = "aABb";
        
        // Act
        int result = _sut.Count(input);
        
        //Assert
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void No_Duplicates_Returns_Zero()
    {
        // Arrange
        string input = "abcde";
        
        // Act
        int result = _sut.Count(input);
        
        //Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Counts_Duplicates_For_Numbers_And_Strings()
    {
        // Arrange
        string input = "a1a1b2";
        
        // Act
        int result = _sut.Count(input);
        
        //Assert
        Assert.Equal(2, result);
    }
}