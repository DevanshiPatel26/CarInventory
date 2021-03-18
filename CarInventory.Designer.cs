
namespace CarInventory
{
    partial class FormCarInventory
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
            this.labelMakePrompt = new System.Windows.Forms.Label();
            this.labelModelPrompt = new System.Windows.Forms.Label();
            this.labelYearPrompt = new System.Windows.Forms.Label();
            this.labelPricePrompt = new System.Windows.Forms.Label();
            this.textBoxModelInput = new System.Windows.Forms.TextBox();
            this.textBoxPriceInput = new System.Windows.Forms.TextBox();
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.comboBoxMakeInput = new System.Windows.Forms.ComboBox();
            this.comboBoxYearInput = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listViewCarInputs = new System.Windows.Forms.ListView();
            this.columnHeaderNew = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMake = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderModel = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYear = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelMakePrompt
            // 
            this.labelMakePrompt.Location = new System.Drawing.Point(42, 25);
            this.labelMakePrompt.Name = "labelMakePrompt";
            this.labelMakePrompt.Size = new System.Drawing.Size(59, 25);
            this.labelMakePrompt.TabIndex = 0;
            this.labelMakePrompt.Text = "M&ake:";
            this.labelMakePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelMakePrompt, "Make of the Car");
            // 
            // labelModelPrompt
            // 
            this.labelModelPrompt.Location = new System.Drawing.Point(42, 63);
            this.labelModelPrompt.Name = "labelModelPrompt";
            this.labelModelPrompt.Size = new System.Drawing.Size(67, 25);
            this.labelModelPrompt.TabIndex = 2;
            this.labelModelPrompt.Text = "&Model:";
            this.toolTip.SetToolTip(this.labelModelPrompt, "Model of the Car");
            // 
            // labelYearPrompt
            // 
            this.labelYearPrompt.Location = new System.Drawing.Point(42, 102);
            this.labelYearPrompt.Name = "labelYearPrompt";
            this.labelYearPrompt.Size = new System.Drawing.Size(48, 25);
            this.labelYearPrompt.TabIndex = 4;
            this.labelYearPrompt.Text = "&Year:";
            this.toolTip.SetToolTip(this.labelYearPrompt, "Year of the Car");
            // 
            // labelPricePrompt
            // 
            this.labelPricePrompt.Location = new System.Drawing.Point(42, 142);
            this.labelPricePrompt.Name = "labelPricePrompt";
            this.labelPricePrompt.Size = new System.Drawing.Size(53, 25);
            this.labelPricePrompt.TabIndex = 6;
            this.labelPricePrompt.Text = "&Price:";
            this.toolTip.SetToolTip(this.labelPricePrompt, "Price of the Car");
            // 
            // textBoxModelInput
            // 
            this.textBoxModelInput.Location = new System.Drawing.Point(132, 63);
            this.textBoxModelInput.Name = "textBoxModelInput";
            this.textBoxModelInput.Size = new System.Drawing.Size(182, 31);
            this.textBoxModelInput.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxModelInput, "Enter the Model of the Car");
            // 
            // textBoxPriceInput
            // 
            this.textBoxPriceInput.Location = new System.Drawing.Point(132, 142);
            this.textBoxPriceInput.Name = "textBoxPriceInput";
            this.textBoxPriceInput.Size = new System.Drawing.Size(182, 31);
            this.textBoxPriceInput.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxPriceInput, "Enter the Price of the Car");
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNew.Location = new System.Drawing.Point(42, 179);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(109, 29);
            this.checkBoxNew.TabIndex = 8;
            this.checkBoxNew.Text = "&New:";
            this.toolTip.SetToolTip(this.checkBoxNew, "Select if the Car is New");
            this.checkBoxNew.UseVisualStyleBackColor = true;
            // 
            // comboBoxMakeInput
            // 
            this.comboBoxMakeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMakeInput.FormattingEnabled = true;
            this.comboBoxMakeInput.Items.AddRange(new object[] {
            "Audi",
            "Acura",
            "Aston Martin",
            "Bentley",
            "BMW",
            "Chevrolet",
            "Dacia",
            "Datsun",
            "Ford",
            "Ferrari",
            "Hyundai",
            "Jaguar",
            "Mercedes",
            "Mustang",
            "Volkswagen"});
            this.comboBoxMakeInput.Location = new System.Drawing.Point(132, 25);
            this.comboBoxMakeInput.Name = "comboBoxMakeInput";
            this.comboBoxMakeInput.Size = new System.Drawing.Size(182, 33);
            this.comboBoxMakeInput.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxMakeInput, "Select the Car\'s Maker Name");
            // 
            // comboBoxYearInput
            // 
            this.comboBoxYearInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYearInput.FormattingEnabled = true;
            this.comboBoxYearInput.Items.AddRange(new object[] {
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            ""});
            this.comboBoxYearInput.Location = new System.Drawing.Point(132, 102);
            this.comboBoxYearInput.Name = "comboBoxYearInput";
            this.comboBoxYearInput.Size = new System.Drawing.Size(182, 33);
            this.comboBoxYearInput.TabIndex = 5;
            this.toolTip.SetToolTip(this.comboBoxYearInput, "Select the Car\'s Year");
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(32, 484);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(470, 94);
            this.labelResult.TabIndex = 10;
            this.toolTip.SetToolTip(this.labelResult, "Shows the output message");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(154, 603);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 34);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Press Enter if you want to make Car Entries");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ClickEnterButton);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(272, 603);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 34);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Press Reset for default form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ClickResetButton);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(390, 603);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click Exit to end the program");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // listViewCarInputs
            // 
            this.listViewCarInputs.CheckBoxes = true;
            this.listViewCarInputs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNew,
            this.columnHeaderID,
            this.columnHeaderMake,
            this.columnHeaderModel,
            this.columnHeaderYear,
            this.columnHeaderPrice});
            this.listViewCarInputs.HideSelection = false;
            this.listViewCarInputs.Location = new System.Drawing.Point(32, 232);
            this.listViewCarInputs.MultiSelect = false;
            this.listViewCarInputs.Name = "listViewCarInputs";
            this.listViewCarInputs.Size = new System.Drawing.Size(470, 228);
            this.listViewCarInputs.TabIndex = 9;
            this.toolTip.SetToolTip(this.listViewCarInputs, "It shows all the lists of Car\'s Entries");
            this.listViewCarInputs.UseCompatibleStateImageBehavior = false;
            this.listViewCarInputs.View = System.Windows.Forms.View.Details;
            this.listViewCarInputs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewCarInputs.SelectedIndexChanged += new System.EventHandler(this.CarSelected);
            // 
            // columnHeaderNew
            // 
            this.columnHeaderNew.Text = "New";
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderMake
            // 
            this.columnHeaderMake.Text = "Make";
            this.columnHeaderMake.Width = 100;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 80;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Year";
            this.columnHeaderYear.Width = 70;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 95;
            // 
            // FormCarInventory
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(528, 649);
            this.Controls.Add(this.listViewCarInputs);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxYearInput);
            this.Controls.Add(this.comboBoxMakeInput);
            this.Controls.Add(this.checkBoxNew);
            this.Controls.Add(this.textBoxPriceInput);
            this.Controls.Add(this.textBoxModelInput);
            this.Controls.Add(this.labelPricePrompt);
            this.Controls.Add(this.labelYearPrompt);
            this.Controls.Add(this.labelModelPrompt);
            this.Controls.Add(this.labelMakePrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            this.toolTip.SetToolTip(this, "Car Inventory Form");
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMakePrompt;
        private System.Windows.Forms.Label labelModelPrompt;
        private System.Windows.Forms.Label labelYearPrompt;
        private System.Windows.Forms.Label labelPricePrompt;
        private System.Windows.Forms.TextBox textBoxModelInput;
        private System.Windows.Forms.TextBox textBoxPriceInput;
        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.ComboBox comboBoxMakeInput;
        private System.Windows.Forms.ComboBox comboBoxYearInput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listViewCarInputs;
        private System.Windows.Forms.ColumnHeader columnHeaderNew;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderMake;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

