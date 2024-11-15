namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbn = new System.Windows.Forms.TextBox();
            this.tbm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.dg3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(45, 104);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(810, 447);
            this.dg.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 45);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 33);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(283, 45);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(50, 22);
            this.tbn.TabIndex = 2;
            this.tbn.Text = "3";
            // 
            // tbm
            // 
            this.tbm.Location = new System.Drawing.Point(387, 45);
            this.tbm.Name = "tbm";
            this.tbm.Size = new System.Drawing.Size(50, 22);
            this.tbm.TabIndex = 3;
            this.tbm.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "n =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "m =";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(513, 45);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(86, 33);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(624, 45);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 33);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1745, 709);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 36);
            this.listBox1.TabIndex = 8;
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(890, 104);
            this.dg2.Name = "dg2";
            this.dg2.RowHeadersWidth = 51;
            this.dg2.RowTemplate.Height = 24;
            this.dg2.Size = new System.Drawing.Size(810, 447);
            this.dg2.TabIndex = 9;
            // 
            // dg3
            // 
            this.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg3.Location = new System.Drawing.Point(890, 577);
            this.dg3.Name = "dg3";
            this.dg3.RowHeadersWidth = 51;
            this.dg3.RowTemplate.Height = 24;
            this.dg3.Size = new System.Drawing.Size(810, 447);
            this.dg3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1741, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Метод \r\nпотенціалів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1724, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Метод \r\nпн-зх кута";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1728, 219);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(136, 36);
            this.listBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg3);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbm);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.TextBox tbm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.DataGridView dg3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
    }
}

