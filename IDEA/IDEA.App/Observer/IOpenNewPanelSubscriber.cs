using System;
using System.Windows.Forms;

namespace IDEA.App.Observer
{
    internal interface IOpenNewPanelSubscriber
    {
        void OpenPanel<TReceiver, TMessage>(object messageObj, string menuButtonText) where TReceiver : Form;
    }
}
