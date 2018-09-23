namespace GrafosDirigidos
{
    partial class FormGrafos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchPath = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tableCamino = new System.Windows.Forms.TableLayoutPanel();
            this.groupDestino = new System.Windows.Forms.GroupBox();
            this.listDestino = new System.Windows.Forms.ListBox();
            this.groupOrigen = new System.Windows.Forms.GroupBox();
            this.listOrigen = new System.Windows.Forms.ListBox();
            this.tabConnect = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listCNodos = new System.Windows.Forms.ListBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.listConectados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tableAgregar = new System.Windows.Forms.TableLayoutPanel();
            this.groupListaNodos = new System.Windows.Forms.GroupBox();
            this.listNodos = new System.Windows.Forms.ListBox();
            this.groupNew = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnNewNodo = new System.Windows.Forms.Button();
            this.txtNewNodo = new System.Windows.Forms.TextBox();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.tabElementos = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.tableConectar = new System.Windows.Forms.TableLayoutPanel();
            this.listVConectados = new System.Windows.Forms.ListBox();
            this.listVNodos = new System.Windows.Forms.ListBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.tabSearch.SuspendLayout();
            this.tableCamino.SuspendLayout();
            this.groupDestino.SuspendLayout();
            this.groupOrigen.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tableAgregar.SuspendLayout();
            this.groupListaNodos.SuspendLayout();
            this.groupNew.SuspendLayout();
            this.tabElementos.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tableConectar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchPath
            // 
            this.tableCamino.SetColumnSpan(this.btnSearchPath, 2);
            this.btnSearchPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchPath.Location = new System.Drawing.Point(3, 194);
            this.btnSearchPath.Name = "btnSearchPath";
            this.btnSearchPath.Size = new System.Drawing.Size(425, 24);
            this.btnSearchPath.TabIndex = 6;
            this.btnSearchPath.Text = "Buscar camino";
            this.btnSearchPath.UseVisualStyleBackColor = true;
            this.btnSearchPath.Click += new System.EventHandler(this.btnSearchPath_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.tableCamino);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(431, 221);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Buscar camino";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // tableCamino
            // 
            this.tableCamino.ColumnCount = 2;
            this.tableCamino.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCamino.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCamino.Controls.Add(this.btnSearchPath, 0, 1);
            this.tableCamino.Controls.Add(this.groupDestino, 1, 0);
            this.tableCamino.Controls.Add(this.groupOrigen, 0, 0);
            this.tableCamino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCamino.Location = new System.Drawing.Point(0, 0);
            this.tableCamino.Name = "tableCamino";
            this.tableCamino.RowCount = 2;
            this.tableCamino.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCamino.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableCamino.Size = new System.Drawing.Size(431, 221);
            this.tableCamino.TabIndex = 9;
            // 
            // groupDestino
            // 
            this.groupDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupDestino.Controls.Add(this.listDestino);
            this.groupDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDestino.Location = new System.Drawing.Point(218, 3);
            this.groupDestino.Name = "groupDestino";
            this.groupDestino.Size = new System.Drawing.Size(210, 185);
            this.groupDestino.TabIndex = 8;
            this.groupDestino.TabStop = false;
            this.groupDestino.Text = "Destino";
            // 
            // listDestino
            // 
            this.listDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDestino.FormattingEnabled = true;
            this.listDestino.Location = new System.Drawing.Point(3, 16);
            this.listDestino.Name = "listDestino";
            this.listDestino.Size = new System.Drawing.Size(204, 166);
            this.listDestino.TabIndex = 9;
            // 
            // groupOrigen
            // 
            this.groupOrigen.Controls.Add(this.listOrigen);
            this.groupOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOrigen.Location = new System.Drawing.Point(3, 3);
            this.groupOrigen.Name = "groupOrigen";
            this.groupOrigen.Size = new System.Drawing.Size(209, 185);
            this.groupOrigen.TabIndex = 5;
            this.groupOrigen.TabStop = false;
            this.groupOrigen.Text = "Origen";
            // 
            // listOrigen
            // 
            this.listOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOrigen.FormattingEnabled = true;
            this.listOrigen.Location = new System.Drawing.Point(3, 16);
            this.listOrigen.Name = "listOrigen";
            this.listOrigen.Size = new System.Drawing.Size(203, 166);
            this.listOrigen.TabIndex = 4;
            // 
            // tabConnect
            // 
            this.tabConnect.Controls.Add(this.tableLayoutPanel1);
            this.tabConnect.Location = new System.Drawing.Point(4, 22);
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnect.Size = new System.Drawing.Size(431, 221);
            this.tabConnect.TabIndex = 1;
            this.tabConnect.Text = "Conectar Nodos";
            this.tabConnect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listCNodos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConectar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listConectados, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 215);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // listCNodos
            // 
            this.listCNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCNodos.FormattingEnabled = true;
            this.listCNodos.Location = new System.Drawing.Point(3, 3);
            this.listCNodos.Name = "listCNodos";
            this.listCNodos.Size = new System.Drawing.Size(181, 179);
            this.listCNodos.TabIndex = 10;
            this.listCNodos.SelectedIndexChanged += new System.EventHandler(this.listCNodos_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnConectar, 3);
            this.btnConectar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConectar.Location = new System.Drawing.Point(3, 188);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(419, 24);
            this.btnConectar.TabIndex = 9;
            this.btnConectar.Text = "Conectar Nodos";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // listConectados
            // 
            this.listConectados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConectados.FormattingEnabled = true;
            this.listConectados.Location = new System.Drawing.Point(240, 3);
            this.listConectados.Name = "listConectados";
            this.listConectados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listConectados.Size = new System.Drawing.Size(182, 179);
            this.listConectados.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-->";
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.tableAgregar);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(431, 221);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Agregar Nodos";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // tableAgregar
            // 
            this.tableAgregar.ColumnCount = 2;
            this.tableAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAgregar.Controls.Add(this.groupListaNodos, 1, 0);
            this.tableAgregar.Controls.Add(this.groupNew, 0, 0);
            this.tableAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAgregar.Location = new System.Drawing.Point(3, 3);
            this.tableAgregar.Name = "tableAgregar";
            this.tableAgregar.RowCount = 2;
            this.tableAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAgregar.Size = new System.Drawing.Size(425, 215);
            this.tableAgregar.TabIndex = 12;
            // 
            // groupListaNodos
            // 
            this.groupListaNodos.Controls.Add(this.listNodos);
            this.groupListaNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupListaNodos.Location = new System.Drawing.Point(215, 3);
            this.groupListaNodos.Name = "groupListaNodos";
            this.tableAgregar.SetRowSpan(this.groupListaNodos, 2);
            this.groupListaNodos.Size = new System.Drawing.Size(207, 209);
            this.groupListaNodos.TabIndex = 11;
            this.groupListaNodos.TabStop = false;
            this.groupListaNodos.Text = "Lista de Nodos existentes";
            // 
            // listNodos
            // 
            this.listNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNodos.FormattingEnabled = true;
            this.listNodos.Location = new System.Drawing.Point(3, 16);
            this.listNodos.Name = "listNodos";
            this.listNodos.Size = new System.Drawing.Size(201, 190);
            this.listNodos.TabIndex = 9;
            // 
            // groupNew
            // 
            this.groupNew.Controls.Add(this.lblNombre);
            this.groupNew.Controls.Add(this.btnNewNodo);
            this.groupNew.Controls.Add(this.txtNewNodo);
            this.groupNew.Controls.Add(this.btnAddAuto);
            this.groupNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupNew.Location = new System.Drawing.Point(3, 3);
            this.groupNew.Name = "groupNew";
            this.groupNew.Size = new System.Drawing.Size(206, 101);
            this.groupNew.TabIndex = 12;
            this.groupNew.TabStop = false;
            this.groupNew.Text = "Nuevo Nodo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Etiqueta del Nodo:";
            // 
            // btnNewNodo
            // 
            this.btnNewNodo.Location = new System.Drawing.Point(117, 30);
            this.btnNewNodo.Name = "btnNewNodo";
            this.btnNewNodo.Size = new System.Drawing.Size(75, 23);
            this.btnNewNodo.TabIndex = 1;
            this.btnNewNodo.Text = "Agregar";
            this.btnNewNodo.UseVisualStyleBackColor = true;
            this.btnNewNodo.Click += new System.EventHandler(this.btnNewNodo_Click);
            // 
            // txtNewNodo
            // 
            this.txtNewNodo.Location = new System.Drawing.Point(9, 32);
            this.txtNewNodo.Name = "txtNewNodo";
            this.txtNewNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNewNodo.TabIndex = 0;
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Location = new System.Drawing.Point(9, 59);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(183, 23);
            this.btnAddAuto.TabIndex = 9;
            this.btnAddAuto.Text = "Agregar con etiqueta automática";
            this.btnAddAuto.UseVisualStyleBackColor = true;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // tabElementos
            // 
            this.tabElementos.Controls.Add(this.tabAdd);
            this.tabElementos.Controls.Add(this.tabConnect);
            this.tabElementos.Controls.Add(this.tabView);
            this.tabElementos.Controls.Add(this.tabSearch);
            this.tabElementos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabElementos.Location = new System.Drawing.Point(0, 0);
            this.tabElementos.Name = "tabElementos";
            this.tabElementos.SelectedIndex = 0;
            this.tabElementos.Size = new System.Drawing.Size(439, 247);
            this.tabElementos.TabIndex = 10;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tableConectar);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Size = new System.Drawing.Size(431, 221);
            this.tabView.TabIndex = 4;
            this.tabView.Text = "Ver conexiones";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // tableConectar
            // 
            this.tableConectar.ColumnCount = 3;
            this.tableConectar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableConectar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableConectar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableConectar.Controls.Add(this.listVConectados, 2, 0);
            this.tableConectar.Controls.Add(this.listVNodos, 0, 0);
            this.tableConectar.Controls.Add(this.lblCon, 1, 0);
            this.tableConectar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableConectar.Location = new System.Drawing.Point(0, 0);
            this.tableConectar.Name = "tableConectar";
            this.tableConectar.RowCount = 1;
            this.tableConectar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableConectar.Size = new System.Drawing.Size(431, 221);
            this.tableConectar.TabIndex = 9;
            // 
            // listVConectados
            // 
            this.listVConectados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVConectados.FormattingEnabled = true;
            this.listVConectados.Location = new System.Drawing.Point(243, 3);
            this.listVConectados.Name = "listVConectados";
            this.listVConectados.Size = new System.Drawing.Size(185, 215);
            this.listVConectados.TabIndex = 9;
            // 
            // listVNodos
            // 
            this.listVNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVNodos.FormattingEnabled = true;
            this.listVNodos.Location = new System.Drawing.Point(3, 3);
            this.listVNodos.Name = "listVNodos";
            this.listVNodos.Size = new System.Drawing.Size(184, 215);
            this.listVNodos.TabIndex = 8;
            this.listVNodos.SelectedIndexChanged += new System.EventHandler(this.listVNodos_SelectedIndexChanged);
            // 
            // lblCon
            // 
            this.lblCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(205, 104);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(19, 13);
            this.lblCon.TabIndex = 6;
            this.lblCon.Text = "-->";
            // 
            // FormGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 247);
            this.Controls.Add(this.tabElementos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGrafos";
            this.Text = "Grafos Dirigidos";
            this.tabSearch.ResumeLayout(false);
            this.tableCamino.ResumeLayout(false);
            this.groupDestino.ResumeLayout(false);
            this.groupOrigen.ResumeLayout(false);
            this.tabConnect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tableAgregar.ResumeLayout(false);
            this.groupListaNodos.ResumeLayout(false);
            this.groupNew.ResumeLayout(false);
            this.groupNew.PerformLayout();
            this.tabElementos.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tableConectar.ResumeLayout(false);
            this.tableConectar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchPath;
        private System.Windows.Forms.TableLayoutPanel tableCamino;
        private System.Windows.Forms.GroupBox groupDestino;
        private System.Windows.Forms.GroupBox groupOrigen;
        private System.Windows.Forms.ListBox listOrigen;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabConnect;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TableLayoutPanel tableAgregar;
        private System.Windows.Forms.GroupBox groupListaNodos;
        private System.Windows.Forms.GroupBox groupNew;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnNewNodo;
        private System.Windows.Forms.TextBox txtNewNodo;
        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.TabControl tabElementos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listCNodos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox listConectados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listNodos;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TableLayoutPanel tableConectar;
        private System.Windows.Forms.ListBox listVConectados;
        private System.Windows.Forms.ListBox listVNodos;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.ListBox listDestino;
    }
}

