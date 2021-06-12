using System.ComponentModel.DataAnnotations;

namespace NewsLetter_OEM.models
{
    public class NewsLetter
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Email { get; set; }

        
        public bool approvesGDPR { get; set; }
    }
}
