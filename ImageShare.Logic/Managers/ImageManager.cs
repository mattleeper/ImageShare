using AutoMapper;
using ImageShare.Data.Models;
using ImageShare.Data.Repositories;
using ImageShare.Logic.Providers;
using ImageShare.Logic.RequestModels;
using ImageShare.Logic.ResponseModels;
using ImageShare.Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShare.Logic.Managers
{
    public interface IImageManager
    {
        ImageViewModel GetImage(long Id);

        ImageViewModel GetImageByURI(string URI);

        ImageViewModel PostImage(ImageViewModel image);

        PagedImages GetPagedImages(PagedRequest request);
    }

    public class ImageManager : BaseManager, IImageManager
    {
        private IImageRepository repository { get; set; }

        public ImageManager(IImageRepository repository)
        {
            this.repository = repository;
        }

        public ImageViewModel GetImage(long id)
        {
            return Mapper.Map<ImageViewModel>(repository.GetById(id));
        }

        public ImageViewModel GetImageByURI(string uri)
        {
            return Mapper.Map<ImageViewModel>(repository.GetByUri(uri));
        }

        public ImageViewModel PostImage(ImageViewModel viewModel)
        {
            var dataModel = Mapper.Map<Image>(viewModel);
            var uri = URIProvider.GetBase62(8);

            while(repository.GetByUri(uri) != null)
                uri = URIProvider.GetBase62(8);

            dataModel.Uri = uri;
            repository.Insert(dataModel);

            return Mapper.Map<ImageViewModel>(dataModel);
        }

        public PagedImages GetPagedImages(PagedRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
