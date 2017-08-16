#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class PlanningItem : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public PlanningItem()
        {
            _client = new ExpandoObject();
        }

        public PlanningItem(dynamic client)
        {
            _client = client;
        }

        public DateTime? CreationDateTime
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("CreationDateTime"))
                        return _client.CreationDateTime;
                    else
                        return default(DateTime?);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.CreationDateTime; }
                    );
                return default(DateTime?);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.CreationDateTime = value;
            }
        }

        public PlanningItemDose Dose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Dose"))
                        return _client.Dose;
                    else
                        return default(PlanningItemDose);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.Dose != null)
                                return new PlanningItemDose(_client.Dose);
                            return null;
                        }
                    );
                return default(PlanningItemDose);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Dose = value;
            }
        }

        public DoseValuePresentation DoseValuePresentation
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("DoseValuePresentation"))
                        return _client.DoseValuePresentation;
                    else
                        return default(DoseValuePresentation);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.DoseValuePresentation; }
                    );
                return default(DoseValuePresentation);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.DoseValuePresentation = value;
            }
        }

        public IEnumerable<Structure> StructuresSelectedForDvh
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("StructuresSelectedForDvh"))
                        foreach (var item in _client.StructuresSelectedForDvh)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.StructuresSelectedForDvh;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new Structure();
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
                    _client.StructuresSelectedForDvh = value;
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

        public DoseValue GetDoseAtVolume(Structure structure, double volume, VolumePresentation volumePresentation,
            DoseValuePresentation requestedDosePresentation)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.GetDoseAtVolume(structure._client, volume, volumePresentation,
                            requestedDosePresentation);
                    }
                );
                return vmsResult;
            }
            return (DoseValue) _client.GetDoseAtVolume(structure, volume, volumePresentation,
                requestedDosePresentation);
        }

        public double GetVolumeAtDose(Structure structure, DoseValue dose,
            VolumePresentation requestedVolumePresentation)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.GetVolumeAtDose(structure._client, dose, requestedVolumePresentation);
                    }
                );
                return vmsResult;
            }
            return (double) _client.GetVolumeAtDose(structure, dose, requestedVolumePresentation);
        }
    }
}