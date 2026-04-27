using CodeChallengesLab.LeetCode;

namespace CodeChallengesLab.Tests.LeetCode;
public class LeetCode001Test
{
    [Fact]
    public void TwoSum_BasicCase_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = { 0, 1 };

        // Act
        int[] result = LeetCode001.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_AnotherCase_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] expected = { 1, 2 };

        // Act
        int[] result = LeetCode001.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_DuplicateNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 3, 3 };
        int target = 6;
        int[] expected = { 0, 1 };

        // Act
        int[] result = LeetCode001.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_NegativeNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { -1, -2, -3, -4, -5 };
        int target = -8;
        int[] expected = { 2, 4 };

        // Act
        int[] result = LeetCode001.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_LargerArray_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 1, 5, 3, 7, 9, 2, 4 };
        int target = 11;
        int[] expected = { 1, 4 };

        // Act
        int[] result = LeetCode001.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_NoSolution_ThrowsException()
    {
        // Arrange
        int[] nums = { 1, 2, 3 };
        int target = 10;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => LeetCode001.TwoSum(nums, target));
    }
}