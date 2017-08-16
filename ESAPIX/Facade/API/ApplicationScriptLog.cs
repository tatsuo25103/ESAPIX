#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class ApplicationScriptLog : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public ApplicationScriptLog()
        {
            _client = new ExpandoObject();
        }

        public ApplicationScriptLog(dynamic client)
        {
            _client = client;
        }

        public string CourseId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("CourseId"))
                        return _client.CourseId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.CourseId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.CourseId = value;
            }
        }

        public string PatientId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PatientId"))
                        return _client.PatientId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PatientId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PatientId = value;
            }
        }

        public string PlanSetupId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PlanSetupId"))
                        return _client.PlanSetupId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PlanSetupId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PlanSetupId = value;
            }
        }

        public string PlanUID
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PlanUID"))
                        return _client.PlanUID;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PlanUID; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PlanUID = value;
            }
        }

        public ApplicationScript Script
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Script"))
                        return _client.Script;
                    else
                        return default(ApplicationScript);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.Script != null)
                                return new ApplicationScript(_client.Script);
                            return null;
                        }
                    );
                return default(ApplicationScript);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Script = value;
            }
        }

        public string ScriptFullName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ScriptFullName"))
                        return _client.ScriptFullName;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ScriptFullName; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ScriptFullName = value;
            }
        }

        public string StructureSetId
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StructureSetId"))
                        return _client.StructureSetId;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StructureSetId; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.StructureSetId = value;
            }
        }

        public string StructureSetUID
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StructureSetUID"))
                        return _client.StructureSetUID;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StructureSetUID; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.StructureSetUID = value;
                }
            }
        }
    }
}