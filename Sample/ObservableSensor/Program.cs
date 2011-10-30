using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using Microsoft.Research.Kinect.Nui;

/// <summary>
/// センサを監視するサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        var runtime = new Runtime();
        runtime.Initialize(RuntimeOptions.UseSkeletalTracking);


        var observer = runtime.SkeletonFrameReadyAsObservable();

        
    }

}

internal static class KinectExtensions
{
    public static IObservable<SkeletonFrameReadyEventArgs> SkeletonFrameReadyAsObservable(this Runtime nui)
    {
        return Observable.FromEventPattern<SkeletonFrameReadyEventArgs>(
                    h => nui.SkeletonFrameReady += h,
                    h => nui.SkeletonFrameReady -= h)
               .Select(e => e.EventArgs);
    }
}
