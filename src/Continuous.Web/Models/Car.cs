namespace Continuous.Web.Models;

public class Car
{
    public byte Speed { get; private set; }

    public void Accelerate(byte speed)
    {
        Speed += speed;
    }
}
