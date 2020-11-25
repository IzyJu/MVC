using System;
using System.ComponentModel.DataAnnotations;

namespace ExMvc.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contenu { get; set; }
    }
}