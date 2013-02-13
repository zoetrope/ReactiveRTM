using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Corba
{
    class DummyNamingServiceClient : INamingServiceClient
    {
        public void Initialize(Dictionary<string, string> setting)
        {
            throw new NotImplementedException();
        }

        public void RegisterObject(string name, MarshalByRefObject obj)
        {
            throw new NotImplementedException();
        }

        public void UnregisterObject(string name)
        {
            throw new NotImplementedException();
        }

        public TObjectType GetObject<TObjectType>(string name) where TObjectType : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetObjectNames()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
