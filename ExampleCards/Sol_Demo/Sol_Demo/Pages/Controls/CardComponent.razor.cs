using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Controls
{
    public partial class CardComponent
    {
        #region Public Parameter Property

        [Parameter]
        public String BackgroundColor { get; set; }

        [Parameter]
        public String ForegroundColor { get; set; }

        [Parameter]
        public String Width { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        #endregion Public Parameter Property

        #region Private Property

        private String Display { get; set; }

        #endregion Private Property

        #region Public Method

        public void SetVisible(bool visible)
        {
            if (visible)
            {
                Display = "";
            }
            else
            {
                Display = "d-none";
            }

            base.StateHasChanged();
        }

        #endregion Public Method
    }
}