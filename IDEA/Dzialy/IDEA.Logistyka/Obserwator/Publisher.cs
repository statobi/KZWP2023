using System;
using System.Collections.Generic;

namespace IDEA.Logistyka.Obserwator
{
    public class Publisher : IPublisher
    {
        #region Singleton pattern
        private static Publisher _instance;
        private static object _lock = new object();
        private Publisher() { }


        public static Publisher GetInstance()
        {
            lock (_lock)
            {
                if (_instance is null)
                    _instance = new Publisher();

                return _instance;
            }
        }
        #endregion 

        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber subscriber)
            => _subscribers.Add(subscriber);

        public void Unsubscribe(ISubscriber subscriber)
            => _subscribers.Remove(subscriber);

        public void Notify(Type subscriberType, object messageObj = null)
        {
            foreach (var subskrybent in _subscribers)
            {
                if(subskrybent.GetType() == subscriberType)
                    subskrybent.UpdateView(message);
            }
        }
    }
}
