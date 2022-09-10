using System;

namespace Lina;

public struct Float3x3
{
	public Float3x3 Identity => new Float3x3(
		new Float3(1.0f, 0.0f, 0.0f),
		new Float3(0.0f, 1.0f, 0.0f),
		new Float3(0.0f, 0.0f, 1.0f)
	);

	public Float3 A
	{
		get => _a;
		set => _a = value;
	}

	public Float3 B
	{
		get => _b;
		set => _b = value;
	}

	public Float3 C
	{
		get => _c;
		set => _c = value;
	}

	private Float3 _a;
	private Float3 _b;
	private Float3 _c;

	public Float3x3(Float3 a, Float3 b, Float3 c)
	{
		_a = a;
		_b = b;
		_c = c;
	}

	public float this[int column, int row]
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

	public static Float3x3 operator +(Float3x3 left, Float3x3 right) => new Float3x3(
		new Float3(left[0, 0] + right[0, 0], left[0, 1] + right[0, 1], left[0, 2] + right[0, 2]),
		new Float3(left[1, 0] + right[1, 0], left[1, 1] + right[1, 1], left[1, 2] + right[1, 2]),
		new Float3(left[2, 0] + right[2, 0], left[2, 1] + right[2, 1], left[2, 2] + right[2, 2])
	);

	public static Float3x3 operator -(Float3x3 left, Float3x3 right) => new Float3x3(
		new Float3(left[0, 0] - right[0, 0], left[0, 1] - right[0, 1], left[0, 2] - right[0, 2]),
		new Float3(left[1, 0] - right[1, 0], left[1, 1] - right[1, 1], left[1, 2] - right[1, 2]),
		new Float3(left[2, 0] - right[2, 0], left[2, 1] - right[2, 1], left[2, 2] - right[2, 2])
	);

	public static Float3x3 operator *(Float3x3 left, Float3x3 right) => new Float3x3(
		new Float3(left[0, 0] * right[0, 0], left[0, 1] * right[0, 1], left[0, 2] * right[0, 2]),
		new Float3(left[1, 0] * right[1, 0], left[1, 1] * right[1, 1], left[1, 2] * right[1, 2]),
		new Float3(left[2, 0] * right[2, 0], left[2, 1] * right[2, 1], left[2, 2] * right[2, 2])
	);

	public static Float3x3 operator /(Float3x3 left, Float3x3 right) => new Float3x3(
		new Float3(left[0, 0] / right[0, 0], left[0, 1] / right[0, 1], left[0, 2] / right[0, 2]),
		new Float3(left[1, 0] / right[1, 0], left[1, 1] / right[1, 1], left[1, 2] / right[1, 2]),
		new Float3(left[2, 0] / right[2, 0], left[2, 1] / right[2, 1], left[2, 2] / right[2, 2])
	);

	public static Float3x3 operator +(Float3x3 left, float right) => new Float3x3(
		new Float3(left[0, 0] + right, left[0, 1] + right, left[0, 2] + right),
		new Float3(left[1, 0] + right, left[1, 1] + right, left[1, 2] + right),
		new Float3(left[2, 0] + right, left[2, 1] + right, left[2, 2] + right)
	);

	public static Float3x3 operator -(Float3x3 left, float right) => new Float3x3(
		new Float3(left[0, 0] - right, left[0, 1] - right, left[0, 2] - right),
		new Float3(left[1, 0] - right, left[1, 1] - right, left[1, 2] - right),
		new Float3(left[2, 0] - right, left[2, 1] - right, left[2, 2] - right)
	);

	public static Float3x3 operator *(Float3x3 left, float right) => new Float3x3(
		new Float3(left[0, 0] * right, left[0, 1] * right, left[0, 2] * right),
		new Float3(left[1, 0] * right, left[1, 1] * right, left[1, 2] * right),
		new Float3(left[2, 0] * right, left[2, 1] * right, left[2, 2] * right)
	);

	public static Float3x3 operator /(Float3x3 left, float right) => new Float3x3(
		new Float3(left[0, 0] / right, left[0, 1] / right, left[0, 2] / right),
		new Float3(left[1, 0] / right, left[1, 1] / right, left[1, 2] / right),
		new Float3(left[2, 0] / right, left[2, 1] / right, left[2, 2] / right)
	);

	public static Float3x3 operator +(float left, Float3x3 right) => new Float3x3(
		new Float3(left + right[0, 0], left + right[0, 1], left + right[0, 2]),
		new Float3(left + right[1, 0], left + right[1, 1], left + right[1, 2]),
		new Float3(left + right[2, 0], left + right[2, 1], left + right[2, 2])
	);

	public static Float3x3 operator -(float left, Float3x3 right) => new Float3x3(
		new Float3(left - right[0, 0], left - right[0, 1], left - right[0, 2]),
		new Float3(left - right[1, 0], left - right[1, 1], left - right[1, 2]),
		new Float3(left - right[2, 0], left - right[2, 1], left - right[2, 2])
	);

	public static Float3x3 operator *(float left, Float3x3 right) => new Float3x3(
		new Float3(left * right[0, 0], left * right[0, 1], left * right[0, 2]),
		new Float3(left * right[1, 0], left * right[1, 1], left * right[1, 2]),
		new Float3(left * right[2, 0], left * right[2, 1], left * right[2, 2])
	);

	public static Float3x3 operator /(float left, Float3x3 right) => new Float3x3(
		new Float3(left / right[0, 0], left / right[0, 1], left / right[0, 2]),
		new Float3(left / right[1, 0], left / right[1, 1], left / right[1, 2]),
		new Float3(left / right[2, 0], left / right[2, 1], left / right[2, 2])
	);

	public static Float3x3 operator +(Float3x3 left, Float3 right) => new Float3x3(
		new Float3(left[0, 0] + right.X, left[0, 1] + right.Y, left[0, 2] + right.Z),
		new Float3(left[1, 0] + right.X, left[1, 1] + right.Y, left[1, 2] + right.Z),
		new Float3(left[2, 0] + right.X, left[2, 1] + right.Y, left[2, 2] + right.Z)
	);

	public static Float3x3 operator -(Float3x3 left, Float3 right) => new Float3x3(
		new Float3(left[0, 0] - right.X, left[0, 1] - right.Y, left[0, 2] - right.Z),
		new Float3(left[1, 0] - right.X, left[1, 1] - right.Y, left[1, 2] - right.Z),
		new Float3(left[2, 0] - right.X, left[2, 1] - right.Y, left[2, 2] - right.Z)
	);

	public static Float3x3 operator *(Float3x3 left, Float3 right) => new Float3x3(
		new Float3(left[0, 0] * right.X, left[0, 1] * right.Y, left[0, 2] * right.Z),
		new Float3(left[1, 0] * right.X, left[1, 1] * right.Y, left[1, 2] * right.Z),
		new Float3(left[2, 0] * right.X, left[2, 1] * right.Y, left[2, 2] * right.Z)
	);

	public static Float3x3 operator /(Float3x3 left, Float3 right) => new Float3x3(
		new Float3(left[0, 0] / right.X, left[0, 1] / right.Y, left[0, 2] / right.Z),
		new Float3(left[1, 0] / right.X, left[1, 1] / right.Y, left[1, 2] / right.Z),
		new Float3(left[2, 0] / right.X, left[2, 1] / right.Y, left[2, 2] / right.Z)
	);

	public static Float3x3 operator +(Float3 left, Float3x3 right) => new Float3x3(
		new Float3(left.X + right[0, 0], left.Y + right[0, 1], left.Z + right[0, 2]),
		new Float3(left.X + right[1, 0], left.Y + right[1, 1], left.Z + right[1, 2]),
		new Float3(left.X + right[2, 0], left.Y + right[2, 1], left.Z + right[2, 2])
	);

	public static Float3x3 operator -(Float3 left, Float3x3 right) => new Float3x3(
		new Float3(left.X - right[0, 0], left.Y - right[0, 1], left.Z - right[0, 2]),
		new Float3(left.X - right[1, 0], left.Y - right[1, 1], left.Z - right[1, 2]),
		new Float3(left.X - right[2, 0], left.Y - right[2, 1], left.Z - right[2, 2])
	);

	public static Float3x3 operator *(Float3 left, Float3x3 right) => new Float3x3(
		new Float3(left.X * right[0, 0], left.Y * right[0, 1], left.Z * right[0, 2]),
		new Float3(left.X * right[1, 0], left.Y * right[1, 1], left.Z * right[1, 2]),
		new Float3(left.X * right[2, 0], left.Y * right[2, 1], left.Z * right[2, 2])
	);

	public static Float3x3 operator /(Float3 left, Float3x3 right) => new Float3x3(
		new Float3(left.X / right[0, 0], left.Y / right[0, 1], left.Z / right[0, 2]),
		new Float3(left.X / right[1, 0], left.Y / right[1, 1], left.Z / right[1, 2]),
		new Float3(left.X / right[2, 0], left.Y / right[2, 1], left.Z / right[2, 2])
	);
}
