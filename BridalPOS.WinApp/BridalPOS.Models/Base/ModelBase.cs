using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Models.Base
{
    public abstract class ModelBase
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
