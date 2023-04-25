using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Obserwator
{
    public interface ISubscriber
    {
        void UpdateView(string message = null);
    }
}
