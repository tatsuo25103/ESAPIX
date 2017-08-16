#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ESAPIX.Extensions;
using XC = ESAPIX.Facade.XContext;

#endregion

namespace ESAPIX.Facade.API
{
    public class ScriptEnvironment
    {
        internal dynamic _client;

        public ScriptEnvironment()
        {
            _client = new ExpandoObject();
        }

        public ScriptEnvironment(dynamic client)
        {
            _client = client;
        }

        public ScriptEnvironment(string appName, IEnumerable<VMS.TPS.Common.Model.IApplicationScript> scripts,
            Action<System.Reflection.Assembly, object, System.Windows.Window, object> scriptExecutionEngine)
        {
            if (XC.Instance.CurrentContext != null)
                _client = VMSConstructor.ConstructScriptEnvironmentFunc0(appName, scripts, scriptExecutionEngine);
            else
                throw new Exception("There is no VMS Context to create the class");
        }

        public bool IsLive
        {
            get { return !DefaultHelper.IsDefault(_client) && !(_client is ExpandoObject); }
        }

        public string ApplicationName
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ApplicationName"))
                        return _client.ApplicationName;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ApplicationName; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ApplicationName = value;
            }
        }

        public string VersionInfo
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("VersionInfo"))
                        return _client.VersionInfo;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.VersionInfo; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.VersionInfo = value;
            }
        }

        public string ApiVersionInfo
        {
            get
            {
                if (_client is ExpandoObject)
                    if (((ExpandoObject) _client).HasProperty("ApiVersionInfo"))
                        return _client.ApiVersionInfo;
                    else
                        return default(string);
                if (XC.Instance.CurrentContext != null)
                    return XC.Instance.CurrentContext.GetValue(sc => { return _client.ApiVersionInfo; }
                    );
                return default(string);
            }

            set
            {
                if (_client is ExpandoObject)
                    _client.ApiVersionInfo = value;
            }
        }

        public IEnumerable<ApplicationScript> Scripts
        {
            get
            {
                if (_client is ExpandoObject)
                {
                    if ((_client as ExpandoObject).HasProperty("Scripts"))
                        foreach (var item in _client.Scripts)
                            yield return item;
                    else
                        yield break;
                }
                else
                {
                    IEnumerator enumerator = null;
                    XC.Instance.CurrentContext.Thread.Invoke(() =>
                        {
                            var asEnum = (IEnumerable) _client.Scripts;
                            enumerator = asEnum.GetEnumerator();
                        }
                    );
                    while (XC.Instance.CurrentContext.GetValue(sc => enumerator.MoveNext()))
                    {
                        var facade = new ApplicationScript();
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
                    _client.Scripts = value;
            }
        }

        public void ExecuteScript(System.Reflection.Assembly scriptAssembly, ScriptContext scriptContext,
            System.Windows.Window window)
        {
            if (XC.Instance.CurrentContext != null)
                XC.Instance.CurrentContext.Thread.Invoke(() =>
                    {
                        _client.ExecuteScript(scriptAssembly, scriptContext._client, window);
                    }
                );
            else
                _client.ExecuteScript(scriptAssembly, scriptContext, window);
        }
    }
}