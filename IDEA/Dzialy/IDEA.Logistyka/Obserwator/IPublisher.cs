using System;

namespace IDEA.Logistyka.Obserwator
{
    public interface IPublisher
    {
        void PowiadomOZamknieciuOkna(Type doKogo);
        void Zasubskrybuj(ISubscriber subscriber);
        void Odsubskrybuj(ISubscriber subscriber);
    }
}
