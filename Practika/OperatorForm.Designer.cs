namespace Practika
{
    partial class OperatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CRMButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AbonentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbonentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 118);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(639, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 103);
            this.label2.TabIndex = 2;
            this.label2.Text = "События";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Абоненты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CRMButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 332);
            this.panel3.TabIndex = 2;
            // 
            // CRMButton
            // 
            this.CRMButton.BackColor = System.Drawing.SystemColors.Control;
            this.CRMButton.Location = new System.Drawing.Point(11, 5);
            this.CRMButton.Name = "CRMButton";
            this.CRMButton.Size = new System.Drawing.Size(98, 43);
            this.CRMButton.TabIndex = 0;
            this.CRMButton.Text = "CRM";
            this.CRMButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(638, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 332);
            this.panel4.TabIndex = 3;
            // 
            // AbonentDataGridView
            // 
            this.AbonentDataGridView.AllowUserToAddRows = false;
            this.AbonentDataGridView.AllowUserToDeleteRows = false;
            this.AbonentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbonentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbonentDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.AbonentDataGridView.Location = new System.Drawing.Point(129, 124);
            this.AbonentDataGridView.Name = "AbonentDataGridView";
            this.AbonentDataGridView.ReadOnly = true;
            this.AbonentDataGridView.RowHeadersWidth = 51;
            this.AbonentDataGridView.RowTemplate.Height = 24;
            this.AbonentDataGridView.Size = new System.Drawing.Size(503, 326);
            this.AbonentDataGridView.TabIndex = 4;
            this.AbonentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AbonentDataGridView_CellClick);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AbonentDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AbonentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AbonentDataGridView;
        private System.Windows.Forms.Button CRMButton;
    }
}