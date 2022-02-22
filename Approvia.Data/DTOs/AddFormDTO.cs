using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvia.Data.DTOs
{
    public class AddFormDTO
    {
        
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMessage { get; set; }
        public string _FormDomainName{ get; set; }
        public string _FormName { get; set; }
    }
}
