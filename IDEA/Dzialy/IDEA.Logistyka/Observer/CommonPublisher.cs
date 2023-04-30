using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IDEA.Logistyka.Observer
{
    public class CommonPublisher
    {
        #region Singleton pattern
        private static CommonPublisher _instance;
        private static object _lock = new object();
        private CommonPublisher() { }


        public static CommonPublisher GetInstance()
        {
            lock (_lock)
            {
                if (_instance is null)
                    _instance = new CommonPublisher();

                return _instance;
            }
        }
        #endregion 

        private readonly List<IRequestSubscriber> _requestSubscribers = new List<IRequestSubscriber>();
        private readonly List<INotifficationSubscriber> _notificationSubscribers = new List<INotifficationSubscriber>();

        public void Subscribe(ICommonSubscriber subscriber)
        {
            if(subscriber is IRequestSubscriber requestSubscriber)
                _requestSubscribers.Add(requestSubscriber);
            
            if(subscriber is INotifficationSubscriber notifficationSubscriber)
                _notificationSubscribers.Add(notifficationSubscriber);
        }

        public void Unsubscribe(IRequestSubscriber subscriber)
        {
            if (subscriber is IRequestSubscriber requestSubscriber)
                _requestSubscribers.Remove(requestSubscriber);

            if (subscriber is INotifficationSubscriber notifficationSubscriber)
                _notificationSubscribers.Remove(notifficationSubscriber);
        }

        public void Send<TReceiver>(object messageObj) where TReceiver : Form
        {
            foreach (var subscriber in _requestSubscribers)
            {
                if (subscriber is TReceiver)
                {
                    subscriber.GetData(messageObj);
                }
            }
        }

        public void Notify<TReceiver>() where TReceiver : Form
        {
            foreach (var subscriber in _notificationSubscribers)
            {
                if (subscriber is TReceiver)
                {
                    subscriber.GetNotification();
                }
            }
        }
    }
}
