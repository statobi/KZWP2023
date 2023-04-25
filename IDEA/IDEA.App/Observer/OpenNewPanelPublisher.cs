using Newtonsoft.Json;
using System.Windows.Forms;

namespace IDEA.App.Observer
{
    internal class OpenNewPanelPublisher
    {
        #region Singleton pattern
        private static OpenNewPanelPublisher _instance;
        private static object _lock = new object();
        private OpenNewPanelPublisher() { }


        public static OpenNewPanelPublisher GetInstance()
        {
            lock (_lock)
            {
                if (_instance is null)
                    _instance = new OpenNewPanelPublisher();

                return _instance;
            }
        }
        #endregion

        private IOpenNewPanelSubscriber _subscriber = null;

        public void Subscribe(IOpenNewPanelSubscriber subscriber)
        {
            if(subscriber is InitForm)
            {
                _subscriber = subscriber;
            }
        }

        public void Notify<T>(object obj) where T : Form
        {
            _subscriber.OpenPanel<T>(obj);
        }
    }
}