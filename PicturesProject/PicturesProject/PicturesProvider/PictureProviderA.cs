using System.Collections;
using System.Drawing;

namespace PicturesProject
{
    /// <summary>
    /// WATCH OUT! THIS IS AN EMPTY CONSTRUCTOR!!!!!!1111
    /// </summary>
    internal partial class PictureProvider : BasePictureProvider
    {
        #region Public Constructors

        public PictureProvider() : base("xxx")
        {
        }

        #endregion

        #region Public Methods
        
        public override IEnumerable GetAllSearches()
        {
            BasePictureProvider obj;
            if (listOfPictures.Count == 0)
                yield return "No created object yet";
            foreach (var item in listOfPictures)
            {
                obj = item;
                yield return obj;
            }
        }

        public override string KeyWords()
        {
            return keyWord;
        }

        #endregion
    }
}
