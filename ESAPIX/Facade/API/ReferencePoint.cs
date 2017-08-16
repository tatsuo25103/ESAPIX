#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class ReferencePoint : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public ReferencePoint()
        {
            _client = new ExpandoObject();
        }

        public ReferencePoint(dynamic client)
        {
            _client = client;
        }

        public DoseValue DailyDoseLimit
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("DailyDoseLimit"))
                        return _client.DailyDoseLimit;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.DailyDoseLimit; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.DailyDoseLimit = value;
            }
        }

        public string PatientVolumeId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PatientVolumeId"))
                        return _client.PatientVolumeId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PatientVolumeId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PatientVolumeId = value;
            }
        }

        public DoseValue SessionDoseLimit
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("SessionDoseLimit"))
                        return _client.SessionDoseLimit;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.SessionDoseLimit; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.SessionDoseLimit = value;
            }
        }

        public DoseValue TotalDoseLimit
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TotalDoseLimit"))
                        return _client.TotalDoseLimit;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TotalDoseLimit; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TotalDoseLimit = value;
            }
        }

        public VVector GetReferencePointLocation(PlanSetup planSetup)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.GetReferencePointLocation(planSetup._client);
                    }
                );
                return vmsResult;
            }
            return (VVector) _client.GetReferencePointLocation(planSetup);
        }

        public bool HasLocation(PlanSetup planSetup)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(
                    sc => { return _client.HasLocation(planSetup._client); }
                );
                return vmsResult;
            }
            return (bool) _client.HasLocation(planSetup);
        }
    }
}