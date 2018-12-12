using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristine.Models {
    public class Sheet {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public ObservableCollection<FabricThread> ClientFabricThreads { get; set; }
    }
}
