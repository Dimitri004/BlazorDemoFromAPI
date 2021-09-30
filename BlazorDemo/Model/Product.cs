namespace BlazorDemo.Model
{
    public class Product
    {
        public string ID { get; set; }
        public int CampaignID { get; set; }
        public string Name { get; set; }
        public Price Price { get; set; }
        public string URL { get; set; }
        public string[] Images { get; set; }
        public string Description { get; set; }
        public string[] Categories { get; set; }
        public string[] Properties { get; set; }
        public string[] Variations { get; set; }
    }
}
