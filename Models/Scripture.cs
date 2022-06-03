using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public string Verse { get; set; }
        public string Chapter { get; set; }
        
        [Display(Name = "Cannon Type")]
        public string CannonType { get; set; }
        public string Notes { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}