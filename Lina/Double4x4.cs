using System;

namespace Lina;

public struct Double4x4
{
	private readonly double[,] _values = new double[4, 4];

	public Double4x4(double[,] values)
	{
		if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
			throw new ArgumentException("values must be a 4 by 4 array");

		_values = values;
	}

	public double this[int row, int column]
	{
		get => _values[row, column];
		set => _values[row, column] = value;
	}
}
