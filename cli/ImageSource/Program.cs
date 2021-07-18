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
    }
}
