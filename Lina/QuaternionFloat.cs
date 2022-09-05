namespace Lina;

public struct QuaternionFloat
{
	public float A { get; set; }
	public float B { get; set; }
	public float C { get; set; }
	public float D { get; set; }

	public QuaternionFloat(float a, float b, float c, float d)
	{
		A = a;
		B = b;
		C = c;
		D = d;
	}
}
