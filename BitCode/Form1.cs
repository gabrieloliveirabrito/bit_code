using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NumberLib;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using FastBitmap;

namespace BitCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                var Buffer = Encoding.UTF8.GetBytes(txtCode.Text);
                var Bits = new List<bool>();

                string data = string.Empty;
                foreach (var Buff in Buffer)
                {
                    var Binary = BaseConverter.FromNative(Convert.ToInt32(Buff), 2);
                    while (Binary.Digits.Length < 8)
                        Binary.AddDigit('0');

                    data += Binary.ToString() + Environment.NewLine;
                    foreach (var Bit in Binary.Digits)
                        Bits.Add(Bit == '1');
                }
                txtOutBinary.Text = data;

                int Length = Bits.Count;
                while (Math.Sqrt(Length) % 8 != 0)
                    Length++;

                var Size = Convert.ToInt32(Math.Sqrt(Length));
                var Bitmap = new Bitmap(Size, Size);

                using (var FS = Bitmap.FastLock())
                {
                    int Position = 0;
                    for (int x = 0; x < Size; x++)
                    {
                        for (int y = 0; y < Size; y++)
                        {
                            if (Position < Bits.Count)
                                FS.SetPixel(x, y, Bits[Position] ? Color.Blue : Color.Red);
                            else if (Position == Bits.Count)
                                FS.SetPixel(x, y, Color.Green);
                            else
                                FS.SetPixel(x, y, Color.Yellow);

                            Position++;
                        }
                    }
                }

                pictureBox1.Image = Bitmap;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var Bits = new List<bool>();

            var Buffer = new List<byte>();
            var Bitmap = (Bitmap)pictureBox1.Image;

            var Flag = false;

            using (var FS = Bitmap.FastLock())
            {
                for (int x = 0; x < Bitmap.Width && !Flag; x++)
                {
                    for (int y = 0; y < Bitmap.Height; y++)
                    {
                        var ARGB = FS.GetPixel(x, y).ToArgb();

                        if (ARGB == Color.Blue.ToArgb())
                            Bits.Add(true);
                        else if (ARGB == Color.Red.ToArgb())
                            Bits.Add(false);
                        else if (ARGB == Color.Green.ToArgb())
                        {
                            Flag = true;
                            break;
                        }
                    }
                }
            }

            Bits.Reverse();
            string data = string.Empty;
            for (int i = 0; i < Bits.Count; i += 8)
            {
                var Binary = new Number(2, string.Join("", Bits.Skip(i).Take(8).Select(B => B ? '1' : '0').ToArray()));

                data = Binary.ToString() + Environment.NewLine + data;
                Buffer.Add(Convert.ToByte(BaseConverter.ToNative(Binary)));
            }
            txtInBinary.Text = string.Join("", Bits.Select(B => B ? '1' : '0').ToArray()) + Environment.NewLine + Environment.NewLine + data;
            txtReaded.Text = Encoding.UTF8.GetString(Buffer.ToArray().Reverse().ToArray());
        }
    }
}