using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericNode<K>
    {
        public GenericNode<K> Next
        {
            get;
            set;
        }

        public K Data
        {
            get;
            set;
        }
    }
}
