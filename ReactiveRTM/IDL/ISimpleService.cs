using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using Ch.Elca.Iiop;
using Ch.Elca.Iiop.Idl;

namespace ReactiveRTM.IDL
{
    [ExplicitSerializationOrdered, RepositoryID("IDL:ReactiveRTM/SimpleServiceException:1.0")]
    [Serializable]
    public class SimpleServiceException : AbstractUserException, IIdlEntity
    {
        [WideChar(true), ExplicitSerializationOrderNr(0), StringValue]
        public string Description;

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("description", this.Description, typeof(string));
        }
        
        protected SimpleServiceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.Description = (string)info.GetValue("description", typeof(string));
        }
        
        public SimpleServiceException()
        {
        }
    }

    [InterfaceType(IdlTypeInterface.ConcreteInterface), RepositoryID("IDL:ReactiveRTM/SimpleService:1.0")]
    public interface ISimpleService : IIdlEntity
    {
        [FromIdlName("invoke"), ThrowsIdlException(typeof(SimpleServiceException))]
        [return: WideChar(true), StringValue, IdlSequence(0L)]
        string[] Invoke([WideChar(true), StringValue] string operation, [IdlSequence(0L), WideChar(true), StringValue] string[] args);
    }

    [InterfaceType(IdlTypeInterface.ConcreteInterface), RepositoryID("IDL:ReactiveRTM/ResultListener:1.0")]
    public interface IResultListener
    {
        [OneWay]
        void OnCompleted([IdlSequence(0L), WideChar(true), StringValue]string[] result);

        [OneWay]
        void OnError(SimpleServiceException exception);
    }

    [SupportedInterface(typeof(IResultListener))]
    public class ResultListener : MarshalByRefObject, IResultListener
    {
        public ResultListener(string userName, IAsyncSimpleService view)
        {
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public void OnCompleted(string[] result)
        {
            throw new NotImplementedException();
        }

        public void OnError(SimpleServiceException exception)
        {
            throw new NotImplementedException();
        }
    }

    [InterfaceType(IdlTypeInterface.ConcreteInterface), RepositoryID("IDL:ReactiveRTM/AsyncSimpleService:1.0")]
    public interface IAsyncSimpleService
    {
        [FromIdlName("invokeAsync")]
        void InvokeAsync([WideChar(true), StringValue] string operation, [IdlSequence(0L), WideChar(true), StringValue] string[] args, IResultListener listener);
    }

    [SupportedInterface(typeof(IAsyncSimpleService))]
    public class AsyncSimpleService : MarshalByRefObject, IAsyncSimpleService
    {
        public override object InitializeLifetimeService()
        {
            // live forever
            return null;
        }

        public void InvokeAsync(string operation, string[] args, IResultListener listener)
        {
            throw new NotImplementedException();
        }
    }
}
