using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Resources
{
    private static ResourceManager resourceManager;

    private static CultureInfo cultureInfo;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager getResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceManager, null))
            {
                resourceManager = new ResourceManager("Foxengine.Resources", typeof(Resources).Assembly);
            }
            return resourceManager;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo getCultureInfo
    {
        get
        {
            return cultureInfo;
        }
        set
        {
            cultureInfo = value;
        }
    }

    [SpecialName]
    internal static Bitmap _1X1PIPA()
    {
        return (Bitmap)RuntimeHelpers.GetObjectValue(getResourceManager.GetObject("_1X1PIPA", cultureInfo));
    }

    [SpecialName]
    internal static Bitmap _1X1PIPA_allando()
    {
        return (Bitmap)RuntimeHelpers.GetObjectValue(getResourceManager.GetObject("_1X1PIPA_allando", cultureInfo));
    }

    [SpecialName]
    internal static byte[] CButtonLib()
    {
        return (byte[])RuntimeHelpers.GetObjectValue(getResourceManager.GetObject("CButtonLib", cultureInfo));
    }

    [SpecialName]
    internal static byte[] Newtonsoft_Json()
    {
        return (byte[])RuntimeHelpers.GetObjectValue(getResourceManager.GetObject("Newtonsoft_Json", cultureInfo));
    }

    [SpecialName]
    internal static byte[] WinFormAnimation()
    {
        return (byte[])RuntimeHelpers.GetObjectValue(getResourceManager.GetObject("WinFormAnimation", cultureInfo));
    }
}
