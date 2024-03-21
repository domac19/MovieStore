using MovieStore.Models;

namespace MovieStore.ViewModels
{
    public class ActorViewModel
    {
        public int Id { get; set; }
        public List<Movie> Movies { get; set; }
        public string? MovieInvitation { get; set; }
        public string? MovieApplication { get; set; }
        public string? MovieRoles { get; set; }
    }
}
