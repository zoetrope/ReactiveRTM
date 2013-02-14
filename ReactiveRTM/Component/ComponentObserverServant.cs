using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using ReactiveRTM.OpenRTM;

namespace ReactiveRTM.Component
{
    public class UpdateStatus
    {
        public StatusKind StatusKind { get; set; }
        public string Hint { get; set; }
    }

    public class ComponentObserverImpl: ComponentObserver, IObservable<UpdateStatus>
    {
        private Subject<UpdateStatus> _subject;

        public ComponentObserverImpl()
        {

            _subject = new Subject<UpdateStatus>();
        }

        public IDisposable Subscribe(IObserver<UpdateStatus> observer)
        {
            return _subject.Subscribe(observer);
        }

        public void UpdateStatus(StatusKind status_kind, string hint)
        {
            _subject.OnNext(new UpdateStatus() { StatusKind = status_kind, Hint = hint });
        }
    }
}
