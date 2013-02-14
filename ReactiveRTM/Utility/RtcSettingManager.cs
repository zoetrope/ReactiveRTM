using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel.Serialization;

namespace ReactiveRTM.Utility
{
    class RtcSettingManager
    {
        private RtcSetting _setting;

        public RtcSetting RtcSetting
        {
            get { return _setting; }
        }

        public RtcSettingManager(string fileName)
        {
            ParseSetting(fileName);
        }


        private List<string> _defaultSettingFileNames = new List<string> { "rtc.yaml" };
        private void ParseSetting(string fileName)
        {
            var settingFile = fileName;
            if (string.IsNullOrEmpty(settingFile) || !File.Exists(settingFile))
            {
                settingFile = _defaultSettingFileNames.Where(f => File.Exists(f)).FirstOrDefault();
            }

            if (!string.IsNullOrEmpty(settingFile))
            {
                using (var input = new StreamReader(settingFile, Encoding.UTF8))
                {
                    var yamlSerializer = new YamlSerializer<RtcSetting>();
                    _setting = yamlSerializer.Deserialize(input);
                }
            }
            else
            {
                _setting = new RtcSetting();
            }

        }

    }
}
