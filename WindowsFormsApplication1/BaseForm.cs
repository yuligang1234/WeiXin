using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BaseForm : Form
    {



        public BaseForm(string filePath, string savePath)
        {
            InitializeComponent();
            axChinaExcel1.OpenFile(filePath);
            axChinaExcel1.SaveFile(savePath);
            Close();
        }



    }
}
