namespace UG_Project
{
    /// <summary>
    /// Example for partial class
    /// </summary>
    internal partial class SomePartialClass : BaseSomePartialClass
    {
        #region Public Constructors

        public SomePartialClass(string userName) : base($"{userName}: {++invokeCounter} instance")
        {
        }

        #endregion

        #region Public Methods

        public override void RemoveAll()
        {
            invokeCounter = 0;
            instances.Clear();
        }

        #endregion
    }
}
