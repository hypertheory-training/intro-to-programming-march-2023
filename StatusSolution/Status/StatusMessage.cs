using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status
{
    public record StatusMessage(Guid Id, string Message, DateTimeOffset When)
    {
    }
}
