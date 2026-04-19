namespace OrdenChef
{
    partial class Form2
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
            this.btnAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ordenChefDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenChefDBDataSet1 = new OrdenChef.OrdenChefDBDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRestaurantAactual = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenChefDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenChefDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAgregar});
            this.dataGridView1.DataSource = this.ordenChefDBDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.HeaderText = "Acción";
            this.btnAgregar.MinimumWidth = 6;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Width = 125;
            // 
            // ordenChefDBDataSet1BindingSource
            // 
            this.ordenChefDBDataSet1BindingSource.DataSource = this.ordenChefDBDataSet1;
            this.ordenChefDBDataSet1BindingSource.Position = 0;
            // 
            // ordenChefDBDataSet1
            // 
            this.ordenChefDBDataSet1.DataSetName = "OrdenChefDBDataSet1";
            this.ordenChefDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estas ordenando en...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRestaurantAactual
            // 
            this.txtRestaurantAactual.Location = new System.Drawing.Point(294, 28);
            this.txtRestaurantAactual.Name = "txtRestaurantAactual";
            this.txtRestaurantAactual.Size = new System.Drawing.Size(100, 22);
            this.txtRestaurantAactual.TabIndex = 2;
            this.txtRestaurantAactual.TextChanged += new System.EventHandler(this.txtRestaurantAactual_TextChanged);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(373, 303);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 16);
            this.lblContador.TabIndex = 3;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(388, 371);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(125, 23);
            this.btConfirmar.TabIndex = 4;
            this.btConfirmar.Text = "Confirmar Orden";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txtRestaurantAactual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenChefDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenChefDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnAgregar;
        private System.Windows.Forms.BindingSource ordenChefDBDataSet1BindingSource;
        private OrdenChefDBDataSet1 ordenChefDBDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRestaurantAactual;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btConfirmar;
    }
}