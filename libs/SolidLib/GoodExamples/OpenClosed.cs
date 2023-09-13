namespace SolidLib_Good;

public interface IShape {
	double CalculateArea();
}

public class Rectangle : IShape {
	public double Width { get; set; }
	public double Height { get; set; }

	public double CalculateArea()
	{
		return Width * Height;
	}
}

public class Circle : IShape {
	public double Radius { get; set; }

	public double CalculateArea()
	{
		return Math.PI * Math.Pow(Radius, 2);
	}
}
