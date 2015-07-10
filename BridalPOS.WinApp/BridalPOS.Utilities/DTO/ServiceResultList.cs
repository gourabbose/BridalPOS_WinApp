using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Utilities.DTO
{
    public class ServiceResultList<T> where T : class
    {
        public OperationState State { get; set; }
        public IEnumerable<T> Data { get; set; }
        public string Exception { get; set; }
    }
}
