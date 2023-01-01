using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Destination Class
    /// </summary>
    public class Destination
    {
        /// <summary>
        /// DestinationID Field
        /// </summary>
        [Key]
        public int DestinationID { get; set; }
        /// <summary>
        /// City Field
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// DayNight Field
        /// </summary>
        public string DayNight { get; set; }
        /// <summary>
        /// Price Field
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Image Field
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Description Field
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Capacity Field
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Status Field
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Details1 Field
        /// </summary>
        public string Details1 { get; set; }
        /// <summary>
        /// Details2 Field
        /// </summary>
        public string Details2 { get; set; }
        /// <summary>
        /// Image2 Field
        /// </summary>
        public string Image2 { get; set; }
        /// <summary>
        /// Comments Field
        /// </summary>
        public List<Comment> Comments { get; set; }
        /// <summary>
        /// Reservations Field
        /// </summary>
        public List<Reservation> Reservations { get; set; }


    }
}
