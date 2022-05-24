using w10d2.Models;

namespace w10d2.FakeDB
{
    public static class Database
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car("Ford", "Escape", "white", 2004, 2000, "muh car that goes vroom", "https://thiscatdoesnotexist.com"),
            new Car("Ford", "Taurus", "white", 1998, 500, "it dun work", "https://thiscatdoesnotexist.com"),
            new Car("Subaru", "Legacy", "white", 2013, 3000, "it got rearended, but still runs well", "https://thiscatdoesnotexist.com")
        };
        
        public static List<House> Houses { get; set; } = new List<House>()
        {
            new House(2000, 2000, 2000, 2000, 2000, "https://thiscatdoesnotexist.com/", "house is cat ecksdee"),
            new House(1000, 2000, 4000, 8000, 16000, "https://thiscatdoesnotexist.com/", "beeg house"),
            new House(2011, 1, 1, 1, 384, "https://thiscatdoesnotexist.com/", "minecraft joke")
        };
        
        // public static List<Job> Jobs { get; set; } = new List<Job>()
        // {
        //     // TODO fake data goes here
        // };
    }
}