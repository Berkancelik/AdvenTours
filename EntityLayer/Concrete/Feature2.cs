using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    /// <summary>
    /// Feature 2 Class
    /// </summary>
    public class Feature2
    {
        [Key]
        public int Feature2Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
