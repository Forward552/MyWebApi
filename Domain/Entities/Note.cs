﻿using System.ComponentModel.DataAnnotations;
namespace Domain.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
