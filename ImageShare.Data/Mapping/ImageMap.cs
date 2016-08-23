using ImageShare.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShare.Data.Mapping
{
    /// <summary>
    /// Fluid API mapping for Image Model.
    /// </summary>
    internal class ImageMap : BaseMap<Image>
    {
        internal ImageMap() : base()
        {
            ToTable("Image");
            Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Owner).HasColumnName("Owner");
            Property(t => t.Description).HasColumnName("Description").HasMaxLength(256);
            Property(t => t.Size).HasColumnName("Size");
            Property(t => t.Title).HasColumnName("Title").HasMaxLength(30);
            Property(t => t.Type).HasColumnName("Type").HasMaxLength(4);
            Property(t => t.Uri).HasColumnName("Uri").HasMaxLength(8);
            
            // Key
            HasKey(t => t.Id);
        }
    }
}
