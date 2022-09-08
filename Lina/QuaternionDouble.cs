namespace Lina;

public struct QuaternionDouble
{
	public QuaternionDouble Identity => new QuaternionDouble(1.0, 0.0, 0.0, 0.0);

	public double A { get; set; }
	public double B { get; set; }
	public double C { get; set; }
	public double D { get; set; }

	public QuaternionDouble(double a, double b, double c, double d)
	{
		A = a;
		B = b;
		C = c;
		D = d;
	}
}
