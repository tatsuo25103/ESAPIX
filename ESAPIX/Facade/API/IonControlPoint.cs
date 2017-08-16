#region

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonControlPoint : ControlPoint, System.Xml.Serialization.IXmlSerializable
    {
        public IonControlPoint()
        {
            _client = new ExpandoObject();
        }

        public IonControlPoint(dynamic client)
        {
            _client = client;
        }

        public IonSpotCollection FinalSpotList
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("FinalSpotList"))
                        return _client.FinalSpotList;
                    else
                        return default(IonSpotCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.FinalSpotList != null)
                                return new IonSpotCollection(_client.FinalSpotList);
                            return null;
                        }
                    );
                return default(IonSpotCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.FinalSpotList = value;
            }
        }

        public IEnumerable<LateralSpreadingDeviceSettings> LateralSpreadingDeviceSettings
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("LateralSpreadingDeviceSettings"))
                        foreach (var item in _client.LateralSpreadingDeviceSettings)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.LateralSpreadingDeviceSettings;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new LateralSpreadingDeviceSettings();
                        XC.Instance.CurrentContext.Thread.Invoke(() =>
                            {
                                var vms = enumerator.Current;
                                if (vms != null)
                                    facade._client = vms;
                            }
                        );
                        if (facade._client != null)
                            yield return facade;
                    }
                }
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.LateralSpreadingDeviceSettings = value;
            }
        }

        public double NominalBeamEnergy
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("NominalBeamEnergy"))
                        return _client.NominalBeamEnergy;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.NominalBeamEnergy; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.NominalBeamEnergy = value;
            }
        }

        public int NumberOfPaintings
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("NumberOfPaintings"))
                        return _client.NumberOfPaintings;
                    else
                        return default(int);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.NumberOfPaintings; }
                    );
                return default(int);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.NumberOfPaintings = value;
            }
        }

        public IEnumerable<RangeModulatorSettings> RangeModulatorSettings
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("RangeModulatorSettings"))
                        foreach (var item in _client.RangeModulatorSettings)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.RangeModulatorSettings;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new RangeModulatorSettings();
                        XC.Instance.CurrentContext.Thread.Invoke(() =>
                            {
                                var vms = enumerator.Current;
                                if (vms != null)
                                    facade._client = vms;
                            }
                        );
                        if (facade._client != null)
                            yield return facade;
                    }
                }
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeModulatorSettings = value;
            }
        }

        public IEnumerable<RangeShifterSettings> RangeShifterSettings
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("RangeShifterSettings"))
                        foreach (var item in _client.RangeShifterSettings)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.RangeShifterSettings;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new RangeShifterSettings();
                        XC.Instance.CurrentContext.Thread.Invoke(() =>
                            {
                                var vms = enumerator.Current;
                                if (vms != null)
                                    facade._client = vms;
                            }
                        );
                        if (facade._client != null)
                            yield return facade;
                    }
                }
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RangeShifterSettings = value;
            }
        }

        public IonSpotCollection RawSpotList
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RawSpotList"))
                        return _client.RawSpotList;
                    else
                        return default(IonSpotCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.RawSpotList != null)
                                return new IonSpotCollection(_client.RawSpotList);
                            return null;
                        }
                    );
                return default(IonSpotCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RawSpotList = value;
            }
        }

        public double ScanningSpotSizeX
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ScanningSpotSizeX"))
                        return _client.ScanningSpotSizeX;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ScanningSpotSizeX; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ScanningSpotSizeX = value;
            }
        }

        public double ScanningSpotSizeY
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ScanningSpotSizeY"))
                        return _client.ScanningSpotSizeY;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ScanningSpotSizeY; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ScanningSpotSizeY = value;
            }
        }

        public string ScanSpotTuneId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ScanSpotTuneId"))
                        return _client.ScanSpotTuneId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ScanSpotTuneId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ScanSpotTuneId = value;
            }
        }

        public double SnoutPosition
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("SnoutPosition"))
                        return _client.SnoutPosition;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.SnoutPosition; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.SnoutPosition = value;
            }
        }
    }
}