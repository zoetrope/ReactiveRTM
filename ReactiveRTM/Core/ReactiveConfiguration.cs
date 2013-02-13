using ReactiveRTM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;

namespace ReactiveRTM.Core
{
    class ReactiveConfiguration
    {
    }

    public class ParamHolder<T> : ISubject<T>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(T value)
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }
    }

    class DynamicConfiguration
    {
        //Jsonで。
    }
}
