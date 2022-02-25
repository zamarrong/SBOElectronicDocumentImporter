namespace SBOElectronicDocumentImporter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbServerTypes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSBOPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSBOUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtLicenseServer = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImportarXML = new System.Windows.Forms.Button();
            this.btnCancelarDocmentos = new System.Windows.Forms.Button();
            this.btnImportFromExcel = new System.Windows.Forms.Button();
            this.txtSignDigest = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSignMsg = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocEntry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.rbDocument = new System.Windows.Forms.RadioButton();
            this.rbPayment = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbServerTypes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSBOPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSBOUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDBPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDBUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtLicenseServer);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión SBO";
            // 
            // cbServerTypes
            // 
            this.cbServerTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerTypes.FormattingEnabled = true;
            this.cbServerTypes.Items.AddRange(new object[] {
            "MSSQL 2008",
            "MSSQL 2012",
            "MSSQL 2014",
            "MSSQL 2016",
            "HANA"});
            this.cbServerTypes.Location = new System.Drawing.Point(423, 127);
            this.cbServerTypes.Name = "cbServerTypes";
            this.cbServerTypes.Size = new System.Drawing.Size(209, 36);
            this.cbServerTypes.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contraseña SBO";
            // 
            // txtSBOPassword
            // 
            this.txtSBOPassword.Location = new System.Drawing.Point(140, 122);
            this.txtSBOPassword.Name = "txtSBOPassword";
            this.txtSBOPassword.Size = new System.Drawing.Size(207, 33);
            this.txtSBOPassword.TabIndex = 4;
            this.txtSBOPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario SBO";
            // 
            // txtSBOUserName
            // 
            this.txtSBOUserName.Location = new System.Drawing.Point(140, 91);
            this.txtSBOUserName.Name = "txtSBOUserName";
            this.txtSBOUserName.Size = new System.Drawing.Size(207, 33);
            this.txtSBOUserName.TabIndex = 3;
            this.txtSBOUserName.Text = "manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña BD";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(547, 86);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.Size = new System.Drawing.Size(207, 33);
            this.txtDBPassword.TabIndex = 7;
            this.txtDBPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario BD";
            // 
            // txtDBUserName
            // 
            this.txtDBUserName.Location = new System.Drawing.Point(547, 55);
            this.txtDBUserName.Name = "txtDBUserName";
            this.txtDBUserName.Size = new System.Drawing.Size(207, 33);
            this.txtDBUserName.TabIndex = 6;
            this.txtDBUserName.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servidor de licencias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(547, 24);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(207, 33);
            this.txtDB.TabIndex = 5;
            // 
            // txtLicenseServer
            // 
            this.txtLicenseServer.Location = new System.Drawing.Point(140, 60);
            this.txtLicenseServer.Name = "txtLicenseServer";
            this.txtLicenseServer.Size = new System.Drawing.Size(209, 33);
            this.txtLicenseServer.TabIndex = 2;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(140, 27);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(209, 33);
            this.txtServer.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(638, 122);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 33);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImportarXML);
            this.groupBox2.Controls.Add(this.btnCancelarDocmentos);
            this.groupBox2.Controls.Add(this.btnImportFromExcel);
            this.groupBox2.Controls.Add(this.txtSignDigest);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSignMsg);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtReportID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDocEntry);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDocNum);
            this.groupBox2.Controls.Add(this.cbTypes);
            this.groupBox2.Controls.Add(this.rbDocument);
            this.groupBox2.Controls.Add(this.rbPayment);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importar documento electrónico";
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Location = new System.Drawing.Point(140, 215);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(209, 33);
            this.btnImportarXML.TabIndex = 34;
            this.btnImportarXML.Text = "Importar XML desde carpeta";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // btnCancelarDocmentos
            // 
            this.btnCancelarDocmentos.Location = new System.Drawing.Point(9, 215);
            this.btnCancelarDocmentos.Name = "btnCancelarDocmentos";
            this.btnCancelarDocmentos.Size = new System.Drawing.Size(35, 33);
            this.btnCancelarDocmentos.TabIndex = 33;
            this.btnCancelarDocmentos.Text = "Cancelar";
            this.btnCancelarDocmentos.UseVisualStyleBackColor = true;
            this.btnCancelarDocmentos.Visible = false;
            this.btnCancelarDocmentos.Click += new System.EventHandler(this.btnCancelarDocmentos_Click);
            // 
            // btnImportFromExcel
            // 
            this.btnImportFromExcel.Location = new System.Drawing.Point(409, 215);
            this.btnImportFromExcel.Name = "btnImportFromExcel";
            this.btnImportFromExcel.Size = new System.Drawing.Size(160, 33);
            this.btnImportFromExcel.TabIndex = 32;
            this.btnImportFromExcel.Text = "Importar desde Excel";
            this.btnImportFromExcel.UseVisualStyleBackColor = true;
            this.btnImportFromExcel.Click += new System.EventHandler(this.btnImportFromExcel_Click);
            // 
            // txtSignDigest
            // 
            this.txtSignDigest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignDigest.Location = new System.Drawing.Point(409, 153);
            this.txtSignDigest.Name = "txtSignDigest";
            this.txtSignDigest.Size = new System.Drawing.Size(341, 56);
            this.txtSignDigest.TabIndex = 16;
            this.txtSignDigest.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "Sello CFD";
            // 
            // txtSignMsg
            // 
            this.txtSignMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignMsg.Location = new System.Drawing.Point(409, 60);
            this.txtSignMsg.Name = "txtSignMsg";
            this.txtSignMsg.Size = new System.Drawing.Size(341, 56);
            this.txtSignMsg.TabIndex = 15;
            this.txtSignMsg.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "Cadena original";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(140, 184);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(209, 33);
            this.dtDate.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 28);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha timbrado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "UUID";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(140, 153);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.Size = new System.Drawing.Size(209, 33);
            this.txtReportID.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "N° de entrada";
            // 
            // txtDocEntry
            // 
            this.txtDocEntry.Location = new System.Drawing.Point(140, 91);
            this.txtDocEntry.Name = "txtDocEntry";
            this.txtDocEntry.Size = new System.Drawing.Size(209, 33);
            this.txtDocEntry.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "N° de documento";
            // 
            // txtDocNum
            // 
            this.txtDocNum.Location = new System.Drawing.Point(140, 122);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(209, 33);
            this.txtDocNum.TabIndex = 12;
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "Factura",
            "Nota de crédito"});
            this.cbTypes.Location = new System.Drawing.Point(140, 60);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(209, 36);
            this.cbTypes.TabIndex = 10;
            // 
            // rbDocument
            // 
            this.rbDocument.AutoSize = true;
            this.rbDocument.Location = new System.Drawing.Point(140, 27);
            this.rbDocument.Name = "rbDocument";
            this.rbDocument.Size = new System.Drawing.Size(140, 32);
            this.rbDocument.TabIndex = 9;
            this.rbDocument.TabStop = true;
            this.rbDocument.Text = "Documento";
            this.rbDocument.UseVisualStyleBackColor = true;
            this.rbDocument.CheckedChanged += new System.EventHandler(this.rbDocument_CheckedChanged);
            // 
            // rbPayment
            // 
            this.rbPayment.AutoSize = true;
            this.rbPayment.Location = new System.Drawing.Point(291, 27);
            this.rbPayment.Name = "rbPayment";
            this.rbPayment.Size = new System.Drawing.Size(81, 32);
            this.rbPayment.TabIndex = 16;
            this.rbPayment.TabStop = true;
            this.rbPayment.Text = "Pago";
            this.rbPayment.UseVisualStyleBackColor = true;
            this.rbPayment.CheckedChanged += new System.EventHandler(this.rbDocument_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 28);
            this.label15.TabIndex = 15;
            this.label15.Text = "Tipo";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(634, 215);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(116, 33);
            this.btnImport.TabIndex = 17;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBO Electronic Document Importer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtLicenseServer;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSBOPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSBOUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RadioButton rbDocument;
        private System.Windows.Forms.RadioButton rbPayment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDocEntry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.RichTextBox txtSignDigest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtSignMsg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImportFromExcel;
        private System.Windows.Forms.ComboBox cbServerTypes;
        private System.Windows.Forms.Button btnCancelarDocmentos;
        private System.Windows.Forms.Button btnImportarXML;
    }
}

