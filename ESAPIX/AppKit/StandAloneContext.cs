﻿#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Threading;
using ESAPIX.Facade;
using ESAPIX.Facade.API;
using ESAPIX.Interfaces;

#endregion

namespace ESAPIX.AppKit
{
    /// <summary>
    ///     Wraps a VMS application in a way that replicates the ScriptContext class. Can be used for debugging or building two
    ///     sided apps
    /// </summary>
    public class StandAloneContext : IScriptContext, IDisposable
    {
        private readonly Application _app;

        public StandAloneContext(Application app, IVMSThread thread)
        {
            _app = app;
            Thread = thread ?? new AppComThread(false); //Same thread
        }

        public void Dispose()
        {
            _app.Dispose();
        }

        public Course Course { get; private set; }

        public User CurrentUser => _app?.CurrentUser;

        public Image Image => PlanSetup?.StructureSet.Image;

        public Patient Patient { get; private set; }

        public PlanSetup PlanSetup { get; private set; }

        public IEnumerable<PlanSetup> PlansInScope => Course?.PlanSetups;

        public IEnumerable<PlanSum> PlanSumsInScope => Course?.PlanSums;

        public StructureSet StructureSet => PlanSetup?.StructureSet;

        public IVMSThread Thread { get; }

        public Dispatcher UIDispatcher { get; set; }

        public string ApplicationName { get; set; } = "VMS Application";

        public BrachyPlanSetup BrachyPlanSetup { get; private set; }

        public IEnumerable<BrachyPlanSetup> BrachyPlansInScope => Course?.BrachyPlanSetups;

        public ExternalPlanSetup ExternalPlanSetup { get; private set; }

        public IEnumerable<ExternalPlanSetup> ExternalPlansInScope => Course?.ExternalPlanSetups;

        public string VersionInfo { get; set; }

        public IonPlanSetup IonPlanSetup { get; private set; }

        public IEnumerable<IonPlanSetup> IonPlansInScope => Course?.IonPlanSetups;

        /// <summary>
        ///     Creates a new application context and binds it to a new thread
        /// </summary>
        /// <returns>app context</returns>
        public static StandAloneContext Create(bool singleThread = false)
        {
            Application app = Application.CreateApplication(singleThread);
            var thread = XContext.Instance.CurrentContext.Thread;
            return new StandAloneContext(app, thread);
        }

        public bool SetPatient(string id)
        {
            Patient = _app.OpenPatientById(id);
            var found = Patient.IsLive;
            if (found)
                OnPatientChanged(Patient);
            else
                OnPatientChanged(null);
            return found;
        }

        public async Task<bool> SetPatientAsync(string id)
        {
            Patient = await Task.Run(() => { return _app.OpenPatientById(id); });
            var found = Patient.IsLive;
            if (found)
                OnPatientChanged(Patient);
            else
                OnPatientChanged(null);
            return found;
        }

        public bool SetCourse(Course course)
        {
            Course = course;
            //Notify
            OnCourseChanged(course);
            return Course != null;
        }

        public bool SetPlanSetup(PlanSetup plan)
        {
            PlanSetup = plan;
            //Notify
            OnPlanSetupChanged(plan);
            return PlanSetup != null;
        }

        public bool SetExternalPlanSetup(ExternalPlanSetup ex)
        {
            PlanSetup = ex;
            ExternalPlanSetup = ex;
            //Notify
            OnExternalPlanSetupChanged(ex);
            OnPlanSetupChanged(ex);
            return ExternalPlanSetup != null;
        }

        public bool SetBrachyPlanSetup(BrachyPlanSetup bs)
        {
            PlanSetup = bs;
            BrachyPlanSetup = bs;
            //Notify
            OnBrachyPlanSetupChanged(bs);
            OnPlanSetupChanged(bs);
            return BrachyPlanSetup != null;
        }

        public bool SetIonPlanSetup(IonPlanSetup ips)
        {
            PlanSetup = ips;
            IonPlanSetup = ips;
            //Notify
            OnIonPlanSetupChanged(ips);
            OnPlanSetupChanged(ips);
            return IonPlanSetup != null;
        }

        public void ClosePatient()
        {
            _app.ClosePatient();
            OnPatientChanged(null);
            SetPlanSetup(null);
            SetCourse(null);
            SetBrachyPlanSetup(null);
            SetExternalPlanSetup(null);
        }

        #region CONTEXT CHANGED EVENTS

        public delegate void PatientChangedHandler(Patient newPatient);

        public event PatientChangedHandler PatientChanged;

        public void OnPatientChanged(Patient p)
        {
            PatientChanged?.Invoke(p);
        }

        public delegate void PlanSetupChangedHandler(PlanSetup ps);

        public event PlanSetupChangedHandler PlanSetupChanged;

        public void OnPlanSetupChanged(PlanSetup ps)
        {
            PlanSetupChanged?.Invoke(ps);
        }

        public delegate void ExternalPlanSetupChangedHandler(ExternalPlanSetup ps);

        public event ExternalPlanSetupChangedHandler ExternalPlanSetupChanged;

        public void OnExternalPlanSetupChanged(ExternalPlanSetup ps)
        {
            ExternalPlanSetupChanged?.Invoke(ps);
        }

        public delegate void BrachyPlanSetupChangedHandler(BrachyPlanSetup ps);

        public event PlanSetupChangedHandler BrachyPlanSetupChanged;

        public void OnBrachyPlanSetupChanged(BrachyPlanSetup ps)
        {
            BrachyPlanSetupChanged?.Invoke(ps);
        }

        public delegate void IonPlanSetupChangedHandler(IonPlanSetup ps);

        public event IonPlanSetupChangedHandler IonPlanSetupChanged;

        public void OnIonPlanSetupChanged(IonPlanSetup ps)
        {
            IonPlanSetupChanged?.Invoke(ps);
        }

        public delegate void CourseChangedHandler(Course c);

        public event CourseChangedHandler CourseChanged;

        public void OnCourseChanged(Course c)
        {
            CourseChanged?.Invoke(c);
        }

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

        #endregion
    }
}