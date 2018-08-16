using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillApp2018
{
    public class TabChanger
    {
        IMainForm mainForm;
        public TabChanger(IMainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public void SelectTab(string TabPageText)
        {
            mainForm.SelectTabPage(TabPageText);
        }
    }
}
