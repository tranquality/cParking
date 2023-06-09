﻿namespace GloryH
{
    partial class SearchParking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parking_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begin_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.carnum = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(581, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "车位信息检索";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(325, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "按";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "车位编号"});
            this.comboBox1.Location = new System.Drawing.Point(372, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 32);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(541, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "检索";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton1.Location = new System.Drawing.Point(17, 41);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 29);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "使用中";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton2.Location = new System.Drawing.Point(17, 91);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 29);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "空闲中";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.parking_id,
            this.card_value,
            this.car_number,
            this.car_user,
            this.state,
            this.begin_time});
            this.dataGridView1.Location = new System.Drawing.Point(270, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 320);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "编号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // parking_id
            // 
            this.parking_id.DataPropertyName = "parking_id";
            this.parking_id.HeaderText = "车位编号";
            this.parking_id.MinimumWidth = 6;
            this.parking_id.Name = "parking_id";
            this.parking_id.Width = 125;
            // 
            // card_value
            // 
            this.card_value.DataPropertyName = "card_value";
            this.card_value.HeaderText = "停车证号";
            this.card_value.MinimumWidth = 6;
            this.card_value.Name = "card_value";
            this.card_value.Width = 125;
            // 
            // car_number
            // 
            this.car_number.DataPropertyName = "car_number";
            this.car_number.HeaderText = "车牌号";
            this.car_number.MinimumWidth = 6;
            this.car_number.Name = "car_number";
            this.car_number.Width = 125;
            // 
            // car_user
            // 
            this.car_user.DataPropertyName = "car_user";
            this.car_user.HeaderText = "车主姓名";
            this.car_user.MinimumWidth = 6;
            this.car_user.Name = "car_user";
            this.car_user.Width = 125;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "车位状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.Width = 125;
            // 
            // begin_time
            // 
            this.begin_time.DataPropertyName = "begin_time";
            this.begin_time.HeaderText = "停入时间";
            this.begin_time.MinimumWidth = 6;
            this.begin_time.Name = "begin_time";
            this.begin_time.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.button1.Location = new System.Drawing.Point(900, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("宋体", 12F);
            this.edit.Location = new System.Drawing.Point(372, 610);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(113, 34);
            this.edit.TabIndex = 20;
            this.edit.Text = "编辑";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // carnum
            // 
            this.carnum.Font = new System.Drawing.Font("宋体", 14.5F);
            this.carnum.Location = new System.Drawing.Point(628, 189);
            this.carnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carnum.Name = "carnum";
            this.carnum.Size = new System.Drawing.Size(188, 35);
            this.carnum.TabIndex = 21;
            this.carnum.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton3.Location = new System.Drawing.Point(17, 4);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 29);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "全部";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("宋体", 12F);
            this.add.Location = new System.Drawing.Point(628, 610);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 34);
            this.add.TabIndex = 23;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Button2_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("宋体", 12F);
            this.del.Location = new System.Drawing.Point(912, 610);
            this.del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(113, 34);
            this.del.TabIndex = 24;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(1061, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 125);
            this.panel1.TabIndex = 25;
            // 
            // SearchParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 795);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.carnum);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchParking";
            this.Text = "车位信息检索";
            this.Load += new System.EventHandler(this.SearchParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parking_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin_time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox carnum;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Panel panel1;
    }
}