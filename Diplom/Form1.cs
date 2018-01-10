using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Diplom.Models;
using Images;
using System.Threading;
using System.Windows.Forms.VisualStyles;



namespace Diplom
{
    public partial class Analiser : Form
    {
        private const string FiltersExt = "Image Files (*.BMP, *.JPG, *.PNG)|*.jpg;*.bmp;*.png";
        private Bitmap _original1;
        private Bitmap _original2;
        private Bitmap _original3;
        private Bitmap _original4;
        private Bitmap _original5;
        private Bitmap _bw1;
        private Bitmap _bw2;
        private Bitmap _bw3;
        private Bitmap _bw4;
        private Bitmap _bw5;
       // private Finger _selected;
        private readonly List<Color> _colors = new List<Color>();
        private readonly List<Interval> _intervals;
        private readonly List<Finger> _fingers;

        public Analiser()
        {
            List<Finger> fingers;
            var t = new Thread(SplashStart);
            t.Start();
            Thread.Sleep(2500);

            InitializeComponent();
            t.Abort();


            pictureBox2.SizeMode = pictureBox1.SizeMode = pictureBox3.SizeMode = pictureBox4.SizeMode = pictureBox5.SizeMode = pictureBox6.SizeMode = pictureBox7.SizeMode = pictureBox8.SizeMode = pictureBox9.SizeMode = pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                fingers = Finger.LoadFingers(@"Fingers.txt");
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error loading fingers. New data will be generated", @"Error");
                Finger.CreateTestData(@"Fingers.txt");
                fingers = Finger.LoadFingers(@"Fingers.txt");
            }

            try
            {
                _intervals = Interval.LoadIntervals(@"Intervals.txt");
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error loading intervals. New data will be generated", @"Error");
                Interval.CreateTestData(@"Intervals.txt");
                _intervals = Interval.LoadIntervals(@"Intervals.txt");
            }


            //cb_finger.DataSource = fingers;
            //cb_finger.DisplayMember = "Name";
            _fingers = fingers;

            KnownColor[] c = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            _colors.AddRange(c.Select(Color.FromKnownColor));

        }

        public void SplashStart()
        {
            Application.Run(new Launch());
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog { Filter = FiltersExt };

            if (openFile.ShowDialog() != DialogResult.OK) return;

            _original1 = new Bitmap(openFile.FileName);

            _bw1 = _original1.make_bw(trackBar1.Value);

            pictureBox1.Image = _original1;
            pictureBox2.Image = _bw1;

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog { Filter = FiltersExt };

            if (openFile.ShowDialog() != DialogResult.OK) return;

            _original2 = new Bitmap(openFile.FileName);

            _bw2 = _original2.make_bw(trackBar1.Value);

            pictureBox3.Image = _original2;
            pictureBox4.Image = _bw2;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog { Filter = FiltersExt };

            if (openFile.ShowDialog() != DialogResult.OK) return;

            _original3 = new Bitmap(openFile.FileName);

            _bw3 = _original3.make_bw(trackBar1.Value);

            pictureBox5.Image = _original3;
            pictureBox6.Image = _bw3;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog { Filter = FiltersExt };

            if (openFile.ShowDialog() != DialogResult.OK) return;

            _original4 = new Bitmap(openFile.FileName);

            _bw4 = _original4.make_bw(trackBar1.Value);

            pictureBox7.Image = _original4;
            pictureBox8.Image = _bw4;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog { Filter = FiltersExt };

            if (openFile.ShowDialog() != DialogResult.OK) return;

            _original5 = new Bitmap(openFile.FileName);

            _bw5 = _original5.make_bw(trackBar1.Value);

            pictureBox9.Image = _original5;
            pictureBox10.Image = _bw5;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _bw1 = _original1.make_bw(trackBar1.Value);
            pictureBox2.Image = _bw1;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            _bw2 = _original1.make_bw(trackBar2.Value);
            pictureBox4.Image = _bw2;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            _bw3 = _original1.make_bw(trackBar3.Value);
            pictureBox6.Image = _bw3;

        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            _bw4 = _original1.make_bw(trackBar4.Value);
            pictureBox8.Image = _bw4;
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            _bw5 = _original1.make_bw(trackBar5.Value);
            pictureBox10.Image = _bw5;
        }



        //private void cb_finger_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _selected = ((ComboBox)sender).SelectedItem as Finger;
        //    pictureBox1.Refresh();
        //    pictureBox2.Refresh();
        //}

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Большой палец"));
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Большой палец"));
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {

            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Указательный палец"));
        }
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Указательный палец"));
        }
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {

            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Средний палец"));
        }
        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Средний палец"));
        }
        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {

            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Безымянный палец"));
        }
        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Безымянный палец"));
        }
        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {

            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Мизинец"));
        }
        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {
            DrawMask(e, _fingers.FirstOrDefault(x => x.Name == "Мизинец"));
        }


        private void DrawMask(PaintEventArgs e, Finger f)
        {
            // return;
            var h = e.Graphics.ClipBounds.Height;
            var w = e.Graphics.ClipBounds.Width;
            var center = new Point((int)(w / 2), (int)(h / 2));

            foreach (var sector in f.Sectors)
            {
                Pen blackPen = new Pen(_colors[f.Sectors.IndexOf(sector)], 3);

                Point point1 = new Point(center.X, center.Y);
                Point point2 = new Point((int)(center.X + Math.Cos(sector.Angl1Rad) * (h)) - 2, (int)(center.Y + Math.Sin(sector.Angl1Rad) * (h)) - 2);
                e.Graphics.DrawLine(blackPen, point1, point2);

                point1 = new Point(center.X, center.Y);
                point2 = new Point((int)(center.X + Math.Cos(sector.Angl2Rad) * (h)) + 2, (int)(center.Y + Math.Sin(sector.Angl2Rad) * (h)) + 2);
                e.Graphics.DrawLine(blackPen, point1, point2);
            }
        }


        private void bt_Start_Click(object sender, EventArgs e)
        {
            if (_bw1 != null)
            {
                var imgMask = _bw1.GetMaskResized(trackBar1.Value);
                tb_console.AppendText("Большой палец" + Environment.NewLine);
                foreach (var sector in _fingers.FirstOrDefault(x => x.Name == "Большой палец").Sectors)
                {
                    var x = Reader.GetSectorsPercentage(imgMask, sector.Angl1Rad, sector.Angl2Rad) * 100;
                    tb_console.AppendText(sector.Name + ": " + x + "%" + "\t" + Interval.GetIntervalInRange(_intervals, x).Name + Environment.NewLine);
                }
                tb_console.AppendText(Environment.NewLine);
            }

            if (_bw2 != null)
            {
                var imgMask = _bw2.GetMaskResized(trackBar2.Value);
                tb_console.AppendText("Указательный палец" + Environment.NewLine);
                foreach (var sector in _fingers.FirstOrDefault(x => x.Name == "Указательный палец").Sectors)
                {
                    var x = Reader.GetSectorsPercentage(imgMask, sector.Angl1Rad, sector.Angl2Rad) * 100;
                    tb_console.AppendText(sector.Name + ": " + x + "%" + "\t" + Interval.GetIntervalInRange(_intervals, x).Name + Environment.NewLine);
                }
                tb_console.AppendText(Environment.NewLine);
            }

            if (_bw3 != null)
            {
                var imgMask = _bw3.GetMaskResized(trackBar3.Value);
                tb_console.AppendText("Средний палец" + Environment.NewLine);
                foreach (var sector in _fingers.FirstOrDefault(x => x.Name == "Средний палец").Sectors)
                {
                    var x = Reader.GetSectorsPercentage(imgMask, sector.Angl1Rad, sector.Angl2Rad) * 100;
                    tb_console.AppendText(sector.Name + ": " + x + "%" + "\t" + Interval.GetIntervalInRange(_intervals, x).Name + Environment.NewLine);
                }
                tb_console.AppendText(Environment.NewLine);
            }

            if (_bw4 != null)
            {
                var imgMask = _bw4.GetMaskResized(trackBar4.Value);
                tb_console.AppendText("Безымянный палец" + Environment.NewLine);
                foreach (var sector in _fingers.FirstOrDefault(x => x.Name == "Безымянный палец").Sectors)
                {
                    var x = Reader.GetSectorsPercentage(imgMask, sector.Angl1Rad, sector.Angl2Rad) * 100;
                    tb_console.AppendText(sector.Name + ": " + x + "%" + "\t" + Interval.GetIntervalInRange(_intervals, x).Name + Environment.NewLine);
                }
                tb_console.AppendText(Environment.NewLine);
            }

            if (_bw5 != null)
            {
                var imgMask = _bw5.GetMaskResized(trackBar5.Value);
                tb_console.AppendText("Мизинец" + Environment.NewLine);
                foreach (var sector in _fingers.FirstOrDefault(x => x.Name == "Мизинец").Sectors)
                {
                    var x = Reader.GetSectorsPercentage(imgMask, sector.Angl1Rad, sector.Angl2Rad) * 100;
                    tb_console.AppendText(sector.Name + ": " + x + "%" + "\t" + Interval.GetIntervalInRange(_intervals, x).Name + Environment.NewLine);
                }
                tb_console.AppendText(Environment.NewLine);
            }


        }
        private void bt_Erase_Click(object sender, EventArgs e)
        {
            tb_console.Clear();
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            var text = tb_console.Text;
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"txt files (*.txt)|*.txt|doc files (*.doc)|*.doc|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };


            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                File.WriteAllText(saveFileDialog1.FileName, text, Encoding.GetEncoding(1251));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Error during saving file");
            }
        }
        private void Analiser_Load(object sender, EventArgs e)
        {

        }














    }
}
