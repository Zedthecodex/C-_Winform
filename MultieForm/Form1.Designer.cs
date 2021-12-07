
namespace MultieForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddGood = new System.Windows.Forms.Button();
            this.EditGood = new System.Windows.Forms.Button();
            this.DeleteGood = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(116, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 303);
            this.listBox1.TabIndex = 0;
            // 
            // AddGood
            // 
            this.AddGood.Location = new System.Drawing.Point(116, 342);
            this.AddGood.Name = "AddGood";
            this.AddGood.Size = new System.Drawing.Size(398, 23);
            this.AddGood.TabIndex = 1;
            this.AddGood.Text = "Add Product";
            this.AddGood.UseVisualStyleBackColor = true;
            this.AddGood.Click += new System.EventHandler(this.AddGood_Click);
            // 
            // EditGood
            // 
            this.EditGood.Location = new System.Drawing.Point(116, 389);
            this.EditGood.Name = "EditGood";
            this.EditGood.Size = new System.Drawing.Size(398, 23);
            this.EditGood.TabIndex = 2;
            this.EditGood.Text = "Edit Product";
            this.EditGood.UseVisualStyleBackColor = true;
            this.EditGood.Click += new System.EventHandler(this.EditGood_Click);
            // 
            // DeleteGood
            // 
            this.DeleteGood.Location = new System.Drawing.Point(116, 436);
            this.DeleteGood.Name = "DeleteGood";
            this.DeleteGood.Size = new System.Drawing.Size(398, 23);
            this.DeleteGood.TabIndex = 3;
            this.DeleteGood.Text = "Remove Product";
            this.DeleteGood.UseVisualStyleBackColor = true;
            this.DeleteGood.Click += new System.EventHandler(this.DeleteGood_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(116, 483);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(398, 23);
            this.ClearAll.TabIndex = 3;
            this.ClearAll.Text = "Clear list";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 643);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.DeleteGood);
            this.Controls.Add(this.EditGood);
            this.Controls.Add(this.AddGood);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddGood;
        private System.Windows.Forms.Button EditGood;
        private System.Windows.Forms.Button DeleteGood;
        private System.Windows.Forms.Button ClearAll;
    }
}

