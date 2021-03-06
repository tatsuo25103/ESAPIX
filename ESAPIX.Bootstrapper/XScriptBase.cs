﻿#region

using System.Windows;
using System.Windows.Threading;
using ESAPIX.AppKit;
using ESAPIX.Facade;
using VMS.TPS.Common.Model.API;

#endregion

namespace ESAPIX.Bootstrapper
{
    public abstract class XScriptBase
    {
        public void Execute(ScriptContext context, Window window)
        {
            var scriptContext = new Facade.API.ScriptContext(context);
            //When hooked up to bootstrapper (comment out otherwise)
            FacadeInitializer.Initialize();
            //Get this window barely visible so that when it does show, it isn't ugly ;)
            window.Height = window.Width = 0;
            window.WindowStyle = WindowStyle.None;
            window.Hide();
            window.Loaded += Window_Loaded;

            var plugCtx = new PluginContext(scriptContext, window);
            var frame = new DispatcherFrame();
            XContext.Instance.CurrentContext = plugCtx;
            XExecute(plugCtx, frame);
            Dispatcher.CurrentDispatcher.UnhandledException += CurrentDispatcher_UnhandledException;
            Dispatcher.PushFrame(frame);
        }

        private void CurrentDispatcher_UnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"SCRIPT ERROR : \n\n"+e.Exception.Message);
            e.Handled = true;
        }

        #region WINDOW PLUMBING

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var win = sender as Window;
            win.Loaded += Window_Loaded;
            win.Close();
        }

        #endregion

        public abstract void XExecute(PluginContext ctx, DispatcherFrame frame);
    }
}