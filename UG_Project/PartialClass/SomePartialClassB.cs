using System.Collections;

namespace UG_Project
{
    /// <summary>
    /// Example for partial class
    /// </summary>
    internal partial class SomePartialClass : BaseSomePartialClass
    {
        #region Public Constructors

        public SomePartialClass() : base($"{nameof(SomePartialClass)}: {++invokeCounter} instance")
        {
        }

        #endregion

        #region Public Methods
        
        public override IEnumerable GetAllPartialClasses()
        {
            string str = "";
            
            if (instances.Count == 0)
                yield return "No created object yet";
            foreach (var item in instances)
            {
                str = item.ToString();
                yield return str;
            }
        }

        public override string ToString()
        {
            return className;
        }

        #endregion
    }
}
