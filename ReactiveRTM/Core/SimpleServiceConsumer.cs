using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Codeplex.Data;
using ReactiveRTM.IDL;

namespace ReactiveRTM.Core
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

            var jsonArgs = args.Select(DynamicJson.Serialize);

            var ret = _service.Invoke(methodName, jsonArgs.ToArray());

            result = DynamicJson.Parse(ret.First());

            return true;
        }
    }

}
