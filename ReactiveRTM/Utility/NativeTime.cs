using System.Runtime.InteropServices;

namespace ReactiveRTM.Utility
{
    public static class NativeTime
    {
        [DllImport("winmm.dll", EntryPoint = "timeGetTime")]
        public static extern uint GetTime();

        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
        public static extern uint BeginPeriod(uint uMilliseconds);

        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod")]
        public static extern uint EndPeriod(uint uMilliseconds);
    }
}
