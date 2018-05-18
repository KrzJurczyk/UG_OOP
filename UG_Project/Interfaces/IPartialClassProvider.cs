using System.Collections;

namespace UG_Project.Interfaces
{
    public interface IPartialClassProvider
    {
        /// <summary>
        /// Remove all objects
        /// </summary>
        void RemoveAll();

        /// <summary>
        /// Get lazy all objects of legal partial class
        /// </summary>
        /// <returns></returns>
        IEnumerable GetAllPartialClasses();
    }
}
