using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// AppUser Class
    /// </summary>
    public class AppUser : IdentityUser<int>
    {
        /// <summary>
        /// ImageUrl Field
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// Name Field
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname Field
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Gender Field
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Reservations Field
        /// </summary>
        public List<Reservation> Reservations {get;set;}
}
}
