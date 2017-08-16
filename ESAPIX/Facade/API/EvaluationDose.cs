#region

using System.Dynamic;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class EvaluationDose : Dose, System.Xml.Serialization.IXmlSerializable
    {
        public EvaluationDose()
        {
            _client = new ExpandoObject();
        }

        public EvaluationDose(dynamic client)
        {
            _client = client;
        }

        public int DoseValueToVoxel(DoseValue doseValue)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(
                    sc => { return _client.DoseValueToVoxel(doseValue); }
                );
                return vmsResult;
            }
            return (int) _client.DoseValueToVoxel(doseValue);
        }

        public void SetVoxels(int planeIndex, int[,] values)
        {
            if (XC.Instance.CurrentContext != null)
                XC.Instance.CurrentContext.Thread.Invoke(() => { _client.SetVoxels(planeIndex, values); }
                );
            else
                _client.SetVoxels(planeIndex, values);
        }
    }
}