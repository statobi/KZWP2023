using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Observer
{
    public interface ISubscriber
    {
        void GetData(string message = null);
    }
}
