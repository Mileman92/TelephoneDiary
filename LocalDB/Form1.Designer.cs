namespace LocalDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phoneBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new LocalDB.Database1DataSet();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.phoneBooksTableAdapter = new LocalDB.Database1DataSetTableAdapters.PhoneBooksTableAdapter();
            this.txtSearchS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Full name:";
            // 
            // txtFullName
            // 
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Ime", true));
            this.txtFullName.Depth = 0;
            this.txtFullName.Hint = "";
            this.txtFullName.Location = new System.Drawing.Point(139, 94);
            this.txtFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.Size = new System.Drawing.Size(202, 23);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.UseSystemPasswordChar = false;
            // 
            // phoneBooksBindingSource
            // 
            this.phoneBooksBindingSource.DataMember = "PhoneBooks";
            this.phoneBooksBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Prezime", true));
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Hint = "";
            this.txtPhoneNumber.Location = new System.Drawing.Point(139, 123);
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.Size = new System.Drawing.Size(202, 23);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 127);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Phone number:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Mesto", true));
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(139, 152);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(202, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 156);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Email:";
            // 
            // txtAdress
            // 
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Telefon", true));
            this.txtAdress.Depth = 0;
            this.txtAdress.Hint = "";
            this.txtAdress.Location = new System.Drawing.Point(139, 181);
            this.txtAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.Size = new System.Drawing.Size(202, 23);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(25, 185);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Adress:";
            // 
            // txtSearch
            // 
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Email", true));
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(139, 210);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(202, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 214);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "Location:";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(457, 423);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(42, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "NEW";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.newButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.phoneBooksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Check ";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn1.FillWeight = 77.19498F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Full name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn2.FillWeight = 77.19498F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Phone number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mesto";
            this.dataGridViewTextBoxColumn3.FillWeight = 77.19498F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.FillWeight = 77.19498F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.FillWeight = 77.19498F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Location";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(561, 423);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(41, 36);
            this.materialFlatButton2.TabIndex = 7;
            this.materialFlatButton2.Text = "Edit";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.editButton_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(678, 423);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton3.TabIndex = 8;
            this.materialFlatButton3.Text = "CANCEL";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // phoneBooksTableAdapter
            // 
            this.phoneBooksTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearchS
            // 
            this.txtSearchS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Ime", true));
            this.txtSearchS.Depth = 0;
            this.txtSearchS.Hint = "";
            this.txtSearchS.Location = new System.Drawing.Point(457, 94);
            this.txtSearchS.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.PasswordChar = '\0';
            this.txtSearchS.SelectedText = "";
            this.txtSearchS.SelectionLength = 0;
            this.txtSearchS.SelectionStart = 0;
            this.txtSearchS.Size = new System.Drawing.Size(202, 23);
            this.txtSearchS.TabIndex = 25;
            this.txtSearchS.UseSystemPasswordChar = false;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(683, 127);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton5.TabIndex = 26;
            this.materialFlatButton5.Text = "Refresh";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(683, 90);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton6.TabIndex = 27;
            this.materialFlatButton6.Text = "Search";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click);
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Location = new System.Drawing.Point(610, 423);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(60, 36);
            this.materialFlatButton7.TabIndex = 28;
            this.materialFlatButton7.Text = "Delete";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            this.materialFlatButton7.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(507, 423);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(46, 36);
            this.materialFlatButton4.TabIndex = 29;
            this.materialFlatButton4.Text = "Save";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(683, 210);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(106, 36);
            this.materialFlatButton8.TabIndex = 30;
            this.materialFlatButton8.Text = "PRINT REPORT";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Location = new System.Drawing.Point(683, 168);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton9.TabIndex = 31;
            this.materialFlatButton9.Text = "PRINT WF";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            this.materialFlatButton9.Click += new System.EventHandler(this.materialFlatButton9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.materialFlatButton9);
            this.Controls.Add(this.materialFlatButton8);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton7);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.txtSearchS);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Diary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.BindingSource tableBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFullName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdress;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource phoneBooksBindingSource;
        private Database1DataSetTableAdapters.PhoneBooksTableAdapter phoneBooksTableAdapter;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchS;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
    }
}

