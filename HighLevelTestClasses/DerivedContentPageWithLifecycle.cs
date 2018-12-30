namespace Com.MarcusTS.SmartDI.LifecycleAware.MSTests.HighLevelTestClasses
{
   using MarcusTS.LifecycleAware.Views.Pages;

   public class DerivedContentPageWithLifecycle : ContentPageWithLifecycle
   {
      #region Public Methods

      public void CallForceDisappearing()
      {
         ForceDisappearing();
      }

      #endregion Public Methods
   }
}