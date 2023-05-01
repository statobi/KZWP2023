using System;
using System.Windows.Forms;

namespace IDEA.App.Observer
{
    internal interface IOpenNewPanelSubscriber
    {
        void OpenPanel<TReceiver>(object messageObj, string menuButtonText) where TReceiver : Form;
    }
}
