namespace Lina;

public partial struct Double3
{
    public Double3 Zero => new Double3(0.0, 0.0, 0.0);
    public Double3 One => new Double3(1.0, 1.0, 0.0);

    public Double3 Up => new Double3(0.0, 1.0, 0.0);
    public Double3 Down => new Double3(0.0, -1.0, 0.0);
    public Double3 Left => new Double3(-1.0, 0.0, 0.0);
    public Double3 Right => new Double3(1.0, 0.0, 0.0);
    public Double3 Forward => new Double3(0.0, 0.0, 1.0);
    public Double3 Backward => new Double3(0.0, 0.0, -1.0);

	public double X { get; set; }
	public double Y { get; set; }
	public double Z { get; set; }

    public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);
    public double LengthSquared => X * X + Y * Y + Z * Z;

    public Double3 Normalized => new Double3(X / Length, Y / Length, Z / Length);

	public Double3(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
	}

    public double this[int index]
    {
        get => index switch {
            0 => X,
            1 => Y,
            2 => Z,
            _ => throw new IndexOutOfRangeException(),
        };
        set
        {
            switch (index)
            {
                case 0:
                    X = value;

                    break;

                case 1:
                    Y = value;

                    break;
                case 2:
                    Z = value;

                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }

	public static implicit operator Double3(Double2 value) => new Double3(value.X, value.Y, 0.0);
	public static explicit operator Double3(Double4 value) => new Double3(value.X, value.Y, value.Z);

	public static implicit operator Double3(Float2 value) => new Double3(value.X, value.Y, 0.0);
    public static implicit operator Double3(Float3 value) => new Double3(value.X, value.Y, value.Z);
    public static explicit operator Double3(Float4 value) => new Double3(value.X, value.Y, value.Z);

    public static Double3 operator +(Double3 left, Double3 right) => new Double3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
    public static Double3 operator -(Double3 left, Double3 right) => new Double3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
    public static Double3 operator *(Double3 left, Double3 right) => new Double3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
    public static Double3 operator /(Double3 left, Double3 right) => new Double3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);

    public static Double3 operator +(Double3 left, double right) => new Double3(left.X + right, left.Y + right, left.Z + right);
    public static Double3 operator -(Double3 left, double right) => new Double3(left.X - right, left.Y - right, left.Z - right);
    public static Double3 operator *(Double3 left, double right) => new Double3(left.X * right, left.Y * right, left.Z * right);
    public static Double3 operator /(Double3 left, double right) => new Double3(left.X / right, left.Y / right, left.Z / right);

    public static Double3 operator +(double left, Double3 right) => new Double3(left + right.X, left + right.Y, left + right.Z);
    public static Double3 operator -(double left, Double3 right) => new Double3(left - right.X, left - right.Y, left - right.Z);
    public static Double3 operator *(double left, Double3 right) => new Double3(left * right.X, left * right.Y, left * right.Z);
    public static Double3 operator /(double left, Double3 right) => new Double3(left / right.X, left / right.Y, left / right.Z);

    public Double3 Normalize()
    {
        X /= Length;
        Y /= Length;
        Z /= Length;

        return this;
    }

    public double Dot(Double3 other) => X * other.X + Y * other.Y + Z * other.Z;

    public Double3 Cross(Double3 other) => new Double3(
        Y * other.Z - Z * other.Y,
        Z * other.X - X * other.Z,
        X * other.Y - Y * other.X
    );
}
