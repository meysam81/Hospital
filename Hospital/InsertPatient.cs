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
    public partial class InsertPatient : Form
    {
        int pId;
        Random r = new Random();
        int minId = 951000, maxId = 969999;

        public InsertPatient()
        {
            InitializeComponent();
            numericUpDownPatientId.Value = r.Next(minId, maxId);
        }

        private void ShowInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PatientTable().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAcceptS1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetHospitalTableAdapters.TableSupplementary1TableAdapter ts1 = new DataSetHospitalTableAdapters.TableSupplementary1TableAdapter();
                ts1.Insert(pId, textBoxContagious.Text, textBoxSensitivity.Text, richTextBoxDescriptionPS.Text);
                MessageBox.Show("با موفقیت اضافه شد", "اطلاعات تکمیلی ۱", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("متاسفانه، انجام نشد", "اطلاعات تکمیلی ۱", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAcceptS2_Click(object sender, EventArgs e)
        {
            try
            {
                string pIA = textBoxPaidInAdvance.Text.Replace(",", "");
                DataSetHospitalTableAdapters.TableSupplementary2TableAdapter ts2 = new DataSetHospitalTableAdapters.TableSupplementary2TableAdapter();
                string marry = "";
                if (radioButtonMarried.Checked == true)
                    marry = "متأهل";
                else if (radioButtonMarried.Checked == true)
                    marry = "مجرد";
                ts2.Insert(pId, marry, textBoxJob.Text, textBoxEducation.Text, textBoxMajor.Text, /*Convert.ToDecimal(pIA)*/null);
                MessageBox.Show("با موفقیت ثبت گردید", "اطلاعات تکمیلی ۲", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("متاسفانه، انجام نشد", "اطلاعات تکمیلی ۲", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPaidInAdvance_Leave(object sender, EventArgs e)
        {
            string num = "";
            try
            {
                int k = 0;
                for (int i = textBoxPaidInAdvance.Text.Length - 1; i >= 0; i--)
                {
                    if (k < 2)
                    {
                        num = textBoxPaidInAdvance.Text[i] + num;
                        k++;
                    }
                    else
                    {
                        k = 0;
                        num = textBoxPaidInAdvance.Text[i] + num;
                        num = "," + num;
                    }
                }
                if (num[0] == ',')
                    num = num.Substring(1);
            }
            catch
            {
            }
            textBoxPaidInAdvance.Text = num;
        }

        private void textBoxPaidInAdvance_Enter(object sender, EventArgs e)
        {
            textBoxPaidInAdvance.Text = textBoxPaidInAdvance.Text.Replace(",", "");
        }

        private void buttonPE_Click(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.TableEscortTableAdapter pe = new DataSetHospitalTableAdapters.TableEscortTableAdapter();
            string rel, c, add, pn1, pn2, pc;
            rel = textBoxRelationShip.Text;
            c = textBoxCityPE.Text;
            add = richTextBoxAddressPE.Text;
            pn1 = textBoxPN1PE.Text;
            pn2 = textBoxPN2PE.Text;
            pc = textBoxPostCodePE.Text;
            try
            {
                pe.Insert(pId, rel, c, add, pn1, pn2, pc);
                MessageBox.Show("با موفقیت اضافه شد", "همراه بیمار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("انجام نپذیرفت", "همراه بیمار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHA_Click(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.TableHomeAddressTableAdapter tha = new DataSetHospitalTableAdapters.TableHomeAddressTableAdapter();
            string c, pn1, pn2, add, pc;
            c = textBoxCityHA.Text;
            pn1 = textBoxPN1HA.Text;
            pn2 = textBoxPN2HA.Text;
            add = richTextBoxAddressHA.Text;
            pc = textBoxPostCodeHA.Text;
            try
            {
                tha.Insert(pId, c, pn1, pn2, add, pc);
                MessageBox.Show("با موفقیت اضافه شد", "آدرس منزل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("انجام نپذیرفت", "آدرس منزل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWA_Click(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.TableWorkAddressTableAdapter twa = new DataSetHospitalTableAdapters.TableWorkAddressTableAdapter();
            string wpn, c, pn1, pn2, add, pc, fax;
            wpn = textBoxWorkName.Text;
            c = textBoxCityWA.Text;
            pn1 = textBoxPN1WA.Text;
            pn2 = textBoxPN2WA.Text;
            add = richTextBoxAddressWA.Text;
            pc = textBoxPostCodeWA.Text;
            fax = textBoxFax.Text;
            try
            {
                twa.Insert(pId, wpn, c, add, pn1, pn2, fax, pc);
                MessageBox.Show("با موفقیت اضافه شد", "آدرس محل کار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("انجام نپذیرفت", "آدرس محل کار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
            labelShowDate.Text = Persia.Calendar.ConvertToPersian(dateTimePickerBirthDate.Value).ToString();
        }

        private void InsertPatient_Load(object sender, EventArgs e)
        {
            labelShowDate.Text = Persia.Calendar.ConvertToPersian(dateTimePickerBirthDate.Value).ToString();
        }

        private void formCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCashier().ShowDialog();
        }

        private void buttonAcceptPS_Click(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.TablePrimeSpecsTableAdapter ta = new DataSetHospitalTableAdapters.TablePrimeSpecsTableAdapter();
            try
            {
                string gen = "";
                if (radioButtonMan.Checked == true)
                    gen = "مرد";
                else if (radioButtonWoman.Checked == true)
                    gen = "زن";
                ta.Insert(Convert.ToInt32(numericUpDownPatientId.Value), textBoxFirstName.Text, textBoxLastName.Text, textBoxFathersName.Text,
                    textBoxSocialSecurityNumber.Text, gen, dateTimePickerBirthDate.Value, textBoxCityPS.Text,
                    richTextBoxAddressPS.Text, richTextBoxDescriptionPS.Text);
                pId = Convert.ToInt32(numericUpDownPatientId.Value);
                textBoxPatientIdHA.Text = pId.ToString();
                textBoxPatientIdPE.Text = pId.ToString();
                textBoxPatientIdS1.Text = pId.ToString();
                textBoxPatientIdS2.Text = pId.ToString();
                textBoxPatientIdWA.Text = pId.ToString();
                numericUpDownPatientId.Value = r.Next(minId, maxId);
                MessageBox.Show("با موفقیت اضافه شد", "مشخصات اولیه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("متاسفانه، انجام نشد", "مشخصات اولیه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}