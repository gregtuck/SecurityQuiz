using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This class is used to clear text from Admn Panel text boxes
namespace SecurityQuiz
{
    class Utilities
    {
        public static void ClearPanels (GroupBox GB)
        {
            foreach (Control control in GB.Controls)
            {
                if(control is TextBox)
                {
                    TextBox txtbx = (TextBox)control;
                    txtbx.Text = null;
                }
            }
            
        }
    }
}