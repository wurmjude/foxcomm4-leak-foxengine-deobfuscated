using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;

[DesignerGenerated]
public class Form4 : Form
{
    private IContainer components;

    [CompilerGenerated]
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;

    [CompilerGenerated]
    [AccessedThroughProperty("Initline")]
    private PictureBox _Initline;

    [CompilerGenerated]
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;

    [CompilerGenerated]
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [CompilerGenerated]
    [AccessedThroughProperty("af_inet")]
    private Label _af_inet;

    [CompilerGenerated]
    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [CompilerGenerated]
    [AccessedThroughProperty("Securebootstatus")]
    private Label _Securebootstatus;

    [CompilerGenerated]
    [AccessedThroughProperty("Label4")]
    private Label _Label4;

    [CompilerGenerated]
    [AccessedThroughProperty("Foxlicencestatus")]
    private Label _Foxlicencestatus;

    [CompilerGenerated]
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;

    [CompilerGenerated]
    [AccessedThroughProperty("Firebutton")]
    private CButton _Firebutton;

    [CompilerGenerated]
    [AccessedThroughProperty("Kisturelmet")]
    private Label _Kisturelmet;

    [CompilerGenerated]
    [AccessedThroughProperty("Initialtime")]
    private Timer _Initialtime;

    [CompilerGenerated]
    [AccessedThroughProperty("Initbar")]
    private ProgressBar _Initbar;

    [CompilerGenerated]
    [AccessedThroughProperty("Kerdojel")]
    private PictureBox _Kerdojel;

    [CompilerGenerated]
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;

    [CompilerGenerated]
    [AccessedThroughProperty("CButton1")]
    private CButton _CButton1;

    [CompilerGenerated]
    [AccessedThroughProperty("CButton2")]
    private CButton _CButton2;

    [CompilerGenerated]
    [AccessedThroughProperty("CheckBox2")]
    private CheckBox _CheckBox2;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;

    private string Status;

    private string Serial;

    private string Barel;

    private string ViharEnc;

    private string SerialEnc;

    private string BarelEnc;

    private string CpuID;

    private string DiskID;

    private string PartitionID;

    private string BoardName;

    private string SecureBootStatus;

    private bool InternetConnection;

    private bool SecureBootDisabled;

    public Form4()
    {
        base.Load += Form4_Load;
        base.KeyDown += Form4_KeyDown;
        InternetConnection = false;
        SecureBootDisabled = false;
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
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
        cBlendItems cBlendItems = new cBlendItems();
        cBlendItems cBlendItems2 = new cBlendItems();
        cBlendItems cBlendItems3 = new cBlendItems();
        TextBox1(new TextBox());
        Initline(new PictureBox());
        CheckBox1(new CheckBox());
        Label1(new Label());
        af_inet(new Label());
        Label2(new Label());
        Securebootstatus(new Label());
        Label4(new Label());
        Foxlicencestatus(new Label());
        Panel1(new Panel());
        PictureBox6(new PictureBox());
        Kisturelmet(new Label());
        Kerdojel(new PictureBox());
        Firebutton(new CButton());
        Initialtime(new Timer(components));
        Initbar(new ProgressBar());
        Panel2(new Panel());
        CButton1(new CButton());
        CButton2(new CButton());
        PictureBox1(new PictureBox());
        PictureBox3(new PictureBox());
        PictureBox2(new PictureBox());
        CheckBox2(new CheckBox());
        PictureBox4(new PictureBox());
        PictureBox5(new PictureBox());
        ((ISupportInitialize)Initline()).BeginInit();
        Panel1().SuspendLayout();
        ((ISupportInitialize)PictureBox6()).BeginInit();
        ((ISupportInitialize)Kerdojel()).BeginInit();
        Panel2().SuspendLayout();
        ((ISupportInitialize)PictureBox1()).BeginInit();
        ((ISupportInitialize)PictureBox3()).BeginInit();
        ((ISupportInitialize)PictureBox2()).BeginInit();
        ((ISupportInitialize)PictureBox4()).BeginInit();
        ((ISupportInitialize)PictureBox5()).BeginInit();
        SuspendLayout();
        TextBox1().BackColor = Color.Black;
        TextBox1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
        TextBox1().ForeColor = Color.Silver;
        TextBox1().Location = new Point(26, 21);
        TextBox1().Multiline = true;
        TextBox1().Name = "TextBox1";
        TextBox1().ReadOnly = true;
        TextBox1().ScrollBars = ScrollBars.Vertical;
        TextBox1().Size = new Size(634, 323);
        TextBox1().TabIndex = 1;
        TextBox1().Text = componentResourceManager.GetString("TextBox1.Text");
        TextBox1().TextAlign = HorizontalAlignment.Center;
        Initline().BackColor = Color.Transparent;
        Initline().Image = (Image)componentResourceManager.GetObject("Initline.Image");
        Initline().Location = new Point(133, 32);
        Initline().Name = "Initline";
        Initline().Size = new Size(162, 31);
        Initline().SizeMode = PictureBoxSizeMode.StretchImage;
        Initline().TabIndex = 47;
        Initline().TabStop = false;
        CheckBox1().AutoSize = true;
        CheckBox1().BackColor = Color.Transparent;
        CheckBox1().Enabled = false;
        CheckBox1().Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 238);
        CheckBox1().ForeColor = Color.White;
        CheckBox1().Location = new Point(170, 357);
        CheckBox1().Name = "CheckBox1";
        CheckBox1().Size = new Size(350, 28);
        CheckBox1().TabIndex = 46;
        CheckBox1().Text = "Elfogadom a használati feltételeket";
        CheckBox1().UseVisualStyleBackColor = false;
        Label1().AutoSize = true;
        Label1().BackColor = Color.Transparent;
        Label1().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label1().ForeColor = Color.DarkGray;
        Label1().Location = new Point(14, 16);
        Label1().Name = "Label1";
        Label1().Size = new Size(136, 19);
        Label1().TabIndex = 51;
        Label1().Text = "Internetkapcsolat:";
        Label1().Visible = false;
        af_inet().AutoSize = true;
        af_inet().BackColor = Color.Transparent;
        af_inet().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        af_inet().ForeColor = Color.DarkGray;
        af_inet().Location = new Point(151, 17);
        af_inet().Name = "af_inet";
        af_inet().Size = new Size(96, 19);
        af_inet().TabIndex = 52;
        af_inet().Text = "Kpacsolódva";
        af_inet().Visible = false;
        Label2().AutoSize = true;
        Label2().BackColor = Color.Transparent;
        Label2().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label2().ForeColor = Color.DarkGray;
        Label2().Location = new Point(4, 82);
        Label2().Name = "Label2";
        Label2().Size = new Size(146, 19);
        Label2().TabIndex = 53;
        Label2().Text = "Secureboot állapot:";
        Label2().Visible = false;
        Securebootstatus().AutoSize = true;
        Securebootstatus().BackColor = Color.Transparent;
        Securebootstatus().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Securebootstatus().ForeColor = Color.DarkGray;
        Securebootstatus().Location = new Point(150, 82);
        Securebootstatus().Name = "Securebootstatus";
        Securebootstatus().Size = new Size(107, 19);
        Securebootstatus().TabIndex = 54;
        Securebootstatus().Text = "Letiltva ( OK )";
        Securebootstatus().Visible = false;
        Label4().AutoSize = true;
        Label4().BackColor = Color.Transparent;
        Label4().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label4().ForeColor = Color.DarkGray;
        Label4().Location = new Point(14, 49);
        Label4().Name = "Label4";
        Label4().Size = new Size(135, 19);
        Label4().TabIndex = 55;
        Label4().Text = "FoxComm Licenc:";
        Label4().Visible = false;
        Foxlicencestatus().AutoSize = true;
        Foxlicencestatus().BackColor = Color.Transparent;
        Foxlicencestatus().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Foxlicencestatus().ForeColor = Color.DarkGray;
        Foxlicencestatus().Location = new Point(150, 49);
        Foxlicencestatus().Name = "Foxlicencestatus";
        Foxlicencestatus().Size = new Size(108, 19);
        Foxlicencestatus().TabIndex = 56;
        Foxlicencestatus().Text = "Kis türelmet...";
        Foxlicencestatus().Visible = false;
        Panel1().BackgroundImage = (Image)componentResourceManager.GetObject("Panel1.BackgroundImage");
        Panel1().BackgroundImageLayout = ImageLayout.Stretch;
        Panel1().Controls.Add(PictureBox6());
        Panel1().Controls.Add(Kisturelmet());
        Panel1().Controls.Add(Kerdojel());
        Panel1().Controls.Add(Label1());
        Panel1().Controls.Add(Securebootstatus());
        Panel1().Controls.Add(Foxlicencestatus());
        Panel1().Controls.Add(Initline());
        Panel1().Controls.Add(Label2());
        Panel1().Controls.Add(af_inet());
        Panel1().Controls.Add(Label4());
        Panel1().Location = new Point(134, 392);
        Panel1().Name = "Panel1";
        Panel1().Size = new Size(414, 118);
        Panel1().TabIndex = 57;
        PictureBox6().BackColor = Color.Transparent;
        PictureBox6().Cursor = Cursors.Hand;
        PictureBox6().Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
        PictureBox6().Location = new Point(366, 33);
        PictureBox6().Name = "PictureBox6";
        PictureBox6().Size = new Size(42, 35);
        PictureBox6().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox6().TabIndex = 61;
        PictureBox6().TabStop = false;
        PictureBox6().Visible = false;
        Kisturelmet().AutoSize = true;
        Kisturelmet().BackColor = Color.Transparent;
        Kisturelmet().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Kisturelmet().ForeColor = Color.DarkGray;
        Kisturelmet().Location = new Point(123, 66);
        Kisturelmet().Name = "Kisturelmet";
        Kisturelmet().Size = new Size(193, 19);
        Kisturelmet().TabIndex = 57;
        Kisturelmet().Text = "Előkészítés, kis türelmet...";
        Kerdojel().BackColor = Color.Transparent;
        Kerdojel().Cursor = Cursors.Hand;
        Kerdojel().Image = (Image)componentResourceManager.GetObject("Kerdojel.Image");
        Kerdojel().Location = new Point(313, 70);
        Kerdojel().Name = "Kerdojel";
        Kerdojel().Size = new Size(42, 35);
        Kerdojel().SizeMode = PictureBoxSizeMode.StretchImage;
        Kerdojel().TabIndex = 60;
        Kerdojel().TabStop = false;
        Kerdojel().Visible = false;
        Firebutton().BorderColor = Color.Orange;
        cBlendItems.iColor = new Color[3]
        {
            Color.FromArgb(15, 3, 41),
            Color.FromArgb(34, 4, 99),
            Color.FromArgb(15, 3, 41)
        };
        cBlendItems.iPoint = new float[3] { 0f, 0.4875776f, 1f };
        Firebutton().ColorFillBlend = cBlendItems;
        Firebutton().Corners.All = 5;
        Firebutton().Corners.LowerLeft = 5;
        Firebutton().Corners.LowerRight = 5;
        Firebutton().Corners.UpperLeft = 5;
        Firebutton().Corners.UpperRight = 5;
        Firebutton().DesignerSelected = false;
        Firebutton().DimFactorHover = 20;
        Firebutton().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Firebutton().ForeColor = Color.Silver;
        Firebutton().ImageAlign = ContentAlignment.MiddleLeft;
        Firebutton().ImageIndex = 0;
        Firebutton().ImageSize = new Size(25, 25);
        Firebutton().Location = new Point(193, 523);
        Firebutton().Name = "Firebutton";
        Firebutton().Size = new Size(305, 35);
        Firebutton().TabIndex = 58;
        Firebutton().Tag = "0";
        Firebutton().Text = "START";
        Firebutton().TextImageRelation = TextImageRelation.ImageBeforeText;
        Firebutton().TextShadow = Color.Black;
        Initbar().Location = new Point(9, 10);
        Initbar().Name = "Initbar";
        Initbar().Size = new Size(10, 10);
        Initbar().TabIndex = 59;
        Initbar().Visible = false;
        Panel2().BackgroundImage = (Image)componentResourceManager.GetObject("Panel2.BackgroundImage");
        Panel2().BackgroundImageLayout = ImageLayout.Stretch;
        Panel2().Controls.Add(CButton1());
        Panel2().Controls.Add(CButton2());
        Panel2().Controls.Add(PictureBox1());
        Panel2().Controls.Add(PictureBox3());
        Panel2().Controls.Add(PictureBox2());
        Panel2().Location = new Point(9, 26);
        Panel2().Name = "Panel2";
        Panel2().Size = new Size(10, 12);
        Panel2().TabIndex = 60;
        CButton1().BorderColor = Color.Orange;
        cBlendItems2.iColor = new Color[3]
        {
            Color.FromArgb(15, 3, 41),
            Color.FromArgb(34, 4, 99),
            Color.FromArgb(15, 3, 41)
        };
        cBlendItems2.iPoint = new float[3] { 0f, 0.4875776f, 1f };
        CButton1().ColorFillBlend = cBlendItems2;
        CButton1().Corners.All = 5;
        CButton1().Corners.LowerLeft = 5;
        CButton1().Corners.LowerRight = 5;
        CButton1().Corners.UpperLeft = 5;
        CButton1().Corners.UpperRight = 5;
        CButton1().DesignerSelected = false;
        CButton1().DimFactorHover = 20;
        CButton1().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        CButton1().ForeColor = Color.Silver;
        CButton1().ImageAlign = ContentAlignment.MiddleLeft;
        CButton1().ImageIndex = 0;
        CButton1().ImageSize = new Size(25, 25);
        CButton1().Location = new Point(381, 376);
        CButton1().Name = "CButton1";
        CButton1().Size = new Size(223, 47);
        CButton1().TabIndex = 62;
        CButton1().Text = "Ennek ellenére elindítom! (Haladóknak)";
        CButton1().TextImageRelation = TextImageRelation.ImageBeforeText;
        CButton1().TextShadow = Color.Black;
        CButton2().BorderColor = Color.Orange;
        cBlendItems3.iColor = new Color[3]
        {
            Color.FromArgb(15, 3, 41),
            Color.FromArgb(34, 4, 99),
            Color.FromArgb(15, 3, 41)
        };
        cBlendItems3.iPoint = new float[3] { 0f, 0.4875776f, 1f };
        CButton2().ColorFillBlend = cBlendItems3;
        CButton2().Corners.All = 5;
        CButton2().Corners.LowerLeft = 5;
        CButton2().Corners.LowerRight = 5;
        CButton2().Corners.UpperLeft = 5;
        CButton2().Corners.UpperRight = 5;
        CButton2().DesignerSelected = false;
        CButton2().DimFactorHover = 20;
        CButton2().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        CButton2().ForeColor = Color.Silver;
        CButton2().ImageAlign = ContentAlignment.MiddleLeft;
        CButton2().ImageIndex = 0;
        CButton2().ImageSize = new Size(25, 25);
        CButton2().Location = new Point(34, 376);
        CButton2().Name = "CButton2";
        CButton2().Size = new Size(223, 47);
        CButton2().TabIndex = 61;
        CButton2().Text = "Megértettem";
        CButton2().TextImageRelation = TextImageRelation.ImageBeforeText;
        CButton2().TextShadow = Color.Black;
        PictureBox1().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
        PictureBox1().Location = new Point(18, 22);
        PictureBox1().Name = "PictureBox1";
        PictureBox1().Size = new Size(600, 91);
        PictureBox1().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox1().TabIndex = 3;
        PictureBox1().TabStop = false;
        PictureBox3().Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
        PictureBox3().Location = new Point(18, 119);
        PictureBox3().Name = "PictureBox3";
        PictureBox3().Size = new Size(600, 229);
        PictureBox3().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox3().TabIndex = 5;
        PictureBox3().TabStop = false;
        PictureBox2().Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
        PictureBox2().Location = new Point(18, 451);
        PictureBox2().Name = "PictureBox2";
        PictureBox2().Size = new Size(600, 88);
        PictureBox2().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox2().TabIndex = 4;
        PictureBox2().TabStop = false;
        CheckBox2().AutoSize = true;
        CheckBox2().BackColor = Color.Transparent;
        CheckBox2().Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 238);
        CheckBox2().ForeColor = Color.White;
        CheckBox2().Location = new Point(170, 357);
        CheckBox2().Name = "CheckBox2";
        CheckBox2().Size = new Size(350, 28);
        CheckBox2().TabIndex = 61;
        CheckBox2().Text = "Elfogadom a használati feltételeket";
        CheckBox2().UseVisualStyleBackColor = false;
        CheckBox2().Visible = false;
        PictureBox4().BackColor = Color.Transparent;
        PictureBox4().Cursor = Cursors.Default;
        PictureBox4().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
        PictureBox4().Location = new Point(553, 391);
        PictureBox4().Name = "PictureBox4";
        PictureBox4().Size = new Size(122, 119);
        PictureBox4().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox4().TabIndex = 61;
        PictureBox4().TabStop = false;
        PictureBox5().BackColor = Color.Transparent;
        PictureBox5().Cursor = Cursors.Default;
        PictureBox5().Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
        PictureBox5().Location = new Point(6, 392);
        PictureBox5().Name = "PictureBox5";
        PictureBox5().Size = new Size(122, 119);
        PictureBox5().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox5().TabIndex = 62;
        PictureBox5().TabStop = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        base.ClientSize = new Size(684, 575);
        base.Controls.Add(Panel2());
        base.Controls.Add(PictureBox4());
        base.Controls.Add(CheckBox2());
        base.Controls.Add(Initbar());
        base.Controls.Add(Firebutton());
        base.Controls.Add(Panel1());
        base.Controls.Add(CheckBox1());
        base.Controls.Add(TextBox1());
        base.Controls.Add(PictureBox5());
        DoubleBuffered = true;
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
        base.KeyPreview = true;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "Welcome";
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Üdvözli önt a 2H FoxComm";
        base.TopMost = true;
        ((ISupportInitialize)Initline()).EndInit();
        Panel1().ResumeLayout(performLayout: false);
        Panel1().PerformLayout();
        ((ISupportInitialize)PictureBox6()).EndInit();
        ((ISupportInitialize)Kerdojel()).EndInit();
        Panel2().ResumeLayout(performLayout: false);
        ((ISupportInitialize)PictureBox1()).EndInit();
        ((ISupportInitialize)PictureBox3()).EndInit();
        ((ISupportInitialize)PictureBox2()).EndInit();
        ((ISupportInitialize)PictureBox4()).EndInit();
        ((ISupportInitialize)PictureBox5()).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual TextBox TextBox1()
    {
        return _TextBox1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void TextBox1(TextBox value)
    {
        _TextBox1 = value;
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
    internal virtual CheckBox CheckBox1()
    {
        return _CheckBox1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void CheckBox1(CheckBox value)
    {
        EventHandler value2 = CheckBox1_CheckedChanged;
        CheckBox checkBox = _CheckBox1;
        if (checkBox != null)
        {
            checkBox.CheckedChanged -= value2;
        }
        _CheckBox1 = value;
        checkBox = _CheckBox1;
        if (checkBox != null)
        {
            checkBox.CheckedChanged += value2;
        }
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
    internal virtual Label af_inet()
    {
        return _af_inet;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void af_inet(Label value)
    {
        _af_inet = value;
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
        _Label2 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Securebootstatus()
    {
        return _Securebootstatus;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Securebootstatus(Label value)
    {
        _Securebootstatus = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Label4()
    {
        return _Label4;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Label4(Label value)
    {
        _Label4 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Foxlicencestatus()
    {
        return _Foxlicencestatus;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Foxlicencestatus(Label value)
    {
        _Foxlicencestatus = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Panel Panel1()
    {
        return _Panel1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Panel1(Panel value)
    {
        _Panel1 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual CButton Firebutton()
    {
        return _Firebutton;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Firebutton(CButton value)
    {
        CButton.ClickButtonAreaEventHandler value2 = Firebutton_ClickButtonArea;
        CButton cButton = _Firebutton;
        if (cButton != null)
        {
            cButton.ClickButtonArea -= value2;
        }
        _Firebutton = value;
        cButton = _Firebutton;
        if (cButton != null)
        {
            cButton.ClickButtonArea += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Kisturelmet()
    {
        return _Kisturelmet;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Kisturelmet(Label value)
    {
        _Kisturelmet = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Timer Initialtime()
    {
        return _Initialtime;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Initialtime(Timer value)
    {
        EventHandler value2 = Initialtime_Tick;
        Timer timer = _Initialtime;
        if (timer != null)
        {
            timer.Tick -= value2;
        }
        _Initialtime = value;
        timer = _Initialtime;
        if (timer != null)
        {
            timer.Tick += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual ProgressBar Initbar()
    {
        return _Initbar;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Initbar(ProgressBar value)
    {
        _Initbar = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox Kerdojel()
    {
        return _Kerdojel;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Kerdojel(PictureBox value)
    {
        EventHandler value2 = Kerdojel_Click;
        PictureBox pictureBox = _Kerdojel;
        if (pictureBox != null)
        {
            pictureBox.Click -= value2;
        }
        _Kerdojel = value;
        pictureBox = _Kerdojel;
        if (pictureBox != null)
        {
            pictureBox.Click += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Panel Panel2()
    {
        return _Panel2;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Panel2(Panel value)
    {
        _Panel2 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox PictureBox1()
    {
        return _PictureBox1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void PictureBox1(PictureBox value)
    {
        _PictureBox1 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox PictureBox3()
    {
        return _PictureBox3;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void PictureBox3(PictureBox value)
    {
        _PictureBox3 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox PictureBox2()
    {
        return _PictureBox2;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void PictureBox2(PictureBox value)
    {
        _PictureBox2 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual CButton CButton1
        ()
    {
        return _CButton1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void CButton1(CButton value)
    {
        CButton.ClickButtonAreaEventHandler value2 = CButton1_ClickButtonArea;
        CButton cButton = _CButton1;
        if (cButton != null)
        {
            cButton.ClickButtonArea -= value2;
        }
        _CButton1 = value;
        cButton = _CButton1;
        if (cButton != null)
        {
            cButton.ClickButtonArea += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual CButton CButton2()
    {
        return _CButton2;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void CButton2(CButton value)
    {
        CButton.ClickButtonAreaEventHandler value2 = CButton2_ClickButtonArea;
        CButton cButton = _CButton2;
        if (cButton != null)
        {
            cButton.ClickButtonArea -= value2;
        }
        _CButton2 = value;
        cButton = _CButton2;
        if (cButton != null)
        {
            cButton.ClickButtonArea += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual CheckBox CheckBox2()
    {
        return _CheckBox2;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void CheckBox2(CheckBox value)
    {
        MouseEventHandler value2 = CheckBox2_MouseClick;
        CheckBox checkBox = _CheckBox2;
        if (checkBox != null)
        {
            checkBox.MouseClick -= value2;
        }
        _CheckBox2 = value;
        checkBox = _CheckBox2;
        if (checkBox != null)
        {
            checkBox.MouseClick += value2;
        }
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
    internal virtual PictureBox PictureBox5()
    {
        return _PictureBox5;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void PictureBox5(PictureBox value)
    {
        _PictureBox5 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual PictureBox PictureBox6()
    {
        return _PictureBox6;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void PictureBox6(PictureBox value)
    {
        EventHandler value2 = _2003;
        PictureBox pictureBox = _PictureBox6;
        if (pictureBox != null)
        {
            pictureBox.Click -= value2;
        }
        _PictureBox6 = value;
        pictureBox = _PictureBox6;
        if (pictureBox != null)
        {
            pictureBox.Click += value2;
        }
    }

    private void Form4_Load(object sender, EventArgs e)
    {
        checked
        {
            int num = (int)Math.Round((double)(Screen.PrimaryScreen.Bounds.Width - base.Width) / 2.0);
            int num2 = (int)Math.Round((double)(Screen.PrimaryScreen.Bounds.Height - base.Height) / 2.0);
            base.Location = new Point(num, num2);
            Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            try
            {
                Process[] array = processesByName;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Id != Process.GetCurrentProcess().Id)
                    {
                        MessageBox.Show("A FoxComm már el van indítva!", "FoxComm Already Running!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                }
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
            }
            AdatokLoad.HardwareID(ref CpuID, ref DiskID, ref PartitionID, ref BoardName);
            AdatokLoad.Regadatok(ref Status, ref SerialEnc, ref ViharEnc, ref BarelEnc);
            Initialtime().Start();
            Firebutton().Text = "Használati feltételek elfogadása!";
            Firebutton().BackColor = Color.Crimson;
            Firebutton().Enabled = false;
            CheckBox1().Select();
            _202A();
            _202B();
        }
    }

    private void _202A()
    {
        byte[] bytes = Encoding.UTF8.GetBytes(CpuID + BoardName + DiskID);
        try
        {
            Serial = AdatokLoad.DecryptString(Convert.FromBase64String(SerialEnc), bytes);
            Barel = AdatokLoad.DecryptString(Convert.FromBase64String(BarelEnc), bytes);
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Serial = "00";
            Barel = "00";
            ProjectData.ClearProjectError();
        }
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1().Checked)
        {
            Firebutton().BackColor = Color.Lime;
            Firebutton().Enabled = true;
            Firebutton().Text = "2H ETM FoxComm Indítása";
        }
        else
        {
            Firebutton().Text = "Használati feltételek elfogadása!";
            Firebutton().BackColor = Color.Crimson;
            Firebutton().Enabled = false;
        }
    }

    private void CheckBox2_MouseClick(object sender, EventArgs e)
    {
        if (Kerdojel().Visible)
        {
            CheckBox2().Checked = false;
            Interaction.MsgBox("Az ellenőrzés során hibákat találtunk! Javítsa ki ezeket, majd próbálja újra!");
        }
    }

    public async void _202B()
    {
        using (Ping ping = new Ping())
        {
            try
            {
                if ((await ping.SendPingAsync("google.com")).Status == IPStatus.Success)
                {
                    af_inet().Text = "Kpacsolódva";
                    af_inet().ForeColor = Color.DarkGreen;
                    InternetConnection = true;
                    _202C();
                }
                else
                {
                    af_inet().Text = "Nincs kapocsolat";
                    af_inet().ForeColor = Color.DarkRed;
                    InternetConnection = false;
                }
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                af_inet().Text = "Nincs kapocsolat";
                af_inet().ForeColor = Color.DarkRed;
                InternetConnection = false;
                ProjectData.ClearProjectError();
            }
        }
        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SecureBoot\\State", writable: true);
        if (registryKey != null)
        {
            SecureBootStatus = Conversions.ToString(RuntimeHelpers.GetObjectValue(registryKey.GetValue("UEFISecureBootEnabled")));
        }
        else
        {
            SecureBootStatus = "nincs";
        }
        if (Operators.CompareString(SecureBootStatus, "0", TextCompare: false) == 0)
        {
            SecureBootDisabled = true;
            Securebootstatus().Text = "Letiltva ( OK )";
            Securebootstatus().ForeColor = Color.DarkGreen;
        }
        else if (Operators.CompareString(SecureBootStatus, "nincs", TextCompare: false) == 0)
        {
            SecureBootDisabled = true;
            Securebootstatus().Text = "MBR fájlrendszer (NSB)";
            Securebootstatus().ForeColor = Color.DarkGreen;
        }
        else
        {
            SecureBootDisabled = false;
            Securebootstatus().Text = "Bekapcsolva (Hiba)";
            Securebootstatus().ForeColor = Color.DarkRed;
        }
    }

    private async void _202C()
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
                        Foxlicencestatus().Text = "Nincs aktív licenc";
                        Foxlicencestatus().ForeColor = Color.DarkRed;
                        CheckBox1().Enabled = false;
                        CheckBox2().Enabled = false;
                        Firebutton().Enabled = false;
                    }
                    if (((double)val2.StatusCode == Conversions.ToDouble("504")) | Conversions.ToBoolean("500"))
                    {
                        Foxlicencestatus().Text = "A Szerver karbantartás alatt!";
                        Foxlicencestatus().ForeColor = Color.DarkOrange;
                        CheckBox1().Enabled = false;
                        CheckBox2().Enabled = false;
                        Firebutton().Enabled = false;
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("403"))
                    {
                        Foxlicencestatus().Text = "Hibás lekérdezés";
                        Foxlicencestatus().ForeColor = Color.DarkOrange;
                        CheckBox1().Enabled = false;
                        CheckBox2().Enabled = false;
                        Firebutton().Enabled = false;
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("401"))
                    {
                        Foxlicencestatus().Text = "Nincs aktív licenc";
                        Foxlicencestatus().ForeColor = Color.DarkRed;
                        CheckBox1().Enabled = false;
                        CheckBox2().Enabled = false;
                        Firebutton().Enabled = false;
                    }
                    if ((double)val2.StatusCode == Conversions.ToDouble("200"))
                    {
                        HttpContent content = val2.Content;
                        try
                        {
                            object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(content.ReadAsStringAsync().Result));
                            Status = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "status" }, null)));
                        }
                        finally
                        {
                            ((IDisposable)content)?.Dispose();
                        }
                        if (Operators.CompareString(Status, "2", TextCompare: false) == 0)
                        {
                            Foxlicencestatus().Text = "FoxComm Licenc Letiltva";
                            Foxlicencestatus().ForeColor = Color.DarkRed;
                        }
                        else
                        {
                            Foxlicencestatus().Text = "FoxComm Licenc aktív";
                            Foxlicencestatus().ForeColor = Color.DarkGreen;
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

    private void Initialtime_Tick(object sender, EventArgs e)
    {
        Initialtime().Interval = 50;
        Initbar().Increment(1);
        _ = Initbar().Value;
        _ = 50;
        if (Initbar().Value != 100)
        {
            return;
        }
        Initline().Visible = false;
        Kisturelmet().Visible = false;
        Initialtime().Stop();
        Label1().Visible = true;
        Label4().Visible = true;
        Label2().Visible = true;
        af_inet().Visible = true;
        Foxlicencestatus().Visible = true;
        Securebootstatus().Visible = true;
        if (SecureBootDisabled & InternetConnection)
        {
            if ((Operators.CompareString(Foxlicencestatus().Text, "FoxComm Licenc aktív", TextCompare: false) == 0) | (Operators.CompareString(Foxlicencestatus().Text, "Nincs aktív licenc", TextCompare: false) == 0))
            {
                CheckBox1().Enabled = true;
            }
        }
        else
        {
            CheckBox2().Visible = true;
        }
        if (Operators.CompareString(Foxlicencestatus().Text, "A Szerver karbantartás alatt!", TextCompare: false) == 0)
        {
            BackColor = Color.Red;
            Text = "Szerver karbantartás! A Fox nem indítható el! Próbálja később!";
            PictureBox6().Visible = true;
            Interaction.MsgBox("A 2H Szerverek nem elérhetők, karbantartás miatt!\r\nA licence ellenőrzése nélkül a FoxComm rendszer nem indítható el!\r\n\r\nPróbálja később az indítást!\r\nHa a hiba tartósan fennáll, hívja a forgalmazót!");
        }
        if (Operators.CompareString(SecureBootStatus, "0", TextCompare: false) != 0 && Operators.CompareString(SecureBootStatus, "nincs", TextCompare: false) != 0)
        {
            Kerdojel().Visible = true;
        }
    }

    private void Kerdojel_Click(object sender, EventArgs e)
    {
        Panel2().Visible = true;
        Panel2().Location = new Point(23, 10);
        Panel2().Size = new Size(636, 557);
    }

    private void CButton2_ClickButtonArea(object sender, MouseEventArgs e)
    {
        Panel2().Visible = false;
    }

    private void CButton1_ClickButtonArea(object sender, MouseEventArgs e)
    {
        if (Operators.CompareString(af_inet().Text, "Kpacsolódva", TextCompare: false) == 0)
        {
            CheckBox1().Enabled = true;
            Panel2().Visible = false;
            CheckBox2().Visible = false;
            if (Operators.CompareString(Status, "2", TextCompare: false) == 0)
            {
                CheckBox1().Enabled = false;
                CheckBox2().Enabled = false;
                Firebutton().Enabled = false;
                Foxlicencestatus().Text = "FoxComm Licenc Letiltva";
                Foxlicencestatus().ForeColor = Color.DarkRed;
            }
            else
            {
                Foxlicencestatus().Text = "FoxComm Licenc aktív";
                Foxlicencestatus().ForeColor = Color.DarkGreen;
            }
        }
        else
        {
            if (Operators.CompareString(Status, "2", TextCompare: false) == 0)
            {
                CheckBox1().Enabled = false;
                CheckBox2().Enabled = false;
                Firebutton().Enabled = false;
                Foxlicencestatus().Text = "FoxComm Licenc Letiltva";
                Foxlicencestatus().ForeColor = Color.DarkRed;
            }
            else
            {
                Foxlicencestatus().Text = "FoxComm Licenc aktív";
                Foxlicencestatus().ForeColor = Color.DarkGreen;
            }
            CheckBox1().Enabled = false;
            Interaction.MsgBox("Kapcsolódjon az internethez a folytatáshoz!");
        }
    }

    private void Firebutton_ClickButtonArea(object sender, MouseEventArgs e)
    {
        _202D();
    }

    private void _2003(object sender, EventArgs e)
    {
        Interaction.MsgBox("A 2H Szerverek nem elérhetők, karbantartás miatt!\r\nA licence ellenőrzése nélkül a FoxComm rendszer nem indítható el!\r\n\r\nPróbálja később az indítást!\r\nHa a hiba tartósan fennáll, hívja a forgalmazót!");
    }

    private void _202D()
    {
        if (Operators.CompareString(Status, "0", TextCompare: false) == 0)
        {
            Hide();
            MyProject.Forms.Form1().Show();
        }
        else if (Operators.CompareString(Status, "1", TextCompare: false) == 0)
        {
            Hide();
            MyProject.Forms.Form2().Show();
        }
        else
        {
            Application.Exit();
        }
    }

    private void Form4_KeyDown(object sender, KeyEventArgs e)
    {
        if ((e.KeyCode == Keys.F8) & e.Control & e.Shift)
        {
            int num = (int)MessageBox.Show("Szeretnéd törölni az összes Fox-licenc adatot és FoxComm beállítást?\r\n\r\nFIGYELEM!! Ez a művelet nem vonható vissza!", "2H FoxComm - Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (num == 6)
            {
                DeleteData();
            }
            else
            {
                _ = 7;
            }
        }
    }

    private void DeleteData()
    {
        string name = "SOFTWARE\\Masbate\\License";
        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, writable: true);
        registryKey.SetValue("Status", "0", RegistryValueKind.DWord);
        registryKey.SetValue("Serial", "0", RegistryValueKind.String);
        registryKey.SetValue("Vihar", "0", RegistryValueKind.String);
        registryKey.SetValue("Barel", "0", RegistryValueKind.String);
        Interaction.MsgBox("Minden FoxComm Adat törölve! (Ez a Windows többi szolgáltatását nem érinti!) A FoxComm most újraindul!");
        Application.Restart();
    }
}
