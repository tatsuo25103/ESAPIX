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
    public class Dose : ESAPIX.Facade.API.ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public IEnumerable<ESAPIX.Facade.API.Isodose> Isodoses
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("Isodoses"))
                    {
                        foreach (var item in _client.Isodoses)
                        {
                            yield return item;
                        }
                    }
                    else
                    {
                        yield break;
                    }
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                    {
                        var asEnum = (IEnumerable)_client.Isodoses;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.Isodose();
                        XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var vms = enumerator.Current;
                            if (vms != null)
                            {
                                facade._client = vms;
                            }
                        }

                        );
                        if (facade._client != null)
                        {
                            yield return facade;
                        }
                    }
                }
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.Isodoses = value;
            }
        }

        public VMS.TPS.Common.Model.Types.DoseValue DoseMax3D
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("DoseMax3D"))
                    {
                        return _client.DoseMax3D;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.DoseValue);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.DoseMax3D;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.DoseValue);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.DoseMax3D = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector DoseMax3DLocation
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("DoseMax3DLocation"))
                    {
                        return _client.DoseMax3DLocation;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.VVector);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.DoseMax3DLocation;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.VVector);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.DoseMax3DLocation = (value);
                }
                else
                {
                }
            }
        }

        public System.Int32 XSize
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("XSize"))
                    {
                        return _client.XSize;
                    }
                    else
                    {
                        return default (System.Int32);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.XSize;
                    }

                    );
                }
                else
                {
                    return default (System.Int32);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.XSize = (value);
                }
                else
                {
                }
            }
        }

        public System.Int32 YSize
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("YSize"))
                    {
                        return _client.YSize;
                    }
                    else
                    {
                        return default (System.Int32);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.YSize;
                    }

                    );
                }
                else
                {
                    return default (System.Int32);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.YSize = (value);
                }
                else
                {
                }
            }
        }

        public System.Int32 ZSize
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ZSize"))
                    {
                        return _client.ZSize;
                    }
                    else
                    {
                        return default (System.Int32);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.ZSize;
                    }

                    );
                }
                else
                {
                    return default (System.Int32);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ZSize = (value);
                }
                else
                {
                }
            }
        }

        public System.Double XRes
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("XRes"))
                    {
                        return _client.XRes;
                    }
                    else
                    {
                        return default (System.Double);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.XRes;
                    }

                    );
                }
                else
                {
                    return default (System.Double);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.XRes = (value);
                }
                else
                {
                }
            }
        }

        public System.Double YRes
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("YRes"))
                    {
                        return _client.YRes;
                    }
                    else
                    {
                        return default (System.Double);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.YRes;
                    }

                    );
                }
                else
                {
                    return default (System.Double);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.YRes = (value);
                }
                else
                {
                }
            }
        }

        public System.Double ZRes
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ZRes"))
                    {
                        return _client.ZRes;
                    }
                    else
                    {
                        return default (System.Double);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.ZRes;
                    }

                    );
                }
                else
                {
                    return default (System.Double);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ZRes = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector Origin
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Origin"))
                    {
                        return _client.Origin;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.VVector);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.Origin;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.VVector);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.Origin = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector XDirection
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("XDirection"))
                    {
                        return _client.XDirection;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.VVector);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.XDirection;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.VVector);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.XDirection = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector YDirection
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("YDirection"))
                    {
                        return _client.YDirection;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.VVector);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.YDirection;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.VVector);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.YDirection = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector ZDirection
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ZDirection"))
                    {
                        return _client.ZDirection;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.VVector);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.ZDirection;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.VVector);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ZDirection = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.DoseValue GetDoseToPoint(VMS.TPS.Common.Model.Types.VVector at)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetDoseToPoint(at);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (VMS.TPS.Common.Model.Types.DoseValue)(_client.GetDoseToPoint(at));
            }
        }

        public VMS.TPS.Common.Model.Types.DoseProfile GetDoseProfile(VMS.TPS.Common.Model.Types.VVector start, VMS.TPS.Common.Model.Types.VVector stop, System.Double[] preallocatedBuffer)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetDoseProfile(start, stop, preallocatedBuffer);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (VMS.TPS.Common.Model.Types.DoseProfile)(_client.GetDoseProfile(start, stop, preallocatedBuffer));
            }
        }

        public void GetVoxels(System.Int32 planeIndex, System.Int32[,] preallocatedBuffer)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                XC.Instance.CurrentContext.Thread.Invoke(() =>
                {
                    _client.GetVoxels(planeIndex, preallocatedBuffer);
                }

                );
            }
            else
            {
                _client.GetVoxels(planeIndex, preallocatedBuffer);
            }
        }

        public VMS.TPS.Common.Model.Types.DoseValue VoxelToDoseValue(System.Int32 voxelValue)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.VoxelToDoseValue(voxelValue);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (VMS.TPS.Common.Model.Types.DoseValue)(_client.VoxelToDoseValue(voxelValue));
            }
        }

        public Dose()
        {
            _client = (new ExpandoObject());
        }

        public Dose(dynamic client)
        {
            _client = (client);
        }
    }
}