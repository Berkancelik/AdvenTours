using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Contact Class
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// ContactID Field
        /// </summary>
        [Key]
        public int ContactID { get; set; }
        /// <summary>
        /// Description Field
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Mail Field
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Adress Field
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// Phone Field
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// MapLocation Field
        /// </summary>
        public string MapLocation { get; set; }
        /// <summary>
        /// Status Field
        /// </summary>
        public bool Status { get; set; }
    }
}
