﻿#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using ESAPIX.Facade.API;
using ESAPIX.Interfaces;
using System.Windows.Threading;

#endregion

namespace ESAPIX.AppKit
{
    /// <summary>
    ///     A simple wrapper around the script context to make it compliant with a common interface IScriptContext
    /// </summary>
    public class PluginContext : IScriptContext
    {
        private readonly ScriptContext _ctx;

        public PluginContext(ScriptContext ctx, Window w)
        {
            _ctx = ctx;
            Thread = new ScriptComThread(w.Dispatcher);
        }

        public Course Course => _ctx?.Course;

        public User CurrentUser => _ctx?.CurrentUser;

        public Image Image => _ctx?.Image;

        public Patient Patient => _ctx?.Patient;

        public PlanSetup PlanSetup => _ctx?.PlanSetup;

        public IEnumerable<PlanSetup> PlansInScope => _ctx?.PlansInScope;

        public IEnumerable<PlanSum> PlanSumsInScope => _ctx?.PlanSumsInScope;

        public StructureSet StructureSet => _ctx?.StructureSet;

        public IVMSThread Thread { get; }

        public async Task<T> GetValueAsync<T>(Func<IScriptContext, T> toExecute)
        {
            var result = default(T);
            await Thread.InvokeAsync(() => { result = toExecute(this); });
            return result;
        }

        public T GetValue<T>(Func<IScriptContext, T> toExecute)
        {
            var result = default(T);
            Thread.Invoke(() => { result = toExecute(this); });
            return result;
        }

        public Dispatcher UIDispatcher { get; set; }

        #region NOT USED

        //These will never get called
        public event StandAloneContext.PatientChangedHandler PatientChanged;

        public event StandAloneContext.PlanSetupChangedHandler PlanSetupChanged;
        public event StandAloneContext.CourseChangedHandler CourseChanged;

        #endregion
    }
}