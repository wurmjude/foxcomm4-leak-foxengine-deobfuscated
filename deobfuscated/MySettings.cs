using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
    private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

    private static bool addedHandler;

    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
        if (MyProject.Application.SaveMySettingsOnExit)
        {
            MySettingsProperty.Settings.Save();
        }
    }

    [SpecialName]
    public static MySettings Default()
    {
        if (!addedHandler)
        {
            object obj = addedHandlerLockObject;
            ObjectFlowControl.CheckForSyncLockOnValueType(obj);
            bool lockTaken = false;
            try
            {
                Monitor.Enter(obj, ref lockTaken);
                if (!addedHandler)
                {
                    MyProject.Application.Shutdown += [DebuggerNonUserCode] [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
                    {
                        if (MyProject.Application.SaveMySettingsOnExit)
                        {
                            MySettingsProperty.Settings.Save();
                        }
                    };
                    addedHandler = true;
                }
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(obj);
                }
            }
        }
        return defaultInstance;
    }
}
