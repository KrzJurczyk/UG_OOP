using System.Collections.Generic;
using System.Drawing;
using PicturesProject.Interfaces;

namespace PicturesProject
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class StratPicturesProvider
    {
        #region Private Fields

        private static StratPicturesProvider instance;
        private IPictureProvider picProviderInstance;

        #endregion

        #region Private Constructors

        private StratPicturesProvider() { }

        #endregion

        #region Public Constructor

        public static StratPicturesProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StratPicturesProvider();
                }
                return instance;
            }
        }

        #endregion

        #region Public Methods

        public Bitmap SearchNewPicture()
        {
            var pic = new PictureProvider();
            picProviderInstance = pic;
            return pic.GetPic();
        }

        public Bitmap SearchNewPicture(string nameForObject)
        {
            var pic = new PictureProvider(nameForObject);
            picProviderInstance = pic;
            return pic.GetPic();
        }

        public List<string> GetAllSearchedPic()
        {
            List<string> dummyList = new List<string>();
            foreach (var item in picProviderInstance.GetAllSearches())
            {
                var a = item as BasePictureProvider;
                if (item != null)
                    dummyList.Add(a.KeyWords());
                else
                    dummyList.Add("Unlucky");
            }
            return dummyList;
        }

        public void RemoveAllPartialClasses()
        {
            picProviderInstance.RemoveAll();
        }

        #endregion

    }
}
