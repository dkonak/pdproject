
namespace MathProf
{
    partial class Matematik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsoru = new System.Windows.Forms.Button();
            this.topicList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearsCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.devamlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soruresim = new System.Windows.Forms.PictureBox();
            this.cözümGroup = new System.Windows.Forms.GroupBox();
            this.cözümresim = new System.Windows.Forms.PictureBox();
            this.cözümtxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soruresim)).BeginInit();
            this.cözümGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cözümresim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.btnsoru);
            this.groupBox1.Controls.Add(this.topicList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yearsCombo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yıl ve Konu Seçimi";
            // 
            // btnsoru
            // 
            this.btnsoru.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnsoru.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsoru.Location = new System.Drawing.Point(259, 338);
            this.btnsoru.Name = "btnsoru";
            this.btnsoru.Size = new System.Drawing.Size(173, 54);
            this.btnsoru.TabIndex = 5;
            this.btnsoru.Text = "? Soruyu Gör ?";
            this.btnsoru.UseVisualStyleBackColor = false;
            this.btnsoru.Click += new System.EventHandler(this.btnsoru_Click);
            // 
            // topicList
            // 
            this.topicList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topicList.ForeColor = System.Drawing.Color.DarkOrchid;
            this.topicList.FormattingEnabled = true;
            this.topicList.ItemHeight = 22;
            this.topicList.Location = new System.Drawing.Point(178, 112);
            this.topicList.Name = "topicList";
            this.topicList.Size = new System.Drawing.Size(331, 202);
            this.topicList.TabIndex = 4;
            this.topicList.SelectedIndexChanged += new System.EventHandler(this.topicList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konu Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yıl Seçiniz";
            // 
            // yearsCombo
            // 
            this.yearsCombo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.yearsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yearsCombo.ForeColor = System.Drawing.Color.DarkOrchid;
            this.yearsCombo.FormattingEnabled = true;
            this.yearsCombo.Location = new System.Drawing.Point(178, 41);
            this.yearsCombo.Name = "yearsCombo";
            this.yearsCombo.Size = new System.Drawing.Size(128, 30);
            this.yearsCombo.TabIndex = 0;
            this.yearsCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Controls.Add(this.devamlabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1261, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bileşenler";
            // 
            // devamlabel
            // 
            this.devamlabel.AutoSize = true;
            this.devamlabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devamlabel.Location = new System.Drawing.Point(473, 378);
            this.devamlabel.Name = "devamlabel";
            this.devamlabel.Size = new System.Drawing.Size(73, 27);
            this.devamlabel.TabIndex = 1;
            this.devamlabel.Text = "label4";
            this.devamlabel.Click += new System.EventHandler(this.devamlabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // soruresim
            // 
            this.soruresim.Location = new System.Drawing.Point(669, 44);
            this.soruresim.Name = "soruresim";
            this.soruresim.Size = new System.Drawing.Size(586, 409);
            this.soruresim.TabIndex = 2;
            this.soruresim.TabStop = false;
            // 
            // cözümGroup
            // 
            this.cözümGroup.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cözümGroup.Controls.Add(this.cözümresim);
            this.cözümGroup.Controls.Add(this.cözümtxt);
            this.cözümGroup.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cözümGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cözümGroup.Location = new System.Drawing.Point(641, 513);
            this.cözümGroup.Name = "cözümGroup";
            this.cözümGroup.Size = new System.Drawing.Size(744, 420);
            this.cözümGroup.TabIndex = 2;
            this.cözümGroup.TabStop = false;
            this.cözümGroup.Text = "Çözüm";
            // 
            // cözümresim
            // 
            this.cözümresim.Location = new System.Drawing.Point(154, 116);
            this.cözümresim.Name = "cözümresim";
            this.cözümresim.Size = new System.Drawing.Size(434, 276);
            this.cözümresim.TabIndex = 1;
            this.cözümresim.TabStop = false;
            // 
            // cözümtxt
            // 
            this.cözümtxt.AutoSize = true;
            this.cözümtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cözümtxt.Location = new System.Drawing.Point(17, 44);
            this.cözümtxt.Name = "cözümtxt";
            this.cözümtxt.Size = new System.Drawing.Size(85, 29);
            this.cözümtxt.TabIndex = 0;
            this.cözümtxt.Text = "label4";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1542, 876);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.MediumOrchid;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(179, 876);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Antrenman";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Matematik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1924, 945);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cözümGroup);
            this.Controls.Add(this.soruresim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Matematik";
            this.Text = "Matematik Hocam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soruresim)).EndInit();
            this.cözümGroup.ResumeLayout(false);
            this.cözümGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cözümresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearsCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox topicList;
        private System.Windows.Forms.Button btnsoru;
        private System.Windows.Forms.PictureBox soruresim;
        private System.Windows.Forms.GroupBox cözümGroup;
        private System.Windows.Forms.Label cözümtxt;
        private System.Windows.Forms.Label devamlabel;
        private System.Windows.Forms.PictureBox cözümresim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

