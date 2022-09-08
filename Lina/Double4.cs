namespace Lina;

public partial struct Double4
{
    public Double4 Zero => new Double4(0.0, 0.0, 0.0, 0.0);
    public Double4 One => new Double4(1.0, 1.0, 0.0, 0.0);

    public Double4 Up => new Double4(0.0, 1.0, 0.0, 0.0);
    public Double4 Down => new Double4(0.0, -1.0, 0.0, 0.0);
    public Double4 Left => new Double4(-1.0, 0.0, 0.0, 0.0);
    public Double4 Right => new Double4(1.0, 0.0, 0.0, 0.0);
    public Double4 Forward => new Double4(0.0, 0.0, 1.0, 0.0);
    public Double4 Backward => new Double4(0.0, 0.0, -1.0, 0.0);

	public double X { get; set; }
	public double Y { get; set; }
	public double Z { get; set; }
	public double W { get; set; }

	public Double4(double x, double y, double z, double w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public static implicit operator Double4(Double2 value) => new Double4(value.X, value.Y, 0.0, 0.0);
	public static implicit operator Double4(Double3 value) => new Double4(value.X, value.Y, value.Z, 0.0);

	public static implicit operator Double4(Float2 value) => new Double4(value.X, value.Y, 0.0, 0.0);
    public static implicit operator Double4(Float3 value) => new Double4(value.X, value.Y, value.Z, 0.0);
    public static implicit operator Double4(Float4 value) => new Double4(value.X, value.Y, value.Z, value.W);
}
