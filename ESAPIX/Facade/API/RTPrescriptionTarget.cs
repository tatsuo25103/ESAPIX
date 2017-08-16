#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class RTPrescriptionTarget : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public RTPrescriptionTarget()
        {
            _client = new ExpandoObject();
        }

        public RTPrescriptionTarget(dynamic client)
        {
            _client = client;
        }

        public DoseValue DosePerFraction
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("DosePerFraction"))
                        return _client.DosePerFraction;
                    else
                        return default(DoseValue);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.DosePerFraction; }
                    );
                return default(DoseValue);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.DosePerFraction = value;
            }
        }

        public int NumberOfFractions
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("NumberOfFractions"))
                        return _client.NumberOfFractions;
                    else
                        return default(int);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.NumberOfFractions; }
                    );
                return default(int);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.NumberOfFractions = value;
            }
        }

        public string TargetId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TargetId"))
                        return _client.TargetId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TargetId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TargetId = value;
            }
        }

        public RTPrescriptionTargetType Type
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Type"))
                        return _client.Type;
                    else
                        return default(RTPrescriptionTargetType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Type; }
                    );
                return default(RTPrescriptionTargetType);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Type = value;
            }
        }

        public double Value
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Value"))
                        return _client.Value;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Value; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.Value = value;
                }
            }
        }
    }
}