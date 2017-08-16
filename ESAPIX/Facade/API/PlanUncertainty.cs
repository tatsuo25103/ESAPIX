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
    public class PlanUncertainty : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public PlanUncertainty()
        {
            _client = new ExpandoObject();
        }

        public PlanUncertainty(dynamic client)
        {
            _client = client;
        }

        public IEnumerable<BeamUncertainty> BeamUncertainties
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("BeamUncertainties"))
                        foreach (var item in _client.BeamUncertainties)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.BeamUncertainties;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new BeamUncertainty();
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
                    _client.BeamUncertainties = value;
            }
        }

        public double CalibrationCurveError
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("CalibrationCurveError"))
                        return _client.CalibrationCurveError;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.CalibrationCurveError; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.CalibrationCurveError = value;
            }
        }

        public string DisplayName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("DisplayName"))
                        return _client.DisplayName;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.DisplayName; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.DisplayName = value;
            }
        }

        public Dose Dose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Dose"))
                        return _client.Dose;
                    else
                        return default(Dose);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.Dose != null)
                                return new Dose(_client.Dose);
                            return null;
                        }
                    );
                return default(Dose);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Dose = value;
            }
        }

        public VVector IsocenterShift
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsocenterShift"))
                        return _client.IsocenterShift;
                    else
                        return default(VVector);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsocenterShift; }
                    );
                return default(VVector);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsocenterShift = value;
            }
        }

        public PlanUncertaintyType UncertaintyType
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("UncertaintyType"))
                        return _client.UncertaintyType;
                    else
                        return default(PlanUncertaintyType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.UncertaintyType; }
                    );
                return default(PlanUncertaintyType);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.UncertaintyType = value;
            }
        }

        public DVHData GetDVHCumulativeData(Structure structure, DoseValuePresentation dosePresentation,
            VolumePresentation volumePresentation, double binWidth)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return new DVHData(_client.GetDVHCumulativeData(structure._client, dosePresentation,
                            volumePresentation, binWidth));
                    }
                );
                return vmsResult;
            }
            return _client.GetDVHCumulativeData(structure, dosePresentation, volumePresentation, binWidth);
        }
    }
}