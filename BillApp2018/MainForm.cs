using System.Linq;
using System.Windows.Forms;

namespace BillApp2018
{
    public partial class MainForm : Form,IMainForm
    {
        TabChanger TabChangePresenter;
        public MainForm()
        {
            TabChangePresenter = new TabChanger(this);
            InitializeComponent();
        }

        public void SelectTabPage(string TabPageText)
        {
            if (tabControl1.SelectedTab.Text != TabPageText)
            {
               foreach(TabPage tabpage in tabControl1.TabPages)
                {
                    if (tabpage.Text == TabPageText)
                    {
                        tabControl1.SelectTab(tabpage);
                        break;
                    }
                    
                }
            }
               
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabChangePresenter.SelectTab(e.TabPage.Text);   
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            TabChangePresenter. SelectTab(textBox1.Text);
        }
    }
}
