using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Utilities.DTO
{
    public class SaveResult
    {
        public int? Id { get; set; }
        public OperationState State { get; set; }
        public string Exception { get; set; }
    }
}
