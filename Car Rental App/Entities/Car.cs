namespace Car_Rental_App.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string PlateNumber { get; set; }
        public bool IsRented { get; set; }
        public string Condition { get; set; }
    }
}