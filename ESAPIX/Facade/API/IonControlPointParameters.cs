#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonControlPointParameters : ControlPointParameters
    {
        public IonControlPointParameters()
        {
            _client = new ExpandoObject();
        }

        public IonControlPointParameters(dynamic client)
        {
            _client = client;
        }

        public IonSpotParametersCollection FinalSpotList
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("FinalSpotList"))
                        return _client.FinalSpotList;
                    else
                        return default(IonSpotParametersCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.FinalSpotList != null)
                                return new IonSpotParametersCollection(_client.FinalSpotList);
                            return null;
                        }
                    );
                return default(IonSpotParametersCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.FinalSpotList = value;
            }
        }

        public IonSpotParametersCollection RawSpotList
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RawSpotList"))
                        return _client.RawSpotList;
                    else
                        return default(IonSpotParametersCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.RawSpotList != null)
                                return new IonSpotParametersCollection(_client.RawSpotList);
                            return null;
                        }
                    );
                return default(IonSpotParametersCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.RawSpotList = value;
                }
            }
        }
    }
}