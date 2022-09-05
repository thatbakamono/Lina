using System;

namespace Lina;

public struct Float4x4
{
	private readonly float[,] _values = new float[4, 4];

	public Float4x4(float[,] values)
	{
		if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
			throw new ArgumentException("values must be a 4 by 4 array");

		_values = values;
	}

	public float this[int row, int column]
	{
		get => _values[row, column];
		set => _values[row, column] = value;
	}
}
