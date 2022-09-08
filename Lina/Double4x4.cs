using System;

namespace Lina;

public struct Double4x4
{
	public Double4x4 Identity => new Double4x4(new double[4, 4]
	{
		{ 1.0, 0.0, 0.0, 0.0 },
		{ 0.0, 1.0, 0.0, 0.0 },
		{ 0.0, 0.0, 1.0, 0.0 },
		{ 0.0, 0.0, 0.0, 1.0 }
	});

	private readonly double[,] _values = new double[4, 4];

	public Double4x4(double[,] values)
	{
		if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
			throw new ArgumentException("values must be a 4 by 4 array");

		_values = values;
	}

	public double this[int column, int row]
	{
		get => _values[column, row];
		set => _values[column, row] = value;
	}

	public static Double4x4 operator +(Double4x4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] + right[0, 0], left[0, 1] + right[0, 1], left[0, 2] + right[0, 2], left[0, 3] + right[0, 3] },
		{ left[1, 0] + right[1, 0], left[1, 1] + right[1, 1], left[1, 2] + right[1, 2], left[1, 3] + right[1, 3] },
		{ left[2, 0] + right[2, 0], left[2, 1] + right[2, 1], left[2, 2] + right[2, 2], left[2, 3] + right[2, 3] },
		{ left[3, 0] + right[3, 0], left[3, 1] + right[3, 1], left[3, 2] + right[3, 2], left[3, 3] + right[3, 3] }
	});

	public static Double4x4 operator -(Double4x4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] - right[0, 0], left[0, 1] - right[0, 1], left[0, 2] - right[0, 2], left[0, 3] - right[0, 3] },
		{ left[1, 0] - right[1, 0], left[1, 1] - right[1, 1], left[1, 2] - right[1, 2], left[1, 3] - right[1, 3] },
		{ left[2, 0] - right[2, 0], left[2, 1] - right[2, 1], left[2, 2] - right[2, 2], left[2, 3] - right[2, 3] },
		{ left[3, 0] - right[3, 0], left[3, 1] - right[3, 1], left[3, 2] - right[3, 2], left[3, 3] - right[3, 3] }
	});

	public static Double4x4 operator *(Double4x4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] * right[0, 0], left[0, 1] * right[0, 1], left[0, 2] * right[0, 2], left[0, 3] * right[0, 3] },
		{ left[1, 0] * right[1, 0], left[1, 1] * right[1, 1], left[1, 2] * right[1, 2], left[1, 3] * right[1, 3] },
		{ left[2, 0] * right[2, 0], left[2, 1] * right[2, 1], left[2, 2] * right[2, 2], left[2, 3] * right[2, 3] },
		{ left[3, 0] * right[3, 0], left[3, 1] * right[3, 1], left[3, 2] * right[3, 2], left[3, 3] * right[3, 3] }
	});

	public static Double4x4 operator /(Double4x4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] / right[0, 0], left[0, 1] / right[0, 1], left[0, 2] / right[0, 2], left[0, 3] / right[0, 3] },
		{ left[1, 0] / right[1, 0], left[1, 1] / right[1, 1], left[1, 2] / right[1, 2], left[1, 3] / right[1, 3] },
		{ left[2, 0] / right[2, 0], left[2, 1] / right[2, 1], left[2, 2] / right[2, 2], left[2, 3] / right[2, 3] },
		{ left[3, 0] / right[3, 0], left[3, 1] / right[3, 1], left[3, 2] / right[3, 2], left[3, 3] / right[3, 3] }
	});

	public static Double4x4 operator +(Double4x4 left, double right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] + right, left[0, 1] + right, left[0, 2] + right, left[0, 3] + right },
		{ left[1, 0] + right, left[1, 1] + right, left[1, 2] + right, left[1, 3] + right },
		{ left[2, 0] + right, left[2, 1] + right, left[2, 2] + right, left[2, 3] + right },
		{ left[3, 0] + right, left[3, 1] + right, left[3, 2] + right, left[3, 3] + right }
	});

	public static Double4x4 operator -(Double4x4 left, double right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] - right, left[0, 1] - right, left[0, 2] - right, left[0, 3] - right },
		{ left[1, 0] - right, left[1, 1] - right, left[1, 2] - right, left[1, 3] - right },
		{ left[2, 0] - right, left[2, 1] - right, left[2, 2] - right, left[2, 3] - right },
		{ left[3, 0] - right, left[3, 1] - right, left[3, 2] - right, left[3, 3] - right }
	});

	public static Double4x4 operator *(Double4x4 left, double right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] * right, left[0, 1] * right, left[0, 2] * right, left[0, 3] * right },
		{ left[1, 0] * right, left[1, 1] * right, left[1, 2] * right, left[1, 3] * right },
		{ left[2, 0] * right, left[2, 1] * right, left[2, 2] * right, left[2, 3] * right },
		{ left[3, 0] * right, left[3, 1] * right, left[3, 2] * right, left[3, 3] * right }
	});

	public static Double4x4 operator /(Double4x4 left, double right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] / right, left[0, 1] / right, left[0, 2] / right, left[0, 3] / right },
		{ left[1, 0] / right, left[1, 1] / right, left[1, 2] / right, left[1, 3] / right },
		{ left[2, 0] / right, left[2, 1] / right, left[2, 2] / right, left[2, 3] / right },
		{ left[3, 0] / right, left[3, 1] / right, left[3, 2] / right, left[3, 3] / right }
	});

	public static Double4x4 operator +(double left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left + right[0, 0], left + right[0, 1], left + right[0, 2], left + right[0, 3] },
		{ left + right[1, 0], left + right[1, 1], left + right[1, 2], left + right[1, 3] },
		{ left + right[2, 0], left + right[2, 1], left + right[2, 2], left + right[2, 3] },
		{ left + right[3, 0], left + right[3, 1], left + right[3, 2], left + right[3, 3] }
	});

	public static Double4x4 operator -(double left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left - right[0, 0], left - right[0, 1], left - right[0, 2], left - right[0, 3] },
		{ left - right[1, 0], left - right[1, 1], left - right[1, 2], left - right[1, 3] },
		{ left - right[2, 0], left - right[2, 1], left - right[2, 2], left - right[2, 3] },
		{ left - right[3, 0], left - right[3, 1], left - right[3, 2], left - right[3, 3] }
	});

	public static Double4x4 operator *(double left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left * right[0, 0], left * right[0, 1], left * right[0, 2], left * right[0, 3] },
		{ left * right[1, 0], left * right[1, 1], left * right[1, 2], left * right[1, 3] },
		{ left * right[2, 0], left * right[2, 1], left * right[2, 2], left * right[2, 3] },
		{ left * right[3, 0], left * right[3, 1], left * right[3, 2], left * right[3, 3] }
	});

	public static Double4x4 operator /(double left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left / right[0, 0], left / right[0, 1], left / right[0, 2], left / right[0, 3] },
		{ left / right[1, 0], left / right[1, 1], left / right[1, 2], left / right[1, 3] },
		{ left / right[2, 0], left / right[2, 1], left / right[2, 2], left / right[2, 3] },
		{ left / right[3, 0], left / right[3, 1], left / right[3, 2], left / right[3, 3] }
	});

	public static Double4x4 operator +(Double4x4 left, Double4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] + right.X, left[0, 1] + right.Y, left[0, 2] + right.Z, left[0, 3] + right.W },
		{ left[1, 0] + right.X, left[1, 1] + right.Y, left[1, 2] + right.Z, left[1, 3] + right.W },
		{ left[2, 0] + right.X, left[2, 1] + right.Y, left[2, 2] + right.Z, left[2, 3] + right.W },
		{ left[3, 0] + right.X, left[3, 1] + right.Y, left[3, 2] + right.Z, left[3, 3] + right.W }
	});

	public static Double4x4 operator -(Double4x4 left, Double4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] - right.X, left[0, 1] - right.Y, left[0, 2] - right.Z, left[0, 3] - right.W },
		{ left[1, 0] - right.X, left[1, 1] - right.Y, left[1, 2] - right.Z, left[1, 3] - right.W },
		{ left[2, 0] - right.X, left[2, 1] - right.Y, left[2, 2] - right.Z, left[2, 3] - right.W },
		{ left[3, 0] - right.X, left[3, 1] - right.Y, left[3, 2] - right.Z, left[3, 3] - right.W }
	});

	public static Double4x4 operator *(Double4x4 left, Double4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] * right.X, left[0, 1] * right.Y, left[0, 2] * right.Z, left[0, 3] * right.W },
		{ left[1, 0] * right.X, left[1, 1] * right.Y, left[1, 2] * right.Z, left[1, 3] * right.W },
		{ left[2, 0] * right.X, left[2, 1] * right.Y, left[2, 2] * right.Z, left[2, 3] * right.W },
		{ left[3, 0] * right.X, left[3, 1] * right.Y, left[3, 2] * right.Z, left[3, 3] * right.W }
	});

	public static Double4x4 operator /(Double4x4 left, Double4 right) => new Double4x4(new double[4, 4]
	{
		{ left[0, 0] / right.X, left[0, 1] / right.Y, left[0, 2] / right.Z, left[0, 3] / right.W },
		{ left[1, 0] / right.X, left[1, 1] / right.Y, left[1, 2] / right.Z, left[1, 3] / right.W },
		{ left[2, 0] / right.X, left[2, 1] / right.Y, left[2, 2] / right.Z, left[2, 3] / right.W },
		{ left[3, 0] / right.X, left[3, 1] / right.Y, left[3, 2] / right.Z, left[3, 3] / right.W }
	});

	public static Double4x4 operator +(Double4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left.X + right[0, 0], left.Y + right[0, 1], left.Z + right[0, 2], left.W + right[0, 3] },
		{ left.X + right[1, 0], left.Y + right[1, 1], left.Z + right[1, 2], left.W + right[1, 3] },
		{ left.X + right[2, 0], left.Y + right[2, 1], left.Z + right[2, 2], left.W + right[2, 3] },
		{ left.X + right[3, 0], left.Y + right[3, 1], left.Z + right[3, 2], left.W + right[3, 3] }
	});

	public static Double4x4 operator -(Double4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left.X - right[0, 0], left.Y - right[0, 1], left.Z - right[0, 2], left.W - right[0, 3] },
		{ left.X - right[1, 0], left.Y - right[1, 1], left.Z - right[1, 2], left.W - right[1, 3] },
		{ left.X - right[2, 0], left.Y - right[2, 1], left.Z - right[2, 2], left.W - right[2, 3] },
		{ left.X - right[3, 0], left.Y - right[3, 1], left.Z - right[3, 2], left.W - right[3, 3] }
	});

	public static Double4x4 operator *(Double4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left.X * right[0, 0], left.Y * right[0, 1], left.Z * right[0, 2], left.W * right[0, 3] },
		{ left.X * right[1, 0], left.Y * right[1, 1], left.Z * right[1, 2], left.W * right[1, 3] },
		{ left.X * right[2, 0], left.Y * right[2, 1], left.Z * right[2, 2], left.W * right[2, 3] },
		{ left.X * right[3, 0], left.Y * right[3, 1], left.Z * right[3, 2], left.W * right[3, 3] }
	});

	public static Double4x4 operator /(Double4 left, Double4x4 right) => new Double4x4(new double[4, 4]
	{
		{ left.X / right[0, 0], left.Y / right[0, 1], left.Z / right[0, 2], left.W / right[0, 3] },
		{ left.X / right[1, 0], left.Y / right[1, 1], left.Z / right[1, 2], left.W / right[1, 3] },
		{ left.X / right[2, 0], left.Y / right[2, 1], left.Z / right[2, 2], left.W / right[2, 3] },
		{ left.X / right[3, 0], left.Y / right[3, 1], left.Z / right[3, 2], left.W / right[3, 3] }
	});
}
