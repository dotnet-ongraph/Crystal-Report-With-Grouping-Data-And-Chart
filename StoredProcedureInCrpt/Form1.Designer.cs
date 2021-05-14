namespace StoredProcedureInCrpt
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
            this.crvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CountryRegionRptbutton = new System.Windows.Forms.Button();
            this.MonthlySalesRptbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvReport
            // 
            this.crvReport.ActiveViewIndex = -1;
            this.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport.Location = new System.Drawing.Point(0, 0);
            this.crvReport.Name = "crvReport";
            this.crvReport.Size = new System.Drawing.Size(1042, 430);
            this.crvReport.TabIndex = 0;
            this.crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CountryRegionRptbutton
            // 
            this.CountryRegionRptbutton.Location = new System.Drawing.Point(686, 0);
            this.CountryRegionRptbutton.Name = "CountryRegionRptbutton";
            this.CountryRegionRptbutton.Size = new System.Drawing.Size(170, 23);
            this.CountryRegionRptbutton.TabIndex = 2;
            this.CountryRegionRptbutton.Text = "Country Region Report";
            this.CountryRegionRptbutton.UseVisualStyleBackColor = true;
            this.CountryRegionRptbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonthlySalesRptbutton
            // 
            this.MonthlySalesRptbutton.Location = new System.Drawing.Point(490, 0);
            this.MonthlySalesRptbutton.Name = "MonthlySalesRptbutton";
            this.MonthlySalesRptbutton.Size = new System.Drawing.Size(163, 23);
            this.MonthlySalesRptbutton.TabIndex = 3;
            this.MonthlySalesRptbutton.Text = "Monthly Sales Order Report";
            this.MonthlySalesRptbutton.UseVisualStyleBackColor = true;
            this.MonthlySalesRptbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 430);
            this.Controls.Add(this.MonthlySalesRptbutton);
            this.Controls.Add(this.CountryRegionRptbutton);
            this.Controls.Add(this.crvReport);
            this.Name = "Form1";
            this.Text = "Crystal Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport;
        private System.Windows.Forms.Button CountryRegionRptbutton;
        private System.Windows.Forms.Button MonthlySalesRptbutton;
    }
}

