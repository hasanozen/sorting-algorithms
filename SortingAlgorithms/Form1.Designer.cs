namespace SortingAlgorithms
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
            this.visualArea = new System.Windows.Forms.PictureBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.tb_Size = new System.Windows.Forms.TextBox();
            this.cb_Algorithm = new System.Windows.Forms.ComboBox();
            this.lbl_Algorithm = new System.Windows.Forms.Label();
            this.lbl_Delay = new System.Windows.Forms.Label();
            this.nud_Delay = new System.Windows.Forms.NumericUpDown();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.lbl_History = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_Color = new System.Windows.Forms.CheckBox();
            this.cb_Style = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.list_History = new System.Windows.Forms.ListBox();
            this.lbl_Infos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // visualArea
            // 
            this.visualArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visualArea.Location = new System.Drawing.Point(213, 12);
            this.visualArea.Name = "visualArea";
            this.visualArea.Size = new System.Drawing.Size(1032, 625);
            this.visualArea.TabIndex = 0;
            this.visualArea.TabStop = false;
            this.visualArea.SizeChanged += new System.EventHandler(this.visualArea_SizeChanged);
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Location = new System.Drawing.Point(12, 12);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(27, 13);
            this.lbl_Size.TabIndex = 1;
            this.lbl_Size.Text = "Size";
            // 
            // tb_Size
            // 
            this.tb_Size.Location = new System.Drawing.Point(12, 28);
            this.tb_Size.Name = "tb_Size";
            this.tb_Size.Size = new System.Drawing.Size(178, 20);
            this.tb_Size.TabIndex = 2;
            this.tb_Size.TextChanged += new System.EventHandler(this.tb_Size_TextChanged);
            // 
            // cb_Algorithm
            // 
            this.cb_Algorithm.FormattingEnabled = true;
            this.cb_Algorithm.Location = new System.Drawing.Point(12, 180);
            this.cb_Algorithm.Name = "cb_Algorithm";
            this.cb_Algorithm.Size = new System.Drawing.Size(178, 21);
            this.cb_Algorithm.TabIndex = 3;
            // 
            // lbl_Algorithm
            // 
            this.lbl_Algorithm.AutoSize = true;
            this.lbl_Algorithm.Location = new System.Drawing.Point(12, 164);
            this.lbl_Algorithm.Name = "lbl_Algorithm";
            this.lbl_Algorithm.Size = new System.Drawing.Size(50, 13);
            this.lbl_Algorithm.TabIndex = 4;
            this.lbl_Algorithm.Text = "Algorithm";
            // 
            // lbl_Delay
            // 
            this.lbl_Delay.AutoSize = true;
            this.lbl_Delay.Location = new System.Drawing.Point(12, 86);
            this.lbl_Delay.Name = "lbl_Delay";
            this.lbl_Delay.Size = new System.Drawing.Size(56, 13);
            this.lbl_Delay.TabIndex = 5;
            this.lbl_Delay.Text = "Delay (ms)";
            // 
            // nud_Delay
            // 
            this.nud_Delay.Location = new System.Drawing.Point(78, 84);
            this.nud_Delay.Name = "nud_Delay";
            this.nud_Delay.Size = new System.Drawing.Size(54, 20);
            this.nud_Delay.TabIndex = 6;
            this.nud_Delay.ValueChanged += new System.EventHandler(this.nud_Delay_ValueChanged);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Generate.Location = new System.Drawing.Point(12, 110);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(178, 39);
            this.btn_Generate.TabIndex = 7;
            this.btn_Generate.Text = "GENERATE";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sort.Location = new System.Drawing.Point(12, 207);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(178, 39);
            this.btn_Sort.TabIndex = 8;
            this.btn_Sort.Text = "SORT";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // lbl_History
            // 
            this.lbl_History.AutoSize = true;
            this.lbl_History.Location = new System.Drawing.Point(12, 315);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(42, 13);
            this.lbl_History.TabIndex = 10;
            this.lbl_History.Text = "Recent";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(222, 21);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color";
            // 
            // chb_Color
            // 
            this.chb_Color.AutoSize = true;
            this.chb_Color.Location = new System.Drawing.Point(175, 87);
            this.chb_Color.Name = "chb_Color";
            this.chb_Color.Size = new System.Drawing.Size(15, 14);
            this.chb_Color.TabIndex = 13;
            this.chb_Color.UseVisualStyleBackColor = true;
            this.chb_Color.CheckedChanged += new System.EventHandler(this.chb_Color_CheckedChanged);
            // 
            // cb_Style
            // 
            this.cb_Style.FormattingEnabled = true;
            this.cb_Style.Location = new System.Drawing.Point(78, 56);
            this.cb_Style.Name = "cb_Style";
            this.cb_Style.Size = new System.Drawing.Size(112, 21);
            this.cb_Style.TabIndex = 14;
            this.cb_Style.SelectedIndexChanged += new System.EventHandler(this.cb_Style_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Style";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cancel.Location = new System.Drawing.Point(12, 252);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(178, 39);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // list_History
            // 
            this.list_History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_History.FormattingEnabled = true;
            this.list_History.Location = new System.Drawing.Point(12, 331);
            this.list_History.Name = "list_History";
            this.list_History.Size = new System.Drawing.Size(195, 303);
            this.list_History.TabIndex = 9;
            // 
            // lbl_Infos
            // 
            this.lbl_Infos.AutoSize = true;
            this.lbl_Infos.Location = new System.Drawing.Point(306, 21);
            this.lbl_Infos.Name = "lbl_Infos";
            this.lbl_Infos.Size = new System.Drawing.Size(35, 13);
            this.lbl_Infos.TabIndex = 17;
            this.lbl_Infos.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 649);
            this.Controls.Add(this.lbl_Infos);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Style);
            this.Controls.Add(this.chb_Color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_History);
            this.Controls.Add(this.list_History);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.nud_Delay);
            this.Controls.Add(this.lbl_Delay);
            this.Controls.Add(this.lbl_Algorithm);
            this.Controls.Add(this.cb_Algorithm);
            this.Controls.Add(this.tb_Size);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.visualArea);
            this.Name = "Form1";
            this.Text = "Sorting Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox visualArea;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.TextBox tb_Size;
        private System.Windows.Forms.ComboBox cb_Algorithm;
        private System.Windows.Forms.Label lbl_Algorithm;
        private System.Windows.Forms.Label lbl_Delay;
        private System.Windows.Forms.NumericUpDown nud_Delay;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Label lbl_History;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_Color;
        private System.Windows.Forms.ComboBox cb_Style;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListBox list_History;
        private System.Windows.Forms.Label lbl_Infos;
    }
}

