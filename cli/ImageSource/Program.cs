using ImageContest.Application.Common.Interfaces;
using ImageContest.Infrastructure.Persistence;
using ImageSource.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace ImageSource
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fileService = GetImageFileService();
            var folders = fileService.GetImageFolders(GetRootFolder());

            foreach(var folder in folders.Folders)
            {
                Console.WriteLine(folder.Name);
            }
        }


        public static IImageFileService GetImageFileService()
        {
            return new ImageFileService(GetApplicationDbContext());
        }

        public static IApplicationDbContext GetApplicationDbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }

        public static string GetRootFolder()
        {
            return ConfigurationManager.AppSettings["rootFolder"].Trim();
        }
    }
}
