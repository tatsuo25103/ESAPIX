#region

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonControlPointPairCollection : IEnumerable<IonControlPointPair>, IEnumerable
    {
        internal dynamic _client;

        public IonControlPointPairCollection()
        {
            _client = new ExpandoObject();
        }

        public IonControlPointPairCollection(dynamic client)
        {
            _client = client;
        }

        public bool IsLive
        {
            get { return !DefaultHelper.IsDefault(_client) && !(_client is ExpandoObject); }
        }

        public IonControlPointPair this[int index]
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Item"))
                        return _client[index];
                    else
                        return default(IonControlPointPair);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client[index] != null)
                                return new IonControlPointPair(_client[index]);
                            return null;
                        }
                    );
                return default(IonControlPointPair);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client[index] = value;
            }
        }

        public int Count
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Count"))
                        return _client.Count;
                    else
                        return default(int);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Count; }
                    );
                return default(int);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.Count = value;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
                yield return this[i];
        }

        public IEnumerator<IonControlPointPair> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
                yield return this[i];
        }
    }
}