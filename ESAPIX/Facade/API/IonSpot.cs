#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonSpot : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public IonSpot()
        {
            _client = new ExpandoObject();
        }

        public IonSpot(dynamic client)
        {
            _client = client;
        }

        public VVector Position
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Position"))
                        return _client.Position;
                    else
                        return default(VVector);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Position; }
                    );
                return default(VVector);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Position = value;
            }
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
                {
                    _client.Weight = value;
                }
            }
        }
    }
}