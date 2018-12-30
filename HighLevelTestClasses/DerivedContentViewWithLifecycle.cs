namespace Com.MarcusTS.SmartDI.LifecycleAware.MSTests.HighLevelTestClasses
{
   using MarcusTS.LifecycleAware.Views.SubViews;

   public class DerivedContentViewWithLifecycle : ContentViewWithLifecycle
   {
      #region Public Methods

      public void CallForceDisappearing()
      {
         ForceDisappearing();
      }

      #endregion Public Methods
   }
}