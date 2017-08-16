using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Facade.XContext;
using Types = VMS.TPS.Common.Model.Types;

namespace ESAPIX.Facade
{
    public class VMSConstructor
    {
        public static Func<System.Object, System.Object, System.String, dynamic> ConstructScriptContextFunc0 = null;
        public static Func<System.String, System.Collections.Generic.IEnumerable<VMS.TPS.Common.Model.IApplicationScript>, System.Action<System.Reflection.Assembly,System.Object,System.Windows.Window,System.Object>, dynamic> ConstructScriptEnvironmentFunc0 = null;
    }
}