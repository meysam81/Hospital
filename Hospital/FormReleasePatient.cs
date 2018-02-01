using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormReleasePatient : Form
    {
        public FormReleasePatient()
        {
            InitializeComponent();
        }
        public int PId { get; set; }
        public string SSN { get; set; }
        public bool Release { get; set; }
        decimal totalPrice = 0;
        private void buttonAcceptRelease_Click(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.TableReleaseTableAdapter rp =
                new DataSetHospitalTableAdapters.TableReleaseTableAdapter();
            string temp = textBoxPrice.Text.Replace(",", "");
            try
            {
                buttonBaresiTaghirat_Click(null, null);
                rp.Insert(PId, SSN, Convert.ToInt32(temp), dateTimePickerTarkhis.Value);
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "ترخیص بیمار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Release = true;
            }
            catch
            {
                Release = false;
                MessageBox.Show("انجام نشد", "ترخیص بیمار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void FormReleasePatient_Activated(object sender, EventArgs e)
        {
            textBoxTarkhis.Text = Persia.Calendar.ConvertToPersian(dateTimePickerTarkhis.Value).ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormReleasePatient_Load(object sender, EventArgs e)
        {
            textBoxPatientId.Text = PId.ToString();
            textBoxSSN.Text = SSN;
            textBoxPrice.Text = "0";
        }

        private void showPriceTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCashier().ShowDialog();
        }

        private static string StarndardSaziePoul(decimal v)
        {
            string num = "";
            string s = v.ToString();
            try
            {
                int k = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (k < 2)
                    {
                        num = s[i] + num;
                        k++;
                    }
                    else
                    {
                        k = 0;
                        num = s[i] + num;
                        num = "," + num;
                    }
                }
                if (num[0] == ',')
                    num = num.Substring(1);
            }
            catch { }
            return num;
        }

        private void buttonBaresiTaghirat_Click(object sender, EventArgs e)
        {
            if (checkBoxAzmayeshgah.Checked)
                totalPrice += 300000;
            if (checkBoxBakhsheKhosousi.Checked)
                totalPrice += 2000000;
            if (checkBoxBastari.Checked)
                totalPrice += (numericUpDownBastari.Value * 200000);
            if (checkBoxJarahi.Checked)
                totalPrice += 2000000;
            if (checkBoxPazireshOrjansi.Checked)
                totalPrice += 300000;
            if (checkBoxRadioLojy.Checked)
                totalPrice += 400000;
            if (checkBoxTazrighat.Checked)
                totalPrice += 200000;
            if (checkBoxDarayeBime.Checked)
                if (totalPrice > 100000)
                    totalPrice = 80000;
                else
                    totalPrice = 30000;
            textBoxPrice.Text = StarndardSaziePoul(totalPrice);
        }

        private void checkBoxBastari_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBastari.Checked)
                numericUpDownBastari.Enabled = true;
            else
                numericUpDownBastari.Enabled = false;
        }

        private void dateTimePickerTarkhis_ValueChanged(object sender, EventArgs e)
        {
            textBoxTarkhis.Text = Persia.Calendar.ConvertToPersian(dateTimePickerTarkhis.Value).ToString();
        }
    }
}