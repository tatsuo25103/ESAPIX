#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class RangeModulator : AddOn, System.Xml.Serialization.IXmlSerializable
    {
        public RangeModulator()
        {
            _client = new ExpandoObject();
        }

        public RangeModulator(dynamic client)
        {
            _client = client;
        }

        public RangeModulatorType Type
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Type"))
                        return _client.Type;
                    else
                        return default(RangeModulatorType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Type; }
                    );
                return default(RangeModulatorType);
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