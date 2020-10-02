using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class ParentComponent
    {
        #region Private Method

        private ChildComponent Child { get; set; }

        #endregion Private Method

        #region Event Handler

        public void OnShowModelClick()
        {
            Child.ShowModel();
        }

        #endregion Event Handler
    }
}