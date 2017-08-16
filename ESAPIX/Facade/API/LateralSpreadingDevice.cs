#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class LateralSpreadingDevice : AddOn, System.Xml.Serialization.IXmlSerializable
    {
        public LateralSpreadingDevice()
        {
            _client = new ExpandoObject();
        }

        public LateralSpreadingDevice(dynamic client)
        {
            _client = client;
        }

        public LateralSpreadingDeviceType Type
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Type"))
                        return _client.Type;
                    else
                        return default(LateralSpreadingDeviceType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Type; }
                    );
                return default(LateralSpreadingDeviceType);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.Type = value;
                }
            }
        }
    }
}