using EcoWise.DAL;
using System.Linq;

namespace EcoWise
{
    partial class WorkForm
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
            this.CrewCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CrewCombo
            // 
            this.CrewCombo.FormattingEnabled = true;
            this.CrewCombo.Location = new System.Drawing.Point(282, 39);
            this.CrewCombo.Name = "CrewCombo";
            this.CrewCombo.Size = new System.Drawing.Size(334, 24);
            this.CrewCombo.TabIndex = 0;
            EcoWiseEntities entities = new EcoWiseEntities();
            this.CrewCombo.DataSource = entities.EmployeeCrews.Where(c => c.Active == true).Select(c => new {Value=c.Id, Display=c.CrewName }).ToList();
            this.CrewCombo.DisplayMember = "Display";
            this.CrewCombo.ValueMember = "Value";
            this.CrewCombo.SelectedIndexChanged += new System.EventHandler(this.CrewCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 639);
            this.Controls.Add(this.CrewCombo);
            this.Name = "Form1";
            this.Text = "Worksheet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CrewCombo;
    }
}

