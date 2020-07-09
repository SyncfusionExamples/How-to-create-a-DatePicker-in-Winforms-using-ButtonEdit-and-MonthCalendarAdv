namespace ChildButtonClick_ButtonEdit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.120522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.87948F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 307);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BeforeTouchSize = new System.Drawing.Size(285, 23);
            this.buttonEdit1.Controls.Add(this.textBoxExt1);
            this.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit1.Location = new System.Drawing.Point(3, 3);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(285, 23);
            this.buttonEdit1.TabIndex = 0;
            this.buttonEdit1.TextBox = this.textBoxExt1;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(100, 22);
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Location = new System.Drawing.Point(3, 4);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(279, 15);
            this.textBoxExt1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
    }
}

