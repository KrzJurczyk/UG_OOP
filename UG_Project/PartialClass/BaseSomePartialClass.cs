using System.Collections;
using System.Collections.Generic;
using UG_Project.Interfaces;

namespace UG_Project
{
    /// <summary>
    /// Base for partials class
    /// </summary>
    internal abstract class BaseSomePartialClass : IPartialClassProvider
    {
        #region Private Fields

        protected static int invokeCounter = 0;
        protected static List<BaseSomePartialClass> instances = new List<BaseSomePartialClass>();

        protected string className;

        #endregion

        #region Public Constructors

        public BaseSomePartialClass(string userName)
        {
            this.className = userName;
            instances.Add(this);
        }

        #endregion

        #region Public Methods

        public abstract void RemoveAll();
        public abstract IEnumerable GetAllPartialClasses();

        #endregion
    }
}
