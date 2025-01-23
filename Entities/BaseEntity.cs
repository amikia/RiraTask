using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseEntity<TKey> 
    {
        public TKey Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {
    }
}
