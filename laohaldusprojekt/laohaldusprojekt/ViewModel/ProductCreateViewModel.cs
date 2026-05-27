using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laohaldusprojekt.ViewModel
{
    public class ProductCreateViewModel
    {
        public int Id { get; set; }
        public string TooteNimi { get; set; }
        public int Kogus { get; set; }
        public double Hind { get; set; }
        public string Kategooria { get; set; }
    }
}
