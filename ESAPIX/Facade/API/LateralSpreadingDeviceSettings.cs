#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class LateralSpreadingDeviceSettings : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public LateralSpreadingDeviceSettings()
        {
            _client = new ExpandoObject();
        }

        public LateralSpreadingDeviceSettings(dynamic client)
        {
            _client = client;
        }

        public double IsocenterToLateralSpreadingDeviceDistance
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsocenterToLateralSpreadingDeviceDistance"))
                        return _client.IsocenterToLateralSpreadingDeviceDistance;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            return _client.IsocenterToLateralSpreadingDeviceDistance;
                        }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsocenterToLateralSpreadingDeviceDistance = value;
            }
        }

        public string LateralSpreadingDeviceSetting
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("LateralSpreadingDeviceSetting"))
                        return _client.LateralSpreadingDeviceSetting;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.LateralSpreadingDeviceSetting; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.LateralSpreadingDeviceSetting = value;
            }
        }

        public double LateralSpreadingDeviceWaterEquivalentThickness
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("LateralSpreadingDeviceWaterEquivalentThickness"))
                        return _client.LateralSpreadingDeviceWaterEquivalentThickness;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            return _client.LateralSpreadingDeviceWaterEquivalentThickness;
                        }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.LateralSpreadingDeviceWaterEquivalentThickness = value;
            }
        }

        public LateralSpreadingDevice ReferencedLateralSpreadingDevice
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ReferencedLateralSpreadingDevice"))
                        return _client.ReferencedLateralSpreadingDevice;
                    else
                        return default(LateralSpreadingDevice);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.ReferencedLateralSpreadingDevice != null)
                                return new LateralSpreadingDevice(_client.ReferencedLateralSpreadingDevice);
                            return null;
                        }
                    );
                return default(LateralSpreadingDevice);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.ReferencedLateralSpreadingDevice = value;
                }
            }
        }
    }
}