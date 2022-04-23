namespace modul08_1302204068
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }

        public List<string> Stars { get; set; }

        public string Description { get; set; }

        public Movie(string judul, string direktor, List<string> bintang, string deskripsi)
        {
            this.Title = judul;
            this.Director = direktor;
            this.Stars = bintang;
            this.Description = deskripsi;
        }
    }
}
