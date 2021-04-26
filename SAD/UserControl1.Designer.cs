
namespace SAD
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zone4_Main1 = new SAD.Zone4_Main();
            this.zone3_Main1 = new SAD.Zone3_Main();
            this.zone2_Main1 = new SAD.Zone2_Main();
            this.zone1_Main1 = new SAD.Zone1_Main();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.zone1_Main1);
            this.panel2.Controls.Add(this.zone2_Main1);
            this.panel2.Controls.Add(this.zone3_Main1);
            this.panel2.Controls.Add(this.zone4_Main1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 534);
            this.panel2.TabIndex = 2;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(31, 269);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(204, 58);
            this.button17.TabIndex = 2;
            this.button17.Text = "ห่อกลับ";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(31, 192);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(204, 58);
            this.button18.TabIndex = 3;
            this.button18.Text = "Zone VIP";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(31, 114);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(204, 58);
            this.button19.TabIndex = 4;
            this.button19.Text = "Zone อีสาน";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(31, 39);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(204, 58);
            this.button20.TabIndex = 5;
            this.button20.Text = "Zone แอร์";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกโซน";
            // 
            // zone4_Main1
            // 
            this.zone4_Main1.Location = new System.Drawing.Point(297, 55);
            this.zone4_Main1.Name = "zone4_Main1";
            this.zone4_Main1.Size = new System.Drawing.Size(682, 357);
            this.zone4_Main1.TabIndex = 7;
            // 
            // zone3_Main1
            // 
            this.zone3_Main1.Location = new System.Drawing.Point(300, 55);
            this.zone3_Main1.Name = "zone3_Main1";
            this.zone3_Main1.Size = new System.Drawing.Size(679, 351);
            this.zone3_Main1.TabIndex = 8;
            // 
            // zone2_Main1
            // 
            this.zone2_Main1.Location = new System.Drawing.Point(300, 55);
            this.zone2_Main1.Name = "zone2_Main1";
            this.zone2_Main1.Size = new System.Drawing.Size(679, 355);
            this.zone2_Main1.TabIndex = 9;
            // 
            // zone1_Main1
            // 
            this.zone1_Main1.Location = new System.Drawing.Point(300, 55);
            this.zone1_Main1.Name = "zone1_Main1";
            this.zone1_Main1.Size = new System.Drawing.Size(679, 357);
            this.zone1_Main1.TabIndex = 10;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(984, 538);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private Zone1_Main zone1_Main1;
        private Zone2_Main zone2_Main1;
        private Zone3_Main zone3_Main1;
        private Zone4_Main zone4_Main1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
