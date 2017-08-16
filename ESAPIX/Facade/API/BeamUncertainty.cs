#region

using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class BeamUncertainty : ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public BeamUncertainty()
        {
            _client = new ExpandoObject();
        }

        public BeamUncertainty(dynamic client)
        {
            _client = client;
        }

        public Beam Beam
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Beam"))
                        return _client.Beam;
                    else
                        return default(Beam);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.Beam != null)
                                return new Beam(_client.Beam);
                            return null;
                        }
                    );
                return default(Beam);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Beam = value;
            }
        }

        public BeamNumber BeamNumber
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("BeamNumber"))
                        return _client.BeamNumber;
                    else
                        return default(BeamNumber);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.BeamNumber; }
                    );
                return default(BeamNumber);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.BeamNumber = value;
            }
        }

        public Dose Dose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("Dose"))
                        return _client.Dose;
                    else
                        return default(Dose);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.Dose != null)
                                return new Dose(_client.Dose);
                            return null;
                        }
                    );
                return default(Dose);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.Dose = value;
                }
            }
        }
    }
}