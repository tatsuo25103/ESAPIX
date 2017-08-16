#region

using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class IonControlPointPair
    {
        internal dynamic _client;

        public IonControlPointPair()
        {
            _client = new ExpandoObject();
        }

        public IonControlPointPair(dynamic client)
        {
            _client = client;
        }

        public bool IsLive
        {
            get { return !DefaultHelper.IsDefault(_client) && !(_client is ExpandoObject); }
        }

        public IonControlPointParameters EndControlPoint
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("EndControlPoint"))
                        return _client.EndControlPoint;
                    else
                        return default(IonControlPointParameters);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.EndControlPoint != null)
                                return new IonControlPointParameters(_client.EndControlPoint);
                            return null;
                        }
                    );
                return default(IonControlPointParameters);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.EndControlPoint = value;
            }
        }

        public IonSpotParametersCollection FinalSpotList
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("FinalSpotList"))
                        return _client.FinalSpotList;
                    else
                        return default(IonSpotParametersCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.FinalSpotList != null)
                                return new IonSpotParametersCollection(_client.FinalSpotList);
                            return null;
                        }
                    );
                return default(IonSpotParametersCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.FinalSpotList = value;
            }
        }

        public double NominalBeamEnergy
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("NominalBeamEnergy"))
                        return _client.NominalBeamEnergy;
                    else
                        return default(double);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.NominalBeamEnergy; }
                    );
                return default(double);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.NominalBeamEnergy = value;
            }
        }

        public IonSpotParametersCollection RawSpotList
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("RawSpotList"))
                        return _client.RawSpotList;
                    else
                        return default(IonSpotParametersCollection);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.RawSpotList != null)
                                return new IonSpotParametersCollection(_client.RawSpotList);
                            return null;
                        }
                    );
                return default(IonSpotParametersCollection);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.RawSpotList = value;
            }
        }

        public IonControlPointParameters StartControlPoint
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StartControlPoint"))
                        return _client.StartControlPoint;
                    else
                        return default(IonControlPointParameters);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc =>
                        {
                            if (_client.StartControlPoint != null)
                                return new IonControlPointParameters(_client.StartControlPoint);
                            return null;
                        }
                    );
                return default(IonControlPointParameters);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.StartControlPoint = value;
            }
        }

        public int StartIndex
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("StartIndex"))
                        return _client.StartIndex;
                    else
                        return default(int);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.StartIndex; }
                    );
                return default(int);
            }

            set
            {
                if (_client is ExpandoObject)
                {
                    _client.StartIndex = value;
                }
            }
        }

        public void ResizeFinalSpotList(int count)
        {
            if (XC.Instance.CurrentContext != null)
                XC.Instance.CurrentContext.Thread.Invoke(() => { _client.ResizeFinalSpotList(count); }
                );
            else
                _client.ResizeFinalSpotList(count);
        }

        public void ResizeRawSpotList(int count)
        {
            if (XC.Instance.CurrentContext != null)
                XC.Instance.CurrentContext.Thread.Invoke(() => { _client.ResizeRawSpotList(count); }
                );
            else
                _client.ResizeRawSpotList(count);
        }
    }
}