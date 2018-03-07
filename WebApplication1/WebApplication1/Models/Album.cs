using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public int Title { get; set; }

        //para obener una vista de la clase referenciada: alt+f12
        //public Artista Artist { get; set; }

        public int ReviewID { get; set; }


        //se adiciona este motodo para solucionar  el problema de scalfonding al adicionar el controlador de review
        //un album puede contener multiples revisiones 1...*
      //  public virtual List <Review> Review { get; set; }


    }
}