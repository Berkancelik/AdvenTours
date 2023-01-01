using System;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Reservation Class
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// Reservation Id
        /// </summary>
        public int ReservationID { get; set; }
        /// <summary>
        /// App User Id
        /// </summary>
        public int AppUserId { get; set; }
        /// <summary>
        /// AppUser
        /// </summary>
        public AppUser AppUser { get; set; }
        /// <summary>
        /// Person Count
        /// </summary>
        public string PersonCount { get; set; }
        /// <summary>
        /// Reservation Date
        /// </summary>
        public DateTime ReservationDate { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Destination
        /// </summary>
        public Destination Destination { get; set; }
        /// <summary>
        /// Destination Id
        /// </summary>
        public int DestinationID { get; set; }


    }
}
