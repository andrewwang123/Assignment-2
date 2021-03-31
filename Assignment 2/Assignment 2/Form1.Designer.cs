namespace Assignment_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnModifySale = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.productOrderType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.productMarketPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.productShares = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.productTickerSymbol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.productCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMainMenuAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMainMenuModify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMainMenuReporting = new System.Windows.Forms.Button();
            this.productOrderType2 = new System.Windows.Forms.TextBox();
            this.productMarketPrice2 = new System.Windows.Forms.TextBox();
            this.productShares2 = new System.Windows.Forms.TextBox();
            this.productTickerSymbol2 = new System.Windows.Forms.TextBox();
            this.productCompany2 = new System.Windows.Forms.TextBox();
            this.productID2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the Stock Market";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select one of the following:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSale.Location = new System.Drawing.Point(198, 151);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(131, 45);
            this.btnAddSale.TabIndex = 10;
            this.btnAddSale.Text = "Add Trade";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnModifySale
            // 
            this.btnModifySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifySale.Location = new System.Drawing.Point(27, 151);
            this.btnModifySale.Name = "btnModifySale";
            this.btnModifySale.Size = new System.Drawing.Size(149, 45);
            this.btnModifySale.TabIndex = 11;
            this.btnModifySale.Text = "Modify Trade";
            this.btnModifySale.UseVisualStyleBackColor = true;
            this.btnModifySale.Click += new System.EventHandler(this.btnModifySale_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporting.Location = new System.Drawing.Point(361, 151);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(131, 45);
            this.btnReporting.TabIndex = 12;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnReporting);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnModifySale);
            this.panel1.Controls.Add(this.btnAddSale);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 483);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.productOrderType);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.productMarketPrice);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.productShares);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.productTickerSymbol);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.productCompany);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.productID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnMainMenuAdd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(51, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 482);
            this.panel2.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(103, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 45);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // productOrderType
            // 
            this.productOrderType.Location = new System.Drawing.Point(169, 331);
            this.productOrderType.Name = "productOrderType";
            this.productOrderType.Size = new System.Drawing.Size(306, 26);
            this.productOrderType.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Order Type:";
            // 
            // productMarketPrice
            // 
            this.productMarketPrice.Location = new System.Drawing.Point(169, 250);
            this.productMarketPrice.Name = "productMarketPrice";
            this.productMarketPrice.Size = new System.Drawing.Size(306, 26);
            this.productMarketPrice.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Market Price:";
            // 
            // productShares
            // 
            this.productShares.Location = new System.Drawing.Point(169, 292);
            this.productShares.Name = "productShares";
            this.productShares.Size = new System.Drawing.Size(306, 26);
            this.productShares.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Shares:";
            // 
            // productTickerSymbol
            // 
            this.productTickerSymbol.Location = new System.Drawing.Point(169, 204);
            this.productTickerSymbol.Name = "productTickerSymbol";
            this.productTickerSymbol.Size = new System.Drawing.Size(306, 26);
            this.productTickerSymbol.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ticker Symbol:";
            // 
            // productCompany
            // 
            this.productCompany.Location = new System.Drawing.Point(169, 160);
            this.productCompany.Name = "productCompany";
            this.productCompany.Size = new System.Drawing.Size(306, 26);
            this.productCompany.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Company:";
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(169, 122);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(306, 26);
            this.productID.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sale ID:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Sale";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainMenuAdd
            // 
            this.btnMainMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuAdd.Location = new System.Drawing.Point(309, 386);
            this.btnMainMenuAdd.Name = "btnMainMenuAdd";
            this.btnMainMenuAdd.Size = new System.Drawing.Size(131, 45);
            this.btnMainMenuAdd.TabIndex = 12;
            this.btnMainMenuAdd.Text = "Main Menu";
            this.btnMainMenuAdd.UseVisualStyleBackColor = true;
            this.btnMainMenuAdd.Click += new System.EventHandler(this.btnMainMenuAdd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 47);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please select one of the following:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productOrderType2);
            this.panel3.Controls.Add(this.productMarketPrice2);
            this.panel3.Controls.Add(this.productShares2);
            this.panel3.Controls.Add(this.productTickerSymbol2);
            this.panel3.Controls.Add(this.productCompany2);
            this.panel3.Controls.Add(this.productID2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnMainMenuModify);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 482);
            this.panel3.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Order Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Market Price:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(109, 292);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Shares:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Ticker Symbol:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(93, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "Company:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(103, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 20);
            this.label19.TabIndex = 25;
            this.label19.Text = "Sale ID:";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(232, 386);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 45);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modify Sale";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainMenuModify
            // 
            this.btnMainMenuModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuModify.Location = new System.Drawing.Point(380, 386);
            this.btnMainMenuModify.Name = "btnMainMenuModify";
            this.btnMainMenuModify.Size = new System.Drawing.Size(131, 45);
            this.btnMainMenuModify.TabIndex = 12;
            this.btnMainMenuModify.Text = "Main Menu";
            this.btnMainMenuModify.UseVisualStyleBackColor = true;
            this.btnMainMenuModify.Click += new System.EventHandler(this.btnMainMenuModify_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 48);
            this.label6.TabIndex = 6;
            this.label6.Text = "Please select one of the following:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(80, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnMainMenuReporting);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(51, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 480);
            this.panel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "Reporting";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainMenuReporting
            // 
            this.btnMainMenuReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuReporting.Location = new System.Drawing.Point(168, 208);
            this.btnMainMenuReporting.Name = "btnMainMenuReporting";
            this.btnMainMenuReporting.Size = new System.Drawing.Size(131, 45);
            this.btnMainMenuReporting.TabIndex = 12;
            this.btnMainMenuReporting.Text = "Main Menu";
            this.btnMainMenuReporting.UseVisualStyleBackColor = true;
            this.btnMainMenuReporting.Click += new System.EventHandler(this.btnMainMenuReporting_Click);
            // 
            // productOrderType2
            // 
            this.productOrderType2.Location = new System.Drawing.Point(179, 328);
            this.productOrderType2.Name = "productOrderType2";
            this.productOrderType2.Size = new System.Drawing.Size(306, 26);
            this.productOrderType2.TabIndex = 41;
            // 
            // productMarketPrice2
            // 
            this.productMarketPrice2.Location = new System.Drawing.Point(179, 247);
            this.productMarketPrice2.Name = "productMarketPrice2";
            this.productMarketPrice2.Size = new System.Drawing.Size(306, 26);
            this.productMarketPrice2.TabIndex = 40;
            // 
            // productShares2
            // 
            this.productShares2.Location = new System.Drawing.Point(179, 289);
            this.productShares2.Name = "productShares2";
            this.productShares2.Size = new System.Drawing.Size(306, 26);
            this.productShares2.TabIndex = 39;
            // 
            // productTickerSymbol2
            // 
            this.productTickerSymbol2.Location = new System.Drawing.Point(179, 201);
            this.productTickerSymbol2.Name = "productTickerSymbol2";
            this.productTickerSymbol2.Size = new System.Drawing.Size(306, 26);
            this.productTickerSymbol2.TabIndex = 38;
            // 
            // productCompany2
            // 
            this.productCompany2.Location = new System.Drawing.Point(179, 157);
            this.productCompany2.Name = "productCompany2";
            this.productCompany2.Size = new System.Drawing.Size(306, 26);
            this.productCompany2.TabIndex = 37;
            // 
            // productID2
            // 
            this.productID2.Location = new System.Drawing.Point(179, 119);
            this.productID2.Name = "productID2";
            this.productID2.Size = new System.Drawing.Size(306, 26);
            this.productID2.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnModifySale;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMainMenuAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMainMenuModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMainMenuReporting;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox productOrderType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox productMarketPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox productShares;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox productTickerSymbol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox productCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox productOrderType2;
        private System.Windows.Forms.TextBox productMarketPrice2;
        private System.Windows.Forms.TextBox productShares2;
        private System.Windows.Forms.TextBox productTickerSymbol2;
        private System.Windows.Forms.TextBox productCompany2;
        private System.Windows.Forms.TextBox productID2;
    }
}

