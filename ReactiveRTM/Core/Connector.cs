using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Core
{

    /// <summary>
    /// データポートやサービスポートの接続を管理するユーティリティクラス
    /// </summary>
    public class PortConnector
    {
        private ConnectorProfileHolder _profile;
        private readonly List<PortService> _portServices;
        private string _connectorId;

        /// <summary>
        /// <see cref="PortConnector"/>クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="ports">接続対象のポート</param>
        public PortConnector(params PortService[] ports)
        {
            _portServices = new List<PortService>(ports);

            _profile = new ConnectorProfileHolder();
            _profile.Ports = ports.ToList();

            _profile.DataFlowType = "push";
            _profile.InterfaceType = "corba_cdr";
            _profile.SubscriptionType = "flush";

        }

        /// <summary>
        /// ConnecotrProfileをもとにPortConnectorを作成する
        /// </summary>
        /// <param name="profile">接続情報</param>
        public PortConnector(ConnectorProfileHolder profile)
        {
            _portServices = profile.Ports;
            _profile = profile;
            _connectorId = _profile.ConnectorID;
            IsConnected = true;
        }

        /// <inheritdoc/>
        public IObservable<ReturnCode_t> ConnectAsync()
        {
            if (IsConnected) return Observable.Return(ReturnCode_t.PRECONDITION_NOT_MET);

            var prof = _profile.GetConnectorProfile();
            ReturnCode_t ret = _portServices[0].connect(ref prof);
            _profile = new ConnectorProfileHolder(prof);
            _connectorId = _profile.ConnectorID;
            if (ret == ReturnCode_t.RTC_OK) IsConnected = true;
            //todo:仮実装。
            return Observable.Return(ret);
        }

        /// <inheritdoc/>
        public IObservable<ReturnCode_t> DisconnectAsync()
        {
            if (!IsConnected) return Observable.Return(ReturnCode_t.PRECONDITION_NOT_MET);

            var ret = _portServices[0].disconnect(_connectorId);
            if (ret == ReturnCode_t.RTC_OK)
            {
                IsConnected = false;
                _connectorId = "";
                _profile.ConnectorID = "";

            }
            //todo:仮実装。
            return Observable.Return(ret);
        }

        /// <inheritdoc/>
        public bool IsConnected
        {
            get;
            private set;
        }


    }


}
