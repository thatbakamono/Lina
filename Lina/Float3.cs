namespace Lina;

public partial struct Float3
{
    public Float3 Zero => new Float3(0.0f, 0.0f, 0.0f);
    public Float3 One => new Float3(1.0f, 1.0f, 0.0f);

    public Float3 Up => new Float3(0.0f, 1.0f, 0.0f);
    public Float3 Down => new Float3(0.0f, -1.0f, 0.0f);
    public Float3 Left => new Float3(-1.0f, 0.0f, 0.0f);
    public Float3 Right => new Float3(1.0f, 0.0f, 0.0f);
    public Float3 Forward => new Float3(0.0f, 0.0f, 1.0f);
    public Float3 Backward => new Float3(0.0f, 0.0f, -1.0f);
	
	public float X { get; set; }
	public float Y { get; set; }
	public float Z { get; set; }

    public float Length => (float) Math.Sqrt(X * X + Y * Y + Z * Z);
    public float LengthSquared => X * X + Y * Y + Z * Z;

    public Float3 Normalized => new Float3(X / Length, Y / Length, Z / Length);

	public Float3(float x, float y, float z)
	{
		X = x;
		Y = y;
		Z = z;
	}

    public float this[int index]
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

	public static implicit operator Float3(Float2 value) => new Float3(value.X, value.Y, 0.0f);
	public static explicit operator Float3(Float4 value) => new Float3(value.X, value.Y, value.Z);

    public static explicit operator Float3(Double2 value) => new Float3((float) value.X, (float) value.Y, 0.0f);
    public static explicit operator Float3(Double3 value) => new Float3((float) value.X, (float) value.Y, (float) value.Z);
    public static explicit operator Float3(Double4 value) => new Float3((float) value.X, (float) value.Y, (float) value.Z);

    public static Float3 operator +(Float3 left, Float3 right) => new Float3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
    public static Float3 operator -(Float3 left, Float3 right) => new Float3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
    public static Float3 operator *(Float3 left, Float3 right) => new Float3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
    public static Float3 operator /(Float3 left, Float3 right) => new Float3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);

    public static Float3 operator +(Float3 left, float right) => new Float3(left.X + right, left.Y + right, left.Z + right);
    public static Float3 operator -(Float3 left, float right) => new Float3(left.X - right, left.Y - right, left.Z - right);
    public static Float3 operator *(Float3 left, float right) => new Float3(left.X * right, left.Y * right, left.Z * right);
    public static Float3 operator /(Float3 left, float right) => new Float3(left.X / right, left.Y / right, left.Z / right);

    public static Float3 operator +(float left, Float3 right) => new Float3(left + right.X, left + right.Y, left + right.Z);
    public static Float3 operator -(float left, Float3 right) => new Float3(left - right.X, left - right.Y, left - right.Z);
    public static Float3 operator *(float left, Float3 right) => new Float3(left * right.X, left * right.Y, left * right.Z);
    public static Float3 operator /(float left, Float3 right) => new Float3(left / right.X, left / right.Y, left / right.Z);

    public Float3 Normalize()
    {
        X /= Length;
        Y /= Length;
        Z /= Length;

        return this;
    }

    public float Dot(Float3 other) => X * other.X + Y * other.Y + Z * other.Z;

    public Float3 Cross(Float3 other) => new Float3(
        Y * other.Z - Z * other.Y,
        Z * other.X - X * other.Z,
        X * other.Y - Y * other.X
    );
}
