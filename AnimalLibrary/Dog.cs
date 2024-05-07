namespace AnimalLibrary;

public class Dog : Animal
{
    private double Speed { get; set; }

    public Dog(double speed)
    {
        if (speed < 0)
        {
            throw new ArgumentException("Скорость не может быть отрицательной");
        }

        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override string Move()
    {
        Speed = GetSpeed() + 10;

        return ToString();
    }

    public override string Stand()
    {
        Speed = GetSpeed() - 10;
        
        return GetSpeed() <= 10 ? "Собака не может двигаться еще медленне, иначе это будет черепаха" : ToString();
    }

    public string MakeVoice()
    {
        return "Собака говорит 'Гав'";
    }
    
    public override string ToString()
    {
        return $"Скорость собаки - {Speed}.";
    }
}