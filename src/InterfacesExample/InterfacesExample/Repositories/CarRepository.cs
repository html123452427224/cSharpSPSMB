namespace InterfacesExample;

public class CarRepository : IRespository<CarModel>
{
    public CarModel? Get(Guid Id)
    {
        return cars.Find(car => car.Id == Id);
    }

    public List<CarModel> Get()
    {
        return cars;
    }

    List<CarModel> cars = new List<CarModel>();

    public void Insert(CarModel model)
    {
            cars.Add(model);
            
    }

    public void Update(CarModel model)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid Id)
    {
        throw new NotImplementedException();
    }

    public int RecordCount()
    {
        int count = cars.Count;

        foreach (var carModel in cars)
        {
            if (cars == null) count--;
        }
        return count;
        
    }
}
   