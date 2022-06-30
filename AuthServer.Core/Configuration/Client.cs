using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Configuration
{
    //Dış dünyaya açılmayacak
    public class Client
    {
        public string Id { get; set; }
        public string Secret { get; set; }

        //www.myapp1.com
        public List<String> Audiences { get; set; }
    }
}
