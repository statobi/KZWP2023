﻿namespace IDEA.Logistyka.Observer
{
    public interface IRequestSubscriber : ICommonSubscriber
    {
        void GetData<TMessage>(string message);
    }
    
    public interface INotifficationSubscriber : ICommonSubscriber
    {
        void GetNotification();
    }

    public interface ICommonSubscriber { }
}
