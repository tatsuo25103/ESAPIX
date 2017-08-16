#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class RangeShifterSettings : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public RangeShifterSettings()
        {
            _client = new ExpandoObject();
        }

        public RangeShifterSettings(dynamic client)
        {
            _client = client;
        }

        public double IsocenterToRangeShifterDistance
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsocenterToRangeShifterDistance"))
                        return _client.IsocenterToRangeShifterDistance;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsocenterToRangeShifterDistance; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsocenterToRangeShifterDistance = value;
            }
        }

        public string RangeShifterSetting
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RangeShifterSetting"))
                        return _client.RangeShifterSetting;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.RangeShifterSetting; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeShifterSetting = value;
            }
        }

        public double RangeShifterWaterEquivalentThickness
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RangeShifterWaterEquivalentThickness"))
                        return _client.RangeShifterWaterEquivalentThickness;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            return _client.RangeShifterWaterEquivalentThickness;
                        }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeShifterWaterEquivalentThickness = value;
            }
        }

        public RangeShifter ReferencedRangeShifter
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ReferencedRangeShifter"))
                        return _client.ReferencedRangeShifter;
                    else
                        return default(RangeShifter);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.ReferencedRangeShifter != null)
                                return new RangeShifter(_client.ReferencedRangeShifter);
                            return null;
                        }
                    );
                return default(RangeShifter);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.ReferencedRangeShifter = value;
                }
            }
        }
    }
}