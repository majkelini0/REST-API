namespace REST_API_vet.Models;

public class Visit
{
    public DateTime data { get; set; }
    public string description { get; set; }
    public double prize { get; set; }
    public int animalId { get; set; }
    public int visitId { get; }
    private static int visitCounter = 0;

    public Visit(DateTime data, string description, double prize, int animalId)
    {
        this.visitId = visitCounter++;
        this.data = data;
        this.description = description;
        this.prize = prize;
        this.animalId = animalId;
    }
}