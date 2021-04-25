using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExample
{
    public partial class Form1 : Form
    {
        // our Logistics images path: @"D:\Winbooks\Logistics\BAOBAB\DATA\pictures\art"
        // protected string ImagesLocation = @"D:\Winbooks\Logistics\BAOBAB\DATA\pictures\art";
        protected string ImageFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // I used here an Open File Dialog to load an image of choice.
            // It can be an image from the Web, little adjustement needed
            // It can come from a database - in our case combinig the ImagesLocation (above) with the ImageFileName,
            // which is the 'artid' of the product in case. add '.jpg' as extension.
            // result would look like @"D:\Winbooks\Logistics\BAOBAB\DATA\pictures\art\MAX10CRI.JPG"
            // REMARK: care on case sensitive text to fit the image name.
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JPEG|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFileName = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(ImageFileName);
                // to fit the PictureBox size, best use PictureBoxSizeMode.Zoom
                // and the system will manage the image resizing (very well).
                // Alternatively, you can use little more to adjust the image size using Cubic transformations,
                // or apply filters, or... "Photoshop" it right here.
                // I think this line is all you need to add and it's what you were not able to do in Logistics.
                // Enjoy it! :)
                //
                // With compliments,
                //
                // Ovidiu :)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
