namespace JuiceBarApplication
{
    partial class JuiceBarMain
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
            this.lblJuiceBarMenu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbJuice = new System.Windows.Forms.GroupBox();
            this.rbFruit = new System.Windows.Forms.RadioButton();
            this.rbVeggie = new System.Windows.Forms.RadioButton();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbTwentyOunce = new System.Windows.Forms.RadioButton();
            this.rbSixteenOunce = new System.Windows.Forms.RadioButton();
            this.rbTwelveOunce = new System.Windows.Forms.RadioButton();
            this.gbSmoothies = new System.Windows.Forms.GroupBox();
            this.rbWheatBerry = new System.Windows.Forms.RadioButton();
            this.rbStrawBanana = new System.Windows.Forms.RadioButton();
            this.rbPom = new System.Windows.Forms.RadioButton();
            this.lbAdditives = new System.Windows.Forms.Label();
            this.cbVitaPack = new System.Windows.Forms.CheckBox();
            this.cbEngBoost = new System.Windows.Forms.CheckBox();
            this.cbCDRem = new System.Windows.Forms.CheckBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCheckout = new System.Windows.Forms.Button();
            this.btViewOrderSum = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.rbJuice = new System.Windows.Forms.RadioButton();
            this.rbSmoothie = new System.Windows.Forms.RadioButton();
            this.gbDrinkChoice = new System.Windows.Forms.GroupBox();
            this.fontDialogMain = new System.Windows.Forms.FontDialog();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.gbJuice.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbSmoothies.SuspendLayout();
            this.gbDrinkChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJuiceBarMenu
            // 
            this.lblJuiceBarMenu.AutoSize = true;
            this.lblJuiceBarMenu.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuiceBarMenu.Location = new System.Drawing.Point(378, 33);
            this.lblJuiceBarMenu.Name = "lblJuiceBarMenu";
            this.lblJuiceBarMenu.Size = new System.Drawing.Size(374, 67);
            this.lblJuiceBarMenu.TabIndex = 0;
            this.lblJuiceBarMenu.Text = "Juice Bar Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderSumToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // orderSumToolStripMenuItem
            // 
            this.orderSumToolStripMenuItem.Name = "orderSumToolStripMenuItem";
            this.orderSumToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.orderSumToolStripMenuItem.Text = "Order Summary";
            this.orderSumToolStripMenuItem.Click += new System.EventHandler(this.orderSumToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.addToOrderToolStripMenuItem.Text = "Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.addToOrderToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbJuice
            // 
            this.gbJuice.Controls.Add(this.rbFruit);
            this.gbJuice.Controls.Add(this.rbVeggie);
            this.gbJuice.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJuice.Location = new System.Drawing.Point(12, 156);
            this.gbJuice.Name = "gbJuice";
            this.gbJuice.Size = new System.Drawing.Size(214, 144);
            this.gbJuice.TabIndex = 2;
            this.gbJuice.TabStop = false;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(26, 48);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(83, 32);
            this.rbFruit.TabIndex = 4;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "Fruit";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // rbVeggie
            // 
            this.rbVeggie.AutoSize = true;
            this.rbVeggie.Location = new System.Drawing.Point(26, 100);
            this.rbVeggie.Name = "rbVeggie";
            this.rbVeggie.Size = new System.Drawing.Size(100, 32);
            this.rbVeggie.TabIndex = 3;
            this.rbVeggie.TabStop = true;
            this.rbVeggie.Text = "Veggie";
            this.rbVeggie.UseVisualStyleBackColor = true;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(258, 418);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(98, 28);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(281, 449);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 33);
            this.tbQuantity.TabIndex = 5;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbTwentyOunce);
            this.gbSize.Controls.Add(this.rbSixteenOunce);
            this.gbSize.Controls.Add(this.rbTwelveOunce);
            this.gbSize.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(12, 418);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(214, 220);
            this.gbSize.TabIndex = 2;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbTwentyOunce
            // 
            this.rbTwentyOunce.AutoSize = true;
            this.rbTwentyOunce.Location = new System.Drawing.Point(26, 168);
            this.rbTwentyOunce.Name = "rbTwentyOunce";
            this.rbTwentyOunce.Size = new System.Drawing.Size(179, 32);
            this.rbTwentyOunce.TabIndex = 2;
            this.rbTwentyOunce.TabStop = true;
            this.rbTwentyOunce.Text = "20 oz.  -  $4.00";
            this.rbTwentyOunce.UseVisualStyleBackColor = true;
            // 
            // rbSixteenOunce
            // 
            this.rbSixteenOunce.AutoSize = true;
            this.rbSixteenOunce.Location = new System.Drawing.Point(26, 109);
            this.rbSixteenOunce.Name = "rbSixteenOunce";
            this.rbSixteenOunce.Size = new System.Drawing.Size(176, 32);
            this.rbSixteenOunce.TabIndex = 1;
            this.rbSixteenOunce.TabStop = true;
            this.rbSixteenOunce.Text = "16 oz.  -  $3.50";
            this.rbSixteenOunce.UseVisualStyleBackColor = true;
            // 
            // rbTwelveOunce
            // 
            this.rbTwelveOunce.AutoSize = true;
            this.rbTwelveOunce.Location = new System.Drawing.Point(26, 53);
            this.rbTwelveOunce.Name = "rbTwelveOunce";
            this.rbTwelveOunce.Size = new System.Drawing.Size(176, 32);
            this.rbTwelveOunce.TabIndex = 11;
            this.rbTwelveOunce.TabStop = true;
            this.rbTwelveOunce.Text = "12 oz.  -  $3.00";
            this.rbTwelveOunce.UseVisualStyleBackColor = true;
            // 
            // gbSmoothies
            // 
            this.gbSmoothies.Controls.Add(this.rbWheatBerry);
            this.gbSmoothies.Controls.Add(this.rbStrawBanana);
            this.gbSmoothies.Controls.Add(this.rbPom);
            this.gbSmoothies.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSmoothies.Location = new System.Drawing.Point(263, 156);
            this.gbSmoothies.Name = "gbSmoothies";
            this.gbSmoothies.Size = new System.Drawing.Size(256, 213);
            this.gbSmoothies.TabIndex = 3;
            this.gbSmoothies.TabStop = false;
            // 
            // rbWheatBerry
            // 
            this.rbWheatBerry.AutoSize = true;
            this.rbWheatBerry.Location = new System.Drawing.Point(24, 151);
            this.rbWheatBerry.Name = "rbWheatBerry";
            this.rbWheatBerry.Size = new System.Drawing.Size(158, 32);
            this.rbWheatBerry.TabIndex = 2;
            this.rbWheatBerry.TabStop = true;
            this.rbWheatBerry.Text = "Wheat Berry";
            this.rbWheatBerry.UseVisualStyleBackColor = true;
            // 
            // rbStrawBanana
            // 
            this.rbStrawBanana.AutoSize = true;
            this.rbStrawBanana.Location = new System.Drawing.Point(24, 103);
            this.rbStrawBanana.Name = "rbStrawBanana";
            this.rbStrawBanana.Size = new System.Drawing.Size(215, 32);
            this.rbStrawBanana.TabIndex = 1;
            this.rbStrawBanana.TabStop = true;
            this.rbStrawBanana.Text = "Strawberry Banana";
            this.rbStrawBanana.UseVisualStyleBackColor = true;
            // 
            // rbPom
            // 
            this.rbPom.AutoSize = true;
            this.rbPom.Location = new System.Drawing.Point(24, 51);
            this.rbPom.Name = "rbPom";
            this.rbPom.Size = new System.Drawing.Size(154, 32);
            this.rbPom.TabIndex = 0;
            this.rbPom.TabStop = true;
            this.rbPom.Text = "Pomegranate";
            this.rbPom.UseVisualStyleBackColor = true;
            // 
            // lbAdditives
            // 
            this.lbAdditives.AutoSize = true;
            this.lbAdditives.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbAdditives.Location = new System.Drawing.Point(624, 127);
            this.lbAdditives.Name = "lbAdditives";
            this.lbAdditives.Size = new System.Drawing.Size(139, 66);
            this.lbAdditives.TabIndex = 4;
            this.lbAdditives.Text = " Additives\r\n($2.50 ea.)";
            // 
            // cbVitaPack
            // 
            this.cbVitaPack.AutoSize = true;
            this.cbVitaPack.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVitaPack.Location = new System.Drawing.Point(630, 227);
            this.cbVitaPack.Name = "cbVitaPack";
            this.cbVitaPack.Size = new System.Drawing.Size(122, 32);
            this.cbVitaPack.TabIndex = 5;
            this.cbVitaPack.Text = "Vita Pack";
            this.cbVitaPack.UseVisualStyleBackColor = true;
            // 
            // cbEngBoost
            // 
            this.cbEngBoost.AutoSize = true;
            this.cbEngBoost.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.cbEngBoost.Location = new System.Drawing.Point(630, 289);
            this.cbEngBoost.Name = "cbEngBoost";
            this.cbEngBoost.Size = new System.Drawing.Size(161, 32);
            this.cbEngBoost.TabIndex = 6;
            this.cbEngBoost.Text = "Energy Boost";
            this.cbEngBoost.UseVisualStyleBackColor = true;
            // 
            // cbCDRem
            // 
            this.cbCDRem.AutoSize = true;
            this.cbCDRem.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.cbCDRem.Location = new System.Drawing.Point(630, 359);
            this.cbCDRem.Name = "cbCDRem";
            this.cbCDRem.Size = new System.Drawing.Size(210, 32);
            this.cbCDRem.TabIndex = 7;
            this.cbCDRem.Text = "Cool Down Remedy";
            this.cbCDRem.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btAdd.Location = new System.Drawing.Point(914, 97);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 57);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add to Order";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCheckout
            // 
            this.btCheckout.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btCheckout.Location = new System.Drawing.Point(914, 202);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(154, 57);
            this.btCheckout.TabIndex = 9;
            this.btCheckout.Text = "Checkout";
            this.btCheckout.UseVisualStyleBackColor = true;
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // btViewOrderSum
            // 
            this.btViewOrderSum.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btViewOrderSum.Location = new System.Drawing.Point(914, 290);
            this.btViewOrderSum.Name = "btViewOrderSum";
            this.btViewOrderSum.Size = new System.Drawing.Size(154, 79);
            this.btViewOrderSum.TabIndex = 10;
            this.btViewOrderSum.Text = "View Orders Summary";
            this.btViewOrderSum.UseVisualStyleBackColor = true;
            this.btViewOrderSum.Click += new System.EventHandler(this.btViewOrderSum_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(914, 524);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(154, 57);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btClear.Location = new System.Drawing.Point(914, 418);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(154, 57);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // rbJuice
            // 
            this.rbJuice.AutoSize = true;
            this.rbJuice.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.rbJuice.Location = new System.Drawing.Point(26, 17);
            this.rbJuice.Name = "rbJuice";
            this.rbJuice.Size = new System.Drawing.Size(87, 32);
            this.rbJuice.TabIndex = 13;
            this.rbJuice.TabStop = true;
            this.rbJuice.Text = "Juice";
            this.rbJuice.UseVisualStyleBackColor = true;
            this.rbJuice.CheckedChanged += new System.EventHandler(this.rbJuice_CheckedChanged);
            // 
            // rbSmoothie
            // 
            this.rbSmoothie.AutoSize = true;
            this.rbSmoothie.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmoothie.Location = new System.Drawing.Point(269, 17);
            this.rbSmoothie.Name = "rbSmoothie";
            this.rbSmoothie.Size = new System.Drawing.Size(125, 32);
            this.rbSmoothie.TabIndex = 14;
            this.rbSmoothie.TabStop = true;
            this.rbSmoothie.Text = "Smoothie";
            this.rbSmoothie.UseVisualStyleBackColor = true;
            // 
            // gbDrinkChoice
            // 
            this.gbDrinkChoice.Controls.Add(this.rbJuice);
            this.gbDrinkChoice.Controls.Add(this.rbSmoothie);
            this.gbDrinkChoice.Location = new System.Drawing.Point(12, 112);
            this.gbDrinkChoice.Name = "gbDrinkChoice";
            this.gbDrinkChoice.Size = new System.Drawing.Size(507, 61);
            this.gbDrinkChoice.TabIndex = 15;
            this.gbDrinkChoice.TabStop = false;
            // 
            // JuiceBarMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 675);
            this.Controls.Add(this.gbDrinkChoice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btViewOrderSum);
            this.Controls.Add(this.btCheckout);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbCDRem);
            this.Controls.Add(this.cbEngBoost);
            this.Controls.Add(this.cbVitaPack);
            this.Controls.Add(this.lbAdditives);
            this.Controls.Add(this.gbSmoothies);
            this.Controls.Add(this.gbJuice);
            this.Controls.Add(this.lblJuiceBarMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JuiceBarMain";
            this.Text = "Pellissippi State Fitness Center Juice Bar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbJuice.ResumeLayout(false);
            this.gbJuice.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbSmoothies.ResumeLayout(false);
            this.gbSmoothies.PerformLayout();
            this.gbDrinkChoice.ResumeLayout(false);
            this.gbDrinkChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJuiceBarMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbJuice;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbTwentyOunce;
        private System.Windows.Forms.RadioButton rbSixteenOunce;
        private System.Windows.Forms.RadioButton rbTwelveOunce;
        private System.Windows.Forms.GroupBox gbSmoothies;
        private System.Windows.Forms.RadioButton rbWheatBerry;
        private System.Windows.Forms.RadioButton rbStrawBanana;
        private System.Windows.Forms.RadioButton rbPom;
        private System.Windows.Forms.Label lbAdditives;
        private System.Windows.Forms.CheckBox cbVitaPack;
        private System.Windows.Forms.CheckBox cbEngBoost;
        private System.Windows.Forms.CheckBox cbCDRem;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.Button btViewOrderSum;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton rbFruit;
        private System.Windows.Forms.RadioButton rbVeggie;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.RadioButton rbJuice;
        private System.Windows.Forms.RadioButton rbSmoothie;
        private System.Windows.Forms.GroupBox gbDrinkChoice;
        private System.Windows.Forms.FontDialog fontDialogMain;
        private System.Windows.Forms.ColorDialog colorDialogMain;
    }
}

