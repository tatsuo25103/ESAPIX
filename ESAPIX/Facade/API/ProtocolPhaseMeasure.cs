#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class ProtocolPhaseMeasure : SerializableObject, System.Xml.Serialization.IXmlSerializable
    {
        public ProtocolPhaseMeasure()
        {
            _client = new ExpandoObject();
        }

        public ProtocolPhaseMeasure(dynamic client)
        {
            _client = client;
        }

        public double TargetValue
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TargetValue"))
                        return _client.TargetValue;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TargetValue; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TargetValue = value;
            }
        }

        public double ActualValue
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ActualValue"))
                        return _client.ActualValue;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ActualValue; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ActualValue = value;
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

        public MeasureModifier Modifier
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Modifier"))
                        return _client.Modifier;
                    else
                        return default(MeasureModifier);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Modifier; }
                    );
                return default(MeasureModifier);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Modifier = value;
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
                    _client.StructureId = value;
            }
        }

        public MeasureType Type
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Type"))
                        return _client.Type;
                    else
                        return default(MeasureType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Type; }
                    );
                return default(MeasureType);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Type = value;
            }
        }

        public string TypeText
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TypeText"))
                        return _client.TypeText;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TypeText; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.TypeText = value;
                }
            }
        }
    }
}