namespace Dungeon_of_No_Name
{
    partial class MainForm
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
            this.downMovementButton = new System.Windows.Forms.Button();
            this.leftMovementButton = new System.Windows.Forms.Button();
            this.upMovementButton = new System.Windows.Forms.Button();
            this.rightMovementButton = new System.Windows.Forms.Button();
            this.abilityButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.restButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.viewTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.exhaustionLabel = new System.Windows.Forms.Label();
            this.viewPort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewPort)).BeginInit();
            this.SuspendLayout();
            // 
            // downMovementButton
            // 
            this.downMovementButton.Location = new System.Drawing.Point(334, 488);
            this.downMovementButton.Name = "downMovementButton";
            this.downMovementButton.Size = new System.Drawing.Size(75, 23);
            this.downMovementButton.TabIndex = 0;
            this.downMovementButton.Text = "South";
            this.downMovementButton.UseVisualStyleBackColor = true;
            this.downMovementButton.Click += new System.EventHandler(this.downMovementButton_Click);
            // 
            // leftMovementButton
            // 
            this.leftMovementButton.Location = new System.Drawing.Point(294, 459);
            this.leftMovementButton.Name = "leftMovementButton";
            this.leftMovementButton.Size = new System.Drawing.Size(75, 23);
            this.leftMovementButton.TabIndex = 1;
            this.leftMovementButton.Text = "West";
            this.leftMovementButton.UseVisualStyleBackColor = true;
            this.leftMovementButton.Click += new System.EventHandler(this.leftMovementButton_Click);
            // 
            // upMovementButton
            // 
            this.upMovementButton.Location = new System.Drawing.Point(334, 430);
            this.upMovementButton.Name = "upMovementButton";
            this.upMovementButton.Size = new System.Drawing.Size(75, 23);
            this.upMovementButton.TabIndex = 2;
            this.upMovementButton.Text = " North";
            this.upMovementButton.UseVisualStyleBackColor = true;
            this.upMovementButton.Click += new System.EventHandler(this.upMovementButton_Click);
            // 
            // rightMovementButton
            // 
            this.rightMovementButton.Location = new System.Drawing.Point(375, 459);
            this.rightMovementButton.Name = "rightMovementButton";
            this.rightMovementButton.Size = new System.Drawing.Size(75, 23);
            this.rightMovementButton.TabIndex = 3;
            this.rightMovementButton.Text = "East";
            this.rightMovementButton.UseVisualStyleBackColor = true;
            this.rightMovementButton.Click += new System.EventHandler(this.rightMovementButton_Click);
            // 
            // abilityButton
            // 
            this.abilityButton.Location = new System.Drawing.Point(415, 430);
            this.abilityButton.Name = "abilityButton";
            this.abilityButton.Size = new System.Drawing.Size(75, 23);
            this.abilityButton.TabIndex = 6;
            this.abilityButton.Text = "Ability";
            this.abilityButton.UseVisualStyleBackColor = true;
            this.abilityButton.Click += new System.EventHandler(this.abilityButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(415, 488);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(75, 23);
            this.inventoryButton.TabIndex = 7;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // restButton
            // 
            this.restButton.Location = new System.Drawing.Point(253, 488);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(75, 23);
            this.restButton.TabIndex = 8;
            this.restButton.Text = "Rest";
            this.restButton.UseVisualStyleBackColor = true;
            this.restButton.Click += new System.EventHandler(this.restButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(253, 430);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 9;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logTextBox.Location = new System.Drawing.Point(522, 419);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(250, 130);
            this.logTextBox.TabIndex = 10;
            this.logTextBox.WordWrap = false;
            // 
            // viewTextBox
            // 
            this.viewTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewTextBox.Location = new System.Drawing.Point(12, 419);
            this.viewTextBox.Multiline = true;
            this.viewTextBox.Name = "viewTextBox";
            this.viewTextBox.ReadOnly = true;
            this.viewTextBox.Size = new System.Drawing.Size(200, 130);
            this.viewTextBox.TabIndex = 11;
            this.viewTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Exhaustion:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthLabel.Location = new System.Drawing.Point(297, 521);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(2, 15);
            this.healthLabel.TabIndex = 14;
            // 
            // exhaustionLabel
            // 
            this.exhaustionLabel.AutoSize = true;
            this.exhaustionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exhaustionLabel.CausesValidation = false;
            this.exhaustionLabel.Location = new System.Drawing.Point(444, 523);
            this.exhaustionLabel.Name = "exhaustionLabel";
            this.exhaustionLabel.Size = new System.Drawing.Size(2, 15);
            this.exhaustionLabel.TabIndex = 15;
            // 
            // viewPort
            // 
            this.viewPort.Location = new System.Drawing.Point(186, 13);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(400, 400);
            this.viewPort.TabIndex = 16;
            this.viewPort.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.exhaustionLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.restButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.abilityButton);
            this.Controls.Add(this.rightMovementButton);
            this.Controls.Add(this.upMovementButton);
            this.Controls.Add(this.leftMovementButton);
            this.Controls.Add(this.downMovementButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "MainForm";
            this.Text = "Dungeon of No Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downMovementButton;
        private System.Windows.Forms.Button leftMovementButton;
        private System.Windows.Forms.Button upMovementButton;
        private System.Windows.Forms.Button rightMovementButton;
        private System.Windows.Forms.Button abilityButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button restButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox viewTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label exhaustionLabel;
        private System.Windows.Forms.PictureBox viewPort;
    }
}

