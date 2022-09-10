using System;

namespace Lina;

public struct Float4x4
{
	public Float4x4 Identity => new Float4x4(
		new Float4(1.0f, 0.0f, 0.0f, 0.0f),
		new Float4(0.0f, 1.0f, 0.0f, 0.0f),
		new Float4(0.0f, 0.0f, 1.0f, 0.0f),
		new Float4(0.0f, 0.0f, 0.0f, 1.0f)
	);

	public Float4 A
	{
		get => _a;
		set => _a = value;
	}

	public Float4 B
	{
		get => _b;
		set => _b = value;
	}

	public Float4 C
	{
		get => _c;
		set => _c = value;
	}

	public Float4 D
	{
		get => _d;
		set => _d = value;
	}

	private Float4 _a;
	private Float4 _b;
	private Float4 _c;
	private Float4 _d;

	public Float4x4(Float4 a, Float4 b, Float4 c, Float4 d)
	{
		_a = a;
		_b = b;
		_c = c;
		_d = d;
	}

	public float this[int column, int row]
	{
		get => column switch {
			0 => _a[row],
			1 => _b[row],
			2 => _c[row],
			3 => _d[row],
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
				case 3:
					_d[row] = value;

					break;
				default:
					throw new IndexOutOfRangeException();
			}
		}
	}

	public static Float4x4 operator +(Float4x4 left, Float4x4 right) => new Float4x4(
		new Float4(left[0, 0] + right[0, 0], left[0, 1] + right[0, 1], left[0, 2] + right[0, 2], left[0, 3] + right[0, 3]),
		new Float4(left[1, 0] + right[1, 0], left[1, 1] + right[1, 1], left[1, 2] + right[1, 2], left[1, 3] + right[1, 3]),
		new Float4(left[2, 0] + right[2, 0], left[2, 1] + right[2, 1], left[2, 2] + right[2, 2], left[2, 3] + right[2, 3]),
		new Float4(left[3, 0] + right[3, 0], left[3, 1] + right[3, 1], left[3, 2] + right[3, 2], left[3, 3] + right[3, 3])
	);

	public static Float4x4 operator -(Float4x4 left, Float4x4 right) => new Float4x4(
		new Float4(left[0, 0] - right[0, 0], left[0, 1] - right[0, 1], left[0, 2] - right[0, 2], left[0, 3] - right[0, 3]),
		new Float4(left[1, 0] - right[1, 0], left[1, 1] - right[1, 1], left[1, 2] - right[1, 2], left[1, 3] - right[1, 3]),
		new Float4(left[2, 0] - right[2, 0], left[2, 1] - right[2, 1], left[2, 2] - right[2, 2], left[2, 3] - right[2, 3]),
		new Float4(left[3, 0] - right[3, 0], left[3, 1] - right[3, 1], left[3, 2] - right[3, 2], left[3, 3] - right[3, 3])
	);

	public static Float4x4 operator *(Float4x4 left, Float4x4 right) => new Float4x4(
		new Float4(left[0, 0] * right[0, 0], left[0, 1] * right[0, 1], left[0, 2] * right[0, 2], left[0, 3] * right[0, 3]),
		new Float4(left[1, 0] * right[1, 0], left[1, 1] * right[1, 1], left[1, 2] * right[1, 2], left[1, 3] * right[1, 3]),
		new Float4(left[2, 0] * right[2, 0], left[2, 1] * right[2, 1], left[2, 2] * right[2, 2], left[2, 3] * right[2, 3]),
		new Float4(left[3, 0] * right[3, 0], left[3, 1] * right[3, 1], left[3, 2] * right[3, 2], left[3, 3] * right[3, 3])
	);

	public static Float4x4 operator /(Float4x4 left, Float4x4 right) => new Float4x4(
		new Float4(left[0, 0] / right[0, 0], left[0, 1] / right[0, 1], left[0, 2] / right[0, 2], left[0, 3] / right[0, 3]),
		new Float4(left[1, 0] / right[1, 0], left[1, 1] / right[1, 1], left[1, 2] / right[1, 2], left[1, 3] / right[1, 3]),
		new Float4(left[2, 0] / right[2, 0], left[2, 1] / right[2, 1], left[2, 2] / right[2, 2], left[2, 3] / right[2, 3]),
		new Float4(left[3, 0] / right[3, 0], left[3, 1] / right[3, 1], left[3, 2] / right[3, 2], left[3, 3] / right[3, 3])
	);

	public static Float4x4 operator +(Float4x4 left, float right) => new Float4x4(
		new Float4(left[0, 0] + right, left[0, 1] + right, left[0, 2] + right, left[0, 3] + right),
		new Float4(left[1, 0] + right, left[1, 1] + right, left[1, 2] + right, left[1, 3] + right),
		new Float4(left[2, 0] + right, left[2, 1] + right, left[2, 2] + right, left[2, 3] + right),
		new Float4(left[3, 0] + right, left[3, 1] + right, left[3, 2] + right, left[3, 3] + right)
	);

	public static Float4x4 operator -(Float4x4 left, float right) => new Float4x4(
		new Float4(left[0, 0] - right, left[0, 1] - right, left[0, 2] - right, left[0, 3] - right),
		new Float4(left[1, 0] - right, left[1, 1] - right, left[1, 2] - right, left[1, 3] - right),
		new Float4(left[2, 0] - right, left[2, 1] - right, left[2, 2] - right, left[2, 3] - right),
		new Float4(left[3, 0] - right, left[3, 1] - right, left[3, 2] - right, left[3, 3] - right)
	);

	public static Float4x4 operator *(Float4x4 left, float right) => new Float4x4(
		new Float4(left[0, 0] * right, left[0, 1] * right, left[0, 2] * right, left[0, 3] * right),
		new Float4(left[1, 0] * right, left[1, 1] * right, left[1, 2] * right, left[1, 3] * right),
		new Float4(left[2, 0] * right, left[2, 1] * right, left[2, 2] * right, left[2, 3] * right),
		new Float4(left[3, 0] * right, left[3, 1] * right, left[3, 2] * right, left[3, 3] * right)
	);

	public static Float4x4 operator /(Float4x4 left, float right) => new Float4x4(
		new Float4(left[0, 0] / right, left[0, 1] / right, left[0, 2] / right, left[0, 3] / right),
		new Float4(left[1, 0] / right, left[1, 1] / right, left[1, 2] / right, left[1, 3] / right),
		new Float4(left[2, 0] / right, left[2, 1] / right, left[2, 2] / right, left[2, 3] / right),
		new Float4(left[3, 0] / right, left[3, 1] / right, left[3, 2] / right, left[3, 3] / right)
	);

	public static Float4x4 operator +(float left, Float4x4 right) => new Float4x4(
		new Float4(left + right[0, 0], left + right[0, 1], left + right[0, 2], left + right[0, 3]),
		new Float4(left + right[1, 0], left + right[1, 1], left + right[1, 2], left + right[1, 3]),
		new Float4(left + right[2, 0], left + right[2, 1], left + right[2, 2], left + right[2, 3]),
		new Float4(left + right[3, 0], left + right[3, 1], left + right[3, 2], left + right[3, 3])
	);

	public static Float4x4 operator -(float left, Float4x4 right) => new Float4x4(
		new Float4(left - right[0, 0], left - right[0, 1], left - right[0, 2], left - right[0, 3]),
		new Float4(left - right[1, 0], left - right[1, 1], left - right[1, 2], left - right[1, 3]),
		new Float4(left - right[2, 0], left - right[2, 1], left - right[2, 2], left - right[2, 3]),
		new Float4(left - right[3, 0], left - right[3, 1], left - right[3, 2], left - right[3, 3])
	);

	public static Float4x4 operator *(float left, Float4x4 right) => new Float4x4(
		new Float4(left * right[0, 0], left * right[0, 1], left * right[0, 2], left * right[0, 3]),
		new Float4(left * right[1, 0], left * right[1, 1], left * right[1, 2], left * right[1, 3]),
		new Float4(left * right[2, 0], left * right[2, 1], left * right[2, 2], left * right[2, 3]),
		new Float4(left * right[3, 0], left * right[3, 1], left * right[3, 2], left * right[3, 3])
	);

	public static Float4x4 operator /(float left, Float4x4 right) => new Float4x4(
		new Float4(left / right[0, 0], left / right[0, 1], left / right[0, 2], left / right[0, 3]),
		new Float4(left / right[1, 0], left / right[1, 1], left / right[1, 2], left / right[1, 3]),
		new Float4(left / right[2, 0], left / right[2, 1], left / right[2, 2], left / right[2, 3]),
		new Float4(left / right[3, 0], left / right[3, 1], left / right[3, 2], left / right[3, 3])
	);

	public static Float4x4 operator +(Float4x4 left, Float4 right) => new Float4x4(
		new Float4(left[0, 0] + right.X, left[0, 1] + right.Y, left[0, 2] + right.Z, left[0, 3] + right.W),
		new Float4(left[1, 0] + right.X, left[1, 1] + right.Y, left[1, 2] + right.Z, left[1, 3] + right.W),
		new Float4(left[2, 0] + right.X, left[2, 1] + right.Y, left[2, 2] + right.Z, left[2, 3] + right.W),
		new Float4(left[3, 0] + right.X, left[3, 1] + right.Y, left[3, 2] + right.Z, left[3, 3] + right.W)
	);

	public static Float4x4 operator -(Float4x4 left, Float4 right) => new Float4x4(
		new Float4(left[0, 0] - right.X, left[0, 1] - right.Y, left[0, 2] - right.Z, left[0, 3] - right.W),
		new Float4(left[1, 0] - right.X, left[1, 1] - right.Y, left[1, 2] - right.Z, left[1, 3] - right.W),
		new Float4(left[2, 0] - right.X, left[2, 1] - right.Y, left[2, 2] - right.Z, left[2, 3] - right.W),
		new Float4(left[3, 0] - right.X, left[3, 1] - right.Y, left[3, 2] - right.Z, left[3, 3] - right.W)
	);

	public static Float4x4 operator *(Float4x4 left, Float4 right) => new Float4x4(
		new Float4(left[0, 0] * right.X, left[0, 1] * right.Y, left[0, 2] * right.Z, left[0, 3] * right.W),
		new Float4(left[1, 0] * right.X, left[1, 1] * right.Y, left[1, 2] * right.Z, left[1, 3] * right.W),
		new Float4(left[2, 0] * right.X, left[2, 1] * right.Y, left[2, 2] * right.Z, left[2, 3] * right.W),
		new Float4(left[3, 0] * right.X, left[3, 1] * right.Y, left[3, 2] * right.Z, left[3, 3] * right.W)
	);

	public static Float4x4 operator /(Float4x4 left, Float4 right) => new Float4x4(
		new Float4(left[0, 0] / right.X, left[0, 1] / right.Y, left[0, 2] / right.Z, left[0, 3] / right.W),
		new Float4(left[1, 0] / right.X, left[1, 1] / right.Y, left[1, 2] / right.Z, left[1, 3] / right.W),
		new Float4(left[2, 0] / right.X, left[2, 1] / right.Y, left[2, 2] / right.Z, left[2, 3] / right.W),
		new Float4(left[3, 0] / right.X, left[3, 1] / right.Y, left[3, 2] / right.Z, left[3, 3] / right.W)
	);

	public static Float4x4 operator +(Float4 left, Float4x4 right) => new Float4x4(
		new Float4(left.X + right[0, 0], left.Y + right[0, 1], left.Z + right[0, 2], left.W + right[0, 3]),
		new Float4(left.X + right[1, 0], left.Y + right[1, 1], left.Z + right[1, 2], left.W + right[1, 3]),
		new Float4(left.X + right[2, 0], left.Y + right[2, 1], left.Z + right[2, 2], left.W + right[2, 3]),
		new Float4(left.X + right[3, 0], left.Y + right[3, 1], left.Z + right[3, 2], left.W + right[3, 3])
	);

	public static Float4x4 operator -(Float4 left, Float4x4 right) => new Float4x4(
		new Float4(left.X - right[0, 0], left.Y - right[0, 1], left.Z - right[0, 2], left.W - right[0, 3]),
		new Float4(left.X - right[1, 0], left.Y - right[1, 1], left.Z - right[1, 2], left.W - right[1, 3]),
		new Float4(left.X - right[2, 0], left.Y - right[2, 1], left.Z - right[2, 2], left.W - right[2, 3]),
		new Float4(left.X - right[3, 0], left.Y - right[3, 1], left.Z - right[3, 2], left.W - right[3, 3])
	);

	public static Float4x4 operator *(Float4 left, Float4x4 right) => new Float4x4(
		new Float4(left.X * right[0, 0], left.Y * right[0, 1], left.Z * right[0, 2], left.W * right[0, 3]),
		new Float4(left.X * right[1, 0], left.Y * right[1, 1], left.Z * right[1, 2], left.W * right[1, 3]),
		new Float4(left.X * right[2, 0], left.Y * right[2, 1], left.Z * right[2, 2], left.W * right[2, 3]),
		new Float4(left.X * right[3, 0], left.Y * right[3, 1], left.Z * right[3, 2], left.W * right[3, 3])
	);

	public static Float4x4 operator /(Float4 left, Float4x4 right) => new Float4x4(
		new Float4(left.X / right[0, 0], left.Y / right[0, 1], left.Z / right[0, 2], left.W / right[0, 3]),
		new Float4(left.X / right[1, 0], left.Y / right[1, 1], left.Z / right[1, 2], left.W / right[1, 3]),
		new Float4(left.X / right[2, 0], left.Y / right[2, 1], left.Z / right[2, 2], left.W / right[2, 3]),
		new Float4(left.X / right[3, 0], left.Y / right[3, 1], left.Z / right[3, 2], left.W / right[3, 3])
	);
}
