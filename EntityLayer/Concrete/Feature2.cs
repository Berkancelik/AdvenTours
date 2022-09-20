using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Feature 2 Class
    /// </summary>
    public class Feature2
    {
        /// <summary>
        /// Feature2Id Field
        /// </summary>
        [Key]
        public int Feature2Id { get; set; }
        /// <summary>
        /// Title Field
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description Field
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Image Field
        /// </summary>
        public string Image { get; set; }
        /// <Status>
        /// Status Field
        /// </summary>
        public bool Status { get; set; }
    }
}
