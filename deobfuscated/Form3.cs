using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form3 : Form
{
    private IContainer components;

    [CompilerGenerated]
    [AccessedThroughProperty("Firebutton")]
    private CButton _Firebutton;

    [CompilerGenerated]
    [AccessedThroughProperty("aktivalaskep")]
    private PictureBox _aktivalaskep;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [CompilerGenerated]
    [AccessedThroughProperty("Kepakepben")]
    private Timer _Kepakepben;

    [CompilerGenerated]
    [AccessedThroughProperty("Bar")]
    private ProgressBar _Bar;

    [CompilerGenerated]
    [AccessedThroughProperty("sikerakt")]
    private Label _sikerakt;

    [CompilerGenerated]
    [AccessedThroughProperty("Label9")]
    private Label _Label9;

    [CompilerGenerated]
    [AccessedThroughProperty("nekifoghat")]
    private Label _nekifoghat;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;

    [CompilerGenerated]
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;

    [CompilerGenerated]
    [AccessedThroughProperty("timer")]
    private Timer _timer;

    public Form3()
    {
        base.Load += Form3_Load;
        timer(new Timer());
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
        cBlendItems cBlendItems = new cBlendItems();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
        Firebutton(new CButton());
        aktivalaskep(new PictureBox());
        PictureBox1(new PictureBox());
        Kepakepben(new Timer(components));
        Bar(new ProgressBar());
        sikerakt(new Label());
        Label9(new Label());
        nekifoghat(new Label());
        PictureBox2(new PictureBox());
        PictureBox3(new PictureBox());
        ((ISupportInitialize)aktivalaskep()).BeginInit();
        ((ISupportInitialize)PictureBox1()).BeginInit();
        ((ISupportInitialize)PictureBox2()).BeginInit();
        ((ISupportInitialize)PictureBox3()).BeginInit();
        SuspendLayout();
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
        Firebutton().Location = new Point(240, 285);
        Firebutton().Name = "Firebutton";
        Firebutton().Size = new Size(191, 36);
        Firebutton().TabIndex = 59;
        Firebutton().Text = "FoxComm indítása";
        Firebutton().TextImageRelation = TextImageRelation.ImageBeforeText;
        Firebutton().TextShadow = Color.Black;
        Firebutton().Visible = false;
        aktivalaskep().BackColor = Color.Transparent;
        aktivalaskep().Image = (Image)componentResourceManager.GetObject("aktivalaskep.Image");
        aktivalaskep().Location = new Point(557, 22);
        aktivalaskep().Name = "aktivalaskep";
        aktivalaskep().Size = new Size(98, 78);
        aktivalaskep().SizeMode = PictureBoxSizeMode.StretchImage;
        aktivalaskep().TabIndex = 60;
        aktivalaskep().TabStop = false;
        PictureBox1().BackColor = Color.Transparent;
        PictureBox1().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
        PictureBox1().Location = new Point(557, 22);
        PictureBox1().Name = "PictureBox1";
        PictureBox1().Size = new Size(98, 78);
        PictureBox1().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox1().TabIndex = 62;
        PictureBox1().TabStop = false;
        PictureBox1().Visible = false;
        Bar().Location = new Point(630, 323);
        Bar().Name = "Bar";
        Bar().Size = new Size(10, 10);
        Bar().TabIndex = 63;
        Bar().Visible = false;
        sikerakt().AutoSize = true;
        sikerakt().BackColor = Color.Transparent;
        sikerakt().Font = new Font("Arial Narrow", 24f, FontStyle.Regular, GraphicsUnit.Point, 238);
        sikerakt().ForeColor = Color.Peru;
        sikerakt().Location = new Point(128, 183);
        sikerakt().Name = "sikerakt";
        sikerakt().Size = new Size(423, 37);
        sikerakt().TabIndex = 64;
        sikerakt().Text = "Az Aktiválás sikeresen megtörtént!";
        sikerakt().Visible = false;
        Label9().BackColor = Color.Transparent;
        Label9().Font = new Font("Arial Narrow", 24f, FontStyle.Regular, GraphicsUnit.Point, 238);
        Label9().ForeColor = Color.CornflowerBlue;
        Label9().Location = new Point(14, 125);
        Label9().Name = "Label9";
        Label9().Size = new Size(646, 37);
        Label9().TabIndex = 65;
        Label9().Text = "A beküldött licenc adatokat rendszerünk fogadta!";
        Label9().TextAlign = ContentAlignment.MiddleCenter;
        nekifoghat().AutoSize = true;
        nekifoghat().BackColor = Color.Transparent;
        nekifoghat().Font = new Font("Tahoma", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
        nekifoghat().ForeColor = Color.SeaGreen;
        nekifoghat().Location = new Point(165, 235);
        nekifoghat().Name = "nekifoghat";
        nekifoghat().Size = new Size(345, 25);
        nekifoghat().TabIndex = 66;
        nekifoghat().Text = "Minden készenáll! Máris nekifoghat!";
        nekifoghat().Visible = false;
        PictureBox2().BackColor = Color.Transparent;
        PictureBox2().Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
        PictureBox2().Location = new Point(21, 22);
        PictureBox2().Name = "PictureBox2";
        PictureBox2().Size = new Size(98, 78);
        PictureBox2().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox2().TabIndex = 67;
        PictureBox2().TabStop = false;
        PictureBox3().BackColor = Color.Transparent;
        PictureBox3().Cursor = Cursors.Default;
        PictureBox3().Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
        PictureBox3().Location = new Point(207, 39);
        PictureBox3().Name = "PictureBox3";
        PictureBox3().Size = new Size(244, 47);
        PictureBox3().SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBox3().TabIndex = 140;
        PictureBox3().TabStop = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        base.ClientSize = new Size(670, 350);
        base.Controls.Add(PictureBox3());
        base.Controls.Add(PictureBox2());
        base.Controls.Add(nekifoghat());
        base.Controls.Add(Label9());
        base.Controls.Add(sikerakt());
        base.Controls.Add(Bar());
        base.Controls.Add(PictureBox1());
        base.Controls.Add(aktivalaskep());
        base.Controls.Add(Firebutton());
        DoubleBuffered = true;
        base.FormBorderStyle = FormBorderStyle.None;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "Actfinally";
        base.ShowInTaskbar = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Securebootinfo";
        base.TopMost = true;
        ((ISupportInitialize)aktivalaskep()).EndInit();
        ((ISupportInitialize)PictureBox1()).EndInit();
        ((ISupportInitialize)PictureBox2()).EndInit();
        ((ISupportInitialize)PictureBox3()).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
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
    internal virtual PictureBox aktivalaskep()
    {
        return _aktivalaskep;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void aktivalaskep(PictureBox value)
    {
        _aktivalaskep = value;
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
    internal virtual Timer Kepakepben()
    {
        return _Kepakepben;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Kepakepben(Timer value)
    {
        EventHandler value2 = Kepakepben_Tick;
        Timer timer = _Kepakepben;
        if (timer != null)
        {
            timer.Tick -= value2;
        }
        _Kepakepben = value;
        timer = _Kepakepben;
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
    internal virtual Label sikerakt()
    {
        return _sikerakt;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void sikerakt(Label value)
    {
        _sikerakt = value;
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label Label9()
    {
        return _Label9;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void Label9(Label value)
    {
        EventHandler value2 = Label9_DoubleClick;
        Label label = _Label9;
        if (label != null)
        {
            label.DoubleClick -= value2;
        }
        _Label9 = value;
        label = _Label9;
        if (label != null)
        {
            label.DoubleClick += value2;
        }
    }

    [SpecialName]
    [CompilerGenerated]
    internal virtual Label nekifoghat()
    {
        return _nekifoghat;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void nekifoghat(Label value)
    {
        _nekifoghat = value;
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
    internal virtual Timer timer()
    {
        return _timer;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    [SpecialName]
    [CompilerGenerated]
    internal virtual void timer(Timer value)
    {
        EventHandler value1 = timer_Tick;
        Timer timer = _timer;
        if (timer != null)
        {
            timer.Tick -= value1;
        }
        _timer = value;
        timer = _timer;
        if (timer != null)
        {
            timer.Tick += value1;
        }
    }

    private void Firebutton_ClickButtonArea(object sender, MouseEventArgs e)
    {
        Application.Restart();
    }

    private void Form3_Load(object sender, EventArgs e)
    {
        base.TransparencyKey = Color.LightBlue;
        BackColor = Color.LightBlue;
        PictureBox1().Image = Resources._1X1PIPA();
        Kepakepben().Start();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        timer().Stop();
        PictureBox1().Image = Resources._1X1PIPA_allando();
    }

    private int _00A0(Image image)
    {
        return 3000;
    }

    private void _1680(object sender, MouseEventArgs e)
    {
        MyProject.Forms.Form4().TopMost = true;
    }

    private void _2000(object sender, EventArgs e)
    {
    }

    private void Kepakepben_Tick(object sender, EventArgs e)
    {
        Kepakepben().Interval = 40;
        Bar().Increment(1);
        if (Bar().Value == 10)
        {
            aktivalaskep().BringToFront();
            PictureBox1().SendToBack();
        }
        if (Bar().Value == 20)
        {
            PictureBox1().Visible = true;
            timer().Interval = _00A0(Resources._1X1PIPA());
            timer().Start();
        }
        if (Bar().Value == 50)
        {
            aktivalaskep().SendToBack();
            aktivalaskep().Visible = false;
        }
        if (Bar().Value == 50)
        {
            sikerakt().Visible = true;
        }
        if (Bar().Value == 60)
        {
            nekifoghat().Visible = true;
        }
        if (Bar().Value == 70)
        {
            Firebutton().Visible = true;
            Kepakepben().Stop();
        }
    }

    private void Label9_DoubleClick(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
