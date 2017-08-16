#region

using System;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class Registration : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public Registration()
        {
            _client = new ExpandoObject();
        }

        public Registration(dynamic client)
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

        public string RegisteredFOR
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RegisteredFOR"))
                        return _client.RegisteredFOR;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.RegisteredFOR; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RegisteredFOR = value;
            }
        }

        public string SourceFOR
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("SourceFOR"))
                        return _client.SourceFOR;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.SourceFOR; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.SourceFOR = value;
            }
        }

        public RegistrationApprovalStatus Status
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Status"))
                        return _client.Status;
                    else
                        return default(RegistrationApprovalStatus);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.Status; }
                    );
                return default(RegistrationApprovalStatus);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Status = value;
            }
        }

        public DateTime? StatusDateTime
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StatusDateTime"))
                        return _client.StatusDateTime;
                    else
                        return default(DateTime?);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StatusDateTime; }
                    );
                return default(DateTime?);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.StatusDateTime = value;
            }
        }

        public string StatusUserDisplayName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StatusUserDisplayName"))
                        return _client.StatusUserDisplayName;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StatusUserDisplayName; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.StatusUserDisplayName = value;
            }
        }

        public string StatusUserName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StatusUserName"))
                        return _client.StatusUserName;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StatusUserName; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.StatusUserName = value;
            }
        }

        public double[,] TransformationMatrix
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("TransformationMatrix"))
                        return _client.TransformationMatrix;
                    else
                        return default(double[,]);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.TransformationMatrix; }
                    );
                return default(double[,]);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.TransformationMatrix = value;
            }
        }

        public string UID
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("UID"))
                        return _client.UID;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.UID; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.UID = value;
            }
        }

        public VVector InverseTransformPoint(VVector pt)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc => { return _client.InverseTransformPoint(pt); }
                );
                return vmsResult;
            }
            return (VVector) _client.InverseTransformPoint(pt);
        }

        public VVector TransformPoint(VVector pt)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc => { return _client.TransformPoint(pt); }
                );
                return vmsResult;
            }
            return (VVector) _client.TransformPoint(pt);
        }
    }
}