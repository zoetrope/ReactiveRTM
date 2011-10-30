using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using Codeplex.Reactive;
using RTC;
using ReactiveRTM.Core;
using omg.org.RTC;

namespace GUIComponent
{
    class MainWindowViewModel
    {
        private RtcManager _manager = new RtcManager("localhost", 2809);
        private SimpleComponent _component = new SimpleComponent("GUI");
        private ReactiveInPort<TimedLong> _inport = new ReactiveInPort<TimedLong>("in");
        private ReactiveOutPort<TimedLong> _outport = new ReactiveOutPort<TimedLong>("out");


        public ReactiveProperty<int> ReceivedData { get; private set; }

        public ReactiveProperty<int> SendData { get; private set; }
        public ReactiveCommand SendCommand { get; private set; }

        public MainWindowViewModel()
        {
            _component.AddPort(_inport);
            _component.AddPort(_outport);

            _manager.RegisterComponent(_component);


            // InPortで受け取ったデータを表示する
            ReceivedData = _inport.Select(x => x.data).ToReactiveProperty();

            SendData = new ReactiveProperty<int>();

            // コンポーネントを活性化したときだけボタンを押せる
            SendCommand = _component.StateChangedAsObservable()
                .Select(state => state == LifeCycleState.ACTIVE_STATE)
                .ToReactiveCommand(initialValue: false);
                
            // ボタンを押したらデータを送信する
            SendCommand
                .Subscribe(x => _outport.WriteAsync(new TimedLong(new Time(), SendData.Value)));

        }
    }
}
