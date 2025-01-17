using ChallengeLibrary;

namespace ChallengeTests;

public class MexicanWaveTest
{
    private readonly MexicanWave _sut;

    public MexicanWaveTest()
    {
        _sut = new MexicanWave();
    }

    [Fact]
    public void Empty_Input_Returns_Empty_Array()
    {
        // Arrange
        string input = "";
        
        // Act
        var result = _sut.Wave(input);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void Handles_Single_Character()
    {
        // Arrange
        const string input = "a";
        
        // Act
        var result = _sut.Wave(input);
        
        // Assert 
        Assert.Equal(["A"], result);
        
    }
    
    [Fact]
    public void Creates_Wave_For_Single_Word()
    {
        // Arrange
        const string input = "wave";
        
        // Act
        var result = _sut.Wave(input);
        
        // Assert 
        Assert.Equal([
            "Wave",
            "wAve",
            "waVe",
            "wavE"
        ], result);
    }
    
    [Fact]
    public void Creates_Wave_For_Multiple_Words()
    {
        // Arrange
        const string input = "big wave";
        
        // Act
        var result = _sut.Wave(input);
        
        // Assert 
        Assert.Equal([
            "Big wave",
            "bIg wave",
            "biG wave",
            "big Wave",
            "big wAve",
            "big waVe",
            "big wavE"
        ], result);
    }
    
    [Fact]
    public void Returns_Empty_Array_For_All_Whitespace_Input()
    {
        // Arrange
        string input = "    ";
        
        // Act
        var result = _sut.Wave(input);

        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void Ignores_Leading_And_Trailing_Whitespace_Input()
    {
        // Arrange
        const string input = " wave ";
        
        // Act
        var result = _sut.Wave(input);
        
        // Assert 
        Assert.Equal([
            " Wave ",
            " wAve ",
            " waVe ",
            " wavE "
        ], result);
    }
}