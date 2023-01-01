
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Sub About Class
    /// </summary>
    public class SubAbout
    {/// <summary>
     /// Sub About Id
     /// </summary>
        [Key]
        public int SubAboutId { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
    }
}
