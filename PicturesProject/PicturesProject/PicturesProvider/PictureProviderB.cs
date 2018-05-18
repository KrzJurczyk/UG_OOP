using System.Drawing;

namespace PicturesProject
{
    /// <summary>
    /// Partial for picture rare provider
    /// </summary>
    internal partial class PictureProvider : BasePictureProvider
    {
        #region Public Constructors

        public PictureProvider(string keyWord) : base(keyWord)
        {
        }

        #endregion

        #region Public Methods

        public override void RemoveAll()
        {
            listOfPictures.Clear();
        }

        public override Bitmap GetPic()
        {
            return base.Pict;
        }

        #endregion
    }
}
