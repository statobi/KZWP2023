using System;

namespace IDEA.Logistyka.Obserwator
{
    public interface IPublisher
    {
        void Notify(Type subscriberType, object messageObj = null);
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
    }
}
