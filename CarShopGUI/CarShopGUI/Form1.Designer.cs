
namespace CarShopGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClearInventory = new System.Windows.Forms.Button();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.radioUsed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUsed);
            this.groupBox1.Controls.Add(this.radioNew);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCreateCar);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(7, 183);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(192, 23);
            this.btnCreateCar.TabIndex = 6;
            this.btnCreateCar.Text = "Create a Car";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(50, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(149, 23);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(50, 67);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(149, 23);
            this.txtModel.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(50, 31);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(149, 23);
            this.txtMake.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstInventory);
            this.groupBox2.Location = new System.Drawing.Point(287, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory";
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 15;
            this.lstInventory.Location = new System.Drawing.Point(6, 34);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(212, 304);
            this.lstInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(520, 212);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 23);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to cart ->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstCart);
            this.groupBox3.Location = new System.Drawing.Point(632, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 353);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 15;
            this.lstCart.Location = new System.Drawing.Point(7, 38);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(204, 304);
            this.lstCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(632, 372);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(217, 23);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(649, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(730, 423);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "$0.00";
            // 
            // btnClearInventory
            // 
            this.btnClearInventory.Location = new System.Drawing.Point(287, 371);
            this.btnClearInventory.Name = "btnClearInventory";
            this.btnClearInventory.Size = new System.Drawing.Size(224, 23);
            this.btnClearInventory.TabIndex = 7;
            this.btnClearInventory.Text = "Clear Inventory";
            this.btnClearInventory.UseVisualStyleBackColor = true;
            this.btnClearInventory.Click += new System.EventHandler(this.btnClearInventory_Click);
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Location = new System.Drawing.Point(52, 147);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(49, 19);
            this.radioNew.TabIndex = 9;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "New";
            this.radioNew.UseVisualStyleBackColor = true;
            // 
            // radioUsed
            // 
            this.radioUsed.AutoSize = true;
            this.radioUsed.Location = new System.Drawing.Point(111, 147);
            this.radioUsed.Name = "radioUsed";
            this.radioUsed.Size = new System.Drawing.Size(51, 19);
            this.radioUsed.TabIndex = 10;
            this.radioUsed.TabStop = true;
            this.radioUsed.Text = "Used";
            this.radioUsed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.btnClearInventory);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearInventory;
        private System.Windows.Forms.RadioButton radioUsed;
        private System.Windows.Forms.RadioButton radioNew;
    }
}

