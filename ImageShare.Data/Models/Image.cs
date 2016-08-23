using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShare.Data.Models
{
    public class Image : BaseModel
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The actual picture, stored as a data Uri string.
        /// </summary>
        public string DataUri { get; set; }

        /// <summary>
        /// Navagible Uri to this resource
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// In Bytes
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// The file type of the image
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A title for the image.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A long description for the image.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The owner user (uploader).
        /// </summary>
        public Guid Owner { get; set; }

        /// <summary>
        /// Creation/ Upload date of this image
        /// </summary>
        public DateTime Created { get; set; }
    }
}
