using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Domain.Entities
{
    public class Root
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RootFolder { get; set; }
        public IEnumerable<ImageFolder> Folders { get; set; } = new HashSet<ImageFolder>();
    }
}
