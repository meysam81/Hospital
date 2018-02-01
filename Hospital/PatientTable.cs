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
    public partial class PatientTable : Form
    {
        public PatientTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHospital1.MyView' table. You can move, or remove it, as needed.
            this.myViewTableAdapter.Fill(this.dataSetHospital1.MyView);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
                contextMenuStrip1.Top = this.Top + e.Y + 30;
                contextMenuStrip1.Left = this.Left + e.X + 10;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.TablePrimeSpecsTableAdapter tps = new DataSetHospitalTableAdapters.TablePrimeSpecsTableAdapter();
            FormReleasePatient f = new FormReleasePatient();
            f.PId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            f.SSN = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (MessageBox.Show("آیا از ترخیص بیمار مربوطه اطمینان دارید؟", "ترخیص بیمار",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

                try
                {
                    f.ShowDialog();
                    if (f.Release)
                    {
                        tps.DeleteQuery(f.SSN, f.PId);
                        MessageBox.Show("با موفقیت ترخیص شد", "ترخیص بیمار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        throw new Exception();
                }
                catch
                {
                    MessageBox.Show("انجام نشد", "ترخیص بیمار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.myViewTableAdapter.Fill(this.dataSetHospital1.MyView);
                }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.myViewTableAdapter.Fill(this.dataSetHospital1.MyView);
        }

        private void textBoxSearchSSN_TextChanged(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.MyViewTableAdapter mvt = new DataSetHospitalTableAdapters.MyViewTableAdapter();
            mvt.FillBySSN(dataSetHospital1.MyView, textBoxSearchSSN.Text);
        }

        private void textBoxSearchByPId_TextChanged(object sender, EventArgs e)
        {
            DataSetHospitalTableAdapters.MyViewTableAdapter mvt = new DataSetHospitalTableAdapters.MyViewTableAdapter();
            if (textBoxSearchByPId.Text != "")
                mvt.FillBypId(dataSetHospital1.MyView, Convert.ToInt32(textBoxSearchByPId.Text));
            else
                this.myViewTableAdapter.Fill(this.dataSetHospital1.MyView);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}