
namespace GiftModels
{
    public class Attachment
    {
        public string Name { get; set; }

        /// <summary>
        /// html file type (json, application, image, w/e)
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// purpose (check, coupon, tsp cover sheet, w/e)
        /// </summary>
        public string FileType { get; set; }

        public string Uri { get; set; }

        /// <summary>
        /// azure identifier
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// bytes
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// catch all notes, description, w/e
        /// </summary>
        public string Description { get; set; }
    }
}
