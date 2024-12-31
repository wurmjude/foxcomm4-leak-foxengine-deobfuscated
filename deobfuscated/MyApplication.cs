using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
    [CompilerGenerated]
    [AccessedThroughProperty("Domain")]
    private AppDomain _Domain;

    [CompilerGenerated]
    [AccessedThroughProperty("Domain5")]
    private AppDomain _Domain5;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [STAThread]
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static void Main(string[] args)
    {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
        MyProject.Application.Run(args);
    }

    [SpecialName]
    [CompilerGenerated]
    private AppDomain Domain()
    {
        return _Domain;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    private void Domain(AppDomain value)
    {
        ResolveEventHandler value2 = DomainCheck;
        AppDomain domain = _Domain;
        if (_Domain != null)
        {
            _Domain.AssemblyResolve -= value2;
        }
        _Domain = value;
        domain = _Domain;
        if (domain != null)
        {
            domain.AssemblyResolve += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    private AppDomain Domain5()
    {
        return _Domain5;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    private void Domain5(AppDomain value)
    {
        ResolveEventHandler value2 = DomainCheck5;
        AppDomain domain = _Domain5;
        if (domain != null)
        {
            domain.AssemblyResolve -= value2;
        }
        _Domain5 = value;
        domain = _Domain5;
        if (domain != null)
        {
            domain.AssemblyResolve += value2;
        }
    }

    private Assembly DomainCheck5(object sender, ResolveEventArgs e)
    {
        if (e.Name.Contains("Newtonsoft.Json"))
        {
            return Assembly.Load(Resources.Newtonsoft_Json());
        }
        return null;
    }

    private Assembly DomainCheck(object sender, ResolveEventArgs e)
    {
        if (e.Name.Contains("CButtonLib"))
        {
            return Assembly.Load(Resources.CButtonLib());
        }
        return null;
    }

    [DebuggerStepThrough]
    public MyApplication()
        : base(AuthenticationMode.Windows)
    {
        Domain(AppDomain.CurrentDomain);
        Domain5(AppDomain.CurrentDomain);
        base.IsSingleInstance = false;
        base.EnableVisualStyles = true;
        base.SaveMySettingsOnExit = false;
        base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm()
    {
        base.MainForm = MyProject.Forms.Form4();
    }

    [DebuggerStepThrough]
    protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
    {
        base.MinimumSplashScreenDisplayTime = 0;
        return base.OnInitialize(commandLineArgs);
    }
}
