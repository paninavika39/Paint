using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CompGraf1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            globalXml = new XmlDocument();
            globalXml.AppendChild(globalXml.CreateElement("root"));//ВОТ ЭТО КОРЕНЬ XML ФАЙЛА
        }
        XmlDocument globalXml; //САМ XML ФАЙЛ

        private string path = @"C:\Users\Викусик\Downloads\CompGraf1"; //ПОМЕНЯЙ ПУТЬ ПРОЕКТА
        Bitmap image = new Bitmap(400, 470);

        private Graphics g;
        private Bitmap bpm;
        private int count = 0;

        //Создаём ручку по умолчанию
        private Pen pen = new Pen(color: Color.Black, width: 5);
        private Pen penConture = new Pen(Color.Black, 5);
        private Brush brush = new SolidBrush(Color.Black);
        //Определение состояния фигуры
        private int flag = 0;
        private int bitmapState = 0;
        //Линия
        private Point startPoint;
        private Point endPoint;
        //Кривая Безье
        private List<Point> besyePoints = new List<Point>();
        //Полигон
        private List<Point> polyGonPoints = new List<Point>();
        //Прямоугольник. Опорная точка
        private Point rectanglePoint = new Point();
        //Круг, эллипс
        private Point CirclePoint = new Point();
        //Текст
        private Point TextPoint = new Point();
        private Font font;

        private void SaveJPEGButton_Click(object sender, EventArgs e)
        {
            pictureBox1.DrawToBitmap(bpm, pictureBox1.ClientRectangle);
            bpm.Save(path + "image.jpeg", ImageFormat.Jpeg);
            globalXml.Save(path + "image.panina"); //ВОТ ЭТО СОХРАНЕНИЕ XML В МОЁМ ФОРМАТЕ, ОТКРЫВАЕТСЯ БЛОКНОТОМ

            pictureBox1.Refresh();
        }

        private void HideShowCounterPenParams(bool aVisible)
        {
            label4.Visible = aVisible;
            label5.Visible = aVisible;
            label6.Visible = aVisible;
            label7.Visible = aVisible;
            trackBar4.Visible = aVisible;
            trackBar5.Visible = aVisible;
        }
        private void HideShowEllipseRectangleParams(bool aVisible)
        {

            trackBar1.Visible = !aVisible;
            PenWidthLabel.Visible = !aVisible;
            label1.Visible = !aVisible;
            toolStripLabel2.Visible = !aVisible;


            toolStripTextBox2.Visible = aVisible;
            toolStripTextBox3.Visible = aVisible;
            toolStripLabel5.Visible = aVisible;
            toolStripLabel4.Visible = aVisible;
            toolStripButton1.Visible = aVisible;
            toolStripButton3.Visible = aVisible;
            toolStripSeparator4.Visible = aVisible;
            toolStripSeparator1.Visible = aVisible;
        }

        private void HideShowCircleParams(bool aVisible)
        {

            trackBar1.Visible = !aVisible;
            PenWidthLabel.Visible = !aVisible;
            label1.Visible = !aVisible;
            toolStripTextBox2.Visible = !aVisible;
            toolStripTextBox3.Visible = !aVisible;
            toolStripLabel5.Visible = !aVisible;
            toolStripLabel4.Visible = !aVisible;

            toolStripButton1.Visible = aVisible;
            toolStripButton3.Visible = aVisible;
            toolStripSeparator4.Visible = aVisible;
            toolStripSeparator1.Visible = aVisible;
            toolStripLabel2.Visible = aVisible;
        }

        private void HideShowTextParams(bool aVisible)
        {
            trackBar1.Visible = !aVisible;
            PenWidthLabel.Visible = !aVisible;
            label1.Visible = !aVisible;

            label3.Visible = aVisible;
            textBox1.Visible = aVisible;
            button2.Visible = aVisible;

            toolStripLabel2.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            flag = 1;

            toolStripLine.Checked = true;
            toolStripPolyline.Checked = false;

            this.HideShowCircleParams(false);
            this.HideShowEllipseRectangleParams(false);

            this.HideShowCounterPenParams(false);
            this.HideShowTextParams(false);

            toolStripLabel2.Visible = false;

        }

        private void toolStripPolyline_Click(object sender, EventArgs e)
        {
            flag = 2;

            toolStripTextBox2.Visible = false;

            toolStripLine.Checked = false;
            toolStripPolyline.Checked = true;

            this.HideShowCircleParams(false); 
            this.HideShowEllipseRectangleParams(false);
            this.HideShowTextParams(false);

            this.HideShowCounterPenParams(false);

            toolStripLabel2.Visible = false;

        }

        private void toolStripRectangle_Click(object sender, EventArgs e)
        {
            flag = 3;


            toolStripLine.Checked = false;
            toolStripPolyline.Checked = false;

            this.HideShowEllipseRectangleParams(true);
            this.HideShowTextParams(false);

            this.HideShowCounterPenParams(true);

            toolStripLabel2.Visible = false;

        }

        private void toolStripElipse_Click(object sender, EventArgs e)
        {
            flag = 4;

            toolStripLine.Checked = false;
            toolStripPolyline.Checked = false;

            this.HideShowEllipseRectangleParams(true);
            this.HideShowTextParams(false);

            this.HideShowCounterPenParams(true);

        }

        private void toolStripBezier_Click(object sender, EventArgs e)
        {
            flag = 8;

            toolStripLine.Checked = false;
            toolStripPolyline.Checked = false;
            this.HideShowTextParams(false);

        }

        private void toolStripPolygon_Click(object sender, EventArgs e)
        {
            flag = 7;
            toolStripLine.Checked = false;
            toolStripPolyline.Checked = false;
            this.HideShowTextParams(false);
            this.HideShowCounterPenParams(true);
            toolStripButton1.Visible = true;
            toolStripButton3.Visible = true;

            toolStripTextBox2.Visible = false;
            toolStripSeparator4.Visible = false;


        }

        private void toolStripCircle_Click(object sender, EventArgs e)
        {
            flag = 5;
            toolStripLabel2.Visible = true;
            toolStripLine.Checked = false;
            toolStripPolyline.Checked = false;
            toolStripTextBox2.Visible = true;

            this.HideShowCircleParams(true);
            this.HideShowCounterPenParams(true);
            this.HideShowTextParams(false);

            toolStripLabel2.Visible = true;
            toolStripTextBox2.Visible = true;
        }

        private void toolStripText_Click(object sender, EventArgs e)
        {
            flag = 6;
            font = new Font("Microsoft Sans Serif", 8);
            toolStripLine.Checked = false;
            toolStripPolyline.Checked = false;

            toolStripTextBox2.Visible = false;
            toolStripLabel2.Visible = false;

            this.HideShowCircleParams(false);
            this.HideShowTextParams(true);
            this.HideShowCounterPenParams(false);
        }

        private void TextColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// При нажатии ЛКМ по pictureBox в зависимости от состояния
        /// происходит считывание значений для отрисовки примитивов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (flag == 1) //line startpoint
            {
                startPoint = new Point(e.X, e.Y);
                flag = 11;
            }

            else if (flag == 11)
            {
                endPoint = new Point(e.X, e.Y);
                flag = 111;


            }

            else if (flag == 2) //polyline
            {
                startPoint = new Point(e.X, e.Y);
                flag = 22;
            }
            else if (flag == 22)
            {
                endPoint = new Point(e.X, e.Y);
                flag = 222;
            }

            else if (flag == 3) //rectangle
            {
                rectanglePoint = new Point(e.X, e.Y);
                flag = 333;
            }

            else if (flag == 4) //ellipse
            {
                CirclePoint = new Point(e.X, e.Y);
                flag = 444;
            }

            else if (flag == 5) //circle
            {
                CirclePoint = new Point(e.X, e.Y);
                flag = 555;
            }

            else if (flag == 6) //Text
            {
                TextPoint = new Point(e.X, e.Y);
                flag = 666;
            }
            else if (flag == 7) //Polygon
            {
                polyGonPoints.Add(new Point(e.X, e.Y));
               
                if (e.Button == MouseButtons.Right)
                {
                    flag = 777;
                }
            }


            else if (flag == 8) //Polygon
            {
                if (count < 4)
                {
                    besyePoints.Add(new Point(e.X, e.Y));
                    count++;
                }
                else
                {
                    count = 0;
                    flag = 888;
                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var DocumentElement = globalXml.DocumentElement;

            if (flag == 111)
            {
                g.DrawLine(pen, startPoint, endPoint);

                XmlElement LineEl = globalXml.CreateElement("line");//ВОТ ЭТО ЗАПИСЬ В XML
                LineEl.SetAttribute("x1", startPoint.X.ToString());
                LineEl.SetAttribute("y1", startPoint.Y.ToString());
                LineEl.SetAttribute("x2", endPoint.X.ToString());
                LineEl.SetAttribute("y2", endPoint.Y.ToString());
                LineEl.SetAttribute("width", pen.Width.ToString());
                LineEl.SetAttribute("opacity", trackBar2.Value.ToString());
                LineEl.SetAttribute("colour", toolStripButton2.BackColor.ToArgb().ToString());
                globalXml.DocumentElement.AppendChild(LineEl);

                flag = 1;
            }

            if (flag == 222)
            {
                g.DrawLine(pen, startPoint, endPoint);
                startPoint = endPoint;

                XmlElement PolylineEl = globalXml.CreateElement("polyline");//ВОТ ЭТО ЗАПИСЬ В XML
                PolylineEl.SetAttribute("coords1", startPoint.ToString());
                PolylineEl.SetAttribute("coords2", endPoint.ToString());
                PolylineEl.SetAttribute("width", pen.Width.ToString());
                PolylineEl.SetAttribute("opacity", trackBar2.Value.ToString());
                PolylineEl.SetAttribute("colour", toolStripButton2.BackColor.ToArgb().ToString());
                globalXml.DocumentElement.AppendChild(PolylineEl);

                flag = 22;
            }

            if (flag == 333)
            {
                int height = Convert.ToInt32(toolStripTextBox3.Text);
                int width = Convert.ToInt32(toolStripTextBox2.Text);
                Size size = new Size(width, height);
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(rectanglePoint, size);
                g.DrawRectangle(penConture, rectangle);
                g.FillRectangle(brush, rectangle);

                XmlElement RectEl = globalXml.CreateElement("rectangle");//ВОТ ЭТО ЗАПИСЬ В XML
                RectEl.SetAttribute("x", rectanglePoint.X.ToString());
                RectEl.SetAttribute("y", rectanglePoint.Y.ToString());
                RectEl.SetAttribute("width", width.ToString());
                RectEl.SetAttribute("height", height.ToString());
                RectEl.SetAttribute("opacity", trackBar2.Value.ToString());
                RectEl.SetAttribute("borderColour", toolStripButton3.BackColor.ToArgb().ToString());
                RectEl.SetAttribute("borderWidth", trackBar5.Value.ToString());
                RectEl.SetAttribute("fillColour", toolStripButton2.BackColor.ToArgb().ToString());
                globalXml.DocumentElement.AppendChild(RectEl);

                flag = 3;
            }

            if (flag == 444)
            {
                int height = Convert.ToInt32(toolStripTextBox3.Text);
                int width = Convert.ToInt32(toolStripTextBox2.Text);
                Size size = new Size(width, height);
                CirclePoint.X -= width / 2;
                CirclePoint.Y -= height / 2;
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(CirclePoint, size);

                g.DrawEllipse(penConture, rectangle);
                g.FillEllipse(brush, rectangle);

                XmlElement CircleEl = globalXml.CreateElement("circle");//ВОТ ЭТО ЗАПИСЬ В XML
                CircleEl.SetAttribute("x", CirclePoint.X.ToString());
                CircleEl.SetAttribute("y", CirclePoint.Y.ToString());
                CircleEl.SetAttribute("width", width.ToString());
                CircleEl.SetAttribute("height", height.ToString());
                CircleEl.SetAttribute("opacity", trackBar2.Value.ToString());
                CircleEl.SetAttribute("borderColour", toolStripButton3.BackColor.ToArgb().ToString());
                CircleEl.SetAttribute("borderWidth", trackBar5.Value.ToString());
                CircleEl.SetAttribute("fillColour", toolStripButton2.BackColor.ToArgb().ToString());
                globalXml.DocumentElement.AppendChild(CircleEl);


                flag = 4;
            }

            if (flag == 555)
            {
                int radius = Convert.ToInt32(toolStripTextBox2.Text);
                Size size = new Size(radius, radius);
                CirclePoint.X -= radius / 2;
                CirclePoint.Y -= radius / 2;
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(CirclePoint, size);
                g.DrawEllipse(penConture, rectangle);
                g.FillEllipse(brush, rectangle);

                XmlElement EllipseEl = globalXml.CreateElement("ellipse");//ВОТ ЭТО ЗАПИСЬ В XML
                EllipseEl.SetAttribute("x", CirclePoint.X.ToString());
                EllipseEl.SetAttribute("y", CirclePoint.Y.ToString());
                EllipseEl.SetAttribute("radius", radius.ToString());
                EllipseEl.SetAttribute("opacity", trackBar2.Value.ToString());
                EllipseEl.SetAttribute("borderColour", toolStripButton3.BackColor.ToArgb().ToString());
                EllipseEl.SetAttribute("borderWidth", trackBar5.Value.ToString());
                EllipseEl.SetAttribute("fillColour", toolStripButton2.BackColor.ToArgb().ToString());
                globalXml.DocumentElement.AppendChild(EllipseEl);


                flag = 5;
            }

            if (flag == 666)
            {
                g.DrawString(textBox1.Text, font, brush, TextPoint);

                XmlElement TextEl = globalXml.CreateElement("text");//ВОТ ЭТО ЗАПИСЬ В XML
                TextEl.SetAttribute("x", TextPoint.X.ToString());
                TextEl.SetAttribute("y", TextPoint.Y.ToString());
                TextEl.InnerText = textBox1.Text;
                TextEl.SetAttribute("textColour", toolStripButton2.BackColor.ToArgb().ToString());
                TextEl.SetAttribute("fontName", font.Name);
                TextEl.SetAttribute("fontSize", font.Size.ToString());
                TextEl.SetAttribute("fontStyle", font.Style.ToString());
                globalXml.DocumentElement.AppendChild(TextEl);

                flag = 6;
            }

            if (flag == 777)
            {
                g.DrawPolygon(penConture, polyGonPoints.ToArray());
                g.FillPolygon(brush, polyGonPoints.ToArray());

                XmlElement PolygonEl = globalXml.CreateElement("polygon");//ВОТ ЭТО ЗАПИСЬ В XML
                PolygonEl.SetAttribute("coords", polyGonPoints.ToString());//
                PolygonEl.SetAttribute("width", penConture.Width.ToString());//
                PolygonEl.SetAttribute("opacity", trackBar2.Value.ToString());//
                PolygonEl.SetAttribute("fillColour", toolStripButton2.BackColor.ToArgb().ToString());//
                PolygonEl.SetAttribute("borderColour", toolStripButton3.BackColor.ToArgb().ToString());//
                globalXml.DocumentElement.AppendChild(PolygonEl);//


                polyGonPoints.Clear();

                flag = 7;
            }

            if (flag == 888)
            {
                g.DrawBezier(pen, besyePoints[0], besyePoints[1], besyePoints[2], besyePoints[3]);

                XmlElement BezierEl = globalXml.CreateElement("bezier"); //ВОТ ЭТО ЗАПИСЬ В XML безье
                BezierEl.SetAttribute("x1", besyePoints[0].X.ToString());
                BezierEl.SetAttribute("y1", besyePoints[0].Y.ToString());
                BezierEl.SetAttribute("x2", besyePoints[1].X.ToString());
                BezierEl.SetAttribute("y2", besyePoints[1].Y.ToString());
                BezierEl.SetAttribute("x3", besyePoints[2].X.ToString());
                BezierEl.SetAttribute("y3", besyePoints[2].Y.ToString());
                BezierEl.SetAttribute("x4", besyePoints[3].X.ToString());
                BezierEl.SetAttribute("y4", besyePoints[3].Y.ToString());
                BezierEl.SetAttribute("width", pen.Width.ToString());
                BezierEl.SetAttribute("opacity", trackBar2.Value.ToString());
                BezierEl.SetAttribute("colour", toolStripButton2.BackColor.ToArgb().ToString());
                globalXml.DocumentElement.AppendChild(BezierEl);


                besyePoints.Clear();

                flag = 8;
            }

            g.Save();
            pictureBox1.Refresh();
        }

        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            if (bitmapState == 0)
            {
                //Создаём Image внутри pictureBox
                bpm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                ////Создаём объект graphics для рисования на bitmap
                g = Graphics.FromImage(bpm);

                g.Clear(Color.White);
                pictureBox1.Image = bpm;
                bitmapState++;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                pen.Color = Color.FromArgb(255, color);
                toolStripButton2.BackColor = color;
                brush = new SolidBrush(Color.FromArgb(255, color));
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            opacitylabel.Text = trackBar2.Value.ToString() + " %";
            var res = Convert.ToInt32(Math.Round(trackBar2.Value * 2.55));
            pen.Color = Color.FromArgb(res, pen.Color); //0-255
            brush = new SolidBrush(Color.FromArgb(res, pen.Color));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PenWidthLabel.Text = trackBar1.Value.ToString();
            pen.Width = trackBar1.Value;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                penConture.Color = Color.FromArgb(255, color);
                toolStripButton3.BackColor = color;
            }
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            penConture.Width = trackBar5.Value;
            label7.Text = trackBar5.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            var res = Convert.ToInt32(Math.Round(trackBar4.Value * 2.55));
            penConture.Color = Color.FromArgb(res, penConture.Color); //0-255
            label6.Text = trackBar4.Value.ToString();
        }

        //Проверка ввода чисел для сторон прямоугольника
        private void toolStripTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
                button2.Text = fontDialog1.Font.FontFamily.Name;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                pen.Color = Color.FromArgb(255, color);
                toolStripButton2.BackColor = color;
                brush = new SolidBrush(Color.FromArgb(255, color));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
