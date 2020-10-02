using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class ParentComponent
    {
        #region Private Property

        private ChildComponent Child { get; set; }

        #endregion Private Property

        #region Public Event Handler

        public void OnShowModelClick()
        {
            Child.ShowModel();
        }

        #endregion Public Event Handler
    }
}