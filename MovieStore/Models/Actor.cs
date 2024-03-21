namespace MovieStore.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string FeePerFilm { get; set; }
        public List<Movie> Movies { get; set; }
    }
}