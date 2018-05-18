using System.Drawing;
using System.Windows.Forms;
using UG_Project;

namespace DISPLAY_UG_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var a = PicturesProvider.Instance;
            Image image = a.SearchNewPicture("cat");

            this.pictureBox1.Image = image;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
