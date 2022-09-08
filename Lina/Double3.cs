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

	public Double3(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public static implicit operator Double3(Double2 value) => new Double3(value.X, value.Y, 0.0);
	public static explicit operator Double3(Double4 value) => new Double3(value.X, value.Y, value.Z);
}
