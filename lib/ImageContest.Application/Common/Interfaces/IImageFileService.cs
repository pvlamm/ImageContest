using ImageContest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Application.Common.Interfaces
{
    public interface IImageFileService
    {
        public Root GetImageFolders(string rootFolder);
        public Root GetImageFolders(Root rootFolder);
    }
}
