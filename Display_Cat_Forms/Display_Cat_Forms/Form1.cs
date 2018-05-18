using PicturesProject;
using System.Drawing;
using System.Windows.Forms;

namespace Display_Cat_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Disgusting();
        }

        private void Disgusting()
        {
            var dummy = StratPicturesProvider.Instance;
            Image img = dummy.SearchNewPicture("cat");
            this.pictureBox1.Image = img;
        }
    }
}
