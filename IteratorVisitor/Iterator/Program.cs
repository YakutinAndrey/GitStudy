using System;
using Iterator;

class Program
{
    static void Main(string[] args)
    {
        Garage garage = new Garage();
        Watcher watcher = new Watcher();
        watcher.SeeCars(garage);

        Console.Read();
    }
}

class Watcher
{
    Visitor visitor = new ConcreteVisitor1();
    public void SeeCars(Garage garage)
    {
        ICarIterator iterator = garage.CreateNumerator();
        while (iterator.HasNext())
        {
            Car car = iterator.Next();
            car.Accept(visitor); 
            Console.WriteLine(car.Name);
        }
    }
}

interface ICarIterator
{
    bool HasNext();
    Car Next();
}
interface ICarNumerable
{
    ICarIterator CreateNumerator();
    int Count { get; }
    Car this[int index] { get; }
}
abstract class Car: IElement
{
    public string Name { get; set; }

    public abstract void Accept(Visitor visitor);
    
}

class Garage : ICarNumerable
{
    private Car[] cars;
    public Garage()
    {
        cars = new Car[]
        {
            new BMW{Name="БМВ"},
            new Mersedec {Name="Мерседес"},
            new Toyota {Name="Тойота"}
        };
    }
    public int Count
    {
        get { return cars.Length; }
    }

    public Car this[int index]
    {
        get { return cars[index]; }
    }
    public ICarIterator CreateNumerator()
    {
        return new CarNumerator(this);
    }
}
class CarNumerator : ICarIterator
{
    ICarNumerable aggregate;
    int index = 0;
    public CarNumerator(ICarNumerable a)
    {
        aggregate = a;
    }
    public bool HasNext()
    {
        return index < aggregate.Count;
    }

    public Car Next()
    {
        return aggregate[index++];
    }
}