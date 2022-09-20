using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// About 2 Class
    /// </summary>
    public class About2
    {
        /// <summary>
        /// About2ID Field
        /// </summary>
        [Key]
        public int About2ID { get; set; }
        /// <summary>
        /// Title1 Field
        /// </summary>
        public string Title1 { get; set; }
        /// <summary>
        /// Title2 Field
        /// </summary>
        public string Title2 { get; set; }
        /// <summary>
        /// Description Field
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Image Field
        /// </summary>
        public string Image { get; set; }
    }
}
