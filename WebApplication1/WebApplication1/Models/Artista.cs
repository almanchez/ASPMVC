using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models

{
    //para adiciona getter and setter: prop +tecla tab+tecla tab

    public class Artista
    {
        public int ArtistID { get; set; }

        public String Name { get; set; }

        public  List <Album> Albums { get; set; }

    }
}