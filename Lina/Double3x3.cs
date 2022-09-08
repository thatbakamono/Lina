using System;

namespace Lina;

public struct Double3x3
{
	public Double3x3 Identity => new Double3x3(new double[3, 3]
	{
		{ 1.0, 0.0, 0.0 },
		{ 0.0, 1.0, 0.0 },
		{ 0.0, 0.0, 1.0 }
	});

	private readonly double[,] _values = new double[3, 3];

	public Double3x3(double[,] values)
	{
		if (values.GetLength(0) != 3 || values.GetLength(1) != 3)
			throw new ArgumentException("values must be a 3 by 3 array");

		_values = values;
	}

	public double this[int column, int row]
	{
		get => _values[column, row];
		set => _values[column, row] = value;
	}
}
