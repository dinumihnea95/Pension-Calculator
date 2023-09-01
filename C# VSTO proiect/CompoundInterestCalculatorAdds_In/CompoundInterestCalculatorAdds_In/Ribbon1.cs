using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompoundInterestCalculatorAdds_In
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Open_Calculator(object sender, RibbonControlEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
