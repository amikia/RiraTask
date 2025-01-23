using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    // Seperating Id from entities to reduce duplication of adding it to each entity in the future
    // Used Generic type base entity so I could declare Id as int, Guid or ...
    public class BaseEntity<TKey> 
    {
        public TKey Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {
    }
}
