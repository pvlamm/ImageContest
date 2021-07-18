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

        public Root GetImageFolders(string rootFolder)
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

        public Root GetImageFolders(Root rootFolder)
        {
            DirectoryInfo root = new DirectoryInfo(rootFolder.RootFolder);

            var imageFolders = root.GetDirectories("*", SearchOption.TopDirectoryOnly);

            var folders = rootFolder.Folders.Where(a => !imageFolders.Any(b => b.FullName == a.Folder)).ToList();
            folders
                .AddRange(imageFolders
                    .Where(a => !rootFolder.Folders.Any(b => b.Folder == a.FullName))
                    .Select(a => new ImageFolder {
                            Folder = a.FullName,
                            ImageSets = a.GetDirectories("*", SearchOption.AllDirectories).Select(a => new ImageSet { 
                            Name = a.Name,
                            Folder = a.FullName,
                            FileCount = a.GetFiles().Length
                        }),
                        Name = a.Name
                    }));

            rootFolder.Folders = folders;

            return rootFolder;
        }
    }
}
