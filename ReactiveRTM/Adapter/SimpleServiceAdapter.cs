using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReactiveRTM.Adapter
{
    public class SimpleServiceAdapter : MarshalByRefObject, SimpleService
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }

        private Func<string, string[], string>  _callback;

        public SimpleServiceAdapter(Func<string, string[], string> callback)
        {
            _callback = callback;
        }

        public string[] invoke(string operation, string[] args)
        {
            return new string[] { _callback(operation, args) };
        }
    }
}
