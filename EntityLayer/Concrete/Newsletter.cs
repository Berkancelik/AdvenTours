
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// NewsLetter Class
    /// </summary>
    public class Newsletter
    {
        /// <Status>
        /// NewsletterID Field
        /// </summary>
        [Key]
        public int NewsletterID { get; set; }
        /// <Status>
        /// Mail Field
        /// </summary>
        public string Mail { get; set; }

    }
}
