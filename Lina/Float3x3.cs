using System;

namespace Lina;

public struct Float3x3
{
	public Float3x3 Identity => new Float3x3(new float[3, 3]
	{
		{ 1.0f, 0.0f, 0.0f },
		{ 0.0f, 1.0f, 0.0f },
		{ 0.0f, 0.0f, 1.0f }
	});

	private readonly float[,] _values = new float[3, 3];

	public Float3x3(float[,] values)
	{
		if (values.GetLength(0) != 3 || values.GetLength(1) != 3)
			throw new ArgumentException("values must be a 3 by 3 array");

		_values = values;
	}

	public float this[int column, int row]
	{
		get => _values[column, row];
		set => _values[column, row] = value;
	}

	public static Float3x3 operator +(Float3x3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] + right[0, 0], left[0, 1] + right[0, 1], left[0, 2] + right[0, 2] },
		{ left[1, 0] + right[1, 0], left[1, 1] + right[1, 1], left[1, 2] + right[1, 2] },
		{ left[2, 0] + right[2, 0], left[2, 1] + right[2, 1], left[2, 2] + right[2, 2] }
	});

	public static Float3x3 operator -(Float3x3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] - right[0, 0], left[0, 1] - right[0, 1], left[0, 2] - right[0, 2] },
		{ left[1, 0] - right[1, 0], left[1, 1] - right[1, 1], left[1, 2] - right[1, 2] },
		{ left[2, 0] - right[2, 0], left[2, 1] - right[2, 1], left[2, 2] - right[2, 2] }
	});

	public static Float3x3 operator *(Float3x3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] * right[0, 0], left[0, 1] * right[0, 1], left[0, 2] * right[0, 2] },
		{ left[1, 0] * right[1, 0], left[1, 1] * right[1, 1], left[1, 2] * right[1, 2] },
		{ left[2, 0] * right[2, 0], left[2, 1] * right[2, 1], left[2, 2] * right[2, 2] }
	});

	public static Float3x3 operator /(Float3x3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] / right[0, 0], left[0, 1] / right[0, 1], left[0, 2] / right[0, 2] },
		{ left[1, 0] / right[1, 0], left[1, 1] / right[1, 1], left[1, 2] / right[1, 2] },
		{ left[2, 0] / right[2, 0], left[2, 1] / right[2, 1], left[2, 2] / right[2, 2] }
	});

	public static Float3x3 operator +(Float3x3 left, float right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] + right, left[0, 1] + right, left[0, 2] + right },
		{ left[1, 0] + right, left[1, 1] + right, left[1, 2] + right },
		{ left[2, 0] + right, left[2, 1] + right, left[2, 2] + right }
	});

	public static Float3x3 operator -(Float3x3 left, float right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] - right, left[0, 1] - right, left[0, 2] - right },
		{ left[1, 0] - right, left[1, 1] - right, left[1, 2] - right },
		{ left[2, 0] - right, left[2, 1] - right, left[2, 2] - right }
	});

	public static Float3x3 operator *(Float3x3 left, float right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] * right, left[0, 1] * right, left[0, 2] * right },
		{ left[1, 0] * right, left[1, 1] * right, left[1, 2] * right },
		{ left[2, 0] * right, left[2, 1] * right, left[2, 2] * right }
	});

	public static Float3x3 operator /(Float3x3 left, float right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] / right, left[0, 1] / right, left[0, 2] / right },
		{ left[1, 0] / right, left[1, 1] / right, left[1, 2] / right },
		{ left[2, 0] / right, left[2, 1] / right, left[2, 2] / right }
	});

	public static Float3x3 operator +(float left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left + right[0, 0], left + right[0, 1], left + right[0, 2] },
		{ left + right[1, 0], left + right[1, 1], left + right[1, 2] },
		{ left + right[2, 0], left + right[2, 1], left + right[2, 2] }
	});

	public static Float3x3 operator -(float left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left - right[0, 0], left - right[0, 1], left - right[0, 2] },
		{ left - right[1, 0], left - right[1, 1], left - right[1, 2] },
		{ left - right[2, 0], left - right[2, 1], left - right[2, 2] }
	});

	public static Float3x3 operator *(float left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left * right[0, 0], left * right[0, 1], left * right[0, 2] },
		{ left * right[1, 0], left * right[1, 1], left * right[1, 2] },
		{ left * right[2, 0], left * right[2, 1], left * right[2, 2] }
	});

	public static Float3x3 operator /(float left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left / right[0, 0], left / right[0, 1], left / right[0, 2] },
		{ left / right[1, 0], left / right[1, 1], left / right[1, 2] },
		{ left / right[2, 0], left / right[2, 1], left / right[2, 2] }
	});

	public static Float3x3 operator +(Float3x3 left, Float3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] + right.X, left[0, 1] + right.Y, left[0, 2] + right.Z },
		{ left[1, 0] + right.X, left[1, 1] + right.Y, left[1, 2] + right.Z },
		{ left[2, 0] + right.X, left[2, 1] + right.Y, left[2, 2] + right.Z }
	});

	public static Float3x3 operator -(Float3x3 left, Float3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] - right.X, left[0, 1] - right.Y, left[0, 2] - right.Z },
		{ left[1, 0] - right.X, left[1, 1] - right.Y, left[1, 2] - right.Z },
		{ left[2, 0] - right.X, left[2, 1] - right.Y, left[2, 2] - right.Z }
	});

	public static Float3x3 operator *(Float3x3 left, Float3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] * right.X, left[0, 1] * right.Y, left[0, 2] * right.Z },
		{ left[1, 0] * right.X, left[1, 1] * right.Y, left[1, 2] * right.Z },
		{ left[2, 0] * right.X, left[2, 1] * right.Y, left[2, 2] * right.Z }
	});

	public static Float3x3 operator /(Float3x3 left, Float3 right) => new Float3x3(new float[3, 3]
	{
		{ left[0, 0] / right.X, left[0, 1] / right.Y, left[0, 2] / right.Z },
		{ left[1, 0] / right.X, left[1, 1] / right.Y, left[1, 2] / right.Z },
		{ left[2, 0] / right.X, left[2, 1] / right.Y, left[2, 2] / right.Z }
	});

	public static Float3x3 operator +(Float3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left.X + right[0, 0], left.Y + right[0, 1], left.Z + right[0, 2] },
		{ left.X + right[1, 0], left.Y + right[1, 1], left.Z + right[1, 2] },
		{ left.X + right[2, 0], left.Y + right[2, 1], left.Z + right[2, 2] }
	});

	public static Float3x3 operator -(Float3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left.X - right[0, 0], left.Y - right[0, 1], left.Z - right[0, 2] },
		{ left.X - right[1, 0], left.Y - right[1, 1], left.Z - right[1, 2] },
		{ left.X - right[2, 0], left.Y - right[2, 1], left.Z - right[2, 2] }
	});

	public static Float3x3 operator *(Float3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left.X * right[0, 0], left.Y * right[0, 1], left.Z * right[0, 2] },
		{ left.X * right[1, 0], left.Y * right[1, 1], left.Z * right[1, 2] },
		{ left.X * right[2, 0], left.Y * right[2, 1], left.Z * right[2, 2] }
	});

	public static Float3x3 operator /(Float3 left, Float3x3 right) => new Float3x3(new float[3, 3]
	{
		{ left.X / right[0, 0], left.Y / right[0, 1], left.Z / right[0, 2] },
		{ left.X / right[1, 0], left.Y / right[1, 1], left.Z / right[1, 2] },
		{ left.X / right[2, 0], left.Y / right[2, 1], left.Z / right[2, 2] }
	});
}
