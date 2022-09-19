using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class NestModel
    {
        public IEnumerable<BOT_Toy_Nest> bOT_Toy_Nests { get; set; }
        public IEnumerable<BOT_Rak_Nest> bot_rak_Toys { get; set; }
        public IEnumerable<BOT_Register_Nest> bot_register_Nests{ get; set; }
        public IEnumerable<BOT_Lokator_Nest> bot_lokator_Nests { get; set; }
    }
}