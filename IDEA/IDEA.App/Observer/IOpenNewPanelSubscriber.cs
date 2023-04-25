using System;

namespace IDEA.App.Observer
{
    internal interface IOpenNewPanelSubscriber
    {
        void OpenPanel(Type type);
    }
}
