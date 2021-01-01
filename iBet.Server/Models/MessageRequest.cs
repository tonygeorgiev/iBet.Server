using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Models
{
    public class MessageRequest
    {
        public string User { get; set; }
        public string MessageText { get; set; }
    }
}
