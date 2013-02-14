using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Utility
{
    public class RunOption
    {
        public static RunOption Parse(IEnumerable<string> args)
        {
            var opt = new RunOption();

            var p = new OptionSet() {
                { "f|file=",      v => opt.SettingFileName = v },
                { "v|version",  v => opt.Version = true },
                { "h|?|help",   v => opt.Help = v != null },
            };
            opt.Extra = p.Parse(args);

            return opt;

        }

        public string SettingFileName { get; set; }
        public bool Help { get; set; }
        public bool Version { get; set; }

        public List<string> Extra { get; set; }
    }
}
