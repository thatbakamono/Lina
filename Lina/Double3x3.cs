using System;

namespace Lina;

public struct Double3x3
{
	public Double3x3 Identity => new Double3x3(
		new Double3(1.0, 0.0, 0.0),
		new Double3(0.0, 1.0, 0.0),
		new Double3(0.0, 0.0, 1.0)
	);

	public Double3 A
	{
		get => _a;
		set => _a = value;
	}

	public Double3 B
	{
		get => _b;
		set => _b = value;
	}

	public Double3 C
	{
		get => _c;
		set => _c = value;
	}

	private Double3 _a;
	private Double3 _b;
	private Double3 _c;

	public Double3x3(Double3 a, Double3 b, Double3 c)
	{
		_a = a;
		_b = b;
		_c = c;
	}

	public double this[int column, int row]
	{
		get => column switch {
			0 => _a[row],
			1 => _b[row],
			2 => _c[row],
			_ => throw new IndexOutOfRangeException(),
		};
		set
		{
			switch (column)
			{
				case 0:
					_a[row] = value;

					break;
				case 1:
					_b[row] = value;

					break;
				case 2:
					_c[row] = value;

					break;
				default:
					throw new IndexOutOfRangeException();
			}
		}
	}

	public static Double3x3 operator +(Double3x3 left, Double3x3 right) => new Double3x3(
		new Double3(left[0, 0] + right[0, 0], left[0, 1] + right[0, 1], left[0, 2] + right[0, 2]),
		new Double3(left[1, 0] + right[1, 0], left[1, 1] + right[1, 1], left[1, 2] + right[1, 2]),
		new Double3(left[2, 0] + right[2, 0], left[2, 1] + right[2, 1], left[2, 2] + right[2, 2])
	);

	public static Double3x3 operator -(Double3x3 left, Double3x3 right) => new Double3x3(
		new Double3(left[0, 0] - right[0, 0], left[0, 1] - right[0, 1], left[0, 2] - right[0, 2]),
		new Double3(left[1, 0] - right[1, 0], left[1, 1] - right[1, 1], left[1, 2] - right[1, 2]),
		new Double3(left[2, 0] - right[2, 0], left[2, 1] - right[2, 1], left[2, 2] - right[2, 2])
	);

	public static Double3x3 operator *(Double3x3 left, Double3x3 right) => new Double3x3(
		new Double3(left[0, 0] * right[0, 0], left[0, 1] * right[0, 1], left[0, 2] * right[0, 2]),
		new Double3(left[1, 0] * right[1, 0], left[1, 1] * right[1, 1], left[1, 2] * right[1, 2]),
		new Double3(left[2, 0] * right[2, 0], left[2, 1] * right[2, 1], left[2, 2] * right[2, 2])
	);

	public static Double3x3 operator /(Double3x3 left, Double3x3 right) => new Double3x3(
		new Double3(left[0, 0] / right[0, 0], left[0, 1] / right[0, 1], left[0, 2] / right[0, 2]),
		new Double3(left[1, 0] / right[1, 0], left[1, 1] / right[1, 1], left[1, 2] / right[1, 2]),
		new Double3(left[2, 0] / right[2, 0], left[2, 1] / right[2, 1], left[2, 2] / right[2, 2])
	);

	public static Double3x3 operator +(Double3x3 left, double right) => new Double3x3(
		new Double3(left[0, 0] + right, left[0, 1] + right, left[0, 2] + right),
		new Double3(left[1, 0] + right, left[1, 1] + right, left[1, 2] + right),
		new Double3(left[2, 0] + right, left[2, 1] + right, left[2, 2] + right)
	);

	public static Double3x3 operator -(Double3x3 left, double right) => new Double3x3(
		new Double3(left[0, 0] - right, left[0, 1] - right, left[0, 2] - right),
		new Double3(left[1, 0] - right, left[1, 1] - right, left[1, 2] - right),
		new Double3(left[2, 0] - right, left[2, 1] - right, left[2, 2] - right)
	);

	public static Double3x3 operator *(Double3x3 left, double right) => new Double3x3(
		new Double3(left[0, 0] * right, left[0, 1] * right, left[0, 2] * right),
		new Double3(left[1, 0] * right, left[1, 1] * right, left[1, 2] * right),
		new Double3(left[2, 0] * right, left[2, 1] * right, left[2, 2] * right)
	);

	public static Double3x3 operator /(Double3x3 left, double right) => new Double3x3(
		new Double3(left[0, 0] / right, left[0, 1] / right, left[0, 2] / right),
		new Double3(left[1, 0] / right, left[1, 1] / right, left[1, 2] / right),
		new Double3(left[2, 0] / right, left[2, 1] / right, left[2, 2] / right)
	);

	public static Double3x3 operator +(double left, Double3x3 right) => new Double3x3(
		new Double3(left + right[0, 0], left + right[0, 1], left + right[0, 2]),
		new Double3(left + right[1, 0], left + right[1, 1], left + right[1, 2]),
		new Double3(left + right[2, 0], left + right[2, 1], left + right[2, 2])
	);

	public static Double3x3 operator -(double left, Double3x3 right) => new Double3x3(
		new Double3(left - right[0, 0], left - right[0, 1], left - right[0, 2]),
		new Double3(left - right[1, 0], left - right[1, 1], left - right[1, 2]),
		new Double3(left - right[2, 0], left - right[2, 1], left - right[2, 2])
	);

	public static Double3x3 operator *(double left, Double3x3 right) => new Double3x3(
		new Double3(left * right[0, 0], left * right[0, 1], left * right[0, 2]),
		new Double3(left * right[1, 0], left * right[1, 1], left * right[1, 2]),
		new Double3(left * right[2, 0], left * right[2, 1], left * right[2, 2])
	);

	public static Double3x3 operator /(double left, Double3x3 right) => new Double3x3(
		new Double3(left / right[0, 0], left / right[0, 1], left / right[0, 2]),
		new Double3(left / right[1, 0], left / right[1, 1], left / right[1, 2]),
		new Double3(left / right[2, 0], left / right[2, 1], left / right[2, 2])
	);

	public static Double3x3 operator +(Double3x3 left, Double3 right) => new Double3x3(
		new Double3(left[0, 0] + right.X, left[0, 1] + right.Y, left[0, 2] + right.Z),
		new Double3(left[1, 0] + right.X, left[1, 1] + right.Y, left[1, 2] + right.Z),
		new Double3(left[2, 0] + right.X, left[2, 1] + right.Y, left[2, 2] + right.Z)
	);

	public static Double3x3 operator -(Double3x3 left, Double3 right) => new Double3x3(
		new Double3(left[0, 0] - right.X, left[0, 1] - right.Y, left[0, 2] - right.Z),
		new Double3(left[1, 0] - right.X, left[1, 1] - right.Y, left[1, 2] - right.Z),
		new Double3(left[2, 0] - right.X, left[2, 1] - right.Y, left[2, 2] - right.Z)
	);

	public static Double3x3 operator *(Double3x3 left, Double3 right) => new Double3x3(
		new Double3(left[0, 0] * right.X, left[0, 1] * right.Y, left[0, 2] * right.Z),
		new Double3(left[1, 0] * right.X, left[1, 1] * right.Y, left[1, 2] * right.Z),
		new Double3(left[2, 0] * right.X, left[2, 1] * right.Y, left[2, 2] * right.Z)
	);

	public static Double3x3 operator /(Double3x3 left, Double3 right) => new Double3x3(
		new Double3(left[0, 0] / right.X, left[0, 1] / right.Y, left[0, 2] / right.Z),
		new Double3(left[1, 0] / right.X, left[1, 1] / right.Y, left[1, 2] / right.Z),
		new Double3(left[2, 0] / right.X, left[2, 1] / right.Y, left[2, 2] / right.Z)
	);

	public static Double3x3 operator +(Double3 left, Double3x3 right) => new Double3x3(
		new Double3(left.X + right[0, 0], left.Y + right[0, 1], left.Z + right[0, 2]),
		new Double3(left.X + right[1, 0], left.Y + right[1, 1], left.Z + right[1, 2]),
		new Double3(left.X + right[2, 0], left.Y + right[2, 1], left.Z + right[2, 2])
	);

	public static Double3x3 operator -(Double3 left, Double3x3 right) => new Double3x3(
		new Double3(left.X - right[0, 0], left.Y - right[0, 1], left.Z - right[0, 2]),
		new Double3(left.X - right[1, 0], left.Y - right[1, 1], left.Z - right[1, 2]),
		new Double3(left.X - right[2, 0], left.Y - right[2, 1], left.Z - right[2, 2])
	);

	public static Double3x3 operator *(Double3 left, Double3x3 right) => new Double3x3(
		new Double3(left.X * right[0, 0], left.Y * right[0, 1], left.Z * right[0, 2]),
		new Double3(left.X * right[1, 0], left.Y * right[1, 1], left.Z * right[1, 2]),
		new Double3(left.X * right[2, 0], left.Y * right[2, 1], left.Z * right[2, 2])
	);

	public static Double3x3 operator /(Double3 left, Double3x3 right) => new Double3x3(
		new Double3(left.X / right[0, 0], left.Y / right[0, 1], left.Z / right[0, 2]),
		new Double3(left.X / right[1, 0], left.Y / right[1, 1], left.Z / right[1, 2]),
		new Double3(left.X / right[2, 0], left.Y / right[2, 1], left.Z / right[2, 2])
	);
}
