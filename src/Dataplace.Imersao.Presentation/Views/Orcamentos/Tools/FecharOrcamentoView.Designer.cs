
namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    partial class FecharOrcamentoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.range = new System.Windows.Forms.DataGridView();
            this.c1DateEdit1 = new C1.Win.Calendar.C1DateEdit();
            this.c1DateEdit2 = new C1.Win.C1Input.C1DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1ContextMenu1 = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            this.SuspendLayout();
            // 
            // range
            // 
            this.range.BackgroundColor = System.Drawing.SystemColors.Control;
            this.range.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.range.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.range.Location = new System.Drawing.Point(3, 78);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(954, 252);
            this.range.TabIndex = 501;
            this.range.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.AllowSpinLoop = false;
            this.c1DateEdit1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1DateEdit1.ImageTransparentColor = System.Drawing.Color.Empty;
            this.c1DateEdit1.Location = new System.Drawing.Point(217, 16);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(156, 18);
            this.c1DateEdit1.TabIndex = 502;
            this.c1DateEdit1.Tag = null;
            this.c1DateEdit1.ValueChanged += new System.EventHandler(this.c1DateEdit1_ValueChanged);
            // 
            // c1DateEdit2
            // 
            this.c1DateEdit2.AllowSpinLoop = false;
            // 
            // 
            // 
            this.c1DateEdit2.Calendar.DayNameLength = 1;
            this.c1DateEdit2.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1DateEdit2.ImageTransparentColor = System.Drawing.Color.Empty;
            this.c1DateEdit2.Location = new System.Drawing.Point(450, 16);
            this.c1DateEdit2.Name = "c1DateEdit2";
            this.c1DateEdit2.Size = new System.Drawing.Size(147, 18);
            this.c1DateEdit2.TabIndex = 503;
            this.c1DateEdit2.Tag = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 504;
            this.label1.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 505;
            this.label2.Text = "Data Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 506;
            this.label3.Text = "Nª Orçamento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Location = new System.Drawing.Point(15, 32);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(116, 18);
            this.c1TextBox1.TabIndex = 507;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.TextChanged += new System.EventHandler(this.c1TextBox1_TextChanged);
            // 
            // c1ContextMenu1
            // 
            this.c1ContextMenu1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1});
            this.c1ContextMenu1.Name = "c1ContextMenu1";
            this.c1ContextMenu1.ShortcutText = "";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1ContextMenu1);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Text = "New Command";
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(879, 49);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(75, 23);
            this.c1Button1.TabIndex = 508;
            this.c1Button1.Text = "Carregar\r\n";
            this.c1Button1.UseVisualStyleBackColor = true;
            // 
            // FecharOrcamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1DateEdit2);
            this.Controls.Add(this.c1DateEdit1);
            this.Controls.Add(this.range);
            this.Name = "FecharOrcamentoView";
            this.Size = new System.Drawing.Size(957, 393);
            this.Controls.SetChildIndex(this.range, 0);
            this.Controls.SetChildIndex(this.c1DateEdit1, 0);
            this.Controls.SetChildIndex(this.c1DateEdit2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.c1TextBox1, 0);
            this.Controls.SetChildIndex(this.c1Button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridOrcamento;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiMarcar;
        private System.Windows.Forms.ToolStripMenuItem tsiDesmarca;
        private System.Windows.Forms.GroupBox groupBox1;
        internal dpLibrary05.ucSymGen_ReferenceDtp rangeDate;
        private System.Windows.Forms.DataGridView range;
        private C1.Win.Calendar.C1DateEdit c1DateEdit1;
        private C1DateEdit c1DateEdit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private C1TextBox c1TextBox1;
        private C1ContextMenu c1ContextMenu1;
        private C1CommandLink c1CommandLink1;
        private C1CommandHolder c1CommandHolder1;
        private C1Button c1Button1;
    }
}
