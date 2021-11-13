
namespace _8_Ball_League
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
            this.playerlist = new System.Windows.Forms.CheckedListBox();
            this.Addplayerbutton = new System.Windows.Forms.Button();
            this.Removeplayerbutton = new System.Windows.Forms.Button();
            this.Newplayername = new System.Windows.Forms.TextBox();
            this.newplayerranking = new System.Windows.Forms.TextBox();
            this.Beginbutton = new System.Windows.Forms.Button();
            this.filepathbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.updateplstbutton = new System.Windows.Forms.Button();
            this.Selectallbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerlist
            // 
            this.playerlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.playerlist.FormattingEnabled = true;
            this.playerlist.Items.AddRange(new object[] {
            "Empty"});
            this.playerlist.Location = new System.Drawing.Point(289, 34);
            this.playerlist.Name = "playerlist";
            this.playerlist.Size = new System.Drawing.Size(166, 292);
            this.playerlist.TabIndex = 0;
            this.playerlist.SelectedIndexChanged += new System.EventHandler(this.playerlist_SelectedIndexChanged);
            // 
            // Addplayerbutton
            // 
            this.Addplayerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Addplayerbutton.Location = new System.Drawing.Point(20, 269);
            this.Addplayerbutton.Name = "Addplayerbutton";
            this.Addplayerbutton.Size = new System.Drawing.Size(126, 42);
            this.Addplayerbutton.TabIndex = 1;
            this.Addplayerbutton.Text = "Add Player";
            this.Addplayerbutton.UseVisualStyleBackColor = true;
            this.Addplayerbutton.Click += new System.EventHandler(this.Addplayerbutton_Click);
            // 
            // Removeplayerbutton
            // 
            this.Removeplayerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Removeplayerbutton.Location = new System.Drawing.Point(151, 269);
            this.Removeplayerbutton.Name = "Removeplayerbutton";
            this.Removeplayerbutton.Size = new System.Drawing.Size(126, 42);
            this.Removeplayerbutton.TabIndex = 2;
            this.Removeplayerbutton.Text = "Remove Selected Player";
            this.Removeplayerbutton.UseVisualStyleBackColor = true;
            this.Removeplayerbutton.Click += new System.EventHandler(this.Removeplayerbutton_Click);
            // 
            // Newplayername
            // 
            this.Newplayername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Newplayername.Location = new System.Drawing.Point(20, 176);
            this.Newplayername.Name = "Newplayername";
            this.Newplayername.Size = new System.Drawing.Size(257, 26);
            this.Newplayername.TabIndex = 3;
            // 
            // newplayerranking
            // 
            this.newplayerranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newplayerranking.Location = new System.Drawing.Point(20, 234);
            this.newplayerranking.Name = "newplayerranking";
            this.newplayerranking.Size = new System.Drawing.Size(95, 26);
            this.newplayerranking.TabIndex = 4;
            this.newplayerranking.Text = "0";
            // 
            // Beginbutton
            // 
            this.Beginbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Beginbutton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.Beginbutton.FlatAppearance.BorderSize = 6;
            this.Beginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beginbutton.Location = new System.Drawing.Point(62, 335);
            this.Beginbutton.Name = "Beginbutton";
            this.Beginbutton.Size = new System.Drawing.Size(180, 59);
            this.Beginbutton.TabIndex = 5;
            this.Beginbutton.Text = "Begin Week";
            this.Beginbutton.UseVisualStyleBackColor = false;
            this.Beginbutton.Click += new System.EventHandler(this.Beginbutton_Click);
            // 
            // filepathbox
            // 
            this.filepathbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filepathbox.Location = new System.Drawing.Point(20, 34);
            this.filepathbox.Name = "filepathbox";
            this.filepathbox.Size = new System.Drawing.Size(257, 26);
            this.filepathbox.TabIndex = 6;
            this.filepathbox.TextChanged += new System.EventHandler(this.filepathbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(20, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateplstbutton
            // 
            this.updateplstbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateplstbutton.Location = new System.Drawing.Point(179, 62);
            this.updateplstbutton.Name = "updateplstbutton";
            this.updateplstbutton.Size = new System.Drawing.Size(98, 31);
            this.updateplstbutton.TabIndex = 8;
            this.updateplstbutton.Text = "Update List";
            this.updateplstbutton.UseVisualStyleBackColor = true;
            this.updateplstbutton.Click += new System.EventHandler(this.updateplstbutton_Click);
            // 
            // Selectallbutton
            // 
            this.Selectallbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Selectallbutton.Location = new System.Drawing.Point(289, 363);
            this.Selectallbutton.Name = "Selectallbutton";
            this.Selectallbutton.Size = new System.Drawing.Size(164, 31);
            this.Selectallbutton.TabIndex = 9;
            this.Selectallbutton.Text = "Check All";
            this.Selectallbutton.UseVisualStyleBackColor = true;
            this.Selectallbutton.Click += new System.EventHandler(this.Selectallbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(286, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ranking File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Player Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "New Player Ranking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selectallbutton);
            this.Controls.Add(this.updateplstbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filepathbox);
            this.Controls.Add(this.Beginbutton);
            this.Controls.Add(this.newplayerranking);
            this.Controls.Add(this.Newplayername);
            this.Controls.Add(this.Removeplayerbutton);
            this.Controls.Add(this.Addplayerbutton);
            this.Controls.Add(this.playerlist);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "8-Ball Swiss League";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox playerlist;
        private System.Windows.Forms.Button Addplayerbutton;
        private System.Windows.Forms.Button Removeplayerbutton;
        private System.Windows.Forms.TextBox Newplayername;
        private System.Windows.Forms.TextBox newplayerranking;
        private System.Windows.Forms.Button Beginbutton;
        private System.Windows.Forms.TextBox filepathbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateplstbutton;
        private System.Windows.Forms.Button Selectallbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

