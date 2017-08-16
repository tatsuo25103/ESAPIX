#region

using System.Dynamic;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class BeamDose : Dose, System.Xml.Serialization.IXmlSerializable
    {
        public BeamDose()
        {
            _client = new ExpandoObject();
        }

        public BeamDose(dynamic client)
        {
            _client = client;
        }

        public DoseValue GetAbsoluteBeamDoseValue(DoseValue relative)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(
                    sc => { return _client.GetAbsoluteBeamDoseValue(relative); }
                );
                return vmsResult;
            }
            return (DoseValue) _client.GetAbsoluteBeamDoseValue(relative);
        }
    }
}