#region

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
            //Wrap context
            var facade = new Facade.API.ScriptContext(context);
            var plugin = new PluginContext(facade, window);

            //Set up singleton XContext pointers
            XContext.Instance.CurrentContext = plugin;
            XContext.Instance.CurrentContext.UIDispatcher = window.Dispatcher;

            //Get this window barely visible so that when it does show, it isn't ugly ;)
            window.Height = window.Width = 0;
            window.WindowStyle = WindowStyle.None;
            window.Hide();
            window.Loaded += Window_Loaded;

            //Push to user method
            var frame = new DispatcherFrame();
            XExecute(plugin, frame);
            Dispatcher.PushFrame(frame);
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