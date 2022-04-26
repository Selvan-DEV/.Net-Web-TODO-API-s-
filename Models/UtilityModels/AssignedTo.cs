using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_APP.Models.UtilityModels
{
    public class AssignedTo
    {
        public Guid TaskId { get; set; }
        public Guid WorkerId { get; set; }
    }
}
