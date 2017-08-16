#region

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonBeam : Beam, System.Xml.Serialization.IXmlSerializable
    {
        public IonBeam()
        {
            _client = new ExpandoObject();
        }

        public IonBeam(dynamic client)
        {
            _client = client;
        }

        public double AirGap
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("AirGap"))
                        return _client.AirGap;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.AirGap; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.AirGap = value;
            }
        }

        public double DistalTargetMargin
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("DistalTargetMargin"))
                        return _client.DistalTargetMargin;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.DistalTargetMargin; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.DistalTargetMargin = value;
            }
        }

        public VRect<double> LateralMargins
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("LateralMargins"))
                        return _client.LateralMargins;
                    else
                        return default(VRect<double>);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.LateralMargins; }
                    );
                return default(VRect<double>);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.LateralMargins = value;
            }
        }

        public IEnumerable<LateralSpreadingDevice> LateralSpreadingDevices
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("LateralSpreadingDevices"))
                        foreach (var item in _client.LateralSpreadingDevices)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.LateralSpreadingDevices;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new LateralSpreadingDevice();
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
                    _client.LateralSpreadingDevices = value;
            }
        }

        public double NominalRange
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("NominalRange"))
                        return _client.NominalRange;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.NominalRange; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.NominalRange = value;
            }
        }

        public double NominalSOBPWidth
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("NominalSOBPWidth"))
                        return _client.NominalSOBPWidth;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.NominalSOBPWidth; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.NominalSOBPWidth = value;
            }
        }

        public string OptionId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("OptionId"))
                        return _client.OptionId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.OptionId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.OptionId = value;
            }
        }

        public string PatientSupportId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PatientSupportId"))
                        return _client.PatientSupportId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PatientSupportId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PatientSupportId = value;
            }
        }

        public PatientSupportType PatientSupportType
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PatientSupportType"))
                        return _client.PatientSupportType;
                    else
                        return default(PatientSupportType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PatientSupportType; }
                    );
                return default(PatientSupportType);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PatientSupportType = value;
            }
        }

        public IonControlPointCollection IonControlPoints
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IonControlPoints"))
                        return _client.IonControlPoints;
                    else
                        return default(IonControlPointCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.IonControlPoints != null)
                                return new IonControlPointCollection(_client.IonControlPoints);
                            return null;
                        }
                    );
                return default(IonControlPointCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IonControlPoints = value;
            }
        }

        public double ProximalTargetMargin
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ProximalTargetMargin"))
                        return _client.ProximalTargetMargin;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ProximalTargetMargin; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ProximalTargetMargin = value;
            }
        }

        public IEnumerable<RangeModulator> RangeModulators
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("RangeModulators"))
                        foreach (var item in _client.RangeModulators)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.RangeModulators;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new RangeModulator();
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
                    _client.RangeModulators = value;
            }
        }

        public IEnumerable<RangeShifter> RangeShifters
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("RangeShifters"))
                        foreach (var item in _client.RangeShifters)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.RangeShifters;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new RangeShifter();
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
                    _client.RangeShifters = value;
            }
        }

        public IonBeamScanMode ScanMode
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ScanMode"))
                        return _client.ScanMode;
                    else
                        return default(IonBeamScanMode);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ScanMode; }
                    );
                return default(IonBeamScanMode);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ScanMode = value;
            }
        }

        public string SnoutId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("SnoutId"))
                        return _client.SnoutId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.SnoutId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.SnoutId = value;
            }
        }

        public Structure TargetStructure
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TargetStructure"))
                        return _client.TargetStructure;
                    else
                        return default(Structure);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.TargetStructure != null)
                                return new Structure(_client.TargetStructure);
                            return null;
                        }
                    );
                return default(Structure);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TargetStructure = value;
            }
        }

        public double VirtualSADX
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("VirtualSADX"))
                        return _client.VirtualSADX;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.VirtualSADX; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.VirtualSADX = value;
            }
        }

        public double VirtualSADY
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("VirtualSADY"))
                        return _client.VirtualSADY;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.VirtualSADY; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.VirtualSADY = value;
            }
        }

        public IonBeamParameters GetEditableParameters()
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return new IonBeamParameters(_client.GetEditableParameters());
                    }
                );
                return vmsResult;
            }
            return _client.GetEditableParameters();
        }
    }
}