using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using ReactiveRTM.Core;

namespace ReactiveRTM.Corba
{
    class RemotingNamingServiceClient : INamingServiceClient
    {
        #region Implementation of IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of INamingServiceClient

        public string Key
        {
            get { throw new NotImplementedException(); }
        }

        public string HostName
        {
            get { throw new NotImplementedException(); }
        }

        public int PortNumber
        {
            get { throw new NotImplementedException(); }
        }

        public void ClearZombie<TObject>()
        {
            throw new NotImplementedException();
        }

        public void RegisterObject(string name, MarshalByRefObject obj)
        {
            RemotingServices.Marshal(obj, name);
        }

        public void UnregisterObject(string name)
        {
            //RemotingServices.Disconnect()
            //RemotingServices.Unmarshal()
        }

        public TObjectType GetObject<TObjectType>(string name) where TObjectType : class
        {
            string uri = "iiop://" + HostName+ ":" + PortNumber+ "/"+name;

            return (TObjectType)RemotingServices.Connect(typeof(TObjectType), uri);
        }

        public IEnumerable<string> GetObjectNames()
        {
            throw new NotImplementedException();
        }

        public bool IsA<TObject>(string name)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
