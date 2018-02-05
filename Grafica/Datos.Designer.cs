namespace Grafica
{
    partial class Datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPuntos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtBxX = new System.Windows.Forms.TextBox();
            this.txtBxY = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.groupBxPunto = new System.Windows.Forms.GroupBox();
            this.groupBxLinea = new System.Windows.Forms.GroupBox();
            this.comBxLinea = new System.Windows.Forms.ComboBox();
            this.btnAgregarL = new System.Windows.Forms.Button();
            this.groupBxGrafica = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comBxTipo = new System.Windows.Forms.ComboBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPuntos)).BeginInit();
            this.groupBxPunto.SuspendLayout();
            this.groupBxLinea.SuspendLayout();
            this.groupBxGrafica.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPuntos
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPuntos.ChartAreas.Add(chartArea4);
            this.chartPuntos.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.chartPuntos.Legends.Add(legend4);
            this.chartPuntos.Location = new System.Drawing.Point(0, 149);
            this.chartPuntos.Name = "chartPuntos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPuntos.Series.Add(series4);
            this.chartPuntos.Size = new System.Drawing.Size(502, 314);
            this.chartPuntos.TabIndex = 0;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 32);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(13, 66);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y:";
            // 
            // txtBxX
            // 
            this.txtBxX.Location = new System.Drawing.Point(41, 32);
            this.txtBxX.Name = "txtBxX";
            this.txtBxX.Size = new System.Drawing.Size(100, 22);
            this.txtBxX.TabIndex = 3;
            this.txtBxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxX_KeyPress);
            // 
            // txtBxY
            // 
            this.txtBxY.Location = new System.Drawing.Point(41, 66);
            this.txtBxY.Name = "txtBxY";
            this.txtBxY.Size = new System.Drawing.Size(100, 22);
            this.txtBxY.TabIndex = 4;
            this.txtBxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxY_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 18);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 128);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(44, 102);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(92, 34);
            this.btnAgregarP.TabIndex = 6;
            this.btnAgregarP.Text = "AGREGAR";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // groupBxPunto
            // 
            this.groupBxPunto.Controls.Add(this.txtBxY);
            this.groupBxPunto.Controls.Add(this.btnAgregarP);
            this.groupBxPunto.Controls.Add(this.lblX);
            this.groupBxPunto.Controls.Add(this.lblY);
            this.groupBxPunto.Controls.Add(this.txtBxX);
            this.groupBxPunto.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBxPunto.Location = new System.Drawing.Point(0, 0);
            this.groupBxPunto.Name = "groupBxPunto";
            this.groupBxPunto.Size = new System.Drawing.Size(162, 149);
            this.groupBxPunto.TabIndex = 7;
            this.groupBxPunto.TabStop = false;
            this.groupBxPunto.Text = "Puntos";
            // 
            // groupBxLinea
            // 
            this.groupBxLinea.Controls.Add(this.lblTipo);
            this.groupBxLinea.Controls.Add(this.lblNum);
            this.groupBxLinea.Controls.Add(this.comBxTipo);
            this.groupBxLinea.Controls.Add(this.btnEliminar);
            this.groupBxLinea.Controls.Add(this.btnAgregarL);
            this.groupBxLinea.Controls.Add(this.comBxLinea);
            this.groupBxLinea.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBxLinea.Location = new System.Drawing.Point(162, 0);
            this.groupBxLinea.Name = "groupBxLinea";
            this.groupBxLinea.Size = new System.Drawing.Size(229, 149);
            this.groupBxLinea.TabIndex = 8;
            this.groupBxLinea.TabStop = false;
            this.groupBxLinea.Text = "Linea";
            // 
            // comBxLinea
            // 
            this.comBxLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBxLinea.FormattingEnabled = true;
            this.comBxLinea.Location = new System.Drawing.Point(53, 29);
            this.comBxLinea.Name = "comBxLinea";
            this.comBxLinea.Size = new System.Drawing.Size(87, 24);
            this.comBxLinea.TabIndex = 0;
            // 
            // btnAgregarL
            // 
            this.btnAgregarL.Location = new System.Drawing.Point(9, 102);
            this.btnAgregarL.Name = "btnAgregarL";
            this.btnAgregarL.Size = new System.Drawing.Size(97, 34);
            this.btnAgregarL.TabIndex = 7;
            this.btnAgregarL.Text = "AGREGAR";
            this.btnAgregarL.UseVisualStyleBackColor = true;
            this.btnAgregarL.Click += new System.EventHandler(this.btnAgregarL_Click);
            // 
            // groupBxGrafica
            // 
            this.groupBxGrafica.Controls.Add(this.btnLimpiar);
            this.groupBxGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBxGrafica.Location = new System.Drawing.Point(391, 0);
            this.groupBxGrafica.Name = "groupBxGrafica";
            this.groupBxGrafica.Size = new System.Drawing.Size(111, 149);
            this.groupBxGrafica.TabIndex = 9;
            this.groupBxGrafica.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(127, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comBxTipo
            // 
            this.comBxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBxTipo.FormattingEnabled = true;
            this.comBxTipo.Items.AddRange(new object[] {
            "Spline",
            "Line",
            "StepLine",
            "Column",
            "Bar",
            "Point",
            "Area"});
            this.comBxTipo.Location = new System.Drawing.Point(53, 62);
            this.comBxTipo.Name = "comBxTipo";
            this.comBxTipo.Size = new System.Drawing.Size(116, 24);
            this.comBxTipo.TabIndex = 9;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(9, 29);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 17);
            this.lblNum.TabIndex = 10;
            this.lblNum.Text = "N:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 65);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo:";
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 463);
            this.Controls.Add(this.groupBxGrafica);
            this.Controls.Add(this.groupBxLinea);
            this.Controls.Add(this.groupBxPunto);
            this.Controls.Add(this.chartPuntos);
            this.MaximumSize = new System.Drawing.Size(540, 540);
            this.MinimumSize = new System.Drawing.Size(520, 510);
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPuntos)).EndInit();
            this.groupBxPunto.ResumeLayout(false);
            this.groupBxPunto.PerformLayout();
            this.groupBxLinea.ResumeLayout(false);
            this.groupBxLinea.PerformLayout();
            this.groupBxGrafica.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPuntos;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtBxX;
        private System.Windows.Forms.TextBox txtBxY;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.GroupBox groupBxPunto;
        private System.Windows.Forms.GroupBox groupBxLinea;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarL;
        private System.Windows.Forms.ComboBox comBxLinea;
        private System.Windows.Forms.GroupBox groupBxGrafica;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ComboBox comBxTipo;
    }
}

