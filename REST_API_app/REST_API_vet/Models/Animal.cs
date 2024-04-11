namespace REST_API_vet.Models;

public class Animal
{
    public int id { get; }
    public string name { get; set; }
    public string category { get; set; }
    public double weight { get; set; }
    public string color { get; set; }
    private static int idCounter = 0;

    public Animal(string name, string category, double weight, string color)
    {
        this.id = idCounter++;
        this.name = name;
        this.category = category;
        this.weight = weight;
        this.color = color;
    }
}