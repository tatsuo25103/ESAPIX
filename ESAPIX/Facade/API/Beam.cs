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
    public class Beam : ESAPIX.Facade.API.ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public System.Nullable<System.DateTime> CreationDateTime
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("CreationDateTime"))
                    {
                        return _client.CreationDateTime;
                    }
                    else
                    {
                        return default (System.Nullable<System.DateTime>);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.CreationDateTime;
                    }

                    );
                }
                else
                {
                    return default (System.Nullable<System.DateTime>);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.CreationDateTime = (value);
                }
                else
                {
                }
            }
        }

        public System.Boolean IsSetupField
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("IsSetupField"))
                    {
                        return _client.IsSetupField;
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
                        return _client.IsSetupField;
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
                    _client.IsSetupField = (value);
                }
                else
                {
                }
            }
        }

        public ESAPIX.Facade.API.ExternalBeam ExternalBeam
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ExternalBeam"))
                    {
                        return _client.ExternalBeam;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.ExternalBeam);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.ExternalBeam) != (null))
                        {
                            return new ESAPIX.Facade.API.ExternalBeam(_client.ExternalBeam);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.ExternalBeam);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ExternalBeam = (value);
                }
                else
                {
                }
            }
        }

        public System.String EnergyModeDisplayName
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("EnergyModeDisplayName"))
                    {
                        return _client.EnergyModeDisplayName;
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
                        return _client.EnergyModeDisplayName;
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
                    _client.EnergyModeDisplayName = (value);
                }
                else
                {
                }
            }
        }

        public System.Int32 DoseRate
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("DoseRate"))
                    {
                        return _client.DoseRate;
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
                        return _client.DoseRate;
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
                    _client.DoseRate = (value);
                }
                else
                {
                }
            }
        }

        public ESAPIX.Facade.API.Technique Technique
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Technique"))
                    {
                        return _client.Technique;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.Technique);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.Technique) != (null))
                        {
                            return new ESAPIX.Facade.API.Technique(_client.Technique);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.Technique);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.Technique = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.SetupTechnique SetupTechnique
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("SetupTechnique"))
                    {
                        return _client.SetupTechnique;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.SetupTechnique);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.SetupTechnique;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.SetupTechnique);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.SetupTechnique = (value);
                }
                else
                {
                }
            }
        }

        public System.Double ArcLength
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ArcLength"))
                    {
                        return _client.ArcLength;
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
                        return _client.ArcLength;
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
                    _client.ArcLength = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.GantryDirection GantryDirection
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("GantryDirection"))
                    {
                        return _client.GantryDirection;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.GantryDirection);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.GantryDirection;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.GantryDirection);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.GantryDirection = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector IsocenterPosition
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("IsocenterPosition"))
                    {
                        return _client.IsocenterPosition;
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
                        return _client.IsocenterPosition;
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
                    _client.IsocenterPosition = (value);
                }
                else
                {
                }
            }
        }

        public IEnumerable<ESAPIX.Facade.API.Wedge> Wedges
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("Wedges"))
                    {
                        foreach (var item in _client.Wedges)
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
                        var asEnum = (IEnumerable)_client.Wedges;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.Wedge();
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
                    _client.Wedges = value;
            }
        }

        public IEnumerable<ESAPIX.Facade.API.Tray> Trays
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("Trays"))
                    {
                        foreach (var item in _client.Trays)
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
                        var asEnum = (IEnumerable)_client.Trays;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.Tray();
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
                    _client.Trays = value;
            }
        }

        public IEnumerable<ESAPIX.Facade.API.Block> Blocks
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("Blocks"))
                    {
                        foreach (var item in _client.Blocks)
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
                        var asEnum = (IEnumerable)_client.Blocks;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.Block();
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
                    _client.Blocks = value;
            }
        }

        public ESAPIX.Facade.API.Compensator Compensator
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Compensator"))
                    {
                        return _client.Compensator;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.Compensator);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.Compensator) != (null))
                        {
                            return new ESAPIX.Facade.API.Compensator(_client.Compensator);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.Compensator);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.Compensator = (value);
                }
                else
                {
                }
            }
        }

        public ESAPIX.Facade.API.MLC MLC
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("MLC"))
                    {
                        return _client.MLC;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.MLC);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.MLC) != (null))
                        {
                            return new ESAPIX.Facade.API.MLC(_client.MLC);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.MLC);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.MLC = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.MLCPlanType MLCPlanType
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("MLCPlanType"))
                    {
                        return _client.MLCPlanType;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.MLCPlanType);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.MLCPlanType;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.MLCPlanType);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.MLCPlanType = (value);
                }
                else
                {
                }
            }
        }

        public System.Double DosimetricLeafGap
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("DosimetricLeafGap"))
                    {
                        return _client.DosimetricLeafGap;
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
                        return _client.DosimetricLeafGap;
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
                    _client.DosimetricLeafGap = (value);
                }
                else
                {
                }
            }
        }

        public System.Double MLCTransmissionFactor
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("MLCTransmissionFactor"))
                    {
                        return _client.MLCTransmissionFactor;
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
                        return _client.MLCTransmissionFactor;
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
                    _client.MLCTransmissionFactor = (value);
                }
                else
                {
                }
            }
        }

        public ESAPIX.Facade.API.ControlPointCollection ControlPoints
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ControlPoints"))
                    {
                        return _client.ControlPoints;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.ControlPointCollection);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.ControlPoints) != (null))
                        {
                            return new ESAPIX.Facade.API.ControlPointCollection(_client.ControlPoints);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.ControlPointCollection);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ControlPoints = (value);
                }
                else
                {
                }
            }
        }

        public IEnumerable<ESAPIX.Facade.API.Bolus> Boluses
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("Boluses"))
                    {
                        foreach (var item in _client.Boluses)
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
                        var asEnum = (IEnumerable)_client.Boluses;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.Bolus();
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
                    _client.Boluses = value;
            }
        }

        public ESAPIX.Facade.API.Applicator Applicator
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Applicator"))
                    {
                        return _client.Applicator;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.Applicator);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.Applicator) != (null))
                        {
                            return new ESAPIX.Facade.API.Applicator(_client.Applicator);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.Applicator);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.Applicator = (value);
                }
                else
                {
                }
            }
        }

        public ESAPIX.Facade.API.Image ReferenceImage
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ReferenceImage"))
                    {
                        return _client.ReferenceImage;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.Image);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        if ((_client.ReferenceImage) != (null))
                        {
                            return new ESAPIX.Facade.API.Image(_client.ReferenceImage);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.Image);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ReferenceImage = (value);
                }
                else
                {
                }
            }
        }

        public System.Double WeightFactor
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("WeightFactor"))
                    {
                        return _client.WeightFactor;
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
                        return _client.WeightFactor;
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
                    _client.WeightFactor = (value);
                }
                else
                {
                }
            }
        }

        public IEnumerable<ESAPIX.Facade.API.BeamCalculationLog> CalculationLogs
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("CalculationLogs"))
                    {
                        foreach (var item in _client.CalculationLogs)
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
                        var asEnum = (IEnumerable)_client.CalculationLogs;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.BeamCalculationLog();
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
                    _client.CalculationLogs = value;
            }
        }

        public VMS.TPS.Common.Model.Types.MetersetValue Meterset
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("Meterset"))
                    {
                        return _client.Meterset;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.MetersetValue);
                    }
                }
                else if ((XC.Instance.CurrentContext) != (null))
                {
                    return XC.Instance.CurrentContext.GetValue(sc =>
                    {
                        return _client.Meterset;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.MetersetValue);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.Meterset = (value);
                }
                else
                {
                }
            }
        }

        public System.Double MetersetPerGy
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("MetersetPerGy"))
                    {
                        return _client.MetersetPerGy;
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
                        return _client.MetersetPerGy;
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
                    _client.MetersetPerGy = (value);
                }
                else
                {
                }
            }
        }

        public System.Double PlannedSSD
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("PlannedSSD"))
                    {
                        return _client.PlannedSSD;
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
                        return _client.PlannedSSD;
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
                    _client.PlannedSSD = (value);
                }
                else
                {
                }
            }
        }

        public System.Double SSD
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("SSD"))
                    {
                        return _client.SSD;
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
                        return _client.SSD;
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
                    _client.SSD = (value);
                }
                else
                {
                }
            }
        }

        public System.Double SSDAtStopAngle
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("SSDAtStopAngle"))
                    {
                        return _client.SSDAtStopAngle;
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
                        return _client.SSDAtStopAngle;
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
                    _client.SSDAtStopAngle = (value);
                }
                else
                {
                }
            }
        }

        public IEnumerable<ESAPIX.Facade.API.FieldReferencePoint> FieldReferencePoints
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("FieldReferencePoints"))
                    {
                        foreach (var item in _client.FieldReferencePoints)
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
                        var asEnum = (IEnumerable)_client.FieldReferencePoints;
                        enumerator = asEnum.GetEnumerator();
                    }

                    );
                    while (XC.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                    {
                        var facade = new ESAPIX.Facade.API.FieldReferencePoint();
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
                    _client.FieldReferencePoints = value;
            }
        }

        public System.Double NormalizationFactor
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("NormalizationFactor"))
                    {
                        return _client.NormalizationFactor;
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
                        return _client.NormalizationFactor;
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
                    _client.NormalizationFactor = (value);
                }
                else
                {
                }
            }
        }

        public System.String NormalizationMethod
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("NormalizationMethod"))
                    {
                        return _client.NormalizationMethod;
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
                        return _client.NormalizationMethod;
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
                    _client.NormalizationMethod = (value);
                }
                else
                {
                }
            }
        }

        public System.Double AverageSSD
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("AverageSSD"))
                    {
                        return _client.AverageSSD;
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
                        return _client.AverageSSD;
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
                    _client.AverageSSD = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector GetSourceLocation(System.Double gantryAngle)
        {
            if ((XC.Instance.CurrentContext) != (null))
            {
                var vmsResult = (XC.Instance.CurrentContext.GetValue(sc =>
                {
                    return _client.GetSourceLocation(gantryAngle);
                }

                ));
                return vmsResult;
            }
            else
            {
                return (VMS.TPS.Common.Model.Types.VVector)(_client.GetSourceLocation(gantryAngle));
            }
        }

        public Beam()
        {
            _client = (new ExpandoObject());
        }

        public Beam(dynamic client)
        {
            _client = (client);
        }
    }
}