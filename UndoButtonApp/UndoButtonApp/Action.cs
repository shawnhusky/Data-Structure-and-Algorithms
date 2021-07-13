using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UndoButtonApp
{
    class actionClass
    {
         private string actionName;

        public actionClass(string an)
        {
            actionName = an;
        }

        public string ActionName
        {
            get { return actionName; }
            set { actionName = value; }
        }

    }

}
