using System.ComponentModel.DataAnnotations.Schema;

namespace laohaldusprojekt.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string TooteNimi { get; set; }
        public int Kogus { get; set; }
        public decimal Hind { get; set; }
        public string Kategooria { get; set; }
    }
}
