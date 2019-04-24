using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev1
{
    public interface IQueueOtopark
    {
        void Insert(object a);
        object Remove();
        object Peek();
        Boolean IsEmpty();
    }
}
