using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CompoundInterestCalculatorAdds_In
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public bool validate_inputs()
        {
            return (name_txt.Text != "" && initial_invest.Value != 0
                && interest_rate.Value != 0 && num_years_retirement.Value != 0
                && monthly_contrib.Value != 0);
        }
        public void headers_initializations(ref dynamic sheet,int index_of_table_start)
        {
            sheet.Range("A"+ index_of_table_start.ToString()).Value = "An";
            sheet.Range("B" + index_of_table_start.ToString()).Value = "Depozit";
            sheet.Range("C" + index_of_table_start.ToString()).Value = "Dobanda";
            sheet.Range("D" + index_of_table_start.ToString()).Value = "Bani depusi";
            sheet.Range("E" + index_of_table_start.ToString()).Value = "Dobanda acumulata";
            sheet.Range("F" + index_of_table_start.ToString()).Value = "Balanta";
        }
        private void calculate_click(object sender, EventArgs e)
        {
            int index_of_table_start = 2;

            if (validate_inputs())
            {
                string name = name_txt.Text;
                float initial_invests = (float)initial_invest.Value;
                float interest_rates = (float)interest_rate.Value;
                float num_year_to_retire = (float)num_years_retirement.Value;
                float monthly_contribution = (float)monthly_contrib.Value;
                float current_deposit = 0;
                var sheet = Globals.ThisAddIn.Application.ActiveSheet;
                headers_initializations(ref sheet, index_of_table_start);


                for (int i = 0; i < num_year_to_retire + 1; i++)
                {
                        current_deposit = i == 0 ? initial_invests : monthly_contribution * 12;
                        index_of_table_start += 1;
                        sheet.Range("A" + index_of_table_start.ToString() ).Value = i;

                        sheet.Range("B" + index_of_table_start.ToString()).Value = current_deposit;


                    sheet.Range("D" + index_of_table_start.ToString()).Value = 
                        i == 0 ?  current_deposit 
                        :
                        (float)sheet.Range("D" + (index_of_table_start - 1).ToString()).Value +
                        current_deposit;

                    sheet.Range("C" + index_of_table_start.ToString()).Value =
                        i == 0 ? 0
                        :
                        (float)sheet.Range("D" + (index_of_table_start).ToString()).Value * (interest_rates/100);


                    sheet.Range("E" + index_of_table_start.ToString()).Value =
                        i == 0 ? 0
                        :
                        (float)sheet.Range("E" + (index_of_table_start-1).ToString()).Value +
                        (float)sheet.Range("C" + index_of_table_start.ToString()).Value
                        ;


                    sheet.Range("F" + index_of_table_start.ToString()).Value =
                        i == 0 ? current_deposit
                        :
                        (float)sheet.Range("D" + index_of_table_start.ToString()).Value +
                        (float)sheet.Range("E" + index_of_table_start.ToString()).Value;
               
                    try
                    {
                        if (i == (int)num_year_to_retire)
                        {
                            
                              sheet.Range("A1").Value = "Pensia dupa " + num_year_to_retire.ToString() + " ani este " +
                               ((decimal)sheet.Range("F" + index_of_table_start.ToString()).Value).ToString();

                            database db = new database();
                            db.insert_data_into_table(name, initial_invests, interest_rates,
                                num_year_to_retire, monthly_contribution,
                                (float)sheet.Range("E" + index_of_table_start.ToString()).Value,
                                (float)sheet.Range("F" + index_of_table_start.ToString()).Value);
                        }
                    }
                    catch (Exception ex)
                            {
                            MessageBox.Show(ex.Message);
                             } 
                    }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
