using System;
using System.Collections.Generic;

namespace ReactiveRTM.Corba
{
    public interface INamingServiceClient : IDisposable
    {
        void Initialize(Dictionary<string, string> setting);
        /// <summary>
        /// コンポーネントをネーミングサービスに登録する
        /// </summary>
        /// <param name="name">登録する名前</param>
        /// <param name="obj">登録するコンポーネントの参照</param>
        void RegisterObject(string name, MarshalByRefObject obj);

        /// <summary>
        /// ネーミングサービスに登録されているオブジェクトを削除する
        /// </summary>
        /// <param name="name">登録されている名前</param>
        void UnregisterObject(string name);

        /// <summary>
        ///   名前指定でコンポーネントの取得
        /// </summary>
        /// <param name="name">コンポーネントの名前</param>
        /// <returns>取得したコンポーネント</returns>
        TObjectType GetObject<TObjectType>(string name) where TObjectType : class;

        /// <summary>
        ///   ネーミングサービスに登録されているオブジェクト名一覧の取得
        /// </summary>
        /// <returns>オブジェクト名一覧</returns>
        IEnumerable<string> GetObjectNames();
        
    }

}
