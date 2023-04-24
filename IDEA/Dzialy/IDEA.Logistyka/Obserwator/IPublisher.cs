namespace IDEA.Logistyka.Obserwator
{
    public interface IPublisher
    {
        void PowiadomOZamknieciuOkna();
        void Zasubskrybuj(ISubscriber subscriber);
        void Odsubskrybuj(ISubscriber subscriber);
    }
}
