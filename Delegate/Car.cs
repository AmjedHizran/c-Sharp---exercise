using Delegate;
using System;

class Car
{
    public event SpeedDelegate SpeedChanged;

    private int speed;

    public int Speed
    {
        get { return speed; }
    }

    public void AddSpeed(int delta)
    {
        speed += delta;
    
        SpeedChanged?.Invoke(speed);
    }
}