namespace TPN2_GonzalezSmithTomas.Models;

public enum CarCategory{
    SUV,
    Hatchback,
    Sedan,
    Van,
    Truck
}

public class Car{
    public int Id { get; set; }
    public string Plate { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public CarCategory Category { get; set; }
}
