using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace PresModels
{
    [Database]
    class BankGiroProcessing
    {
        public string CompanyName { get; set; }
        public long OrgNumber { get; set; }
        public string BGNumber { get; set; }
        public bool IsProcessed => OrgNumber > 0 && !string.IsNullOrEmpty(CompanyName);
    }
}
