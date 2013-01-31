using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using ReactiveRTM.OpenRTM;

namespace ReactiveRTM.Adapter
{
    public class UpdateStatus
    {
        public StatusKind StatusKind { get; set; }
        public string Hint { get; set; }
    }

    public class ComponentObserverImpl: ComponentObserver, IObservable<UpdateStatus>
    {
        private Subject<UpdateStatus> _subject;

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public ComponentObserverImpl()
        {

            _subject = new Subject<UpdateStatus>();
        }

        #region Implementation of IObservable<out UpdateStatus>

        public IDisposable Subscribe(IObserver<UpdateStatus> observer)
        {
            return _subject.Subscribe(observer);
        }

        #endregion


        public void UpdateStatus(StatusKind status_kind, string hint)
        {
            _subject.OnNext(new UpdateStatus() { StatusKind = status_kind, Hint = hint });
        }
    }
}
