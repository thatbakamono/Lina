namespace Lina;

public partial struct Double2
{
    public Double2 Zero => new Double2(0.0, 0.0);
    public Double2 One => new Double2(1.0, 1.0);

    public Double2 Up => new Double2(0.0, 1.0);
    public Double2 Down => new Double2(0.0, -1.0);
    public Double2 Left => new Double2(-1.0, 0.0);
    public Double2 Right => new Double2(1.0, 0.0);

	public double X { get; set; }
    public double Y { get; set; }

    public double Length => Math.Sqrt(X * X + Y * Y);
    public double LengthSquared => X * X + Y * Y;

    public Double2 Normalized => new Double2(X / Length, Y / Length);

    public Double2(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double this[int index]
    {
        get => index switch {
            0 => X,
            1 => Y,
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
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }

    public static explicit operator Double2(Double3 value) => new Double2(value.X, value.Y);
    public static explicit operator Double2(Double4 value) => new Double2(value.X, value.Y);

    public static implicit operator Double2(Float2 value) => new Double2(value.X, value.Y);
    public static explicit operator Double2(Float3 value) => new Double2(value.X, value.Y);
    public static explicit operator Double2(Float4 value) => new Double2(value.X, value.Y);

    public static Double2 operator +(Double2 left, Double2 right) => new Double2(left.X + right.X, left.Y + right.Y);
    public static Double2 operator -(Double2 left, Double2 right) => new Double2(left.X - right.X, left.Y - right.Y);
    public static Double2 operator *(Double2 left, Double2 right) => new Double2(left.X * right.X, left.Y * right.Y);
    public static Double2 operator /(Double2 left, Double2 right) => new Double2(left.X / right.X, left.Y / right.Y);

    public static Double2 operator +(Double2 left, double right) => new Double2(left.X + right, left.Y + right);
    public static Double2 operator -(Double2 left, double right) => new Double2(left.X - right, left.Y - right);
    public static Double2 operator *(Double2 left, double right) => new Double2(left.X * right, left.Y * right);
    public static Double2 operator /(Double2 left, double right) => new Double2(left.X / right, left.Y / right);

    public static Double2 operator +(double left, Double2 right) => new Double2(left + right.X, left + right.Y);
    public static Double2 operator -(double left, Double2 right) => new Double2(left - right.X, left - right.Y);
    public static Double2 operator *(double left, Double2 right) => new Double2(left * right.X, left * right.Y);
    public static Double2 operator /(double left, Double2 right) => new Double2(left / right.X, left / right.Y);

    public Double2 Normalize()
    {
        X /= Length;
        Y /= Length;

        return this;
    }

    public double Dot(Double2 other) => X * other.X + Y * other.Y; 
}
