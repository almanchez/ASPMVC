using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]  
        [Display(Name ="Correo Electrónico")]
        [DataType(DataType.EmailAddress)]

        public string ReviewEmail { get; set; }


    }
}