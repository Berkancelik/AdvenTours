using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Feature Class
    /// </summary>
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
