using REST_API_vet.Models;

namespace REST_API_vet.Database;

public class MockDB
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();
    
    private static MockDB instance;

    public MockDB()
    {
        Animals.Add(new Animal("Jas", "cat", 7.3, "drab"));
        Animals.Add(new Animal("FiloDendron", "cat", 2.3, "pitch-black"));
        Animals.Add(new Animal("Felicia", "cat", 1.9, "cosmic-grey"));
        Animals.Add(new Animal("Edmund", "dog", 24.7, "brown"));
        
        Visits.Add(new Visit(new DateTime(2024,4,11), "RTG kregoslupa", 120, 0));
        Visits.Add(new Visit(new DateTime(2024,4,7), "Eutanazja", 666, 2));
        Visits.Add(new Visit(new DateTime(2024,3,27), "Kastracja", 240, 1));
        Visits.Add(new Visit(new DateTime(2024,3,22), "Zmniejszenie zaladka", 1000, 3));
        Visits.Add(new Visit(new DateTime(2024,4,12), "Eutanazja", 666, 0));
        Visits.Add(new Visit(new DateTime(2024,4,11), "RTG kregoslupa", 120, 0));
    }
    public static MockDB getInstance()
    {
        if (instance == null)
            instance = new MockDB();
        return instance;
    }
}