using System.Drawing;

namespace PicturesProject.Interfaces
{
    public interface ISearchClassProvider
    {
        /// <summary>
        /// Search img in google by keyword
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        Image SearchPicture(string keyWord);
    }
}
