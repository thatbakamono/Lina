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

    public Float2(float x, float y)
    {
        X = x;
        Y = y;
    }

    public static explicit operator Float2(Float3 value) => new Float2(value.X, value.Y);
    public static explicit operator Float2(Float4 value) => new Float2(value.X, value.Y);
}
