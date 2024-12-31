using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

[DesignerGenerated]
public class Form2 : Form
{
    private IContainer components;

    [CompilerGenerated]
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [CompilerGenerated]
    [AccessedThroughProperty("Initline")]
    private PictureBox _Initline;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;

    [CompilerGenerated]
    [AccessedThroughProperty("LoadStatus")]
    private Label _LoadStatus;

    [CompilerGenerated]
    [AccessedThroughProperty("Loadengine")]
    private Timer _Loadengine;

    [CompilerGenerated]
    [AccessedThroughProperty("Bar")]
    private ProgressBar _Bar;

    [CompilerGenerated]
    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [CompilerGenerated]
    [AccessedThroughProperty("FoxTaskIcon")]
    private NotifyIcon _FoxTaskIcon;

    private string CpuID;
    
    private string CpuID1;

    private string DiskID;

    private string DiskID1;
    
    private string PartitionID;

    private string PartitionID1;
    
    private string BoardID;

    private string BoardID1;

    private string Status;

    private string Serial;

    private string Barel;

    private string ViharEnc;

    private string SerialEnc;

    private string BarelEnc;

    private string Password;

    public Form2()
    {
        base.Load += Form2_Load;
        base.FormClosing += Form2_FormClosing;
        InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
        components = new Container();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
        Label1(new Label());
        Initline(new PictureBox());
        PictureBox4(new PictureBox());
        LoadStatus(new Label());
        Loadengine(new Timer(components));
        Bar(new ProgressBar());
        Label2(new Label());
        FoxTaskIcon(new NotifyIcon(components));
        ((ISupportInitialize)Initline()).BeginInit();
        ((ISupportInitialize)PictureBox4()).BeginInit();
        SuspendLayout();
        Label1().AutoSize = true;
        Label1().BackColor = Color.Transparent;
        Label1().Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label1().ForeColor = SystemColors.AppWorkspace;
        Label1().Location = new Point(134, 120);
        Label1().Name = "Label1";
        Label1().Size = new Size(141, 25);
        Label1().TabIndex = 0;
        Label1().Text = "PRELOADER";
        Initline().BackColor = Color.Transparent;
        Initline().Image = (Image)componentResourceManager.GetObject("Initline.Image");
        Initline().Location = new Point(124, 148);
        Initline().Name = "Initline";
        Initline().Size = new Size(162, 31);
        Initline().SizeMode = PictureBoxSizeMode.StretchImage;
        Initline().TabIndex = 48;
        Initline().TabStop = false;
        PictureBox4().BackColor = Color.Transparent;
        PictureBox4().Cursor = Cursors.Default;
        PictureBox4().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
        PictureBox4().Location = new Point(150, 21);
        PictureBox4().Name = "PictureBox4";
        PictureBox4().Size = new Size(109, 93);
        PictureBox4().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox4().TabIndex = 62;
        PictureBox4().TabStop = false;
        LoadStatus().BackColor = Color.Transparent;
        LoadStatus().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        LoadStatus().ForeColor = SystemColors.AppWorkspace;
        LoadStatus().Location = new Point(12, 180);
        LoadStatus().Name = "LoadStatus";
        LoadStatus().Size = new Size(383, 28);
        LoadStatus().TabIndex = 63;
        LoadStatus().Text = "- - -";
        LoadStatus().TextAlign = ContentAlignment.MiddleCenter;
        Bar().Location = new Point(401, 181);
        Bar().Name = "Bar";
        Bar().Size = new Size(10, 10);
        Bar().TabIndex = 64;
        Bar().Visible = false;
        Label2().AutoSize = true;
        Label2().BackColor = Color.Transparent;
        Label2().Cursor = Cursors.Hand;
        Label2().Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label2().ForeColor = Color.DarkRed;
        Label2().Location = new Point(389, 12);
        Label2().Name = "Label2";
        Label2().Size = new Size(14, 14);
        Label2().TabIndex = 65;
        Label2().Text = "X";
        FoxTaskIcon().Icon = (Icon)componentResourceManager.GetObject("FoxTaskIcon.Icon");
        FoxTaskIcon().Text = "2H FoxComm En-Dilla Licence Management System";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
        base.ClientSize = new Size(416, 227);
        base.Controls.Add(Label2());
        base.Controls.Add(Bar());
        base.Controls.Add(LoadStatus());
        base.Controls.Add(PictureBox4());
        base.Controls.Add(Initline());
        base.Controls.Add(Label1());
        DoubleBuffered = true;
        base.FormBorderStyle = FormBorderStyle.None;
        base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "Preloader";
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "2H FoxComm Preloader";
        base.TopMost = true;
        ((ISupportInitialize)Initline()).EndInit();
        ((ISupportInitialize)PictureBox4()).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Label1()
    {
        return _Label1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Label1(Label value)
    {
        _Label1 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox Initline()
    {
        return _Initline;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Initline(PictureBox value)
    {
        _Initline = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox PictureBox4()
    {
        return _PictureBox4;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void PictureBox4(PictureBox value)
    {
        _PictureBox4 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label LoadStatus()
    {
        return _LoadStatus;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void LoadStatus(Label value)
    {
        _LoadStatus = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Timer Loadengine()
    {
        return _Loadengine;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Loadengine(Timer value)
    {
        EventHandler value2 = Loadengine_Tick;
        Timer timer = _Loadengine;
        if (timer != null)
        {
            timer.Tick -= value2;
        }
        _Loadengine = value;
        timer = _Loadengine;
        if (timer != null)
        {
            timer.Tick += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual ProgressBar Bar()
    {
        return _Bar;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Bar(ProgressBar value)
    {
        _Bar = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Label2()
    {
        return _Label2;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Label2(Label value)
    {
        EventHandler value2 = Label2_Click;
        Label label = _Label2;
        if (label != null)
        {
            label.Click -= value2;
        }
        _Label2 = value;
        label = _Label2;
        if (label != null)
        {
            label.Click += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual NotifyIcon FoxTaskIcon()
    {
        return _FoxTaskIcon;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void FoxTaskIcon(NotifyIcon value)
    {
        _FoxTaskIcon = value;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        base.TransparencyKey = Color.LightBlue;
        BackColor = Color.LightBlue;
        int num = Screen.PrimaryScreen.WorkingArea.Width;
        checked
        {
            int num2 = Screen.PrimaryScreen.WorkingArea.Height - base.Height;
            while (num != Screen.PrimaryScreen.WorkingArea.Width - base.Width)
            {
                num--;
                base.Location = new Point(num, num2);
            }
            AdatokLoad.HardwareID(ref CpuID1, ref DiskID1, ref PartitionID1, ref BoardID1);
            AdatokLoad.Regadatok(ref Status, ref SerialEnc, ref ViharEnc, ref BarelEnc);
            _2007();
            Loadengine().Start();
        }
    }

    private void _2007()
    {
        byte[] bytes = Encoding.UTF8.GetBytes(CpuID1 + BoardID1 + DiskID1);
        try
        {
            Serial = AdatokLoad.DecryptString(Convert.FromBase64String(SerialEnc), bytes);
            Barel = AdatokLoad.DecryptString(Convert.FromBase64String(BarelEnc), bytes);
            string vihar = AdatokLoad.DecryptString(Convert.FromBase64String(ViharEnc), bytes).Substring(5);
            Password = vihar.Substring(0, checked(vihar.Length - 11));
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Serial = "00";
            Barel = "00";
            ProjectData.ClearProjectError();
        }
        _2008();
    }

    private void Loadengine_Tick(object sender, EventArgs e)
    {
        Loadengine().Interval = 65;
        Bar().Increment(1);
        if (Bar().Value == 1)
        {
            LoadStatus().Text = "Processing parameterized data...";
        }
        if (Bar().Value == 15)
        {
            LoadStatus().Text = "FoxComm Audit checking...";
            _2007();
        }
        if (Bar().Value == 30)
        {
            LoadStatus().Text = "Checking userdata query...";
        }
        if (Bar().Value == 55)
        {
            LoadStatus().Text = "Checking username and passwd...";
        }
        if (Bar().Value == 75)
        {
            LoadStatus().Text = "User registerning on the system...";
        }
        if (Bar().Value == 85)
        {
            LoadStatus().Text = "All check completed preparoing boot to os...";
        }
        if (Bar().Value == 100)
        {
            Loadengine().Stop();
            base.TopMost = false;
            base.ShowInTaskbar = false;
            Hide();
            FoxTaskIcon().Visible = true;
            if (File.Exists("C:\\Windows\\Branding\\Masbate\\boot\\2hbootx64.efi"))
            {
                AdatokLoad.StartingMain(Password);
                return;
            }
            Hide();
            Interaction.MsgBox("Hiányzó 2H Bootloader! hívja a forgalmazót!");
            Application.Exit();
        }
    }

    private async void _2008()
    {
        try
        {
            string text = string.Format("https://dimitris.masbate.hu/Engine/Preloader?Max={0}", Serial);
            HttpClient val = new HttpClient();
            try
            {
                ((HttpHeaders)val.DefaultRequestHeaders).Add("Authorization", "Bearer " + Barel);
                HttpResponseMessage val2 = await val.GetAsync(text);
                try
                {
                    if ((double)val2.StatusCode == Conversions.ToDouble("400"))
                    {
                        Hide();
                        MessageBox.Show("A beírt Licenckulcs nem létezik! Próbálja újra! A Program most kilép!", "2H-ETM Endencio: Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("504"))
                    {
                        Hide();
                        MessageBox.Show("A ETM Szerverek nem elérhetők! Próbálja később!", "2H-ETM Endencio: Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("403"))
                    {
                        Hide();
                        MessageBox.Show("A Digitális token érvénytelen vagy hibás! Próbálja ismét!", "2H-ETM Endencio: Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("401"))
                    {
                        Hide();
                        Interaction.MsgBox("A Digitális token érvénytelen vagy hibás! Próbálja ismét!");
                        Application.Exit();
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("200"))
                    {
                        HttpContent content = val2.Content;
                        try
                        {
                            object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(content.ReadAsStringAsync().Result));
                            Status = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "status" }, null)));
                            CpuID = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "cpuid" }, null)));
                            DiskID = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "diskid" }, null)));
                            BoardID = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "boardid" }, null)));
                            PartitionID = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "diskpart" }, null)));
                            _2009();
                            return;
                        }
                        finally
                        {
                            ((IDisposable)content)?.Dispose();
                        }
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }
        catch (Exception projectError)
        {
            ProjectData.SetProjectError(projectError);
            ProjectData.ClearProjectError();
        }
    }

    private void _2009()
    {
        if ((Operators.CompareString(Status, "1", TextCompare: false) == 0) | (Operators.CompareString(Status, "5", TextCompare: false) == 0))
        {
            if (!((Operators.CompareString(CpuID, CpuID1, TextCompare: false) == 0) & (Operators.CompareString(DiskID, DiskID1, TextCompare: false) == 0) & (Operators.CompareString(BoardID, BoardID1, TextCompare: false) == 0) & (Operators.CompareString(PartitionID, PartitionID1, TextCompare: false) == 0)))
            {
                Loadengine().Stop();
                Hide();
                MessageBox.Show("HWID Eltérés! A hardveres gyártási számok nem egyeznek a licencben foglaltakkal!", "2H-ETM FoxComm Preloader - HWID Eltérés észlelhető", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
        }
        else if (Operators.CompareString(Status, "2", TextCompare: false) == 0)
        {
            Loadengine().Stop();
            Hide();
            MessageBox.Show("A licenc le van tiltva! Hívja a forgalmazót!", "2H-ETM FoxComm Preloader", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void Label2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
