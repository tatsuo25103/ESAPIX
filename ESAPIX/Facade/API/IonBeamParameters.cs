#region

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonBeamParameters : BeamParameters
    {
        public IonBeamParameters()
        {
            _client = new ExpandoObject();
        }

        public IonBeamParameters(dynamic client)
        {
            _client = client;
        }

        public IEnumerable<IonControlPointParameters> ControlPoints
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("ControlPoints"))
                        foreach (var item in _client.ControlPoints)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.ControlPoints;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new IonControlPointParameters();
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
                    _client.ControlPoints = value;
            }
        }

        public IonControlPointPairCollection IonControlPointPairs
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("IonControlPointPairs"))
                        return _client.IonControlPointPairs;
                    else
                        return default(IonControlPointPairCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.IonControlPointPairs != null)
                                return new IonControlPointPairCollection(_client.IonControlPointPairs);
                            return null;
                        }
                    );
                return default(IonControlPointPairCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.IonControlPointPairs = value;
            }
        }
    }
}