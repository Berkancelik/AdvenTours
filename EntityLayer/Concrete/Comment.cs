using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Comment Class
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// CommentId Field
        /// </summary>
        [Key]
        public int CommentId { get; set; }
        /// <summary>
        /// CommentUser Field
        /// </summary>
        public string CommentUser { get; set; }
        /// <summary>
        /// CommentDate Field
        /// </summary>
        public DateTime CommentDate { get; set; }
        /// <summary>
        /// CommentContent Field
        /// </summary>
        public string CommentContent { get; set; }
        /// <summary>
        /// CommentStatus Field
        /// </summary>
        public bool CommentStatus { get; set; }
        /// <summary>
        /// DestinationId Field
        /// </summary>
        public int DestinationId { get; set; }
        /// <summary>
        /// Destination Field
        /// </summary>
        public Destination Destination { get; set; }
    }
}
