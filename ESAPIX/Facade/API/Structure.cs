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
    public class Structure : ESAPIX.Facade.API.ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public System.Boolean IsEmpty
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("IsEmpty"))
                    {
                        return _client.IsEmpty;
                    }
                    else
                    {
                        return default (System.Boolean);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.IsEmpty;
                    }

                    );
                }
                else
                {
                    return default (System.Boolean);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.IsEmpty = (value);
                }
                else
                {
                }
            }
        }

        public System.Boolean HasSegment
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("HasSegment"))
                    {
                        return _client.HasSegment;
                    }
                    else
                    {
                        return default (System.Boolean);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.HasSegment;
                    }

                    );
                }
                else
                {
                    return default (System.Boolean);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.HasSegment = (value);
                }
                else
                {
                }
            }
        }

        public System.Windows.Media.Color Color
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Color"))
                    {
                        return _client.Color;
                    }
                    else
                    {
                        return default (System.Windows.Media.Color);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.Color;
                    }

                    );
                }
                else
                {
                    return default (System.Windows.Media.Color);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.Color = (value);
                }
                else
                {
                }
            }
        }

        public System.String DicomType
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("DicomType"))
                    {
                        return _client.DicomType;
                    }
                    else
                    {
                        return default (System.String);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.DicomType;
                    }

                    );
                }
                else
                {
                    return default (System.String);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.DicomType = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector CenterPoint
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("CenterPoint"))
                    {
                        return _client.CenterPoint;
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
                        return _client.CenterPoint;
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
                    _client.CenterPoint = (value);
                }
                else
                {
                }
            }
        }

        public System.Double Volume
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Volume"))
                    {
                        return _client.Volume;
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
                        return _client.Volume;
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
                    _client.Volume = (value);
                }
                else
                {
                }
            }
        }

        public System.Windows.Media.Media3D.MeshGeometry3D MeshGeometry
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("MeshGeometry"))
                    {
                        return _client.MeshGeometry;
                    }
                    else
                    {
                        return default (System.Windows.Media.Media3D.MeshGeometry3D);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    var mesh = (new MeshGeometry3D());
                    var points = (new Point3D[]{});
                    var normals = (new Vector3D[]{});
                    var indices = (new Int32[]{});
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                    {
                        points = (new Point3D[_client.MeshGeometry.Positions.Count]);
                        normals = (new Vector3D[_client.MeshGeometry.Normals.Count]);
                        indices = (new Int32[_client.MeshGeometry.Normals.Count]);
                        _client.MeshGeometry.Positions.CopyTo(points, 0);
                        _client.MeshGeometry.Normals.CopyTo(normals, 0);
                        _client.MeshGeometry.TriangleIndices.CopyTo(indices, 0);
                    }

                    );
                    mesh.Positions = (new Point3DCollection(points));
                    mesh.Normals = (new Vector3DCollection(normals));
                    mesh.TriangleIndices = (new Int32Collection(indices));
                    return mesh;
                }
                else
                {
                    return default (System.Windows.Media.Media3D.MeshGeometry3D);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.MeshGeometry = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector[][] GetContoursOnImagePlane(System.Int32 z)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetContoursOnImagePlane(z);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (VMS.TPS.Common.Model.Types.VVector[][])(_client.GetContoursOnImagePlane(z));
            }
        }

        public System.Boolean GetAssignedHU(out System.Double huValue)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var huValue_OUT = (default (System.Double));
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetAssignedHU(out huValue_OUT);
                }

                ));
                huValue = (huValue_OUT);
                return vmsResult;
            }
            else
            {
                return (System.Boolean)(_client.GetAssignedHU(out huValue));
            }
        }

        public System.Boolean IsPointInsideSegment(VMS.TPS.Common.Model.Types.VVector point)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.IsPointInsideSegment(point);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (System.Boolean)(_client.IsPointInsideSegment(point));
            }
        }

        public VMS.TPS.Common.Model.Types.SegmentProfile GetSegmentProfile(VMS.TPS.Common.Model.Types.VVector start, VMS.TPS.Common.Model.Types.VVector stop, System.Collections.BitArray preallocatedBuffer)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetSegmentProfile(start, stop, preallocatedBuffer);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (VMS.TPS.Common.Model.Types.SegmentProfile)(_client.GetSegmentProfile(start, stop, preallocatedBuffer));
            }
        }

        public System.Int32 GetNumberOfSeparateParts()
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetNumberOfSeparateParts();
                }

                ));
                return vmsResult;
            }
            else
            {
                return (System.Int32)(_client.GetNumberOfSeparateParts());
            }
        }

        public Structure()
        {
            _client = (new ExpandoObject());
        }

        public Structure(dynamic client)
        {
            _client = (client);
        }
    }
}