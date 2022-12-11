
namespace CompGraf1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveJPEGButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripPolyline = new System.Windows.Forms.ToolStripButton();
            this.toolStripRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripElipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripBezier = new System.Windows.Forms.ToolStripButton();
            this.toolStripPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.opacitylabel = new System.Windows.Forms.Label();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Location = new System.Drawing.Point(262, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveJPEGButton
            // 
            this.SaveJPEGButton.Location = new System.Drawing.Point(466, 481);
            this.SaveJPEGButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveJPEGButton.Name = "SaveJPEGButton";
            this.SaveJPEGButton.Size = new System.Drawing.Size(124, 57);
            this.SaveJPEGButton.TabIndex = 12;
            this.SaveJPEGButton.Text = "Save";
            this.SaveJPEGButton.UseVisualStyleBackColor = false;
            this.SaveJPEGButton.Click += new System.EventHandler(this.SaveJPEGButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FloralWhite;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLine,
            this.toolStripPolyline,
            this.toolStripRectangle,
            this.toolStripElipse,
            this.toolStripBezier,
            this.toolStripPolygon,
            this.toolStripCircle,
            this.toolStripText,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripLabel5,
            this.toolStripTextBox3,
            this.toolStripLabel4,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(110, 584);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseEnter += new System.EventHandler(this.toolStrip1_MouseEnter);
            // 
            // toolStripLine
            // 
            this.toolStripLine.AutoSize = false;
            this.toolStripLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLine.Image")));
            this.toolStripLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLine.Name = "toolStripLine";
            this.toolStripLine.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLine.Size = new System.Drawing.Size(100, 35);
            this.toolStripLine.Text = "Линия";
            this.toolStripLine.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripPolyline
            // 
            this.toolStripPolyline.AutoSize = false;
            this.toolStripPolyline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripPolyline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPolyline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPolyline.Image")));
            this.toolStripPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPolyline.Name = "toolStripPolyline";
            this.toolStripPolyline.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripPolyline.Size = new System.Drawing.Size(100, 35);
            this.toolStripPolyline.Text = "Полилиния";
            this.toolStripPolyline.Click += new System.EventHandler(this.toolStripPolyline_Click);
            // 
            // toolStripRectangle
            // 
            this.toolStripRectangle.AutoSize = false;
            this.toolStripRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRectangle.Image")));
            this.toolStripRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRectangle.Name = "toolStripRectangle";
            this.toolStripRectangle.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripRectangle.Size = new System.Drawing.Size(100, 35);
            this.toolStripRectangle.Text = "Прямоугольник";
            this.toolStripRectangle.Click += new System.EventHandler(this.toolStripRectangle_Click);
            // 
            // toolStripElipse
            // 
            this.toolStripElipse.AutoSize = false;
            this.toolStripElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripElipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripElipse.Image")));
            this.toolStripElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripElipse.Name = "toolStripElipse";
            this.toolStripElipse.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripElipse.Size = new System.Drawing.Size(100, 35);
            this.toolStripElipse.Text = "Эллипс";
            this.toolStripElipse.Click += new System.EventHandler(this.toolStripElipse_Click);
            // 
            // toolStripBezier
            // 
            this.toolStripBezier.AutoSize = false;
            this.toolStripBezier.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripBezier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBezier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBezier.Image")));
            this.toolStripBezier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBezier.Name = "toolStripBezier";
            this.toolStripBezier.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBezier.Size = new System.Drawing.Size(100, 35);
            this.toolStripBezier.Text = "Кривая Безье";
            this.toolStripBezier.Click += new System.EventHandler(this.toolStripBezier_Click);
            // 
            // toolStripPolygon
            // 
            this.toolStripPolygon.AutoSize = false;
            this.toolStripPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPolygon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPolygon.Image")));
            this.toolStripPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPolygon.Name = "toolStripPolygon";
            this.toolStripPolygon.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripPolygon.Size = new System.Drawing.Size(100, 35);
            this.toolStripPolygon.Text = "Полигон";
            this.toolStripPolygon.Click += new System.EventHandler(this.toolStripPolygon_Click);
            // 
            // toolStripCircle
            // 
            this.toolStripCircle.AutoSize = false;
            this.toolStripCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCircle.Image")));
            this.toolStripCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCircle.Name = "toolStripCircle";
            this.toolStripCircle.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripCircle.Size = new System.Drawing.Size(100, 35);
            this.toolStripCircle.Text = "Круг";
            this.toolStripCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripCircle.Click += new System.EventHandler(this.toolStripCircle_Click);
            // 
            // toolStripText
            // 
            this.toolStripText.AutoSize = false;
            this.toolStripText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripText.Image")));
            this.toolStripText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripText.Name = "toolStripText";
            this.toolStripText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripText.Size = new System.Drawing.Size(100, 35);
            this.toolStripText.Text = "Текст";
            this.toolStripText.Click += new System.EventHandler(this.toolStripText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(108, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 15);
            this.toolStripLabel1.Text = "Цвет:";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.Black;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(108, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 15);
            this.toolStripButton1.Text = "Цвет контура";
            this.toolStripButton1.Visible = false;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.Black;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripButton3.Visible = false;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(108, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(30, 23);
            this.toolStripTextBox2.Text = "100";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Visible = false;
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(108, 15);
            this.toolStripLabel2.Text = "Радиус";
            this.toolStripLabel2.Visible = false;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(108, 15);
            this.toolStripLabel5.Text = "Длина";
            this.toolStripLabel5.Visible = false;
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(30, 23);
            this.toolStripTextBox3.Text = "50";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox3.Visible = false;
            this.toolStripTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox3_KeyPress);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 10);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(108, 15);
            this.toolStripLabel4.Text = "Ширина";
            this.toolStripLabel4.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FloralWhite;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(131, 24);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.FloralWhite;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(131, 107);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 24;
            this.trackBar2.TickFrequency = 20;
            this.trackBar2.Value = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // opacitylabel
            // 
            this.opacitylabel.BackColor = System.Drawing.Color.White;
            this.opacitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opacitylabel.Location = new System.Drawing.Point(143, 134);
            this.opacitylabel.Name = "opacitylabel";
            this.opacitylabel.Size = new System.Drawing.Size(79, 13);
            this.opacitylabel.TabIndex = 25;
            this.opacitylabel.Text = "100 %";
            this.opacitylabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.BackColor = System.Drawing.Color.White;
            this.PenWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PenWidthLabel.Location = new System.Drawing.Point(143, 51);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(79, 13);
            this.PenWidthLabel.TabIndex = 26;
            this.PenWidthLabel.Text = "5";
            this.PenWidthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Толщина кисти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Прозрачность основы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Прозраность контура";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(143, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "100 %";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Visible = false;
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.Color.FloralWhite;
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(131, 273);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 32;
            this.trackBar4.TickFrequency = 20;
            this.trackBar4.Value = 100;
            this.trackBar4.Visible = false;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.Color.FloralWhite;
            this.trackBar5.LargeChange = 1;
            this.trackBar5.Location = new System.Drawing.Point(131, 190);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 35;
            this.trackBar5.Value = 5;
            this.trackBar5.Visible = false;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(143, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "5";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Толщина контура";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Введите текст";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 43;
            this.button2.Text = "Microsoft Sans Serif";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PenWidthLabel);
            this.Controls.Add(this.opacitylabel);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SaveJPEGButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveJPEGButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripLine;
        private System.Windows.Forms.ToolStripButton toolStripPolyline;
        private System.Windows.Forms.ToolStripButton toolStripRectangle;
        private System.Windows.Forms.ToolStripButton toolStripBezier;
        private System.Windows.Forms.ToolStripButton toolStripPolygon;
        private System.Windows.Forms.ToolStripButton toolStripCircle;
        private System.Windows.Forms.ToolStripButton toolStripText;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripElipse;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label opacitylabel;
        private System.Windows.Forms.Label PenWidthLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button2;
    }
}

