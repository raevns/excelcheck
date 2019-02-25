namespace excelcheck
{
    partial class unit5
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.column_select1 = new System.Windows.Forms.ComboBox();
            this.column_select2 = new System.Windows.Forms.ComboBox();
            this.column_select3 = new System.Windows.Forms.ComboBox();
            this.column_select4 = new System.Windows.Forms.ComboBox();
            this.unit1 = new System.Windows.Forms.TextBox();
            this.파일경로 = new System.Windows.Forms.Label();
            this.column_select1_label = new System.Windows.Forms.Label();
            this.column_select2_label = new System.Windows.Forms.Label();
            this.column_select3_label = new System.Windows.Forms.Label();
            this.column_select4_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unit2 = new System.Windows.Forms.TextBox();
            this.unit3 = new System.Windows.Forms.TextBox();
            this.unit4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unit4_label = new System.Windows.Forms.Label();
            this.file_open_button = new System.Windows.Forms.Button();
            this.save_setting_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.time_set_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.multi_data_check = new System.Windows.Forms.ComboBox();
            this.file_remove_button = new System.Windows.Forms.Button();
            this.export_excel_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.select5 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.file_list_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.file_list_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 46);
            this.textBox1.TabIndex = 0;
            // 
            // column_select1
            // 
            this.column_select1.FormattingEnabled = true;
            this.column_select1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.column_select1.Location = new System.Drawing.Point(84, 78);
            this.column_select1.Name = "column_select1";
            this.column_select1.Size = new System.Drawing.Size(121, 20);
            this.column_select1.TabIndex = 1;
            // 
            // column_select2
            // 
            this.column_select2.FormattingEnabled = true;
            this.column_select2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.column_select2.Location = new System.Drawing.Point(84, 119);
            this.column_select2.Name = "column_select2";
            this.column_select2.Size = new System.Drawing.Size(121, 20);
            this.column_select2.TabIndex = 2;
            // 
            // column_select3
            // 
            this.column_select3.FormattingEnabled = true;
            this.column_select3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.column_select3.Location = new System.Drawing.Point(84, 160);
            this.column_select3.Name = "column_select3";
            this.column_select3.Size = new System.Drawing.Size(121, 20);
            this.column_select3.TabIndex = 3;
            // 
            // column_select4
            // 
            this.column_select4.FormattingEnabled = true;
            this.column_select4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.column_select4.Location = new System.Drawing.Point(84, 201);
            this.column_select4.Name = "column_select4";
            this.column_select4.Size = new System.Drawing.Size(121, 20);
            this.column_select4.TabIndex = 4;
            // 
            // unit1
            // 
            this.unit1.Location = new System.Drawing.Point(271, 78);
            this.unit1.Name = "unit1";
            this.unit1.Size = new System.Drawing.Size(63, 21);
            this.unit1.TabIndex = 5;
            // 
            // 파일경로
            // 
            this.파일경로.AutoSize = true;
            this.파일경로.Location = new System.Drawing.Point(25, 21);
            this.파일경로.Name = "파일경로";
            this.파일경로.Size = new System.Drawing.Size(53, 12);
            this.파일경로.TabIndex = 9;
            this.파일경로.Text = "파일경로";
            // 
            // column_select1_label
            // 
            this.column_select1_label.AutoSize = true;
            this.column_select1_label.Location = new System.Drawing.Point(31, 81);
            this.column_select1_label.Name = "column_select1_label";
            this.column_select1_label.Size = new System.Drawing.Size(47, 12);
            this.column_select1_label.TabIndex = 10;
            this.column_select1_label.Text = "행선택1";
            // 
            // column_select2_label
            // 
            this.column_select2_label.AutoSize = true;
            this.column_select2_label.Location = new System.Drawing.Point(31, 122);
            this.column_select2_label.Name = "column_select2_label";
            this.column_select2_label.Size = new System.Drawing.Size(47, 12);
            this.column_select2_label.TabIndex = 11;
            this.column_select2_label.Text = "행선택2";
            // 
            // column_select3_label
            // 
            this.column_select3_label.AutoSize = true;
            this.column_select3_label.Location = new System.Drawing.Point(31, 163);
            this.column_select3_label.Name = "column_select3_label";
            this.column_select3_label.Size = new System.Drawing.Size(47, 12);
            this.column_select3_label.TabIndex = 12;
            this.column_select3_label.Text = "행선택3";
            // 
            // column_select4_label
            // 
            this.column_select4_label.AutoSize = true;
            this.column_select4_label.Location = new System.Drawing.Point(31, 204);
            this.column_select4_label.Name = "column_select4_label";
            this.column_select4_label.Size = new System.Drawing.Size(47, 12);
            this.column_select4_label.TabIndex = 13;
            this.column_select4_label.Text = "행선택4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "단위1";
            // 
            // unit2
            // 
            this.unit2.Location = new System.Drawing.Point(271, 119);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(63, 21);
            this.unit2.TabIndex = 15;
            // 
            // unit3
            // 
            this.unit3.Location = new System.Drawing.Point(271, 160);
            this.unit3.Name = "unit3";
            this.unit3.Size = new System.Drawing.Size(63, 21);
            this.unit3.TabIndex = 16;
            // 
            // unit4
            // 
            this.unit4.Location = new System.Drawing.Point(271, 200);
            this.unit4.Name = "unit4";
            this.unit4.Size = new System.Drawing.Size(63, 21);
            this.unit4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "단위2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "단위3";
            // 
            // unit4_label
            // 
            this.unit4_label.AutoSize = true;
            this.unit4_label.Location = new System.Drawing.Point(230, 204);
            this.unit4_label.Name = "unit4_label";
            this.unit4_label.Size = new System.Drawing.Size(35, 12);
            this.unit4_label.TabIndex = 20;
            this.unit4_label.Text = "단위4";
            // 
            // file_open_button
            // 
            this.file_open_button.Location = new System.Drawing.Point(364, 76);
            this.file_open_button.Name = "file_open_button";
            this.file_open_button.Size = new System.Drawing.Size(75, 23);
            this.file_open_button.TabIndex = 21;
            this.file_open_button.Text = "파일열기";
            this.file_open_button.UseVisualStyleBackColor = true;
            this.file_open_button.Click += new System.EventHandler(this.file_open_button_Click);
            // 
            // save_setting_button
            // 
            this.save_setting_button.Location = new System.Drawing.Point(364, 117);
            this.save_setting_button.Name = "save_setting_button";
            this.save_setting_button.Size = new System.Drawing.Size(75, 23);
            this.save_setting_button.TabIndex = 22;
            this.save_setting_button.Text = "설정저장";
            this.save_setting_button.UseVisualStyleBackColor = true;
            this.save_setting_button.Click += new System.EventHandler(this.save_setting_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "데이터 처리 시간";
            // 
            // time_set_box
            // 
            this.time_set_box.Location = new System.Drawing.Point(573, 23);
            this.time_set_box.Name = "time_set_box";
            this.time_set_box.Size = new System.Drawing.Size(63, 21);
            this.time_set_box.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "복수 데이터 처리";
            // 
            // multi_data_check
            // 
            this.multi_data_check.FormattingEnabled = true;
            this.multi_data_check.Items.AddRange(new object[] {
            "단일값",
            "평균"});
            this.multi_data_check.Location = new System.Drawing.Point(573, 50);
            this.multi_data_check.Name = "multi_data_check";
            this.multi_data_check.Size = new System.Drawing.Size(121, 20);
            this.multi_data_check.TabIndex = 25;
            // 
            // file_remove_button
            // 
            this.file_remove_button.Location = new System.Drawing.Point(364, 159);
            this.file_remove_button.Name = "file_remove_button";
            this.file_remove_button.Size = new System.Drawing.Size(75, 23);
            this.file_remove_button.TabIndex = 28;
            this.file_remove_button.Text = "파일삭제";
            this.file_remove_button.UseVisualStyleBackColor = true;
            // 
            // export_excel_button
            // 
            this.export_excel_button.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.export_excel_button.Location = new System.Drawing.Point(302, 289);
            this.export_excel_button.Name = "export_excel_button";
            this.export_excel_button.Size = new System.Drawing.Size(201, 74);
            this.export_excel_button.TabIndex = 29;
            this.export_excel_button.Text = "결과엑셀출력";
            this.export_excel_button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "단위4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 21);
            this.textBox2.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "행선택5";
            // 
            // select5
            // 
            this.select5.FormattingEnabled = true;
            this.select5.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.select5.Location = new System.Drawing.Point(84, 246);
            this.select5.Name = "select5";
            this.select5.Size = new System.Drawing.Size(121, 20);
            this.select5.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // file_list_grid
            // 
            this.file_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.file_list_grid.Location = new System.Drawing.Point(469, 76);
            this.file_list_grid.Name = "file_list_grid";
            this.file_list_grid.RowTemplate.Height = 23;
            this.file_list_grid.Size = new System.Drawing.Size(325, 190);
            this.file_list_grid.TabIndex = 34;
            // 
            // unit5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 375);
            this.Controls.Add(this.file_list_grid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.select5);
            this.Controls.Add(this.export_excel_button);
            this.Controls.Add(this.file_remove_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.multi_data_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time_set_box);
            this.Controls.Add(this.save_setting_button);
            this.Controls.Add(this.file_open_button);
            this.Controls.Add(this.unit4_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unit4);
            this.Controls.Add(this.unit3);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.column_select4_label);
            this.Controls.Add(this.column_select3_label);
            this.Controls.Add(this.column_select2_label);
            this.Controls.Add(this.column_select1_label);
            this.Controls.Add(this.파일경로);
            this.Controls.Add(this.unit1);
            this.Controls.Add(this.column_select4);
            this.Controls.Add(this.column_select3);
            this.Controls.Add(this.column_select2);
            this.Controls.Add(this.column_select1);
            this.Controls.Add(this.textBox1);
            this.Name = "unit5";
            this.Text = "시계열계측자료";
            ((System.ComponentModel.ISupportInitialize)(this.file_list_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox column_select1;
        private System.Windows.Forms.ComboBox column_select2;
        private System.Windows.Forms.ComboBox column_select3;
        private System.Windows.Forms.ComboBox column_select4;
        private System.Windows.Forms.TextBox unit1;
        private System.Windows.Forms.Label 파일경로;
        private System.Windows.Forms.Label column_select1_label;
        private System.Windows.Forms.Label column_select2_label;
        private System.Windows.Forms.Label column_select3_label;
        private System.Windows.Forms.Label column_select4_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unit2;
        private System.Windows.Forms.TextBox unit3;
        private System.Windows.Forms.TextBox unit4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label unit4_label;
        private System.Windows.Forms.Button file_open_button;
        private System.Windows.Forms.Button save_setting_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox time_set_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox multi_data_check;
        private System.Windows.Forms.Button file_remove_button;
        private System.Windows.Forms.Button export_excel_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox select5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView file_list_grid;
    }
}

