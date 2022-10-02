using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippodrome.Tables;

namespace Hippodrome
{
    public partial class FormRate : FormMainClient
    {
        public FormRate()
        {
            InitializeComponent();
            cbRacing_Load();
            cbRate_Load();
            dtgRateClient_Load();
        }



        private void cbRacing_Load()
        {

            RacingService racing = new RacingService();
            racing.RacingForRateLook(cbRacing);
        }

        private void cbRate_Load()
        {
            RateService rate = new RateService();
            rate.ComboxIns(cbRate, (@"SELECT Номер, Название FROM  [Тип ставки]"), "Название", "Номер");
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            dtgRateCoefficient_Load();
            rtbInfo_Load();
        }



        private void rtbInfo_Load()
        {
            RateService rate = new RateService();
            rate.RateInfo(rtbInfo, Convert.ToInt32(cbRate.SelectedValue));

        }

        private void dtgRateCoefficient_Load()
        {
            RateService rate = new RateService();
           rate.RateCoefficientLook(dtgRateCoefficient, Convert.ToInt32(cbRacing.SelectedValue), Convert.ToInt32(cbRate.SelectedValue));
        }



        private void dtgRateClient_Load()
        {
            RateService rate = new RateService();
            rate.RateClientLook(dtgRateClient);
        }

             
        private void btView_Click(object sender, EventArgs e)
        {
            decimal koeff = RateError();
            if (koeff!=0)
            {
                rtbShow.Text = " Скачки: " + (cbRacing.Text);
                rtbShow.AppendText ("\n Ставка: " + (cbRate.Text));
                rtbShow.AppendText ( "\n Коэффициент:  " + Convert.ToString(koeff));
                rtbShow.AppendText ( "\n Лошади: ");
                if ((Convert.ToInt32(cbRate.SelectedValue)) != 4)
                {
                    foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                    {
                        if (object.Equals(Row.Cells["ch1"].Value, true))
                        { rtbShow.AppendText  ("\n         " + Convert.ToString(Row.Cells["name"].Value)); }

                    }
                }
                else
                {
                    foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                    {
                        if (object.Equals(Row.Cells["ch1"].Value, true))
                        { rtbShow.AppendText ("\n    На первое место:  " + Convert.ToString(Row.Cells["name"].Value)); }
                        if (object.Equals(Row.Cells["ch2"].Value, true))
                        { rtbShow.AppendText  ("\n На призовое место:  " + Convert.ToString(Row.Cells["name2"].Value)); }
                    }
                }
                rtbShow.AppendText ("\n Максимальный выигрыш: " + Convert.ToString(((Convert.ToDecimal(mtbSum.Text))*koeff))) ;


            }

        }


        private decimal RateError()
        {
            int k = 0;
            decimal a = 1;
            string error = null;
            errorProvider1.Clear();
            string horse1 = "1";
            string horse2 = "2";
            if ((Convert.ToInt32(cbRate.SelectedValue)) != 5)
            {
                foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                { if ((object.Equals(Row.Cells["ch1"].Value, true))) { k++; a *= Convert.ToDecimal(Row.Cells["k"].Value); horse1 = Convert.ToString(Row.Cells["name"].Value); } }
                if (k != 1)
                { error = "Не верно выбраны лошади, посмотрите описание"; errorProvider1.SetError(rtbInfo, error); }
            }
            else
            {
                foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                { if ((object.Equals(Row.Cells["ch1"].Value, true))) { k++; a *= Convert.ToDecimal(Row.Cells["k"].Value); } }
                if (k != 3)
                { error = "Не верно выбраны лошади, посмотрите описание"; errorProvider1.SetError(rtbInfo, error); }
            }
            if ((Convert.ToInt32(cbRate.SelectedValue)) == 4)
            {
                foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                { if ((object.Equals(Row.Cells["ch2"].Value, true)))
                    {
                        k++;
                        a *= Convert.ToDecimal(Row.Cells["k2"].Value);
                        horse2 = Convert.ToString(Row.Cells["name2"].Value);
                    }
                }
                if (k != 2)
                { error = "Не верно выбраны лошади, посмотрите описание"; errorProvider1.SetError(rtbInfo, error); }
                else
                    if (horse1 == horse2)
                { error = "Выберите разных лошадей"; errorProvider1.SetError(rtbInfo, error); }
            }
            try { Convert.ToInt32(mtbSum.Text); }
            catch { error = "Введите сумму"; errorProvider1.SetError(mtbSum, error); }
            if (error is null)
            { return a; }
            else { return 0; }

        }
        

        private void btIns_Click(object sender, EventArgs e)
        {
            decimal koeff = RateError();
            if (koeff != 0)
            {
                RateService rate = new RateService();
                foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                {
                    if (object.Equals(Row.Cells["ch1"].Value, true))
                    { rate.InsRate(Convert.ToInt16(cbRacing.SelectedValue), Convert.ToDecimal(mtbSum.Text) , Convert.ToString(Row.Cells["id"].Value) ,
                          Convert.ToInt16(cbRate.SelectedValue))  ; }

                }
                if ((Convert.ToInt32(cbRate.SelectedValue)) == 4)
                {
                    foreach (DataGridViewRow Row in dtgRateCoefficient.Rows)
                    {
                        if (object.Equals(Row.Cells["ch2"].Value, true))
                        {
                            rate.InsRate(Convert.ToInt16(cbRacing.SelectedValue), Convert.ToDecimal(mtbSum.Text), Convert.ToString(Row.Cells["id"].Value),
                                Convert.ToInt16(cbRate.SelectedValue));
                        }
                    }
                }

            }

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            dtgRateClient.Rows.Clear();
            dtgRateClient_Load();
        }
    }
}
