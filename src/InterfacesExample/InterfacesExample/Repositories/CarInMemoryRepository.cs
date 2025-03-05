namespace InterfacesExample;

public class CarInMemoryRepository : ICarRepository
{
    public CarModel? Get(Guid Id)
    {
    }

    public List<CarModel> Get()
    {
    }

    public void Insert(CarModel model)
    {
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
        }
    }