using System;

namespace Lina;

public struct Double3x3
{
	private readonly double[,] _values = new double[3, 3];

	public Double3x3(double[,] values)
	{
		if (values.GetLength(0) != 3 || values.GetLength(1) != 3)
			throw new ArgumentException("values must be a 3 by 3 array");

		_values = values;
	}

	public double this[int row, int column]
	{
		get => _values[row, column];
		set => _values[row, column] = value;
	}
}
