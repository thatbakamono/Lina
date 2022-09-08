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
}
