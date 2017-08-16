#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class RangeShifter : AddOn, System.Xml.Serialization.IXmlSerializable
    {
        public RangeShifter()
        {
            _client = new ExpandoObject();
        }

        public RangeShifter(dynamic client)
        {
            _client = client;
        }

        public RangeShifterType Type
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Type"))
                        return _client.Type;
                    else
                        return default(RangeShifterType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Type; }
                    );
                return default(RangeShifterType);
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