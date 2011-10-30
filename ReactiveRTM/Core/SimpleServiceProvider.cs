using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Codeplex.Data;
using ReactiveRTM.Adapter;

namespace ReactiveRTM.Core
{
    public class SimpleServiceProvider
    {
        public SimpleServiceProvider(string name)
        {
            _adapter = new SimpleServiceAdapter(Invoke);
        }

        private SimpleService _adapter;

        public SimpleService AdapterForTest
        {
            get { return _adapter; }
        }

        Dictionary<string, Delegate> _actions = new Dictionary<string, Delegate>();
        public void RegisterMethod(string methodName, Action action)
        {
            _actions.Add(methodName, action);
        }

        public void RegisterMethod<T>(string methodName, Action<T> action)
        {
            _actions.Add(methodName, action);
        }

        public void RegisterMethod<T1, T2>(string methodName, Action<T1, T2> action)
        {
            _actions.Add(methodName, action);
        }

        public void RegisterMethod<TResult>(string methodName, Func<TResult> action)
        {
            _actions.Add(methodName, action);
        }

        public void RegisterMethod<T, TResult>(string methodName, Func<T, TResult> action)
        {
            _actions.Add(methodName, action);
        }

        public void RegisterMethod<T1, T2, TResult>(string methodName, Func<T1, T2, TResult> action)
        {
            _actions.Add(methodName, action);
        }

        private string Invoke(string operation, string[] args)
        {
            if (!_actions.ContainsKey(operation))
            {
                throw new ArgumentException();
            }

            var methodInfo = _actions[operation];

            //キャストしたい・・・
            //var p = methodInfo.Method.GetParameters().Select(param=>param.ParameterType);
            var argObjs = args.Select(DynamicJson.Parse);//.Cast<>();

            var ret = methodInfo.DynamicInvoke(argObjs.ToArray());

            return DynamicJson.Serialize(ret);
        }
    }
}
