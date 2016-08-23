using ImageShare.Data.Context;
using ImageShare.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShare.Data.Repositories
{
    public interface IImageRepository : IBaseRepository<Image>
    {
        Image GetByUri(string uri);

        Image GetById(long id);
    }

    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(IDataContext context)
            : base(context)
        {
        }

        public Image GetByUri(string uri)
        {
            return Get(i => i.Uri == uri).FirstOrDefault();
        }

        public Image GetById(long id)
        {
            return Get(i => i.Id == id).FirstOrDefault();
        }
    }
}
