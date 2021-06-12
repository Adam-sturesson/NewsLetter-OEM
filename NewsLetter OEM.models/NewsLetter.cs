using System.ComponentModel.DataAnnotations;

namespace NewsLetter_OEM.models
{
    public class NewsLetter
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Fältet för mailen är obligatoriskt")]
        public string Email { get; set; }
        [RegularExpression("True",ErrorMessage = "GDPR måste godkännas för att kunna få nyhetsbrev")]
        public bool approvesGDPR { get; set; }
    }
}
