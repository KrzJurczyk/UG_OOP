using System.Drawing;
using PicturesProject.Interfaces;

namespace PicturesProject.PictureSearcher
{
    /// <summary>
    /// Provide instance for pic searcher
    /// </summary>
    public class PicSearcherProvider : ISearchClassProvider
    {
        #region Private Fields

        private PicSearcher searcher;

        #endregion

        #region Public Constructors

        public PicSearcherProvider()
        {
        }

        #endregion

        #region Public Methods

        public Image SearchPicture(string keyWord)
        {
            searcher = new PicSearcher(keyWord);
            return searcher.TakePicture();
        }

        #endregion
    }
}
