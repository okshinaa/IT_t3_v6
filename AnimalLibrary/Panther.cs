namespace AnimalLibrary;

public class Panther : Animal
{
    private double Speed { get; set; }

    public Panther(double speed)
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
        Speed = GetSpeed() + 30;

        return ToString();
    }

    public override string Stand()
    {
        Speed = GetSpeed() - 20;
        
        return GetSpeed() <= 20 ? "Пантера не может двигаться еще медленне, иначе это будет собака" : ToString();
    }

    public string MakeVoice()
    {
        return "Пантера говорит 'Рррр'";
    }
    
    public override string ToString()
    {
        return $"Скорость пантеры - {Speed}.";
    }
}