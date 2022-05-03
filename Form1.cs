namespace WindowsFormsApp1
{
    #region using;

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;

    #endregion;    

    /// <summary>
    /// Parser Json app start wondow.
    /// </summary>
    public partial class ParserJsonStartWindow : Form
    {
        #region Fields and Constants;

        protected string fileName;
        protected string newFileName;
        protected string filePath;
        protected string newFilePath;
        protected string json;
        protected string newJson;
        protected string temp;
        protected string tempJson;
        protected string partOfJson;
        protected string[][] Elements = new string[7][]; // An array of arrays to store the data of the .json file.
        protected bool wasSaved;
        protected string helpMessage;

        #endregion;

        #region Private methods

        /// <summary>
        /// Handles a Click event on ButtonAdd.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            newJson += Environment.NewLine + richTextBoxNewJson.Text;
            newJson = newJson.TrimStart('\n');
            MessageBox.Show("Fragment added");
        }

        /// <summary>
        /// Handles a Click event on ButtonParse.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonParse_Click(object sender, EventArgs e)
        {
            Parser();
            richTextBoxJson.Text = json;
            comboBoxJsonRootElements.Enabled = true;            
            comboBoxJsonRootElements.Items.Add("All");
            foreach (string element in Elements[0])
            {
                comboBoxJsonRootElements.Items.Add(element);
            }
            buttonParse.Enabled = false;
        }

        /// <summary>
        /// Handles a Click event on ButtonClean.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonClean_Click(object sender, EventArgs e)
        {
            newJson = "";
        }

        /// <summary>
        /// Hadles a SelectedIndexChanged event on ComboBoxJsonRootElements.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        public void ComboBoxJsonRootElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonClear.Enabled = true;
            buttonUndo.Enabled = false;
            buttonRedo.Enabled = false;
            textBoxNewJsonPath.Enabled = true;
            pictureBoxSave.Enabled = true;
            if (comboBoxJsonRootElements.Items.Count > 0)
            {
                switch (comboBoxJsonRootElements.SelectedItem)
                {
                    case "All":
                        partOfJson = newJson;
                        break;
                    default:
                        {
                            partOfJson = Elements[0][Array.IndexOf(Elements[0], comboBoxJsonRootElements.SelectedItem)] + " : ";
                            foreach (string element in Elements[comboBoxJsonRootElements.SelectedIndex])
                            {
                                partOfJson += Environment.NewLine + "\t" + element;
                            }

                            break;
                        }
                }
                richTextBoxNewJson.Text = partOfJson;
                richTextBoxNewJson.ReadOnly = false;
            }
        }

        /// <summary>
        /// Handles a Click event on ButtonUndo.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            richTextBoxNewJson.Undo();
        }

        /// <summary>
        /// Handles a Click event on ButtonRedo.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonRedo_Click(object sender, EventArgs e)
        {
            richTextBoxNewJson.Redo();
        }

        /// <summary>
        /// Hadles a Click event on PictureBoxOpen.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void PictureBoxOpen_Click(object sender, EventArgs e)
        {
                if (wasSaved == false)
            {
                DialogResult notSaved = MessageBox.Show("Attention! The file you created was not saved. Still continue without saving?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (notSaved == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog1.FileName;
            textBoxJsonPath.Text = fileName;
            json = File.ReadAllText(fileName);
            richTextBoxJson.Text = json;
            MessageBox.Show("File opened");
            newJson = "";
            buttonParse.Enabled = true;
            comboBoxJsonRootElements.SelectedItem = false;
            comboBoxJsonRootElements.Items.Clear();
            comboBoxJsonRootElements.Enabled = false;
            richTextBoxNewJson.Text = "";
            buttonAdd.Enabled = false;
            buttonClear.Enabled = false;
            textBoxNewJsonPath.Enabled = false;
            pictureBoxSave.Enabled = false;
            wasSaved = false;
            return;
        }

        /// <summary>
        /// Hadles a Click event on PictureboxSave.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            newFileName = saveFileDialog1.FileName;
            newJson = richTextBoxNewJson.Text;
            File.WriteAllText(newFileName, newJson);
            MessageBox.Show("File saved");
        }

        /// <summary>
        /// Hadles a Click event on ButtonHelp.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            helpMessage = "If you have suggestions you can contact me: anatolii.butko3@gmail.com" +
                "\nHow to use:" +
                "\n1. Open a valid .json file:" +
                "\n\ta. Press folder icon and check valid file." +
                "\n\tb. Write valid path to .json file in Json Path textbox and press Open button." +
                "\n2. Press Parse button." +
                "\n3. Choose root elemant in combobox" +
                "\n4. You can edit the selected part of the file as you like. Click the Add button to add the text to the destination file. " +
                "You can always view the generated file by selecting the All drop-down menu." +
                "\n5. Save file:" +
                "\n\ta. Press folder icon and write valid path and file name." +
                "\n\tb. Write valid path to .json file in New Json Path testbox and press Save button.";
            DialogResult help = MessageBox.Show(helpMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Hadles a Hadles a KeyDown event on TextBoxJsonPath.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TextBoxJsonPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Open();
            }
        }

        /// <summary>
        /// Hadles a KeyDown event on TextBoxNewJsonPath.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TextBoxNewJsonPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        /// <summary>
        /// Opens a .json file in the specified path, if possible (if path valid). If not, report the error.
        /// </summary>
        /// <param>
        /// Method without parametrs.
        /// </param>
        private void Open()
        {
            if (wasSaved == false)
            {
                DialogResult notSaved = MessageBox.Show("Attention! The file you created was not saved. Still continue without saving?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (notSaved == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (textBoxJsonPath.Text != null & textBoxJsonPath.Text.Length > 0)
            {
                filePath = textBoxJsonPath.Text;
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Invalid file path or name. Try again");
                    textBoxJsonPath.Text = filePath;
                    return;
                }
                else
                {
                    textBoxJsonPath.Text = fileName;
                    json = File.ReadAllText(filePath);
                    richTextBoxJson.Text = json;
                    MessageBox.Show("File opened");
                    buttonParse.Enabled = true;
                    comboBoxJsonRootElements.SelectedItem = false;
                    comboBoxJsonRootElements.Items.Clear();
                    comboBoxJsonRootElements.Enabled = false;
                    richTextBoxNewJson.Text = "";
                    buttonAdd.Enabled = false;
                    buttonClear.Enabled = false;
                    pictureBoxSave.Enabled = false;
                    wasSaved = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid file path or name. Try again");
                textBoxJsonPath.Text = filePath;
                return;
            }
        }

        /// <summary>
        /// Saves the generated .json file in the specified path, if possible (if path valid). 
        /// If a file exists, it will overwrite it, and if not, it will create it.
        /// </summary>
        /// <param>
        /// Method without parametrs.
        /// </param>
        private void Save()
        {
            if (textBoxNewJsonPath.Text != null & textBoxNewJsonPath.Text.Length > 0)
            {
                newFilePath = textBoxNewJsonPath.Text;
                if (!File.Exists(newFilePath))
                {
                    string directory = Path.GetDirectoryName(newFilePath);
                    if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                    File.Create(newFilePath).Close();
                    MessageBox.Show("New .json file created");
                    wasSaved = true;
                    return;
                }
                else MessageBox.Show("Existed .json file overrided");
                File.WriteAllText(newFilePath, newJson);
                wasSaved = true;
                return;
            }
            else
            {
                MessageBox.Show("Invalid file path or name. Try again");
                return;
            }
        }

        /// <summary>
        /// Tracks changes in the RichTexBoxNewJson. Needed to implement Undo and Redo.
        /// </summary>
        /// <param name="sender">
        /// Default parametr
        /// </param>
        /// <param name="e">
        /// Default parametr
        /// </param>
        private void RichTextBoxNewJson_TextChanged(object sender, EventArgs e)
        {
            buttonClear.Enabled = true;
            buttonUndo.Enabled = richTextBoxNewJson.CanUndo;
            buttonRedo.Enabled = richTextBoxNewJson.CanRedo;
            ///if (richTextBoxNewJson.CanRedo) buttonRedo.Enabled = true;
            ///else buttonRedo.Enabled = false;
        }

        #endregion

        #region Public methods              

        /// <summary>
        /// Method that parse .json file to DataJson class object.
        /// </summary>
        public void Parser()
        {
            DataJson data = JsonConvert.DeserializeObject<DataJson>(json);
            json = JsonConvert.SerializeObject(data, Formatting.Indented);
            // Create an array of root elements.
            Elements[0] = new string[]
            { "Interface Settings", "Media Interface Settings", "Port Settings",
                    "Unique ID", "MAC Address", "Component Interconnect ID" };
            // Splitting the dictionary of the root element InterfaceSettings into arrays of keys and values and their subsequent concatenation and writing to the array.
            Elements[1] = new string[data.InterfaceSettings.Count];
            for (int i = 0; i < data.InterfaceSettings.Count; i++) Elements[1][i] = data.InterfaceSettings.Keys.ToArray()[i] + " : " + data.InterfaceSettings.Values.ToArray()[i];
            // Splitting the dictionary of the root element MediaInterfaceSetting into arrays
            // of keys and values and their subsequent concatenation and writing to the array.
            Elements[2] = new string[data.MediaInterfaceSettings.Count];
            for (int b = 0; b < data.MediaInterfaceSettings.Count; b++)
            {
                string temp = "";
                foreach (var nodeitem in data.MediaInterfaceSettings.Values.ToArray()[b])
                {
                    temp += Environment.NewLine + "\t\t " + nodeitem.Key + " : " + nodeitem.Value;
                }
                Elements[2][b] = data.MediaInterfaceSettings.Keys.ToArray()[b] + " : " + temp;
            }
            // Splitting the dictionary of the root element PortSettings into arrays of keys and values and their subsequent concatenation and writing to the array.
            Elements[3] = new string[data.PortSettings.Count];
            for (int j = 0; j < data.PortSettings.Count; j++) Elements[3][j] = data.PortSettings.Keys.ToArray()[j] + " : " + data.PortSettings.Values.ToArray()[j];
            // Splitting the dictionary of the root element UniqueId into arrays of keys and values and their subsequent concatenation and writing to the array.
            Elements[4] = new string[data.UniqueId.Count];
            for (int k = 0; k < data.UniqueId.Count; k++) Elements[4][k] = data.UniqueId.Keys.ToArray()[k] + " : " + data.UniqueId.Values.ToArray()[k];
            // Splitting the dictionary of the root element MacAddress into arrays of keys and values and their subsequent concatenation and writing to the array.
            Elements[5] = new string[data.MacAddress.Count];
            for (int l = 0; l < data.MacAddress.Count; l++) Elements[5][l] = data.MacAddress.Keys.ToArray()[l] + " : " + data.MacAddress.Values.ToArray()[l];
            // Splitting the dictionary of the root element ComponentInterconnectId into arrays of keys and values and their subsequent concatenation and writing to the array.
            Elements[6] = new string[data.ComponentInterconnectId.Count];
            for (int m = 0; m < data.ComponentInterconnectId.Count; m++) Elements[6][m] = data.ComponentInterconnectId.Keys.ToArray()[m] + " : " + data.ComponentInterconnectId.Values.ToArray()[m];
        }

        #endregion

        /// <summary>
        /// Parser Json app StartWindow properties and settings.
        /// </summary>
        public ParserJsonStartWindow()
        {
            InitializeComponent();
            buttonParse.Enabled = false;
            comboBoxJsonRootElements.Enabled = false;
            buttonAdd.Enabled = false;
            buttonUndo.Enabled = false;
            buttonRedo.Enabled = false;
            buttonClear.Enabled = false;
            textBoxNewJsonPath.Enabled = false;
            pictureBoxSave.Enabled = false;
            wasSaved = true;
            buttonUndo.Enabled = false;
            buttonRedo.Enabled = false;
        }

        /// <summary>
        /// App StartWindow parametrs.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr
        /// </param>
        private void ParserJsonStartWindow_Load(object sender, EventArgs e)
        {

        }
    }
}