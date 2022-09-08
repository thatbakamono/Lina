namespace Lina;

public partial struct Float4
{
    public Float4 Zero => new Float4(0.0f, 0.0f, 0.0f, 0.0f);
    public Float4 One => new Float4(1.0f, 1.0f, 0.0f, 0.0f);

    public Float4 Up => new Float4(0.0f, 1.0f, 0.0f, 0.0f);
    public Float4 Down => new Float4(0.0f, -1.0f, 0.0f, 0.0f);
    public Float4 Left => new Float4(-1.0f, 0.0f, 0.0f, 0.0f);
    public Float4 Right => new Float4(1.0f, 0.0f, 0.0f, 0.0f);
    public Float4 Forward => new Float4(0.0f, 0.0f, 1.0f, 0.0f);
    public Float4 Backward => new Float4(0.0f, 0.0f, -1.0f, 0.0f);
	
	public float X { get; set; }
	public float Y { get; set; }
	public float Z { get; set; }
	public float W { get; set; }

    public float Length => (float) Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
    public float LengthSquared => X * X + Y * Y + Z * Z + W * W;

    public Float4 Normalized => new Float4(X / Length, Y / Length, Z / Length, W / Length);

	public Float4(float x, float y, float z, float w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public static implicit operator Float4(Float2 value) => new Float4(value.X, value.Y, 0.0f, 0.0f);
	public static implicit operator Float4(Float3 value) => new Float4(value.X, value.Y, value.Z, 0.0f);

	public static explicit operator Float4(Double2 value) => new Float4((float) value.X, (float) value.Y, 0.0f, 0.0f);
    public static explicit operator Float4(Double3 value) => new Float4((float) value.X, (float) value.Y, (float) value.Z, 0.0f);
    public static explicit operator Float4(Double4 value) => new Float4((float) value.X, (float) value.Y, (float) value.Z, (float) value.W);

    public static Float4 operator +(Float4 left, Float4 right) => new Float4(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
    public static Float4 operator -(Float4 left, Float4 right) => new Float4(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
    public static Float4 operator *(Float4 left, Float4 right) => new Float4(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
    public static Float4 operator /(Float4 left, Float4 right) => new Float4(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);

    public static Float4 operator +(Float4 left, float right) => new Float4(left.X + right, left.Y + right, left.Z + right, left.W + right);
    public static Float4 operator -(Float4 left, float right) => new Float4(left.X - right, left.Y - right, left.Z - right, left.W - right);
    public static Float4 operator *(Float4 left, float right) => new Float4(left.X * right, left.Y * right, left.Z * right, left.W * right);
    public static Float4 operator /(Float4 left, float right) => new Float4(left.X / right, left.Y / right, left.Z / right, left.W / right);

    public static Float4 operator +(float left, Float4 right) => new Float4(left + right.X, left + right.Y, left + right.Z, left + right.W);
    public static Float4 operator -(float left, Float4 right) => new Float4(left - right.X, left - right.Y, left - right.Z, left - right.W);
    public static Float4 operator *(float left, Float4 right) => new Float4(left * right.X, left * right.Y, left * right.Z, left * right.W);
    public static Float4 operator /(float left, Float4 right) => new Float4(left / right.X, left / right.Y, left / right.Z, left / right.W);

    public Float4 Normalize()
    {
        X /= Length;
        Y /= Length;
        Z /= Length;
        W /= Length;

        return this;
    }

    public float Dot(Float4 other) => X * other.X + Y * other.Y + Z * other.Z + W * other.W;
}
