namespace SolidLib_Good;

public interface IFruit 
{
    public string GetColor();
}

internal class Apple : IFruit{
	public string GetColor() {
		return "Red";
	}
}

internal class Orange : IFruit {
	public string GetColor() {
		return "Orange";
	}
}