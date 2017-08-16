#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class ProtocolPhasePrescription : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public ProtocolPhasePrescription()
        {
            _client = new ExpandoObject();
        }

        public ProtocolPhasePrescription(dynamic client)
        {
            _client = client;
        }

        public DoseValue TargetTotalDose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TargetTotalDose"))
                        return _client.TargetTotalDose;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TargetTotalDose; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TargetTotalDose = value;
            }
        }

        public DoseValue TargetFractionDose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TargetFractionDose"))
                        return _client.TargetFractionDose;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TargetFractionDose; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TargetFractionDose = value;
            }
        }

        public DoseValue ActualTotalDose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ActualTotalDose"))
                        return _client.ActualTotalDose;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ActualTotalDose; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ActualTotalDose = value;
            }
        }

        public bool? TargetIsMet
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TargetIsMet"))
                        return _client.TargetIsMet;
                    else
                        return default(bool?);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TargetIsMet; }
                    );
                return default(bool?);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TargetIsMet = value;
            }
        }

        public PrescriptionModifier PrescModifier
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PrescModifier"))
                        return _client.PrescModifier;
                    else
                        return default(PrescriptionModifier);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PrescModifier; }
                    );
                return default(PrescriptionModifier);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PrescModifier = value;
            }
        }

        public double PrescParameter
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PrescParameter"))
                        return _client.PrescParameter;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PrescParameter; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PrescParameter = value;
            }
        }

        public PrescriptionType PrescType
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PrescType"))
                        return _client.PrescType;
                    else
                        return default(PrescriptionType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PrescType; }
                    );
                return default(PrescriptionType);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PrescType = value;
            }
        }

        public string StructureId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StructureId"))
                        return _client.StructureId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StructureId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.StructureId = value;
                }
            }
        }
    }
}