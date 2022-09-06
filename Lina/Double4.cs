namespace Lina;

public partial struct Double4
{
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
}
