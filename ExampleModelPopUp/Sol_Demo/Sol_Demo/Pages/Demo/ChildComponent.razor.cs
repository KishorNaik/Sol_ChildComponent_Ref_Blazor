using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class ChildComponent
    {
        #region Private Property

        private bool? IsDisplay { get; set; }

        #endregion Private Property

        #region Private Event Handler

        private void OnCancelModel()
        {
            IsDisplay = false;
            base.StateHasChanged();
        }

        #endregion Private Event Handler

        #region Public Method

        public void ShowModel()
        {
            IsDisplay = true;
            base.StateHasChanged();
        }

        #endregion Public Method
    }
}