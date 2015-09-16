
using System.ComponentModel.DataAnnotations;

namespace GiftModels
{
    public class Attachment
    {
        public Attachment()
        {
            IsActive = true;    
        }
        
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// html file type (json, application, image, w/e)
        /// </summary>
        [Required]
        public string ContentType { get; set; }

        /// <summary>
        /// purpose (check, coupon, tsp cover sheet, w/e)
        /// </summary>
        public string FileType { get; set; }

        public string Uri { get; set; }

        /// <summary>
        /// azure identifier
        /// </summary>
        [Required]
        public string Identifier { get; set; }

        /// <summary>
        /// bytes
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// catch all notes, description, w/e
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Whether or not an attachment is active, i.e., visible
        /// </summary>
        public bool IsActive { get; set; }
    }
}
