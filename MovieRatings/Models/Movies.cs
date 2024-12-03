namespace MovieRatings.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
    }

    public class MovieRating
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}
