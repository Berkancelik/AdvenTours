
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Testimonial Class
    /// </summary>
    public class Testimonial
    {
        /// <summary>
        /// Testimonial Id
        /// </summary>
        [Key]
        public int TestimonialID { get; set; }
        /// <summary>
        /// Client
        /// </summary>
        public string Client { get; set; }
        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Client Images
        /// </summary>
        public string ClientImages { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public bool Status { get; set; }
    }
}
