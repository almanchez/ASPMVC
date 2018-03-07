namespace WebApplication1.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public int Title { get; set; }

        //para obener una vista de la clase referenciada: alt+f12
        public Artista Artist { get; set; }

        public Review Review { get; set; }


    }
}