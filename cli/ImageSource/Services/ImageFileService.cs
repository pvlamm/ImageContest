using ImageContest.Application.Common.Interfaces;
using ImageContest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSource.Services
{
    public class ImageFileService : IImageFileService
    {
        private readonly IApplicationDbContext _context;

        public ImageFileService(IApplicationDbContext context)
        {
            _context = context ?? throw new NullReferenceException(nameof(context));
        }

        public IEnumerable<ImageFolder> GetImageFolders(string rootFolder)
        {
            if (string.IsNullOrWhiteSpace(rootFolder))
            {
                throw new ArgumentNullException($"{nameof(rootFolder)} parameter is null");
            }

            var rootDirectory = new DirectoryInfo(rootFolder);

            var root = _context.Roots
                .Include(a => a.Folders)
                    .ThenInclude(a => a.ImageSets)
                .FirstOrDefault(a => a.Name == rootDirectory.Name)
                ?? new Root { Name = rootDirectory.Name, RootFolder = rootDirectory.FullName };

            return GetImageFolders(root);
        }

        public IEnumerable<ImageFolder> GetImageFolders(Root rootFolder)
        {
            throw new NotImplementedException();
        }

    }
}
