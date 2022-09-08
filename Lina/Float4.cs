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

	public Float4(float x, float y, float z, float w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}
}
