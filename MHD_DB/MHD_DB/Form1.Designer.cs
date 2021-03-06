namespace MHD_DB
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
            this.components = new System.ComponentModel.Container();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbSearch = new System.Windows.Forms.CheckedListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRegister.Location = new System.Drawing.Point(12, 500);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(159, 29);
            this.btnAddRegister.TabIndex = 2;
            this.btnAddRegister.Text = "Agregar Registro";
            this.btnAddRegister.UseVisualStyleBackColor = true;
            this.btnAddRegister.Click += new System.EventHandler(this.btnAddRegister_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(594, 517);
            this.dataGridView1.TabIndex = 4;
            // 
            // dbConnectionBindingSource
            // 
            this.dbConnectionBindingSource.DataSource = typeof(MHD_DB.dbConnection);
            // 
            // TBsearch
            // 
            this.TBsearch.Location = new System.Drawing.Point(12, 33);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(150, 27);
            this.TBsearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // clbSearch
            // 
            this.clbSearch.FormattingEnabled = true;
            this.clbSearch.Items.AddRange(new object[] {
            "Tipo de Objeto",
            "Codigo",
            "Cultura"});
            this.clbSearch.Location = new System.Drawing.Point(12, 66);
            this.clbSearch.Name = "clbSearch";
            this.clbSearch.Size = new System.Drawing.Size(150, 92);
            this.clbSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditRegister
            // 
            this.btnEditRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditRegister.Location = new System.Drawing.Point(12, 465);
            this.btnEditRegister.Name = "btnEditRegister";
            this.btnEditRegister.Size = new System.Drawing.Size(159, 29);
            this.btnEditRegister.TabIndex = 9;
            this.btnEditRegister.Text = "Ver / Editar Registro";
            this.btnEditRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 541);
            this.Controls.Add(this.btnEditRegister);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.clbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddRegister);
            this.MinimumSize = new System.Drawing.Size(801, 588);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddRegister;
        private DataGridView dataGridView1;
        private BindingSource dbConnectionBindingSource;
        private TextBox TBsearch;
        private Label label1;
        private CheckedListBox clbSearch;
        private Button btnSearch;
        private Button btnEditRegister;
    }
}