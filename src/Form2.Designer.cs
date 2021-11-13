
namespace _8_Ball_League
{
    partial class Form2
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
            this.masterpanel = new System.Windows.Forms.Panel();
            this.endround = new System.Windows.Forms.Button();
            this.endweek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masterpanel
            // 
            this.masterpanel.AutoScroll = true;
            this.masterpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.masterpanel.Location = new System.Drawing.Point(29, 188);
            this.masterpanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.masterpanel.Name = "masterpanel";
            this.masterpanel.Size = new System.Drawing.Size(2841, 1201);
            this.masterpanel.TabIndex = 0;
            this.masterpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.masterpanel_Paint);
            // 
            // endround
            // 
            this.endround.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.endround.FlatAppearance.BorderSize = 6;
            this.endround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.endround.Location = new System.Drawing.Point(29, 24);
            this.endround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endround.Name = "endround";
            this.endround.Size = new System.Drawing.Size(480, 141);
            this.endround.TabIndex = 0;
            this.endround.Text = "End Round";
            this.endround.UseVisualStyleBackColor = true;
            this.endround.Click += new System.EventHandler(this.button1_Click);
            // 
            // endweek
            // 
            this.endweek.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.endweek.FlatAppearance.BorderSize = 6;
            this.endweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.endweek.Location = new System.Drawing.Point(637, 24);
            this.endweek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endweek.Name = "endweek";
            this.endweek.Size = new System.Drawing.Size(480, 141);
            this.endweek.TabIndex = 1;
            this.endweek.Text = "End Week";
            this.endweek.UseVisualStyleBackColor = true;
            this.endweek.Click += new System.EventHandler(this.endweek_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2936, 1426);
            this.Controls.Add(this.endweek);
            this.Controls.Add(this.endround);
            this.Controls.Add(this.masterpanel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form2";
            this.Text = "Current Week";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResizeEnd += new System.EventHandler(this.Form2_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel masterpanel;
        private System.Windows.Forms.Button endround;
        private System.Windows.Forms.Button endweek;
    }
}