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
            this.previewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbJuice = new System.Windows.Forms.GroupBox();
            this.gbSizeJuice = new System.Windows.Forms.GroupBox();
            this.rbTwentyJuice = new System.Windows.Forms.RadioButton();
            this.rbSixteenJuice = new System.Windows.Forms.RadioButton();
            this.rbTwelveJuice = new System.Windows.Forms.RadioButton();
            this.rbFruit = new System.Windows.Forms.RadioButton();
            this.rbVeggie = new System.Windows.Forms.RadioButton();
            this.gbSmoothies = new System.Windows.Forms.GroupBox();
            this.gbSizeSmoothies = new System.Windows.Forms.GroupBox();
            this.rbTwentySmooth = new System.Windows.Forms.RadioButton();
            this.rbSixteenSmooth = new System.Windows.Forms.RadioButton();
            this.rbTwelveSmooth = new System.Windows.Forms.RadioButton();
            this.rbWheatBerry = new System.Windows.Forms.RadioButton();
            this.rbStrawBanana = new System.Windows.Forms.RadioButton();
            this.rbPom = new System.Windows.Forms.RadioButton();
            this.lbAdditives = new System.Windows.Forms.Label();
            this.cbVitaPack = new System.Windows.Forms.CheckBox();
            this.cbEngBoost = new System.Windows.Forms.CheckBox();
            this.cbCDRem = new System.Windows.Forms.CheckBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCheckout = new System.Windows.Forms.Button();
            this.btPreview = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbJuice.SuspendLayout();
            this.gbSizeJuice.SuspendLayout();
            this.gbSmoothies.SuspendLayout();
            this.gbSizeSmoothies.SuspendLayout();
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
            this.previewOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // previewOrderToolStripMenuItem
            // 
            this.previewOrderToolStripMenuItem.Name = "previewOrderToolStripMenuItem";
            this.previewOrderToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.previewOrderToolStripMenuItem.Text = "Preview Order";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
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
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.addToOrderToolStripMenuItem.Text = "Add to Order";
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.colorToolStripMenuItem.Text = "Color";
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
            this.gbJuice.Controls.Add(this.gbSizeJuice);
            this.gbJuice.Controls.Add(this.rbFruit);
            this.gbJuice.Controls.Add(this.rbVeggie);
            this.gbJuice.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJuice.Location = new System.Drawing.Point(24, 129);
            this.gbJuice.Name = "gbJuice";
            this.gbJuice.Size = new System.Drawing.Size(214, 405);
            this.gbJuice.TabIndex = 2;
            this.gbJuice.TabStop = false;
            this.gbJuice.Text = "Juice";
            // 
            // gbSizeJuice
            // 
            this.gbSizeJuice.Controls.Add(this.rbTwentyJuice);
            this.gbSizeJuice.Controls.Add(this.rbSixteenJuice);
            this.gbSizeJuice.Controls.Add(this.rbTwelveJuice);
            this.gbSizeJuice.Location = new System.Drawing.Point(0, 182);
            this.gbSizeJuice.Name = "gbSizeJuice";
            this.gbSizeJuice.Size = new System.Drawing.Size(214, 220);
            this.gbSizeJuice.TabIndex = 2;
            this.gbSizeJuice.TabStop = false;
            this.gbSizeJuice.Text = "Size";
            // 
            // rbTwentyJuice
            // 
            this.rbTwentyJuice.AutoSize = true;
            this.rbTwentyJuice.Location = new System.Drawing.Point(26, 168);
            this.rbTwentyJuice.Name = "rbTwentyJuice";
            this.rbTwentyJuice.Size = new System.Drawing.Size(179, 32);
            this.rbTwentyJuice.TabIndex = 2;
            this.rbTwentyJuice.TabStop = true;
            this.rbTwentyJuice.Text = "20 oz.  -  $4.00";
            this.rbTwentyJuice.UseVisualStyleBackColor = true;
            // 
            // rbSixteenJuice
            // 
            this.rbSixteenJuice.AutoSize = true;
            this.rbSixteenJuice.Location = new System.Drawing.Point(26, 109);
            this.rbSixteenJuice.Name = "rbSixteenJuice";
            this.rbSixteenJuice.Size = new System.Drawing.Size(176, 32);
            this.rbSixteenJuice.TabIndex = 1;
            this.rbSixteenJuice.TabStop = true;
            this.rbSixteenJuice.Text = "16 oz.  -  $3.50";
            this.rbSixteenJuice.UseVisualStyleBackColor = true;
            // 
            // rbTwelveJuice
            // 
            this.rbTwelveJuice.AutoSize = true;
            this.rbTwelveJuice.Location = new System.Drawing.Point(26, 53);
            this.rbTwelveJuice.Name = "rbTwelveJuice";
            this.rbTwelveJuice.Size = new System.Drawing.Size(176, 32);
            this.rbTwelveJuice.TabIndex = 0;
            this.rbTwelveJuice.TabStop = true;
            this.rbTwelveJuice.Text = "12 oz.  -  $3.00";
            this.rbTwelveJuice.UseVisualStyleBackColor = true;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(26, 103);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(83, 32);
            this.rbFruit.TabIndex = 1;
            this.rbFruit.Text = "Fruit";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // rbVeggie
            // 
            this.rbVeggie.AutoSize = true;
            this.rbVeggie.Checked = true;
            this.rbVeggie.Location = new System.Drawing.Point(26, 51);
            this.rbVeggie.Name = "rbVeggie";
            this.rbVeggie.Size = new System.Drawing.Size(100, 32);
            this.rbVeggie.TabIndex = 0;
            this.rbVeggie.TabStop = true;
            this.rbVeggie.Text = "Veggie";
            this.rbVeggie.UseVisualStyleBackColor = true;
            // 
            // gbSmoothies
            // 
            this.gbSmoothies.Controls.Add(this.gbSizeSmoothies);
            this.gbSmoothies.Controls.Add(this.rbWheatBerry);
            this.gbSmoothies.Controls.Add(this.rbStrawBanana);
            this.gbSmoothies.Controls.Add(this.rbPom);
            this.gbSmoothies.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSmoothies.Location = new System.Drawing.Point(857, 126);
            this.gbSmoothies.Name = "gbSmoothies";
            this.gbSmoothies.Size = new System.Drawing.Size(256, 405);
            this.gbSmoothies.TabIndex = 3;
            this.gbSmoothies.TabStop = false;
            this.gbSmoothies.Text = "Smoothies";
            // 
            // gbSizeSmoothies
            // 
            this.gbSizeSmoothies.Controls.Add(this.rbTwentySmooth);
            this.gbSizeSmoothies.Controls.Add(this.rbSixteenSmooth);
            this.gbSizeSmoothies.Controls.Add(this.rbTwelveSmooth);
            this.gbSizeSmoothies.Location = new System.Drawing.Point(0, 189);
            this.gbSizeSmoothies.Name = "gbSizeSmoothies";
            this.gbSizeSmoothies.Size = new System.Drawing.Size(256, 213);
            this.gbSizeSmoothies.TabIndex = 3;
            this.gbSizeSmoothies.TabStop = false;
            this.gbSizeSmoothies.Text = "Size";
            // 
            // rbTwentySmooth
            // 
            this.rbTwentySmooth.AutoSize = true;
            this.rbTwentySmooth.Location = new System.Drawing.Point(24, 161);
            this.rbTwentySmooth.Name = "rbTwentySmooth";
            this.rbTwentySmooth.Size = new System.Drawing.Size(179, 32);
            this.rbTwentySmooth.TabIndex = 2;
            this.rbTwentySmooth.TabStop = true;
            this.rbTwentySmooth.Text = "20 oz.  -  $4.00";
            this.rbTwentySmooth.UseVisualStyleBackColor = true;
            // 
            // rbSixteenSmooth
            // 
            this.rbSixteenSmooth.AutoSize = true;
            this.rbSixteenSmooth.Location = new System.Drawing.Point(24, 102);
            this.rbSixteenSmooth.Name = "rbSixteenSmooth";
            this.rbSixteenSmooth.Size = new System.Drawing.Size(176, 32);
            this.rbSixteenSmooth.TabIndex = 1;
            this.rbSixteenSmooth.TabStop = true;
            this.rbSixteenSmooth.Text = "16 oz.  -  $3.50";
            this.rbSixteenSmooth.UseVisualStyleBackColor = true;
            // 
            // rbTwelveSmooth
            // 
            this.rbTwelveSmooth.AutoSize = true;
            this.rbTwelveSmooth.Location = new System.Drawing.Point(24, 46);
            this.rbTwelveSmooth.Name = "rbTwelveSmooth";
            this.rbTwelveSmooth.Size = new System.Drawing.Size(176, 32);
            this.rbTwelveSmooth.TabIndex = 0;
            this.rbTwelveSmooth.TabStop = true;
            this.rbTwelveSmooth.Text = "12 oz.  -  $3.00";
            this.rbTwelveSmooth.UseVisualStyleBackColor = true;
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
            this.lbAdditives.Location = new System.Drawing.Point(490, 129);
            this.lbAdditives.Name = "lbAdditives";
            this.lbAdditives.Size = new System.Drawing.Size(139, 66);
            this.lbAdditives.TabIndex = 4;
            this.lbAdditives.Text = " Additives\r\n($2.50 ea.)";
            // 
            // cbVitaPack
            // 
            this.cbVitaPack.AutoSize = true;
            this.cbVitaPack.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVitaPack.Location = new System.Drawing.Point(478, 229);
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
            this.cbEngBoost.Location = new System.Drawing.Point(478, 291);
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
            this.cbCDRem.Location = new System.Drawing.Point(478, 361);
            this.cbCDRem.Name = "cbCDRem";
            this.cbCDRem.Size = new System.Drawing.Size(210, 32);
            this.cbCDRem.TabIndex = 7;
            this.cbCDRem.Text = "Cool Down Remedy";
            this.cbCDRem.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btAdd.Location = new System.Drawing.Point(289, 471);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 57);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add to Order";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btCheckout
            // 
            this.btCheckout.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btCheckout.Location = new System.Drawing.Point(485, 471);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(154, 57);
            this.btCheckout.TabIndex = 9;
            this.btCheckout.Text = "Checkout";
            this.btCheckout.UseVisualStyleBackColor = true;
            // 
            // btPreview
            // 
            this.btPreview.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btPreview.Location = new System.Drawing.Point(678, 471);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(154, 57);
            this.btPreview.TabIndex = 10;
            this.btPreview.Text = "Preview Order";
            this.btPreview.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(485, 567);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(154, 57);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // JuiceBarMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 636);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPreview);
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
            this.gbSizeJuice.ResumeLayout(false);
            this.gbSizeJuice.PerformLayout();
            this.gbSmoothies.ResumeLayout(false);
            this.gbSmoothies.PerformLayout();
            this.gbSizeSmoothies.ResumeLayout(false);
            this.gbSizeSmoothies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJuiceBarMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbJuice;
        private System.Windows.Forms.GroupBox gbSizeJuice;
        private System.Windows.Forms.RadioButton rbTwentyJuice;
        private System.Windows.Forms.RadioButton rbSixteenJuice;
        private System.Windows.Forms.RadioButton rbTwelveJuice;
        private System.Windows.Forms.RadioButton rbFruit;
        private System.Windows.Forms.RadioButton rbVeggie;
        private System.Windows.Forms.GroupBox gbSmoothies;
        private System.Windows.Forms.RadioButton rbWheatBerry;
        private System.Windows.Forms.RadioButton rbStrawBanana;
        private System.Windows.Forms.RadioButton rbPom;
        private System.Windows.Forms.GroupBox gbSizeSmoothies;
        private System.Windows.Forms.RadioButton rbTwentySmooth;
        private System.Windows.Forms.RadioButton rbSixteenSmooth;
        private System.Windows.Forms.RadioButton rbTwelveSmooth;
        private System.Windows.Forms.Label lbAdditives;
        private System.Windows.Forms.CheckBox cbVitaPack;
        private System.Windows.Forms.CheckBox cbEngBoost;
        private System.Windows.Forms.CheckBox cbCDRem;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btExit;
    }
}

