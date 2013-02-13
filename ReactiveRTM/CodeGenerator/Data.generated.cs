using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Data;
using ReactiveRTM.Generated;

 
namespace ReactiveRTM.CORBA
{
    public enum TCKind
    {
        tk_null = 0,
        tk_void = 1,
        tk_short = 2,
        tk_long = 3,
        tk_ushort = 4,
        tk_ulong = 5,
        tk_float = 6,
        tk_double = 7,
        tk_boolean = 8,
        tk_char = 9,
        tk_octet = 10,
        tk_any = 11,
        tk_TypeCode = 12,
        tk_Principal = 13,
        tk_objref = 14,
        tk_struct = 15,
        tk_union = 16,
        tk_enum = 17,
        tk_string = 18,
        tk_sequence = 19,
        tk_array = 20,
        tk_alias = 21,
        tk_except = 22,
        tk_longlong = 23,
        tk_ulonglong = 24,
        tk_longdouble = 25,
        tk_wchar = 26,
        tk_wstring = 27,
        tk_fixed = 28,
        tk_value = 29,
        tk_value_box = 30,
        tk_native = 31,
        tk_abstract_interface = 32,
        tk_local_interface = 33,
    }
    
}
 
namespace ReactiveRTM.OpenRTM
{
    public enum StatusKind
    {
        COMPONENT_PROFILE = 0,
        RTC_STATUS = 1,
        EC_STATUS = 2,
        PORT_PROFILE = 3,
        CONFIGURATION = 4,
        HEARTBEAT = 5,
        STATUS_KIND_NUM = 6,
    }
    public enum PortStatus
    {
        PORT_OK = 0,
        PORT_ERROR = 1,
        BUFFER_FULL = 2,
        BUFFER_EMPTY = 3,
        BUFFER_TIMEOUT = 4,
        UNKNOWN_ERROR = 5,
    }
    public enum LogLevel
    {
        SILENT = 0,
        ERROR = 1,
        WARN = 2,
        INFO = 3,
        NORMAL = 4,
        DEBUG = 5,
        TRACE = 6,
        VERBOSE = 7,
        PARANOID = 8,
    }
    
 
    public class LogRecord : NotifyPropertyChangedBase
    {
        private System.DateTime _Time;
            
        ///<exclude/>
        public System.DateTime Time
        {
            get { return _Time; }
            set 
            {
                if(!(_Time.Equals(value)))
                {
                    _Time = value;
                    RaisePropertyChanged("Time");
                }
            }
        }
        private System.String _Loggername;
            
        ///<exclude/>
        public System.String Loggername
        {
            get { return _Loggername; }
            set 
            {
                if(!(_Loggername == (value)))
                {
                    _Loggername = value;
                    RaisePropertyChanged("Loggername");
                }
            }
        }
        private ReactiveRTM.OpenRTM.LogLevel _Level;
            
        ///<exclude/>
        public ReactiveRTM.OpenRTM.LogLevel Level
        {
            get { return _Level; }
            set 
            {
                if(!(_Level.Equals(value)))
                {
                    _Level = value;
                    RaisePropertyChanged("Level");
                }
            }
        }
        private System.String _Message;
            
        ///<exclude/>
        public System.String Message
        {
            get { return _Message; }
            set 
            {
                if(!(_Message == (value)))
                {
                    _Message = value;
                    RaisePropertyChanged("Message");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::OpenRTM.LogRecord (ReactiveRTM.OpenRTM.LogRecord source)
        {
            var instance = new global::OpenRTM.LogRecord();
            instance.time =  Converter.DateTimeToRtcTime(source._Time);
            instance.loggername =  source._Loggername;
            instance.level =  (global::OpenRTM.LogLevel)source._Level;
            instance.message =  source._Message;
            return instance;
        }
        public LogRecord ()
        {
            _Time = default(System.DateTime);
            _Loggername = string.Empty;
            _Level = new ReactiveRTM.OpenRTM.LogLevel();
            _Message = string.Empty;
        }
        public LogRecord (global::OpenRTM.LogRecord source)
        {
            _Time = Converter.RtcTimeToDateTime(source.time);
            _Loggername = source.loggername;
            _Level = (ReactiveRTM.OpenRTM.LogLevel)source.level;
            _Message = source.message;
        }

        ///<exclude/>
        public bool Equals(LogRecord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Time.Equals(_Time) && other._Loggername == (_Loggername) && other._Level.Equals(_Level) && other._Message == (_Message);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(LogRecord)) return false;
            return Equals((LogRecord)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Time.GetHashCode();
                result = (result * 397) ^ _Loggername.GetHashCode();
                result = (result * 397) ^ _Level.GetHashCode();
                result = (result * 397) ^ _Message.GetHashCode();
                return result;
            }
        }
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    
}
 
namespace ReactiveRTM.RTC
{
    public enum ActArrayActuatorStatus
    {
        ACTUATOR_STATUS_IDLE = 0,
        ACTUATOR_STATUS_MOVING = 1,
        ACTUATOR_STATUS_BRAKED = 2,
        ACTUATOR_STATUS_STALLED = 3,
    }
    public enum ActArrayActuatorType
    {
        ACTARRAY_ACTUATORTYPE_LINEAR = 0,
        ACTARRAY_ACTUATORTYPE_ROTARY = 1,
    }
    public enum GPSFixType
    {
        GPS_FIX_NONE = 0,
        GPS_FIX_NORMAL = 1,
        GPS_FIX_DGPS = 2,
    }
    public enum GripperStatus
    {
        GRIPPER_STATE_OPEN = 0,
        GRIPPER_STATE_CLOSED = 1,
        GRIPPER_STATE_MOVING = 2,
        GRIPPER_STATE_UNKNOWN = 3,
    }
    public enum LimbStatus
    {
        LIMB_STATUS_IDLE = 0,
        LIMB_STATUS_BRAKED = 1,
        LIMB_STATUS_MOVING = 2,
        LIMB_STATUS_OOR = 3,
        LIMB_STATUS_COLLISION = 4,
    }
    
 
    public class Time : NotifyPropertyChangedBase
    {
        private System.Int32 _Sec;
            
        ///<exclude/>
        public System.Int32 Sec
        {
            get { return _Sec; }
            set 
            {
                if(!(_Sec.Equals(value)))
                {
                    _Sec = value;
                    RaisePropertyChanged("Sec");
                }
            }
        }
        private System.Int32 _Nsec;
            
        ///<exclude/>
        public System.Int32 Nsec
        {
            get { return _Nsec; }
            set 
            {
                if(!(_Nsec.Equals(value)))
                {
                    _Nsec = value;
                    RaisePropertyChanged("Nsec");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Time (ReactiveRTM.RTC.Time source)
        {
            var instance = new global::RTC.Time();
            instance.sec =  source._Sec;
            instance.nsec =  source._Nsec;
            return instance;
        }
        public Time ()
        {
            _Sec = new System.Int32();
            _Nsec = new System.Int32();
        }
        public Time (global::RTC.Time source)
        {
            _Sec = source.sec;
            _Nsec = source.nsec;
        }

        ///<exclude/>
        public bool Equals(Time other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Sec.Equals(_Sec) && other._Nsec.Equals(_Nsec);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Time)) return false;
            return Equals((Time)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Sec.GetHashCode();
                result = (result * 397) ^ _Nsec.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedState : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Data;
            
        ///<exclude/>
        public System.Int16 Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedState (ReactiveRTM.RTC.TimedState source)
        {
            var instance = new global::RTC.TimedState();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedState ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Int16();
        }
        public TimedState (global::RTC.TimedState source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedState other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedState)) return false;
            return Equals((TimedState)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedShort : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Data;
            
        ///<exclude/>
        public System.Int16 Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedShort (ReactiveRTM.RTC.TimedShort source)
        {
            var instance = new global::RTC.TimedShort();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedShort ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Int16();
        }
        public TimedShort (global::RTC.TimedShort source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedShort other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedShort)) return false;
            return Equals((TimedShort)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedLong : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int32 _Data;
            
        ///<exclude/>
        public System.Int32 Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedLong (ReactiveRTM.RTC.TimedLong source)
        {
            var instance = new global::RTC.TimedLong();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedLong ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Int32();
        }
        public TimedLong (global::RTC.TimedLong source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedLong other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedLong)) return false;
            return Equals((TimedLong)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedUShort : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Data;
            
        ///<exclude/>
        public System.Int16 Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedUShort (ReactiveRTM.RTC.TimedUShort source)
        {
            var instance = new global::RTC.TimedUShort();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedUShort ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Int16();
        }
        public TimedUShort (global::RTC.TimedUShort source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedUShort other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedUShort)) return false;
            return Equals((TimedUShort)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedULong : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int32 _Data;
            
        ///<exclude/>
        public System.Int32 Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedULong (ReactiveRTM.RTC.TimedULong source)
        {
            var instance = new global::RTC.TimedULong();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedULong ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Int32();
        }
        public TimedULong (global::RTC.TimedULong source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedULong other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedULong)) return false;
            return Equals((TimedULong)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedFloat : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Single _Data;
            
        ///<exclude/>
        public System.Single Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedFloat (ReactiveRTM.RTC.TimedFloat source)
        {
            var instance = new global::RTC.TimedFloat();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedFloat ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Single();
        }
        public TimedFloat (global::RTC.TimedFloat source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedFloat other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedFloat)) return false;
            return Equals((TimedFloat)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedDouble : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Double _Data;
            
        ///<exclude/>
        public System.Double Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedDouble (ReactiveRTM.RTC.TimedDouble source)
        {
            var instance = new global::RTC.TimedDouble();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedDouble ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Double();
        }
        public TimedDouble (global::RTC.TimedDouble source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedDouble other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedDouble)) return false;
            return Equals((TimedDouble)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedChar : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Char _Data;
            
        ///<exclude/>
        public System.Char Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedChar (ReactiveRTM.RTC.TimedChar source)
        {
            var instance = new global::RTC.TimedChar();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedChar ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Char();
        }
        public TimedChar (global::RTC.TimedChar source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedChar other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedChar)) return false;
            return Equals((TimedChar)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedWChar : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Char _Data;
            
        ///<exclude/>
        public System.Char Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedWChar (ReactiveRTM.RTC.TimedWChar source)
        {
            var instance = new global::RTC.TimedWChar();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedWChar ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Char();
        }
        public TimedWChar (global::RTC.TimedWChar source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedWChar other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedWChar)) return false;
            return Equals((TimedWChar)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedBoolean : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Boolean _Data;
            
        ///<exclude/>
        public System.Boolean Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedBoolean (ReactiveRTM.RTC.TimedBoolean source)
        {
            var instance = new global::RTC.TimedBoolean();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedBoolean ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Boolean();
        }
        public TimedBoolean (global::RTC.TimedBoolean source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedBoolean other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedBoolean)) return false;
            return Equals((TimedBoolean)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedOctet : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Byte _Data;
            
        ///<exclude/>
        public System.Byte Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedOctet (ReactiveRTM.RTC.TimedOctet source)
        {
            var instance = new global::RTC.TimedOctet();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedOctet ()
        {
            _Tm = default(System.DateTime);
            _Data = new System.Byte();
        }
        public TimedOctet (global::RTC.TimedOctet source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedOctet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedOctet)) return false;
            return Equals((TimedOctet)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedString : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.String _Data;
            
        ///<exclude/>
        public System.String Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data == (value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedString (ReactiveRTM.RTC.TimedString source)
        {
            var instance = new global::RTC.TimedString();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedString ()
        {
            _Tm = default(System.DateTime);
            _Data = string.Empty;
        }
        public TimedString (global::RTC.TimedString source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedString other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data == (_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedString)) return false;
            return Equals((TimedString)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedWString : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.String _Data;
            
        ///<exclude/>
        public System.String Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data == (value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedWString (ReactiveRTM.RTC.TimedWString source)
        {
            var instance = new global::RTC.TimedWString();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data;
            return instance;
        }
        public TimedWString ()
        {
            _Tm = default(System.DateTime);
            _Data = string.Empty;
        }
        public TimedWString (global::RTC.TimedWString source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data;
        }

        ///<exclude/>
        public bool Equals(TimedWString other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data == (_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedWString)) return false;
            return Equals((TimedWString)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedShortSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Int16> _Data;
            
        ///<exclude/>
        public List<System.Int16> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedShortSeq (ReactiveRTM.RTC.TimedShortSeq source)
        {
            var instance = new global::RTC.TimedShortSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedShortSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Int16>();
        }
        public TimedShortSeq (global::RTC.TimedShortSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Int16)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedShortSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedShortSeq)) return false;
            return Equals((TimedShortSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedLongSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Int32> _Data;
            
        ///<exclude/>
        public List<System.Int32> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedLongSeq (ReactiveRTM.RTC.TimedLongSeq source)
        {
            var instance = new global::RTC.TimedLongSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedLongSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Int32>();
        }
        public TimedLongSeq (global::RTC.TimedLongSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Int32)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedLongSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedLongSeq)) return false;
            return Equals((TimedLongSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedUShortSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Int16> _Data;
            
        ///<exclude/>
        public List<System.Int16> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedUShortSeq (ReactiveRTM.RTC.TimedUShortSeq source)
        {
            var instance = new global::RTC.TimedUShortSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedUShortSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Int16>();
        }
        public TimedUShortSeq (global::RTC.TimedUShortSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Int16)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedUShortSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedUShortSeq)) return false;
            return Equals((TimedUShortSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedULongSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Int32> _Data;
            
        ///<exclude/>
        public List<System.Int32> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedULongSeq (ReactiveRTM.RTC.TimedULongSeq source)
        {
            var instance = new global::RTC.TimedULongSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedULongSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Int32>();
        }
        public TimedULongSeq (global::RTC.TimedULongSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Int32)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedULongSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedULongSeq)) return false;
            return Equals((TimedULongSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedFloatSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Single> _Data;
            
        ///<exclude/>
        public List<System.Single> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedFloatSeq (ReactiveRTM.RTC.TimedFloatSeq source)
        {
            var instance = new global::RTC.TimedFloatSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedFloatSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Single>();
        }
        public TimedFloatSeq (global::RTC.TimedFloatSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Single)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedFloatSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedFloatSeq)) return false;
            return Equals((TimedFloatSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedDoubleSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Double> _Data;
            
        ///<exclude/>
        public List<System.Double> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedDoubleSeq (ReactiveRTM.RTC.TimedDoubleSeq source)
        {
            var instance = new global::RTC.TimedDoubleSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedDoubleSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Double>();
        }
        public TimedDoubleSeq (global::RTC.TimedDoubleSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Double)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedDoubleSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedDoubleSeq)) return false;
            return Equals((TimedDoubleSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedCharSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Char> _Data;
            
        ///<exclude/>
        public List<System.Char> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedCharSeq (ReactiveRTM.RTC.TimedCharSeq source)
        {
            var instance = new global::RTC.TimedCharSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedCharSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Char>();
        }
        public TimedCharSeq (global::RTC.TimedCharSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Char)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedCharSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedCharSeq)) return false;
            return Equals((TimedCharSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedWCharSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Char> _Data;
            
        ///<exclude/>
        public List<System.Char> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedWCharSeq (ReactiveRTM.RTC.TimedWCharSeq source)
        {
            var instance = new global::RTC.TimedWCharSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedWCharSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Char>();
        }
        public TimedWCharSeq (global::RTC.TimedWCharSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Char)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedWCharSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedWCharSeq)) return false;
            return Equals((TimedWCharSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedBooleanSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Boolean> _Data;
            
        ///<exclude/>
        public List<System.Boolean> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedBooleanSeq (ReactiveRTM.RTC.TimedBooleanSeq source)
        {
            var instance = new global::RTC.TimedBooleanSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedBooleanSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Boolean>();
        }
        public TimedBooleanSeq (global::RTC.TimedBooleanSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Boolean)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedBooleanSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedBooleanSeq)) return false;
            return Equals((TimedBooleanSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedOctetSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Byte> _Data;
            
        ///<exclude/>
        public List<System.Byte> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedOctetSeq (ReactiveRTM.RTC.TimedOctetSeq source)
        {
            var instance = new global::RTC.TimedOctetSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedOctetSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.Byte>();
        }
        public TimedOctetSeq (global::RTC.TimedOctetSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.Byte)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedOctetSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedOctetSeq)) return false;
            return Equals((TimedOctetSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedStringSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.String> _Data;
            
        ///<exclude/>
        public List<System.String> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedStringSeq (ReactiveRTM.RTC.TimedStringSeq source)
        {
            var instance = new global::RTC.TimedStringSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedStringSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.String>();
        }
        public TimedStringSeq (global::RTC.TimedStringSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.String)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedStringSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedStringSeq)) return false;
            return Equals((TimedStringSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class TimedWStringSeq : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.String> _Data;
            
        ///<exclude/>
        public List<System.String> Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.SequenceEqual(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedWStringSeq (ReactiveRTM.RTC.TimedWStringSeq source)
        {
            var instance = new global::RTC.TimedWStringSeq();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  source._Data.Select(x=>x).ToArray();
            return instance;
        }
        public TimedWStringSeq ()
        {
            _Tm = default(System.DateTime);
            _Data = new List<System.String>();
        }
        public TimedWStringSeq (global::RTC.TimedWStringSeq source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = source.data.Select(x => (System.String)x).ToList();
        }

        ///<exclude/>
        public bool Equals(TimedWStringSeq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.SequenceEqual(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedWStringSeq)) return false;
            return Equals((TimedWStringSeq)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Data.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class RGBColour : NotifyPropertyChangedBase
    {
        private System.Double _R;
            
        ///<exclude/>
        public System.Double R
        {
            get { return _R; }
            set 
            {
                if(!(_R.Equals(value)))
                {
                    _R = value;
                    RaisePropertyChanged("R");
                }
            }
        }
        private System.Double _G;
            
        ///<exclude/>
        public System.Double G
        {
            get { return _G; }
            set 
            {
                if(!(_G.Equals(value)))
                {
                    _G = value;
                    RaisePropertyChanged("G");
                }
            }
        }
        private System.Double _B;
            
        ///<exclude/>
        public System.Double B
        {
            get { return _B; }
            set 
            {
                if(!(_B.Equals(value)))
                {
                    _B = value;
                    RaisePropertyChanged("B");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.RGBColour (ReactiveRTM.RTC.RGBColour source)
        {
            var instance = new global::RTC.RGBColour();
            instance.r =  source._R;
            instance.g =  source._G;
            instance.b =  source._B;
            return instance;
        }
        public RGBColour ()
        {
            _R = new System.Double();
            _G = new System.Double();
            _B = new System.Double();
        }
        public RGBColour (global::RTC.RGBColour source)
        {
            _R = source.r;
            _G = source.g;
            _B = source.b;
        }

        ///<exclude/>
        public bool Equals(RGBColour other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._R.Equals(_R) && other._G.Equals(_G) && other._B.Equals(_B);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RGBColour)) return false;
            return Equals((RGBColour)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _R.GetHashCode();
                result = (result * 397) ^ _G.GetHashCode();
                result = (result * 397) ^ _B.GetHashCode();
                return result;
            }
        }
    }
 
    public class Point2D : NotifyPropertyChangedBase
    {
        private System.Double _X;
            
        ///<exclude/>
        public System.Double X
        {
            get { return _X; }
            set 
            {
                if(!(_X.Equals(value)))
                {
                    _X = value;
                    RaisePropertyChanged("X");
                }
            }
        }
        private System.Double _Y;
            
        ///<exclude/>
        public System.Double Y
        {
            get { return _Y; }
            set 
            {
                if(!(_Y.Equals(value)))
                {
                    _Y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Point2D (ReactiveRTM.RTC.Point2D source)
        {
            var instance = new global::RTC.Point2D();
            instance.x =  source._X;
            instance.y =  source._Y;
            return instance;
        }
        public Point2D ()
        {
            _X = new System.Double();
            _Y = new System.Double();
        }
        public Point2D (global::RTC.Point2D source)
        {
            _X = source.x;
            _Y = source.y;
        }

        ///<exclude/>
        public bool Equals(Point2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._X.Equals(_X) && other._Y.Equals(_Y);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Point2D)) return false;
            return Equals((Point2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _X.GetHashCode();
                result = (result * 397) ^ _Y.GetHashCode();
                return result;
            }
        }
    }
 
    public class Vector2D : NotifyPropertyChangedBase
    {
        private System.Double _X;
            
        ///<exclude/>
        public System.Double X
        {
            get { return _X; }
            set 
            {
                if(!(_X.Equals(value)))
                {
                    _X = value;
                    RaisePropertyChanged("X");
                }
            }
        }
        private System.Double _Y;
            
        ///<exclude/>
        public System.Double Y
        {
            get { return _Y; }
            set 
            {
                if(!(_Y.Equals(value)))
                {
                    _Y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Vector2D (ReactiveRTM.RTC.Vector2D source)
        {
            var instance = new global::RTC.Vector2D();
            instance.x =  source._X;
            instance.y =  source._Y;
            return instance;
        }
        public Vector2D ()
        {
            _X = new System.Double();
            _Y = new System.Double();
        }
        public Vector2D (global::RTC.Vector2D source)
        {
            _X = source.x;
            _Y = source.y;
        }

        ///<exclude/>
        public bool Equals(Vector2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._X.Equals(_X) && other._Y.Equals(_Y);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Vector2D)) return false;
            return Equals((Vector2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _X.GetHashCode();
                result = (result * 397) ^ _Y.GetHashCode();
                return result;
            }
        }
    }
 
    public class Pose2D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Point2D _Position;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point2D Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        private System.Double _Heading;
            
        ///<exclude/>
        public System.Double Heading
        {
            get { return _Heading; }
            set 
            {
                if(!(_Heading.Equals(value)))
                {
                    _Heading = value;
                    RaisePropertyChanged("Heading");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Pose2D (ReactiveRTM.RTC.Pose2D source)
        {
            var instance = new global::RTC.Pose2D();
            instance.position =  ((global::RTC.Point2D)((IStub)source._Position).GetTarget());
            instance.heading =  source._Heading;
            return instance;
        }
        public Pose2D ()
        {
            _Position = new ReactiveRTM.RTC.Point2D();
            _Heading = new System.Double();
        }
        public Pose2D (global::RTC.Pose2D source)
        {
            _Position = new ReactiveRTM.RTC.Point2D(source.position);
            _Heading = source.heading;
        }

        ///<exclude/>
        public bool Equals(Pose2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Position.Equals(_Position) && other._Heading.Equals(_Heading);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Pose2D)) return false;
            return Equals((Pose2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Position.GetHashCode();
                result = (result * 397) ^ _Heading.GetHashCode();
                return result;
            }
        }
    }
 
    public class Velocity2D : NotifyPropertyChangedBase
    {
        private System.Double _Vx;
            
        ///<exclude/>
        public System.Double Vx
        {
            get { return _Vx; }
            set 
            {
                if(!(_Vx.Equals(value)))
                {
                    _Vx = value;
                    RaisePropertyChanged("Vx");
                }
            }
        }
        private System.Double _Vy;
            
        ///<exclude/>
        public System.Double Vy
        {
            get { return _Vy; }
            set 
            {
                if(!(_Vy.Equals(value)))
                {
                    _Vy = value;
                    RaisePropertyChanged("Vy");
                }
            }
        }
        private System.Double _Va;
            
        ///<exclude/>
        public System.Double Va
        {
            get { return _Va; }
            set 
            {
                if(!(_Va.Equals(value)))
                {
                    _Va = value;
                    RaisePropertyChanged("Va");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Velocity2D (ReactiveRTM.RTC.Velocity2D source)
        {
            var instance = new global::RTC.Velocity2D();
            instance.vx =  source._Vx;
            instance.vy =  source._Vy;
            instance.va =  source._Va;
            return instance;
        }
        public Velocity2D ()
        {
            _Vx = new System.Double();
            _Vy = new System.Double();
            _Va = new System.Double();
        }
        public Velocity2D (global::RTC.Velocity2D source)
        {
            _Vx = source.vx;
            _Vy = source.vy;
            _Va = source.va;
        }

        ///<exclude/>
        public bool Equals(Velocity2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Vx.Equals(_Vx) && other._Vy.Equals(_Vy) && other._Va.Equals(_Va);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Velocity2D)) return false;
            return Equals((Velocity2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Vx.GetHashCode();
                result = (result * 397) ^ _Vy.GetHashCode();
                result = (result * 397) ^ _Va.GetHashCode();
                return result;
            }
        }
    }
 
    public class Acceleration2D : NotifyPropertyChangedBase
    {
        private System.Double _Ax;
            
        ///<exclude/>
        public System.Double Ax
        {
            get { return _Ax; }
            set 
            {
                if(!(_Ax.Equals(value)))
                {
                    _Ax = value;
                    RaisePropertyChanged("Ax");
                }
            }
        }
        private System.Double _Ay;
            
        ///<exclude/>
        public System.Double Ay
        {
            get { return _Ay; }
            set 
            {
                if(!(_Ay.Equals(value)))
                {
                    _Ay = value;
                    RaisePropertyChanged("Ay");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Acceleration2D (ReactiveRTM.RTC.Acceleration2D source)
        {
            var instance = new global::RTC.Acceleration2D();
            instance.ax =  source._Ax;
            instance.ay =  source._Ay;
            return instance;
        }
        public Acceleration2D ()
        {
            _Ax = new System.Double();
            _Ay = new System.Double();
        }
        public Acceleration2D (global::RTC.Acceleration2D source)
        {
            _Ax = source.ax;
            _Ay = source.ay;
        }

        ///<exclude/>
        public bool Equals(Acceleration2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Ax.Equals(_Ax) && other._Ay.Equals(_Ay);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Acceleration2D)) return false;
            return Equals((Acceleration2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Ax.GetHashCode();
                result = (result * 397) ^ _Ay.GetHashCode();
                return result;
            }
        }
    }
 
    public class PoseVel2D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose2D _Pose;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Pose
        {
            get { return _Pose; }
            set 
            {
                if(!(_Pose.Equals(value)))
                {
                    _Pose = value;
                    RaisePropertyChanged("Pose");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity2D _Velocities;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity2D Velocities
        {
            get { return _Velocities; }
            set 
            {
                if(!(_Velocities.Equals(value)))
                {
                    _Velocities = value;
                    RaisePropertyChanged("Velocities");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PoseVel2D (ReactiveRTM.RTC.PoseVel2D source)
        {
            var instance = new global::RTC.PoseVel2D();
            instance.pose =  ((global::RTC.Pose2D)((IStub)source._Pose).GetTarget());
            instance.velocities =  ((global::RTC.Velocity2D)((IStub)source._Velocities).GetTarget());
            return instance;
        }
        public PoseVel2D ()
        {
            _Pose = new ReactiveRTM.RTC.Pose2D();
            _Velocities = new ReactiveRTM.RTC.Velocity2D();
        }
        public PoseVel2D (global::RTC.PoseVel2D source)
        {
            _Pose = new ReactiveRTM.RTC.Pose2D(source.pose);
            _Velocities = new ReactiveRTM.RTC.Velocity2D(source.velocities);
        }

        ///<exclude/>
        public bool Equals(PoseVel2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Pose.Equals(_Pose) && other._Velocities.Equals(_Velocities);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PoseVel2D)) return false;
            return Equals((PoseVel2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Pose.GetHashCode();
                result = (result * 397) ^ _Velocities.GetHashCode();
                return result;
            }
        }
    }
 
    public class Size2D : NotifyPropertyChangedBase
    {
        private System.Double _L;
            
        ///<exclude/>
        public System.Double L
        {
            get { return _L; }
            set 
            {
                if(!(_L.Equals(value)))
                {
                    _L = value;
                    RaisePropertyChanged("L");
                }
            }
        }
        private System.Double _W;
            
        ///<exclude/>
        public System.Double W
        {
            get { return _W; }
            set 
            {
                if(!(_W.Equals(value)))
                {
                    _W = value;
                    RaisePropertyChanged("W");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Size2D (ReactiveRTM.RTC.Size2D source)
        {
            var instance = new global::RTC.Size2D();
            instance.l =  source._L;
            instance.w =  source._W;
            return instance;
        }
        public Size2D ()
        {
            _L = new System.Double();
            _W = new System.Double();
        }
        public Size2D (global::RTC.Size2D source)
        {
            _L = source.l;
            _W = source.w;
        }

        ///<exclude/>
        public bool Equals(Size2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._L.Equals(_L) && other._W.Equals(_W);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Size2D)) return false;
            return Equals((Size2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _L.GetHashCode();
                result = (result * 397) ^ _W.GetHashCode();
                return result;
            }
        }
    }
 
    public class Geometry2D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose2D _Pose;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Pose
        {
            get { return _Pose; }
            set 
            {
                if(!(_Pose.Equals(value)))
                {
                    _Pose = value;
                    RaisePropertyChanged("Pose");
                }
            }
        }
        private ReactiveRTM.RTC.Size2D _Size;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size2D Size
        {
            get { return _Size; }
            set 
            {
                if(!(_Size.Equals(value)))
                {
                    _Size = value;
                    RaisePropertyChanged("Size");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Geometry2D (ReactiveRTM.RTC.Geometry2D source)
        {
            var instance = new global::RTC.Geometry2D();
            instance.pose =  ((global::RTC.Pose2D)((IStub)source._Pose).GetTarget());
            instance.size =  ((global::RTC.Size2D)((IStub)source._Size).GetTarget());
            return instance;
        }
        public Geometry2D ()
        {
            _Pose = new ReactiveRTM.RTC.Pose2D();
            _Size = new ReactiveRTM.RTC.Size2D();
        }
        public Geometry2D (global::RTC.Geometry2D source)
        {
            _Pose = new ReactiveRTM.RTC.Pose2D(source.pose);
            _Size = new ReactiveRTM.RTC.Size2D(source.size);
        }

        ///<exclude/>
        public bool Equals(Geometry2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Pose.Equals(_Pose) && other._Size.Equals(_Size);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Geometry2D)) return false;
            return Equals((Geometry2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Pose.GetHashCode();
                result = (result * 397) ^ _Size.GetHashCode();
                return result;
            }
        }
    }
 
    public class Covariance2D : NotifyPropertyChangedBase
    {
        private System.Double _Xx;
            
        ///<exclude/>
        public System.Double Xx
        {
            get { return _Xx; }
            set 
            {
                if(!(_Xx.Equals(value)))
                {
                    _Xx = value;
                    RaisePropertyChanged("Xx");
                }
            }
        }
        private System.Double _Xy;
            
        ///<exclude/>
        public System.Double Xy
        {
            get { return _Xy; }
            set 
            {
                if(!(_Xy.Equals(value)))
                {
                    _Xy = value;
                    RaisePropertyChanged("Xy");
                }
            }
        }
        private System.Double _Xt;
            
        ///<exclude/>
        public System.Double Xt
        {
            get { return _Xt; }
            set 
            {
                if(!(_Xt.Equals(value)))
                {
                    _Xt = value;
                    RaisePropertyChanged("Xt");
                }
            }
        }
        private System.Double _Yy;
            
        ///<exclude/>
        public System.Double Yy
        {
            get { return _Yy; }
            set 
            {
                if(!(_Yy.Equals(value)))
                {
                    _Yy = value;
                    RaisePropertyChanged("Yy");
                }
            }
        }
        private System.Double _Yt;
            
        ///<exclude/>
        public System.Double Yt
        {
            get { return _Yt; }
            set 
            {
                if(!(_Yt.Equals(value)))
                {
                    _Yt = value;
                    RaisePropertyChanged("Yt");
                }
            }
        }
        private System.Double _Tt;
            
        ///<exclude/>
        public System.Double Tt
        {
            get { return _Tt; }
            set 
            {
                if(!(_Tt.Equals(value)))
                {
                    _Tt = value;
                    RaisePropertyChanged("Tt");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Covariance2D (ReactiveRTM.RTC.Covariance2D source)
        {
            var instance = new global::RTC.Covariance2D();
            instance.xx =  source._Xx;
            instance.xy =  source._Xy;
            instance.xt =  source._Xt;
            instance.yy =  source._Yy;
            instance.yt =  source._Yt;
            instance.tt =  source._Tt;
            return instance;
        }
        public Covariance2D ()
        {
            _Xx = new System.Double();
            _Xy = new System.Double();
            _Xt = new System.Double();
            _Yy = new System.Double();
            _Yt = new System.Double();
            _Tt = new System.Double();
        }
        public Covariance2D (global::RTC.Covariance2D source)
        {
            _Xx = source.xx;
            _Xy = source.xy;
            _Xt = source.xt;
            _Yy = source.yy;
            _Yt = source.yt;
            _Tt = source.tt;
        }

        ///<exclude/>
        public bool Equals(Covariance2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Xx.Equals(_Xx) && other._Xy.Equals(_Xy) && other._Xt.Equals(_Xt) && other._Yy.Equals(_Yy) && other._Yt.Equals(_Yt) && other._Tt.Equals(_Tt);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Covariance2D)) return false;
            return Equals((Covariance2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Xx.GetHashCode();
                result = (result * 397) ^ _Xy.GetHashCode();
                result = (result * 397) ^ _Xt.GetHashCode();
                result = (result * 397) ^ _Yy.GetHashCode();
                result = (result * 397) ^ _Yt.GetHashCode();
                result = (result * 397) ^ _Tt.GetHashCode();
                return result;
            }
        }
    }
 
    public class PointCovariance2D : NotifyPropertyChangedBase
    {
        private System.Double _Xx;
            
        ///<exclude/>
        public System.Double Xx
        {
            get { return _Xx; }
            set 
            {
                if(!(_Xx.Equals(value)))
                {
                    _Xx = value;
                    RaisePropertyChanged("Xx");
                }
            }
        }
        private System.Double _Xy;
            
        ///<exclude/>
        public System.Double Xy
        {
            get { return _Xy; }
            set 
            {
                if(!(_Xy.Equals(value)))
                {
                    _Xy = value;
                    RaisePropertyChanged("Xy");
                }
            }
        }
        private System.Double _Yy;
            
        ///<exclude/>
        public System.Double Yy
        {
            get { return _Yy; }
            set 
            {
                if(!(_Yy.Equals(value)))
                {
                    _Yy = value;
                    RaisePropertyChanged("Yy");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PointCovariance2D (ReactiveRTM.RTC.PointCovariance2D source)
        {
            var instance = new global::RTC.PointCovariance2D();
            instance.xx =  source._Xx;
            instance.xy =  source._Xy;
            instance.yy =  source._Yy;
            return instance;
        }
        public PointCovariance2D ()
        {
            _Xx = new System.Double();
            _Xy = new System.Double();
            _Yy = new System.Double();
        }
        public PointCovariance2D (global::RTC.PointCovariance2D source)
        {
            _Xx = source.xx;
            _Xy = source.xy;
            _Yy = source.yy;
        }

        ///<exclude/>
        public bool Equals(PointCovariance2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Xx.Equals(_Xx) && other._Xy.Equals(_Xy) && other._Yy.Equals(_Yy);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PointCovariance2D)) return false;
            return Equals((PointCovariance2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Xx.GetHashCode();
                result = (result * 397) ^ _Xy.GetHashCode();
                result = (result * 397) ^ _Yy.GetHashCode();
                return result;
            }
        }
    }
 
    public class Carlike : NotifyPropertyChangedBase
    {
        private System.Double _Speed;
            
        ///<exclude/>
        public System.Double Speed
        {
            get { return _Speed; }
            set 
            {
                if(!(_Speed.Equals(value)))
                {
                    _Speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
        private System.Double _SteeringAngle;
            
        ///<exclude/>
        public System.Double SteeringAngle
        {
            get { return _SteeringAngle; }
            set 
            {
                if(!(_SteeringAngle.Equals(value)))
                {
                    _SteeringAngle = value;
                    RaisePropertyChanged("SteeringAngle");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Carlike (ReactiveRTM.RTC.Carlike source)
        {
            var instance = new global::RTC.Carlike();
            instance.speed =  source._Speed;
            instance.steeringAngle =  source._SteeringAngle;
            return instance;
        }
        public Carlike ()
        {
            _Speed = new System.Double();
            _SteeringAngle = new System.Double();
        }
        public Carlike (global::RTC.Carlike source)
        {
            _Speed = source.speed;
            _SteeringAngle = source.steeringAngle;
        }

        ///<exclude/>
        public bool Equals(Carlike other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Speed.Equals(_Speed) && other._SteeringAngle.Equals(_SteeringAngle);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Carlike)) return false;
            return Equals((Carlike)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Speed.GetHashCode();
                result = (result * 397) ^ _SteeringAngle.GetHashCode();
                return result;
            }
        }
    }
 
    public class SpeedHeading2D : NotifyPropertyChangedBase
    {
        private System.Double _Speed;
            
        ///<exclude/>
        public System.Double Speed
        {
            get { return _Speed; }
            set 
            {
                if(!(_Speed.Equals(value)))
                {
                    _Speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
        private System.Double _Heading;
            
        ///<exclude/>
        public System.Double Heading
        {
            get { return _Heading; }
            set 
            {
                if(!(_Heading.Equals(value)))
                {
                    _Heading = value;
                    RaisePropertyChanged("Heading");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.SpeedHeading2D (ReactiveRTM.RTC.SpeedHeading2D source)
        {
            var instance = new global::RTC.SpeedHeading2D();
            instance.speed =  source._Speed;
            instance.heading =  source._Heading;
            return instance;
        }
        public SpeedHeading2D ()
        {
            _Speed = new System.Double();
            _Heading = new System.Double();
        }
        public SpeedHeading2D (global::RTC.SpeedHeading2D source)
        {
            _Speed = source.speed;
            _Heading = source.heading;
        }

        ///<exclude/>
        public bool Equals(SpeedHeading2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Speed.Equals(_Speed) && other._Heading.Equals(_Heading);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(SpeedHeading2D)) return false;
            return Equals((SpeedHeading2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Speed.GetHashCode();
                result = (result * 397) ^ _Heading.GetHashCode();
                return result;
            }
        }
    }
 
    public class Point3D : NotifyPropertyChangedBase
    {
        private System.Double _X;
            
        ///<exclude/>
        public System.Double X
        {
            get { return _X; }
            set 
            {
                if(!(_X.Equals(value)))
                {
                    _X = value;
                    RaisePropertyChanged("X");
                }
            }
        }
        private System.Double _Y;
            
        ///<exclude/>
        public System.Double Y
        {
            get { return _Y; }
            set 
            {
                if(!(_Y.Equals(value)))
                {
                    _Y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        private System.Double _Z;
            
        ///<exclude/>
        public System.Double Z
        {
            get { return _Z; }
            set 
            {
                if(!(_Z.Equals(value)))
                {
                    _Z = value;
                    RaisePropertyChanged("Z");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Point3D (ReactiveRTM.RTC.Point3D source)
        {
            var instance = new global::RTC.Point3D();
            instance.x =  source._X;
            instance.y =  source._Y;
            instance.z =  source._Z;
            return instance;
        }
        public Point3D ()
        {
            _X = new System.Double();
            _Y = new System.Double();
            _Z = new System.Double();
        }
        public Point3D (global::RTC.Point3D source)
        {
            _X = source.x;
            _Y = source.y;
            _Z = source.z;
        }

        ///<exclude/>
        public bool Equals(Point3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._X.Equals(_X) && other._Y.Equals(_Y) && other._Z.Equals(_Z);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Point3D)) return false;
            return Equals((Point3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _X.GetHashCode();
                result = (result * 397) ^ _Y.GetHashCode();
                result = (result * 397) ^ _Z.GetHashCode();
                return result;
            }
        }
    }
 
    public class Vector3D : NotifyPropertyChangedBase
    {
        private System.Double _X;
            
        ///<exclude/>
        public System.Double X
        {
            get { return _X; }
            set 
            {
                if(!(_X.Equals(value)))
                {
                    _X = value;
                    RaisePropertyChanged("X");
                }
            }
        }
        private System.Double _Y;
            
        ///<exclude/>
        public System.Double Y
        {
            get { return _Y; }
            set 
            {
                if(!(_Y.Equals(value)))
                {
                    _Y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        private System.Double _Z;
            
        ///<exclude/>
        public System.Double Z
        {
            get { return _Z; }
            set 
            {
                if(!(_Z.Equals(value)))
                {
                    _Z = value;
                    RaisePropertyChanged("Z");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Vector3D (ReactiveRTM.RTC.Vector3D source)
        {
            var instance = new global::RTC.Vector3D();
            instance.x =  source._X;
            instance.y =  source._Y;
            instance.z =  source._Z;
            return instance;
        }
        public Vector3D ()
        {
            _X = new System.Double();
            _Y = new System.Double();
            _Z = new System.Double();
        }
        public Vector3D (global::RTC.Vector3D source)
        {
            _X = source.x;
            _Y = source.y;
            _Z = source.z;
        }

        ///<exclude/>
        public bool Equals(Vector3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._X.Equals(_X) && other._Y.Equals(_Y) && other._Z.Equals(_Z);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Vector3D)) return false;
            return Equals((Vector3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _X.GetHashCode();
                result = (result * 397) ^ _Y.GetHashCode();
                result = (result * 397) ^ _Z.GetHashCode();
                return result;
            }
        }
    }
 
    public class Orientation3D : NotifyPropertyChangedBase
    {
        private System.Double _R;
            
        ///<exclude/>
        public System.Double R
        {
            get { return _R; }
            set 
            {
                if(!(_R.Equals(value)))
                {
                    _R = value;
                    RaisePropertyChanged("R");
                }
            }
        }
        private System.Double _P;
            
        ///<exclude/>
        public System.Double P
        {
            get { return _P; }
            set 
            {
                if(!(_P.Equals(value)))
                {
                    _P = value;
                    RaisePropertyChanged("P");
                }
            }
        }
        private System.Double _Y;
            
        ///<exclude/>
        public System.Double Y
        {
            get { return _Y; }
            set 
            {
                if(!(_Y.Equals(value)))
                {
                    _Y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Orientation3D (ReactiveRTM.RTC.Orientation3D source)
        {
            var instance = new global::RTC.Orientation3D();
            instance.r =  source._R;
            instance.p =  source._P;
            instance.y =  source._Y;
            return instance;
        }
        public Orientation3D ()
        {
            _R = new System.Double();
            _P = new System.Double();
            _Y = new System.Double();
        }
        public Orientation3D (global::RTC.Orientation3D source)
        {
            _R = source.r;
            _P = source.p;
            _Y = source.y;
        }

        ///<exclude/>
        public bool Equals(Orientation3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._R.Equals(_R) && other._P.Equals(_P) && other._Y.Equals(_Y);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Orientation3D)) return false;
            return Equals((Orientation3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _R.GetHashCode();
                result = (result * 397) ^ _P.GetHashCode();
                result = (result * 397) ^ _Y.GetHashCode();
                return result;
            }
        }
    }
 
    public class Pose3D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Point3D _Position;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point3D Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        private ReactiveRTM.RTC.Orientation3D _Orientation;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Orientation3D Orientation
        {
            get { return _Orientation; }
            set 
            {
                if(!(_Orientation.Equals(value)))
                {
                    _Orientation = value;
                    RaisePropertyChanged("Orientation");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Pose3D (ReactiveRTM.RTC.Pose3D source)
        {
            var instance = new global::RTC.Pose3D();
            instance.position =  ((global::RTC.Point3D)((IStub)source._Position).GetTarget());
            instance.orientation =  ((global::RTC.Orientation3D)((IStub)source._Orientation).GetTarget());
            return instance;
        }
        public Pose3D ()
        {
            _Position = new ReactiveRTM.RTC.Point3D();
            _Orientation = new ReactiveRTM.RTC.Orientation3D();
        }
        public Pose3D (global::RTC.Pose3D source)
        {
            _Position = new ReactiveRTM.RTC.Point3D(source.position);
            _Orientation = new ReactiveRTM.RTC.Orientation3D(source.orientation);
        }

        ///<exclude/>
        public bool Equals(Pose3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Position.Equals(_Position) && other._Orientation.Equals(_Orientation);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Pose3D)) return false;
            return Equals((Pose3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Position.GetHashCode();
                result = (result * 397) ^ _Orientation.GetHashCode();
                return result;
            }
        }
    }
 
    public class Velocity3D : NotifyPropertyChangedBase
    {
        private System.Double _Vx;
            
        ///<exclude/>
        public System.Double Vx
        {
            get { return _Vx; }
            set 
            {
                if(!(_Vx.Equals(value)))
                {
                    _Vx = value;
                    RaisePropertyChanged("Vx");
                }
            }
        }
        private System.Double _Vy;
            
        ///<exclude/>
        public System.Double Vy
        {
            get { return _Vy; }
            set 
            {
                if(!(_Vy.Equals(value)))
                {
                    _Vy = value;
                    RaisePropertyChanged("Vy");
                }
            }
        }
        private System.Double _Vz;
            
        ///<exclude/>
        public System.Double Vz
        {
            get { return _Vz; }
            set 
            {
                if(!(_Vz.Equals(value)))
                {
                    _Vz = value;
                    RaisePropertyChanged("Vz");
                }
            }
        }
        private System.Double _Vr;
            
        ///<exclude/>
        public System.Double Vr
        {
            get { return _Vr; }
            set 
            {
                if(!(_Vr.Equals(value)))
                {
                    _Vr = value;
                    RaisePropertyChanged("Vr");
                }
            }
        }
        private System.Double _Vp;
            
        ///<exclude/>
        public System.Double Vp
        {
            get { return _Vp; }
            set 
            {
                if(!(_Vp.Equals(value)))
                {
                    _Vp = value;
                    RaisePropertyChanged("Vp");
                }
            }
        }
        private System.Double _Va;
            
        ///<exclude/>
        public System.Double Va
        {
            get { return _Va; }
            set 
            {
                if(!(_Va.Equals(value)))
                {
                    _Va = value;
                    RaisePropertyChanged("Va");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Velocity3D (ReactiveRTM.RTC.Velocity3D source)
        {
            var instance = new global::RTC.Velocity3D();
            instance.vx =  source._Vx;
            instance.vy =  source._Vy;
            instance.vz =  source._Vz;
            instance.vr =  source._Vr;
            instance.vp =  source._Vp;
            instance.va =  source._Va;
            return instance;
        }
        public Velocity3D ()
        {
            _Vx = new System.Double();
            _Vy = new System.Double();
            _Vz = new System.Double();
            _Vr = new System.Double();
            _Vp = new System.Double();
            _Va = new System.Double();
        }
        public Velocity3D (global::RTC.Velocity3D source)
        {
            _Vx = source.vx;
            _Vy = source.vy;
            _Vz = source.vz;
            _Vr = source.vr;
            _Vp = source.vp;
            _Va = source.va;
        }

        ///<exclude/>
        public bool Equals(Velocity3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Vx.Equals(_Vx) && other._Vy.Equals(_Vy) && other._Vz.Equals(_Vz) && other._Vr.Equals(_Vr) && other._Vp.Equals(_Vp) && other._Va.Equals(_Va);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Velocity3D)) return false;
            return Equals((Velocity3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Vx.GetHashCode();
                result = (result * 397) ^ _Vy.GetHashCode();
                result = (result * 397) ^ _Vz.GetHashCode();
                result = (result * 397) ^ _Vr.GetHashCode();
                result = (result * 397) ^ _Vp.GetHashCode();
                result = (result * 397) ^ _Va.GetHashCode();
                return result;
            }
        }
    }
 
    public class AngularVelocity3D : NotifyPropertyChangedBase
    {
        private System.Double _Avx;
            
        ///<exclude/>
        public System.Double Avx
        {
            get { return _Avx; }
            set 
            {
                if(!(_Avx.Equals(value)))
                {
                    _Avx = value;
                    RaisePropertyChanged("Avx");
                }
            }
        }
        private System.Double _Avy;
            
        ///<exclude/>
        public System.Double Avy
        {
            get { return _Avy; }
            set 
            {
                if(!(_Avy.Equals(value)))
                {
                    _Avy = value;
                    RaisePropertyChanged("Avy");
                }
            }
        }
        private System.Double _Avz;
            
        ///<exclude/>
        public System.Double Avz
        {
            get { return _Avz; }
            set 
            {
                if(!(_Avz.Equals(value)))
                {
                    _Avz = value;
                    RaisePropertyChanged("Avz");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.AngularVelocity3D (ReactiveRTM.RTC.AngularVelocity3D source)
        {
            var instance = new global::RTC.AngularVelocity3D();
            instance.avx =  source._Avx;
            instance.avy =  source._Avy;
            instance.avz =  source._Avz;
            return instance;
        }
        public AngularVelocity3D ()
        {
            _Avx = new System.Double();
            _Avy = new System.Double();
            _Avz = new System.Double();
        }
        public AngularVelocity3D (global::RTC.AngularVelocity3D source)
        {
            _Avx = source.avx;
            _Avy = source.avy;
            _Avz = source.avz;
        }

        ///<exclude/>
        public bool Equals(AngularVelocity3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Avx.Equals(_Avx) && other._Avy.Equals(_Avy) && other._Avz.Equals(_Avz);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(AngularVelocity3D)) return false;
            return Equals((AngularVelocity3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Avx.GetHashCode();
                result = (result * 397) ^ _Avy.GetHashCode();
                result = (result * 397) ^ _Avz.GetHashCode();
                return result;
            }
        }
    }
 
    public class Acceleration3D : NotifyPropertyChangedBase
    {
        private System.Double _Ax;
            
        ///<exclude/>
        public System.Double Ax
        {
            get { return _Ax; }
            set 
            {
                if(!(_Ax.Equals(value)))
                {
                    _Ax = value;
                    RaisePropertyChanged("Ax");
                }
            }
        }
        private System.Double _Ay;
            
        ///<exclude/>
        public System.Double Ay
        {
            get { return _Ay; }
            set 
            {
                if(!(_Ay.Equals(value)))
                {
                    _Ay = value;
                    RaisePropertyChanged("Ay");
                }
            }
        }
        private System.Double _Az;
            
        ///<exclude/>
        public System.Double Az
        {
            get { return _Az; }
            set 
            {
                if(!(_Az.Equals(value)))
                {
                    _Az = value;
                    RaisePropertyChanged("Az");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Acceleration3D (ReactiveRTM.RTC.Acceleration3D source)
        {
            var instance = new global::RTC.Acceleration3D();
            instance.ax =  source._Ax;
            instance.ay =  source._Ay;
            instance.az =  source._Az;
            return instance;
        }
        public Acceleration3D ()
        {
            _Ax = new System.Double();
            _Ay = new System.Double();
            _Az = new System.Double();
        }
        public Acceleration3D (global::RTC.Acceleration3D source)
        {
            _Ax = source.ax;
            _Ay = source.ay;
            _Az = source.az;
        }

        ///<exclude/>
        public bool Equals(Acceleration3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Ax.Equals(_Ax) && other._Ay.Equals(_Ay) && other._Az.Equals(_Az);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Acceleration3D)) return false;
            return Equals((Acceleration3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Ax.GetHashCode();
                result = (result * 397) ^ _Ay.GetHashCode();
                result = (result * 397) ^ _Az.GetHashCode();
                return result;
            }
        }
    }
 
    public class AngularAcceleration3D : NotifyPropertyChangedBase
    {
        private System.Double _Aax;
            
        ///<exclude/>
        public System.Double Aax
        {
            get { return _Aax; }
            set 
            {
                if(!(_Aax.Equals(value)))
                {
                    _Aax = value;
                    RaisePropertyChanged("Aax");
                }
            }
        }
        private System.Double _Aay;
            
        ///<exclude/>
        public System.Double Aay
        {
            get { return _Aay; }
            set 
            {
                if(!(_Aay.Equals(value)))
                {
                    _Aay = value;
                    RaisePropertyChanged("Aay");
                }
            }
        }
        private System.Double _Aaz;
            
        ///<exclude/>
        public System.Double Aaz
        {
            get { return _Aaz; }
            set 
            {
                if(!(_Aaz.Equals(value)))
                {
                    _Aaz = value;
                    RaisePropertyChanged("Aaz");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.AngularAcceleration3D (ReactiveRTM.RTC.AngularAcceleration3D source)
        {
            var instance = new global::RTC.AngularAcceleration3D();
            instance.aax =  source._Aax;
            instance.aay =  source._Aay;
            instance.aaz =  source._Aaz;
            return instance;
        }
        public AngularAcceleration3D ()
        {
            _Aax = new System.Double();
            _Aay = new System.Double();
            _Aaz = new System.Double();
        }
        public AngularAcceleration3D (global::RTC.AngularAcceleration3D source)
        {
            _Aax = source.aax;
            _Aay = source.aay;
            _Aaz = source.aaz;
        }

        ///<exclude/>
        public bool Equals(AngularAcceleration3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Aax.Equals(_Aax) && other._Aay.Equals(_Aay) && other._Aaz.Equals(_Aaz);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(AngularAcceleration3D)) return false;
            return Equals((AngularAcceleration3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Aax.GetHashCode();
                result = (result * 397) ^ _Aay.GetHashCode();
                result = (result * 397) ^ _Aaz.GetHashCode();
                return result;
            }
        }
    }
 
    public class PoseVel3D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose3D _Pose;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Pose
        {
            get { return _Pose; }
            set 
            {
                if(!(_Pose.Equals(value)))
                {
                    _Pose = value;
                    RaisePropertyChanged("Pose");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity3D _Velocities;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity3D Velocities
        {
            get { return _Velocities; }
            set 
            {
                if(!(_Velocities.Equals(value)))
                {
                    _Velocities = value;
                    RaisePropertyChanged("Velocities");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PoseVel3D (ReactiveRTM.RTC.PoseVel3D source)
        {
            var instance = new global::RTC.PoseVel3D();
            instance.pose =  ((global::RTC.Pose3D)((IStub)source._Pose).GetTarget());
            instance.velocities =  ((global::RTC.Velocity3D)((IStub)source._Velocities).GetTarget());
            return instance;
        }
        public PoseVel3D ()
        {
            _Pose = new ReactiveRTM.RTC.Pose3D();
            _Velocities = new ReactiveRTM.RTC.Velocity3D();
        }
        public PoseVel3D (global::RTC.PoseVel3D source)
        {
            _Pose = new ReactiveRTM.RTC.Pose3D(source.pose);
            _Velocities = new ReactiveRTM.RTC.Velocity3D(source.velocities);
        }

        ///<exclude/>
        public bool Equals(PoseVel3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Pose.Equals(_Pose) && other._Velocities.Equals(_Velocities);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PoseVel3D)) return false;
            return Equals((PoseVel3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Pose.GetHashCode();
                result = (result * 397) ^ _Velocities.GetHashCode();
                return result;
            }
        }
    }
 
    public class Size3D : NotifyPropertyChangedBase
    {
        private System.Double _L;
            
        ///<exclude/>
        public System.Double L
        {
            get { return _L; }
            set 
            {
                if(!(_L.Equals(value)))
                {
                    _L = value;
                    RaisePropertyChanged("L");
                }
            }
        }
        private System.Double _W;
            
        ///<exclude/>
        public System.Double W
        {
            get { return _W; }
            set 
            {
                if(!(_W.Equals(value)))
                {
                    _W = value;
                    RaisePropertyChanged("W");
                }
            }
        }
        private System.Double _H;
            
        ///<exclude/>
        public System.Double H
        {
            get { return _H; }
            set 
            {
                if(!(_H.Equals(value)))
                {
                    _H = value;
                    RaisePropertyChanged("H");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Size3D (ReactiveRTM.RTC.Size3D source)
        {
            var instance = new global::RTC.Size3D();
            instance.l =  source._L;
            instance.w =  source._W;
            instance.h =  source._H;
            return instance;
        }
        public Size3D ()
        {
            _L = new System.Double();
            _W = new System.Double();
            _H = new System.Double();
        }
        public Size3D (global::RTC.Size3D source)
        {
            _L = source.l;
            _W = source.w;
            _H = source.h;
        }

        ///<exclude/>
        public bool Equals(Size3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._L.Equals(_L) && other._W.Equals(_W) && other._H.Equals(_H);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Size3D)) return false;
            return Equals((Size3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _L.GetHashCode();
                result = (result * 397) ^ _W.GetHashCode();
                result = (result * 397) ^ _H.GetHashCode();
                return result;
            }
        }
    }
 
    public class Geometry3D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose3D _Pose;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Pose
        {
            get { return _Pose; }
            set 
            {
                if(!(_Pose.Equals(value)))
                {
                    _Pose = value;
                    RaisePropertyChanged("Pose");
                }
            }
        }
        private ReactiveRTM.RTC.Size3D _Size;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size3D Size
        {
            get { return _Size; }
            set 
            {
                if(!(_Size.Equals(value)))
                {
                    _Size = value;
                    RaisePropertyChanged("Size");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Geometry3D (ReactiveRTM.RTC.Geometry3D source)
        {
            var instance = new global::RTC.Geometry3D();
            instance.pose =  ((global::RTC.Pose3D)((IStub)source._Pose).GetTarget());
            instance.size =  ((global::RTC.Size3D)((IStub)source._Size).GetTarget());
            return instance;
        }
        public Geometry3D ()
        {
            _Pose = new ReactiveRTM.RTC.Pose3D();
            _Size = new ReactiveRTM.RTC.Size3D();
        }
        public Geometry3D (global::RTC.Geometry3D source)
        {
            _Pose = new ReactiveRTM.RTC.Pose3D(source.pose);
            _Size = new ReactiveRTM.RTC.Size3D(source.size);
        }

        ///<exclude/>
        public bool Equals(Geometry3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Pose.Equals(_Pose) && other._Size.Equals(_Size);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Geometry3D)) return false;
            return Equals((Geometry3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Pose.GetHashCode();
                result = (result * 397) ^ _Size.GetHashCode();
                return result;
            }
        }
    }
 
    public class Covariance3D : NotifyPropertyChangedBase
    {
        private System.Double _Xx;
            
        ///<exclude/>
        public System.Double Xx
        {
            get { return _Xx; }
            set 
            {
                if(!(_Xx.Equals(value)))
                {
                    _Xx = value;
                    RaisePropertyChanged("Xx");
                }
            }
        }
        private System.Double _Xy;
            
        ///<exclude/>
        public System.Double Xy
        {
            get { return _Xy; }
            set 
            {
                if(!(_Xy.Equals(value)))
                {
                    _Xy = value;
                    RaisePropertyChanged("Xy");
                }
            }
        }
        private System.Double _Xz;
            
        ///<exclude/>
        public System.Double Xz
        {
            get { return _Xz; }
            set 
            {
                if(!(_Xz.Equals(value)))
                {
                    _Xz = value;
                    RaisePropertyChanged("Xz");
                }
            }
        }
        private System.Double _Xr;
            
        ///<exclude/>
        public System.Double Xr
        {
            get { return _Xr; }
            set 
            {
                if(!(_Xr.Equals(value)))
                {
                    _Xr = value;
                    RaisePropertyChanged("Xr");
                }
            }
        }
        private System.Double _Xp;
            
        ///<exclude/>
        public System.Double Xp
        {
            get { return _Xp; }
            set 
            {
                if(!(_Xp.Equals(value)))
                {
                    _Xp = value;
                    RaisePropertyChanged("Xp");
                }
            }
        }
        private System.Double _Xa;
            
        ///<exclude/>
        public System.Double Xa
        {
            get { return _Xa; }
            set 
            {
                if(!(_Xa.Equals(value)))
                {
                    _Xa = value;
                    RaisePropertyChanged("Xa");
                }
            }
        }
        private System.Double _Yy;
            
        ///<exclude/>
        public System.Double Yy
        {
            get { return _Yy; }
            set 
            {
                if(!(_Yy.Equals(value)))
                {
                    _Yy = value;
                    RaisePropertyChanged("Yy");
                }
            }
        }
        private System.Double _Yz;
            
        ///<exclude/>
        public System.Double Yz
        {
            get { return _Yz; }
            set 
            {
                if(!(_Yz.Equals(value)))
                {
                    _Yz = value;
                    RaisePropertyChanged("Yz");
                }
            }
        }
        private System.Double _Yr;
            
        ///<exclude/>
        public System.Double Yr
        {
            get { return _Yr; }
            set 
            {
                if(!(_Yr.Equals(value)))
                {
                    _Yr = value;
                    RaisePropertyChanged("Yr");
                }
            }
        }
        private System.Double _Yp;
            
        ///<exclude/>
        public System.Double Yp
        {
            get { return _Yp; }
            set 
            {
                if(!(_Yp.Equals(value)))
                {
                    _Yp = value;
                    RaisePropertyChanged("Yp");
                }
            }
        }
        private System.Double _Ya;
            
        ///<exclude/>
        public System.Double Ya
        {
            get { return _Ya; }
            set 
            {
                if(!(_Ya.Equals(value)))
                {
                    _Ya = value;
                    RaisePropertyChanged("Ya");
                }
            }
        }
        private System.Double _Zz;
            
        ///<exclude/>
        public System.Double Zz
        {
            get { return _Zz; }
            set 
            {
                if(!(_Zz.Equals(value)))
                {
                    _Zz = value;
                    RaisePropertyChanged("Zz");
                }
            }
        }
        private System.Double _Zr;
            
        ///<exclude/>
        public System.Double Zr
        {
            get { return _Zr; }
            set 
            {
                if(!(_Zr.Equals(value)))
                {
                    _Zr = value;
                    RaisePropertyChanged("Zr");
                }
            }
        }
        private System.Double _Zp;
            
        ///<exclude/>
        public System.Double Zp
        {
            get { return _Zp; }
            set 
            {
                if(!(_Zp.Equals(value)))
                {
                    _Zp = value;
                    RaisePropertyChanged("Zp");
                }
            }
        }
        private System.Double _Za;
            
        ///<exclude/>
        public System.Double Za
        {
            get { return _Za; }
            set 
            {
                if(!(_Za.Equals(value)))
                {
                    _Za = value;
                    RaisePropertyChanged("Za");
                }
            }
        }
        private System.Double _Rr;
            
        ///<exclude/>
        public System.Double Rr
        {
            get { return _Rr; }
            set 
            {
                if(!(_Rr.Equals(value)))
                {
                    _Rr = value;
                    RaisePropertyChanged("Rr");
                }
            }
        }
        private System.Double _Rp;
            
        ///<exclude/>
        public System.Double Rp
        {
            get { return _Rp; }
            set 
            {
                if(!(_Rp.Equals(value)))
                {
                    _Rp = value;
                    RaisePropertyChanged("Rp");
                }
            }
        }
        private System.Double _Ra;
            
        ///<exclude/>
        public System.Double Ra
        {
            get { return _Ra; }
            set 
            {
                if(!(_Ra.Equals(value)))
                {
                    _Ra = value;
                    RaisePropertyChanged("Ra");
                }
            }
        }
        private System.Double _Pp;
            
        ///<exclude/>
        public System.Double Pp
        {
            get { return _Pp; }
            set 
            {
                if(!(_Pp.Equals(value)))
                {
                    _Pp = value;
                    RaisePropertyChanged("Pp");
                }
            }
        }
        private System.Double _Pa;
            
        ///<exclude/>
        public System.Double Pa
        {
            get { return _Pa; }
            set 
            {
                if(!(_Pa.Equals(value)))
                {
                    _Pa = value;
                    RaisePropertyChanged("Pa");
                }
            }
        }
        private System.Double _Aa;
            
        ///<exclude/>
        public System.Double Aa
        {
            get { return _Aa; }
            set 
            {
                if(!(_Aa.Equals(value)))
                {
                    _Aa = value;
                    RaisePropertyChanged("Aa");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Covariance3D (ReactiveRTM.RTC.Covariance3D source)
        {
            var instance = new global::RTC.Covariance3D();
            instance.xx =  source._Xx;
            instance.xy =  source._Xy;
            instance.xz =  source._Xz;
            instance.xr =  source._Xr;
            instance.xp =  source._Xp;
            instance.xa =  source._Xa;
            instance.yy =  source._Yy;
            instance.yz =  source._Yz;
            instance.yr =  source._Yr;
            instance.yp =  source._Yp;
            instance.ya =  source._Ya;
            instance.zz =  source._Zz;
            instance.zr =  source._Zr;
            instance.zp =  source._Zp;
            instance.za =  source._Za;
            instance.rr =  source._Rr;
            instance.rp =  source._Rp;
            instance.ra =  source._Ra;
            instance.pp =  source._Pp;
            instance.pa =  source._Pa;
            instance.aa =  source._Aa;
            return instance;
        }
        public Covariance3D ()
        {
            _Xx = new System.Double();
            _Xy = new System.Double();
            _Xz = new System.Double();
            _Xr = new System.Double();
            _Xp = new System.Double();
            _Xa = new System.Double();
            _Yy = new System.Double();
            _Yz = new System.Double();
            _Yr = new System.Double();
            _Yp = new System.Double();
            _Ya = new System.Double();
            _Zz = new System.Double();
            _Zr = new System.Double();
            _Zp = new System.Double();
            _Za = new System.Double();
            _Rr = new System.Double();
            _Rp = new System.Double();
            _Ra = new System.Double();
            _Pp = new System.Double();
            _Pa = new System.Double();
            _Aa = new System.Double();
        }
        public Covariance3D (global::RTC.Covariance3D source)
        {
            _Xx = source.xx;
            _Xy = source.xy;
            _Xz = source.xz;
            _Xr = source.xr;
            _Xp = source.xp;
            _Xa = source.xa;
            _Yy = source.yy;
            _Yz = source.yz;
            _Yr = source.yr;
            _Yp = source.yp;
            _Ya = source.ya;
            _Zz = source.zz;
            _Zr = source.zr;
            _Zp = source.zp;
            _Za = source.za;
            _Rr = source.rr;
            _Rp = source.rp;
            _Ra = source.ra;
            _Pp = source.pp;
            _Pa = source.pa;
            _Aa = source.aa;
        }

        ///<exclude/>
        public bool Equals(Covariance3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Xx.Equals(_Xx) && other._Xy.Equals(_Xy) && other._Xz.Equals(_Xz) && other._Xr.Equals(_Xr) && other._Xp.Equals(_Xp) && other._Xa.Equals(_Xa) && other._Yy.Equals(_Yy) && other._Yz.Equals(_Yz) && other._Yr.Equals(_Yr) && other._Yp.Equals(_Yp) && other._Ya.Equals(_Ya) && other._Zz.Equals(_Zz) && other._Zr.Equals(_Zr) && other._Zp.Equals(_Zp) && other._Za.Equals(_Za) && other._Rr.Equals(_Rr) && other._Rp.Equals(_Rp) && other._Ra.Equals(_Ra) && other._Pp.Equals(_Pp) && other._Pa.Equals(_Pa) && other._Aa.Equals(_Aa);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Covariance3D)) return false;
            return Equals((Covariance3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Xx.GetHashCode();
                result = (result * 397) ^ _Xy.GetHashCode();
                result = (result * 397) ^ _Xz.GetHashCode();
                result = (result * 397) ^ _Xr.GetHashCode();
                result = (result * 397) ^ _Xp.GetHashCode();
                result = (result * 397) ^ _Xa.GetHashCode();
                result = (result * 397) ^ _Yy.GetHashCode();
                result = (result * 397) ^ _Yz.GetHashCode();
                result = (result * 397) ^ _Yr.GetHashCode();
                result = (result * 397) ^ _Yp.GetHashCode();
                result = (result * 397) ^ _Ya.GetHashCode();
                result = (result * 397) ^ _Zz.GetHashCode();
                result = (result * 397) ^ _Zr.GetHashCode();
                result = (result * 397) ^ _Zp.GetHashCode();
                result = (result * 397) ^ _Za.GetHashCode();
                result = (result * 397) ^ _Rr.GetHashCode();
                result = (result * 397) ^ _Rp.GetHashCode();
                result = (result * 397) ^ _Ra.GetHashCode();
                result = (result * 397) ^ _Pp.GetHashCode();
                result = (result * 397) ^ _Pa.GetHashCode();
                result = (result * 397) ^ _Aa.GetHashCode();
                return result;
            }
        }
    }
 
    public class SpeedHeading3D : NotifyPropertyChangedBase
    {
        private System.Double _Speed;
            
        ///<exclude/>
        public System.Double Speed
        {
            get { return _Speed; }
            set 
            {
                if(!(_Speed.Equals(value)))
                {
                    _Speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
        private ReactiveRTM.RTC.Orientation3D _Direction;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Orientation3D Direction
        {
            get { return _Direction; }
            set 
            {
                if(!(_Direction.Equals(value)))
                {
                    _Direction = value;
                    RaisePropertyChanged("Direction");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.SpeedHeading3D (ReactiveRTM.RTC.SpeedHeading3D source)
        {
            var instance = new global::RTC.SpeedHeading3D();
            instance.speed =  source._Speed;
            instance.direction =  ((global::RTC.Orientation3D)((IStub)source._Direction).GetTarget());
            return instance;
        }
        public SpeedHeading3D ()
        {
            _Speed = new System.Double();
            _Direction = new ReactiveRTM.RTC.Orientation3D();
        }
        public SpeedHeading3D (global::RTC.SpeedHeading3D source)
        {
            _Speed = source.speed;
            _Direction = new ReactiveRTM.RTC.Orientation3D(source.direction);
        }

        ///<exclude/>
        public bool Equals(SpeedHeading3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Speed.Equals(_Speed) && other._Direction.Equals(_Direction);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(SpeedHeading3D)) return false;
            return Equals((SpeedHeading3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Speed.GetHashCode();
                result = (result * 397) ^ _Direction.GetHashCode();
                return result;
            }
        }
    }
 
    public class OAP : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Vector3D _Orientation;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector3D Orientation
        {
            get { return _Orientation; }
            set 
            {
                if(!(_Orientation.Equals(value)))
                {
                    _Orientation = value;
                    RaisePropertyChanged("Orientation");
                }
            }
        }
        private ReactiveRTM.RTC.Vector3D _Approach;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector3D Approach
        {
            get { return _Approach; }
            set 
            {
                if(!(_Approach.Equals(value)))
                {
                    _Approach = value;
                    RaisePropertyChanged("Approach");
                }
            }
        }
        private ReactiveRTM.RTC.Vector3D _Position;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector3D Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.OAP (ReactiveRTM.RTC.OAP source)
        {
            var instance = new global::RTC.OAP();
            instance.orientation =  ((global::RTC.Vector3D)((IStub)source._Orientation).GetTarget());
            instance.approach =  ((global::RTC.Vector3D)((IStub)source._Approach).GetTarget());
            instance.position =  ((global::RTC.Vector3D)((IStub)source._Position).GetTarget());
            return instance;
        }
        public OAP ()
        {
            _Orientation = new ReactiveRTM.RTC.Vector3D();
            _Approach = new ReactiveRTM.RTC.Vector3D();
            _Position = new ReactiveRTM.RTC.Vector3D();
        }
        public OAP (global::RTC.OAP source)
        {
            _Orientation = new ReactiveRTM.RTC.Vector3D(source.orientation);
            _Approach = new ReactiveRTM.RTC.Vector3D(source.approach);
            _Position = new ReactiveRTM.RTC.Vector3D(source.position);
        }

        ///<exclude/>
        public bool Equals(OAP other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Orientation.Equals(_Orientation) && other._Approach.Equals(_Approach) && other._Position.Equals(_Position);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(OAP)) return false;
            return Equals((OAP)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Orientation.GetHashCode();
                result = (result * 397) ^ _Approach.GetHashCode();
                result = (result * 397) ^ _Position.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedRGBColour : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.RGBColour _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RGBColour Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedRGBColour (ReactiveRTM.RTC.TimedRGBColour source)
        {
            var instance = new global::RTC.TimedRGBColour();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.RGBColour)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedRGBColour ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.RGBColour();
        }
        public TimedRGBColour (global::RTC.TimedRGBColour source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.RGBColour(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedRGBColour other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedRGBColour)) return false;
            return Equals((TimedRGBColour)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPoint2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Point2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPoint2D (ReactiveRTM.RTC.TimedPoint2D source)
        {
            var instance = new global::RTC.TimedPoint2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Point2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPoint2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Point2D();
        }
        public TimedPoint2D (global::RTC.TimedPoint2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Point2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPoint2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPoint2D)) return false;
            return Equals((TimedPoint2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedVector2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Vector2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedVector2D (ReactiveRTM.RTC.TimedVector2D source)
        {
            var instance = new global::RTC.TimedVector2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Vector2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedVector2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Vector2D();
        }
        public TimedVector2D (global::RTC.TimedVector2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Vector2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedVector2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedVector2D)) return false;
            return Equals((TimedVector2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPose2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Pose2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPose2D (ReactiveRTM.RTC.TimedPose2D source)
        {
            var instance = new global::RTC.TimedPose2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Pose2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPose2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Pose2D();
        }
        public TimedPose2D (global::RTC.TimedPose2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Pose2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPose2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPose2D)) return false;
            return Equals((TimedPose2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedVelocity2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedVelocity2D (ReactiveRTM.RTC.TimedVelocity2D source)
        {
            var instance = new global::RTC.TimedVelocity2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Velocity2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedVelocity2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Velocity2D();
        }
        public TimedVelocity2D (global::RTC.TimedVelocity2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Velocity2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedVelocity2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedVelocity2D)) return false;
            return Equals((TimedVelocity2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedAcceleration2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Acceleration2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Acceleration2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedAcceleration2D (ReactiveRTM.RTC.TimedAcceleration2D source)
        {
            var instance = new global::RTC.TimedAcceleration2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Acceleration2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedAcceleration2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Acceleration2D();
        }
        public TimedAcceleration2D (global::RTC.TimedAcceleration2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Acceleration2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedAcceleration2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedAcceleration2D)) return false;
            return Equals((TimedAcceleration2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPoseVel2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.PoseVel2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PoseVel2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPoseVel2D (ReactiveRTM.RTC.TimedPoseVel2D source)
        {
            var instance = new global::RTC.TimedPoseVel2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.PoseVel2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPoseVel2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.PoseVel2D();
        }
        public TimedPoseVel2D (global::RTC.TimedPoseVel2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.PoseVel2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPoseVel2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPoseVel2D)) return false;
            return Equals((TimedPoseVel2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedSize2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Size2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedSize2D (ReactiveRTM.RTC.TimedSize2D source)
        {
            var instance = new global::RTC.TimedSize2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Size2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedSize2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Size2D();
        }
        public TimedSize2D (global::RTC.TimedSize2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Size2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedSize2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedSize2D)) return false;
            return Equals((TimedSize2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedGeometry2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Geometry2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedGeometry2D (ReactiveRTM.RTC.TimedGeometry2D source)
        {
            var instance = new global::RTC.TimedGeometry2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Geometry2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedGeometry2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Geometry2D();
        }
        public TimedGeometry2D (global::RTC.TimedGeometry2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Geometry2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedGeometry2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedGeometry2D)) return false;
            return Equals((TimedGeometry2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedCovariance2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Covariance2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Covariance2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedCovariance2D (ReactiveRTM.RTC.TimedCovariance2D source)
        {
            var instance = new global::RTC.TimedCovariance2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Covariance2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedCovariance2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Covariance2D();
        }
        public TimedCovariance2D (global::RTC.TimedCovariance2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Covariance2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedCovariance2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedCovariance2D)) return false;
            return Equals((TimedCovariance2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPointCovariance2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.PointCovariance2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PointCovariance2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPointCovariance2D (ReactiveRTM.RTC.TimedPointCovariance2D source)
        {
            var instance = new global::RTC.TimedPointCovariance2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.PointCovariance2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPointCovariance2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.PointCovariance2D();
        }
        public TimedPointCovariance2D (global::RTC.TimedPointCovariance2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.PointCovariance2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPointCovariance2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPointCovariance2D)) return false;
            return Equals((TimedPointCovariance2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedCarlike : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Carlike _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Carlike Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedCarlike (ReactiveRTM.RTC.TimedCarlike source)
        {
            var instance = new global::RTC.TimedCarlike();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Carlike)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedCarlike ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Carlike();
        }
        public TimedCarlike (global::RTC.TimedCarlike source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Carlike(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedCarlike other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedCarlike)) return false;
            return Equals((TimedCarlike)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedSpeedHeading2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.SpeedHeading2D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.SpeedHeading2D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedSpeedHeading2D (ReactiveRTM.RTC.TimedSpeedHeading2D source)
        {
            var instance = new global::RTC.TimedSpeedHeading2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.SpeedHeading2D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedSpeedHeading2D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.SpeedHeading2D();
        }
        public TimedSpeedHeading2D (global::RTC.TimedSpeedHeading2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.SpeedHeading2D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedSpeedHeading2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedSpeedHeading2D)) return false;
            return Equals((TimedSpeedHeading2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPoint3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Point3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPoint3D (ReactiveRTM.RTC.TimedPoint3D source)
        {
            var instance = new global::RTC.TimedPoint3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Point3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPoint3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Point3D();
        }
        public TimedPoint3D (global::RTC.TimedPoint3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Point3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPoint3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPoint3D)) return false;
            return Equals((TimedPoint3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedVector3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Vector3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedVector3D (ReactiveRTM.RTC.TimedVector3D source)
        {
            var instance = new global::RTC.TimedVector3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Vector3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedVector3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Vector3D();
        }
        public TimedVector3D (global::RTC.TimedVector3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Vector3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedVector3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedVector3D)) return false;
            return Equals((TimedVector3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedOrientation3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Orientation3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Orientation3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedOrientation3D (ReactiveRTM.RTC.TimedOrientation3D source)
        {
            var instance = new global::RTC.TimedOrientation3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Orientation3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedOrientation3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Orientation3D();
        }
        public TimedOrientation3D (global::RTC.TimedOrientation3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Orientation3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedOrientation3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedOrientation3D)) return false;
            return Equals((TimedOrientation3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPose3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Pose3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPose3D (ReactiveRTM.RTC.TimedPose3D source)
        {
            var instance = new global::RTC.TimedPose3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Pose3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPose3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Pose3D();
        }
        public TimedPose3D (global::RTC.TimedPose3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Pose3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPose3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPose3D)) return false;
            return Equals((TimedPose3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedVelocity3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedVelocity3D (ReactiveRTM.RTC.TimedVelocity3D source)
        {
            var instance = new global::RTC.TimedVelocity3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Velocity3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedVelocity3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Velocity3D();
        }
        public TimedVelocity3D (global::RTC.TimedVelocity3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Velocity3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedVelocity3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedVelocity3D)) return false;
            return Equals((TimedVelocity3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedAngularVelocity3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.AngularVelocity3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.AngularVelocity3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedAngularVelocity3D (ReactiveRTM.RTC.TimedAngularVelocity3D source)
        {
            var instance = new global::RTC.TimedAngularVelocity3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.AngularVelocity3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedAngularVelocity3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.AngularVelocity3D();
        }
        public TimedAngularVelocity3D (global::RTC.TimedAngularVelocity3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.AngularVelocity3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedAngularVelocity3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedAngularVelocity3D)) return false;
            return Equals((TimedAngularVelocity3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedAcceleration3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Acceleration3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Acceleration3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedAcceleration3D (ReactiveRTM.RTC.TimedAcceleration3D source)
        {
            var instance = new global::RTC.TimedAcceleration3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Acceleration3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedAcceleration3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Acceleration3D();
        }
        public TimedAcceleration3D (global::RTC.TimedAcceleration3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Acceleration3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedAcceleration3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedAcceleration3D)) return false;
            return Equals((TimedAcceleration3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedAngularAcceleration3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.AngularAcceleration3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.AngularAcceleration3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedAngularAcceleration3D (ReactiveRTM.RTC.TimedAngularAcceleration3D source)
        {
            var instance = new global::RTC.TimedAngularAcceleration3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.AngularAcceleration3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedAngularAcceleration3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.AngularAcceleration3D();
        }
        public TimedAngularAcceleration3D (global::RTC.TimedAngularAcceleration3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.AngularAcceleration3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedAngularAcceleration3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedAngularAcceleration3D)) return false;
            return Equals((TimedAngularAcceleration3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedPoseVel3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.PoseVel3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PoseVel3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedPoseVel3D (ReactiveRTM.RTC.TimedPoseVel3D source)
        {
            var instance = new global::RTC.TimedPoseVel3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.PoseVel3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedPoseVel3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.PoseVel3D();
        }
        public TimedPoseVel3D (global::RTC.TimedPoseVel3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.PoseVel3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedPoseVel3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedPoseVel3D)) return false;
            return Equals((TimedPoseVel3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedSize3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Size3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedSize3D (ReactiveRTM.RTC.TimedSize3D source)
        {
            var instance = new global::RTC.TimedSize3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Size3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedSize3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Size3D();
        }
        public TimedSize3D (global::RTC.TimedSize3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Size3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedSize3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedSize3D)) return false;
            return Equals((TimedSize3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedGeometry3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Geometry3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedGeometry3D (ReactiveRTM.RTC.TimedGeometry3D source)
        {
            var instance = new global::RTC.TimedGeometry3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Geometry3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedGeometry3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Geometry3D();
        }
        public TimedGeometry3D (global::RTC.TimedGeometry3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Geometry3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedGeometry3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedGeometry3D)) return false;
            return Equals((TimedGeometry3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedCovariance3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.Covariance3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Covariance3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedCovariance3D (ReactiveRTM.RTC.TimedCovariance3D source)
        {
            var instance = new global::RTC.TimedCovariance3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.Covariance3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedCovariance3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.Covariance3D();
        }
        public TimedCovariance3D (global::RTC.TimedCovariance3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.Covariance3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedCovariance3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedCovariance3D)) return false;
            return Equals((TimedCovariance3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedSpeedHeading3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.SpeedHeading3D _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.SpeedHeading3D Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedSpeedHeading3D (ReactiveRTM.RTC.TimedSpeedHeading3D source)
        {
            var instance = new global::RTC.TimedSpeedHeading3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.SpeedHeading3D)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedSpeedHeading3D ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.SpeedHeading3D();
        }
        public TimedSpeedHeading3D (global::RTC.TimedSpeedHeading3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.SpeedHeading3D(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedSpeedHeading3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedSpeedHeading3D)) return false;
            return Equals((TimedSpeedHeading3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class TimedOAP : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.OAP _Data;
            
        ///<exclude/>
        public ReactiveRTM.RTC.OAP Data
        {
            get { return _Data; }
            set 
            {
                if(!(_Data.Equals(value)))
                {
                    _Data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.TimedOAP (ReactiveRTM.RTC.TimedOAP source)
        {
            var instance = new global::RTC.TimedOAP();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.data =  ((global::RTC.OAP)((IStub)source._Data).GetTarget());
            return instance;
        }
        public TimedOAP ()
        {
            _Tm = default(System.DateTime);
            _Data = new ReactiveRTM.RTC.OAP();
        }
        public TimedOAP (global::RTC.TimedOAP source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Data = new ReactiveRTM.RTC.OAP(source.data);
        }

        ///<exclude/>
        public bool Equals(TimedOAP other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Data.Equals(_Data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TimedOAP)) return false;
            return Equals((TimedOAP)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Data.GetHashCode();
                return result;
            }
        }
    }
 
    public class ActArrayActuatorPos : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Index;
            
        ///<exclude/>
        public System.Int16 Index
        {
            get { return _Index; }
            set 
            {
                if(!(_Index.Equals(value)))
                {
                    _Index = value;
                    RaisePropertyChanged("Index");
                }
            }
        }
        private System.Double _Position;
            
        ///<exclude/>
        public System.Double Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.ActArrayActuatorPos (ReactiveRTM.RTC.ActArrayActuatorPos source)
        {
            var instance = new global::RTC.ActArrayActuatorPos();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.index =  source._Index;
            instance.position =  source._Position;
            return instance;
        }
        public ActArrayActuatorPos ()
        {
            _Tm = default(System.DateTime);
            _Index = new System.Int16();
            _Position = new System.Double();
        }
        public ActArrayActuatorPos (global::RTC.ActArrayActuatorPos source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Index = source.index;
            _Position = source.position;
        }

        ///<exclude/>
        public bool Equals(ActArrayActuatorPos other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Index.Equals(_Index) && other._Position.Equals(_Position);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ActArrayActuatorPos)) return false;
            return Equals((ActArrayActuatorPos)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Index.GetHashCode();
                result = (result * 397) ^ _Position.GetHashCode();
                return result;
            }
        }
    }
 
    public class ActArrayActuatorSpeed : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Index;
            
        ///<exclude/>
        public System.Int16 Index
        {
            get { return _Index; }
            set 
            {
                if(!(_Index.Equals(value)))
                {
                    _Index = value;
                    RaisePropertyChanged("Index");
                }
            }
        }
        private System.Double _Speed;
            
        ///<exclude/>
        public System.Double Speed
        {
            get { return _Speed; }
            set 
            {
                if(!(_Speed.Equals(value)))
                {
                    _Speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.ActArrayActuatorSpeed (ReactiveRTM.RTC.ActArrayActuatorSpeed source)
        {
            var instance = new global::RTC.ActArrayActuatorSpeed();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.index =  source._Index;
            instance.speed =  source._Speed;
            return instance;
        }
        public ActArrayActuatorSpeed ()
        {
            _Tm = default(System.DateTime);
            _Index = new System.Int16();
            _Speed = new System.Double();
        }
        public ActArrayActuatorSpeed (global::RTC.ActArrayActuatorSpeed source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Index = source.index;
            _Speed = source.speed;
        }

        ///<exclude/>
        public bool Equals(ActArrayActuatorSpeed other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Index.Equals(_Index) && other._Speed.Equals(_Speed);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ActArrayActuatorSpeed)) return false;
            return Equals((ActArrayActuatorSpeed)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Index.GetHashCode();
                result = (result * 397) ^ _Speed.GetHashCode();
                return result;
            }
        }
    }
 
    public class ActArrayActuatorCurrent : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Index;
            
        ///<exclude/>
        public System.Int16 Index
        {
            get { return _Index; }
            set 
            {
                if(!(_Index.Equals(value)))
                {
                    _Index = value;
                    RaisePropertyChanged("Index");
                }
            }
        }
        private System.Double _Current;
            
        ///<exclude/>
        public System.Double Current
        {
            get { return _Current; }
            set 
            {
                if(!(_Current.Equals(value)))
                {
                    _Current = value;
                    RaisePropertyChanged("Current");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.ActArrayActuatorCurrent (ReactiveRTM.RTC.ActArrayActuatorCurrent source)
        {
            var instance = new global::RTC.ActArrayActuatorCurrent();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.index =  source._Index;
            instance.current =  source._Current;
            return instance;
        }
        public ActArrayActuatorCurrent ()
        {
            _Tm = default(System.DateTime);
            _Index = new System.Int16();
            _Current = new System.Double();
        }
        public ActArrayActuatorCurrent (global::RTC.ActArrayActuatorCurrent source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Index = source.index;
            _Current = source.current;
        }

        ///<exclude/>
        public bool Equals(ActArrayActuatorCurrent other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Index.Equals(_Index) && other._Current.Equals(_Current);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ActArrayActuatorCurrent)) return false;
            return Equals((ActArrayActuatorCurrent)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Index.GetHashCode();
                result = (result * 397) ^ _Current.GetHashCode();
                return result;
            }
        }
    }
 
    public class Actuator : NotifyPropertyChangedBase
    {
        private System.Double _Position;
            
        ///<exclude/>
        public System.Double Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        private System.Double _Speed;
            
        ///<exclude/>
        public System.Double Speed
        {
            get { return _Speed; }
            set 
            {
                if(!(_Speed.Equals(value)))
                {
                    _Speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
        private System.Double _Accel;
            
        ///<exclude/>
        public System.Double Accel
        {
            get { return _Accel; }
            set 
            {
                if(!(_Accel.Equals(value)))
                {
                    _Accel = value;
                    RaisePropertyChanged("Accel");
                }
            }
        }
        private System.Double _Current;
            
        ///<exclude/>
        public System.Double Current
        {
            get { return _Current; }
            set 
            {
                if(!(_Current.Equals(value)))
                {
                    _Current = value;
                    RaisePropertyChanged("Current");
                }
            }
        }
        private ReactiveRTM.RTC.ActArrayActuatorStatus _Status;
            
        ///<exclude/>
        public ReactiveRTM.RTC.ActArrayActuatorStatus Status
        {
            get { return _Status; }
            set 
            {
                if(!(_Status.Equals(value)))
                {
                    _Status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Actuator (ReactiveRTM.RTC.Actuator source)
        {
            var instance = new global::RTC.Actuator();
            instance.position =  source._Position;
            instance.speed =  source._Speed;
            instance.accel =  source._Accel;
            instance.current =  source._Current;
            instance.status =  (global::RTC.ActArrayActuatorStatus)source._Status;
            return instance;
        }
        public Actuator ()
        {
            _Position = new System.Double();
            _Speed = new System.Double();
            _Accel = new System.Double();
            _Current = new System.Double();
            _Status = new ReactiveRTM.RTC.ActArrayActuatorStatus();
        }
        public Actuator (global::RTC.Actuator source)
        {
            _Position = source.position;
            _Speed = source.speed;
            _Accel = source.accel;
            _Current = source.current;
            _Status = (ReactiveRTM.RTC.ActArrayActuatorStatus)source.status;
        }

        ///<exclude/>
        public bool Equals(Actuator other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Position.Equals(_Position) && other._Speed.Equals(_Speed) && other._Accel.Equals(_Accel) && other._Current.Equals(_Current) && other._Status.Equals(_Status);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Actuator)) return false;
            return Equals((Actuator)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Position.GetHashCode();
                result = (result * 397) ^ _Speed.GetHashCode();
                result = (result * 397) ^ _Accel.GetHashCode();
                result = (result * 397) ^ _Current.GetHashCode();
                result = (result * 397) ^ _Status.GetHashCode();
                return result;
            }
        }
    }
 
    public class ActArrayState : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.Actuator> _Actuators;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Actuator> Actuators
        {
            get { return _Actuators; }
            set 
            {
                if(!(_Actuators.SequenceEqual(value)))
                {
                    _Actuators = value;
                    RaisePropertyChanged("Actuators");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.ActArrayState (ReactiveRTM.RTC.ActArrayState source)
        {
            var instance = new global::RTC.ActArrayState();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.actuators =  source._Actuators.Select(x=>((global::RTC.Actuator)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public ActArrayState ()
        {
            _Tm = default(System.DateTime);
            _Actuators = new List<ReactiveRTM.RTC.Actuator>();
        }
        public ActArrayState (global::RTC.ActArrayState source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Actuators = source.actuators.Select(x => (ReactiveRTM.RTC.Actuator)new ReactiveRTM.RTC.Actuator(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(ActArrayState other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Actuators.SequenceEqual(_Actuators);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ActArrayState)) return false;
            return Equals((ActArrayState)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Actuators.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class ActArrayActuatorGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.ActArrayActuatorType _Type;
            
        ///<exclude/>
        public ReactiveRTM.RTC.ActArrayActuatorType Type
        {
            get { return _Type; }
            set 
            {
                if(!(_Type.Equals(value)))
                {
                    _Type = value;
                    RaisePropertyChanged("Type");
                }
            }
        }
        private System.Double _Length;
            
        ///<exclude/>
        public System.Double Length
        {
            get { return _Length; }
            set 
            {
                if(!(_Length.Equals(value)))
                {
                    _Length = value;
                    RaisePropertyChanged("Length");
                }
            }
        }
        private ReactiveRTM.RTC.Orientation3D _Orientation;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Orientation3D Orientation
        {
            get { return _Orientation; }
            set 
            {
                if(!(_Orientation.Equals(value)))
                {
                    _Orientation = value;
                    RaisePropertyChanged("Orientation");
                }
            }
        }
        private ReactiveRTM.RTC.Vector3D _Axis;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector3D Axis
        {
            get { return _Axis; }
            set 
            {
                if(!(_Axis.Equals(value)))
                {
                    _Axis = value;
                    RaisePropertyChanged("Axis");
                }
            }
        }
        private System.Double _MinRange;
            
        ///<exclude/>
        public System.Double MinRange
        {
            get { return _MinRange; }
            set 
            {
                if(!(_MinRange.Equals(value)))
                {
                    _MinRange = value;
                    RaisePropertyChanged("MinRange");
                }
            }
        }
        private System.Double _Centre;
            
        ///<exclude/>
        public System.Double Centre
        {
            get { return _Centre; }
            set 
            {
                if(!(_Centre.Equals(value)))
                {
                    _Centre = value;
                    RaisePropertyChanged("Centre");
                }
            }
        }
        private System.Double _MaxRange;
            
        ///<exclude/>
        public System.Double MaxRange
        {
            get { return _MaxRange; }
            set 
            {
                if(!(_MaxRange.Equals(value)))
                {
                    _MaxRange = value;
                    RaisePropertyChanged("MaxRange");
                }
            }
        }
        private System.Double _HomePosition;
            
        ///<exclude/>
        public System.Double HomePosition
        {
            get { return _HomePosition; }
            set 
            {
                if(!(_HomePosition.Equals(value)))
                {
                    _HomePosition = value;
                    RaisePropertyChanged("HomePosition");
                }
            }
        }
        private System.Boolean _HasBrakes;
            
        ///<exclude/>
        public System.Boolean HasBrakes
        {
            get { return _HasBrakes; }
            set 
            {
                if(!(_HasBrakes.Equals(value)))
                {
                    _HasBrakes = value;
                    RaisePropertyChanged("HasBrakes");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.ActArrayActuatorGeometry (ReactiveRTM.RTC.ActArrayActuatorGeometry source)
        {
            var instance = new global::RTC.ActArrayActuatorGeometry();
            instance.type =  (global::RTC.ActArrayActuatorType)source._Type;
            instance.length =  source._Length;
            instance.orientation =  ((global::RTC.Orientation3D)((IStub)source._Orientation).GetTarget());
            instance.axis =  ((global::RTC.Vector3D)((IStub)source._Axis).GetTarget());
            instance.minRange =  source._MinRange;
            instance.centre =  source._Centre;
            instance.maxRange =  source._MaxRange;
            instance.homePosition =  source._HomePosition;
            instance.hasBrakes =  source._HasBrakes;
            return instance;
        }
        public ActArrayActuatorGeometry ()
        {
            _Type = new ReactiveRTM.RTC.ActArrayActuatorType();
            _Length = new System.Double();
            _Orientation = new ReactiveRTM.RTC.Orientation3D();
            _Axis = new ReactiveRTM.RTC.Vector3D();
            _MinRange = new System.Double();
            _Centre = new System.Double();
            _MaxRange = new System.Double();
            _HomePosition = new System.Double();
            _HasBrakes = new System.Boolean();
        }
        public ActArrayActuatorGeometry (global::RTC.ActArrayActuatorGeometry source)
        {
            _Type = (ReactiveRTM.RTC.ActArrayActuatorType)source.type;
            _Length = source.length;
            _Orientation = new ReactiveRTM.RTC.Orientation3D(source.orientation);
            _Axis = new ReactiveRTM.RTC.Vector3D(source.axis);
            _MinRange = source.minRange;
            _Centre = source.centre;
            _MaxRange = source.maxRange;
            _HomePosition = source.homePosition;
            _HasBrakes = source.hasBrakes;
        }

        ///<exclude/>
        public bool Equals(ActArrayActuatorGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Type.Equals(_Type) && other._Length.Equals(_Length) && other._Orientation.Equals(_Orientation) && other._Axis.Equals(_Axis) && other._MinRange.Equals(_MinRange) && other._Centre.Equals(_Centre) && other._MaxRange.Equals(_MaxRange) && other._HomePosition.Equals(_HomePosition) && other._HasBrakes.Equals(_HasBrakes);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ActArrayActuatorGeometry)) return false;
            return Equals((ActArrayActuatorGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Type.GetHashCode();
                result = (result * 397) ^ _Length.GetHashCode();
                result = (result * 397) ^ _Orientation.GetHashCode();
                result = (result * 397) ^ _Axis.GetHashCode();
                result = (result * 397) ^ _MinRange.GetHashCode();
                result = (result * 397) ^ _Centre.GetHashCode();
                result = (result * 397) ^ _MaxRange.GetHashCode();
                result = (result * 397) ^ _HomePosition.GetHashCode();
                result = (result * 397) ^ _HasBrakes.GetHashCode();
                return result;
            }
        }
    }
 
    public class ActArrayGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Geometry3D _ArrayGeometry;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D ArrayGeometry
        {
            get { return _ArrayGeometry; }
            set 
            {
                if(!(_ArrayGeometry.Equals(value)))
                {
                    _ArrayGeometry = value;
                    RaisePropertyChanged("ArrayGeometry");
                }
            }
        }
        private List<ReactiveRTM.RTC.ActArrayActuatorGeometry> _ActuatorGeometry;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.ActArrayActuatorGeometry> ActuatorGeometry
        {
            get { return _ActuatorGeometry; }
            set 
            {
                if(!(_ActuatorGeometry.SequenceEqual(value)))
                {
                    _ActuatorGeometry = value;
                    RaisePropertyChanged("ActuatorGeometry");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.ActArrayGeometry (ReactiveRTM.RTC.ActArrayGeometry source)
        {
            var instance = new global::RTC.ActArrayGeometry();
            instance.arrayGeometry =  ((global::RTC.Geometry3D)((IStub)source._ArrayGeometry).GetTarget());
            instance.actuatorGeometry =  source._ActuatorGeometry.Select(x=>((global::RTC.ActArrayActuatorGeometry)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public ActArrayGeometry ()
        {
            _ArrayGeometry = new ReactiveRTM.RTC.Geometry3D();
            _ActuatorGeometry = new List<ReactiveRTM.RTC.ActArrayActuatorGeometry>();
        }
        public ActArrayGeometry (global::RTC.ActArrayGeometry source)
        {
            _ArrayGeometry = new ReactiveRTM.RTC.Geometry3D(source.arrayGeometry);
            _ActuatorGeometry = source.actuatorGeometry.Select(x => (ReactiveRTM.RTC.ActArrayActuatorGeometry)new ReactiveRTM.RTC.ActArrayActuatorGeometry(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(ActArrayGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._ArrayGeometry.Equals(_ArrayGeometry) && other._ActuatorGeometry.SequenceEqual(_ActuatorGeometry);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ActArrayGeometry)) return false;
            return Equals((ActArrayGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _ArrayGeometry.GetHashCode();
                result = _ActuatorGeometry.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class BumperGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose3D _Pose;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Pose
        {
            get { return _Pose; }
            set 
            {
                if(!(_Pose.Equals(value)))
                {
                    _Pose = value;
                    RaisePropertyChanged("Pose");
                }
            }
        }
        private ReactiveRTM.RTC.Size3D _Size;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size3D Size
        {
            get { return _Size; }
            set 
            {
                if(!(_Size.Equals(value)))
                {
                    _Size = value;
                    RaisePropertyChanged("Size");
                }
            }
        }
        private System.Double _Roc;
            
        ///<exclude/>
        public System.Double Roc
        {
            get { return _Roc; }
            set 
            {
                if(!(_Roc.Equals(value)))
                {
                    _Roc = value;
                    RaisePropertyChanged("Roc");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.BumperGeometry (ReactiveRTM.RTC.BumperGeometry source)
        {
            var instance = new global::RTC.BumperGeometry();
            instance.pose =  ((global::RTC.Pose3D)((IStub)source._Pose).GetTarget());
            instance.size =  ((global::RTC.Size3D)((IStub)source._Size).GetTarget());
            instance.roc =  source._Roc;
            return instance;
        }
        public BumperGeometry ()
        {
            _Pose = new ReactiveRTM.RTC.Pose3D();
            _Size = new ReactiveRTM.RTC.Size3D();
            _Roc = new System.Double();
        }
        public BumperGeometry (global::RTC.BumperGeometry source)
        {
            _Pose = new ReactiveRTM.RTC.Pose3D(source.pose);
            _Size = new ReactiveRTM.RTC.Size3D(source.size);
            _Roc = source.roc;
        }

        ///<exclude/>
        public bool Equals(BumperGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Pose.Equals(_Pose) && other._Size.Equals(_Size) && other._Roc.Equals(_Roc);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(BumperGeometry)) return false;
            return Equals((BumperGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Pose.GetHashCode();
                result = (result * 397) ^ _Size.GetHashCode();
                result = (result * 397) ^ _Roc.GetHashCode();
                return result;
            }
        }
    }
 
    public class BumperArrayGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Geometry3D _ArrayGeometry;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D ArrayGeometry
        {
            get { return _ArrayGeometry; }
            set 
            {
                if(!(_ArrayGeometry.Equals(value)))
                {
                    _ArrayGeometry = value;
                    RaisePropertyChanged("ArrayGeometry");
                }
            }
        }
        private List<ReactiveRTM.RTC.BumperGeometry> _BumperGeometry;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.BumperGeometry> BumperGeometry
        {
            get { return _BumperGeometry; }
            set 
            {
                if(!(_BumperGeometry.SequenceEqual(value)))
                {
                    _BumperGeometry = value;
                    RaisePropertyChanged("BumperGeometry");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.BumperArrayGeometry (ReactiveRTM.RTC.BumperArrayGeometry source)
        {
            var instance = new global::RTC.BumperArrayGeometry();
            instance.arrayGeometry =  ((global::RTC.Geometry3D)((IStub)source._ArrayGeometry).GetTarget());
            instance.bumperGeometry =  source._BumperGeometry.Select(x=>((global::RTC.BumperGeometry)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public BumperArrayGeometry ()
        {
            _ArrayGeometry = new ReactiveRTM.RTC.Geometry3D();
            _BumperGeometry = new List<ReactiveRTM.RTC.BumperGeometry>();
        }
        public BumperArrayGeometry (global::RTC.BumperArrayGeometry source)
        {
            _ArrayGeometry = new ReactiveRTM.RTC.Geometry3D(source.arrayGeometry);
            _BumperGeometry = source.bumperGeometry.Select(x => (ReactiveRTM.RTC.BumperGeometry)new ReactiveRTM.RTC.BumperGeometry(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(BumperArrayGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._ArrayGeometry.Equals(_ArrayGeometry) && other._BumperGeometry.SequenceEqual(_BumperGeometry);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(BumperArrayGeometry)) return false;
            return Equals((BumperArrayGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _ArrayGeometry.GetHashCode();
                result = _BumperGeometry.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class CameraImage : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Int16 _Width;
            
        ///<exclude/>
        public System.Int16 Width
        {
            get { return _Width; }
            set 
            {
                if(!(_Width.Equals(value)))
                {
                    _Width = value;
                    RaisePropertyChanged("Width");
                }
            }
        }
        private System.Int16 _Height;
            
        ///<exclude/>
        public System.Int16 Height
        {
            get { return _Height; }
            set 
            {
                if(!(_Height.Equals(value)))
                {
                    _Height = value;
                    RaisePropertyChanged("Height");
                }
            }
        }
        private System.Int16 _Bpp;
            
        ///<exclude/>
        public System.Int16 Bpp
        {
            get { return _Bpp; }
            set 
            {
                if(!(_Bpp.Equals(value)))
                {
                    _Bpp = value;
                    RaisePropertyChanged("Bpp");
                }
            }
        }
        private System.String _Format;
            
        ///<exclude/>
        public System.String Format
        {
            get { return _Format; }
            set 
            {
                if(!(_Format == (value)))
                {
                    _Format = value;
                    RaisePropertyChanged("Format");
                }
            }
        }
        private System.Double _FDiv;
            
        ///<exclude/>
        public System.Double FDiv
        {
            get { return _FDiv; }
            set 
            {
                if(!(_FDiv.Equals(value)))
                {
                    _FDiv = value;
                    RaisePropertyChanged("FDiv");
                }
            }
        }
        private List<System.Byte> _Pixels;
            
        ///<exclude/>
        public List<System.Byte> Pixels
        {
            get { return _Pixels; }
            set 
            {
                if(!(_Pixels.SequenceEqual(value)))
                {
                    _Pixels = value;
                    RaisePropertyChanged("Pixels");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.CameraImage (ReactiveRTM.RTC.CameraImage source)
        {
            var instance = new global::RTC.CameraImage();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.width =  source._Width;
            instance.height =  source._Height;
            instance.bpp =  source._Bpp;
            instance.format =  source._Format;
            instance.fDiv =  source._FDiv;
            instance.pixels =  source._Pixels.Select(x=>x).ToArray();
            return instance;
        }
        public CameraImage ()
        {
            _Tm = default(System.DateTime);
            _Width = new System.Int16();
            _Height = new System.Int16();
            _Bpp = new System.Int16();
            _Format = string.Empty;
            _FDiv = new System.Double();
            _Pixels = new List<System.Byte>();
        }
        public CameraImage (global::RTC.CameraImage source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Width = source.width;
            _Height = source.height;
            _Bpp = source.bpp;
            _Format = source.format;
            _FDiv = source.fDiv;
            _Pixels = source.pixels.Select(x => (System.Byte)x).ToList();
        }

        ///<exclude/>
        public bool Equals(CameraImage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Width.Equals(_Width) && other._Height.Equals(_Height) && other._Bpp.Equals(_Bpp) && other._Format == (_Format) && other._FDiv.Equals(_FDiv) && other._Pixels.SequenceEqual(_Pixels);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(CameraImage)) return false;
            return Equals((CameraImage)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Width.GetHashCode();
                result = (result * 397) ^ _Height.GetHashCode();
                result = (result * 397) ^ _Bpp.GetHashCode();
                result = (result * 397) ^ _Format.GetHashCode();
                result = (result * 397) ^ _FDiv.GetHashCode();
                result = _Pixels.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class CameraInfo : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Vector2D _FocalLength;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Vector2D FocalLength
        {
            get { return _FocalLength; }
            set 
            {
                if(!(_FocalLength.Equals(value)))
                {
                    _FocalLength = value;
                    RaisePropertyChanged("FocalLength");
                }
            }
        }
        private ReactiveRTM.RTC.Point2D _PrincipalPoint;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point2D PrincipalPoint
        {
            get { return _PrincipalPoint; }
            set 
            {
                if(!(_PrincipalPoint.Equals(value)))
                {
                    _PrincipalPoint = value;
                    RaisePropertyChanged("PrincipalPoint");
                }
            }
        }
        private System.Double _K1;
            
        ///<exclude/>
        public System.Double K1
        {
            get { return _K1; }
            set 
            {
                if(!(_K1.Equals(value)))
                {
                    _K1 = value;
                    RaisePropertyChanged("K1");
                }
            }
        }
        private System.Double _K2;
            
        ///<exclude/>
        public System.Double K2
        {
            get { return _K2; }
            set 
            {
                if(!(_K2.Equals(value)))
                {
                    _K2 = value;
                    RaisePropertyChanged("K2");
                }
            }
        }
        private System.Double _P1;
            
        ///<exclude/>
        public System.Double P1
        {
            get { return _P1; }
            set 
            {
                if(!(_P1.Equals(value)))
                {
                    _P1 = value;
                    RaisePropertyChanged("P1");
                }
            }
        }
        private System.Double _P2;
            
        ///<exclude/>
        public System.Double P2
        {
            get { return _P2; }
            set 
            {
                if(!(_P2.Equals(value)))
                {
                    _P2 = value;
                    RaisePropertyChanged("P2");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.CameraInfo (ReactiveRTM.RTC.CameraInfo source)
        {
            var instance = new global::RTC.CameraInfo();
            instance.focalLength =  ((global::RTC.Vector2D)((IStub)source._FocalLength).GetTarget());
            instance.principalPoint =  ((global::RTC.Point2D)((IStub)source._PrincipalPoint).GetTarget());
            instance.k1 =  source._K1;
            instance.k2 =  source._K2;
            instance.p1 =  source._P1;
            instance.p2 =  source._P2;
            return instance;
        }
        public CameraInfo ()
        {
            _FocalLength = new ReactiveRTM.RTC.Vector2D();
            _PrincipalPoint = new ReactiveRTM.RTC.Point2D();
            _K1 = new System.Double();
            _K2 = new System.Double();
            _P1 = new System.Double();
            _P2 = new System.Double();
        }
        public CameraInfo (global::RTC.CameraInfo source)
        {
            _FocalLength = new ReactiveRTM.RTC.Vector2D(source.focalLength);
            _PrincipalPoint = new ReactiveRTM.RTC.Point2D(source.principalPoint);
            _K1 = source.k1;
            _K2 = source.k2;
            _P1 = source.p1;
            _P2 = source.p2;
        }

        ///<exclude/>
        public bool Equals(CameraInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._FocalLength.Equals(_FocalLength) && other._PrincipalPoint.Equals(_PrincipalPoint) && other._K1.Equals(_K1) && other._K2.Equals(_K2) && other._P1.Equals(_P1) && other._P2.Equals(_P2);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(CameraInfo)) return false;
            return Equals((CameraInfo)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _FocalLength.GetHashCode();
                result = (result * 397) ^ _PrincipalPoint.GetHashCode();
                result = (result * 397) ^ _K1.GetHashCode();
                result = (result * 397) ^ _K2.GetHashCode();
                result = (result * 397) ^ _P1.GetHashCode();
                result = (result * 397) ^ _P2.GetHashCode();
                return result;
            }
        }
    }
 
    public class FiducialInfo : NotifyPropertyChangedBase
    {
        private System.Int32 _Id;
            
        ///<exclude/>
        public System.Int32 Id
        {
            get { return _Id; }
            set 
            {
                if(!(_Id.Equals(value)))
                {
                    _Id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }
        private ReactiveRTM.RTC.Pose3D _Pose;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Pose
        {
            get { return _Pose; }
            set 
            {
                if(!(_Pose.Equals(value)))
                {
                    _Pose = value;
                    RaisePropertyChanged("Pose");
                }
            }
        }
        private ReactiveRTM.RTC.Pose3D _PoseUncertainty;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D PoseUncertainty
        {
            get { return _PoseUncertainty; }
            set 
            {
                if(!(_PoseUncertainty.Equals(value)))
                {
                    _PoseUncertainty = value;
                    RaisePropertyChanged("PoseUncertainty");
                }
            }
        }
        private ReactiveRTM.RTC.Size3D _Size;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size3D Size
        {
            get { return _Size; }
            set 
            {
                if(!(_Size.Equals(value)))
                {
                    _Size = value;
                    RaisePropertyChanged("Size");
                }
            }
        }
        private ReactiveRTM.RTC.Size3D _SizeUncertainty;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Size3D SizeUncertainty
        {
            get { return _SizeUncertainty; }
            set 
            {
                if(!(_SizeUncertainty.Equals(value)))
                {
                    _SizeUncertainty = value;
                    RaisePropertyChanged("SizeUncertainty");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.FiducialInfo (ReactiveRTM.RTC.FiducialInfo source)
        {
            var instance = new global::RTC.FiducialInfo();
            instance.id =  source._Id;
            instance.pose =  ((global::RTC.Pose3D)((IStub)source._Pose).GetTarget());
            instance.poseUncertainty =  ((global::RTC.Pose3D)((IStub)source._PoseUncertainty).GetTarget());
            instance.size =  ((global::RTC.Size3D)((IStub)source._Size).GetTarget());
            instance.sizeUncertainty =  ((global::RTC.Size3D)((IStub)source._SizeUncertainty).GetTarget());
            return instance;
        }
        public FiducialInfo ()
        {
            _Id = new System.Int32();
            _Pose = new ReactiveRTM.RTC.Pose3D();
            _PoseUncertainty = new ReactiveRTM.RTC.Pose3D();
            _Size = new ReactiveRTM.RTC.Size3D();
            _SizeUncertainty = new ReactiveRTM.RTC.Size3D();
        }
        public FiducialInfo (global::RTC.FiducialInfo source)
        {
            _Id = source.id;
            _Pose = new ReactiveRTM.RTC.Pose3D(source.pose);
            _PoseUncertainty = new ReactiveRTM.RTC.Pose3D(source.poseUncertainty);
            _Size = new ReactiveRTM.RTC.Size3D(source.size);
            _SizeUncertainty = new ReactiveRTM.RTC.Size3D(source.sizeUncertainty);
        }

        ///<exclude/>
        public bool Equals(FiducialInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Id.Equals(_Id) && other._Pose.Equals(_Pose) && other._PoseUncertainty.Equals(_PoseUncertainty) && other._Size.Equals(_Size) && other._SizeUncertainty.Equals(_SizeUncertainty);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(FiducialInfo)) return false;
            return Equals((FiducialInfo)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Id.GetHashCode();
                result = (result * 397) ^ _Pose.GetHashCode();
                result = (result * 397) ^ _PoseUncertainty.GetHashCode();
                result = (result * 397) ^ _Size.GetHashCode();
                result = (result * 397) ^ _SizeUncertainty.GetHashCode();
                return result;
            }
        }
    }
 
    public class Fiducials : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.FiducialInfo> _FiducialsList;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.FiducialInfo> FiducialsList
        {
            get { return _FiducialsList; }
            set 
            {
                if(!(_FiducialsList.SequenceEqual(value)))
                {
                    _FiducialsList = value;
                    RaisePropertyChanged("FiducialsList");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Fiducials (ReactiveRTM.RTC.Fiducials source)
        {
            var instance = new global::RTC.Fiducials();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.fiducialsList =  source._FiducialsList.Select(x=>((global::RTC.FiducialInfo)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public Fiducials ()
        {
            _Tm = default(System.DateTime);
            _FiducialsList = new List<ReactiveRTM.RTC.FiducialInfo>();
        }
        public Fiducials (global::RTC.Fiducials source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _FiducialsList = source.fiducialsList.Select(x => (ReactiveRTM.RTC.FiducialInfo)new ReactiveRTM.RTC.FiducialInfo(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(Fiducials other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._FiducialsList.SequenceEqual(_FiducialsList);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Fiducials)) return false;
            return Equals((Fiducials)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _FiducialsList.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class FiducialFOV : NotifyPropertyChangedBase
    {
        private System.Double _MinRange;
            
        ///<exclude/>
        public System.Double MinRange
        {
            get { return _MinRange; }
            set 
            {
                if(!(_MinRange.Equals(value)))
                {
                    _MinRange = value;
                    RaisePropertyChanged("MinRange");
                }
            }
        }
        private System.Double _MaxRange;
            
        ///<exclude/>
        public System.Double MaxRange
        {
            get { return _MaxRange; }
            set 
            {
                if(!(_MaxRange.Equals(value)))
                {
                    _MaxRange = value;
                    RaisePropertyChanged("MaxRange");
                }
            }
        }
        private System.Double _ViewAngle;
            
        ///<exclude/>
        public System.Double ViewAngle
        {
            get { return _ViewAngle; }
            set 
            {
                if(!(_ViewAngle.Equals(value)))
                {
                    _ViewAngle = value;
                    RaisePropertyChanged("ViewAngle");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.FiducialFOV (ReactiveRTM.RTC.FiducialFOV source)
        {
            var instance = new global::RTC.FiducialFOV();
            instance.minRange =  source._MinRange;
            instance.maxRange =  source._MaxRange;
            instance.viewAngle =  source._ViewAngle;
            return instance;
        }
        public FiducialFOV ()
        {
            _MinRange = new System.Double();
            _MaxRange = new System.Double();
            _ViewAngle = new System.Double();
        }
        public FiducialFOV (global::RTC.FiducialFOV source)
        {
            _MinRange = source.minRange;
            _MaxRange = source.maxRange;
            _ViewAngle = source.viewAngle;
        }

        ///<exclude/>
        public bool Equals(FiducialFOV other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._MinRange.Equals(_MinRange) && other._MaxRange.Equals(_MaxRange) && other._ViewAngle.Equals(_ViewAngle);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(FiducialFOV)) return false;
            return Equals((FiducialFOV)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _MinRange.GetHashCode();
                result = (result * 397) ^ _MaxRange.GetHashCode();
                result = (result * 397) ^ _ViewAngle.GetHashCode();
                return result;
            }
        }
    }
 
    public class GPSTime : NotifyPropertyChangedBase
    {
        private System.Int32 _Sec;
            
        ///<exclude/>
        public System.Int32 Sec
        {
            get { return _Sec; }
            set 
            {
                if(!(_Sec.Equals(value)))
                {
                    _Sec = value;
                    RaisePropertyChanged("Sec");
                }
            }
        }
        private System.Int32 _Msec;
            
        ///<exclude/>
        public System.Int32 Msec
        {
            get { return _Msec; }
            set 
            {
                if(!(_Msec.Equals(value)))
                {
                    _Msec = value;
                    RaisePropertyChanged("Msec");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.GPSTime (ReactiveRTM.RTC.GPSTime source)
        {
            var instance = new global::RTC.GPSTime();
            instance.sec =  source._Sec;
            instance.msec =  source._Msec;
            return instance;
        }
        public GPSTime ()
        {
            _Sec = new System.Int32();
            _Msec = new System.Int32();
        }
        public GPSTime (global::RTC.GPSTime source)
        {
            _Sec = source.sec;
            _Msec = source.msec;
        }

        ///<exclude/>
        public bool Equals(GPSTime other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Sec.Equals(_Sec) && other._Msec.Equals(_Msec);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(GPSTime)) return false;
            return Equals((GPSTime)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Sec.GetHashCode();
                result = (result * 397) ^ _Msec.GetHashCode();
                return result;
            }
        }
    }
 
    public class GPSData : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.GPSTime _TimeFromGPS;
            
        ///<exclude/>
        public ReactiveRTM.RTC.GPSTime TimeFromGPS
        {
            get { return _TimeFromGPS; }
            set 
            {
                if(!(_TimeFromGPS.Equals(value)))
                {
                    _TimeFromGPS = value;
                    RaisePropertyChanged("TimeFromGPS");
                }
            }
        }
        private System.Double _Latitude;
            
        ///<exclude/>
        public System.Double Latitude
        {
            get { return _Latitude; }
            set 
            {
                if(!(_Latitude.Equals(value)))
                {
                    _Latitude = value;
                    RaisePropertyChanged("Latitude");
                }
            }
        }
        private System.Double _Longitude;
            
        ///<exclude/>
        public System.Double Longitude
        {
            get { return _Longitude; }
            set 
            {
                if(!(_Longitude.Equals(value)))
                {
                    _Longitude = value;
                    RaisePropertyChanged("Longitude");
                }
            }
        }
        private System.Double _Altitude;
            
        ///<exclude/>
        public System.Double Altitude
        {
            get { return _Altitude; }
            set 
            {
                if(!(_Altitude.Equals(value)))
                {
                    _Altitude = value;
                    RaisePropertyChanged("Altitude");
                }
            }
        }
        private System.Double _HorizontalError;
            
        ///<exclude/>
        public System.Double HorizontalError
        {
            get { return _HorizontalError; }
            set 
            {
                if(!(_HorizontalError.Equals(value)))
                {
                    _HorizontalError = value;
                    RaisePropertyChanged("HorizontalError");
                }
            }
        }
        private System.Double _VerticalError;
            
        ///<exclude/>
        public System.Double VerticalError
        {
            get { return _VerticalError; }
            set 
            {
                if(!(_VerticalError.Equals(value)))
                {
                    _VerticalError = value;
                    RaisePropertyChanged("VerticalError");
                }
            }
        }
        private System.Double _Heading;
            
        ///<exclude/>
        public System.Double Heading
        {
            get { return _Heading; }
            set 
            {
                if(!(_Heading.Equals(value)))
                {
                    _Heading = value;
                    RaisePropertyChanged("Heading");
                }
            }
        }
        private System.Double _HorizontalSpeed;
            
        ///<exclude/>
        public System.Double HorizontalSpeed
        {
            get { return _HorizontalSpeed; }
            set 
            {
                if(!(_HorizontalSpeed.Equals(value)))
                {
                    _HorizontalSpeed = value;
                    RaisePropertyChanged("HorizontalSpeed");
                }
            }
        }
        private System.Double _VerticalSpeed;
            
        ///<exclude/>
        public System.Double VerticalSpeed
        {
            get { return _VerticalSpeed; }
            set 
            {
                if(!(_VerticalSpeed.Equals(value)))
                {
                    _VerticalSpeed = value;
                    RaisePropertyChanged("VerticalSpeed");
                }
            }
        }
        private System.Int16 _NumSatellites;
            
        ///<exclude/>
        public System.Int16 NumSatellites
        {
            get { return _NumSatellites; }
            set 
            {
                if(!(_NumSatellites.Equals(value)))
                {
                    _NumSatellites = value;
                    RaisePropertyChanged("NumSatellites");
                }
            }
        }
        private ReactiveRTM.RTC.GPSFixType _FixType;
            
        ///<exclude/>
        public ReactiveRTM.RTC.GPSFixType FixType
        {
            get { return _FixType; }
            set 
            {
                if(!(_FixType.Equals(value)))
                {
                    _FixType = value;
                    RaisePropertyChanged("FixType");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.GPSData (ReactiveRTM.RTC.GPSData source)
        {
            var instance = new global::RTC.GPSData();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.timeFromGPS =  ((global::RTC.GPSTime)((IStub)source._TimeFromGPS).GetTarget());
            instance.latitude =  source._Latitude;
            instance.longitude =  source._Longitude;
            instance.altitude =  source._Altitude;
            instance.horizontalError =  source._HorizontalError;
            instance.verticalError =  source._VerticalError;
            instance.heading =  source._Heading;
            instance.horizontalSpeed =  source._HorizontalSpeed;
            instance.verticalSpeed =  source._VerticalSpeed;
            instance.numSatellites =  source._NumSatellites;
            instance.fixType =  (global::RTC.GPSFixType)source._FixType;
            return instance;
        }
        public GPSData ()
        {
            _Tm = default(System.DateTime);
            _TimeFromGPS = new ReactiveRTM.RTC.GPSTime();
            _Latitude = new System.Double();
            _Longitude = new System.Double();
            _Altitude = new System.Double();
            _HorizontalError = new System.Double();
            _VerticalError = new System.Double();
            _Heading = new System.Double();
            _HorizontalSpeed = new System.Double();
            _VerticalSpeed = new System.Double();
            _NumSatellites = new System.Int16();
            _FixType = new ReactiveRTM.RTC.GPSFixType();
        }
        public GPSData (global::RTC.GPSData source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _TimeFromGPS = new ReactiveRTM.RTC.GPSTime(source.timeFromGPS);
            _Latitude = source.latitude;
            _Longitude = source.longitude;
            _Altitude = source.altitude;
            _HorizontalError = source.horizontalError;
            _VerticalError = source.verticalError;
            _Heading = source.heading;
            _HorizontalSpeed = source.horizontalSpeed;
            _VerticalSpeed = source.verticalSpeed;
            _NumSatellites = source.numSatellites;
            _FixType = (ReactiveRTM.RTC.GPSFixType)source.fixType;
        }

        ///<exclude/>
        public bool Equals(GPSData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._TimeFromGPS.Equals(_TimeFromGPS) && other._Latitude.Equals(_Latitude) && other._Longitude.Equals(_Longitude) && other._Altitude.Equals(_Altitude) && other._HorizontalError.Equals(_HorizontalError) && other._VerticalError.Equals(_VerticalError) && other._Heading.Equals(_Heading) && other._HorizontalSpeed.Equals(_HorizontalSpeed) && other._VerticalSpeed.Equals(_VerticalSpeed) && other._NumSatellites.Equals(_NumSatellites) && other._FixType.Equals(_FixType);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(GPSData)) return false;
            return Equals((GPSData)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _TimeFromGPS.GetHashCode();
                result = (result * 397) ^ _Latitude.GetHashCode();
                result = (result * 397) ^ _Longitude.GetHashCode();
                result = (result * 397) ^ _Altitude.GetHashCode();
                result = (result * 397) ^ _HorizontalError.GetHashCode();
                result = (result * 397) ^ _VerticalError.GetHashCode();
                result = (result * 397) ^ _Heading.GetHashCode();
                result = (result * 397) ^ _HorizontalSpeed.GetHashCode();
                result = (result * 397) ^ _VerticalSpeed.GetHashCode();
                result = (result * 397) ^ _NumSatellites.GetHashCode();
                result = (result * 397) ^ _FixType.GetHashCode();
                return result;
            }
        }
    }
 
    public class GripperState : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.GripperStatus _Status;
            
        ///<exclude/>
        public ReactiveRTM.RTC.GripperStatus Status
        {
            get { return _Status; }
            set 
            {
                if(!(_Status.Equals(value)))
                {
                    _Status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.GripperState (ReactiveRTM.RTC.GripperState source)
        {
            var instance = new global::RTC.GripperState();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.status =  (global::RTC.GripperStatus)source._Status;
            return instance;
        }
        public GripperState ()
        {
            _Tm = default(System.DateTime);
            _Status = new ReactiveRTM.RTC.GripperStatus();
        }
        public GripperState (global::RTC.GripperState source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Status = (ReactiveRTM.RTC.GripperStatus)source.status;
        }

        ///<exclude/>
        public bool Equals(GripperState other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Status.Equals(_Status);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(GripperState)) return false;
            return Equals((GripperState)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Status.GetHashCode();
                return result;
            }
        }
    }
 
    public class GripperGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Geometry3D _Exterior;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D Exterior
        {
            get { return _Exterior; }
            set 
            {
                if(!(_Exterior.Equals(value)))
                {
                    _Exterior = value;
                    RaisePropertyChanged("Exterior");
                }
            }
        }
        private ReactiveRTM.RTC.Geometry3D _Interior;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D Interior
        {
            get { return _Interior; }
            set 
            {
                if(!(_Interior.Equals(value)))
                {
                    _Interior = value;
                    RaisePropertyChanged("Interior");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.GripperGeometry (ReactiveRTM.RTC.GripperGeometry source)
        {
            var instance = new global::RTC.GripperGeometry();
            instance.exterior =  ((global::RTC.Geometry3D)((IStub)source._Exterior).GetTarget());
            instance.interior =  ((global::RTC.Geometry3D)((IStub)source._Interior).GetTarget());
            return instance;
        }
        public GripperGeometry ()
        {
            _Exterior = new ReactiveRTM.RTC.Geometry3D();
            _Interior = new ReactiveRTM.RTC.Geometry3D();
        }
        public GripperGeometry (global::RTC.GripperGeometry source)
        {
            _Exterior = new ReactiveRTM.RTC.Geometry3D(source.exterior);
            _Interior = new ReactiveRTM.RTC.Geometry3D(source.interior);
        }

        ///<exclude/>
        public bool Equals(GripperGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Exterior.Equals(_Exterior) && other._Interior.Equals(_Interior);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(GripperGeometry)) return false;
            return Equals((GripperGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Exterior.GetHashCode();
                result = (result * 397) ^ _Interior.GetHashCode();
                return result;
            }
        }
    }
 
    public class INSData : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Double _Latitude;
            
        ///<exclude/>
        public System.Double Latitude
        {
            get { return _Latitude; }
            set 
            {
                if(!(_Latitude.Equals(value)))
                {
                    _Latitude = value;
                    RaisePropertyChanged("Latitude");
                }
            }
        }
        private System.Double _Longitude;
            
        ///<exclude/>
        public System.Double Longitude
        {
            get { return _Longitude; }
            set 
            {
                if(!(_Longitude.Equals(value)))
                {
                    _Longitude = value;
                    RaisePropertyChanged("Longitude");
                }
            }
        }
        private System.Double _Altitude;
            
        ///<exclude/>
        public System.Double Altitude
        {
            get { return _Altitude; }
            set 
            {
                if(!(_Altitude.Equals(value)))
                {
                    _Altitude = value;
                    RaisePropertyChanged("Altitude");
                }
            }
        }
        private System.Double _HeightAMSL;
            
        ///<exclude/>
        public System.Double HeightAMSL
        {
            get { return _HeightAMSL; }
            set 
            {
                if(!(_HeightAMSL.Equals(value)))
                {
                    _HeightAMSL = value;
                    RaisePropertyChanged("HeightAMSL");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity3D _VelocityENU;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity3D VelocityENU
        {
            get { return _VelocityENU; }
            set 
            {
                if(!(_VelocityENU.Equals(value)))
                {
                    _VelocityENU = value;
                    RaisePropertyChanged("VelocityENU");
                }
            }
        }
        private ReactiveRTM.RTC.Orientation3D _Orientation;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Orientation3D Orientation
        {
            get { return _Orientation; }
            set 
            {
                if(!(_Orientation.Equals(value)))
                {
                    _Orientation = value;
                    RaisePropertyChanged("Orientation");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.INSData (ReactiveRTM.RTC.INSData source)
        {
            var instance = new global::RTC.INSData();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.latitude =  source._Latitude;
            instance.longitude =  source._Longitude;
            instance.altitude =  source._Altitude;
            instance.heightAMSL =  source._HeightAMSL;
            instance.velocityENU =  ((global::RTC.Velocity3D)((IStub)source._VelocityENU).GetTarget());
            instance.orientation =  ((global::RTC.Orientation3D)((IStub)source._Orientation).GetTarget());
            return instance;
        }
        public INSData ()
        {
            _Tm = default(System.DateTime);
            _Latitude = new System.Double();
            _Longitude = new System.Double();
            _Altitude = new System.Double();
            _HeightAMSL = new System.Double();
            _VelocityENU = new ReactiveRTM.RTC.Velocity3D();
            _Orientation = new ReactiveRTM.RTC.Orientation3D();
        }
        public INSData (global::RTC.INSData source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Latitude = source.latitude;
            _Longitude = source.longitude;
            _Altitude = source.altitude;
            _HeightAMSL = source.heightAMSL;
            _VelocityENU = new ReactiveRTM.RTC.Velocity3D(source.velocityENU);
            _Orientation = new ReactiveRTM.RTC.Orientation3D(source.orientation);
        }

        ///<exclude/>
        public bool Equals(INSData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Latitude.Equals(_Latitude) && other._Longitude.Equals(_Longitude) && other._Altitude.Equals(_Altitude) && other._HeightAMSL.Equals(_HeightAMSL) && other._VelocityENU.Equals(_VelocityENU) && other._Orientation.Equals(_Orientation);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(INSData)) return false;
            return Equals((INSData)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Latitude.GetHashCode();
                result = (result * 397) ^ _Longitude.GetHashCode();
                result = (result * 397) ^ _Altitude.GetHashCode();
                result = (result * 397) ^ _HeightAMSL.GetHashCode();
                result = (result * 397) ^ _VelocityENU.GetHashCode();
                result = (result * 397) ^ _Orientation.GetHashCode();
                return result;
            }
        }
    }
 
    public class LimbState : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.OAP _OapMatrix;
            
        ///<exclude/>
        public ReactiveRTM.RTC.OAP OapMatrix
        {
            get { return _OapMatrix; }
            set 
            {
                if(!(_OapMatrix.Equals(value)))
                {
                    _OapMatrix = value;
                    RaisePropertyChanged("OapMatrix");
                }
            }
        }
        private ReactiveRTM.RTC.LimbStatus _Status;
            
        ///<exclude/>
        public ReactiveRTM.RTC.LimbStatus Status
        {
            get { return _Status; }
            set 
            {
                if(!(_Status.Equals(value)))
                {
                    _Status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.LimbState (ReactiveRTM.RTC.LimbState source)
        {
            var instance = new global::RTC.LimbState();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.oapMatrix =  ((global::RTC.OAP)((IStub)source._OapMatrix).GetTarget());
            instance.status =  (global::RTC.LimbStatus)source._Status;
            return instance;
        }
        public LimbState ()
        {
            _Tm = default(System.DateTime);
            _OapMatrix = new ReactiveRTM.RTC.OAP();
            _Status = new ReactiveRTM.RTC.LimbStatus();
        }
        public LimbState (global::RTC.LimbState source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _OapMatrix = new ReactiveRTM.RTC.OAP(source.oapMatrix);
            _Status = (ReactiveRTM.RTC.LimbStatus)source.status;
        }

        ///<exclude/>
        public bool Equals(LimbState other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._OapMatrix.Equals(_OapMatrix) && other._Status.Equals(_Status);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(LimbState)) return false;
            return Equals((LimbState)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _OapMatrix.GetHashCode();
                result = (result * 397) ^ _Status.GetHashCode();
                return result;
            }
        }
    }
 
    public class Hypothesis2D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose2D _Mean;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Mean
        {
            get { return _Mean; }
            set 
            {
                if(!(_Mean.Equals(value)))
                {
                    _Mean = value;
                    RaisePropertyChanged("Mean");
                }
            }
        }
        private ReactiveRTM.RTC.Covariance2D _Covariance;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Covariance2D Covariance
        {
            get { return _Covariance; }
            set 
            {
                if(!(_Covariance.Equals(value)))
                {
                    _Covariance = value;
                    RaisePropertyChanged("Covariance");
                }
            }
        }
        private System.Double _Weight;
            
        ///<exclude/>
        public System.Double Weight
        {
            get { return _Weight; }
            set 
            {
                if(!(_Weight.Equals(value)))
                {
                    _Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Hypothesis2D (ReactiveRTM.RTC.Hypothesis2D source)
        {
            var instance = new global::RTC.Hypothesis2D();
            instance.mean =  ((global::RTC.Pose2D)((IStub)source._Mean).GetTarget());
            instance.covariance =  ((global::RTC.Covariance2D)((IStub)source._Covariance).GetTarget());
            instance.weight =  source._Weight;
            return instance;
        }
        public Hypothesis2D ()
        {
            _Mean = new ReactiveRTM.RTC.Pose2D();
            _Covariance = new ReactiveRTM.RTC.Covariance2D();
            _Weight = new System.Double();
        }
        public Hypothesis2D (global::RTC.Hypothesis2D source)
        {
            _Mean = new ReactiveRTM.RTC.Pose2D(source.mean);
            _Covariance = new ReactiveRTM.RTC.Covariance2D(source.covariance);
            _Weight = source.weight;
        }

        ///<exclude/>
        public bool Equals(Hypothesis2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Mean.Equals(_Mean) && other._Covariance.Equals(_Covariance) && other._Weight.Equals(_Weight);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Hypothesis2D)) return false;
            return Equals((Hypothesis2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Mean.GetHashCode();
                result = (result * 397) ^ _Covariance.GetHashCode();
                result = (result * 397) ^ _Weight.GetHashCode();
                return result;
            }
        }
    }
 
    public class Hypotheses2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.Hypothesis2D> _Hypotheses;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Hypothesis2D> Hypotheses
        {
            get { return _Hypotheses; }
            set 
            {
                if(!(_Hypotheses.SequenceEqual(value)))
                {
                    _Hypotheses = value;
                    RaisePropertyChanged("Hypotheses");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Hypotheses2D (ReactiveRTM.RTC.Hypotheses2D source)
        {
            var instance = new global::RTC.Hypotheses2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.hypotheses =  source._Hypotheses.Select(x=>((global::RTC.Hypothesis2D)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public Hypotheses2D ()
        {
            _Tm = default(System.DateTime);
            _Hypotheses = new List<ReactiveRTM.RTC.Hypothesis2D>();
        }
        public Hypotheses2D (global::RTC.Hypotheses2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Hypotheses = source.hypotheses.Select(x => (ReactiveRTM.RTC.Hypothesis2D)new ReactiveRTM.RTC.Hypothesis2D(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(Hypotheses2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Hypotheses.SequenceEqual(_Hypotheses);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Hypotheses2D)) return false;
            return Equals((Hypotheses2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Hypotheses.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class Hypothesis3D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose3D _Mean;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Mean
        {
            get { return _Mean; }
            set 
            {
                if(!(_Mean.Equals(value)))
                {
                    _Mean = value;
                    RaisePropertyChanged("Mean");
                }
            }
        }
        private ReactiveRTM.RTC.Covariance3D _Covariance;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Covariance3D Covariance
        {
            get { return _Covariance; }
            set 
            {
                if(!(_Covariance.Equals(value)))
                {
                    _Covariance = value;
                    RaisePropertyChanged("Covariance");
                }
            }
        }
        private System.Double _Weight;
            
        ///<exclude/>
        public System.Double Weight
        {
            get { return _Weight; }
            set 
            {
                if(!(_Weight.Equals(value)))
                {
                    _Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Hypothesis3D (ReactiveRTM.RTC.Hypothesis3D source)
        {
            var instance = new global::RTC.Hypothesis3D();
            instance.mean =  ((global::RTC.Pose3D)((IStub)source._Mean).GetTarget());
            instance.covariance =  ((global::RTC.Covariance3D)((IStub)source._Covariance).GetTarget());
            instance.weight =  source._Weight;
            return instance;
        }
        public Hypothesis3D ()
        {
            _Mean = new ReactiveRTM.RTC.Pose3D();
            _Covariance = new ReactiveRTM.RTC.Covariance3D();
            _Weight = new System.Double();
        }
        public Hypothesis3D (global::RTC.Hypothesis3D source)
        {
            _Mean = new ReactiveRTM.RTC.Pose3D(source.mean);
            _Covariance = new ReactiveRTM.RTC.Covariance3D(source.covariance);
            _Weight = source.weight;
        }

        ///<exclude/>
        public bool Equals(Hypothesis3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Mean.Equals(_Mean) && other._Covariance.Equals(_Covariance) && other._Weight.Equals(_Weight);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Hypothesis3D)) return false;
            return Equals((Hypothesis3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Mean.GetHashCode();
                result = (result * 397) ^ _Covariance.GetHashCode();
                result = (result * 397) ^ _Weight.GetHashCode();
                return result;
            }
        }
    }
 
    public class Hypotheses3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.Hypothesis3D> _Hypotheses;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Hypothesis3D> Hypotheses
        {
            get { return _Hypotheses; }
            set 
            {
                if(!(_Hypotheses.SequenceEqual(value)))
                {
                    _Hypotheses = value;
                    RaisePropertyChanged("Hypotheses");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Hypotheses3D (ReactiveRTM.RTC.Hypotheses3D source)
        {
            var instance = new global::RTC.Hypotheses3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.hypotheses =  source._Hypotheses.Select(x=>((global::RTC.Hypothesis3D)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public Hypotheses3D ()
        {
            _Tm = default(System.DateTime);
            _Hypotheses = new List<ReactiveRTM.RTC.Hypothesis3D>();
        }
        public Hypotheses3D (global::RTC.Hypotheses3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Hypotheses = source.hypotheses.Select(x => (ReactiveRTM.RTC.Hypothesis3D)new ReactiveRTM.RTC.Hypothesis3D(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(Hypotheses3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Hypotheses.SequenceEqual(_Hypotheses);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Hypotheses3D)) return false;
            return Equals((Hypotheses3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Hypotheses.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class OGMapConfig : NotifyPropertyChangedBase
    {
        private System.Double _XScale;
            
        ///<exclude/>
        public System.Double XScale
        {
            get { return _XScale; }
            set 
            {
                if(!(_XScale.Equals(value)))
                {
                    _XScale = value;
                    RaisePropertyChanged("XScale");
                }
            }
        }
        private System.Double _YScale;
            
        ///<exclude/>
        public System.Double YScale
        {
            get { return _YScale; }
            set 
            {
                if(!(_YScale.Equals(value)))
                {
                    _YScale = value;
                    RaisePropertyChanged("YScale");
                }
            }
        }
        private System.Int32 _Width;
            
        ///<exclude/>
        public System.Int32 Width
        {
            get { return _Width; }
            set 
            {
                if(!(_Width.Equals(value)))
                {
                    _Width = value;
                    RaisePropertyChanged("Width");
                }
            }
        }
        private System.Int32 _Height;
            
        ///<exclude/>
        public System.Int32 Height
        {
            get { return _Height; }
            set 
            {
                if(!(_Height.Equals(value)))
                {
                    _Height = value;
                    RaisePropertyChanged("Height");
                }
            }
        }
        private ReactiveRTM.RTC.Pose2D _Origin;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Origin
        {
            get { return _Origin; }
            set 
            {
                if(!(_Origin.Equals(value)))
                {
                    _Origin = value;
                    RaisePropertyChanged("Origin");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.OGMapConfig (ReactiveRTM.RTC.OGMapConfig source)
        {
            var instance = new global::RTC.OGMapConfig();
            instance.xScale =  source._XScale;
            instance.yScale =  source._YScale;
            instance.width =  source._Width;
            instance.height =  source._Height;
            instance.origin =  ((global::RTC.Pose2D)((IStub)source._Origin).GetTarget());
            return instance;
        }
        public OGMapConfig ()
        {
            _XScale = new System.Double();
            _YScale = new System.Double();
            _Width = new System.Int32();
            _Height = new System.Int32();
            _Origin = new ReactiveRTM.RTC.Pose2D();
        }
        public OGMapConfig (global::RTC.OGMapConfig source)
        {
            _XScale = source.xScale;
            _YScale = source.yScale;
            _Width = source.width;
            _Height = source.height;
            _Origin = new ReactiveRTM.RTC.Pose2D(source.origin);
        }

        ///<exclude/>
        public bool Equals(OGMapConfig other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._XScale.Equals(_XScale) && other._YScale.Equals(_YScale) && other._Width.Equals(_Width) && other._Height.Equals(_Height) && other._Origin.Equals(_Origin);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(OGMapConfig)) return false;
            return Equals((OGMapConfig)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _XScale.GetHashCode();
                result = (result * 397) ^ _YScale.GetHashCode();
                result = (result * 397) ^ _Width.GetHashCode();
                result = (result * 397) ^ _Height.GetHashCode();
                result = (result * 397) ^ _Origin.GetHashCode();
                return result;
            }
        }
    }
 
    public class OGMapTile : NotifyPropertyChangedBase
    {
        private System.Int32 _Column;
            
        ///<exclude/>
        public System.Int32 Column
        {
            get { return _Column; }
            set 
            {
                if(!(_Column.Equals(value)))
                {
                    _Column = value;
                    RaisePropertyChanged("Column");
                }
            }
        }
        private System.Int32 _Row;
            
        ///<exclude/>
        public System.Int32 Row
        {
            get { return _Row; }
            set 
            {
                if(!(_Row.Equals(value)))
                {
                    _Row = value;
                    RaisePropertyChanged("Row");
                }
            }
        }
        private System.Int32 _Width;
            
        ///<exclude/>
        public System.Int32 Width
        {
            get { return _Width; }
            set 
            {
                if(!(_Width.Equals(value)))
                {
                    _Width = value;
                    RaisePropertyChanged("Width");
                }
            }
        }
        private System.Int32 _Height;
            
        ///<exclude/>
        public System.Int32 Height
        {
            get { return _Height; }
            set 
            {
                if(!(_Height.Equals(value)))
                {
                    _Height = value;
                    RaisePropertyChanged("Height");
                }
            }
        }
        private List<System.Byte> _Cells;
            
        ///<exclude/>
        public List<System.Byte> Cells
        {
            get { return _Cells; }
            set 
            {
                if(!(_Cells.SequenceEqual(value)))
                {
                    _Cells = value;
                    RaisePropertyChanged("Cells");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.OGMapTile (ReactiveRTM.RTC.OGMapTile source)
        {
            var instance = new global::RTC.OGMapTile();
            instance.column =  source._Column;
            instance.row =  source._Row;
            instance.width =  source._Width;
            instance.height =  source._Height;
            instance.cells =  source._Cells.Select(x=>x).ToArray();
            return instance;
        }
        public OGMapTile ()
        {
            _Column = new System.Int32();
            _Row = new System.Int32();
            _Width = new System.Int32();
            _Height = new System.Int32();
            _Cells = new List<System.Byte>();
        }
        public OGMapTile (global::RTC.OGMapTile source)
        {
            _Column = source.column;
            _Row = source.row;
            _Width = source.width;
            _Height = source.height;
            _Cells = source.cells.Select(x => (System.Byte)x).ToList();
        }

        ///<exclude/>
        public bool Equals(OGMapTile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Column.Equals(_Column) && other._Row.Equals(_Row) && other._Width.Equals(_Width) && other._Height.Equals(_Height) && other._Cells.SequenceEqual(_Cells);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(OGMapTile)) return false;
            return Equals((OGMapTile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Column.GetHashCode();
                result = (result * 397) ^ _Row.GetHashCode();
                result = (result * 397) ^ _Width.GetHashCode();
                result = (result * 397) ^ _Height.GetHashCode();
                result = _Cells.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class PointFeature : NotifyPropertyChangedBase
    {
        private System.Double _Probability;
            
        ///<exclude/>
        public System.Double Probability
        {
            get { return _Probability; }
            set 
            {
                if(!(_Probability.Equals(value)))
                {
                    _Probability = value;
                    RaisePropertyChanged("Probability");
                }
            }
        }
        private ReactiveRTM.RTC.Point2D _Position;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point2D Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        private ReactiveRTM.RTC.PointCovariance2D _Covariance;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PointCovariance2D Covariance
        {
            get { return _Covariance; }
            set 
            {
                if(!(_Covariance.Equals(value)))
                {
                    _Covariance = value;
                    RaisePropertyChanged("Covariance");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PointFeature (ReactiveRTM.RTC.PointFeature source)
        {
            var instance = new global::RTC.PointFeature();
            instance.probability =  source._Probability;
            instance.position =  ((global::RTC.Point2D)((IStub)source._Position).GetTarget());
            instance.covariance =  ((global::RTC.PointCovariance2D)((IStub)source._Covariance).GetTarget());
            return instance;
        }
        public PointFeature ()
        {
            _Probability = new System.Double();
            _Position = new ReactiveRTM.RTC.Point2D();
            _Covariance = new ReactiveRTM.RTC.PointCovariance2D();
        }
        public PointFeature (global::RTC.PointFeature source)
        {
            _Probability = source.probability;
            _Position = new ReactiveRTM.RTC.Point2D(source.position);
            _Covariance = new ReactiveRTM.RTC.PointCovariance2D(source.covariance);
        }

        ///<exclude/>
        public bool Equals(PointFeature other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Probability.Equals(_Probability) && other._Position.Equals(_Position) && other._Covariance.Equals(_Covariance);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PointFeature)) return false;
            return Equals((PointFeature)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Probability.GetHashCode();
                result = (result * 397) ^ _Position.GetHashCode();
                result = (result * 397) ^ _Covariance.GetHashCode();
                return result;
            }
        }
    }
 
    public class PoseFeature : NotifyPropertyChangedBase
    {
        private System.Double _Probability;
            
        ///<exclude/>
        public System.Double Probability
        {
            get { return _Probability; }
            set 
            {
                if(!(_Probability.Equals(value)))
                {
                    _Probability = value;
                    RaisePropertyChanged("Probability");
                }
            }
        }
        private ReactiveRTM.RTC.Pose2D _Position;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Position
        {
            get { return _Position; }
            set 
            {
                if(!(_Position.Equals(value)))
                {
                    _Position = value;
                    RaisePropertyChanged("Position");
                }
            }
        }
        private ReactiveRTM.RTC.Covariance2D _Covariance;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Covariance2D Covariance
        {
            get { return _Covariance; }
            set 
            {
                if(!(_Covariance.Equals(value)))
                {
                    _Covariance = value;
                    RaisePropertyChanged("Covariance");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PoseFeature (ReactiveRTM.RTC.PoseFeature source)
        {
            var instance = new global::RTC.PoseFeature();
            instance.probability =  source._Probability;
            instance.position =  ((global::RTC.Pose2D)((IStub)source._Position).GetTarget());
            instance.covariance =  ((global::RTC.Covariance2D)((IStub)source._Covariance).GetTarget());
            return instance;
        }
        public PoseFeature ()
        {
            _Probability = new System.Double();
            _Position = new ReactiveRTM.RTC.Pose2D();
            _Covariance = new ReactiveRTM.RTC.Covariance2D();
        }
        public PoseFeature (global::RTC.PoseFeature source)
        {
            _Probability = source.probability;
            _Position = new ReactiveRTM.RTC.Pose2D(source.position);
            _Covariance = new ReactiveRTM.RTC.Covariance2D(source.covariance);
        }

        ///<exclude/>
        public bool Equals(PoseFeature other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Probability.Equals(_Probability) && other._Position.Equals(_Position) && other._Covariance.Equals(_Covariance);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PoseFeature)) return false;
            return Equals((PoseFeature)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Probability.GetHashCode();
                result = (result * 397) ^ _Position.GetHashCode();
                result = (result * 397) ^ _Covariance.GetHashCode();
                return result;
            }
        }
    }
 
    public class LineFeature : NotifyPropertyChangedBase
    {
        private System.Double _Probability;
            
        ///<exclude/>
        public System.Double Probability
        {
            get { return _Probability; }
            set 
            {
                if(!(_Probability.Equals(value)))
                {
                    _Probability = value;
                    RaisePropertyChanged("Probability");
                }
            }
        }
        private System.Double _Rho;
            
        ///<exclude/>
        public System.Double Rho
        {
            get { return _Rho; }
            set 
            {
                if(!(_Rho.Equals(value)))
                {
                    _Rho = value;
                    RaisePropertyChanged("Rho");
                }
            }
        }
        private System.Double _Alpha;
            
        ///<exclude/>
        public System.Double Alpha
        {
            get { return _Alpha; }
            set 
            {
                if(!(_Alpha.Equals(value)))
                {
                    _Alpha = value;
                    RaisePropertyChanged("Alpha");
                }
            }
        }
        private ReactiveRTM.RTC.PointCovariance2D _Covariance;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PointCovariance2D Covariance
        {
            get { return _Covariance; }
            set 
            {
                if(!(_Covariance.Equals(value)))
                {
                    _Covariance = value;
                    RaisePropertyChanged("Covariance");
                }
            }
        }
        private ReactiveRTM.RTC.Point2D _Start;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point2D Start
        {
            get { return _Start; }
            set 
            {
                if(!(_Start.Equals(value)))
                {
                    _Start = value;
                    RaisePropertyChanged("Start");
                }
            }
        }
        private ReactiveRTM.RTC.Point2D _End;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point2D End
        {
            get { return _End; }
            set 
            {
                if(!(_End.Equals(value)))
                {
                    _End = value;
                    RaisePropertyChanged("End");
                }
            }
        }
        private System.Boolean _StartSighted;
            
        ///<exclude/>
        public System.Boolean StartSighted
        {
            get { return _StartSighted; }
            set 
            {
                if(!(_StartSighted.Equals(value)))
                {
                    _StartSighted = value;
                    RaisePropertyChanged("StartSighted");
                }
            }
        }
        private System.Boolean _EndSighted;
            
        ///<exclude/>
        public System.Boolean EndSighted
        {
            get { return _EndSighted; }
            set 
            {
                if(!(_EndSighted.Equals(value)))
                {
                    _EndSighted = value;
                    RaisePropertyChanged("EndSighted");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.LineFeature (ReactiveRTM.RTC.LineFeature source)
        {
            var instance = new global::RTC.LineFeature();
            instance.probability =  source._Probability;
            instance.rho =  source._Rho;
            instance.alpha =  source._Alpha;
            instance.covariance =  ((global::RTC.PointCovariance2D)((IStub)source._Covariance).GetTarget());
            instance.start =  ((global::RTC.Point2D)((IStub)source._Start).GetTarget());
            instance._end =  ((global::RTC.Point2D)((IStub)source._End).GetTarget());
            instance.startSighted =  source._StartSighted;
            instance.endSighted =  source._EndSighted;
            return instance;
        }
        public LineFeature ()
        {
            _Probability = new System.Double();
            _Rho = new System.Double();
            _Alpha = new System.Double();
            _Covariance = new ReactiveRTM.RTC.PointCovariance2D();
            _Start = new ReactiveRTM.RTC.Point2D();
            _End = new ReactiveRTM.RTC.Point2D();
            _StartSighted = new System.Boolean();
            _EndSighted = new System.Boolean();
        }
        public LineFeature (global::RTC.LineFeature source)
        {
            _Probability = source.probability;
            _Rho = source.rho;
            _Alpha = source.alpha;
            _Covariance = new ReactiveRTM.RTC.PointCovariance2D(source.covariance);
            _Start = new ReactiveRTM.RTC.Point2D(source.start);
            _End = new ReactiveRTM.RTC.Point2D(source._end);
            _StartSighted = source.startSighted;
            _EndSighted = source.endSighted;
        }

        ///<exclude/>
        public bool Equals(LineFeature other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Probability.Equals(_Probability) && other._Rho.Equals(_Rho) && other._Alpha.Equals(_Alpha) && other._Covariance.Equals(_Covariance) && other._Start.Equals(_Start) && other._End.Equals(_End) && other._StartSighted.Equals(_StartSighted) && other._EndSighted.Equals(_EndSighted);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(LineFeature)) return false;
            return Equals((LineFeature)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Probability.GetHashCode();
                result = (result * 397) ^ _Rho.GetHashCode();
                result = (result * 397) ^ _Alpha.GetHashCode();
                result = (result * 397) ^ _Covariance.GetHashCode();
                result = (result * 397) ^ _Start.GetHashCode();
                result = (result * 397) ^ _End.GetHashCode();
                result = (result * 397) ^ _StartSighted.GetHashCode();
                result = (result * 397) ^ _EndSighted.GetHashCode();
                return result;
            }
        }
    }
 
    public class Features : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.PointFeature> _PointFeatures;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.PointFeature> PointFeatures
        {
            get { return _PointFeatures; }
            set 
            {
                if(!(_PointFeatures.SequenceEqual(value)))
                {
                    _PointFeatures = value;
                    RaisePropertyChanged("PointFeatures");
                }
            }
        }
        private List<ReactiveRTM.RTC.PoseFeature> _PoseFeatures;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.PoseFeature> PoseFeatures
        {
            get { return _PoseFeatures; }
            set 
            {
                if(!(_PoseFeatures.SequenceEqual(value)))
                {
                    _PoseFeatures = value;
                    RaisePropertyChanged("PoseFeatures");
                }
            }
        }
        private List<ReactiveRTM.RTC.LineFeature> _LineFeatures;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.LineFeature> LineFeatures
        {
            get { return _LineFeatures; }
            set 
            {
                if(!(_LineFeatures.SequenceEqual(value)))
                {
                    _LineFeatures = value;
                    RaisePropertyChanged("LineFeatures");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Features (ReactiveRTM.RTC.Features source)
        {
            var instance = new global::RTC.Features();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.pointFeatures =  source._PointFeatures.Select(x=>((global::RTC.PointFeature)((IStub)x).GetTarget())).ToArray();
            instance.poseFeatures =  source._PoseFeatures.Select(x=>((global::RTC.PoseFeature)((IStub)x).GetTarget())).ToArray();
            instance.lineFeatures =  source._LineFeatures.Select(x=>((global::RTC.LineFeature)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public Features ()
        {
            _Tm = default(System.DateTime);
            _PointFeatures = new List<ReactiveRTM.RTC.PointFeature>();
            _PoseFeatures = new List<ReactiveRTM.RTC.PoseFeature>();
            _LineFeatures = new List<ReactiveRTM.RTC.LineFeature>();
        }
        public Features (global::RTC.Features source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _PointFeatures = source.pointFeatures.Select(x => (ReactiveRTM.RTC.PointFeature)new ReactiveRTM.RTC.PointFeature(x)).ToList();
            _PoseFeatures = source.poseFeatures.Select(x => (ReactiveRTM.RTC.PoseFeature)new ReactiveRTM.RTC.PoseFeature(x)).ToList();
            _LineFeatures = source.lineFeatures.Select(x => (ReactiveRTM.RTC.LineFeature)new ReactiveRTM.RTC.LineFeature(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(Features other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._PointFeatures.SequenceEqual(_PointFeatures) && other._PoseFeatures.SequenceEqual(_PoseFeatures) && other._LineFeatures.SequenceEqual(_LineFeatures);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Features)) return false;
            return Equals((Features)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _PointFeatures.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = _PoseFeatures.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = _LineFeatures.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class MultiCameraImages : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.CameraImage> _Images;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.CameraImage> Images
        {
            get { return _Images; }
            set 
            {
                if(!(_Images.SequenceEqual(value)))
                {
                    _Images = value;
                    RaisePropertyChanged("Images");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.MultiCameraImages (ReactiveRTM.RTC.MultiCameraImages source)
        {
            var instance = new global::RTC.MultiCameraImages();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.images =  source._Images.Select(x=>((global::RTC.CameraImage)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public MultiCameraImages ()
        {
            _Tm = default(System.DateTime);
            _Images = new List<ReactiveRTM.RTC.CameraImage>();
        }
        public MultiCameraImages (global::RTC.MultiCameraImages source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Images = source.images.Select(x => (ReactiveRTM.RTC.CameraImage)new ReactiveRTM.RTC.CameraImage(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(MultiCameraImages other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Images.SequenceEqual(_Images);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(MultiCameraImages)) return false;
            return Equals((MultiCameraImages)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Images.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class MulticameraGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Geometry3D _Geometry;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D Geometry
        {
            get { return _Geometry; }
            set 
            {
                if(!(_Geometry.Equals(value)))
                {
                    _Geometry = value;
                    RaisePropertyChanged("Geometry");
                }
            }
        }
        private List<ReactiveRTM.RTC.Geometry3D> _CameraGeometries;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Geometry3D> CameraGeometries
        {
            get { return _CameraGeometries; }
            set 
            {
                if(!(_CameraGeometries.SequenceEqual(value)))
                {
                    _CameraGeometries = value;
                    RaisePropertyChanged("CameraGeometries");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.MulticameraGeometry (ReactiveRTM.RTC.MulticameraGeometry source)
        {
            var instance = new global::RTC.MulticameraGeometry();
            instance.geometry =  ((global::RTC.Geometry3D)((IStub)source._Geometry).GetTarget());
            instance.cameraGeometries =  source._CameraGeometries.Select(x=>((global::RTC.Geometry3D)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public MulticameraGeometry ()
        {
            _Geometry = new ReactiveRTM.RTC.Geometry3D();
            _CameraGeometries = new List<ReactiveRTM.RTC.Geometry3D>();
        }
        public MulticameraGeometry (global::RTC.MulticameraGeometry source)
        {
            _Geometry = new ReactiveRTM.RTC.Geometry3D(source.geometry);
            _CameraGeometries = source.cameraGeometries.Select(x => (ReactiveRTM.RTC.Geometry3D)new ReactiveRTM.RTC.Geometry3D(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(MulticameraGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Geometry.Equals(_Geometry) && other._CameraGeometries.SequenceEqual(_CameraGeometries);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(MulticameraGeometry)) return false;
            return Equals((MulticameraGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Geometry.GetHashCode();
                result = _CameraGeometries.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class Waypoint2D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose2D _Target;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose2D Target
        {
            get { return _Target; }
            set 
            {
                if(!(_Target.Equals(value)))
                {
                    _Target = value;
                    RaisePropertyChanged("Target");
                }
            }
        }
        private System.Double _DistanceTolerance;
            
        ///<exclude/>
        public System.Double DistanceTolerance
        {
            get { return _DistanceTolerance; }
            set 
            {
                if(!(_DistanceTolerance.Equals(value)))
                {
                    _DistanceTolerance = value;
                    RaisePropertyChanged("DistanceTolerance");
                }
            }
        }
        private System.Double _HeadingTolerance;
            
        ///<exclude/>
        public System.Double HeadingTolerance
        {
            get { return _HeadingTolerance; }
            set 
            {
                if(!(_HeadingTolerance.Equals(value)))
                {
                    _HeadingTolerance = value;
                    RaisePropertyChanged("HeadingTolerance");
                }
            }
        }
        private System.DateTime _TimeLimit;
            
        ///<exclude/>
        public System.DateTime TimeLimit
        {
            get { return _TimeLimit; }
            set 
            {
                if(!(_TimeLimit.Equals(value)))
                {
                    _TimeLimit = value;
                    RaisePropertyChanged("TimeLimit");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity2D _MaxSpeed;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity2D MaxSpeed
        {
            get { return _MaxSpeed; }
            set 
            {
                if(!(_MaxSpeed.Equals(value)))
                {
                    _MaxSpeed = value;
                    RaisePropertyChanged("MaxSpeed");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Waypoint2D (ReactiveRTM.RTC.Waypoint2D source)
        {
            var instance = new global::RTC.Waypoint2D();
            instance.target =  ((global::RTC.Pose2D)((IStub)source._Target).GetTarget());
            instance.distanceTolerance =  source._DistanceTolerance;
            instance.headingTolerance =  source._HeadingTolerance;
            instance.timeLimit =  Converter.DateTimeToRtcTime(source._TimeLimit);
            instance.maxSpeed =  ((global::RTC.Velocity2D)((IStub)source._MaxSpeed).GetTarget());
            return instance;
        }
        public Waypoint2D ()
        {
            _Target = new ReactiveRTM.RTC.Pose2D();
            _DistanceTolerance = new System.Double();
            _HeadingTolerance = new System.Double();
            _TimeLimit = default(System.DateTime);
            _MaxSpeed = new ReactiveRTM.RTC.Velocity2D();
        }
        public Waypoint2D (global::RTC.Waypoint2D source)
        {
            _Target = new ReactiveRTM.RTC.Pose2D(source.target);
            _DistanceTolerance = source.distanceTolerance;
            _HeadingTolerance = source.headingTolerance;
            _TimeLimit = Converter.RtcTimeToDateTime(source.timeLimit);
            _MaxSpeed = new ReactiveRTM.RTC.Velocity2D(source.maxSpeed);
        }

        ///<exclude/>
        public bool Equals(Waypoint2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Target.Equals(_Target) && other._DistanceTolerance.Equals(_DistanceTolerance) && other._HeadingTolerance.Equals(_HeadingTolerance) && other._TimeLimit.Equals(_TimeLimit) && other._MaxSpeed.Equals(_MaxSpeed);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Waypoint2D)) return false;
            return Equals((Waypoint2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Target.GetHashCode();
                result = (result * 397) ^ _DistanceTolerance.GetHashCode();
                result = (result * 397) ^ _HeadingTolerance.GetHashCode();
                result = (result * 397) ^ _TimeLimit.GetHashCode();
                result = (result * 397) ^ _MaxSpeed.GetHashCode();
                return result;
            }
        }
    }
 
    public class Path2D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.Waypoint2D> _Waypoints;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Waypoint2D> Waypoints
        {
            get { return _Waypoints; }
            set 
            {
                if(!(_Waypoints.SequenceEqual(value)))
                {
                    _Waypoints = value;
                    RaisePropertyChanged("Waypoints");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Path2D (ReactiveRTM.RTC.Path2D source)
        {
            var instance = new global::RTC.Path2D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.waypoints =  source._Waypoints.Select(x=>((global::RTC.Waypoint2D)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public Path2D ()
        {
            _Tm = default(System.DateTime);
            _Waypoints = new List<ReactiveRTM.RTC.Waypoint2D>();
        }
        public Path2D (global::RTC.Path2D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Waypoints = source.waypoints.Select(x => (ReactiveRTM.RTC.Waypoint2D)new ReactiveRTM.RTC.Waypoint2D(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(Path2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Waypoints.SequenceEqual(_Waypoints);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Path2D)) return false;
            return Equals((Path2D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Waypoints.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class Waypoint3D : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Pose3D _Target;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Pose3D Target
        {
            get { return _Target; }
            set 
            {
                if(!(_Target.Equals(value)))
                {
                    _Target = value;
                    RaisePropertyChanged("Target");
                }
            }
        }
        private System.Double _DistanceTolerance;
            
        ///<exclude/>
        public System.Double DistanceTolerance
        {
            get { return _DistanceTolerance; }
            set 
            {
                if(!(_DistanceTolerance.Equals(value)))
                {
                    _DistanceTolerance = value;
                    RaisePropertyChanged("DistanceTolerance");
                }
            }
        }
        private System.Double _HeadingTolerance;
            
        ///<exclude/>
        public System.Double HeadingTolerance
        {
            get { return _HeadingTolerance; }
            set 
            {
                if(!(_HeadingTolerance.Equals(value)))
                {
                    _HeadingTolerance = value;
                    RaisePropertyChanged("HeadingTolerance");
                }
            }
        }
        private System.DateTime _TimeLimit;
            
        ///<exclude/>
        public System.DateTime TimeLimit
        {
            get { return _TimeLimit; }
            set 
            {
                if(!(_TimeLimit.Equals(value)))
                {
                    _TimeLimit = value;
                    RaisePropertyChanged("TimeLimit");
                }
            }
        }
        private ReactiveRTM.RTC.Velocity3D _MaxSpeed;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Velocity3D MaxSpeed
        {
            get { return _MaxSpeed; }
            set 
            {
                if(!(_MaxSpeed.Equals(value)))
                {
                    _MaxSpeed = value;
                    RaisePropertyChanged("MaxSpeed");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Waypoint3D (ReactiveRTM.RTC.Waypoint3D source)
        {
            var instance = new global::RTC.Waypoint3D();
            instance.target =  ((global::RTC.Pose3D)((IStub)source._Target).GetTarget());
            instance.distanceTolerance =  source._DistanceTolerance;
            instance.headingTolerance =  source._HeadingTolerance;
            instance.timeLimit =  Converter.DateTimeToRtcTime(source._TimeLimit);
            instance.maxSpeed =  ((global::RTC.Velocity3D)((IStub)source._MaxSpeed).GetTarget());
            return instance;
        }
        public Waypoint3D ()
        {
            _Target = new ReactiveRTM.RTC.Pose3D();
            _DistanceTolerance = new System.Double();
            _HeadingTolerance = new System.Double();
            _TimeLimit = default(System.DateTime);
            _MaxSpeed = new ReactiveRTM.RTC.Velocity3D();
        }
        public Waypoint3D (global::RTC.Waypoint3D source)
        {
            _Target = new ReactiveRTM.RTC.Pose3D(source.target);
            _DistanceTolerance = source.distanceTolerance;
            _HeadingTolerance = source.headingTolerance;
            _TimeLimit = Converter.RtcTimeToDateTime(source.timeLimit);
            _MaxSpeed = new ReactiveRTM.RTC.Velocity3D(source.maxSpeed);
        }

        ///<exclude/>
        public bool Equals(Waypoint3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Target.Equals(_Target) && other._DistanceTolerance.Equals(_DistanceTolerance) && other._HeadingTolerance.Equals(_HeadingTolerance) && other._TimeLimit.Equals(_TimeLimit) && other._MaxSpeed.Equals(_MaxSpeed);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Waypoint3D)) return false;
            return Equals((Waypoint3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Target.GetHashCode();
                result = (result * 397) ^ _DistanceTolerance.GetHashCode();
                result = (result * 397) ^ _HeadingTolerance.GetHashCode();
                result = (result * 397) ^ _TimeLimit.GetHashCode();
                result = (result * 397) ^ _MaxSpeed.GetHashCode();
                return result;
            }
        }
    }
 
    public class Path3D : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.Waypoint3D> _Waypoints;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Waypoint3D> Waypoints
        {
            get { return _Waypoints; }
            set 
            {
                if(!(_Waypoints.SequenceEqual(value)))
                {
                    _Waypoints = value;
                    RaisePropertyChanged("Waypoints");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.Path3D (ReactiveRTM.RTC.Path3D source)
        {
            var instance = new global::RTC.Path3D();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.waypoints =  source._Waypoints.Select(x=>((global::RTC.Waypoint3D)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public Path3D ()
        {
            _Tm = default(System.DateTime);
            _Waypoints = new List<ReactiveRTM.RTC.Waypoint3D>();
        }
        public Path3D (global::RTC.Path3D source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Waypoints = source.waypoints.Select(x => (ReactiveRTM.RTC.Waypoint3D)new ReactiveRTM.RTC.Waypoint3D(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(Path3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Waypoints.SequenceEqual(_Waypoints);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Path3D)) return false;
            return Equals((Path3D)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Waypoints.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class PointCloudPoint : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Point3D _Point;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Point3D Point
        {
            get { return _Point; }
            set 
            {
                if(!(_Point.Equals(value)))
                {
                    _Point = value;
                    RaisePropertyChanged("Point");
                }
            }
        }
        private ReactiveRTM.RTC.RGBColour _Colour;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RGBColour Colour
        {
            get { return _Colour; }
            set 
            {
                if(!(_Colour.Equals(value)))
                {
                    _Colour = value;
                    RaisePropertyChanged("Colour");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PointCloudPoint (ReactiveRTM.RTC.PointCloudPoint source)
        {
            var instance = new global::RTC.PointCloudPoint();
            instance.point =  ((global::RTC.Point3D)((IStub)source._Point).GetTarget());
            instance.colour =  ((global::RTC.RGBColour)((IStub)source._Colour).GetTarget());
            return instance;
        }
        public PointCloudPoint ()
        {
            _Point = new ReactiveRTM.RTC.Point3D();
            _Colour = new ReactiveRTM.RTC.RGBColour();
        }
        public PointCloudPoint (global::RTC.PointCloudPoint source)
        {
            _Point = new ReactiveRTM.RTC.Point3D(source.point);
            _Colour = new ReactiveRTM.RTC.RGBColour(source.colour);
        }

        ///<exclude/>
        public bool Equals(PointCloudPoint other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Point.Equals(_Point) && other._Colour.Equals(_Colour);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PointCloudPoint)) return false;
            return Equals((PointCloudPoint)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Point.GetHashCode();
                result = (result * 397) ^ _Colour.GetHashCode();
                return result;
            }
        }
    }
 
    public class PointCloud : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<ReactiveRTM.RTC.PointCloudPoint> _Points;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.PointCloudPoint> Points
        {
            get { return _Points; }
            set 
            {
                if(!(_Points.SequenceEqual(value)))
                {
                    _Points = value;
                    RaisePropertyChanged("Points");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PointCloud (ReactiveRTM.RTC.PointCloud source)
        {
            var instance = new global::RTC.PointCloud();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.points =  source._Points.Select(x=>((global::RTC.PointCloudPoint)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public PointCloud ()
        {
            _Tm = default(System.DateTime);
            _Points = new List<ReactiveRTM.RTC.PointCloudPoint>();
        }
        public PointCloud (global::RTC.PointCloud source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Points = source.points.Select(x => (ReactiveRTM.RTC.PointCloudPoint)new ReactiveRTM.RTC.PointCloudPoint(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(PointCloud other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Points.SequenceEqual(_Points);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PointCloud)) return false;
            return Equals((PointCloud)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Points.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class PanTiltAngles : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private System.Double _Pan;
            
        ///<exclude/>
        public System.Double Pan
        {
            get { return _Pan; }
            set 
            {
                if(!(_Pan.Equals(value)))
                {
                    _Pan = value;
                    RaisePropertyChanged("Pan");
                }
            }
        }
        private System.Double _Tilt;
            
        ///<exclude/>
        public System.Double Tilt
        {
            get { return _Tilt; }
            set 
            {
                if(!(_Tilt.Equals(value)))
                {
                    _Tilt = value;
                    RaisePropertyChanged("Tilt");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PanTiltAngles (ReactiveRTM.RTC.PanTiltAngles source)
        {
            var instance = new global::RTC.PanTiltAngles();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.pan =  source._Pan;
            instance.tilt =  source._Tilt;
            return instance;
        }
        public PanTiltAngles ()
        {
            _Tm = default(System.DateTime);
            _Pan = new System.Double();
            _Tilt = new System.Double();
        }
        public PanTiltAngles (global::RTC.PanTiltAngles source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Pan = source.pan;
            _Tilt = source.tilt;
        }

        ///<exclude/>
        public bool Equals(PanTiltAngles other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Pan.Equals(_Pan) && other._Tilt.Equals(_Tilt);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PanTiltAngles)) return false;
            return Equals((PanTiltAngles)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Pan.GetHashCode();
                result = (result * 397) ^ _Tilt.GetHashCode();
                return result;
            }
        }
    }
 
    public class PanTiltState : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private ReactiveRTM.RTC.PanTiltAngles _Angles;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PanTiltAngles Angles
        {
            get { return _Angles; }
            set 
            {
                if(!(_Angles.Equals(value)))
                {
                    _Angles = value;
                    RaisePropertyChanged("Angles");
                }
            }
        }
        private System.Double _PanSpeed;
            
        ///<exclude/>
        public System.Double PanSpeed
        {
            get { return _PanSpeed; }
            set 
            {
                if(!(_PanSpeed.Equals(value)))
                {
                    _PanSpeed = value;
                    RaisePropertyChanged("PanSpeed");
                }
            }
        }
        private System.Double _TiltSpeed;
            
        ///<exclude/>
        public System.Double TiltSpeed
        {
            get { return _TiltSpeed; }
            set 
            {
                if(!(_TiltSpeed.Equals(value)))
                {
                    _TiltSpeed = value;
                    RaisePropertyChanged("TiltSpeed");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.PanTiltState (ReactiveRTM.RTC.PanTiltState source)
        {
            var instance = new global::RTC.PanTiltState();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.angles =  ((global::RTC.PanTiltAngles)((IStub)source._Angles).GetTarget());
            instance.panSpeed =  source._PanSpeed;
            instance.tiltSpeed =  source._TiltSpeed;
            return instance;
        }
        public PanTiltState ()
        {
            _Tm = default(System.DateTime);
            _Angles = new ReactiveRTM.RTC.PanTiltAngles();
            _PanSpeed = new System.Double();
            _TiltSpeed = new System.Double();
        }
        public PanTiltState (global::RTC.PanTiltState source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Angles = new ReactiveRTM.RTC.PanTiltAngles(source.angles);
            _PanSpeed = source.panSpeed;
            _TiltSpeed = source.tiltSpeed;
        }

        ///<exclude/>
        public bool Equals(PanTiltState other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Angles.Equals(_Angles) && other._PanSpeed.Equals(_PanSpeed) && other._TiltSpeed.Equals(_TiltSpeed);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PanTiltState)) return false;
            return Equals((PanTiltState)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = (result * 397) ^ _Angles.GetHashCode();
                result = (result * 397) ^ _PanSpeed.GetHashCode();
                result = (result * 397) ^ _TiltSpeed.GetHashCode();
                return result;
            }
        }
    }
 
    public class RangerGeometry : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.Geometry3D _Geometry;
            
        ///<exclude/>
        public ReactiveRTM.RTC.Geometry3D Geometry
        {
            get { return _Geometry; }
            set 
            {
                if(!(_Geometry.Equals(value)))
                {
                    _Geometry = value;
                    RaisePropertyChanged("Geometry");
                }
            }
        }
        private List<ReactiveRTM.RTC.Geometry3D> _ElementGeometries;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.Geometry3D> ElementGeometries
        {
            get { return _ElementGeometries; }
            set 
            {
                if(!(_ElementGeometries.SequenceEqual(value)))
                {
                    _ElementGeometries = value;
                    RaisePropertyChanged("ElementGeometries");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.RangerGeometry (ReactiveRTM.RTC.RangerGeometry source)
        {
            var instance = new global::RTC.RangerGeometry();
            instance.geometry =  ((global::RTC.Geometry3D)((IStub)source._Geometry).GetTarget());
            instance.elementGeometries =  source._ElementGeometries.Select(x=>((global::RTC.Geometry3D)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public RangerGeometry ()
        {
            _Geometry = new ReactiveRTM.RTC.Geometry3D();
            _ElementGeometries = new List<ReactiveRTM.RTC.Geometry3D>();
        }
        public RangerGeometry (global::RTC.RangerGeometry source)
        {
            _Geometry = new ReactiveRTM.RTC.Geometry3D(source.geometry);
            _ElementGeometries = source.elementGeometries.Select(x => (ReactiveRTM.RTC.Geometry3D)new ReactiveRTM.RTC.Geometry3D(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(RangerGeometry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Geometry.Equals(_Geometry) && other._ElementGeometries.SequenceEqual(_ElementGeometries);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RangerGeometry)) return false;
            return Equals((RangerGeometry)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Geometry.GetHashCode();
                result = _ElementGeometries.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class RangerConfig : NotifyPropertyChangedBase
    {
        private System.Double _MinAngle;
            
        ///<exclude/>
        public System.Double MinAngle
        {
            get { return _MinAngle; }
            set 
            {
                if(!(_MinAngle.Equals(value)))
                {
                    _MinAngle = value;
                    RaisePropertyChanged("MinAngle");
                }
            }
        }
        private System.Double _MaxAngle;
            
        ///<exclude/>
        public System.Double MaxAngle
        {
            get { return _MaxAngle; }
            set 
            {
                if(!(_MaxAngle.Equals(value)))
                {
                    _MaxAngle = value;
                    RaisePropertyChanged("MaxAngle");
                }
            }
        }
        private System.Double _AngularRes;
            
        ///<exclude/>
        public System.Double AngularRes
        {
            get { return _AngularRes; }
            set 
            {
                if(!(_AngularRes.Equals(value)))
                {
                    _AngularRes = value;
                    RaisePropertyChanged("AngularRes");
                }
            }
        }
        private System.Double _MinRange;
            
        ///<exclude/>
        public System.Double MinRange
        {
            get { return _MinRange; }
            set 
            {
                if(!(_MinRange.Equals(value)))
                {
                    _MinRange = value;
                    RaisePropertyChanged("MinRange");
                }
            }
        }
        private System.Double _MaxRange;
            
        ///<exclude/>
        public System.Double MaxRange
        {
            get { return _MaxRange; }
            set 
            {
                if(!(_MaxRange.Equals(value)))
                {
                    _MaxRange = value;
                    RaisePropertyChanged("MaxRange");
                }
            }
        }
        private System.Double _RangeRes;
            
        ///<exclude/>
        public System.Double RangeRes
        {
            get { return _RangeRes; }
            set 
            {
                if(!(_RangeRes.Equals(value)))
                {
                    _RangeRes = value;
                    RaisePropertyChanged("RangeRes");
                }
            }
        }
        private System.Double _Frequency;
            
        ///<exclude/>
        public System.Double Frequency
        {
            get { return _Frequency; }
            set 
            {
                if(!(_Frequency.Equals(value)))
                {
                    _Frequency = value;
                    RaisePropertyChanged("Frequency");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.RangerConfig (ReactiveRTM.RTC.RangerConfig source)
        {
            var instance = new global::RTC.RangerConfig();
            instance.minAngle =  source._MinAngle;
            instance.maxAngle =  source._MaxAngle;
            instance.angularRes =  source._AngularRes;
            instance.minRange =  source._MinRange;
            instance.maxRange =  source._MaxRange;
            instance.rangeRes =  source._RangeRes;
            instance.frequency =  source._Frequency;
            return instance;
        }
        public RangerConfig ()
        {
            _MinAngle = new System.Double();
            _MaxAngle = new System.Double();
            _AngularRes = new System.Double();
            _MinRange = new System.Double();
            _MaxRange = new System.Double();
            _RangeRes = new System.Double();
            _Frequency = new System.Double();
        }
        public RangerConfig (global::RTC.RangerConfig source)
        {
            _MinAngle = source.minAngle;
            _MaxAngle = source.maxAngle;
            _AngularRes = source.angularRes;
            _MinRange = source.minRange;
            _MaxRange = source.maxRange;
            _RangeRes = source.rangeRes;
            _Frequency = source.frequency;
        }

        ///<exclude/>
        public bool Equals(RangerConfig other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._MinAngle.Equals(_MinAngle) && other._MaxAngle.Equals(_MaxAngle) && other._AngularRes.Equals(_AngularRes) && other._MinRange.Equals(_MinRange) && other._MaxRange.Equals(_MaxRange) && other._RangeRes.Equals(_RangeRes) && other._Frequency.Equals(_Frequency);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RangerConfig)) return false;
            return Equals((RangerConfig)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _MinAngle.GetHashCode();
                result = (result * 397) ^ _MaxAngle.GetHashCode();
                result = (result * 397) ^ _AngularRes.GetHashCode();
                result = (result * 397) ^ _MinRange.GetHashCode();
                result = (result * 397) ^ _MaxRange.GetHashCode();
                result = (result * 397) ^ _RangeRes.GetHashCode();
                result = (result * 397) ^ _Frequency.GetHashCode();
                return result;
            }
        }
    }
 
    public class RangeData : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Double> _Ranges;
            
        ///<exclude/>
        public List<System.Double> Ranges
        {
            get { return _Ranges; }
            set 
            {
                if(!(_Ranges.SequenceEqual(value)))
                {
                    _Ranges = value;
                    RaisePropertyChanged("Ranges");
                }
            }
        }
        private ReactiveRTM.RTC.RangerGeometry _Geometry;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RangerGeometry Geometry
        {
            get { return _Geometry; }
            set 
            {
                if(!(_Geometry.Equals(value)))
                {
                    _Geometry = value;
                    RaisePropertyChanged("Geometry");
                }
            }
        }
        private ReactiveRTM.RTC.RangerConfig _Config;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RangerConfig Config
        {
            get { return _Config; }
            set 
            {
                if(!(_Config.Equals(value)))
                {
                    _Config = value;
                    RaisePropertyChanged("Config");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.RangeData (ReactiveRTM.RTC.RangeData source)
        {
            var instance = new global::RTC.RangeData();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.ranges =  source._Ranges.Select(x=>x).ToArray();
            instance.geometry =  ((global::RTC.RangerGeometry)((IStub)source._Geometry).GetTarget());
            instance.config =  ((global::RTC.RangerConfig)((IStub)source._Config).GetTarget());
            return instance;
        }
        public RangeData ()
        {
            _Tm = default(System.DateTime);
            _Ranges = new List<System.Double>();
            _Geometry = new ReactiveRTM.RTC.RangerGeometry();
            _Config = new ReactiveRTM.RTC.RangerConfig();
        }
        public RangeData (global::RTC.RangeData source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Ranges = source.ranges.Select(x => (System.Double)x).ToList();
            _Geometry = new ReactiveRTM.RTC.RangerGeometry(source.geometry);
            _Config = new ReactiveRTM.RTC.RangerConfig(source.config);
        }

        ///<exclude/>
        public bool Equals(RangeData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Ranges.SequenceEqual(_Ranges) && other._Geometry.Equals(_Geometry) && other._Config.Equals(_Config);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RangeData)) return false;
            return Equals((RangeData)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Ranges.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = (result * 397) ^ _Geometry.GetHashCode();
                result = (result * 397) ^ _Config.GetHashCode();
                return result;
            }
        }
    }
 
    public class IntensityData : NotifyPropertyChangedBase
    {
        private System.DateTime _Tm;
            
        ///<exclude/>
        public System.DateTime Tm
        {
            get { return _Tm; }
            set 
            {
                if(!(_Tm.Equals(value)))
                {
                    _Tm = value;
                    RaisePropertyChanged("Tm");
                }
            }
        }
        private List<System.Double> _Intensities;
            
        ///<exclude/>
        public List<System.Double> Intensities
        {
            get { return _Intensities; }
            set 
            {
                if(!(_Intensities.SequenceEqual(value)))
                {
                    _Intensities = value;
                    RaisePropertyChanged("Intensities");
                }
            }
        }
        private ReactiveRTM.RTC.RangerGeometry _Geometry;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RangerGeometry Geometry
        {
            get { return _Geometry; }
            set 
            {
                if(!(_Geometry.Equals(value)))
                {
                    _Geometry = value;
                    RaisePropertyChanged("Geometry");
                }
            }
        }
        private ReactiveRTM.RTC.RangerConfig _Config;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RangerConfig Config
        {
            get { return _Config; }
            set 
            {
                if(!(_Config.Equals(value)))
                {
                    _Config = value;
                    RaisePropertyChanged("Config");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTC.IntensityData (ReactiveRTM.RTC.IntensityData source)
        {
            var instance = new global::RTC.IntensityData();
            instance.tm =  Converter.DateTimeToRtcTime(source._Tm);
            instance.intensities =  source._Intensities.Select(x=>x).ToArray();
            instance.geometry =  ((global::RTC.RangerGeometry)((IStub)source._Geometry).GetTarget());
            instance.config =  ((global::RTC.RangerConfig)((IStub)source._Config).GetTarget());
            return instance;
        }
        public IntensityData ()
        {
            _Tm = default(System.DateTime);
            _Intensities = new List<System.Double>();
            _Geometry = new ReactiveRTM.RTC.RangerGeometry();
            _Config = new ReactiveRTM.RTC.RangerConfig();
        }
        public IntensityData (global::RTC.IntensityData source)
        {
            _Tm = Converter.RtcTimeToDateTime(source.tm);
            _Intensities = source.intensities.Select(x => (System.Double)x).ToList();
            _Geometry = new ReactiveRTM.RTC.RangerGeometry(source.geometry);
            _Config = new ReactiveRTM.RTC.RangerConfig(source.config);
        }

        ///<exclude/>
        public bool Equals(IntensityData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Tm.Equals(_Tm) && other._Intensities.SequenceEqual(_Intensities) && other._Geometry.Equals(_Geometry) && other._Config.Equals(_Config);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(IntensityData)) return false;
            return Equals((IntensityData)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Tm.GetHashCode();
                result = _Intensities.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = (result * 397) ^ _Geometry.GetHashCode();
                result = (result * 397) ^ _Config.GetHashCode();
                return result;
            }
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public enum ReturnCode_t
    {
        RTC_OK = 0,
        RTC_ERROR = 1,
        BAD_PARAMETER = 2,
        UNSUPPORTED = 3,
        OUT_OF_RESOURCES = 4,
        PRECONDITION_NOT_MET = 5,
    }
    public enum LifeCycleState
    {
        CREATED_STATE = 0,
        INACTIVE_STATE = 1,
        ACTIVE_STATE = 2,
        ERROR_STATE = 3,
    }
    public enum ExecutionKind
    {
        PERIODIC = 0,
        EVENT_DRIVEN = 1,
        OTHER = 2,
    }
    public enum PortInterfacePolarity
    {
        PROVIDED = 0,
        REQUIRED = 1,
    }
    
 
    public class PortInterfaceProfile : NotifyPropertyChangedBase
    {
        private System.String _InstanceName;
            
        ///<exclude/>
        public System.String InstanceName
        {
            get { return _InstanceName; }
            set 
            {
                if(!(_InstanceName == (value)))
                {
                    _InstanceName = value;
                    RaisePropertyChanged("InstanceName");
                }
            }
        }
        private System.String _TypeName;
            
        ///<exclude/>
        public System.String TypeName
        {
            get { return _TypeName; }
            set 
            {
                if(!(_TypeName == (value)))
                {
                    _TypeName = value;
                    RaisePropertyChanged("TypeName");
                }
            }
        }
        private ReactiveRTM.RTC.PortInterfacePolarity _Polarity;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PortInterfacePolarity Polarity
        {
            get { return _Polarity; }
            set 
            {
                if(!(_Polarity.Equals(value)))
                {
                    _Polarity = value;
                    RaisePropertyChanged("Polarity");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.PortInterfaceProfile (ReactiveRTM.RTC.PortInterfaceProfile source)
        {
            var instance = new global::omg.org.RTC.PortInterfaceProfile();
            instance.instance_name =  source._InstanceName;
            instance.type_name =  source._TypeName;
            instance.polarity =  (global::omg.org.RTC.PortInterfacePolarity)source._Polarity;
            return instance;
        }
        public PortInterfaceProfile ()
        {
            _InstanceName = string.Empty;
            _TypeName = string.Empty;
            _Polarity = new ReactiveRTM.RTC.PortInterfacePolarity();
        }
        public PortInterfaceProfile (global::omg.org.RTC.PortInterfaceProfile source)
        {
            _InstanceName = source.instance_name;
            _TypeName = source.type_name;
            _Polarity = (ReactiveRTM.RTC.PortInterfacePolarity)source.polarity;
        }

        ///<exclude/>
        public bool Equals(PortInterfaceProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._InstanceName == (_InstanceName) && other._TypeName == (_TypeName) && other._Polarity.Equals(_Polarity);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PortInterfaceProfile)) return false;
            return Equals((PortInterfaceProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _InstanceName.GetHashCode();
                result = (result * 397) ^ _TypeName.GetHashCode();
                result = (result * 397) ^ _Polarity.GetHashCode();
                return result;
            }
        }
    }
 
    public class ConnectorProfile : NotifyPropertyChangedBase
    {
        private System.String _Name;
            
        ///<exclude/>
        public System.String Name
        {
            get { return _Name; }
            set 
            {
                if(!(_Name == (value)))
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        private System.String _ConnectorId;
            
        ///<exclude/>
        public System.String ConnectorId
        {
            get { return _ConnectorId; }
            set 
            {
                if(!(_ConnectorId == (value)))
                {
                    _ConnectorId = value;
                    RaisePropertyChanged("ConnectorId");
                }
            }
        }
        private List<ReactiveRTM.RTC.PortService> _Ports;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.PortService> Ports
        {
            get { return _Ports; }
            set 
            {
                if(!(_Ports.SequenceEqual(value)))
                {
                    _Ports = value;
                    RaisePropertyChanged("Ports");
                }
            }
        }
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.ConnectorProfile (ReactiveRTM.RTC.ConnectorProfile source)
        {
            var instance = new global::omg.org.RTC.ConnectorProfile();
            instance.name =  source._Name;
            instance.connector_id =  source._ConnectorId;
            instance.ports =  source._Ports.Select(x=>((global::omg.org.RTC.PortService)((IStub)x).GetTarget())).ToArray();
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public ConnectorProfile ()
        {
            _Name = string.Empty;
            _ConnectorId = string.Empty;
            _Ports = new List<ReactiveRTM.RTC.PortService>();
            _Properties = new Dictionary<string,object>();
        }
        public ConnectorProfile (global::omg.org.RTC.ConnectorProfile source)
        {
            _Name = source.name;
            _ConnectorId = source.connector_id;
            _Ports = source.ports.Select(x => (ReactiveRTM.RTC.PortService)new ReactiveRTM.RTC.PortServiceStub(x)).ToList();
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(ConnectorProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Name == (_Name) && other._ConnectorId == (_ConnectorId) && other._Ports.SequenceEqual(_Ports) && other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ConnectorProfile)) return false;
            return Equals((ConnectorProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Name.GetHashCode();
                result = (result * 397) ^ _ConnectorId.GetHashCode();
                result = _Ports.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
 
    public class PortProfile : NotifyPropertyChangedBase
    {
        private System.String _Name;
            
        ///<exclude/>
        public System.String Name
        {
            get { return _Name; }
            set 
            {
                if(!(_Name == (value)))
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        private List<ReactiveRTM.RTC.PortInterfaceProfile> _Interfaces;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.PortInterfaceProfile> Interfaces
        {
            get { return _Interfaces; }
            set 
            {
                if(!(_Interfaces.SequenceEqual(value)))
                {
                    _Interfaces = value;
                    RaisePropertyChanged("Interfaces");
                }
            }
        }
        private ReactiveRTM.RTC.PortService _PortRef;
            
        ///<exclude/>
        public ReactiveRTM.RTC.PortService PortRef
        {
            get { return _PortRef; }
            set 
            {
                if(!(_PortRef == (value)))
                {
                    _PortRef = value;
                    RaisePropertyChanged("PortRef");
                }
            }
        }
        private List<ReactiveRTM.RTC.ConnectorProfile> _ConnectorProfiles;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.ConnectorProfile> ConnectorProfiles
        {
            get { return _ConnectorProfiles; }
            set 
            {
                if(!(_ConnectorProfiles.SequenceEqual(value)))
                {
                    _ConnectorProfiles = value;
                    RaisePropertyChanged("ConnectorProfiles");
                }
            }
        }
        private ReactiveRTM.RTC.RTObject _Owner;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RTObject Owner
        {
            get { return _Owner; }
            set 
            {
                if(!(_Owner == (value)))
                {
                    _Owner = value;
                    RaisePropertyChanged("Owner");
                }
            }
        }
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.PortProfile (ReactiveRTM.RTC.PortProfile source)
        {
            var instance = new global::omg.org.RTC.PortProfile();
            instance.name =  source._Name;
            instance.interfaces =  source._Interfaces.Select(x=>((global::omg.org.RTC.PortInterfaceProfile)((IStub)x).GetTarget())).ToArray();
            instance.port_ref =  ((global::omg.org.RTC.PortService)((IStub)source._PortRef).GetTarget());
            instance.connector_profiles =  source._ConnectorProfiles.Select(x=>((global::omg.org.RTC.ConnectorProfile)((IStub)x).GetTarget())).ToArray();
            instance.owner =  ((global::omg.org.RTC.RTObject)((IStub)source._Owner).GetTarget());
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public PortProfile ()
        {
            _Name = string.Empty;
            _Interfaces = new List<ReactiveRTM.RTC.PortInterfaceProfile>();
            _PortRef = default(ReactiveRTM.RTC.PortService);
            _ConnectorProfiles = new List<ReactiveRTM.RTC.ConnectorProfile>();
            _Owner = default(ReactiveRTM.RTC.RTObject);
            _Properties = new Dictionary<string,object>();
        }
        public PortProfile (global::omg.org.RTC.PortProfile source)
        {
            _Name = source.name;
            _Interfaces = source.interfaces.Select(x => (ReactiveRTM.RTC.PortInterfaceProfile)new ReactiveRTM.RTC.PortInterfaceProfile(x)).ToList();
            _PortRef = new ReactiveRTM.RTC.PortServiceStub(source.port_ref);
            _ConnectorProfiles = source.connector_profiles.Select(x => (ReactiveRTM.RTC.ConnectorProfile)new ReactiveRTM.RTC.ConnectorProfile(x)).ToList();
            _Owner = new ReactiveRTM.RTC.RTObjectStub(source.owner);
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(PortProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Name == (_Name) && other._Interfaces.SequenceEqual(_Interfaces) && other._PortRef == (_PortRef) && other._ConnectorProfiles.SequenceEqual(_ConnectorProfiles) && other._Owner == (_Owner) && other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(PortProfile)) return false;
            return Equals((PortProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Name.GetHashCode();
                result = _Interfaces.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = (result * 397) ^ _PortRef.GetHashCode();
                result = _ConnectorProfiles.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = (result * 397) ^ _Owner.GetHashCode();
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
 
    public class ExecutionContextProfile : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.ExecutionKind _Kind;
            
        ///<exclude/>
        public ReactiveRTM.RTC.ExecutionKind Kind
        {
            get { return _Kind; }
            set 
            {
                if(!(_Kind.Equals(value)))
                {
                    _Kind = value;
                    RaisePropertyChanged("Kind");
                }
            }
        }
        private System.Double _Rate;
            
        ///<exclude/>
        public System.Double Rate
        {
            get { return _Rate; }
            set 
            {
                if(!(_Rate.Equals(value)))
                {
                    _Rate = value;
                    RaisePropertyChanged("Rate");
                }
            }
        }
        private ReactiveRTM.RTC.RTObject _Owner;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RTObject Owner
        {
            get { return _Owner; }
            set 
            {
                if(!(_Owner == (value)))
                {
                    _Owner = value;
                    RaisePropertyChanged("Owner");
                }
            }
        }
        private List<ReactiveRTM.RTC.RTObject> _Participants;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.RTObject> Participants
        {
            get { return _Participants; }
            set 
            {
                if(!(_Participants.SequenceEqual(value)))
                {
                    _Participants = value;
                    RaisePropertyChanged("Participants");
                }
            }
        }
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.ExecutionContextProfile (ReactiveRTM.RTC.ExecutionContextProfile source)
        {
            var instance = new global::omg.org.RTC.ExecutionContextProfile();
            instance.kind =  (global::omg.org.RTC.ExecutionKind)source._Kind;
            instance.rate =  source._Rate;
            instance.owner =  ((global::omg.org.RTC.RTObject)((IStub)source._Owner).GetTarget());
            instance.participants =  source._Participants.Select(x=>((global::omg.org.RTC.RTObject)((IStub)x).GetTarget())).ToArray();
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public ExecutionContextProfile ()
        {
            _Kind = new ReactiveRTM.RTC.ExecutionKind();
            _Rate = new System.Double();
            _Owner = default(ReactiveRTM.RTC.RTObject);
            _Participants = new List<ReactiveRTM.RTC.RTObject>();
            _Properties = new Dictionary<string,object>();
        }
        public ExecutionContextProfile (global::omg.org.RTC.ExecutionContextProfile source)
        {
            _Kind = (ReactiveRTM.RTC.ExecutionKind)source.kind;
            _Rate = source.rate;
            _Owner = new ReactiveRTM.RTC.RTObjectStub(source.owner);
            _Participants = source.participants.Select(x => (ReactiveRTM.RTC.RTObject)new ReactiveRTM.RTC.RTObjectStub(x)).ToList();
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(ExecutionContextProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Kind.Equals(_Kind) && other._Rate.Equals(_Rate) && other._Owner == (_Owner) && other._Participants.SequenceEqual(_Participants) && other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ExecutionContextProfile)) return false;
            return Equals((ExecutionContextProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Kind.GetHashCode();
                result = (result * 397) ^ _Rate.GetHashCode();
                result = (result * 397) ^ _Owner.GetHashCode();
                result = _Participants.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
 
    public class FsmBehaviorProfile : NotifyPropertyChangedBase
    {
        private ReactiveRTM.RTC.FsmParticipantAction _ActionComponent;
            
        ///<exclude/>
        public ReactiveRTM.RTC.FsmParticipantAction ActionComponent
        {
            get { return _ActionComponent; }
            set 
            {
                if(!(_ActionComponent == (value)))
                {
                    _ActionComponent = value;
                    RaisePropertyChanged("ActionComponent");
                }
            }
        }
        private System.String _Id;
            
        ///<exclude/>
        public System.String Id
        {
            get { return _Id; }
            set 
            {
                if(!(_Id == (value)))
                {
                    _Id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.FsmBehaviorProfile (ReactiveRTM.RTC.FsmBehaviorProfile source)
        {
            var instance = new global::omg.org.RTC.FsmBehaviorProfile();
            instance.action_component =  ((global::omg.org.RTC.FsmParticipantAction)((IStub)source._ActionComponent).GetTarget());
            instance.id =  source._Id;
            return instance;
        }
        public FsmBehaviorProfile ()
        {
            _ActionComponent = default(ReactiveRTM.RTC.FsmParticipantAction);
            _Id = string.Empty;
        }
        public FsmBehaviorProfile (global::omg.org.RTC.FsmBehaviorProfile source)
        {
            _ActionComponent = new ReactiveRTM.RTC.FsmParticipantActionStub(source.action_component);
            _Id = source.id;
        }

        ///<exclude/>
        public bool Equals(FsmBehaviorProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._ActionComponent == (_ActionComponent) && other._Id == (_Id);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(FsmBehaviorProfile)) return false;
            return Equals((FsmBehaviorProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _ActionComponent.GetHashCode();
                result = (result * 397) ^ _Id.GetHashCode();
                return result;
            }
        }
    }
 
    public class FsmProfile : NotifyPropertyChangedBase
    {
        private List<ReactiveRTM.RTC.FsmBehaviorProfile> _BehaviorProfiles;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.FsmBehaviorProfile> BehaviorProfiles
        {
            get { return _BehaviorProfiles; }
            set 
            {
                if(!(_BehaviorProfiles.SequenceEqual(value)))
                {
                    _BehaviorProfiles = value;
                    RaisePropertyChanged("BehaviorProfiles");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.FsmProfile (ReactiveRTM.RTC.FsmProfile source)
        {
            var instance = new global::omg.org.RTC.FsmProfile();
            instance.behavior_profiles =  source._BehaviorProfiles.Select(x=>((global::omg.org.RTC.FsmBehaviorProfile)((IStub)x).GetTarget())).ToArray();
            return instance;
        }
        public FsmProfile ()
        {
            _BehaviorProfiles = new List<ReactiveRTM.RTC.FsmBehaviorProfile>();
        }
        public FsmProfile (global::omg.org.RTC.FsmProfile source)
        {
            _BehaviorProfiles = source.behavior_profiles.Select(x => (ReactiveRTM.RTC.FsmBehaviorProfile)new ReactiveRTM.RTC.FsmBehaviorProfile(x)).ToList();
        }

        ///<exclude/>
        public bool Equals(FsmProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._BehaviorProfiles.SequenceEqual(_BehaviorProfiles);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(FsmProfile)) return false;
            return Equals((FsmProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = _BehaviorProfiles.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class ComponentProfile : NotifyPropertyChangedBase
    {
        private System.String _InstanceName;
            
        ///<exclude/>
        public System.String InstanceName
        {
            get { return _InstanceName; }
            set 
            {
                if(!(_InstanceName == (value)))
                {
                    _InstanceName = value;
                    RaisePropertyChanged("InstanceName");
                }
            }
        }
        private System.String _TypeName;
            
        ///<exclude/>
        public System.String TypeName
        {
            get { return _TypeName; }
            set 
            {
                if(!(_TypeName == (value)))
                {
                    _TypeName = value;
                    RaisePropertyChanged("TypeName");
                }
            }
        }
        private System.String _Description;
            
        ///<exclude/>
        public System.String Description
        {
            get { return _Description; }
            set 
            {
                if(!(_Description == (value)))
                {
                    _Description = value;
                    RaisePropertyChanged("Description");
                }
            }
        }
        private System.String _Version;
            
        ///<exclude/>
        public System.String Version
        {
            get { return _Version; }
            set 
            {
                if(!(_Version == (value)))
                {
                    _Version = value;
                    RaisePropertyChanged("Version");
                }
            }
        }
        private System.String _Vendor;
            
        ///<exclude/>
        public System.String Vendor
        {
            get { return _Vendor; }
            set 
            {
                if(!(_Vendor == (value)))
                {
                    _Vendor = value;
                    RaisePropertyChanged("Vendor");
                }
            }
        }
        private System.String _Category;
            
        ///<exclude/>
        public System.String Category
        {
            get { return _Category; }
            set 
            {
                if(!(_Category == (value)))
                {
                    _Category = value;
                    RaisePropertyChanged("Category");
                }
            }
        }
        private List<ReactiveRTM.RTC.PortProfile> _PortProfiles;
            
        ///<exclude/>
        public List<ReactiveRTM.RTC.PortProfile> PortProfiles
        {
            get { return _PortProfiles; }
            set 
            {
                if(!(_PortProfiles.SequenceEqual(value)))
                {
                    _PortProfiles = value;
                    RaisePropertyChanged("PortProfiles");
                }
            }
        }
        private ReactiveRTM.RTC.RTObject _Parent;
            
        ///<exclude/>
        public ReactiveRTM.RTC.RTObject Parent
        {
            get { return _Parent; }
            set 
            {
                if(!(_Parent == (value)))
                {
                    _Parent = value;
                    RaisePropertyChanged("Parent");
                }
            }
        }
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::omg.org.RTC.ComponentProfile (ReactiveRTM.RTC.ComponentProfile source)
        {
            var instance = new global::omg.org.RTC.ComponentProfile();
            instance.instance_name =  source._InstanceName;
            instance.type_name =  source._TypeName;
            instance.description =  source._Description;
            instance.version =  source._Version;
            instance.vendor =  source._Vendor;
            instance.category =  source._Category;
            instance.port_profiles =  source._PortProfiles.Select(x=>((global::omg.org.RTC.PortProfile)((IStub)x).GetTarget())).ToArray();
            instance.parent =  ((global::omg.org.RTC.RTObject)((IStub)source._Parent).GetTarget());
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public ComponentProfile ()
        {
            _InstanceName = string.Empty;
            _TypeName = string.Empty;
            _Description = string.Empty;
            _Version = string.Empty;
            _Vendor = string.Empty;
            _Category = string.Empty;
            _PortProfiles = new List<ReactiveRTM.RTC.PortProfile>();
            _Parent = default(ReactiveRTM.RTC.RTObject);
            _Properties = new Dictionary<string,object>();
        }
        public ComponentProfile (global::omg.org.RTC.ComponentProfile source)
        {
            _InstanceName = source.instance_name;
            _TypeName = source.type_name;
            _Description = source.description;
            _Version = source.version;
            _Vendor = source.vendor;
            _Category = source.category;
            _PortProfiles = source.port_profiles.Select(x => (ReactiveRTM.RTC.PortProfile)new ReactiveRTM.RTC.PortProfile(x)).ToList();
            _Parent = new ReactiveRTM.RTC.RTObjectStub(source.parent);
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(ComponentProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._InstanceName == (_InstanceName) && other._TypeName == (_TypeName) && other._Description == (_Description) && other._Version == (_Version) && other._Vendor == (_Vendor) && other._Category == (_Category) && other._PortProfiles.SequenceEqual(_PortProfiles) && other._Parent == (_Parent) && other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ComponentProfile)) return false;
            return Equals((ComponentProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _InstanceName.GetHashCode();
                result = (result * 397) ^ _TypeName.GetHashCode();
                result = (result * 397) ^ _Description.GetHashCode();
                result = (result * 397) ^ _Version.GetHashCode();
                result = (result * 397) ^ _Vendor.GetHashCode();
                result = (result * 397) ^ _Category.GetHashCode();
                result = _PortProfiles.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                result = (result * 397) ^ _Parent.GetHashCode();
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
}
 
namespace ReactiveRTM.RTM
{
    
 
    public class ModuleProfile : NotifyPropertyChangedBase
    {
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTM.ModuleProfile (ReactiveRTM.RTM.ModuleProfile source)
        {
            var instance = new global::RTM.ModuleProfile();
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public ModuleProfile ()
        {
            _Properties = new Dictionary<string,object>();
        }
        public ModuleProfile (global::RTM.ModuleProfile source)
        {
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(ModuleProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ModuleProfile)) return false;
            return Equals((ModuleProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
 
    public class ManagerProfile : NotifyPropertyChangedBase
    {
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::RTM.ManagerProfile (ReactiveRTM.RTM.ManagerProfile source)
        {
            var instance = new global::RTM.ManagerProfile();
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public ManagerProfile ()
        {
            _Properties = new Dictionary<string,object>();
        }
        public ManagerProfile (global::RTM.ManagerProfile source)
        {
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(ManagerProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ManagerProfile)) return false;
            return Equals((ManagerProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
}
 
namespace ReactiveRTM.SDOPackage
{
    public enum NumericType
    {
        SHORT_TYPE = 0,
        LONG_TYPE = 1,
        FLOAT_TYPE = 2,
        DOUBLE_TYPE = 3,
    }
    public enum ComplexDataType
    {
        ENUMERATION = 0,
        RANGE = 1,
        INTERVAL = 2,
    }
    public enum DependencyType
    {
        OWN = 0,
        OWNED = 1,
        NO_DEPENDENCY = 2,
    }
    
 
    public class NameValue : NotifyPropertyChangedBase
    {
        private System.String _Name;
            
        ///<exclude/>
        public System.String Name
        {
            get { return _Name; }
            set 
            {
                if(!(_Name == (value)))
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        private System.Object _Value;
            
        ///<exclude/>
        public System.Object Value
        {
            get { return _Value; }
            set 
            {
                if(!(_Value == (value)))
                {
                    _Value = value;
                    RaisePropertyChanged("Value");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.NameValue (ReactiveRTM.SDOPackage.NameValue source)
        {
            var instance = new global::org.omg.SDOPackage.NameValue();
            instance.name =  source._Name;
            instance.value =  source._Value;
            return instance;
        }
        public NameValue ()
        {
            _Name = string.Empty;
            _Value = default(System.Object);
        }
        public NameValue (global::org.omg.SDOPackage.NameValue source)
        {
            _Name = source.name;
            _Value = source.value;
        }

        ///<exclude/>
        public bool Equals(NameValue other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Name == (_Name) && other._Value == (_Value);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(NameValue)) return false;
            return Equals((NameValue)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Name.GetHashCode();
                result = (result * 397) ^ _Value.GetHashCode();
                return result;
            }
        }
    }
 
    public class EnumerationType : NotifyPropertyChangedBase
    {
        private List<System.String> _EnumeratedValues;
            
        ///<exclude/>
        public List<System.String> EnumeratedValues
        {
            get { return _EnumeratedValues; }
            set 
            {
                if(!(_EnumeratedValues.SequenceEqual(value)))
                {
                    _EnumeratedValues = value;
                    RaisePropertyChanged("EnumeratedValues");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.EnumerationType (ReactiveRTM.SDOPackage.EnumerationType source)
        {
            var instance = new global::org.omg.SDOPackage.EnumerationType();
            instance.enumerated_values =  source._EnumeratedValues.Select(x=>x).ToArray();
            return instance;
        }
        public EnumerationType ()
        {
            _EnumeratedValues = new List<System.String>();
        }
        public EnumerationType (global::org.omg.SDOPackage.EnumerationType source)
        {
            _EnumeratedValues = source.enumerated_values.Select(x => (System.String)x).ToList();
        }

        ///<exclude/>
        public bool Equals(EnumerationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._EnumeratedValues.SequenceEqual(_EnumeratedValues);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(EnumerationType)) return false;
            return Equals((EnumerationType)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = _EnumeratedValues.Aggregate(result, (s,x) => (s * 397) ^ x.GetHashCode());
                return result;
            }
        }
    }
 
    public class RangeType : NotifyPropertyChangedBase
    {
        private global::org.omg.SDOPackage.Numeric _Min;
            
        ///<exclude/>
        public global::org.omg.SDOPackage.Numeric Min
        {
            get { return _Min; }
            set 
            {
                if(!(_Min.Equals(value)))
                {
                    _Min = value;
                    RaisePropertyChanged("Min");
                }
            }
        }
        private global::org.omg.SDOPackage.Numeric _Max;
            
        ///<exclude/>
        public global::org.omg.SDOPackage.Numeric Max
        {
            get { return _Max; }
            set 
            {
                if(!(_Max.Equals(value)))
                {
                    _Max = value;
                    RaisePropertyChanged("Max");
                }
            }
        }
        private System.Boolean _MinInclusive;
            
        ///<exclude/>
        public System.Boolean MinInclusive
        {
            get { return _MinInclusive; }
            set 
            {
                if(!(_MinInclusive.Equals(value)))
                {
                    _MinInclusive = value;
                    RaisePropertyChanged("MinInclusive");
                }
            }
        }
        private System.Boolean _MaxInclusive;
            
        ///<exclude/>
        public System.Boolean MaxInclusive
        {
            get { return _MaxInclusive; }
            set 
            {
                if(!(_MaxInclusive.Equals(value)))
                {
                    _MaxInclusive = value;
                    RaisePropertyChanged("MaxInclusive");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.RangeType (ReactiveRTM.SDOPackage.RangeType source)
        {
            var instance = new global::org.omg.SDOPackage.RangeType();
            instance.min =  source._Min;
            instance.max =  source._Max;
            instance.min_inclusive =  source._MinInclusive;
            instance.max_inclusive =  source._MaxInclusive;
            return instance;
        }
        public RangeType ()
        {
            _Min = new global::org.omg.SDOPackage.Numeric();
            _Max = new global::org.omg.SDOPackage.Numeric();
            _MinInclusive = new System.Boolean();
            _MaxInclusive = new System.Boolean();
        }
        public RangeType (global::org.omg.SDOPackage.RangeType source)
        {
            _Min = source.min;
            _Max = source.max;
            _MinInclusive = source.min_inclusive;
            _MaxInclusive = source.max_inclusive;
        }

        ///<exclude/>
        public bool Equals(RangeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Min.Equals(_Min) && other._Max.Equals(_Max) && other._MinInclusive.Equals(_MinInclusive) && other._MaxInclusive.Equals(_MaxInclusive);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RangeType)) return false;
            return Equals((RangeType)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Min.GetHashCode();
                result = (result * 397) ^ _Max.GetHashCode();
                result = (result * 397) ^ _MinInclusive.GetHashCode();
                result = (result * 397) ^ _MaxInclusive.GetHashCode();
                return result;
            }
        }
    }
 
    public class IntervalType : NotifyPropertyChangedBase
    {
        private global::org.omg.SDOPackage.Numeric _Min;
            
        ///<exclude/>
        public global::org.omg.SDOPackage.Numeric Min
        {
            get { return _Min; }
            set 
            {
                if(!(_Min.Equals(value)))
                {
                    _Min = value;
                    RaisePropertyChanged("Min");
                }
            }
        }
        private global::org.omg.SDOPackage.Numeric _Max;
            
        ///<exclude/>
        public global::org.omg.SDOPackage.Numeric Max
        {
            get { return _Max; }
            set 
            {
                if(!(_Max.Equals(value)))
                {
                    _Max = value;
                    RaisePropertyChanged("Max");
                }
            }
        }
        private System.Boolean _MinInclusive;
            
        ///<exclude/>
        public System.Boolean MinInclusive
        {
            get { return _MinInclusive; }
            set 
            {
                if(!(_MinInclusive.Equals(value)))
                {
                    _MinInclusive = value;
                    RaisePropertyChanged("MinInclusive");
                }
            }
        }
        private System.Boolean _MaxInclusive;
            
        ///<exclude/>
        public System.Boolean MaxInclusive
        {
            get { return _MaxInclusive; }
            set 
            {
                if(!(_MaxInclusive.Equals(value)))
                {
                    _MaxInclusive = value;
                    RaisePropertyChanged("MaxInclusive");
                }
            }
        }
        private global::org.omg.SDOPackage.Numeric _Step;
            
        ///<exclude/>
        public global::org.omg.SDOPackage.Numeric Step
        {
            get { return _Step; }
            set 
            {
                if(!(_Step.Equals(value)))
                {
                    _Step = value;
                    RaisePropertyChanged("Step");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.IntervalType (ReactiveRTM.SDOPackage.IntervalType source)
        {
            var instance = new global::org.omg.SDOPackage.IntervalType();
            instance.min =  source._Min;
            instance.max =  source._Max;
            instance.min_inclusive =  source._MinInclusive;
            instance.max_inclusive =  source._MaxInclusive;
            instance._step =  source._Step;
            return instance;
        }
        public IntervalType ()
        {
            _Min = new global::org.omg.SDOPackage.Numeric();
            _Max = new global::org.omg.SDOPackage.Numeric();
            _MinInclusive = new System.Boolean();
            _MaxInclusive = new System.Boolean();
            _Step = new global::org.omg.SDOPackage.Numeric();
        }
        public IntervalType (global::org.omg.SDOPackage.IntervalType source)
        {
            _Min = source.min;
            _Max = source.max;
            _MinInclusive = source.min_inclusive;
            _MaxInclusive = source.max_inclusive;
            _Step = source._step;
        }

        ///<exclude/>
        public bool Equals(IntervalType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Min.Equals(_Min) && other._Max.Equals(_Max) && other._MinInclusive.Equals(_MinInclusive) && other._MaxInclusive.Equals(_MaxInclusive) && other._Step.Equals(_Step);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(IntervalType)) return false;
            return Equals((IntervalType)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Min.GetHashCode();
                result = (result * 397) ^ _Max.GetHashCode();
                result = (result * 397) ^ _MinInclusive.GetHashCode();
                result = (result * 397) ^ _MaxInclusive.GetHashCode();
                result = (result * 397) ^ _Step.GetHashCode();
                return result;
            }
        }
    }
 
    public class Parameter : NotifyPropertyChangedBase
    {
        private System.String _Name;
            
        ///<exclude/>
        public System.String Name
        {
            get { return _Name; }
            set 
            {
                if(!(_Name == (value)))
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        private ReactiveRTM.CORBA.TypeCode _Type;
            
        ///<exclude/>
        public ReactiveRTM.CORBA.TypeCode Type
        {
            get { return _Type; }
            set 
            {
                if(!(_Type == (value)))
                {
                    _Type = value;
                    RaisePropertyChanged("Type");
                }
            }
        }
        private global::org.omg.SDOPackage.AllowedValues _AllowedValues;
            
        ///<exclude/>
        public global::org.omg.SDOPackage.AllowedValues AllowedValues
        {
            get { return _AllowedValues; }
            set 
            {
                if(!(_AllowedValues.Equals(value)))
                {
                    _AllowedValues = value;
                    RaisePropertyChanged("AllowedValues");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.Parameter (ReactiveRTM.SDOPackage.Parameter source)
        {
            var instance = new global::org.omg.SDOPackage.Parameter();
            instance.name =  source._Name;
            instance.type =  ((global::omg.org.CORBA.TypeCode)((IStub)source._Type).GetTarget());
            instance.allowed_values =  source._AllowedValues;
            return instance;
        }
        public Parameter ()
        {
            _Name = string.Empty;
            _Type = default(ReactiveRTM.CORBA.TypeCode);
            _AllowedValues = new global::org.omg.SDOPackage.AllowedValues();
        }
        public Parameter (global::org.omg.SDOPackage.Parameter source)
        {
            _Name = source.name;
            _Type = new ReactiveRTM.CORBA.TypeCodeStub(source.type);
            _AllowedValues = source.allowed_values;
        }

        ///<exclude/>
        public bool Equals(Parameter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Name == (_Name) && other._Type == (_Type) && other._AllowedValues.Equals(_AllowedValues);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Parameter)) return false;
            return Equals((Parameter)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Name.GetHashCode();
                result = (result * 397) ^ _Type.GetHashCode();
                result = (result * 397) ^ _AllowedValues.GetHashCode();
                return result;
            }
        }
    }
 
    public class OrganizationProperty : NotifyPropertyChangedBase
    {
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.OrganizationProperty (ReactiveRTM.SDOPackage.OrganizationProperty source)
        {
            var instance = new global::org.omg.SDOPackage.OrganizationProperty();
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public OrganizationProperty ()
        {
            _Properties = new Dictionary<string,object>();
        }
        public OrganizationProperty (global::org.omg.SDOPackage.OrganizationProperty source)
        {
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(OrganizationProperty other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(OrganizationProperty)) return false;
            return Equals((OrganizationProperty)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
 
    public class DeviceProfile : NotifyPropertyChangedBase
    {
        private System.String _DeviceType;
            
        ///<exclude/>
        public System.String DeviceType
        {
            get { return _DeviceType; }
            set 
            {
                if(!(_DeviceType == (value)))
                {
                    _DeviceType = value;
                    RaisePropertyChanged("DeviceType");
                }
            }
        }
        private System.String _Manufacturer;
            
        ///<exclude/>
        public System.String Manufacturer
        {
            get { return _Manufacturer; }
            set 
            {
                if(!(_Manufacturer == (value)))
                {
                    _Manufacturer = value;
                    RaisePropertyChanged("Manufacturer");
                }
            }
        }
        private System.String _Model;
            
        ///<exclude/>
        public System.String Model
        {
            get { return _Model; }
            set 
            {
                if(!(_Model == (value)))
                {
                    _Model = value;
                    RaisePropertyChanged("Model");
                }
            }
        }
        private System.String _Version;
            
        ///<exclude/>
        public System.String Version
        {
            get { return _Version; }
            set 
            {
                if(!(_Version == (value)))
                {
                    _Version = value;
                    RaisePropertyChanged("Version");
                }
            }
        }
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.DeviceProfile (ReactiveRTM.SDOPackage.DeviceProfile source)
        {
            var instance = new global::org.omg.SDOPackage.DeviceProfile();
            instance.device_type =  source._DeviceType;
            instance.manufacturer =  source._Manufacturer;
            instance.model =  source._Model;
            instance.version =  source._Version;
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            return instance;
        }
        public DeviceProfile ()
        {
            _DeviceType = string.Empty;
            _Manufacturer = string.Empty;
            _Model = string.Empty;
            _Version = string.Empty;
            _Properties = new Dictionary<string,object>();
        }
        public DeviceProfile (global::org.omg.SDOPackage.DeviceProfile source)
        {
            _DeviceType = source.device_type;
            _Manufacturer = source.manufacturer;
            _Model = source.model;
            _Version = source.version;
            _Properties = Converter.NVListToDictionary(source.properties);
        }

        ///<exclude/>
        public bool Equals(DeviceProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._DeviceType == (_DeviceType) && other._Manufacturer == (_Manufacturer) && other._Model == (_Model) && other._Version == (_Version) && other._Properties.SequenceEqual(_Properties);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(DeviceProfile)) return false;
            return Equals((DeviceProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _DeviceType.GetHashCode();
                result = (result * 397) ^ _Manufacturer.GetHashCode();
                result = (result * 397) ^ _Model.GetHashCode();
                result = (result * 397) ^ _Version.GetHashCode();
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
 
    public class ServiceProfile : NotifyPropertyChangedBase
    {
        private System.String _Id;
            
        ///<exclude/>
        public System.String Id
        {
            get { return _Id; }
            set 
            {
                if(!(_Id == (value)))
                {
                    _Id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }
        private System.String _InterfaceType;
            
        ///<exclude/>
        public System.String InterfaceType
        {
            get { return _InterfaceType; }
            set 
            {
                if(!(_InterfaceType == (value)))
                {
                    _InterfaceType = value;
                    RaisePropertyChanged("InterfaceType");
                }
            }
        }
        private Dictionary<string,object> _Properties;
            
        ///<exclude/>
        public Dictionary<string,object> Properties
        {
            get { return _Properties; }
            set 
            {
                if(!(_Properties.SequenceEqual(value)))
                {
                    _Properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }
        private ReactiveRTM.SDOPackage.SDOService _Service;
            
        ///<exclude/>
        public ReactiveRTM.SDOPackage.SDOService Service
        {
            get { return _Service; }
            set 
            {
                if(!(_Service == (value)))
                {
                    _Service = value;
                    RaisePropertyChanged("Service");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.ServiceProfile (ReactiveRTM.SDOPackage.ServiceProfile source)
        {
            var instance = new global::org.omg.SDOPackage.ServiceProfile();
            instance.id =  source._Id;
            instance.interface_type =  source._InterfaceType;
            instance.properties =  Converter.DictionaryToNVList(source._Properties);
            instance.service =  ((global::org.omg.SDOPackage.SDOService)((IStub)source._Service).GetTarget());
            return instance;
        }
        public ServiceProfile ()
        {
            _Id = string.Empty;
            _InterfaceType = string.Empty;
            _Properties = new Dictionary<string,object>();
            _Service = default(ReactiveRTM.SDOPackage.SDOService);
        }
        public ServiceProfile (global::org.omg.SDOPackage.ServiceProfile source)
        {
            _Id = source.id;
            _InterfaceType = source.interface_type;
            _Properties = Converter.NVListToDictionary(source.properties);
            _Service = new ReactiveRTM.SDOPackage.SDOServiceStub(source.service);
        }

        ///<exclude/>
        public bool Equals(ServiceProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Id == (_Id) && other._InterfaceType == (_InterfaceType) && other._Properties.SequenceEqual(_Properties) && other._Service == (_Service);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ServiceProfile)) return false;
            return Equals((ServiceProfile)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Id.GetHashCode();
                result = (result * 397) ^ _InterfaceType.GetHashCode();
                result = _Properties.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                result = (result * 397) ^ _Service.GetHashCode();
                return result;
            }
        }
    }
 
    public class ConfigurationSet : NotifyPropertyChangedBase
    {
        private System.String _Id;
            
        ///<exclude/>
        public System.String Id
        {
            get { return _Id; }
            set 
            {
                if(!(_Id == (value)))
                {
                    _Id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }
        private System.String _Description;
            
        ///<exclude/>
        public System.String Description
        {
            get { return _Description; }
            set 
            {
                if(!(_Description == (value)))
                {
                    _Description = value;
                    RaisePropertyChanged("Description");
                }
            }
        }
        private Dictionary<string,object> _ConfigurationData;
            
        ///<exclude/>
        public Dictionary<string,object> ConfigurationData
        {
            get { return _ConfigurationData; }
            set 
            {
                if(!(_ConfigurationData.SequenceEqual(value)))
                {
                    _ConfigurationData = value;
                    RaisePropertyChanged("ConfigurationData");
                }
            }
        }
        public string RepositoryId
        {
            //TODO:
            get { return ""; }
        }
        public static explicit operator global::org.omg.SDOPackage.ConfigurationSet (ReactiveRTM.SDOPackage.ConfigurationSet source)
        {
            var instance = new global::org.omg.SDOPackage.ConfigurationSet();
            instance.id =  source._Id;
            instance.description =  source._Description;
            instance.configuration_data =  Converter.DictionaryToNVList(source._ConfigurationData);
            return instance;
        }
        public ConfigurationSet ()
        {
            _Id = string.Empty;
            _Description = string.Empty;
            _ConfigurationData = new Dictionary<string,object>();
        }
        public ConfigurationSet (global::org.omg.SDOPackage.ConfigurationSet source)
        {
            _Id = source.id;
            _Description = source.description;
            _ConfigurationData = Converter.NVListToDictionary(source.configuration_data);
        }

        ///<exclude/>
        public bool Equals(ConfigurationSet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._Id == (_Id) && other._Description == (_Description) && other._ConfigurationData.SequenceEqual(_ConfigurationData);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ConfigurationSet)) return false;
            return Equals((ConfigurationSet)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ _Id.GetHashCode();
                result = (result * 397) ^ _Description.GetHashCode();
                result = _ConfigurationData.Aggregate(result, (s, x) => (((s * 397) ^ x.Key.GetHashCode()) * 397) ^ x.Value.GetHashCode());
                return result;
            }
        }
    }
}
