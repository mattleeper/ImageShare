using ImageShare.Data.Models;
using System.Data.Entity.ModelConfiguration;

namespace ImageShare.Data.Mapping
{
    internal abstract class BaseMap<T> : EntityTypeConfiguration<T>
        where T : BaseModel
    {
        internal BaseMap()
        {
        }
    }
}
