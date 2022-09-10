namespace Lina;

public partial struct Float2
{
    public Float2 Zero => new Float2(0.0f, 0.0f);
    public Float2 One => new Float2(1.0f, 1.0f);

    public Float2 Up => new Float2(0.0f, 1.0f);
    public Float2 Down => new Float2(0.0f, -1.0f);
    public Float2 Left => new Float2(-1.0f, 0.0f);
    public Float2 Right => new Float2(1.0f, 0.0f);

    public float X { get; set; }
    public float Y { get; set; }

    public float Length => (float) Math.Sqrt(X * X + Y * Y);
    public float LengthSquared => X * X + Y * Y;

    public Float2 Normalized => new Float2(X / Length, Y / Length);

    public Float2(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float this[int index]
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

    public static explicit operator Float2(Float3 value) => new Float2(value.X, value.Y);
    public static explicit operator Float2(Float4 value) => new Float2(value.X, value.Y);

    public static explicit operator Float2(Double2 value) => new Float2((float) value.X, (float) value.Y);
    public static explicit operator Float2(Double3 value) => new Float2((float) value.X, (float) value.Y);
    public static explicit operator Float2(Double4 value) => new Float2((float) value.X, (float) value.Y);

    public static Float2 operator +(Float2 left, Float2 right) => new Float2(left.X + right.X, left.Y + right.Y);
    public static Float2 operator -(Float2 left, Float2 right) => new Float2(left.X - right.X, left.Y - right.Y);
    public static Float2 operator *(Float2 left, Float2 right) => new Float2(left.X * right.X, left.Y * right.Y);
    public static Float2 operator /(Float2 left, Float2 right) => new Float2(left.X / right.X, left.Y / right.Y);

    public static Float2 operator +(Float2 left, float right) => new Float2(left.X + right, left.Y + right);
    public static Float2 operator -(Float2 left, float right) => new Float2(left.X - right, left.Y - right);
    public static Float2 operator *(Float2 left, float right) => new Float2(left.X * right, left.Y * right);
    public static Float2 operator /(Float2 left, float right) => new Float2(left.X / right, left.Y / right);

    public static Float2 operator +(float left, Float2 right) => new Float2(left + right.X, left + right.Y);
    public static Float2 operator -(float left, Float2 right) => new Float2(left - right.X, left - right.Y);
    public static Float2 operator *(float left, Float2 right) => new Float2(left * right.X, left * right.Y);
    public static Float2 operator /(float left, Float2 right) => new Float2(left / right.X, left / right.Y);

    public Float2 Normalize()
    {
        X /= Length;
        Y /= Length;

        return this;
    }

    public float Dot(Float2 other) => X * other.X + Y * other.Y;
}
