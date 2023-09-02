namespace LibObjects;

public interface IShape 
{
    int size {get; set;}

    double getArea();
    double getPerimeter();
}

public class Shape : IShape
{
    public int size {get; set;}

    public double getArea()
    {
        return 0;
    }

    public double getPerimeter()
    {
        return 0;
    }
}

public class Circle : Shape 
{
    public Circle() {}

    new public double getArea()
    {
        return 1000;
    }
}