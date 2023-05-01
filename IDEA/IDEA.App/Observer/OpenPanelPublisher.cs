using Newtonsoft.Json;
using System.Windows.Forms;

namespace IDEA.App.Observer
{
    internal class OpenPanelPublisher
    {
        #region Singleton pattern
        private static OpenPanelPublisher _instance;
        private static object _lock = new object();
        private OpenPanelPublisher() { }


        public static OpenPanelPublisher GetInstance()
        {
            lock (_lock)
            {
                if (_instance is null)
                    _instance = new OpenPanelPublisher();

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

        public void Open<TReceiver>(object obj, string menuButtonText) where TReceiver : Form
        {
            _subscriber.OpenPanel<TReceiver>(obj, menuButtonText);
        }
    }
}