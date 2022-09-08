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
}
