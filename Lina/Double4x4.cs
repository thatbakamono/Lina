﻿using System;

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
}
