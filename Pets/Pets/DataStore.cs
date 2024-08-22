namespace Pets
{
    public class DataStore
    {
        public static List<Pet> Pets = new List<Pet>
        {
            new() { Id = 1, Name = "Ezreal", Birthdate = DateTime.Now },
            new() { Id = 2, Name = "Seraphine", Birthdate = DateTime.Now },
        };

        public static List<Owner> Owners = new List<Owner>
        {
            new Owner() { Id = 1, Name = "Jhon", Pets = [new() { Id = 1, Name = "Ezreal", Birthdate = DateTime.Now } ]},
            new Owner() { Id = 2, Name = "Samuel", Pets =
                [
                    new() { Id = 1, Name = "Ezreal", Birthdate = DateTime.Now },
                    new() { Id = 2, Name = "Seraphine", Birthdate = DateTime.Now }
                ]},
        };
    }
}
