#region

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonControlPointCollection : SerializableObject, System.Xml.Serialization.IXmlSerializable,
        IEnumerable<IonControlPoint>, IEnumerable
    {
        public IonControlPointCollection()
        {
            _client = new ExpandoObject();
        }

        public IonControlPointCollection(dynamic client)
        {
            _client = client;
        }

        public IonControlPoint this[int index]
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Item"))
                        return _client[index];
                    else
                        return default(IonControlPoint);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client[index] != null)
                                return new IonControlPoint(_client[index]);
                            return null;
                        }
                    );
                return default(IonControlPoint);
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

        public IEnumerator<IonControlPoint> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
                yield return this[i];
        }
    }
}