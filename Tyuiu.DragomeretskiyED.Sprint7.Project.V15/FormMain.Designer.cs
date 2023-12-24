
namespace Tyuiu.DragomeretskiyED.Sprint7.Project.V15
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelp_DED = new System.Windows.Forms.Button();
            this.buttonSaveFile_DED = new System.Windows.Forms.Button();
            this.buttonOpenFile_DED = new System.Windows.Forms.Button();
            this.dataGridViewOut_DED = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Srok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonSort_DED = new System.Windows.Forms.Button();
            this.textBoxSort_DED = new System.Windows.Forms.TextBox();
            this.buttonDelete_DED = new System.Windows.Forms.Button();
            this.buttonChange_DED = new System.Windows.Forms.Button();
            this.buttonAdd_DED = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxAddSrok_DED = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxAddOklad_DED = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxAddStatus_DED = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxAddPhone_DED = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxAddAddress_DED = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAddNamee_DED = new System.Windows.Forms.TextBox();
            this.openFileDialog_DED = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExcel_DED = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_DED)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHelp_DED);
            this.groupBox1.Controls.Add(this.buttonSaveFile_DED);
            this.groupBox1.Controls.Add(this.buttonOpenFile_DED);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кнопки навигации";
            // 
            // buttonHelp_DED
            // 
            this.buttonHelp_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_DED.Image")));
            this.buttonHelp_DED.Location = new System.Drawing.Point(991, 19);
            this.buttonHelp_DED.Name = "buttonHelp_DED";
            this.buttonHelp_DED.Size = new System.Drawing.Size(75, 48);
            this.buttonHelp_DED.TabIndex = 2;
            this.buttonHelp_DED.UseVisualStyleBackColor = true;
            this.buttonHelp_DED.Click += new System.EventHandler(this.buttonHelp_DED_Click);
            // 
            // buttonSaveFile_DED
            // 
            this.buttonSaveFile_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_DED.Image")));
            this.buttonSaveFile_DED.Location = new System.Drawing.Point(88, 19);
            this.buttonSaveFile_DED.Name = "buttonSaveFile_DED";
            this.buttonSaveFile_DED.Size = new System.Drawing.Size(75, 48);
            this.buttonSaveFile_DED.TabIndex = 1;
            this.buttonSaveFile_DED.UseVisualStyleBackColor = true;
            this.buttonSaveFile_DED.Click += new System.EventHandler(this.buttonSaveFile_DED_Click);
            // 
            // buttonOpenFile_DED
            // 
            this.buttonOpenFile_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_DED.Image")));
            this.buttonOpenFile_DED.Location = new System.Drawing.Point(6, 19);
            this.buttonOpenFile_DED.Name = "buttonOpenFile_DED";
            this.buttonOpenFile_DED.Size = new System.Drawing.Size(76, 48);
            this.buttonOpenFile_DED.TabIndex = 0;
            this.buttonOpenFile_DED.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DED.Click += new System.EventHandler(this.buttonOpenFile_DED_Click);
            // 
            // dataGridViewOut_DED
            // 
            this.dataGridViewOut_DED.AllowUserToAddRows = false;
            this.dataGridViewOut_DED.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOut_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_DED.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Address,
            this.Phone,
            this.Status,
            this.Oklad,
            this.Srok});
            this.dataGridViewOut_DED.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOut_DED.Name = "dataGridViewOut_DED";
            this.dataGridViewOut_DED.Size = new System.Drawing.Size(648, 469);
            this.dataGridViewOut_DED.TabIndex = 1;
            this.dataGridViewOut_DED.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOut_DED_CellClick);
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Name";
            this.Namee.Name = "Namee";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Oklad
            // 
            this.Oklad.HeaderText = "Oklad";
            this.Oklad.Name = "Oklad";
            // 
            // Srok
            // 
            this.Srok.HeaderText = "Srok";
            this.Srok.Name = "Srok";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOut_DED);
            this.groupBox2.Location = new System.Drawing.Point(424, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 494);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.buttonDelete_DED);
            this.groupBox3.Controls.Add(this.buttonChange_DED);
            this.groupBox3.Controls.Add(this.buttonAdd_DED);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 494);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.buttonSort_DED);
            this.groupBox10.Controls.Add(this.textBoxSort_DED);
            this.groupBox10.Location = new System.Drawing.Point(6, 355);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(394, 62);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Сортировка";
            // 
            // buttonSort_DED
            // 
            this.buttonSort_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonSort_DED.Image")));
            this.buttonSort_DED.Location = new System.Drawing.Point(313, 10);
            this.buttonSort_DED.Name = "buttonSort_DED";
            this.buttonSort_DED.Size = new System.Drawing.Size(75, 46);
            this.buttonSort_DED.TabIndex = 1;
            this.buttonSort_DED.UseVisualStyleBackColor = true;
            this.buttonSort_DED.Click += new System.EventHandler(this.buttonSort_DED_Click);
            // 
            // textBoxSort_DED
            // 
            this.textBoxSort_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSort_DED.Location = new System.Drawing.Point(6, 25);
            this.textBoxSort_DED.Name = "textBoxSort_DED";
            this.textBoxSort_DED.Size = new System.Drawing.Size(301, 20);
            this.textBoxSort_DED.TabIndex = 0;
            // 
            // buttonDelete_DED
            // 
            this.buttonDelete_DED.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete_DED.Location = new System.Drawing.Point(309, 423);
            this.buttonDelete_DED.Name = "buttonDelete_DED";
            this.buttonDelete_DED.Size = new System.Drawing.Size(91, 65);
            this.buttonDelete_DED.TabIndex = 12;
            this.buttonDelete_DED.Text = "Удалить";
            this.buttonDelete_DED.UseVisualStyleBackColor = false;
            this.buttonDelete_DED.Click += new System.EventHandler(this.buttonDelete_DED_Click);
            // 
            // buttonChange_DED
            // 
            this.buttonChange_DED.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonChange_DED.Location = new System.Drawing.Point(161, 423);
            this.buttonChange_DED.Name = "buttonChange_DED";
            this.buttonChange_DED.Size = new System.Drawing.Size(91, 65);
            this.buttonChange_DED.TabIndex = 11;
            this.buttonChange_DED.Text = "Изменить";
            this.buttonChange_DED.UseVisualStyleBackColor = false;
            this.buttonChange_DED.Click += new System.EventHandler(this.buttonChange_DED_Click);
            // 
            // buttonAdd_DED
            // 
            this.buttonAdd_DED.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd_DED.Location = new System.Drawing.Point(6, 423);
            this.buttonAdd_DED.Name = "buttonAdd_DED";
            this.buttonAdd_DED.Size = new System.Drawing.Size(92, 65);
            this.buttonAdd_DED.TabIndex = 10;
            this.buttonAdd_DED.Text = "Добавить";
            this.buttonAdd_DED.UseVisualStyleBackColor = false;
            this.buttonAdd_DED.Click += new System.EventHandler(this.buttonAdd_DED_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxAddSrok_DED);
            this.groupBox9.Location = new System.Drawing.Point(6, 299);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(394, 50);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Srok";
            // 
            // textBoxAddSrok_DED
            // 
            this.textBoxAddSrok_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddSrok_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddSrok_DED.Name = "textBoxAddSrok_DED";
            this.textBoxAddSrok_DED.Size = new System.Drawing.Size(382, 20);
            this.textBoxAddSrok_DED.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxAddOklad_DED);
            this.groupBox8.Location = new System.Drawing.Point(6, 243);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(394, 50);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Oklad";
            // 
            // textBoxAddOklad_DED
            // 
            this.textBoxAddOklad_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddOklad_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddOklad_DED.Name = "textBoxAddOklad_DED";
            this.textBoxAddOklad_DED.Size = new System.Drawing.Size(382, 20);
            this.textBoxAddOklad_DED.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxAddStatus_DED);
            this.groupBox7.Location = new System.Drawing.Point(6, 187);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(394, 50);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // textBoxAddStatus_DED
            // 
            this.textBoxAddStatus_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddStatus_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddStatus_DED.Name = "textBoxAddStatus_DED";
            this.textBoxAddStatus_DED.Size = new System.Drawing.Size(382, 20);
            this.textBoxAddStatus_DED.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxAddPhone_DED);
            this.groupBox6.Location = new System.Drawing.Point(6, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(394, 50);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Phone";
            // 
            // textBoxAddPhone_DED
            // 
            this.textBoxAddPhone_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddPhone_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddPhone_DED.Name = "textBoxAddPhone_DED";
            this.textBoxAddPhone_DED.Size = new System.Drawing.Size(382, 20);
            this.textBoxAddPhone_DED.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxAddAddress_DED);
            this.groupBox5.Location = new System.Drawing.Point(6, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 50);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Address";
            // 
            // textBoxAddAddress_DED
            // 
            this.textBoxAddAddress_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddAddress_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddAddress_DED.Name = "textBoxAddAddress_DED";
            this.textBoxAddAddress_DED.Size = new System.Drawing.Size(382, 20);
            this.textBoxAddAddress_DED.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAddNamee_DED);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 50);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Name";
            // 
            // textBoxAddNamee_DED
            // 
            this.textBoxAddNamee_DED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddNamee_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddNamee_DED.Name = "textBoxAddNamee_DED";
            this.textBoxAddNamee_DED.Size = new System.Drawing.Size(382, 20);
            this.textBoxAddNamee_DED.TabIndex = 0;
            // 
            // openFileDialog_DED
            // 
            this.openFileDialog_DED.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Спринт 7 | Проект | Драгомерцкий Е. Д,";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_DED)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveFile_DED;
        private System.Windows.Forms.Button buttonOpenFile_DED;
        private System.Windows.Forms.DataGridView dataGridViewOut_DED;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog_DED;
        private System.Windows.Forms.Button buttonHelp_DED;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel_DED;
        private System.Windows.Forms.Button buttonChange_DED;
        private System.Windows.Forms.Button buttonAdd_DED;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxAddSrok_DED;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxAddOklad_DED;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxAddStatus_DED;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxAddPhone_DED;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxAddAddress_DED;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxAddNamee_DED;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srok;
        private System.Windows.Forms.Button buttonDelete_DED;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button buttonSort_DED;
        private System.Windows.Forms.TextBox textBoxSort_DED;
    }
}

