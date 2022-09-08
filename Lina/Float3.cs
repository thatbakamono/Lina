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

	public Float3(float x, float y, float z)
	{
		X = x;
		Y = y;
		Z = z;
	}
}
