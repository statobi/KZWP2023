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

        private readonly List<ISubscriber> _subskrybenci = new List<ISubscriber>();
        public void Zasubskrybuj(ISubscriber subscriber)
            => _subskrybenci.Add(subscriber);

        public void Odsubskrybuj(ISubscriber subscriber)
            => _subskrybenci.Remove(subscriber);

        public void PowiadomOZamknieciuOkna(Type doKogo)
        {
            foreach (var subskrybent in _subskrybenci)
            {
                if(subskrybent.GetType() == doKogo)
                    subskrybent.ZaktualizujWidok();
            }
        }
    }
}
