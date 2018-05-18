using System.Collections.Generic;
using UG_Project.Interfaces;

namespace UG_Project
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class PartialClassesProvider
    {
        #region Private Fields

        private static PartialClassesProvider instance;
        private IPartialClassProvider partialClassInstance;

        #endregion

        #region Private Constructors

        private PartialClassesProvider() { }

        #endregion

        #region Public Constructor

        public static PartialClassesProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PartialClassesProvider();
                }
                return instance;
            }
        }

        #endregion

        #region Public Methods

        public void CreateNewPartialClass()
        {
            partialClassInstance = new SomePartialClass();
        }

        public void CreateNewPartialClass(string nameForObject)
        {
            partialClassInstance = new SomePartialClass(nameForObject);
        }

        public List<string> GetListOfPartalClasses()
        {
            List<string> dummyList = new List<string>();
            int counter = 0;
            foreach (var item in partialClassInstance.GetAllPartialClasses())
            {
                dummyList.Add($"{counter++}>> {item.ToString()}");
            }
            return dummyList;
        }

        public void RemoveAllPartialClasses()
        {
            partialClassInstance.RemoveAll();
        }

        #endregion

    }
}
