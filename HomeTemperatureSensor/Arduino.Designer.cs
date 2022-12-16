
namespace HomeTemperatureSensor
{
    partial class Arduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arduino));
            this.arduinoText = new System.Windows.Forms.TextBox();
            this.buzzerEmiter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arduinoText
            // 
            this.arduinoText.BackColor = System.Drawing.Color.Navy;
            this.arduinoText.Enabled = false;
            this.arduinoText.Font = new System.Drawing.Font("OCR A Extended", 20F);
            this.arduinoText.ForeColor = System.Drawing.Color.Transparent;
            this.arduinoText.Location = new System.Drawing.Point(544, 316);
            this.arduinoText.Name = "arduinoText";
            this.arduinoText.Size = new System.Drawing.Size(248, 35);
            this.arduinoText.TabIndex = 0;
            this.arduinoText.TextChanged += new System.EventHandler(this.arduinoText_TextChanged);
            // 
            // buzzerEmiter
            // 
            this.buzzerEmiter.AutoSize = true;
            this.buzzerEmiter.BackColor = System.Drawing.Color.Transparent;
            this.buzzerEmiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.buzzerEmiter.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buzzerEmiter.Location = new System.Drawing.Point(702, 240);
            this.buzzerEmiter.Name = "buzzerEmiter";
            this.buzzerEmiter.Size = new System.Drawing.Size(80, 46);
            this.buzzerEmiter.TabIndex = 1;
            this.buzzerEmiter.Text = "< >";
            this.buzzerEmiter.Click += new System.EventHandler(this.buzzerEmiter_Click);
            // 
            // Arduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 409);
            this.Controls.Add(this.buzzerEmiter);
            this.Controls.Add(this.arduinoText);
            this.Name = "Arduino";
            this.Text = "Arduino";
            this.Load += new System.EventHandler(this.Arduino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arduinoText;
        private System.Windows.Forms.Label buzzerEmiter;
    }
}