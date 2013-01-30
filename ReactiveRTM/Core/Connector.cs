using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Core
{

    /// <summary>
    /// データポートやサービスポートの接続を管理するユーティリティクラス
    /// </summary>
    public class PortConnector
    {
        private ConnectorProfile _profile;
        private readonly List<PortServiceStub> _portServices;
        private string _connectorId;

        /// <summary>
        /// <see cref="PortConnector"/>クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="ports">接続対象のポート</param>
        public PortConnector(params PortServiceStub[] ports)
        {
            _portServices = new List<PortService>(ports);

            _profile = new ConnectorProfile();
            _profile.Ports = ports.ToList();

            _profile.DataFlowType = "push";
            _profile.InterfaceType = "corba_cdr";
            _profile.SubscriptionType = "flush";

        }

        /// <summary>
        /// ConnecotrProfileをもとにPortConnectorを作成する
        /// </summary>
        /// <param name="profile">接続情報</param>
        public PortConnector(ConnectorProfile profile)
        {
            _portServices = profile.Ports;
            _profile = profile;
            _connectorId = _profile.ConnectorID;
            IsConnected = true;
        }

        public async Task<ReturnCode_t> ConnectAsync()
        {
            if (IsConnected) return ReturnCode_t.PRECONDITION_NOT_MET;

            var prof = _profile.GetConnectorProfile();
            ReturnCode_t ret = await _portServices[0].ConnectAsync(ref prof);
            _profile = new ConnectorProfileHolder(prof);
            _connectorId = _profile.ConnectorID;
            if (ret == ReturnCode_t.RTC_OK) IsConnected = true;
            //todo:仮実装。
            return ret;
        }

        public async Task<ReturnCode_t> DisconnectAsync()
        {
            if (IsConnected) return ReturnCode_t.PRECONDITION_NOT_MET;

            var ret = await _portServices[0].DisconnectAsync(_connectorId);
            if (ret == ReturnCode_t.RTC_OK)
            {
                IsConnected = false;
                _connectorId = "";
                _profile.ConnectorID = "";

            }
            //todo:仮実装。
            return ret;
        }

        public bool IsConnected
        {
            get;
            private set;
        }


    }


}
