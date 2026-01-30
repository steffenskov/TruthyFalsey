// ReSharper disable SimplifyConditionalTernaryExpression

namespace TruthyFalsey.UnitTests;

public class TruthyFalseyStructTests
{
	[Theory]
	[InlineData(false, false)]
	[InlineData(true, true)]
	public void Bool_Input_ReturnsInput(bool value, bool expected)
	{
		// Act
		var result = value ? true : false;

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void Int_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = Random.Shared.Next(int.MaxValue - 1) + 1; // Will always be > 0

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Int_Zero_ReturnsFalse()
	{
		// Arrange
		const int value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Int_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const int value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Long_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = Random.Shared.NextInt64(1, long.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Long_Zero_ReturnsFalse()
	{
		// Arrange
		const long value = 0L;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Long_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const long value = 0L;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Long_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = Random.Shared.NextInt64(1, long.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Short_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (short)Random.Shared.Next(1, short.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Short_Zero_ReturnsFalse()
	{
		// Arrange
		const short value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Short_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const short value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Short_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (short)Random.Shared.Next(1, short.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void SByte_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (sbyte)Random.Shared.Next(1, sbyte.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void SByte_Zero_ReturnsFalse()
	{
		// Arrange
		const sbyte value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void SByte_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const sbyte value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void SByte_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (sbyte)Random.Shared.Next(1, sbyte.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Byte_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (byte)Random.Shared.Next(1, byte.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Byte_Zero_ReturnsFalse()
	{
		// Arrange
		const byte value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Byte_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const byte value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Byte_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (byte)Random.Shared.Next(1, byte.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void UInt_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (uint)Random.Shared.Next(1, int.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void UInt_Zero_ReturnsFalse()
	{
		// Arrange
		const uint value = 0U;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void UInt_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const uint value = 0U;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void UInt_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (uint)Random.Shared.Next(1, int.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void UShort_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (ushort)Random.Shared.Next(1, ushort.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void UShort_Zero_ReturnsFalse()
	{
		// Arrange
		const ushort value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void UShort_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const ushort value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void UShort_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (ushort)Random.Shared.Next(1, ushort.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void ULong_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (ulong)Random.Shared.NextInt64(1, long.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void ULong_Zero_ReturnsFalse()
	{
		// Arrange
		const ulong value = 0UL;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void ULong_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const ulong value = 0UL;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void ULong_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (ulong)Random.Shared.NextInt64(1, long.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void NInt_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (nint)Random.Shared.Next(1, int.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void NInt_Zero_ReturnsFalse()
	{
		// Arrange
		nint value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void NInt_Zero_NegatedReturnsTrue()
	{
		// Arrange
		nint value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void NInt_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (nint)Random.Shared.Next(1, int.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void NUInt_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (nuint)Random.Shared.Next(1, int.MaxValue);

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void NUInt_Zero_ReturnsFalse()
	{
		// Arrange
		nuint value = 0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void NUInt_Zero_NegatedReturnsTrue()
	{
		// Arrange
		nuint value = 0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void NUInt_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (nuint)Random.Shared.Next(1, int.MaxValue);

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Float_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (float)(Random.Shared.NextDouble() + 0.0001d); // guaranteed != 0

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Float_Zero_ReturnsFalse()
	{
		// Arrange
		const float value = 0f;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Float_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const float value = 0f;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Float_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (float)(Random.Shared.NextDouble() + 0.0001d); // guaranteed != 0

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Double_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = Random.Shared.NextDouble() + 0.0001d; // guaranteed != 0

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Double_Zero_ReturnsFalse()
	{
		// Arrange
		const double value = 0d;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Double_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const double value = 0d;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Double_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = Random.Shared.NextDouble() + 0.0001d; // guaranteed != 0

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Decimal_NonZero_ReturnsTrue()
	{
		// Arrange
		var value = (decimal)(Random.Shared.NextDouble() + 0.0001d); // guaranteed != 0

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Decimal_Zero_ReturnsFalse()
	{
		// Arrange
		const decimal value = 0m;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Decimal_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const decimal value = 0m;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Decimal_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		var value = (decimal)(Random.Shared.NextDouble() + 0.0001d); // guaranteed != 0

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Char_NonZero_ReturnsTrue()
	{
		// Arrange
		const char value = (char)1; // non-zero

		// Act
		var result = value ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Char_Zero_ReturnsFalse()
	{
		// Arrange
		const char value = (char)0;

		// Act
		var result = value ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Char_Zero_NegatedReturnsTrue()
	{
		// Arrange
		const char value = (char)0;

		// Act
		var result = !value;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Char_NonZero_NegatedReturnsFalse()
	{
		// Arrange
		const char value = (char)1; // non-zero

		// Act
		var result = !value;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Enum_Default_ReturnFalse()
	{
		// Arrange
		var color = Colors.None;

		// Act
		var result = color ? true : false;

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Enum_Default_NegatedReturnTrue()
	{
		// Arrange
		var color = Colors.None;

		// Act
		var result = !color;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Enum_NonDefault_ReturnTrue()
	{
		// Arrange
		var color = Colors.Red;

		// Act
		var result = color ? true : false;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Enum_NonDefault_NegatedReturnFalse()
	{
		// Arrange
		var color = Colors.Red;

		// Act
		var result = !color;

		// Assert
		Assert.False(result);
	}
}

file enum Colors
{
	None = 0,
	Red = 1
}