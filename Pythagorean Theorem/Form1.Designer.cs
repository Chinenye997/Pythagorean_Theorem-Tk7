
namespace Pythagorean_Theorem
{
    partial class Pyth
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
            this.Sidescmb = new System.Windows.Forms.ComboBox();
            this.firstlb1 = new System.Windows.Forms.Label();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.sectxt = new System.Windows.Forms.TextBox();
            this.seclbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Answertxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find for :";
            // 
            // Sidescmb
            // 
            this.Sidescmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidescmb.FormattingEnabled = true;
            this.Sidescmb.Items.AddRange(new object[] {
            "Adjacent",
            "Opposite",
            "Hypotenus"});
            this.Sidescmb.Location = new System.Drawing.Point(239, 166);
            this.Sidescmb.Name = "Sidescmb";
            this.Sidescmb.Size = new System.Drawing.Size(259, 45);
            this.Sidescmb.TabIndex = 1;
            this.Sidescmb.SelectedIndexChanged += new System.EventHandler(this.Sidescmb_SelectedIndexChanged);
            // 
            // firstlb1
            // 
            this.firstlb1.AutoSize = true;
            this.firstlb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstlb1.Location = new System.Drawing.Point(43, 257);
            this.firstlb1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstlb1.Name = "firstlb1";
            this.firstlb1.Size = new System.Drawing.Size(128, 29);
            this.firstlb1.TabIndex = 2;
            this.firstlb1.Text = "First Side :";
            // 
            // firsttxt
            // 
            this.firsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firsttxt.Location = new System.Drawing.Point(239, 248);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.Size = new System.Drawing.Size(189, 44);
            this.firsttxt.TabIndex = 3;
            // 
            // sectxt
            // 
            this.sectxt.Location = new System.Drawing.Point(239, 338);
            this.sectxt.Name = "sectxt";
            this.sectxt.Size = new System.Drawing.Size(189, 35);
            this.sectxt.TabIndex = 4;
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.Location = new System.Drawing.Point(41, 341);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(177, 29);
            this.seclbl.TabIndex = 5;
            this.seclbl.Text = "Second Side :";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(54, 419);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(113, 29);
            this.answerLbl.TabIndex = 6;
            this.answerLbl.Text = "Answer :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(239, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answertxt
            // 
            this.Answertxt.AutoSize = true;
            this.Answertxt.Location = new System.Drawing.Point(246, 419);
            this.Answertxt.Name = "Answertxt";
            this.Answertxt.Size = new System.Drawing.Size(28, 29);
            this.Answertxt.TabIndex = 8;
            this.Answertxt.Text = "=";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 102);
            this.label2.TabIndex = 9;
            this.label2.Text = "MY PYTHAGORAS THEOREM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pyth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Answertxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.seclbl);
            this.Controls.Add(this.sectxt);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.firstlb1);
            this.Controls.Add(this.Sidescmb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Pyth";
            this.Text = "PYTHAGOREAN ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sidescmb;
        private System.Windows.Forms.Label firstlb1;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.TextBox sectxt;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Answertxt;
        private System.Windows.Forms.Label label2;
    }
}

