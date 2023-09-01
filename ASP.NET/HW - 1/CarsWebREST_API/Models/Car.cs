namespace WebApplication1.Models;
public class Car
{
    public Car(int id,string name,string make)
    {
        Id = id;
        Name = name;
        Make = make;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
}