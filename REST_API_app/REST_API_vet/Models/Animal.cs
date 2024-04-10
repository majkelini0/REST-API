namespace REST_API_vet.Models;

public class Animal : Shelter
{
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public double weight { get; set; }
    public string color { get; set; }

    public static List<Animal> listOfAnimals = new ()
    {
        new Animal(1, "Pimpek", "dog", 38.9, "brown"),
        new Animal(2, "Filowstret", "cat", 3.3, "pitch black"),
        new Animal(3, "Jas", "cat", 7.3, "tabby"),
        new Animal(4, "Maja", "bee", 0.005, "yellow")
    };

    //public static List<Animal> ListOfAnimals { get; set; }

    public Animal(int id, string name, string category, double weight, string color)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.weight = weight;
        this.color = color;
        listOfAnimals = new List<Animal>();
        addAnimals();
    }

    private void addAnimals()
    {
        listOfAnimals.Add(new (11, "Pimpek", "dog", 38.9, "brown"));
        listOfAnimals.Add(new (22,"Filowstret", "cat", 3.3, "pitch black"));
    }
}