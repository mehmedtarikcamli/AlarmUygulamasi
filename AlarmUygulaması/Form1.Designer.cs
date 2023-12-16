namespace AlarmUygulaması
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
            components = new System.ComponentModel.Container();
            dtpZaman = new DateTimePicker();
            statusStrip1 = new StatusStrip();
            lblDurum = new ToolStripStatusLabel();
            btnKur = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpZaman
            // 
            dtpZaman.Format = DateTimePickerFormat.Time;
            dtpZaman.Location = new Point(42, 12);
            dtpZaman.Name = "dtpZaman";
            dtpZaman.Size = new Size(148, 23);
            dtpZaman.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDurum });
            statusStrip1.Location = new Point(0, 98);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(232, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDurum
            // 
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(107, 17);
            lblDurum.Text = "Alarm Kurulu Değil";
            // 
            // btnKur
            // 
            btnKur.Location = new Point(72, 51);
            btnKur.Name = "btnKur";
            btnKur.Size = new Size(88, 32);
            btnKur.TabIndex = 2;
            btnKur.Text = "Alarm Kur";
            btnKur.UseVisualStyleBackColor = true;
            btnKur.Click += btnKur_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 120);
            Controls.Add(btnKur);
            Controls.Add(statusStrip1);
            Controls.Add(dtpZaman);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarm Uygulaması";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpZaman;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDurum;
        private Button btnKur;
        private System.Windows.Forms.Timer timer1;
    }
}