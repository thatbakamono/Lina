using System;

namespace Lina;

public struct Float4x4
{
	public Float4x4 Identity => new Float4x4(new float[4, 4]
	{
		{ 1.0f, 0.0f, 0.0f, 0.0f },
		{ 0.0f, 1.0f, 0.0f, 0.0f },
		{ 0.0f, 0.0f, 1.0f, 0.0f },
		{ 0.0f, 0.0f, 0.0f, 1.0f }
	});

	private readonly float[,] _values = new float[4, 4];

	public Float4x4(float[,] values)
	{
		if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
			throw new ArgumentException("values must be a 4 by 4 array");

		_values = values;
	}

	public float this[int column, int row]
	{
		get => _values[column, row];
		set => _values[column, row] = value;
	}

	public static Float4x4 operator +(Float4x4 left, Float4x4 right) => new Float4x4(new float[4, 4]
	{
		{ left[0, 0] + right[0, 0], left[0, 1] + right[0, 1], left[0, 2] + right[0, 2], left[0, 3] + right[0, 3] },
		{ left[1, 0] + right[1, 0], left[1, 1] + right[1, 1], left[1, 2] + right[1, 2], left[1, 3] + right[1, 3] },
		{ left[2, 0] + right[2, 0], left[2, 1] + right[2, 1], left[2, 2] + right[2, 2], left[2, 3] + right[2, 3] },
		{ left[3, 0] + right[3, 0], left[3, 1] + right[3, 1], left[3, 2] + right[3, 2], left[3, 3] + right[3, 3] }
	});

	public static Float4x4 operator -(Float4x4 left, Float4x4 right) => new Float4x4(new float[4, 4]
	{
		{ left[0, 0] - right[0, 0], left[0, 1] - right[0, 1], left[0, 2] - right[0, 2], left[0, 3] - right[0, 3] },
		{ left[1, 0] - right[1, 0], left[1, 1] - right[1, 1], left[1, 2] - right[1, 2], left[1, 3] - right[1, 3] },
		{ left[2, 0] - right[2, 0], left[2, 1] - right[2, 1], left[2, 2] - right[2, 2], left[2, 3] - right[2, 3] },
		{ left[3, 0] - right[3, 0], left[3, 1] - right[3, 1], left[3, 2] - right[3, 2], left[3, 3] - right[3, 3] }
	});

	public static Float4x4 operator *(Float4x4 left, Float4x4 right) => new Float4x4(new float[4, 4]
	{
		{ left[0, 0] * right[0, 0], left[0, 1] * right[0, 1], left[0, 2] * right[0, 2], left[0, 3] * right[0, 3] },
		{ left[1, 0] * right[1, 0], left[1, 1] * right[1, 1], left[1, 2] * right[1, 2], left[1, 3] * right[1, 3] },
		{ left[2, 0] * right[2, 0], left[2, 1] * right[2, 1], left[2, 2] * right[2, 2], left[2, 3] * right[2, 3] },
		{ left[3, 0] * right[3, 0], left[3, 1] * right[3, 1], left[3, 2] * right[3, 2], left[3, 3] * right[3, 3] }
	});

	public static Float4x4 operator /(Float4x4 left, Float4x4 right) => new Float4x4(new float[4, 4]
	{
		{ left[0, 0] / right[0, 0], left[0, 1] / right[0, 1], left[0, 2] / right[0, 2], left[0, 3] / right[0, 3] },
		{ left[1, 0] / right[1, 0], left[1, 1] / right[1, 1], left[1, 2] / right[1, 2], left[1, 3] / right[1, 3] },
		{ left[2, 0] / right[2, 0], left[2, 1] / right[2, 1], left[2, 2] / right[2, 2], left[2, 3] / right[2, 3] },
		{ left[3, 0] / right[3, 0], left[3, 1] / right[3, 1], left[3, 2] / right[3, 2], left[3, 3] / right[3, 3] }
	});
}
