using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;

[DesignerGenerated]
public class Form1 : Form
{
    private IContainer components;

    [CompilerGenerated]
    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [CompilerGenerated]
    [AccessedThroughProperty("magickeyinput")]
    private TextBox _magickeyinput;

    [CompilerGenerated]
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [CompilerGenerated]
    [AccessedThroughProperty("usernuminput")]
    private TextBox _usernuminput;

    [CompilerGenerated]
    [AccessedThroughProperty("maillabelle")]
    private Label _maillabelle;

    [CompilerGenerated]
    [AccessedThroughProperty("liclcabelle")]
    private Label _liclcabelle;

    [CompilerGenerated]
    [AccessedThroughProperty("licencekeyinput")]
    private TextBox _licencekeyinput;

    [CompilerGenerated]
    [AccessedThroughProperty("Firebutton")]
    private CButton _Firebutton;

    [CompilerGenerated]
    [AccessedThroughProperty("Initline")]
    private PictureBox _Initline;

    [CompilerGenerated]
    [AccessedThroughProperty("Kisturelmet")]
    private Label _Kisturelmet;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [CompilerGenerated]
    [AccessedThroughProperty("Label10")]
    private Label _Label10;

    [CompilerGenerated]
    [AccessedThroughProperty("ShowedHWID")]
    private Label _ShowedHWID;

    [CompilerGenerated]
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;

    [CompilerGenerated]
    [AccessedThroughProperty("Panel3")]
    private Panel _Panel3;

    [CompilerGenerated]
    [AccessedThroughProperty("CButton3")]
    private CButton _CButton3;

    [CompilerGenerated]
    [AccessedThroughProperty("CButton4")]
    private CButton _CButton4;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;

    [CompilerGenerated]
    [AccessedThroughProperty("Chrono")]
    private Timer _Chrono;

    [CompilerGenerated]
    [AccessedThroughProperty("Bar")]
    private ProgressBar _Bar;

    [CompilerGenerated]
    [AccessedThroughProperty("Reinstalldetected")]
    private Label _Reinstalldetected;

    [CompilerGenerated]
    [AccessedThroughProperty("SigneturedAuth")]
    private TextBox _SigneturedAuth;

    [CompilerGenerated]
    [AccessedThroughProperty("Beolvasotteljesnev")]
    private Label _Beolvasotteljesnev;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;

    private string CpuID;

    private string CpuID1;

    private string DiskID;

    private string DiskID1;
    
    private string PartitionID1;

    private string BoardID;

    private string BoardID1;

    private string Status;

    private string SerialEnc;

    private string ViharEnc;

    private string BarelEnc;

    private string Barel;

    private string Vihar;

    private string Usernumma;

    private string DateTime;

    private string ReinstallDetected;

    private string Hwid;
    
    private string Serial;

    public Form1()
    {
        base.Load += Form1_Load;
        InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && CpuID != null)
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
        cBlendItems cBlendItems = new cBlendItems();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
        cBlendItems cBlendItems2 = new cBlendItems();
        cBlendItems cBlendItems3 = new cBlendItems();
        Label2(new Label());
        magickeyinput(new TextBox());
        Label1(new Label());
        usernuminput(new TextBox());
        maillabelle(new Label());
        liclcabelle(new Label());
        licencekeyinput(new TextBox());
        Firebutton(new CButton());
        Initline(new PictureBox());
        Kisturelmet(new Label());
        PictureBox1(new PictureBox());
        Label10(new Label());
        ShowedHWID(new Label());
        Panel2(new Panel());
        Beolvasotteljesnev(new Label());
        SigneturedAuth(new TextBox());
        Panel3(new Panel());
        CButton3(new CButton());
        CButton4(new CButton());
        PictureBox4(new PictureBox());
        PictureBox5(new PictureBox());
        PictureBox2(new PictureBox());
        Chrono(new Timer(components));
        Bar(new ProgressBar());
        Reinstalldetected(new Label());
        PictureBox3(new PictureBox());
        ((ISupportInitialize)Initline()).BeginInit();
        ((ISupportInitialize)PictureBox1()).BeginInit();
        Panel2().SuspendLayout();
        Panel3().SuspendLayout();
        ((ISupportInitialize)PictureBox4()).BeginInit();
        ((ISupportInitialize)PictureBox5()).BeginInit();
        ((ISupportInitialize)PictureBox2()).BeginInit();
        ((ISupportInitialize)PictureBox3()).BeginInit();
        SuspendLayout();
        Label2().BackColor = Color.Transparent;
        Label2().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label2().ForeColor = Color.White;
        Label2().Location = new Point(32, 198);
        Label2().Name = "Label2";
        Label2().Size = new Size(643, 18);
        Label2().TabIndex = 121;
        Label2().Text = "Azonosító token";
        Label2().TextAlign = ContentAlignment.MiddleCenter;
        magickeyinput().BackColor = Color.Black;
        magickeyinput().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
        magickeyinput().ForeColor = Color.PaleGreen;
        magickeyinput().Location = new Point(31, 219);
        magickeyinput().Multiline = true;
        magickeyinput().Name = "magickeyinput";
        magickeyinput().Size = new Size(643, 60);
        magickeyinput().TabIndex = 120;
        magickeyinput().TextAlign = HorizontalAlignment.Center;
        Label1().BackColor = Color.Transparent;
        Label1().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label1().ForeColor = Color.White;
        Label1().Location = new Point(157, 137);
        Label1().Name = "Label1";
        Label1().Size = new Size(394, 18);
        Label1().TabIndex = 119;
        Label1().Text = "Vásárlói azonosító";
        Label1().TextAlign = ContentAlignment.MiddleCenter;
        usernuminput().BackColor = Color.Black;
        usernuminput().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
        usernuminput().ForeColor = Color.Coral;
        usernuminput().Location = new Point(157, 158);
        usernuminput().Name = "usernuminput";
        usernuminput().Size = new Size(394, 21);
        usernuminput().TabIndex = 118;
        usernuminput().TextAlign = HorizontalAlignment.Center;
        maillabelle().BackColor = Color.Transparent;
        maillabelle().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        maillabelle().ForeColor = Color.White;
        maillabelle().Location = new Point(157, 21);
        maillabelle().Name = "maillabelle";
        maillabelle().Size = new Size(394, 18);
        maillabelle().TabIndex = 116;
        maillabelle().Text = "Az ön teljes neve";
        maillabelle().TextAlign = ContentAlignment.MiddleCenter;
        liclcabelle().BackColor = Color.Transparent;
        liclcabelle().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        liclcabelle().ForeColor = Color.White;
        liclcabelle().Location = new Point(157, 81);
        liclcabelle().Name = "liclcabelle";
        liclcabelle().Size = new Size(394, 18);
        liclcabelle().TabIndex = 114;
        liclcabelle().Text = "Termékkulcs";
        liclcabelle().TextAlign = ContentAlignment.MiddleCenter;
        licencekeyinput().BackColor = Color.Black;
        licencekeyinput().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
        licencekeyinput().ForeColor = Color.Plum;
        licencekeyinput().Location = new Point(157, 102);
        licencekeyinput().Name = "licencekeyinput";
        licencekeyinput().Size = new Size(394, 21);
        licencekeyinput().TabIndex = 112;
        licencekeyinput().TextAlign = HorizontalAlignment.Center;
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
        Firebutton().Location = new Point(201, 301);
        Firebutton().Name = "Firebutton";
        Firebutton().Size = new Size(305, 39);
        Firebutton().TabIndex = 130;
        Firebutton().Tag = "0";
        Firebutton().Text = "Aktiválás megkezdése";
        Firebutton().TextImageRelation = TextImageRelation.ImageBeforeText;
        Firebutton().TextShadow = Color.Black;
        Initline().BackColor = Color.Transparent;
        Initline().Image = (Image)componentResourceManager.GetObject("Initline.Image");
        Initline().Location = new Point(342, 497);
        Initline().Name = "Initline";
        Initline().Size = new Size(305, 31);
        Initline().SizeMode = PictureBoxSizeMode.StretchImage;
        Initline().TabIndex = 131;
        Initline().TabStop = false;
        Initline().Visible = false;
        Kisturelmet().BackColor = Color.Transparent;
        Kisturelmet().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Kisturelmet().ForeColor = Color.DarkGray;
        Kisturelmet().Location = new Point(342, 535);
        Kisturelmet().Name = "Kisturelmet";
        Kisturelmet().Size = new Size(305, 19);
        Kisturelmet().TabIndex = 132;
        Kisturelmet().Text = "Kapcsolódás a 2H Szerverhez...";
        Kisturelmet().TextAlign = ContentAlignment.MiddleCenter;
        Kisturelmet().Visible = false;
        PictureBox1().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PictureBox1().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
        PictureBox1().Location = new Point(20, 24);
        PictureBox1().Name = "PictureBox1";
        PictureBox1().Size = new Size(741, 266);
        PictureBox1().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox1().TabIndex = 136;
        PictureBox1().TabStop = false;
        Label10().AutoSize = true;
        Label10().BackColor = Color.Transparent;
        Label10().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label10().ForeColor = Color.White;
        Label10().Location = new Point(1, 3);
        Label10().Name = "Label10";
        Label10().Size = new Size(133, 18);
        Label10().TabIndex = 123;
        Label10().Text = "Számítógép HWID:";
        ShowedHWID().AutoSize = true;
        ShowedHWID().BackColor = Color.Transparent;
        ShowedHWID().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        ShowedHWID().ForeColor = Color.Gray;
        ShowedHWID().Location = new Point(132, 3);
        ShowedHWID().Name = "ShowedHWID";
        ShowedHWID().Size = new Size(33, 18);
        ShowedHWID().TabIndex = 134;
        ShowedHWID().Text = "IDX";
        Panel2().BackColor = Color.Transparent;
        Panel2().BackgroundImage = (Image)componentResourceManager.GetObject("Panel2.BackgroundImage");
        Panel2().BackgroundImageLayout = ImageLayout.Stretch;
        Panel2().Controls.Add(Beolvasotteljesnev());
        Panel2().Controls.Add(magickeyinput());
        Panel2().Controls.Add(licencekeyinput());
        Panel2().Controls.Add(liclcabelle());
        Panel2().Controls.Add(maillabelle());
        Panel2().Controls.Add(Firebutton());
        Panel2().Controls.Add(usernuminput());
        Panel2().Controls.Add(Label1());
        Panel2().Controls.Add(Label2());
        Panel2().Controls.Add(SigneturedAuth());
        Panel2().Location = new Point(140, 95);
        Panel2().Name = "Panel2";
        Panel2().Size = new Size(705, 366);
        Panel2().TabIndex = 135;
        Panel2().Visible = false;
        Beolvasotteljesnev().BackColor = Color.Transparent;
        Beolvasotteljesnev().Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Beolvasotteljesnev().ForeColor = Color.Goldenrod;
        Beolvasotteljesnev().Location = new Point(74, 41);
        Beolvasotteljesnev().Name = "Beolvasotteljesnev";
        Beolvasotteljesnev().Size = new Size(564, 31);
        Beolvasotteljesnev().TabIndex = 142;
        Beolvasotteljesnev().Text = "- - - ";
        Beolvasotteljesnev().TextAlign = ContentAlignment.MiddleCenter;
        SigneturedAuth().BackColor = Color.Black;
        SigneturedAuth().Enabled = false;
        SigneturedAuth().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
        SigneturedAuth().ForeColor = Color.PaleGreen;
        SigneturedAuth().Location = new Point(31, 219);
        SigneturedAuth().Multiline = true;
        SigneturedAuth().Name = "SigneturedAuth";
        SigneturedAuth().Size = new Size(643, 60);
        SigneturedAuth().TabIndex = 131;
        SigneturedAuth().Text = componentResourceManager.GetString("SigneturedAuth.Text");
        SigneturedAuth().TextAlign = HorizontalAlignment.Center;
        SigneturedAuth().Visible = false;
        Panel3().BackColor = Color.Transparent;
        Panel3().BackgroundImage = (Image)componentResourceManager.GetObject("Panel3.BackgroundImage");
        Panel3().BackgroundImageLayout = ImageLayout.Stretch;
        Panel3().Controls.Add(CButton3());
        Panel3().Controls.Add(CButton4());
        Panel3().Controls.Add(PictureBox1());
        Panel3().Location = new Point(100, 92);
        Panel3().Name = "Panel3";
        Panel3().Size = new Size(777, 375);
        Panel3().TabIndex = 136;
        CButton3().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        CButton3().BorderColor = Color.Orange;
        cBlendItems2.iColor = new Color[3]
        {
            Color.FromArgb(15, 3, 41),
            Color.FromArgb(128, 0, 0),
            Color.FromArgb(15, 3, 41)
        };
        cBlendItems2.iPoint = new float[3] { 0f, 0.4875776f, 1f };
        CButton3().ColorFillBlend = cBlendItems2;
        CButton3().Corners.All = 5;
        CButton3().Corners.LowerLeft = 5;
        CButton3().Corners.LowerRight = 5;
        CButton3().Corners.UpperLeft = 5;
        CButton3().Corners.UpperRight = 5;
        CButton3().DesignerSelected = false;
        CButton3().DimFactorHover = 20;
        CButton3().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        CButton3().ForeColor = Color.Silver;
        CButton3().ImageAlign = ContentAlignment.MiddleLeft;
        CButton3().ImageIndex = 0;
        CButton3().ImageSize = new Size(25, 25);
        CButton3().Location = new Point(45, 315);
        CButton3().Name = "CButton3";
        CButton3().Size = new Size(305, 39);
        CButton3().TabIndex = 138;
        CButton3().Tag = "0";
        CButton3().Text = "Nem értek egyet! (kilépés)";
        CButton3().TextImageRelation = TextImageRelation.ImageBeforeText;
        CButton3().TextShadow = Color.Black;
        CButton4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CButton4().BorderColor = Color.Orange;
        cBlendItems3.iColor = new Color[3]
        {
            Color.FromArgb(15, 3, 41),
            Color.FromArgb(34, 4, 99),
            Color.FromArgb(15, 3, 41)
        };
        cBlendItems3.iPoint = new float[3] { 0f, 0.4875776f, 1f };
        CButton4().ColorFillBlend = cBlendItems3;
        CButton4().Corners.All = 5;
        CButton4().Corners.LowerLeft = 5;
        CButton4().Corners.LowerRight = 5;
        CButton4().Corners.UpperLeft = 5;
        CButton4().Corners.UpperRight = 5;
        CButton4().DesignerSelected = false;
        CButton4().DimFactorHover = 20;
        CButton4().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
        CButton4().ForeColor = Color.Silver;
        CButton4().ImageAlign = ContentAlignment.MiddleLeft;
        CButton4().ImageIndex = 0;
        CButton4().ImageSize = new Size(25, 25);
        CButton4().Location = new Point(429, 315);
        CButton4().Name = "CButton4";
        CButton4().Size = new Size(305, 39);
        CButton4().TabIndex = 137;
        CButton4().Tag = "0";
        CButton4().Text = "Megértettem! Folytathatjuk!";
        CButton4().TextImageRelation = TextImageRelation.ImageBeforeText;
        CButton4().TextShadow = Color.Black;
        PictureBox4().BackColor = Color.Transparent;
        PictureBox4().Cursor = Cursors.Default;
        PictureBox4().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
        PictureBox4().Location = new Point(868, 442);
        PictureBox4().Name = "PictureBox4";
        PictureBox4().Size = new Size(109, 93);
        PictureBox4().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox4().TabIndex = 137;
        PictureBox4().TabStop = false;
        PictureBox5().BackColor = Color.Transparent;
        PictureBox5().Cursor = Cursors.Default;
        PictureBox5().Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
        PictureBox5().Location = new Point(3, 442);
        PictureBox5().Name = "PictureBox5";
        PictureBox5().Size = new Size(109, 93);
        PictureBox5().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox5().TabIndex = 138;
        PictureBox5().TabStop = false;
        PictureBox2().BackColor = Color.Transparent;
        PictureBox2().Cursor = Cursors.Default;
        PictureBox2().Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
        PictureBox2().Location = new Point(371, 7);
        PictureBox2().Name = "PictureBox2";
        PictureBox2().Size = new Size(244, 47);
        PictureBox2().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox2().TabIndex = 139;
        PictureBox2().TabStop = false;
        Bar().Location = new Point(988, 12);
        Bar().Name = "Bar";
        Bar().Size = new Size(10, 10);
        Bar().TabIndex = 140;
        Bar().Visible = false;
        Reinstalldetected().BackColor = Color.Transparent;
        Reinstalldetected().Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Reinstalldetected().ForeColor = Color.Orange;
        Reinstalldetected().Location = new Point(125, 469);
        Reinstalldetected().Name = "Reinstalldetected";
        Reinstalldetected().Size = new Size(738, 31);
        Reinstalldetected().TabIndex = 141;
        Reinstalldetected().Text = "Azonosított licenc! A számítógépet felismertük! Újratelepítés észlelve! Üdvözöljük ismét!";
        Reinstalldetected().TextAlign = ContentAlignment.MiddleCenter;
        Reinstalldetected().Visible = false;
        PictureBox3().BackColor = Color.Transparent;
        PictureBox3().Cursor = Cursors.Default;
        PictureBox3().Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
        PictureBox3().Location = new Point(240, 50);
        PictureBox3().Name = "PictureBox3";
        PictureBox3().Size = new Size(509, 47);
        PictureBox3().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox3().TabIndex = 142;
        PictureBox3().TabStop = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
        base.ClientSize = new Size(979, 562);
        base.Controls.Add(PictureBox2());
        base.Controls.Add(Reinstalldetected());
        base.Controls.Add(Bar());
        base.Controls.Add(Panel3());
        base.Controls.Add(Panel2());
        base.Controls.Add(ShowedHWID());
        base.Controls.Add(Kisturelmet());
        base.Controls.Add(Initline());
        base.Controls.Add(Label10());
        base.Controls.Add(PictureBox4());
        base.Controls.Add(PictureBox5());
        base.Controls.Add(PictureBox3());
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.Name = "Licencing";
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "2H FoxComm - Licencelés";
        ((ISupportInitialize)Initline()).EndInit();
        ((ISupportInitialize)PictureBox1()).EndInit();
        Panel2().ResumeLayout(performLayout: false);
        Panel2().PerformLayout();
        Panel3().ResumeLayout(performLayout: false);
        ((ISupportInitialize)PictureBox4()).EndInit();
        ((ISupportInitialize)PictureBox5()).EndInit();
        ((ISupportInitialize)PictureBox2()).EndInit();
        ((ISupportInitialize)PictureBox3()).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
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
    internal virtual TextBox magickeyinput()
    {
        return _magickeyinput;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void magickeyinput(TextBox value)
    {
        MouseEventHandler value2 = magickeyinput_MouseClick;
        TextBox textBox = _magickeyinput;
        if (textBox != null)
        {
            textBox.MouseClick -= value2;
        }
        _magickeyinput = value;
        textBox = _magickeyinput;
        if (textBox != null)
        {
            textBox.MouseClick += value2;
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
    internal virtual TextBox usernuminput()
    {
        return _usernuminput;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void usernuminput(TextBox value)
    {
        MouseEventHandler value2 = usernuminput_MouseClick;
        TextBox textBox = _usernuminput;
        if (textBox != null)
        {
            textBox.MouseClick -= value2;
        }
        _usernuminput = value;
        textBox = _usernuminput;
        if (textBox != null)
        {
            textBox.MouseClick += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label maillabelle()
    {
        return _maillabelle;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void maillabelle(Label value)
    {
        _maillabelle = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label liclcabelle()
    {
        return _liclcabelle;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void liclcabelle(Label value)
    {
        _liclcabelle = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual TextBox licencekeyinput()
    {
        return _licencekeyinput;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void licencekeyinput(TextBox value)
    {
        MouseEventHandler value2 = licencekeyinput_MouseClick;
        TextBox textBox = _licencekeyinput;
        if (textBox != null)
        {
            textBox.MouseClick -= value2;
        }
        _licencekeyinput = value;
        textBox = _licencekeyinput;
        if (textBox != null)
        {
            textBox.MouseClick += value2;
        }
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
    internal virtual Label Label10()
    {
        return _Label10;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Label10(Label value)
    {
        _Label10 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label ShowedHWID()
    {
        return _ShowedHWID;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void ShowedHWID(Label value)
    {
        _ShowedHWID = value;
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
    internal virtual Panel Panel3()
    {
        return _Panel3;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Panel3(Panel value)
    {
        _Panel3 = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual CButton CButton3()
    {
        return _CButton3;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void CButton3(CButton value)
    {
        CButton.ClickButtonAreaEventHandler value2 = CButton3_ClickButtonArea;
        CButton cButton = _CButton3;
        if (cButton != null)
        {
            cButton.ClickButtonArea -= value2;
        }
        _CButton3 = value;
        cButton = _CButton3;
        if (cButton != null)
        {
            cButton.ClickButtonArea += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual CButton CButton4()
    {
        return _CButton4;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void CButton4(CButton value)
    {
        CButton.ClickButtonAreaEventHandler value2 = _CButton4_ClickButtonArea;
        CButton cButton = _CButton4;
        if (cButton != null)
        {
            cButton.ClickButtonArea -= value2;
        }
        _CButton4 = value;
        cButton = _CButton4;
        if (cButton != null)
        {
            cButton.ClickButtonArea += value2;
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
    internal virtual Timer Chrono()
    {
        return _Chrono;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Chrono(Timer value)
    {
        EventHandler value2 = Chrono_Tick;
        Timer timer = _Chrono;
        if (timer != null)
        {
            timer.Tick -= value2;
        }
        _Chrono = value;
        timer = _Chrono;
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
    internal virtual Label Reinstalldetected()
    {
        return _Reinstalldetected;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Reinstalldetected(Label value)
    {
        _Reinstalldetected = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual TextBox SigneturedAuth()
    {
        return _SigneturedAuth;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void SigneturedAuth(TextBox value)
    {
        _SigneturedAuth = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Beolvasotteljesnev()
    {
        return _Beolvasotteljesnev;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Beolvasotteljesnev(Label value)
    {
        _Beolvasotteljesnev = value;
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

    private void Form1_Load(object sender, EventArgs e)
    {
        Panel3().Size = new Size(777, 375);
        Panel3().Location = new Point(100, 92);
        DateTime = Conversions.ToString(DateAndTime.Now);
        AdatokLoad.HardwareID(ref CpuID1, ref DiskID1, ref PartitionID1, ref BoardID1);
        AdatokLoad.Regadatok(ref Status, ref SerialEnc, ref ViharEnc, ref BarelEnc);
        Hwid = PartitionID1 + CpuID1;
        _202C();
        _202B();
    }

    private void _202B()
    {
        if (Hwid.Length > 15)
        {
            ShowedHWID().Text = Hwid.Substring(0, 15);
        }
        else
        {
            ShowedHWID().Text = Hwid;
        }
    }

    private void _202C()
    {
        byte[] bytes = Encoding.UTF8.GetBytes(CpuID1 + BoardID1 + DiskID1);
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

    private void Firebutton_ClickButtonArea(object sender, MouseEventArgs e)
    {
        checkInput();
        disableInput();
        Firebutton().Enabled = false;
    }

    private void CButton3_ClickButtonArea(object sender, MouseEventArgs e)
    {
        Application.Exit();
    }

    private void licencekeyinput_MouseClick(object sender, EventArgs e)
    {
        licencekeyinput().Text = "";
    }

    private void usernuminput_MouseClick(object sender, EventArgs e)
    {
        usernuminput().Text = "";
    }

    private void magickeyinput_MouseClick(object sender, EventArgs e)
    {
        magickeyinput().Text = "";
    }

    private void disableInput()
    {
        licencekeyinput().Enabled = false;
        usernuminput().Enabled = false;
        magickeyinput().Enabled = false;
    }

    private void enableInput()
    {
        licencekeyinput().Enabled = true;
        usernuminput().Enabled = true;
        magickeyinput().Enabled = true;
    }

    private void checkInput()
    {
        if (Operators.CompareString(licencekeyinput().Text, null, TextCompare: false) == 0)
        {
            MessageBox.Show("A Licenckulcs megadása kötelező! A mező nem lehet üres!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Firebutton().Enabled = true;
            enableInput();
        }
        else if (Operators.CompareString(usernuminput().Text, null, TextCompare: false) == 0)
        {
            MessageBox.Show("A vásárlóazonosító megadása kötelező! A mező nem lehet üres!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Firebutton().Enabled = true;
            enableInput();
        }
        else if (Operators.CompareString(magickeyinput().Text, null, TextCompare: false) == 0)
        {
            MessageBox.Show("Az azonosító token megadása kötelező! A mező nem lehet üres!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Firebutton().Enabled = true;
            enableInput();
        }
        else
        {
            Chrono().Start();
        }
    }

    private void Chrono_Tick(object sender, EventArgs e)
    {
        Chrono().Interval = 100;
        Bar().Increment(1);
        _ = Bar().Value;
        _ = 1;
        if (Bar().Value == 3)
        {
            Kisturelmet().Visible = true;
            Initline().Visible = true;
            Kisturelmet().Text = "Kapcsolódás a 2H kiszolgálóhoz...";
        }
        if (Bar().Value == 10)
        {
            _2032();
            Kisturelmet().Text = "Licencadatok ellenőrzése...";
        }
        if (Bar().Value == 30)
        {
            Kisturelmet().Text = "HWID beküldése...";
        }
        if (Bar().Value == 40)
        {
            Kisturelmet().Text = "HWID beküldése...";
        }
        if (Bar().Value == 50)
        {
            Kisturelmet().Text = "Válaszra várva...";
            if (Operators.CompareString(ReinstallDetected, "1", TextCompare: false) == 0)
            {
                Reinstalldetected().Visible = true;
            }
        }
        if (Bar().Value == 70)
        {
            Kisturelmet().Text = "Feldolgozás...";
        }
        if (Bar().Value == 70)
        {
            Kisturelmet().Text = "Zamboanga művelet indul...";
        }
        if (Bar().Value == 100)
        {
            Chrono().Stop();
            Kisturelmet().Visible = false;
            Initline().Visible = false;
            MyProject.Forms.Form3().Show();
            Hide();
        }
    }

    private void _CButton4_ClickButtonArea(object sender, MouseEventArgs e)
    {
        Panel3().Visible = false;
        Panel2().Visible = true;
    }

    private void _2032()
    {
        try
        {
            string text = string.Format("https://dimitris.masbate.hu/Checklua/Serlod?Serl={0}", licencekeyinput().Text);
            HttpClient val = new HttpClient();
            try
            {
                ((HttpHeaders)val.DefaultRequestHeaders).Add("Authorization", "Bearer " + magickeyinput().Text);
                HttpResponseMessage result = val.GetAsync(text).Result;
                try
                {
                    if ((double)result.StatusCode == Conversions.ToDouble("400"))
                    {
                        Chrono().Stop();
                        Bar().Value = 1;
                        Initline().Visible = false;
                        Kisturelmet().Visible = false;
                        enableInput();
                        Firebutton().Enabled = true;
                        MessageBox.Show("A beírt Licenckulcs nem létezik a 2H Rendszerben! Próbálja újra!", "2H-ETM FoxComm 4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("504"))
                    {
                        Chrono().Stop();
                        Bar().Value = 1;
                        Initline().Visible = false;
                        Kisturelmet().Visible = false;
                        enableInput();
                        Firebutton().Enabled = true;
                        MessageBox.Show("A 2H szerverek jelenleg nem tudják feldolgozni a kérést!\r\nKérem próbálja kicsit később!", "2H-ETM FoxComm 4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("403"))
                    {
                        Chrono().Stop();
                        Bar().Value = 1;
                        Initline().Visible = false;
                        Kisturelmet().Visible = false;
                        enableInput();
                        Firebutton().Enabled = true;
                        MessageBox.Show("Az azonosító token érvényessége lejárt! Hívja a forgalmazót", "2H-ETM FoxComm 4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("401"))
                    {
                        Chrono().Stop();
                        Bar().Value = 1;
                        Initline().Visible = false;
                        Kisturelmet().Visible = false;
                        enableInput();
                        Firebutton().Enabled = true;
                        Interaction.MsgBox("Az azonosító token érvénytelen vagy hibás! Próbálja ismét!");
                    }
                    if ((double)result.StatusCode != Conversions.ToDouble("200"))
                    {
                        return;
                    }
                    Chrono().Start();
                    HttpContent content = result.Content;
                    try
                    {
                        object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(content.ReadAsStringAsync().Result));
                        Status = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "status" }, null));
                        CpuID = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "cpuid" }, null));
                        DiskID = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "diskid" }, null));
                        BoardID = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "boardid" }, null));
                        Usernumma = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "usernumma" }, null));
                        Beolvasotteljesnev().ForeColor = Color.DodgerBlue;
                        Beolvasotteljesnev().Text = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "owner" }, null));
                        if (Operators.CompareString(Usernumma, usernuminput().Text, TextCompare: false) == 0)
                        {
                            magickeyinput().Visible = false;
                            SigneturedAuth().Visible = true;
                            if (Operators.CompareString(Status, "0", TextCompare: false) == 0)
                            {
                                _2035();
                            }
                            else if (Operators.CompareString(Status, "1", TextCompare: false) == 0)
                            {
                                if ((Operators.CompareString(CpuID, CpuID1, TextCompare: false) == 0) & (Operators.CompareString(DiskID, DiskID1, TextCompare: false) == 0) & (Operators.CompareString(BoardID, BoardID1, TextCompare: false) == 0))
                                {
                                    ReinstallDetected = "1";
                                    _2035();
                                    return;
                                }
                                Chrono().Stop();
                                Bar().Value = 0;
                                MessageBox.Show("A megadott terméklicenc másik számítógéphez tartozik!\r\nAdjon meg egy új, vagy ehhez a géphez regiszrtált licencet!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Firebutton().Enabled = true;
                            }
                            else if (Operators.CompareString(Status, "2", TextCompare: false) == 0)
                            {
                                Chrono().Stop();
                                Bar().Value = 0;
                                MessageBox.Show("Az ön által megadott FoxComm 4 licenc le van tiltva! Keresse a forgalmazót!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Firebutton().Enabled = true;
                            }
                            else
                            {
                                Chrono().Stop();
                                Bar().Value = 0;
                                MessageBox.Show("Az aktiválás sikertelen volt: Kapcsolódási hiba! Próbálja ismét!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Firebutton().Enabled = true;
                            }
                        }
                        else
                        {
                            Chrono().Stop();
                            Bar().Value = 1;
                            Initline().Visible = false;
                            Kisturelmet().Visible = false;
                            Interaction.MsgBox("Érvénytelen Vásárló azonosító! Próbálja újra!");
                            enableInput();
                            Firebutton().Enabled = true;
                        }
                    }
                    finally
                    {
                        ((IDisposable)content)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)result)?.Dispose();
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
        }
    }

    private void _2035()
    {
        try
        {
            string text = string.Format("https://dimitris.masbate.hu/Checklua/Serial?AddSer={0}&Partid={1}&Addcp={2}&Addhd={3}&AddStat=1&Stamp={4}&Bdsn={5}", licencekeyinput().Text, PartitionID1, CpuID1, DiskID1, DateTime, BoardID1);
            HttpClient val = new HttpClient();
            try
            {
                ((HttpHeaders)val.DefaultRequestHeaders).Add("Authorization", "Bearer " + magickeyinput().Text);
                HttpResponseMessage result = val.GetAsync(text).Result;
                try
                {
                    if ((double)result.StatusCode == Conversions.ToDouble("400"))
                    {
                        Hide();
                        MessageBox.Show("A 2H Szerver a bevitt adatokban hibákat észlelt", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("504"))
                    {
                        Hide();
                        MessageBox.Show("A 2H ETM Szerverek nem elérhetők! Próbálja később megismételni az aktiválást!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("403"))
                    {
                        Hide();
                        MessageBox.Show("A Digitális token érvénytelen, lejárt, vagy hibás! Próbálja ismét, Ha nem sikerül hívja a forgalmazót!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("401"))
                    {
                        Hide();
                        MessageBox.Show("A Digitális token érvénytelen, lejárt, vagy hibás! Próbálja ismét, Ha nem sikerül hívja a forgalmazót!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("200"))
                    {
                        HttpContent content = result.Content;
                        try
                        {
                            RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(content.ReadAsStringAsync().Result));
                            _2036();
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
                    ((IDisposable)result)?.Dispose();
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
        }
    }

    private void _2033()
    {
        byte[] bytes = Encoding.UTF8.GetBytes(CpuID1 + BoardID1 + DiskID1);
        string name = "SOFTWARE\\Masbate\\License";
        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, writable: true);
        registryKey.SetValue("Status", "1", RegistryValueKind.DWord);
        registryKey.SetValue(value: Convert.ToBase64String(AdatokLoad.EncryptString(licencekeyinput().Text, bytes)), name: "Serial", valueKind: RegistryValueKind.String);
        registryKey.SetValue(value: Convert.ToBase64String(AdatokLoad.EncryptString(Vihar, bytes)), name: "Vihar", valueKind: RegistryValueKind.String);
        registryKey.SetValue(value: Convert.ToBase64String(AdatokLoad.EncryptString(Barel, bytes)), name: "Barel", valueKind: RegistryValueKind.String);
    }

    private void _2036()
    {
        try
        {
            string text = "https://dimitris.masbate.hu/Checklua/Gipszelo?Meszelo=10";
            HttpClient val = new HttpClient();
            try
            {
                ((HttpHeaders)val.DefaultRequestHeaders).Add("Authorization", "Bearer " + magickeyinput().Text);
                HttpResponseMessage result = val.GetAsync(text).Result;
                try
                {
                    if ((double)result.StatusCode == Conversions.ToDouble("400"))
                    {
                        Hide();
                        MessageBox.Show("A beírt Licenckulcs nem létezik! Próbálja újra! A Program most kilép!", "2H-ETM Endencio: Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("504"))
                    {
                        Hide();
                        MessageBox.Show("A ETM Szerverek nem elérhetők! Próbálja később!", "2H-ETM Endencio: Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("403"))
                    {
                        Hide();
                        MessageBox.Show("A Digitális token érvénytelen vagy hibás! Próbálja ismét!", "2H-ETM Endencio: Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("401"))
                    {
                        Hide();
                        Interaction.MsgBox("A Digitális token érvénytelen vagy hibás! Próbálja ismét!");
                        Application.Exit();
                    }
                    if ((double)result.StatusCode == Conversions.ToDouble("200"))
                    {
                        HttpContent content = result.Content;
                        try
                        {
                            object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(content.ReadAsStringAsync().Result));
                            Barel = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "kifesto" }, null));
                            Vihar = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "mazolo" }, null));
                            _2033();
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
                    ((IDisposable)result)?.Dispose();
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
        }
    }
}
