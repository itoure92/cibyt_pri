using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cibyt_pri.DataModel
{
    class ApplicationPage
    {
        public Window mWindow;
        public PageType pageType;

        public ApplicationPage(Window window, PageType pageType)
        {
            this.mWindow = window;
            this.pageType = pageType;
        }
    }

    
}
