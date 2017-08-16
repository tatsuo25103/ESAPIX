﻿#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Threading;
using ESAPIX.Facade.API;
using static ESAPIX.AppKit.StandAloneContext;

#endregion

namespace ESAPIX.Interfaces
{
    /// <summary>
    ///     The common interface for use in standalone and plugin applications. It exposes properties that found in a the
    ///     "ScriptContext" class
    /// </summary>
    public interface IScriptContext
    {
        string ApplicationName { get; }

        System.String VersionInfo { get; }

        BrachyPlanSetup BrachyPlanSetup { get; }

        IEnumerable<BrachyPlanSetup> BrachyPlansInScope { get; }

        User CurrentUser { get; }

        Course Course { get; }

        Image Image { get; }

        Patient Patient { get; }

        ExternalPlanSetup ExternalPlanSetup { get; }

        IEnumerable<ExternalPlanSetup> ExternalPlansInScope { get; }

        ESAPIX.Facade.API.IonPlanSetup IonPlanSetup { get; }

        IEnumerable<ESAPIX.Facade.API.IonPlanSetup> IonPlansInScope { get;  }

        PlanSetup PlanSetup { get; }

        IEnumerable<PlanSetup> PlansInScope { get; }

        IEnumerable<PlanSum> PlanSumsInScope { get; }

        StructureSet StructureSet { get; }

        /// <summary>
        ///     The thread that can access VMS objects
        /// </summary>
        IVMSThread Thread { get; }

        Dispatcher UIDispatcher { get; set; }

        /// <summary>
        ///     Gets a value on the correct thread and returns it
        /// </summary>
        /// <typeparam name="T">the type of value to be returned</typeparam>
        /// <param name="toExecute">the function that assigns the value</param>
        /// <returns>the value requested</returns>
        T GetValue<T>(Func<IScriptContext, T> toExecute);

        /// <summary>
        ///     Gets a value asynchronously on the correct thread and returns it
        /// </summary>
        /// <typeparam name="T">the type of value to be returned</typeparam>
        /// <param name="toExecute">the function that assigns the value</param>
        /// <returns>a task of the value requested</returns>
        Task<T> GetValueAsync<T>(Func<IScriptContext, T> toExecute);

        #region EVENTS

        //These are only used in Standalone Context, but are here so casting does not have to be performed to check
        event PatientChangedHandler PatientChanged;

        event PlanSetupChangedHandler PlanSetupChanged;
        event ExternalPlanSetupChangedHandler ExternalPlanSetupChanged;
        event PlanSetupChangedHandler BrachyPlanSetupChanged;
        event IonPlanSetupChangedHandler IonPlanSetupChanged;
        event CourseChangedHandler CourseChanged;

        #endregion
    }
}