namespace Model
{
    public class Car : IDomainObject
    {
     
            
            public int Id { get; set; }
            public string Brand { get; set; }
            public string Color { get; set; }
            public string Year { get; set; }


            
            public Car (int id, string brand, string color, string year)
            {
                Id = id;
                Brand = brand;
                Color = color;
                Year=year;
            }
       

    }
}
