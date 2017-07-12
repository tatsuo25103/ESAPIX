using System;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;
using Types = VMS.TPS.Common.Model.Types;

namespace ESAPIX.Facade.API
{
    public class SerializableObject : System.Xml.Serialization.IXmlSerializable
    {
        internal dynamic _client;
        public bool IsLive
        {
            get
            {
                return !DefaultHelper.IsDefault(_client) && !(_client is ExpandoObject);
            }
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetSchema();
                }

                ));
                return vmsResult;
            }
            else
            {
                return (System.Xml.Schema.XmlSchema)(_client.GetSchema());
            }
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                XC.Instance.CurrentContext.Thread.Invoke(() =>
                {
                    _client.ReadXml(reader);
                }

                );
            }
            else
            {
                _client.ReadXml(reader);
            }
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                XC.Instance.CurrentContext.Thread.Invoke(() =>
                {
                    _client.WriteXml(writer);
                }

                );
            }
            else
            {
                _client.WriteXml(writer);
            }
        }

        public static void ClearSerializationHistory()
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                XC.Instance.CurrentContext.Thread.Invoke(() =>
                {
                    StaticHelper.SerializableObject_ClearSerializationHistory();
                }

                );
            }
            else
            {
                throw new Exception("Cannot connect to VMS system. Static methods will not work without an active connection");
            }
        }

        public SerializableObject()
        {
            _client = (new ExpandoObject());
        }

        public SerializableObject(dynamic client)
        {
            _client = (client);
        }
    }
}