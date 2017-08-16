#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonSpotParameters : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public IonSpotParameters()
        {
            _client = new ExpandoObject();
        }

        public IonSpotParameters(dynamic client)
        {
            _client = client;
        }

        public float Weight
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Weight"))
                        return _client.Weight;
                    else
                        return default(float);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Weight; }
                    );
                return default(float);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Weight = value;
            }
        }

        public float X
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("X"))
                        return _client.X;
                    else
                        return default(float);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.X; }
                    );
                return default(float);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.X = value;
            }
        }

        public float Y
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Y"))
                        return _client.Y;
                    else
                        return default(float);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Y; }
                    );
                return default(float);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.Y = value;
                }
            }
        }
    }
}