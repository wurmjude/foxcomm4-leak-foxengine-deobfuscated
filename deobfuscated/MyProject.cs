using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
        [ThreadStatic]
        private static Hashtable m_FormBeingCreated;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Form3 m_Form3;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Form1 m_Form1;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Form2 m_Form2;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Form4 m_Form4;

        [DebuggerHidden]
        private static T Create__Instance__<T>(T Instance) where T : Form, new()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                if (m_FormBeingCreated != null)
                {
                    if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
                    }
                }
                else
                {
                    m_FormBeingCreated = new Hashtable();
                }
                m_FormBeingCreated.Add(typeof(T), null);
                try
                {
                    return new T();
                }
                catch (TargetInvocationException ex) when (((Func<bool>)delegate
                {
                    // Could not convert BlockContainer to single expression
                    ProjectData.SetProjectError(ex);
                    return ex.InnerException != null;
                }).Invoke())
                {
                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
                }
                finally
                {
                    m_FormBeingCreated.Remove(typeof(T));
                }
            }
            return Instance;
        }

        [DebuggerHidden]
        private void Dispose__Instance__<T>(ref T instance) where T : Form
        {
            instance.Dispose();
            instance = null;
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public MyForms()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object o)
        {
            return base.Equals(RuntimeHelpers.GetObjectValue(o));
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal Type GetType()
        {
            return typeof(MyForms);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [SpecialName]
        public Form3 Form3()
        {
            m_Form3 = Create__Instance__<Form3>(m_Form3);
            return m_Form3;
        }

        [SpecialName]
        public Form1 Form1()
        {
            m_Form1 = Create__Instance__<Form1>(m_Form1);
            return m_Form1;
        }

        [SpecialName]
        public Form2 Form2()
        {
            m_Form2 = Create__Instance__<Form2>(m_Form2);
            return m_Form2;
        }

        [SpecialName]
        public Form4 Form4()
        {
            m_Form4 = Create__Instance__<Form4>(m_Form4);
            return m_Form4;
        }

        [SpecialName]
        public void Form3(Form3 value)
        {
            if (value != m_Form3)
            {
                if (value != null)
                {
                    throw new ArgumentException("Property can only be set to Nothing");
                }
                Dispose__Instance__(ref m_Form3);
            }
        }

        [SpecialName]
        public void Form3(Form1 value)
        {
            if (value != m_Form1)
            {
                if (value != null)
                {
                    throw new ArgumentException("Property can only be set to Nothing");
                }
                Dispose__Instance__(ref m_Form1);
            }
        }

        [SpecialName]
        public void Form2(Form2 value)
        {
            if (value != m_Form2)
            {
                if (value != null)
                {
                    throw new ArgumentException("Property can only be set to Nothing");
                }
                Dispose__Instance__(ref m_Form2);
            }
        }

        [SpecialName]
        public void Form4(Form4 value)
        {
            if (value != m_Form4)
            {
                if (value != null)
                {
                    throw new ArgumentException("Property can only be set to Nothing");
                }
                Dispose__Instance__(ref m_Form4);
            }
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerHidden]
        public override bool Equals(object o)
        {
            return base.Equals(RuntimeHelpers.GetObjectValue(o));
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerHidden]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerHidden]
        internal Type GetType()
        {
            return typeof(MyWebServices);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerHidden]
        public override string ToString()
        {
            return base.ToString();
        }

        [DebuggerHidden]
        private static T Create__Instance__<T>(T instance) where T : new()
        {
            if (instance == null)
            {
                return new T();
            }
            return instance;
        }

        [DebuggerHidden]
        private void Dispose__Instance__<T>(ref T instance)
        {
            instance = default(T);
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public MyWebServices()
        {
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
        [CompilerGenerated]
        [ThreadStatic]
        private static T m_ThreadStaticValue;

        [SpecialName]
        [DebuggerHidden]
        internal T GetInstance()
        {
            if (m_ThreadStaticValue == null)
            {
                m_ThreadStaticValue = new T();
            }
            return m_ThreadStaticValue;
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ThreadSafeObjectProvider()
        {
        }
    }

    private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

    private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

    private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

    private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

    private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
        [DebuggerHidden]
        get
        {
            return m_ComputerObjectProvider.GetInstance();
        }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
        [DebuggerHidden]
        get
        {
            return m_AppObjectProvider.GetInstance();
        }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
        [DebuggerHidden]
        get
        {
            return m_UserObjectProvider.GetInstance();
        }
    }

    [HelpKeyword("My.Forms")]
    internal static MyForms Forms
    {
        [DebuggerHidden]
        get
        {
            return m_MyFormsObjectProvider.GetInstance();
        }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyWebServices WebServices
    {
        [DebuggerHidden]
        get
        {
            return m_MyWebServicesObjectProvider.GetInstance();
        }
    }
}
