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

    public Double2(double x, double y)
    {
        X = x;
        Y = y;
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
}
