using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Feature Class
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// FeatureID Field
        /// </summary>
        [Key]
        public int FeatureID { get; set; }
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
        /// Status Field
        /// </summary>
        public bool Status { get; set; }
    }
}
