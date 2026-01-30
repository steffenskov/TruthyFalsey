// ReSharper disable SimplifyConditionalTernaryExpression

namespace TruthyFalsey.UnitTests;

public class TruthyFalseyClasstTests
{
	[Fact]
	public void Class_NotNull_ReturnsTrue()
	{
		// Arrange
		var user = new User("John");

		// Act
		var result = user ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Class_Null_ReturnsFalse()
	{
		// Arrange
		User? user = null;

		// Act
		var result = user ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Class_Null_NegatedReturnsTrue()
	{
		// Arrange
		User? user = null;

		// Act
		var result = !user;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Class_NotNull_NegatedReturnsFalse()
	{
		// Arrange
		var user = new User("John");

		// Act
		var result = !user;

		// Assert
		Assert.False(result);
	}
}

file record User(string Name);