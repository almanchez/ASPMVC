﻿namespace WebApplication1.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public Album Album { get; set; }

        public string Contents { get; set; }

        public string ReviewEmail { get; set; }


    }
}