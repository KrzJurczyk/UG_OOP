using System.Collections;
using System.Drawing;

namespace PicturesProject.Interfaces
{
    public interface IPictureProvider
    {
        /// <summary>
        /// Remove all objects
        /// </summary>
        void RemoveAll();

        /// <summary>
        /// Get lazy all objects of legal partial class
        /// </summary>
        /// <returns></returns>
        IEnumerable GetAllSearches();

        /// <summary>
        /// Search key word
        /// </summary>
        /// <returns></returns>
        string KeyWords();

        /// <summary>
        /// Found pick
        /// </summary>
        /// <returns></returns>
        Bitmap GetPic();
    }
}
