#region

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonPlanSetup : PlanSetup, System.Xml.Serialization.IXmlSerializable
    {
        public IonPlanSetup()
        {
            _client = new ExpandoObject();
        }

        public IonPlanSetup(dynamic client)
        {
            _client = client;
        }

        public bool IsPostProcessingNeeded
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IsPostProcessingNeeded"))
                        return _client.IsPostProcessingNeeded;
                    else
                        return default(bool);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.IsPostProcessingNeeded; }
                    );
                return default(bool);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IsPostProcessingNeeded = value;
            }
        }

        public EvaluationDose DoseAsEvaluationDose
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("DoseAsEvaluationDose"))
                        return _client.DoseAsEvaluationDose;
                    else
                        return default(EvaluationDose);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.DoseAsEvaluationDose != null)
                                return new EvaluationDose(_client.DoseAsEvaluationDose);
                            return null;
                        }
                    );
                return default(EvaluationDose);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.DoseAsEvaluationDose = value;
            }
        }

        public IEnumerable<IonBeam> IonBeams
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("IonBeams"))
                        foreach (var item in _client.IonBeams)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.IonBeams;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new IonBeam();
                        XC.Instance.CurrentContext.Thread.Invoke(() =>
                            {
                                var vms = enumerator.Current;
                                if (vms != null)
                                    facade._client = vms;
                            }
                        );
                        if (facade._client != null)
                            yield return facade;
                    }
                }
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IonBeams = value;
            }
        }

        public CalculationResult CalculateDose()
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(
                    sc => { return new CalculationResult(_client.CalculateDose()); }
                );
                return vmsResult;
            }
            return _client.CalculateDose();
        }

        public CalculationResult PostProcessAndCalculateDose()
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return new CalculationResult(_client.PostProcessAndCalculateDose());
                    }
                );
                return vmsResult;
            }
            return _client.PostProcessAndCalculateDose();
        }

        public CalculationResult CalculateDoseWithoutPostProcessing()
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return new CalculationResult(_client.CalculateDoseWithoutPostProcessing());
                    }
                );
                return vmsResult;
            }
            return _client.CalculateDoseWithoutPostProcessing();
        }

        public IEnumerable<string> GetModelsForCalculationType(CalculationType calculationType)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.GetModelsForCalculationType(calculationType);
                    }
                );
                return vmsResult;
            }
            return (IEnumerable<string>) _client.GetModelsForCalculationType(calculationType);
        }

        public EvaluationDose CopyEvaluationDose(Dose existing)
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return new EvaluationDose(_client.CopyEvaluationDose(existing._client));
                    }
                );
                return vmsResult;
            }
            return _client.CopyEvaluationDose(existing);
        }

        public EvaluationDose CreateEvaluationDose()
        {
            if (XC.Instance.CurrentContext != null)
            {
                var vmsResult = XC.Instance.CurrentContext.GetValue(
                    sc => { return new EvaluationDose(_client.CreateEvaluationDose()); }
                );
                return vmsResult;
            }
            return _client.CreateEvaluationDose();
        }
    }
}