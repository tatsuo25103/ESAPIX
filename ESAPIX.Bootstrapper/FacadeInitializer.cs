using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using ESAPIX.Extensions;
using ESAPIX.Facade;
using V = VMS.TPS.Common.Model.API;
using X= ESAPIX.Facade.API;
using T = VMS.TPS.Common.Model.Types;

namespace ESAPIX.Bootstrapper
{
    public class FacadeInitializer
    {
        public static void Initialize()
        {
            StaticHelper.SerializableObject_ClearSerializationHistoryAction0 = (() => V.SerializableObject.ClearSerializationHistory());
            VMSConstructor.ConstructScriptContextFunc0 = (new Func<System.Object, System.Object, System.String, dynamic>((System.Object context, System.Object user, System.String appName) => new VMS.TPS.Common.Model.API.ScriptContext(context, user, appName)));
            StaticHelper.Application_CreateApplicationFunc0 = ((System.String username, System.String password) => V.Application.CreateApplication(username, password));
            StaticHelper.Application_CreateApplicationFunc1 = (() => V.Application.CreateApplication());
            VMSConstructor.ConstructScriptEnvironmentFunc0 = (new Func<System.String, System.Collections.Generic.IEnumerable<VMS.TPS.Common.Model.IApplicationScript>, System.Action<System.Reflection.Assembly,System.Object,System.Windows.Window,System.Object>, dynamic>((System.String appName, System.Collections.Generic.IEnumerable<VMS.TPS.Common.Model.IApplicationScript> scripts, System.Action<System.Reflection.Assembly,System.Object,System.Windows.Window,System.Object> scriptExecutionEngine) => new VMS.TPS.Common.Model.API.ScriptEnvironment(appName, scripts, scriptExecutionEngine)));
        }
    }
}