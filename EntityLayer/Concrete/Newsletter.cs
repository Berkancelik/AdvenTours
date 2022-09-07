
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// NewsLetter Class
    /// </summary>
    public class Newsletter
    {
        [Key]
        public int NewsletterID { get; set; }
        public string Mail { get; set; }

    }
}
