using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcToyStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UrlImage { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        

    }
}