using System;
using System.Windows.Forms;

namespace IDEA.App.Observer
{
    internal interface IOpenNewPanelSubscriber
    {
        void OpenPanel<T>(object messageObj) where T : Form;
    }
}
