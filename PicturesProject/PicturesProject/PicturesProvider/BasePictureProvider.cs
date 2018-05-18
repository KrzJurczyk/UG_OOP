using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using PicturesProject.Interfaces;
using PicturesProject.PictureSearcher;

namespace PicturesProject
{
    /// <summary>
    /// Base for picture provider
    /// </summary>
    internal abstract class BasePictureProvider : IPictureProvider
    {
        #region Private Fields
        
        protected List<BasePictureProvider> listOfPictures = new List<BasePictureProvider>();
        
        protected string keyWord;
        private Bitmap pict;

        #endregion

        #region Protected Properties

        protected Bitmap Pict { get { return this.pict; } }

        #endregion

        #region Public Constructors

        public BasePictureProvider(string keySearch)
        {
            this.keyWord = keySearch;
            listOfPictures.Add(this);
            pict = new Bitmap(new PicSearcherProvider().SearchPicture(keySearch));
        }

        #endregion

        #region Public Methods

        public virtual string KeyWords()
        {
            return "xxx";
        }

        public abstract void RemoveAll();
        public abstract IEnumerable GetAllSearches();
        public abstract Bitmap GetPic();

        #endregion
    }
}
