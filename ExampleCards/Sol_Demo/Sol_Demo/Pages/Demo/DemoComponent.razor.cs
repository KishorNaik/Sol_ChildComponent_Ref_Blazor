using Sol_Demo.Pages.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class DemoComponent
    {
        #region Cards Referance Property

        private CardComponent Card1 { get; set; }
        private CardComponent Card2 { get; set; }

        #endregion Cards Referance Property

        #region Private Property

        private String HideToggleButtonText { get; set; }

        #endregion Private Property

        #region Public Event Handler

        public void OnHideShowCardsEventHandler()
        {
            if (HideToggleButtonText == "Hide")
            {
                Card1.SetVisible(false);
                Card2.SetVisible(false);

                HideToggleButtonText = "Show";
            }
            else if (HideToggleButtonText == "Show")
            {
                Card1.SetVisible(true);
                Card2.SetVisible(true);

                HideToggleButtonText = "Hide";
            }

            base.StateHasChanged();
        }

        #endregion Public Event Handler

        #region Protected Method

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                HideToggleButtonText = "Hide";

                base.StateHasChanged();
            }
        }

        #endregion Protected Method
    }
}