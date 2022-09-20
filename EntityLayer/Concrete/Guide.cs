using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Guide Class
    /// </summary>
    public class Guide
    {
        /// <Status>
        /// GuideID Field
        /// </summary>
        [Key]
        public int GuideID { get; set; }
        /// <Status>
        /// Name Field
        /// </summary>
        public string Name { get; set; }
        /// <Status>
        /// Description Field
        /// </summary>
        public string Description { get; set; }
        /// <Status>
        /// Image Field
        /// </summary>
        public string Image { get; set; }
        /// <Status>
        /// TwitterUrl Field
        /// </summary>
        public string TwitterUrl { get; set; }
        /// <Status>
        /// InstagramUrl Field
        /// </summary>
        public string InstagramUrl { get; set; }
        /// <Status>
        /// Status Field
        /// </summary>
        public bool Status  { get; set; }
    }
}
