#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class BrachyFieldReferencePoint : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public BrachyFieldReferencePoint()
        {
            _client = new ExpandoObject();
        }

        public BrachyFieldReferencePoint(dynamic client)
        {
            _client = client;
        }

        public DoseValue FieldDose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("FieldDose"))
                        return _client.FieldDose;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.FieldDose; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.FieldDose = value;
            }
        }

        public bool IsFieldDoseNominal
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsFieldDoseNominal"))
                        return _client.IsFieldDoseNominal;
                    else
                        return default(bool);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsFieldDoseNominal; }
                    );
                return default(bool);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsFieldDoseNominal = value;
            }
        }

        public bool IsPrimaryReferencePoint
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsPrimaryReferencePoint"))
                        return _client.IsPrimaryReferencePoint;
                    else
                        return default(bool);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsPrimaryReferencePoint; }
                    );
                return default(bool);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsPrimaryReferencePoint = value;
            }
        }

        public ReferencePoint ReferencePoint
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ReferencePoint"))
                        return _client.ReferencePoint;
                    else
                        return default(ReferencePoint);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.ReferencePoint != null)
                                return new ReferencePoint(_client.ReferencePoint);
                            return null;
                        }
                    );
                return default(ReferencePoint);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ReferencePoint = value;
            }
        }

        public VVector RefPointLocation
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RefPointLocation"))
                        return _client.RefPointLocation;
                    else
                        return default(VVector);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.RefPointLocation; }
                    );
                return default(VVector);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.RefPointLocation = value;
                }
            }
        }
    }
}