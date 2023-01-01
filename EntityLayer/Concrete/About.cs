using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// About Class
    /// </summary>
    public class About
    {


        /// <summary>
        /// AboutID Field
        /// </summary>

        [Key]
        public int AboutID { get; set; }
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
        /// <summary>
        /// Title2 Field
        /// </summary>
        public string Title2 { get; set; }
        /// <summary>
        /// Description2 Field
        /// </summary>
        public string Description2 { get; set; }
        /// <summary>
        /// Description2 Field
        /// </summary>
        public string Status { get; set; }

    }
}
