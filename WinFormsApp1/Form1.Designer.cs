
using System;

namespace WinFormsApp1
{
    partial class frmArticles
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
            this.lblRegistres = new System.Windows.Forms.Label();
            this.txtRegistres = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCodiArticle = new System.Windows.Forms.TextBox();
            this.txtDescripcioArticle = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtPreu = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCodi = new System.Windows.Forms.Label();
            this.lblDescripcio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPreu = new System.Windows.Forms.Label();
            this.lblDivisa = new System.Windows.Forms.Label();
            this.btnGoToRecord = new System.Windows.Forms.Button();
            this.btnDeleteCurrentRecord = new System.Windows.Forms.Button();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnExportToTxt = new System.Windows.Forms.Button();
            this.txtRegToGo = new System.Windows.Forms.TextBox();
            this.lblRegToGo = new System.Windows.Forms.Label();
            this.btnConfirmarAlta = new System.Windows.Forms.Button();
            this.btnCancelAlta = new System.Windows.Forms.Button();
            this.btnSerialitzar = new System.Windows.Forms.Button();
            this.btnCercaXMLPerCodi = new System.Windows.Forms.Button();
            this.btnUpdateXML = new System.Windows.Forms.Button();
            this.btnDeleteXML = new System.Windows.Forms.Button();
            this.btnAddXML = new System.Windows.Forms.Button();
            this.btnCancelAltaXML = new System.Windows.Forms.Button();
            this.btnDoAltaXML = new System.Windows.Forms.Button();
            this.txtDocumentXML = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRegistres
            // 
            this.lblRegistres.AutoSize = true;
            this.lblRegistres.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistres.Location = new System.Drawing.Point(614, 82);
            this.lblRegistres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistres.Name = "lblRegistres";
            this.lblRegistres.Size = new System.Drawing.Size(293, 41);
            this.lblRegistres.TabIndex = 0;
            this.lblRegistres.Text = "RANG DE REGISTRES";
            // 
            // txtRegistres
            // 
            this.txtRegistres.Enabled = false;
            this.txtRegistres.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegistres.Location = new System.Drawing.Point(901, 77);
            this.txtRegistres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegistres.Name = "txtRegistres";
            this.txtRegistres.Size = new System.Drawing.Size(64, 47);
            this.txtRegistres.TabIndex = 1;
            this.txtRegistres.TextChanged += new System.EventHandler(this.txtRegistres_TextChanged);
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum.Location = new System.Drawing.Point(320, 165);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(131, 39);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodiArticle
            // 
            this.txtCodiArticle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodiArticle.Location = new System.Drawing.Point(320, 260);
            this.txtCodiArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodiArticle.Name = "txtCodiArticle";
            this.txtCodiArticle.Size = new System.Drawing.Size(317, 39);
            this.txtCodiArticle.TabIndex = 4;
            this.txtCodiArticle.TextChanged += new System.EventHandler(this.txtCodiArticle_TextChanged);
            // 
            // txtDescripcioArticle
            // 
            this.txtDescripcioArticle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcioArticle.Location = new System.Drawing.Point(320, 358);
            this.txtDescripcioArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcioArticle.Name = "txtDescripcioArticle";
            this.txtDescripcioArticle.Size = new System.Drawing.Size(360, 39);
            this.txtDescripcioArticle.TabIndex = 5;
            this.txtDescripcioArticle.TextChanged += new System.EventHandler(this.txtDescripcioArticle_TextChanged);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColor.Location = new System.Drawing.Point(320, 463);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(317, 39);
            this.txtColor.TabIndex = 6;
            // 
            // txtTalla
            // 
            this.txtTalla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTalla.Location = new System.Drawing.Point(320, 563);
            this.txtTalla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(131, 39);
            this.txtTalla.TabIndex = 7;
            // 
            // txtPreu
            // 
            this.txtPreu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreu.Location = new System.Drawing.Point(320, 663);
            this.txtPreu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreu.Name = "txtPreu";
            this.txtPreu.Size = new System.Drawing.Size(131, 39);
            this.txtPreu.TabIndex = 8;
            this.txtPreu.TextChanged += new System.EventHandler(this.txtPreu_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum.Location = new System.Drawing.Point(6, 160);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(323, 41);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "NUMERO DE REGISTRE";
            this.lblNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodi.Location = new System.Drawing.Point(83, 262);
            this.lblCodi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(232, 41);
            this.lblCodi.TabIndex = 10;
            this.lblCodi.Text = "CODI D\'ARTICLE";
            // 
            // lblDescripcio
            // 
            this.lblDescripcio.AutoSize = true;
            this.lblDescripcio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcio.Location = new System.Drawing.Point(21, 360);
            this.lblDescripcio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcio.Name = "lblDescripcio";
            this.lblDescripcio.Size = new System.Drawing.Size(298, 41);
            this.lblDescripcio.TabIndex = 11;
            this.lblDescripcio.Text = "DESCRIPCIÓ ARTICLE";
            this.lblDescripcio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(83, 465);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(229, 41);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "COLOR ARTICLE";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTalla.Location = new System.Drawing.Point(83, 565);
            this.lblTalla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(215, 41);
            this.lblTalla.TabIndex = 13;
            this.lblTalla.Text = "TALLA ARTICLE";
            // 
            // lblPreu
            // 
            this.lblPreu.AutoSize = true;
            this.lblPreu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreu.Location = new System.Drawing.Point(83, 665);
            this.lblPreu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreu.Name = "lblPreu";
            this.lblPreu.Size = new System.Drawing.Size(205, 41);
            this.lblPreu.TabIndex = 14;
            this.lblPreu.Text = "PREU ARTICLE";
            // 
            // lblDivisa
            // 
            this.lblDivisa.AutoSize = true;
            this.lblDivisa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDivisa.Location = new System.Drawing.Point(509, 665);
            this.lblDivisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDivisa.Name = "lblDivisa";
            this.lblDivisa.Size = new System.Drawing.Size(34, 41);
            this.lblDivisa.TabIndex = 15;
            this.lblDivisa.Text = "€";
            // 
            // btnGoToRecord
            // 
            this.btnGoToRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToRecord.Location = new System.Drawing.Point(1120, 70);
            this.btnGoToRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoToRecord.Name = "btnGoToRecord";
            this.btnGoToRecord.Size = new System.Drawing.Size(199, 87);
            this.btnGoToRecord.TabIndex = 16;
            this.btnGoToRecord.Text = "ACCÉS DIRECTE A REGISTRE";
            this.btnGoToRecord.UseVisualStyleBackColor = true;
            this.btnGoToRecord.Click += new System.EventHandler(this.btnGoToRecord_Click);
            // 
            // btnDeleteCurrentRecord
            // 
            this.btnDeleteCurrentRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCurrentRecord.Location = new System.Drawing.Point(1120, 177);
            this.btnDeleteCurrentRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCurrentRecord.Name = "btnDeleteCurrentRecord";
            this.btnDeleteCurrentRecord.Size = new System.Drawing.Size(199, 132);
            this.btnDeleteCurrentRecord.TabIndex = 17;
            this.btnDeleteCurrentRecord.Text = "ESBORRAT LÒGIC R.ACTUAL";
            this.btnDeleteCurrentRecord.UseVisualStyleBackColor = true;
            this.btnDeleteCurrentRecord.Click += new System.EventHandler(this.btnDeleteCurrentRecord_Click);
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateRecord.Location = new System.Drawing.Point(1120, 322);
            this.btnUpdateRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(199, 132);
            this.btnUpdateRecord.TabIndex = 18;
            this.btnUpdateRecord.Text = "MODIFICAR  R.ACTUAL";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRecord.Location = new System.Drawing.Point(1120, 480);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(199, 132);
            this.btnAddRecord.TabIndex = 19;
            this.btnAddRecord.Text = "AFEGIR NOU REGISTRE";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnExportToTxt
            // 
            this.btnExportToTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportToTxt.Location = new System.Drawing.Point(1120, 647);
            this.btnExportToTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportToTxt.Name = "btnExportToTxt";
            this.btnExportToTxt.Size = new System.Drawing.Size(199, 132);
            this.btnExportToTxt.TabIndex = 20;
            this.btnExportToTxt.Text = "EXPORTAR A TXT";
            this.btnExportToTxt.UseVisualStyleBackColor = true;
            this.btnExportToTxt.Click += new System.EventHandler(this.btnExportToTxt_Click);
            // 
            // txtRegToGo
            // 
            this.txtRegToGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegToGo.Location = new System.Drawing.Point(1359, 90);
            this.txtRegToGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegToGo.Name = "txtRegToGo";
            this.txtRegToGo.Size = new System.Drawing.Size(168, 39);
            this.txtRegToGo.TabIndex = 21;
            this.txtRegToGo.TextChanged += new System.EventHandler(this.txtRegToGo_TextChanged);
            // 
            // lblRegToGo
            // 
            this.lblRegToGo.AutoSize = true;
            this.lblRegToGo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegToGo.Location = new System.Drawing.Point(1359, 15);
            this.lblRegToGo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegToGo.Name = "lblRegToGo";
            this.lblRegToGo.Size = new System.Drawing.Size(232, 41);
            this.lblRegToGo.TabIndex = 22;
            this.lblRegToGo.Text = "NUM.REG.DESTÍ";
            // 
            // btnConfirmarAlta
            // 
            this.btnConfirmarAlta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarAlta.Location = new System.Drawing.Point(1343, 480);
            this.btnConfirmarAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarAlta.Name = "btnConfirmarAlta";
            this.btnConfirmarAlta.Size = new System.Drawing.Size(199, 132);
            this.btnConfirmarAlta.TabIndex = 23;
            this.btnConfirmarAlta.Text = "CONFIRMAR ALTA";
            this.btnConfirmarAlta.UseVisualStyleBackColor = true;
            this.btnConfirmarAlta.Click += new System.EventHandler(this.btnConfirmarAlta_Click);
            // 
            // btnCancelAlta
            // 
            this.btnCancelAlta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAlta.Location = new System.Drawing.Point(1566, 480);
            this.btnCancelAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelAlta.Name = "btnCancelAlta";
            this.btnCancelAlta.Size = new System.Drawing.Size(199, 132);
            this.btnCancelAlta.TabIndex = 24;
            this.btnCancelAlta.Text = "CANCEL·LAR ALTA";
            this.btnCancelAlta.UseVisualStyleBackColor = true;
            this.btnCancelAlta.Click += new System.EventHandler(this.btnCancelAlta_Click);
            // 
            // btnSerialitzar
            // 
            this.btnSerialitzar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerialitzar.Location = new System.Drawing.Point(1120, 817);
            this.btnSerialitzar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerialitzar.Name = "btnSerialitzar";
            this.btnSerialitzar.Size = new System.Drawing.Size(199, 132);
            this.btnSerialitzar.TabIndex = 25;
            this.btnSerialitzar.Text = "SERIALITZACIÓ XML";
            this.btnSerialitzar.UseVisualStyleBackColor = true;
            this.btnSerialitzar.Click += new System.EventHandler(this.btnSerialitzar_Click);
            // 
            // btnCercaXMLPerCodi
            // 
            this.btnCercaXMLPerCodi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCercaXMLPerCodi.Location = new System.Drawing.Point(1327, 817);
            this.btnCercaXMLPerCodi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCercaXMLPerCodi.Name = "btnCercaXMLPerCodi";
            this.btnCercaXMLPerCodi.Size = new System.Drawing.Size(199, 132);
            this.btnCercaXMLPerCodi.TabIndex = 26;
            this.btnCercaXMLPerCodi.Text = "CERCAR PER CODI";
            this.btnCercaXMLPerCodi.UseVisualStyleBackColor = true;
            this.btnCercaXMLPerCodi.Click += new System.EventHandler(this.btnCercaXMLPerCodi_Click);
            // 
            // btnUpdateXML
            // 
            this.btnUpdateXML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateXML.Location = new System.Drawing.Point(1549, 817);
            this.btnUpdateXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateXML.Name = "btnUpdateXML";
            this.btnUpdateXML.Size = new System.Drawing.Size(199, 132);
            this.btnUpdateXML.TabIndex = 27;
            this.btnUpdateXML.Text = "ACTUALITZAR NODE";
            this.btnUpdateXML.UseVisualStyleBackColor = true;
            this.btnUpdateXML.Click += new System.EventHandler(this.btnUpdateXML_Click);
            // 
            // btnDeleteXML
            // 
            this.btnDeleteXML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteXML.Location = new System.Drawing.Point(1330, 990);
            this.btnDeleteXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteXML.Name = "btnDeleteXML";
            this.btnDeleteXML.Size = new System.Drawing.Size(199, 132);
            this.btnDeleteXML.TabIndex = 28;
            this.btnDeleteXML.Text = "ELIMINAR NODE";
            this.btnDeleteXML.UseVisualStyleBackColor = true;
            this.btnDeleteXML.Click += new System.EventHandler(this.btnDeleteXML_Click);
            // 
            // btnAddXML
            // 
            this.btnAddXML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddXML.Location = new System.Drawing.Point(1549, 990);
            this.btnAddXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddXML.Name = "btnAddXML";
            this.btnAddXML.Size = new System.Drawing.Size(199, 132);
            this.btnAddXML.TabIndex = 29;
            this.btnAddXML.Text = "AFEGIR NOU NODE";
            this.btnAddXML.UseVisualStyleBackColor = true;
            this.btnAddXML.Click += new System.EventHandler(this.btnAddXML_Click);
            // 
            // btnCancelAltaXML
            // 
            this.btnCancelAltaXML.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAltaXML.Location = new System.Drawing.Point(1760, 1062);
            this.btnCancelAltaXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelAltaXML.Name = "btnCancelAltaXML";
            this.btnCancelAltaXML.Size = new System.Drawing.Size(137, 60);
            this.btnCancelAltaXML.TabIndex = 31;
            this.btnCancelAltaXML.Text = "CANCEL·LAR ALTA";
            this.btnCancelAltaXML.UseVisualStyleBackColor = true;
            this.btnCancelAltaXML.Click += new System.EventHandler(this.btnCancelAltaXML_Click);
            // 
            // btnDoAltaXML
            // 
            this.btnDoAltaXML.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoAltaXML.Location = new System.Drawing.Point(1760, 990);
            this.btnDoAltaXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoAltaXML.Name = "btnDoAltaXML";
            this.btnDoAltaXML.Size = new System.Drawing.Size(137, 62);
            this.btnDoAltaXML.TabIndex = 30;
            this.btnDoAltaXML.Text = "CONFIRMAR ALTA";
            this.btnDoAltaXML.UseVisualStyleBackColor = true;
            this.btnDoAltaXML.Click += new System.EventHandler(this.btnDoAltaXML_Click);
            // 
            // txtDocumentXML
            // 
            this.txtDocumentXML.Location = new System.Drawing.Point(696, 182);
            this.txtDocumentXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocumentXML.Multiline = true;
            this.txtDocumentXML.Name = "txtDocumentXML";
            this.txtDocumentXML.Size = new System.Drawing.Size(371, 914);
            this.txtDocumentXML.TabIndex = 32;
            this.txtDocumentXML.TextChanged += new System.EventHandler(this.txtDocumentXML_TextChanged);
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1954, 1203);
            this.Controls.Add(this.txtDocumentXML);
            this.Controls.Add(this.btnCancelAltaXML);
            this.Controls.Add(this.btnDoAltaXML);
            this.Controls.Add(this.btnAddXML);
            this.Controls.Add(this.btnDeleteXML);
            this.Controls.Add(this.btnUpdateXML);
            this.Controls.Add(this.btnCercaXMLPerCodi);
            this.Controls.Add(this.btnSerialitzar);
            this.Controls.Add(this.btnCancelAlta);
            this.Controls.Add(this.btnConfirmarAlta);
            this.Controls.Add(this.lblRegToGo);
            this.Controls.Add(this.txtRegToGo);
            this.Controls.Add(this.btnExportToTxt);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnDeleteCurrentRecord);
            this.Controls.Add(this.btnGoToRecord);
            this.Controls.Add(this.lblDivisa);
            this.Controls.Add(this.lblPreu);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblDescripcio);
            this.Controls.Add(this.lblCodi);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtPreu);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtDescripcioArticle);
            this.Controls.Add(this.txtCodiArticle);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtRegistres);
            this.Controls.Add(this.lblRegistres);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArticles";
            this.Text = "MANTENIMENT D\'ARTICLES";
            this.Load += new System.EventHandler(this.frmArticles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblRegistres;
        private System.Windows.Forms.TextBox txtRegistres;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCodiArticle;
        private System.Windows.Forms.TextBox txtDescripcioArticle;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtPreu;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.Label lblDescripcio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPreu;
        private System.Windows.Forms.Label lblDivisa;
        private System.Windows.Forms.Button btnGoToRecord;
        private System.Windows.Forms.Button btnDeleteCurrentRecord;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnExportToTxt;
        private System.Windows.Forms.TextBox txtRegToGo;
        private System.Windows.Forms.Label lblRegToGo;
        private System.Windows.Forms.Button btnConfirmarAlta;
        private System.Windows.Forms.Button btnCancelAlta;
        private System.Windows.Forms.Button btnSerialitzar;
        private System.Windows.Forms.Button btnCercaXMLPerCodi;
        private System.Windows.Forms.Button btnUpdateXML;
        private System.Windows.Forms.Button btnDeleteXML;
        private System.Windows.Forms.Button btnAddXML;
        private System.Windows.Forms.Button btnCancelAltaXML;
        private System.Windows.Forms.Button btnDoAltaXML;
        private System.Windows.Forms.TextBox txtDocumentXML;
    }
}

