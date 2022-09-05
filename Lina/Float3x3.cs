using System;

namespace Lina;

public struct Float3x3
{
	private readonly float[,] _values = new float[3, 3];

	public Float3x3(float[,] values)
	{
		if (values.GetLength(0) != 3 || values.GetLength(1) != 3)
			throw new ArgumentException("values must be a 3 by 3 array");

		_values = values;
	}

	public float this[int row, int column]
	{
		get => _values[row, column];
		set => _values[row, column] = value;
	}
}
