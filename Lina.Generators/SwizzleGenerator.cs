using Microsoft.CodeAnalysis;

namespace Lina.Generators;

[Generator]
public class SwizzleGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context) { }

	public void Execute(GeneratorExecutionContext context)
	{
		foreach (var floatingPointType in new string[] { "Float", "Double" })
		{
			foreach (var dimensions in new int[] { 2, 3, 4 })
			{
				context.AddSource($"{floatingPointType}{dimensions}.Swizzles.g.cs", GenerateSwizzles(floatingPointType, dimensions));
			}
		}
	}

	private string GenerateSwizzles(string floatingPointType, int dimensions)
	{
		List<char[]> permutations = GenerateAllPossiblePermutationsOfNAxes(dimensions);
		List<string> lines = new List<string>();

		lines.Add("namespace Lina;");
		lines.Add($"public partial struct {floatingPointType}{dimensions}");
		lines.Add("{");

		foreach (var permutation in permutations)
		{
			string vectorType = permutation.Length switch
			{
				2 => $"{floatingPointType}2",
				3 => $"{floatingPointType}3",
				4 => $"{floatingPointType}4",
				_ => throw new InvalidOperationException(),
			};
			
			lines.Add($"public {vectorType} {string.Join("", permutation)}");
			lines.Add("{");

			lines.Add($"get => new {vectorType}({string.Join(", ", permutation)});");

			lines.Add("set");
			lines.Add("{");

			if (permutation.Length >= 2)
			{
				lines.Add($"{permutation[0]} = value.X;");
				lines.Add($"{permutation[1]} = value.Y;");
			}

			if (permutation.Length >= 3)
			{
				lines.Add($"{permutation[2]} = value.Z;");
			}
			
			if (permutation.Length >= 4)
			{
				lines.Add($"{permutation[3]} = value.W;");
			}

			lines.Add("}");

			lines.Add("}");
		}

		lines.Add("}");

		return string.Join(Environment.NewLine, lines);
	}

	private List<char[]> GenerateAllPossiblePermutationsOfNAxes(int n)
	{
		if (n < 2 || n > 4)
			throw new ArgumentException("n must be equal to 2, 3 or 4");

		List<char[]> permutations = new List<char[]>();

		char[] axes = n switch
		{
			2 => new char[] { 'X', 'Y' },
			3 => new char[] { 'X', 'Y', 'Z' },
			4 => new char[] { 'X', 'Y', 'Z', 'W' },
			_ => throw new InvalidOperationException(),
		};

		if (n >= 2)
		{
			foreach (var x in axes)
			{
				foreach (var y in axes)
				{
					permutations.Add(new char[] { x, y, });
				}
			}
		}

		if (n >= 3)
		{
			foreach (var x in axes)
			{
				foreach (var y in axes)
				{
					foreach (var z in axes)
					{
						permutations.Add(new char[] { x, y, z });
					}
				}
			}
		}

		if (n >= 4)
		{
			foreach (var x in axes)
			{
				foreach (var y in axes)
				{
					foreach (var z in axes)
					{
						foreach (var w in axes)
						{
							permutations.Add(new char[] { x, y, z, w });
						}
					}
				}
			}
		}

		return permutations;
	}
}
