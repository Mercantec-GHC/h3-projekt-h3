namespace API.Models
{
    public class plants : Common
    {
        public string PlantName { get; set; }
        public int MinWaterLevel { get; set; }
        public int MaxWaterLevel { get; set; }
    }
}
