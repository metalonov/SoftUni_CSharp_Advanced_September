using System.Collections.Generic;

namespace SoftUniParking;

public class Parking
{
    private Dictionary<string, Car> _cars;
    private int _capacity;

    public Parking(int capacity)
    {
        Capacity = capacity;
        Cars = new Dictionary<string, Car>();
    }

    public Dictionary<string, Car> Cars 
    { 
        get => _cars; 
        set => _cars = value; 
    }
    public int Capacity 
    {
        get 
        {
            return _capacity;
        } 
        init => _capacity = value; 
    }

    public int Count
    {
        get { return _cars.Count; }
    }

    public string AddCar(Car car)
    {
        if (_cars.ContainsKey(car.RegistrationNumber))
        {
            return "Car with that registration number, already exists!";
        }
        if (Count >= _capacity)
        {
            return "Parking is full!";
        }
        _cars.Add(car.RegistrationNumber, car);
        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }
    public Car GetCar(string regNum)
    {
        return _cars[regNum];
    }

    public string RemoveCar(string regNum)
    {
        if (!_cars.ContainsKey(regNum))
        {
            return "Car with that registration number, doesn't exist!";
        }
        else
        {
        _cars.Remove(regNum);
        return $"Successfullyremoved {regNum}";
        }
    }

    public void RemoveSetOfRegistrationNumber(List<string> regNumbers)
    {
        foreach (var item in regNumbers)
        {
            RemoveCar(item);
        }
    }
}
