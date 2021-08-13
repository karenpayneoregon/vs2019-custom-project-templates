
namespace SqlServerTablesColumns
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateArrayButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatabaseNamesListBox = new System.Windows.Forms.ListBox();
            this.TableNamesListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.CreateArrayButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 129);
            this.panel1.TabIndex = 0;
            // 
            // CreateArrayButton
            // 
            this.CreateArrayButton.Location = new System.Drawing.Point(12, 12);
            this.CreateArrayButton.Name = "CreateArrayButton";
            this.CreateArrayButton.Size = new System.Drawing.Size(203, 23);
            this.CreateArrayButton.TabIndex = 0;
            this.CreateArrayButton.Text = "Create";
            this.CreateArrayButton.UseVisualStyleBackColor = true;
            this.CreateArrayButton.Click += new System.EventHandler(this.CreateArrayButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatabaseNamesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TableNamesListBox);
            this.splitContainer1.Size = new System.Drawing.Size(523, 322);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 1;
            // 
            // DatabaseNamesListBox
            // 
            this.DatabaseNamesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseNamesListBox.FormattingEnabled = true;
            this.DatabaseNamesListBox.ItemHeight = 15;
            this.DatabaseNamesListBox.Location = new System.Drawing.Point(0, 0);
            this.DatabaseNamesListBox.Name = "DatabaseNamesListBox";
            this.DatabaseNamesListBox.Size = new System.Drawing.Size(215, 322);
            this.DatabaseNamesListBox.TabIndex = 0;
            // 
            // TableNamesListBox
            // 
            this.TableNamesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableNamesListBox.FormattingEnabled = true;
            this.TableNamesListBox.ItemHeight = 15;
            this.TableNamesListBox.Location = new System.Drawing.Point(0, 0);
            this.TableNamesListBox.Name = "TableNamesListBox";
            this.TableNamesListBox.Size = new System.Drawing.Size(304, 322);
            this.TableNamesListBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 78);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate arrays";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox DatabaseNamesListBox;
        private System.Windows.Forms.Button CreateArrayButton;
        private System.Windows.Forms.ListBox TableNamesListBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

