
namespace HomeTemperatureSensor
{
    partial class PodaciOTemperaturama
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeTemperatureSensorDataSet = new HomeTemperatureSensor.homeTemperatureSensorDataSet();
            this.homeTemperatureSensorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeTemperatureSensorDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RedniBrojID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperaturaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperaturaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAlarma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTemperatureSensorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTemperatureSensorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTemperatureSensorDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RedniBrojID,
            this.Soba,
            this.TemperaturaC,
            this.TemperaturaF,
            this.StatusAlarma,
            this.Vrijeme});
            this.dataGridView1.DataSource = this.homeTemperatureSensorDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // homeTemperatureSensorDataSet
            // 
            this.homeTemperatureSensorDataSet.DataSetName = "homeTemperatureSensorDataSet";
            this.homeTemperatureSensorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeTemperatureSensorDataSetBindingSource
            // 
            this.homeTemperatureSensorDataSetBindingSource.DataSource = this.homeTemperatureSensorDataSet;
            this.homeTemperatureSensorDataSetBindingSource.Position = 0;
            // 
            // homeTemperatureSensorDataSetBindingSource1
            // 
            this.homeTemperatureSensorDataSetBindingSource1.DataSource = this.homeTemperatureSensorDataSet;
            this.homeTemperatureSensorDataSetBindingSource1.Position = 0;
            // 
            // RedniBrojID
            // 
            this.RedniBrojID.DataPropertyName = "RedniBrojID";
            this.RedniBrojID.HeaderText = "RedniBroj";
            this.RedniBrojID.MinimumWidth = 6;
            this.RedniBrojID.Name = "RedniBrojID";
            this.RedniBrojID.Width = 125;
            // 
            // Soba
            // 
            this.Soba.DataPropertyName = "SobaID";
            this.Soba.HeaderText = "Soba";
            this.Soba.MinimumWidth = 6;
            this.Soba.Name = "Soba";
            this.Soba.Width = 125;
            // 
            // TemperaturaC
            // 
            this.TemperaturaC.DataPropertyName = "TemperaturaCelzijusa";
            this.TemperaturaC.HeaderText = "TemperaturaC";
            this.TemperaturaC.MinimumWidth = 6;
            this.TemperaturaC.Name = "TemperaturaC";
            this.TemperaturaC.Width = 125;
            // 
            // TemperaturaF
            // 
            this.TemperaturaF.DataPropertyName = "TemperaturaFarenhajta";
            this.TemperaturaF.HeaderText = "TemperaturaF";
            this.TemperaturaF.MinimumWidth = 6;
            this.TemperaturaF.Name = "TemperaturaF";
            this.TemperaturaF.Width = 125;
            // 
            // StatusAlarma
            // 
            this.StatusAlarma.DataPropertyName = "StatusAlarma";
            this.StatusAlarma.HeaderText = "StatusAlarma";
            this.StatusAlarma.MinimumWidth = 6;
            this.StatusAlarma.Name = "StatusAlarma";
            this.StatusAlarma.Width = 125;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.MinimumWidth = 6;
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Width = 125;
            // 
            // PodaciOTemperaturama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PodaciOTemperaturama";
            this.Text = "PodaciOTemperaturama";
            this.Load += new System.EventHandler(this.PodaciOTemperaturama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTemperatureSensorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTemperatureSensorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTemperatureSensorDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource homeTemperatureSensorDataSetBindingSource;
        private homeTemperatureSensorDataSet homeTemperatureSensorDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBrojID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soba;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperaturaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperaturaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAlarma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.BindingSource homeTemperatureSensorDataSetBindingSource1;
    }
}