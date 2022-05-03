
namespace WindowsFormsApp1
{
    partial class ParserJsonStartWindow
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxJsonPath = new System.Windows.Forms.TextBox();
            this.labelJsonPath = new System.Windows.Forms.Label();
            this.labelJsonContent = new System.Windows.Forms.Label();
            this.labelNewJsonContent = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonParse = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxJsonRootElements = new System.Windows.Forms.GroupBox();
            this.comboBoxJsonRootElements = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelNewJsonPath = new System.Windows.Forms.Label();
            this.textBoxNewJsonPath = new System.Windows.Forms.TextBox();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.richTextBoxNewJson = new System.Windows.Forms.RichTextBox();
            this.richTextBoxJson = new System.Windows.Forms.RichTextBox();
            this.groupBoxJsonRootElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "json files (*.json)|*.json";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // textBoxJsonPath
            // 
            this.textBoxJsonPath.AcceptsReturn = true;
            this.textBoxJsonPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxJsonPath.BackColor = System.Drawing.Color.White;
            this.textBoxJsonPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJsonPath.Location = new System.Drawing.Point(111, 4);
            this.textBoxJsonPath.Name = "textBoxJsonPath";
            this.textBoxJsonPath.Size = new System.Drawing.Size(290, 26);
            this.textBoxJsonPath.TabIndex = 1;
            this.textBoxJsonPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxJsonPath_KeyDown);
            // 
            // labelJsonPath
            // 
            this.labelJsonPath.AutoSize = true;
            this.labelJsonPath.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelJsonPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJsonPath.Location = new System.Drawing.Point(6, 9);
            this.labelJsonPath.Name = "labelJsonPath";
            this.labelJsonPath.Size = new System.Drawing.Size(83, 20);
            this.labelJsonPath.TabIndex = 2;
            this.labelJsonPath.Text = "Json path:";
            // 
            // labelJsonContent
            // 
            this.labelJsonContent.AutoSize = true;
            this.labelJsonContent.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelJsonContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJsonContent.Location = new System.Drawing.Point(6, 39);
            this.labelJsonContent.Name = "labelJsonContent";
            this.labelJsonContent.Size = new System.Drawing.Size(105, 20);
            this.labelJsonContent.TabIndex = 4;
            this.labelJsonContent.Text = "Json content:";
            // 
            // labelNewJsonContent
            // 
            this.labelNewJsonContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewJsonContent.AutoSize = true;
            this.labelNewJsonContent.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelNewJsonContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewJsonContent.Location = new System.Drawing.Point(591, 39);
            this.labelNewJsonContent.Name = "labelNewJsonContent";
            this.labelNewJsonContent.Size = new System.Drawing.Size(140, 20);
            this.labelNewJsonContent.TabIndex = 6;
            this.labelNewJsonContent.Text = "New Json content:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "json files (*.json)|*.json";
            this.saveFileDialog1.InitialDirectory = "C:\\\\";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // buttonParse
            // 
            this.buttonParse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonParse.AutoSize = true;
            this.buttonParse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonParse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonParse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParse.Location = new System.Drawing.Point(331, 36);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(68, 26);
            this.buttonParse.TabIndex = 8;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = false;
            this.buttonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(748, 36);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 26);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // groupBoxJsonRootElements
            // 
            this.groupBoxJsonRootElements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxJsonRootElements.Controls.Add(this.comboBoxJsonRootElements);
            this.groupBoxJsonRootElements.Cursor = System.Windows.Forms.Cursors.Help;
            this.groupBoxJsonRootElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxJsonRootElements.Location = new System.Drawing.Point(407, 6);
            this.groupBoxJsonRootElements.Name = "groupBoxJsonRootElements";
            this.groupBoxJsonRootElements.Size = new System.Drawing.Size(182, 56);
            this.groupBoxJsonRootElements.TabIndex = 0;
            this.groupBoxJsonRootElements.TabStop = false;
            this.groupBoxJsonRootElements.Text = "Choose root element";
            this.groupBoxJsonRootElements.UseCompatibleTextRendering = true;
            // 
            // comboBoxJsonRootElements
            // 
            this.comboBoxJsonRootElements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxJsonRootElements.BackColor = System.Drawing.Color.White;
            this.comboBoxJsonRootElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxJsonRootElements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJsonRootElements.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxJsonRootElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJsonRootElements.FormattingEnabled = true;
            this.comboBoxJsonRootElements.Location = new System.Drawing.Point(6, 23);
            this.comboBoxJsonRootElements.Name = "comboBoxJsonRootElements";
            this.comboBoxJsonRootElements.Size = new System.Drawing.Size(172, 24);
            this.comboBoxJsonRootElements.TabIndex = 0;
            this.comboBoxJsonRootElements.SelectedIndexChanged += new System.EventHandler(this.ComboBoxJsonRootElements_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClear.AutoSize = true;
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(970, 36);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(68, 26);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // labelNewJsonPath
            // 
            this.labelNewJsonPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewJsonPath.AutoSize = true;
            this.labelNewJsonPath.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelNewJsonPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewJsonPath.Location = new System.Drawing.Point(591, 7);
            this.labelNewJsonPath.Name = "labelNewJsonPath";
            this.labelNewJsonPath.Size = new System.Drawing.Size(118, 20);
            this.labelNewJsonPath.TabIndex = 12;
            this.labelNewJsonPath.Text = "New Json path:";
            // 
            // textBoxNewJsonPath
            // 
            this.textBoxNewJsonPath.AcceptsReturn = true;
            this.textBoxNewJsonPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNewJsonPath.BackColor = System.Drawing.Color.White;
            this.textBoxNewJsonPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewJsonPath.Location = new System.Drawing.Point(748, 4);
            this.textBoxNewJsonPath.Name = "textBoxNewJsonPath";
            this.textBoxNewJsonPath.Size = new System.Drawing.Size(290, 26);
            this.textBoxNewJsonPath.TabIndex = 13;
            this.textBoxNewJsonPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNewJsonPath_KeyDown);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRedo.AutoSize = true;
            this.buttonRedo.BackColor = System.Drawing.Color.Transparent;
            this.buttonRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRedo.Image = global::WindowsFormsApp1.Properties.Resources.icons8_right_36x20;
            this.buttonRedo.Location = new System.Drawing.Point(896, 36);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(68, 26);
            this.buttonRedo.TabIndex = 15;
            this.buttonRedo.UseVisualStyleBackColor = false;
            this.buttonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHelp.AutoSize = true;
            this.buttonHelp.BackColor = System.Drawing.Color.White;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(301, 36);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(26, 26);
            this.buttonHelp.TabIndex = 19;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxSave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Image = global::WindowsFormsApp1.Properties.Resources.icons8_file_folder_24;
            this.pictureBoxSave.Location = new System.Drawing.Point(1012, 5);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxSave.TabIndex = 18;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.PictureBoxSave_Click);
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxOpen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpen.Image = global::WindowsFormsApp1.Properties.Resources.icons8_file_folder_24;
            this.pictureBoxOpen.Location = new System.Drawing.Point(375, 5);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxOpen.TabIndex = 17;
            this.pictureBoxOpen.TabStop = false;
            this.pictureBoxOpen.Click += new System.EventHandler(this.PictureBoxOpen_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUndo.AutoSize = true;
            this.buttonUndo.BackColor = System.Drawing.Color.Transparent;
            this.buttonUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUndo.Image = global::WindowsFormsApp1.Properties.Resources.icons8_left_36x20;
            this.buttonUndo.Location = new System.Drawing.Point(822, 36);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(68, 26);
            this.buttonUndo.TabIndex = 14;
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // richTextBoxNewJson
            // 
            this.richTextBoxNewJson.AcceptsTab = true;
            this.richTextBoxNewJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBoxNewJson.BackColor = System.Drawing.Color.White;
            this.richTextBoxNewJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNewJson.Location = new System.Drawing.Point(595, 68);
            this.richTextBoxNewJson.Name = "richTextBoxNewJson";
            this.richTextBoxNewJson.ReadOnly = true;
            this.richTextBoxNewJson.Size = new System.Drawing.Size(579, 514);
            this.richTextBoxNewJson.TabIndex = 20;
            this.richTextBoxNewJson.Text = "";
            this.richTextBoxNewJson.TextChanged += new System.EventHandler(this.RichTextBoxNewJson_TextChanged);
            // 
            // richTextBoxJson
            // 
            this.richTextBoxJson.AcceptsTab = true;
            this.richTextBoxJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBoxJson.BackColor = System.Drawing.Color.White;
            this.richTextBoxJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxJson.Location = new System.Drawing.Point(10, 68);
            this.richTextBoxJson.Name = "richTextBoxJson";
            this.richTextBoxJson.ReadOnly = true;
            this.richTextBoxJson.Size = new System.Drawing.Size(579, 514);
            this.richTextBoxJson.TabIndex = 21;
            this.richTextBoxJson.Text = "";
            // 
            // ParserJsonStartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 591);
            this.Controls.Add(this.richTextBoxJson);
            this.Controls.Add(this.richTextBoxNewJson);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.buttonParse);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxNewJsonPath);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.labelNewJsonPath);
            this.Controls.Add(this.groupBoxJsonRootElements);
            this.Controls.Add(this.labelNewJsonContent);
            this.Controls.Add(this.labelJsonContent);
            this.Controls.Add(this.labelJsonPath);
            this.Controls.Add(this.textBoxJsonPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(1198, 630);
            this.Name = "ParserJsonStartWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParserJson";
            this.Load += new System.EventHandler(this.ParserJsonStartWindow_Load);
            this.groupBoxJsonRootElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxJsonPath;
        private System.Windows.Forms.Label labelJsonPath;
        private System.Windows.Forms.Label labelJsonContent;
        private System.Windows.Forms.Label labelNewJsonContent;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxJsonRootElements;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxJsonRootElements;
        private System.Windows.Forms.Label labelNewJsonPath;
        private System.Windows.Forms.TextBox textBoxNewJsonPath;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.RichTextBox richTextBoxNewJson;
        private System.Windows.Forms.RichTextBox richTextBoxJson;
    }
}

