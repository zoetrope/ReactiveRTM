using System;
using System.Collections.Generic;
using System.Linq;
using Ch.Elca.Iiop.Services;

namespace ReactiveRTM.Corba
{
    /// <summary>
    ///   CORBA Naming Service Client
    /// </summary>
    public class NamingServiceClient : INamingServiceClient
    {
        private readonly global::omg.org.CosNaming.NamingContext _rootContext;

        /// <summary>
        ///   <see cref = "NamingServiceClient" />のインスタンス生成<br />  
        ///   ホスト名:"localhost"、ポート番号:2809 でインスタンスを生成する
        /// </summary>
        public NamingServiceClient()
            : this("localhost", 2809)
        {
        }

        /// <summary>
        ///   <see cref = "NamingServiceClient" />のインスタンス生成
        /// </summary>
        /// <param name = "host">ホスト名</param>
        /// <param name = "port">ポート番号</param>
        public NamingServiceClient(string host, int port)
        {
            // ネーミングサービスの参照を取得する
            CorbaInit init = CorbaInit.GetInit();
            _rootContext = init.GetNameService(host, port);

            NameDelimiter = '.';
            TreeDelimiter = '/';

            HostName = host;
            PortNumber = port;
            Key = HostName + ":" + PortNumber;
        }

        /// <summary>
        ///   オブジェクトの名前を文字列で表現するときのIDとKINDの区切り文字。
        ///   デフォルトでは'.'
        /// </summary>
        public char NameDelimiter { get; set; }

        /// <summary>
        ///   オブジェクトの名前を文字列で表現するときの階層の区切り文字。
        ///   デフォルトでは'/'
        /// </summary>
        public char TreeDelimiter { get; set; }

        #region INamingServiceClient Members

        public string Key { get; private set; }

        public string HostName { get; private set; }

        public int PortNumber { get; private set; }

        /// <summary>
        ///   終了処理
        /// </summary>
        public void Dispose()
        {
            try
            {
                _rootContext.destroy();
            }
            catch (Exception)
            {
                // Do nothing
            }
        }


        /// <summary>
        ///   コンポーネントをネーミングサービスに登録する
        /// </summary>
        /// <param name = "name">登録する名前</param>
        /// <param name = "obj">登録するコンポーネントの参照</param>
        public void RegisterObject(string name, MarshalByRefObject obj)
        {
            BindObject(StringToNameComponents(name), obj);
        }

        /// <summary>
        ///   ネーミングサービスに登録されているオブジェクトを削除する
        /// </summary>
        /// <param name = "name">登録されている名前</param>
        public void UnregisterObject(string name)
        {
            _rootContext.unbind(StringToNameComponents(name));
        }


        /// <summary>
        ///   名前指定でコンポーネントの取得
        /// </summary>
        /// <param name = "name">コンポーネントの名前</param>
        /// <returns>取得したコンポーネント</returns>
        public TObjectType GetObject<TObjectType>(string name) where TObjectType : class
        {
            var obj = _rootContext.resolve(StringToNameComponents(name));

            if (!IsA<TObjectType>(obj))
            {
                throw new InvalidCastException(typeof (TObjectType).FullName + "にキャストできません。");
            }

            return obj as TObjectType;
        }

        /// <summary>
        ///   ネーミングサービスに登録されているオブジェクト名一覧の取得
        /// </summary>
        public IEnumerable<string> GetObjectNames()
        {
            return GetObjectNamesRecursive(_rootContext, "");
        }

        #endregion

        /// <summary>
        ///   指定した型の無効なオブジェクトを削除する
        /// </summary>
        public void ClearZombie<TObject>()
        {
            foreach (string name in GetObjectNames())
            {
                MarshalByRefObject obj;
                try
                {
                    obj = _rootContext.resolve(StringToNameComponents(name));
                }
                catch (global::omg.org.CosNaming.NamingContext_package.NotFound)
                {
                    continue;
                }

                try
                {
                    if (!IsA<TObject>(obj))
                    {
                        continue;
                    }
                }
                catch (global::omg.org.CORBA.TRANSIENT)
                {
                    try
                    {
                        UnregisterObject(name);
                    }
                    catch (global::omg.org.CosNaming.NamingContext_package.NotFound)
                    {
                    }
                }
            }
        }

        private void BindObject(global::omg.org.CosNaming.NameComponent[] name, MarshalByRefObject obj)
        {
            try
            {
                _rootContext.rebind(name, obj);
            }
            catch (global::omg.org.CosNaming.NamingContext_package.NotFound)
            {
                BindObjectRecursive(_rootContext, name, obj);
            }
            catch (global::omg.org.CosNaming.NamingContext_package.CannotProceed ex)
            {
                BindObjectRecursive(ex.cxt, ex.rest_of_name, obj);
            }
        }

        private void BindObjectRecursive(global::omg.org.CosNaming.NamingContext context, global::omg.org.CosNaming.NameComponent[] name, MarshalByRefObject obj)
        {
            int len = name.Length;
            var cxt = context;

            for (int i = 0; i < len; i++)
            {
                if (i == len - 1)
                {
                    var objectName = new[] {name[len - 1]};
                    BindObject(objectName, obj);
                }
                else
                {
                    var contextName = new[] {name[i]};
                    try
                    {
                        cxt = cxt.bind_new_context(contextName);
                    }
                    catch (global::omg.org.CosNaming.NamingContext_package.AlreadyBound)
                    {
                        cxt = (global::omg.org.CosNaming.NamingContext)cxt.resolve(contextName);
                    }
                }
            }
        }


        /// <summary>
        ///   指定した名前のオブジェクトがTObject型かどうかを判断する
        /// </summary>
        public bool IsA<TObject>(MarshalByRefObject obj)
        {
            try
            {
                var orb = global::omg.org.CORBA.OrbServices.GetSingleton();
                if (!orb.is_a(obj, typeof (TObject)))
                {
                    return false;
                }
            }
            catch (global::omg.org.CORBA.TRANSIENT)
            {
                return false;
            }

            return true;
        }

        private IEnumerable<string> GetObjectNamesRecursive(global::omg.org.CosNaming.NamingContext context, string name)
        {
            const int lote = 10;
            global::omg.org.CosNaming.Binding[] bindList;
            global::omg.org.CosNaming.BindingIterator bindIter;

            // 現在の階層に登録されているコンテキストをlote個ずつ取得する
            context.list(lote, out bindList, out bindIter);

            do
            {
                for (int i = 0; i < bindList.Length; i++)
                {
                    string newName = string.Copy(name);

                    // IDとKINDを'.'で区切る。
                    newName += bindList[i].binding_name[0].id;
                    newName += NameDelimiter;
                    newName += bindList[i].binding_name[0].kind;

                    if (bindList[i].binding_type == global::omg.org.CosNaming.BindingType.ncontext)
                    {
                        // バインドされているものがコンテキストでない場合は
                        // さらに下の階層がある。

                        // 階層を'/'で区切る
                        newName += TreeDelimiter;

                        // 一つ下の階層のネーミングコンテキストを取得する
                        MarshalByRefObject obj = context.resolve(bindList[i].binding_name);
                        var nc = (global::omg.org.CosNaming.NamingContext)obj;

                        // 次の階層へ
                        foreach (var n in GetObjectNamesRecursive(nc, newName))
                        {
                            yield return n;
                        }
                    }
                    else
                    {
                        // これより下の階層はないので、現在の名前を返す
                        yield return newName;
                    }
                }
            } while ((bindIter != null) && bindIter.next_n(lote, out bindList));

            // 後片付け
            if (bindIter != null)
            {
                bindIter.destroy();
            }
        }


        private global::omg.org.CosNaming.NameComponent[] StringToNameComponents(string stringName)
        {
            if (stringName == string.Empty)
            {
                throw new global::omg.org.CosNaming.NamingContext_package.InvalidName("stringName is empty.");
            }

            string[] subcol = stringName.Split(new[] {TreeDelimiter});
            var context = new global::omg.org.CosNaming.NameComponent[subcol.Length];
            int index = 0;

            foreach (string sub in subcol)
            {
                string[] subsubcol = sub.Split(new[] {NameDelimiter});
                if (subsubcol.Length == 2)
                {
                    context[index++] = new global::omg.org.CosNaming.NameComponent(subsubcol[0], subsubcol[1]);
                }
                else
                {
                    context[index++] = new global::omg.org.CosNaming.NameComponent(sub, "");
                }
            }

            return context;
        }

        public NamingContextInfo RootContextInfo {
            get { return new NamingContextInfo(null, null, _rootContext); }
        }

        public void Initialize(Dictionary<string, string> setting)
        {
            throw new NotImplementedException();
        }
    }

    
// var comps = context.Contexts
// .Expand(x => x.Contexts)
// .SelectMany(x => x.Objects)
// .Concat(context.Objects)
// .Select(x => x.FullName);
            

    public abstract class NamingInfoBase
    {
        private NamingContextInfo _parent;
        private global::omg.org.CosNaming.NameComponent[] _name;

        /// <summary>
        /// オブジェクトの名前を文字列で表現するときのIDとKINDの区切り文字。
        /// デフォルトでは'.'
        /// </summary>
        public static char NameDelimiter { get; set; }

        /// <summary>
        /// オブジェクトの名前を文字列で表現するときの階層の区切り文字。
        /// デフォルトでは'/'
        /// </summary>
        public static char TreeDelimiter { get; set; }

        static NamingInfoBase()
        {
            NameDelimiter = '.';
            TreeDelimiter = '/';
        }

        protected NamingInfoBase(NamingContextInfo parent, global::omg.org.CosNaming.NameComponent[] name)
        {
            _parent = parent;
            _name = name;
        }

        public string Name
        {
            get {
                return _name == null ? "" : _name.First().id + NameDelimiter + _name.First().kind;
            }
        }
        public string FullName
        {
            get {
                return (_parent == null ? "" : _parent.FullName + TreeDelimiter) + Name;
            }
        }
    }

    public class NamingContextInfo : NamingInfoBase
    {
        private global::omg.org.CosNaming.NamingContext _context;

        public NamingContextInfo(NamingContextInfo parent, global::omg.org.CosNaming.NameComponent[] name, global::omg.org.CosNaming.NamingContext context)
            : base(parent, name)
        {
            _context = context;
        }


        public IEnumerable<NamingContextInfo> Contexts
        {
            get
            {
                const int lote = 10;
                global::omg.org.CosNaming.Binding[] bindList;
                global::omg.org.CosNaming.BindingIterator bindIter;

                // 現在の階層に登録されているコンテキストをlote個ずつ取得する
                _context.list(lote, out bindList, out bindIter);

                do
                {
                    for (int i = 0; i < bindList.Length; i++)
                    {
                        if (bindList[i].binding_type == global::omg.org.CosNaming.BindingType.ncontext)
                        {
                            var name = bindList[i].binding_name;
                            MarshalByRefObject obj = _context.resolve(name);
                            var nc = (global::omg.org.CosNaming.NamingContext)obj;
                            yield return new NamingContextInfo(this, name, nc);
                        }
                    }
                } while ((bindIter != null) && bindIter.next_n(lote, out bindList));

                // 後片付け
                if (bindIter != null)
                {
                    bindIter.destroy();
                }

            }
        }

        public IEnumerable<NamingObjectInfo> Objects
        {
            get
            {
                const int lote = 10;
                global::omg.org.CosNaming.Binding[] bindList;
                global::omg.org.CosNaming.BindingIterator bindIter;

                // 現在の階層に登録されているコンテキストをlote個ずつ取得する
                _context.list(lote, out bindList, out bindIter);

                do
                {
                    for (int i = 0; i < bindList.Length; i++)
                    {
                        if (bindList[i].binding_type == global::omg.org.CosNaming.BindingType.nobject)
                        {
                            var name = bindList[i].binding_name;
                            MarshalByRefObject obj = _context.resolve(name);
                            yield return new NamingObjectInfo(this, name, obj);

                        }
                    }
                } while ((bindIter != null) && bindIter.next_n(lote, out bindList));

                // 後片付け
                if (bindIter != null)
                {
                    bindIter.destroy();
                }
            }
        }
    }

    public class NamingObjectInfo : NamingInfoBase
    {
        private MarshalByRefObject _object;

        public NamingObjectInfo(NamingContextInfo parent, global::omg.org.CosNaming.NameComponent[] name, MarshalByRefObject obj)
            : base(parent, name)
        {
            _object = obj;
        }
    }
}

