#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class RangeModulatorSettings : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public RangeModulatorSettings()
        {
            _client = new ExpandoObject();
        }

        public RangeModulatorSettings(dynamic client)
        {
            _client = client;
        }

        public double IsocenterToRangeModulatorDistance
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsocenterToRangeModulatorDistance"))
                        return _client.IsocenterToRangeModulatorDistance;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(
                        sc => { return _client.IsocenterToRangeModulatorDistance; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsocenterToRangeModulatorDistance = value;
            }
        }

        public double RangeModulatorGatingStartValue
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RangeModulatorGatingStartValue"))
                        return _client.RangeModulatorGatingStartValue;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.RangeModulatorGatingStartValue; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeModulatorGatingStartValue = value;
            }
        }

        public double RangeModulatorGatingStarWaterEquivalentThickness
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RangeModulatorGatingStarWaterEquivalentThickness"))
                        return _client.RangeModulatorGatingStarWaterEquivalentThickness;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            return _client.RangeModulatorGatingStarWaterEquivalentThickness;
                        }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeModulatorGatingStarWaterEquivalentThickness = value;
            }
        }

        public double RangeModulatorGatingStopValue
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RangeModulatorGatingStopValue"))
                        return _client.RangeModulatorGatingStopValue;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.RangeModulatorGatingStopValue; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeModulatorGatingStopValue = value;
            }
        }

        public double RangeModulatorGatingStopWaterEquivalentThickness
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RangeModulatorGatingStopWaterEquivalentThickness"))
                        return _client.RangeModulatorGatingStopWaterEquivalentThickness;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            return _client.RangeModulatorGatingStopWaterEquivalentThickness;
                        }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeModulatorGatingStopWaterEquivalentThickness = value;
            }
        }

        public RangeModulator ReferencedRangeModulator
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ReferencedRangeModulator"))
                        return _client.ReferencedRangeModulator;
                    else
                        return default(RangeModulator);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.ReferencedRangeModulator != null)
                                return new RangeModulator(_client.ReferencedRangeModulator);
                            return null;
                        }
                    );
                return default(RangeModulator);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.ReferencedRangeModulator = value;
                }
            }
        }
    }
}