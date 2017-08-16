#region

using System;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class ApplicationScript : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public ApplicationScript()
        {
            _client = new ExpandoObject();
        }

        public ApplicationScript(dynamic client)
        {
            _client = client;
        }

        public ApplicationScriptApprovalStatus ApprovalStatus
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ApprovalStatus"))
                        return _client.ApprovalStatus;
                    else
                        return default(ApplicationScriptApprovalStatus);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ApprovalStatus; }
                    );
                return default(ApplicationScriptApprovalStatus);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ApprovalStatus = value;
            }
        }

        public string ApprovalStatusDisplayText
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ApprovalStatusDisplayText"))
                        return _client.ApprovalStatusDisplayText;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ApprovalStatusDisplayText; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ApprovalStatusDisplayText = value;
            }
        }

        public System.Reflection.AssemblyName AssemblyName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("AssemblyName"))
                        return _client.AssemblyName;
                    else
                        return default(System.Reflection.AssemblyName);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.AssemblyName; }
                    );
                return default(System.Reflection.AssemblyName);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.AssemblyName = value;
            }
        }

        public DateTime? ExpirationDate
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ExpirationDate"))
                        return _client.ExpirationDate;
                    else
                        return default(DateTime?);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ExpirationDate; }
                    );
                return default(DateTime?);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ExpirationDate = value;
            }
        }

        public bool IsReadOnlyScript
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsReadOnlyScript"))
                        return _client.IsReadOnlyScript;
                    else
                        return default(bool);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsReadOnlyScript; }
                    );
                return default(bool);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsReadOnlyScript = value;
            }
        }

        public bool IsWriteableScript
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsWriteableScript"))
                        return _client.IsWriteableScript;
                    else
                        return default(bool);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsWriteableScript; }
                    );
                return default(bool);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsWriteableScript = value;
            }
        }

        public string PublisherName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("PublisherName"))
                        return _client.PublisherName;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.PublisherName; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.PublisherName = value;
            }
        }

        public ApplicationScriptType ScriptType
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ScriptType"))
                        return _client.ScriptType;
                    else
                        return default(ApplicationScriptType);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ScriptType; }
                    );
                return default(ApplicationScriptType);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ScriptType = value;
            }
        }

        public DateTime? StatusDate
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StatusDate"))
                        return _client.StatusDate;
                    else
                        return default(DateTime?);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StatusDate; }
                    );
                return default(DateTime?);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.StatusDate = value;
            }
        }

        public UserIdentity StatusUserIdentity
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StatusUserIdentity"))
                        return _client.StatusUserIdentity;
                    else
                        return default(UserIdentity);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StatusUserIdentity; }
                    );
                return default(UserIdentity);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.StatusUserIdentity = value;
                }
            }
        }
    }
}