namespace InterfacesExample.Tests;

public class CarRepositoryTests
{
    [Fact]
    public void InsertingNewModel_ShouldIncreaseRecordCount()
    {
        //Arrange
        CarModel model = new CarModel("rapid", "skoda");
        CarRepository carRepo = new CarRepository();
        int oldNumber = carRepo.RecordCount();

        //Act

        carRepo.Insert(model);
        int newNumber = carRepo.RecordCount();

        //Assert
        Assert.Equal(oldNumber+1, newNumber);
    }

    [Fact]
    public void InsertingNull_ShouldSustainRecordCount()
    {
        //Arrange
        CarRepository carRepo = new CarRepository();
        int oldNumber = carRepo.RecordCount();

        //Act
        carRepo.Insert(null);
        int newNumber = carRepo.RecordCount();
        //Assert

        Assert.NotEqual(oldNumber, newNumber);
    }

    [Fact]
    public void GettingAllRecords_WithTwoRecords_ShouldReturnListOfTwoRecords()
    {
        //Arrange
        CarRepository carRepo = new CarRepository();
        List<CarModel> carList = new List<CarModel>();
        carList.Add(new CarModel("fabia", "skoda"));
        carList.Add(new CarModel("octavia", "skoda"));
        
        carRepo.Insert(carList[0]);
        carRepo.Insert(carList[1]);
        
        //Act
        var retrievedCars = carRepo.Get();

        //Assert

        Assert.Equal(retrievedCars.Count, carList.Count);
        Assert.Equal(carList[0].Id, retrievedCars[0].Id);
    }

    [Fact]
    public void GettingInsertedRecordWithId_WithTwoRecords_ShouldReturnInsertedRecord()
    {
//Arrange
        CarRepository carRepo = new CarRepository();
        CarModel model1 = new CarModel("neco", "idk");
        CarModel model2 = new CarModel("ahoj", "ahoj");

        carRepo.Insert(model1);
        carRepo.Insert(model2);
        //Act
        var retrievedCar = carRepo.Get(model1.Id);

        //Assert
        Assert.NotNull(retrievedCar);
        Assert.Equal(model1.Id, retrievedCar.Id);
        
    }

    [Fact]
    public void GettingNotInsertedRecordWithId_WithTwoRecords_ShouldReturnNull()
    {
        
        //Arrange
        CarRepository carRepo = new CarRepository();
        CarModel wantedCar = new CarModel("car", "car");

        //Act
        carRepo.Insert(new CarModel("cau", "cau"));
        carRepo.Insert(new CarModel("idk", "idk"));
        
        //Assert
        Assert.Null(carRepo.Get(wantedCar.Id));
        
        
    }
}