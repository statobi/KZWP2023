using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace IDEA.Logistyka.Obserwator
{
    public class Publisher
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

        public void Notify<T>(object messageObj = null) where T : Form
        {
            foreach (var subscriber in _subscribers)
            {
                if(subscriber is T)
                {
                    var serializedObj = Serialize(messageObj) ?? "";
                    subscriber.UpdateView(serializedObj);
                }
            }
        }

        private string Serialize(object obj)
            => JsonConvert.SerializeObject(obj, Formatting.None);
    }
}
