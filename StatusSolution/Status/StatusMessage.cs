using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status;
//Models
    public record StatusMessage(Guid Id, string Message, DateTimeOffset when);
  
public record StatusChangerequest(string Message);
