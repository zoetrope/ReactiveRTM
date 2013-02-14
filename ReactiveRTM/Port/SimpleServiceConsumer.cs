using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using ReactiveRTM.IDL;
using Newtonsoft.Json.Linq;

namespace ReactiveRTM.Port
{
    public class SimpleServiceConsumer : DynamicObject
    {
        ISimpleService _service;

        public SimpleServiceConsumer(string portName)
        {
        }

        public void SetDummy(MarshalByRefObject obj)
        {
            _service = (ISimpleService)obj;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var methodName = binder.Name;

            var jsonArgs = args.Select(JObject.FromObject);

            var ret = _service.Invoke(methodName, jsonArgs.Select(j => j.ToString()).ToArray());

            result = JObject.Parse(ret.First());

            return true;
        }
    }

}
