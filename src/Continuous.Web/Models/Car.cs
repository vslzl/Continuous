namespace Continuous.Web.Models;

public class Car
{
    public byte Speed { get; private set; } = 0;

    public void Accelerate(byte speed)
    {
        Speed += speed;
    }
}