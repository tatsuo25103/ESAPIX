#region

using System;
using ESAPIX.AppKit;
using ESAPIX.Facade.API;

#endregion

namespace ESAPIX.Facade
{
    public class StaticHelper
    {
        //MUST SET BEFORE CALLING
        public static Func<string, string, dynamic> Application_CreateApplicationFunc0 { get; set; } =
            (u, p) => { return null; };

        public static Func<dynamic> Application_CreateApplicationFunc1 { get; set; } =
            () => { return null; };

        //MUST SET BEFORE CALLING
        public static Action SerializableObject_ClearSerializationHistoryAction0 { get; set; } = () => { };

        public static Application Application_CreateApplication(string username, string password,
            bool useCurrentThread = false)
        {
            var thread = new AppComThread(!useCurrentThread);
            Application xapp = null;
            Exception e = null;
            thread.Invoke(() =>
            {
                try
                {
                    var vms = Application_CreateApplicationFunc0(username, password);
                    xapp = new Application(vms);
                }
                catch (Exception ex)
                {
                    e = ex;
                }
            });
            if (xapp == null)
                throw new Exception("App was not created. Check to make sure the VMS dll references are correct.", e);
            var sac = new StandAloneContext(xapp, thread);
            XContext.Instance.CurrentContext = sac;
            XContext.Instance.CurrentContext.UIDispatcher = System.Windows.Application.Current?.Dispatcher;
            return xapp;
        }


        public static Application Application_CreateApplication(
            bool useCurrentThread = false)
        {
            var thread = new AppComThread(!useCurrentThread);
            Application xapp = null;
            Exception e = null;
            thread.Invoke(() =>
            {
                try
                {
                    var vms = Application_CreateApplicationFunc1();
                    xapp = new Application(vms);
                }
                catch (Exception ex)
                {
                    e = ex;
                }
            });
            if (xapp == null)
                throw new Exception("App was not created. Check to make sure the VMS dll references are correct.", e);
            var sac = new StandAloneContext(xapp, thread);
            XContext.Instance.CurrentContext = sac;
            XContext.Instance.CurrentContext.UIDispatcher = System.Windows.Application.Current?.Dispatcher;
            return xapp;
        }

        public static void SerializableObject_ClearSerializationHistory()
        {
            XContext.Instance.CurrentContext.Thread.Invoke(() =>
            {
                SerializableObject_ClearSerializationHistoryAction0();
            });
        }
    }
}