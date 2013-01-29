using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;

 
namespace omg.org.RTC
{
	
     
    public static class PortInterfaceProfileAsyncExtensions : INotifyPropertyChanged
    {
                public System.String InstanceName
        {
            get;
			set;
        }
                public System.String TypeName
        {
            get;
			set;
        }
                public omg.org.RTC.PortInterfacePolarity Polarity
        {
            get;
			set;
        }
            }
     
    public static class ConnectorProfileAsyncExtensions : INotifyPropertyChanged
    {
                public System.String Name
        {
            get;
			set;
        }
                public System.String ConnectorId
        {
            get;
			set;
        }
                public omg.org.RTC.PortService[] Ports
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
     
    public static class PortProfileAsyncExtensions : INotifyPropertyChanged
    {
                public System.String Name
        {
            get;
			set;
        }
                public omg.org.RTC.PortInterfaceProfile[] Interfaces
        {
            get;
			set;
        }
                public omg.org.RTC.PortService PortRef
        {
            get;
			set;
        }
                public omg.org.RTC.ConnectorProfile[] ConnectorProfiles
        {
            get;
			set;
        }
                public omg.org.RTC.RTObject Owner
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
     
    public static class ExecutionContextProfileAsyncExtensions : INotifyPropertyChanged
    {
                public omg.org.RTC.ExecutionKind Kind
        {
            get;
			set;
        }
                public System.Double Rate
        {
            get;
			set;
        }
                public omg.org.RTC.RTObject Owner
        {
            get;
			set;
        }
                public omg.org.RTC.RTObject[] Participants
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
     
    public static class FsmBehaviorProfileAsyncExtensions : INotifyPropertyChanged
    {
                public omg.org.RTC.FsmParticipantAction ActionComponent
        {
            get;
			set;
        }
                public System.String Id
        {
            get;
			set;
        }
            }
     
    public static class FsmProfileAsyncExtensions : INotifyPropertyChanged
    {
                public omg.org.RTC.FsmBehaviorProfile[] BehaviorProfiles
        {
            get;
			set;
        }
            }
     
    public static class ComponentProfileAsyncExtensions : INotifyPropertyChanged
    {
                public System.String InstanceName
        {
            get;
			set;
        }
                public System.String TypeName
        {
            get;
			set;
        }
                public System.String Description
        {
            get;
			set;
        }
                public System.String Version
        {
            get;
			set;
        }
                public System.String Vendor
        {
            get;
			set;
        }
                public System.String Category
        {
            get;
			set;
        }
                public omg.org.RTC.PortProfile[] PortProfiles
        {
            get;
			set;
        }
                public omg.org.RTC.RTObject Parent
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
    }
 
namespace OpenRTM
{
	
     
    public static class LogRecordAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Time
        {
            get;
			set;
        }
                public System.String Loggername
        {
            get;
			set;
        }
                public OpenRTM.LogLevel Level
        {
            get;
			set;
        }
                public System.String Message
        {
            get;
			set;
        }
            }
    }
 
namespace org.omg.SDOPackage
{
	
     
    public static class NameValueAsyncExtensions : INotifyPropertyChanged
    {
                public System.String Name
        {
            get;
			set;
        }
                public System.Object Value
        {
            get;
			set;
        }
            }
     
    public static class EnumerationTypeAsyncExtensions : INotifyPropertyChanged
    {
                public System.String[] EnumeratedValues
        {
            get;
			set;
        }
            }
     
    public static class RangeTypeAsyncExtensions : INotifyPropertyChanged
    {
                public org.omg.SDOPackage.Numeric Min
        {
            get;
			set;
        }
                public org.omg.SDOPackage.Numeric Max
        {
            get;
			set;
        }
                public System.Boolean MinInclusive
        {
            get;
			set;
        }
                public System.Boolean MaxInclusive
        {
            get;
			set;
        }
            }
     
    public static class IntervalTypeAsyncExtensions : INotifyPropertyChanged
    {
                public org.omg.SDOPackage.Numeric Min
        {
            get;
			set;
        }
                public org.omg.SDOPackage.Numeric Max
        {
            get;
			set;
        }
                public System.Boolean MinInclusive
        {
            get;
			set;
        }
                public System.Boolean MaxInclusive
        {
            get;
			set;
        }
                public org.omg.SDOPackage.Numeric Step
        {
            get;
			set;
        }
            }
     
    public static class ParameterAsyncExtensions : INotifyPropertyChanged
    {
                public System.String Name
        {
            get;
			set;
        }
                public omg.org.CORBA.TypeCode Type
        {
            get;
			set;
        }
                public org.omg.SDOPackage.AllowedValues AllowedValues
        {
            get;
			set;
        }
            }
     
    public static class OrganizationPropertyAsyncExtensions : INotifyPropertyChanged
    {
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
     
    public static class DeviceProfileAsyncExtensions : INotifyPropertyChanged
    {
                public System.String DeviceType
        {
            get;
			set;
        }
                public System.String Manufacturer
        {
            get;
			set;
        }
                public System.String Model
        {
            get;
			set;
        }
                public System.String Version
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
     
    public static class ServiceProfileAsyncExtensions : INotifyPropertyChanged
    {
                public System.String Id
        {
            get;
			set;
        }
                public System.String InterfaceType
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
                public org.omg.SDOPackage.SDOService Service
        {
            get;
			set;
        }
            }
     
    public static class ConfigurationSetAsyncExtensions : INotifyPropertyChanged
    {
                public System.String Id
        {
            get;
			set;
        }
                public System.String Description
        {
            get;
			set;
        }
                public org.omg.SDOPackage.NameValue[] ConfigurationData
        {
            get;
			set;
        }
            }
    }
 
namespace RTC
{
	
     
    public static class TimeAsyncExtensions : INotifyPropertyChanged
    {
                public System.Int32 Sec
        {
            get;
			set;
        }
                public System.Int32 Nsec
        {
            get;
			set;
        }
            }
     
    public static class TimedStateAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Data
        {
            get;
			set;
        }
            }
     
    public static class TimedShortAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Data
        {
            get;
			set;
        }
            }
     
    public static class TimedLongAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int32 Data
        {
            get;
			set;
        }
            }
     
    public static class TimedUShortAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Data
        {
            get;
			set;
        }
            }
     
    public static class TimedULongAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int32 Data
        {
            get;
			set;
        }
            }
     
    public static class TimedFloatAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Single Data
        {
            get;
			set;
        }
            }
     
    public static class TimedDoubleAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Double Data
        {
            get;
			set;
        }
            }
     
    public static class TimedCharAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Char Data
        {
            get;
			set;
        }
            }
     
    public static class TimedWCharAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Char Data
        {
            get;
			set;
        }
            }
     
    public static class TimedBooleanAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Boolean Data
        {
            get;
			set;
        }
            }
     
    public static class TimedOctetAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Byte Data
        {
            get;
			set;
        }
            }
     
    public static class TimedStringAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.String Data
        {
            get;
			set;
        }
            }
     
    public static class TimedWStringAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.String Data
        {
            get;
			set;
        }
            }
     
    public static class TimedShortSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedLongSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int32[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedUShortSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedULongSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int32[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedFloatSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Single[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedDoubleSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Double[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedCharSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Char[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedWCharSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Char[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedBooleanSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Boolean[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedOctetSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Byte[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedStringSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.String[] Data
        {
            get;
			set;
        }
            }
     
    public static class TimedWStringSeqAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.String[] Data
        {
            get;
			set;
        }
            }
     
    public static class RGBColourAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double R
        {
            get;
			set;
        }
                public System.Double G
        {
            get;
			set;
        }
                public System.Double B
        {
            get;
			set;
        }
            }
     
    public static class Point2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double X
        {
            get;
			set;
        }
                public System.Double Y
        {
            get;
			set;
        }
            }
     
    public static class Vector2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double X
        {
            get;
			set;
        }
                public System.Double Y
        {
            get;
			set;
        }
            }
     
    public static class Pose2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Point2D Position
        {
            get;
			set;
        }
                public System.Double Heading
        {
            get;
			set;
        }
            }
     
    public static class Velocity2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Vx
        {
            get;
			set;
        }
                public System.Double Vy
        {
            get;
			set;
        }
                public System.Double Va
        {
            get;
			set;
        }
            }
     
    public static class Acceleration2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Ax
        {
            get;
			set;
        }
                public System.Double Ay
        {
            get;
			set;
        }
            }
     
    public static class PoseVel2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose2D Pose
        {
            get;
			set;
        }
                public RTC.Velocity2D Velocities
        {
            get;
			set;
        }
            }
     
    public static class Size2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double L
        {
            get;
			set;
        }
                public System.Double W
        {
            get;
			set;
        }
            }
     
    public static class Geometry2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose2D Pose
        {
            get;
			set;
        }
                public RTC.Size2D Size
        {
            get;
			set;
        }
            }
     
    public static class Covariance2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Xx
        {
            get;
			set;
        }
                public System.Double Xy
        {
            get;
			set;
        }
                public System.Double Xt
        {
            get;
			set;
        }
                public System.Double Yy
        {
            get;
			set;
        }
                public System.Double Yt
        {
            get;
			set;
        }
                public System.Double Tt
        {
            get;
			set;
        }
            }
     
    public static class PointCovariance2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Xx
        {
            get;
			set;
        }
                public System.Double Xy
        {
            get;
			set;
        }
                public System.Double Yy
        {
            get;
			set;
        }
            }
     
    public static class CarlikeAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Speed
        {
            get;
			set;
        }
                public System.Double SteeringAngle
        {
            get;
			set;
        }
            }
     
    public static class SpeedHeading2DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Speed
        {
            get;
			set;
        }
                public System.Double Heading
        {
            get;
			set;
        }
            }
     
    public static class Point3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double X
        {
            get;
			set;
        }
                public System.Double Y
        {
            get;
			set;
        }
                public System.Double Z
        {
            get;
			set;
        }
            }
     
    public static class Vector3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double X
        {
            get;
			set;
        }
                public System.Double Y
        {
            get;
			set;
        }
                public System.Double Z
        {
            get;
			set;
        }
            }
     
    public static class Orientation3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double R
        {
            get;
			set;
        }
                public System.Double P
        {
            get;
			set;
        }
                public System.Double Y
        {
            get;
			set;
        }
            }
     
    public static class Pose3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Point3D Position
        {
            get;
			set;
        }
                public RTC.Orientation3D Orientation
        {
            get;
			set;
        }
            }
     
    public static class Velocity3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Vx
        {
            get;
			set;
        }
                public System.Double Vy
        {
            get;
			set;
        }
                public System.Double Vz
        {
            get;
			set;
        }
                public System.Double Vr
        {
            get;
			set;
        }
                public System.Double Vp
        {
            get;
			set;
        }
                public System.Double Va
        {
            get;
			set;
        }
            }
     
    public static class AngularVelocity3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Avx
        {
            get;
			set;
        }
                public System.Double Avy
        {
            get;
			set;
        }
                public System.Double Avz
        {
            get;
			set;
        }
            }
     
    public static class Acceleration3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Ax
        {
            get;
			set;
        }
                public System.Double Ay
        {
            get;
			set;
        }
                public System.Double Az
        {
            get;
			set;
        }
            }
     
    public static class AngularAcceleration3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Aax
        {
            get;
			set;
        }
                public System.Double Aay
        {
            get;
			set;
        }
                public System.Double Aaz
        {
            get;
			set;
        }
            }
     
    public static class PoseVel3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose3D Pose
        {
            get;
			set;
        }
                public RTC.Velocity3D Velocities
        {
            get;
			set;
        }
            }
     
    public static class Size3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double L
        {
            get;
			set;
        }
                public System.Double W
        {
            get;
			set;
        }
                public System.Double H
        {
            get;
			set;
        }
            }
     
    public static class Geometry3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose3D Pose
        {
            get;
			set;
        }
                public RTC.Size3D Size
        {
            get;
			set;
        }
            }
     
    public static class Covariance3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Xx
        {
            get;
			set;
        }
                public System.Double Xy
        {
            get;
			set;
        }
                public System.Double Xz
        {
            get;
			set;
        }
                public System.Double Xr
        {
            get;
			set;
        }
                public System.Double Xp
        {
            get;
			set;
        }
                public System.Double Xa
        {
            get;
			set;
        }
                public System.Double Yy
        {
            get;
			set;
        }
                public System.Double Yz
        {
            get;
			set;
        }
                public System.Double Yr
        {
            get;
			set;
        }
                public System.Double Yp
        {
            get;
			set;
        }
                public System.Double Ya
        {
            get;
			set;
        }
                public System.Double Zz
        {
            get;
			set;
        }
                public System.Double Zr
        {
            get;
			set;
        }
                public System.Double Zp
        {
            get;
			set;
        }
                public System.Double Za
        {
            get;
			set;
        }
                public System.Double Rr
        {
            get;
			set;
        }
                public System.Double Rp
        {
            get;
			set;
        }
                public System.Double Ra
        {
            get;
			set;
        }
                public System.Double Pp
        {
            get;
			set;
        }
                public System.Double Pa
        {
            get;
			set;
        }
                public System.Double Aa
        {
            get;
			set;
        }
            }
     
    public static class SpeedHeading3DAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Speed
        {
            get;
			set;
        }
                public RTC.Orientation3D Direction
        {
            get;
			set;
        }
            }
     
    public static class OAPAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Vector3D Orientation
        {
            get;
			set;
        }
                public RTC.Vector3D Approach
        {
            get;
			set;
        }
                public RTC.Vector3D Position
        {
            get;
			set;
        }
            }
     
    public static class TimedRGBColourAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.RGBColour Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPoint2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Point2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedVector2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Vector2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPose2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Pose2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedVelocity2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Velocity2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedAcceleration2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Acceleration2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPoseVel2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.PoseVel2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedSize2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Size2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedGeometry2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Geometry2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedCovariance2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Covariance2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPointCovariance2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.PointCovariance2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedCarlikeAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Carlike Data
        {
            get;
			set;
        }
            }
     
    public static class TimedSpeedHeading2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.SpeedHeading2D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPoint3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Point3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedVector3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Vector3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedOrientation3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Orientation3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPose3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Pose3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedVelocity3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Velocity3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedAngularVelocity3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.AngularVelocity3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedAcceleration3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Acceleration3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedAngularAcceleration3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.AngularAcceleration3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedPoseVel3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.PoseVel3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedSize3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Size3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedGeometry3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Geometry3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedCovariance3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Covariance3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedSpeedHeading3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.SpeedHeading3D Data
        {
            get;
			set;
        }
            }
     
    public static class TimedOAPAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.OAP Data
        {
            get;
			set;
        }
            }
     
    public static class ActArrayActuatorPosAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Index
        {
            get;
			set;
        }
                public System.Double Position
        {
            get;
			set;
        }
            }
     
    public static class ActArrayActuatorSpeedAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Index
        {
            get;
			set;
        }
                public System.Double Speed
        {
            get;
			set;
        }
            }
     
    public static class ActArrayActuatorCurrentAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Index
        {
            get;
			set;
        }
                public System.Double Current
        {
            get;
			set;
        }
            }
     
    public static class ActuatorAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Position
        {
            get;
			set;
        }
                public System.Double Speed
        {
            get;
			set;
        }
                public System.Double Accel
        {
            get;
			set;
        }
                public System.Double Current
        {
            get;
			set;
        }
                public RTC.ActArrayActuatorStatus Status
        {
            get;
			set;
        }
            }
     
    public static class ActArrayStateAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Actuator[] Actuators
        {
            get;
			set;
        }
            }
     
    public static class ActArrayActuatorGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.ActArrayActuatorType Type
        {
            get;
			set;
        }
                public System.Double Length
        {
            get;
			set;
        }
                public RTC.Orientation3D Orientation
        {
            get;
			set;
        }
                public RTC.Vector3D Axis
        {
            get;
			set;
        }
                public System.Double MinRange
        {
            get;
			set;
        }
                public System.Double Centre
        {
            get;
			set;
        }
                public System.Double MaxRange
        {
            get;
			set;
        }
                public System.Double HomePosition
        {
            get;
			set;
        }
                public System.Boolean HasBrakes
        {
            get;
			set;
        }
            }
     
    public static class ActArrayGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Geometry3D ArrayGeometry
        {
            get;
			set;
        }
                public RTC.ActArrayActuatorGeometry[] ActuatorGeometry
        {
            get;
			set;
        }
            }
     
    public static class BumperGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose3D Pose
        {
            get;
			set;
        }
                public RTC.Size3D Size
        {
            get;
			set;
        }
                public System.Double Roc
        {
            get;
			set;
        }
            }
     
    public static class BumperArrayGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Geometry3D ArrayGeometry
        {
            get;
			set;
        }
                public RTC.BumperGeometry[] BumperGeometry
        {
            get;
			set;
        }
            }
     
    public static class CameraImageAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Int16 Width
        {
            get;
			set;
        }
                public System.Int16 Height
        {
            get;
			set;
        }
                public System.Int16 Bpp
        {
            get;
			set;
        }
                public System.String Format
        {
            get;
			set;
        }
                public System.Double FDiv
        {
            get;
			set;
        }
                public System.Byte[] Pixels
        {
            get;
			set;
        }
            }
     
    public static class CameraInfoAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Vector2D FocalLength
        {
            get;
			set;
        }
                public RTC.Point2D PrincipalPoint
        {
            get;
			set;
        }
                public System.Double K1
        {
            get;
			set;
        }
                public System.Double K2
        {
            get;
			set;
        }
                public System.Double P1
        {
            get;
			set;
        }
                public System.Double P2
        {
            get;
			set;
        }
            }
     
    public static class FiducialInfoAsyncExtensions : INotifyPropertyChanged
    {
                public System.Int32 Id
        {
            get;
			set;
        }
                public RTC.Pose3D Pose
        {
            get;
			set;
        }
                public RTC.Pose3D PoseUncertainty
        {
            get;
			set;
        }
                public RTC.Size3D Size
        {
            get;
			set;
        }
                public RTC.Size3D SizeUncertainty
        {
            get;
			set;
        }
            }
     
    public static class FiducialsAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.FiducialInfo[] FiducialsList
        {
            get;
			set;
        }
            }
     
    public static class FiducialFOVAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double MinRange
        {
            get;
			set;
        }
                public System.Double MaxRange
        {
            get;
			set;
        }
                public System.Double ViewAngle
        {
            get;
			set;
        }
            }
     
    public static class GPSTimeAsyncExtensions : INotifyPropertyChanged
    {
                public System.Int32 Sec
        {
            get;
			set;
        }
                public System.Int32 Msec
        {
            get;
			set;
        }
            }
     
    public static class GPSDataAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.GPSTime TimeFromGPS
        {
            get;
			set;
        }
                public System.Double Latitude
        {
            get;
			set;
        }
                public System.Double Longitude
        {
            get;
			set;
        }
                public System.Double Altitude
        {
            get;
			set;
        }
                public System.Double HorizontalError
        {
            get;
			set;
        }
                public System.Double VerticalError
        {
            get;
			set;
        }
                public System.Double Heading
        {
            get;
			set;
        }
                public System.Double HorizontalSpeed
        {
            get;
			set;
        }
                public System.Double VerticalSpeed
        {
            get;
			set;
        }
                public System.Int16 NumSatellites
        {
            get;
			set;
        }
                public RTC.GPSFixType FixType
        {
            get;
			set;
        }
            }
     
    public static class GripperStateAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.GripperStatus Status
        {
            get;
			set;
        }
            }
     
    public static class GripperGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Geometry3D Exterior
        {
            get;
			set;
        }
                public RTC.Geometry3D Interior
        {
            get;
			set;
        }
            }
     
    public static class INSDataAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Double Latitude
        {
            get;
			set;
        }
                public System.Double Longitude
        {
            get;
			set;
        }
                public System.Double Altitude
        {
            get;
			set;
        }
                public System.Double HeightAMSL
        {
            get;
			set;
        }
                public RTC.Velocity3D VelocityENU
        {
            get;
			set;
        }
                public RTC.Orientation3D Orientation
        {
            get;
			set;
        }
            }
     
    public static class LimbStateAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.OAP OapMatrix
        {
            get;
			set;
        }
                public RTC.LimbStatus Status
        {
            get;
			set;
        }
            }
     
    public static class Hypothesis2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose2D Mean
        {
            get;
			set;
        }
                public RTC.Covariance2D Covariance
        {
            get;
			set;
        }
                public System.Double Weight
        {
            get;
			set;
        }
            }
     
    public static class Hypotheses2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Hypothesis2D[] Hypotheses
        {
            get;
			set;
        }
            }
     
    public static class Hypothesis3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose3D Mean
        {
            get;
			set;
        }
                public RTC.Covariance3D Covariance
        {
            get;
			set;
        }
                public System.Double Weight
        {
            get;
			set;
        }
            }
     
    public static class Hypotheses3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Hypothesis3D[] Hypotheses
        {
            get;
			set;
        }
            }
     
    public static class OGMapConfigAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double XScale
        {
            get;
			set;
        }
                public System.Double YScale
        {
            get;
			set;
        }
                public System.Int32 Width
        {
            get;
			set;
        }
                public System.Int32 Height
        {
            get;
			set;
        }
                public RTC.Pose2D Origin
        {
            get;
			set;
        }
            }
     
    public static class OGMapTileAsyncExtensions : INotifyPropertyChanged
    {
                public System.Int32 Column
        {
            get;
			set;
        }
                public System.Int32 Row
        {
            get;
			set;
        }
                public System.Int32 Width
        {
            get;
			set;
        }
                public System.Int32 Height
        {
            get;
			set;
        }
                public System.Byte[] Cells
        {
            get;
			set;
        }
            }
     
    public static class PointFeatureAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Probability
        {
            get;
			set;
        }
                public RTC.Point2D Position
        {
            get;
			set;
        }
                public RTC.PointCovariance2D Covariance
        {
            get;
			set;
        }
            }
     
    public static class PoseFeatureAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Probability
        {
            get;
			set;
        }
                public RTC.Pose2D Position
        {
            get;
			set;
        }
                public RTC.Covariance2D Covariance
        {
            get;
			set;
        }
            }
     
    public static class LineFeatureAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double Probability
        {
            get;
			set;
        }
                public System.Double Rho
        {
            get;
			set;
        }
                public System.Double Alpha
        {
            get;
			set;
        }
                public RTC.PointCovariance2D Covariance
        {
            get;
			set;
        }
                public RTC.Point2D Start
        {
            get;
			set;
        }
                public RTC.Point2D End
        {
            get;
			set;
        }
                public System.Boolean StartSighted
        {
            get;
			set;
        }
                public System.Boolean EndSighted
        {
            get;
			set;
        }
            }
     
    public static class FeaturesAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.PointFeature[] PointFeatures
        {
            get;
			set;
        }
                public RTC.PoseFeature[] PoseFeatures
        {
            get;
			set;
        }
                public RTC.LineFeature[] LineFeatures
        {
            get;
			set;
        }
            }
     
    public static class MultiCameraImagesAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.CameraImage[] Images
        {
            get;
			set;
        }
            }
     
    public static class MulticameraGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Geometry3D Geometry
        {
            get;
			set;
        }
                public RTC.Geometry3D[] CameraGeometries
        {
            get;
			set;
        }
            }
     
    public static class Waypoint2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose2D Target
        {
            get;
			set;
        }
                public System.Double DistanceTolerance
        {
            get;
			set;
        }
                public System.Double HeadingTolerance
        {
            get;
			set;
        }
                public RTC.Time TimeLimit
        {
            get;
			set;
        }
                public RTC.Velocity2D MaxSpeed
        {
            get;
			set;
        }
            }
     
    public static class Path2DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Waypoint2D[] Waypoints
        {
            get;
			set;
        }
            }
     
    public static class Waypoint3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Pose3D Target
        {
            get;
			set;
        }
                public System.Double DistanceTolerance
        {
            get;
			set;
        }
                public System.Double HeadingTolerance
        {
            get;
			set;
        }
                public RTC.Time TimeLimit
        {
            get;
			set;
        }
                public RTC.Velocity3D MaxSpeed
        {
            get;
			set;
        }
            }
     
    public static class Path3DAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.Waypoint3D[] Waypoints
        {
            get;
			set;
        }
            }
     
    public static class PointCloudPointAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Point3D Point
        {
            get;
			set;
        }
                public RTC.RGBColour Colour
        {
            get;
			set;
        }
            }
     
    public static class PointCloudAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.PointCloudPoint[] Points
        {
            get;
			set;
        }
            }
     
    public static class PanTiltAnglesAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Double Pan
        {
            get;
			set;
        }
                public System.Double Tilt
        {
            get;
			set;
        }
            }
     
    public static class PanTiltStateAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public RTC.PanTiltAngles Angles
        {
            get;
			set;
        }
                public System.Double PanSpeed
        {
            get;
			set;
        }
                public System.Double TiltSpeed
        {
            get;
			set;
        }
            }
     
    public static class RangerGeometryAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Geometry3D Geometry
        {
            get;
			set;
        }
                public RTC.Geometry3D[] ElementGeometries
        {
            get;
			set;
        }
            }
     
    public static class RangerConfigAsyncExtensions : INotifyPropertyChanged
    {
                public System.Double MinAngle
        {
            get;
			set;
        }
                public System.Double MaxAngle
        {
            get;
			set;
        }
                public System.Double AngularRes
        {
            get;
			set;
        }
                public System.Double MinRange
        {
            get;
			set;
        }
                public System.Double MaxRange
        {
            get;
			set;
        }
                public System.Double RangeRes
        {
            get;
			set;
        }
                public System.Double Frequency
        {
            get;
			set;
        }
            }
     
    public static class RangeDataAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Double[] Ranges
        {
            get;
			set;
        }
                public RTC.RangerGeometry Geometry
        {
            get;
			set;
        }
                public RTC.RangerConfig Config
        {
            get;
			set;
        }
            }
     
    public static class IntensityDataAsyncExtensions : INotifyPropertyChanged
    {
                public RTC.Time Tm
        {
            get;
			set;
        }
                public System.Double[] Intensities
        {
            get;
			set;
        }
                public RTC.RangerGeometry Geometry
        {
            get;
			set;
        }
                public RTC.RangerConfig Config
        {
            get;
			set;
        }
            }
    }
 
namespace RTM
{
	
     
    public static class ModuleProfileAsyncExtensions : INotifyPropertyChanged
    {
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
     
    public static class ManagerProfileAsyncExtensions : INotifyPropertyChanged
    {
                public org.omg.SDOPackage.NameValue[] Properties
        {
            get;
			set;
        }
            }
    }
