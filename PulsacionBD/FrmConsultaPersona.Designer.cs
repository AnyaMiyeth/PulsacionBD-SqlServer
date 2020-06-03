namespace PulsacionBD
{
    partial class FrmConsultaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPersona));
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalHombres = new System.Windows.Forms.TextBox();
            this.TxtTotalMujeres = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DtgPersona = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Hombres",
            "Mujeres",
            "Todos"});
            this.CmbTipo.Location = new System.Drawing.Point(400, 169);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(482, 39);
            this.CmbTipo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1030, 657);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Hombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 660);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Mujeres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 660);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Isncritos";
            // 
            // TxtTotalHombres
            // 
            this.TxtTotalHombres.Location = new System.Drawing.Point(998, 695);
            this.TxtTotalHombres.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtTotalHombres.Name = "TxtTotalHombres";
            this.TxtTotalHombres.Size = new System.Drawing.Size(260, 38);
            this.TxtTotalHombres.TabIndex = 13;
            // 
            // TxtTotalMujeres
            // 
            this.TxtTotalMujeres.Location = new System.Drawing.Point(622, 695);
            this.TxtTotalMujeres.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtTotalMujeres.Name = "TxtTotalMujeres";
            this.TxtTotalMujeres.Size = new System.Drawing.Size(260, 38);
            this.TxtTotalMujeres.TabIndex = 12;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(222, 695);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(260, 38);
            this.TxtTotal.TabIndex = 11;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.Location = new System.Drawing.Point(1587, 134);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(179, 74);
            this.BtnConsultar.TabIndex = 10;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DtgPersona
            // 
            this.DtgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPersona.Location = new System.Drawing.Point(187, 259);
            this.DtgPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgPersona.Name = "DtgPersona";
            this.DtgPersona.RowHeadersWidth = 102;
            this.DtgPersona.RowTemplate.Height = 40;
            this.DtgPersona.Size = new System.Drawing.Size(1669, 353);
            this.DtgPersona.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1378, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 74);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2043, 867);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotalHombres);
            this.Controls.Add(this.TxtTotalMujeres);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DtgPersona);
            this.Name = "FrmConsultaPersona";
            this.Text = "ConsultaPersona";
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalHombres;
        private System.Windows.Forms.TextBox TxtTotalMujeres;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView DtgPersona;
        private System.Windows.Forms.Button button1;
    }
}