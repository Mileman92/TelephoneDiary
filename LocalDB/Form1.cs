using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocalDB
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
         
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            this.phoneBooksTableAdapter.Fill(this.database1DataSet.PhoneBooks);
            Edit(false);


          
        }

        private void Edit(bool value)
        {
            txtFullName.Enabled = value;
            txtPhoneNumber.Enabled = value;
            txtEmail.Enabled = value;
            txtAdress.Enabled = value;
            txtSearch.Enabled = value;
        }

        private void newButton_Click(object sender, EventArgs e) 
        {
            try
            {
                Edit(true);
                database1DataSet.PhoneBooks.AddPhoneBooksRow(database1DataSet.PhoneBooks.NewPhoneBooksRow());
                phoneBooksBindingSource.MoveLast();
                txtFullName.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.PhoneBooks.RejectChanges();
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtPhoneNumber.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Edit(false);
            phoneBooksBindingSource.ResetBindings(false);
            DialogResult dR= MessageBox.Show("Exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if (DialogResult.Yes == dR )
            {
                DialogResult dR1 = MessageBox.Show("Do you want Save?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dR1)
                {
                    Edit(false);
                    phoneBooksTableAdapter.Update(database1DataSet.PhoneBooks);
                    txtFullName.Focus();
                    Close();
                }
                else
                {
                    Close();
                }
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                phoneBooksBindingSource.EndEdit();
                phoneBooksTableAdapter.Update(database1DataSet.PhoneBooks);
                dataGridView1.Refresh();
                phoneBooksBindingSource.MoveLast();
                txtPhoneNumber.Focus();
                MessageBox.Show("Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.PhoneBooks.RejectChanges();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    phoneBooksBindingSource.Filter = string.Format("PhoneNumber = '{0}' OR FullName LIKE '*{1}*' OR Email = '{2}' OR Address LIKE '*{3}*'", txtFullName.Text, txtPhoneNumber.Text, txtEmail.Text, txtAdress.Text);
                else
                    phoneBooksBindingSource.Filter = string.Empty;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult dR = MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dR)
                {
                    phoneBooksBindingSource.RemoveCurrent();
                }
                else
                {
                    phoneBooksBindingSource.EndEdit();

                }
            }
        }
      
    
        private void refreshButton_Click(object sender, EventArgs e)
        {
            
            this.phoneBooksTableAdapter.Fill(this.database1DataSet.PhoneBooks);



        }


        private void materialFlatButton6_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSearchS.Text))
            {

               //// this.phoneBooksBindingSource.Filter = string.Format("Ime='{0}' OR Prezime='{0}' OR Mesto='{0}' OR Telefon='{0}' OR Email='{0}' ", txtFullName.Text);
                //this.phoneBooksBindingSource.Filter = string.Format("Ime='{0}' OR Prezime='{0}' OR Mesto='{0}' OR Telefon='{0}' OR Email='{0}' ", tableBindingSource);
                //this.phoneBooksBindingSource.Filter = string.Format("Ime='{0}' OR Prezime='{0}' OR Mesto='{0}' OR Telefon='{0}' OR Email='{0}' ", txtSearchS.Text);
                //dataGridView1.Show();

                // dataGridView1.Rows.GetFirstRow  = string.Format("Ime='{0}%' OR Prezime='{0}%' OR Mesto='{0}%' OR Telefon='{0}%' OR Email='{0}%' ", txtFullName.Text);



                //for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
                //{
                //    if (this.dataGridView1.Rows[i].Cells[2].Value.ToString() == this.txtFullName.Text)
                //    {
                //        MessageBox.Show("Ima");
                //    }
                //}

                if (txtSearchS.Text == string.Empty)
                {
                    phoneBooksBindingSource.RemoveFilter();
                }
                else
                {
                    phoneBooksBindingSource.Filter = string.Format("Ime='{0}' OR Prezime='{0}' OR Mesto='{0}' OR Telefon='{0}' OR Email='{0}' ", txtFullName.Text);

                }
            }

            else
            {

                MessageBox.Show("Not found");
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dR)
            {
                 phoneBooksBindingSource.RemoveCurrent();

                for (int i = dataGridView1.Rows.Count - 1; i > 0; i--)
                {
                    DataGridViewRow row = dataGridView1.Rows[i - 1];
                    if (Convert.ToBoolean(row.Cells["Column1"].Value) == true)
                    {

                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

       
  

        private void materialFlatButton4_Click(object sender, EventArgs e) //SAVE
        {
            try
            {
                Edit(false);
                phoneBooksTableAdapter.Update(database1DataSet.PhoneBooks);
                txtFullName.Focus();
                MessageBox.Show("Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.PhoneBooks.RejectChanges();
            }
        }

        // Bitmap bmp;
        private void materialFlatButton8_Click(object sender, EventArgs e)
        {


          

            XtraReport1 report = new XtraReport1();
           
             report.ShowPreview();
                  
            
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DialogResult dR = MessageBox.Show("Print Select?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dR)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    bool isCellChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                    if (isCellChecked == true)
                    {

                        var allCheckedRows = this.dataGridView1.Rows.Cast<DataGridViewRow>()
                                   .Where(row => (bool?)row.Cells[0].Value == true)
                                   .ToList();
                        
                        var builder = new StringBuilder();

                        allCheckedRows.ForEach(row =>
                        {

                            var cellValues = row.Cells.Cast<DataGridViewCell>()
                                .Where(cell => cell.ColumnIndex > 0)
                                .Select(cell => string.Format("{0}   ", cell.Value))
                                .ToArray();

                           
                            builder.AppendLine(string.Join("                             ", cellValues));

                           
                        });

                        Font fsystem = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Pixel);
                        Font fsystem1 = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel);
                        Font fsystem2 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        e.Graphics.DrawString("PHONE BOOKS", fsystem, Brushes.Black, 300, 30);
                        e.Graphics.DrawString("FULL NAME", fsystem1, Brushes.Black, 40, 60);
                        e.Graphics.DrawString("PHONE NUMBER", fsystem1, Brushes.Black, 200, 60);
                        e.Graphics.DrawString("EMAIL", fsystem1, Brushes.Black, 420, 60);
                        e.Graphics.DrawString("ADDRESS", fsystem1, Brushes.Black, 540, 60);
                        e.Graphics.DrawString("LOCATION", fsystem1, Brushes.Black, 680, 60);
                        e.Graphics.DrawString(builder.ToString(), fsystem2,
                           //this.dataGridView1.Font,
                           new SolidBrush(this.dataGridView1.ForeColor),
                           new RectangleF(30, 80, this.printDocument1.DefaultPageSettings.PrintableArea.Width, this.printDocument1.DefaultPageSettings.PrintableArea.Height));


                    }
                    else
                    {
                        
                    }

                }
            }
            else  //if(DialogResult.No == dR)
            { 
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                bool isCellChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                    if (isCellChecked == false)
                    {

                        var allCheckedRows = this.dataGridView1.Rows.Cast<DataGridViewRow>()
                                   .Where(row => (bool?)row.Cells[0].Value == null)
                                   .ToList();

                        var builder = new StringBuilder();

                        allCheckedRows.ForEach(row =>
                        {

                            var cellValues = row.Cells.Cast<DataGridViewCell>()
                                .Where(cell => cell.ColumnIndex > 0)
                                .Select(cell => string.Format("{0}     ", cell.Value))
                                .ToArray();


                            builder.AppendLine(string.Join("                             ", cellValues));

                        });

                        Font fsystem = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Pixel);
                        Font fsystem1 = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel);
                        Font fsystem2 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        e.Graphics.DrawString("PHONE BOOKS", fsystem, Brushes.Black, 300, 30);
                        e.Graphics.DrawString("FULL NAME", fsystem1, Brushes.Black, 40, 60);
                        e.Graphics.DrawString("PHONE NUMBER", fsystem1, Brushes.Black, 200, 60);
                        e.Graphics.DrawString("EMAIL", fsystem1, Brushes.Black, 420, 60);
                        e.Graphics.DrawString("ADDRESS", fsystem1, Brushes.Black, 540, 60);
                        e.Graphics.DrawString("LOCATION", fsystem1, Brushes.Black, 680, 60);
                        e.Graphics.DrawString(builder.ToString(), fsystem2,
                           //this.dataGridView1.Font,
                           new SolidBrush(this.dataGridView1.ForeColor),
                           new RectangleF(30, 80, this.printDocument1.DefaultPageSettings.PrintableArea.Width, this.printDocument1.DefaultPageSettings.PrintableArea.Height));

                    }
                    else
                    {
                        
                    }
                }

            }

        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.ShowDialog();
        
        }
    }
}
