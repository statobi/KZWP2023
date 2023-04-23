namespace IDEA.Database
{

    public class IDEADatabase
    {
        private static IDEAEntities _instance = null;
        private static object _instanceLock = new object();

        private IDEADatabase() { }

        public static IDEAEntities GetInstance()
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                    _instance = new IDEAEntities();

                return _instance;
            }
        }
    }
}
