using System.Collections.Immutable;
using System.Reflection;

namespace TextAnalyzerGUI { 
    public partial class frmTextAnalyzer : Form {

        // declare variables
        public Dictionary<string, int> wordDic;
        string text;        
        string[] wordsArray;
        private StreamReader m_fileReader;
        bool checker;



        public frmTextAnalyzer() {
            InitializeComponent();
        } // end form initialization


        /////////////////////////////////////////////////////////////
        ///             Event handlers for the buttons           /// 
        ////////////////////////////////////////////////////////////
      
        private void btnAnalyze_Click(object sender, EventArgs e) {
            // make a new object of the TextAnalyzer class
            // passing the text from the textbox as an argument

            // try catch  to check if the user trys to run the 
            // program with no text in the text box, tells the 
            // user to enter text if no text is entered.
            try {
                text = txtText.Text;
                if (txtText.Text == "") {
                    throw new Exception();
                } // end if 
            } catch (Exception) {
                MessageBox.Show("You must enter some text in the text box.");
                return;
            } // end try catch
            
            // new instance of the TextAnalyzer class
            TextAnalyzer t = new TextAnalyzer(text);           

            // get the sentence, word and unique word counts
            // using the methods in the TextAnalyzer class
            // be sure to use GetSentenceCount() first before 
            // the other methods remove punctuation.
            var sentences = t.GetSentenceCount();
            int wordCount = t.GetWordCount();
            int uniqueWordCount = t.GetUniqueWordCount();
            // add the unique words to the dictionary objects
            wordDic = t.GetUniqueWords();

            // set the results to the label
            lblSentenceCount.Text = sentences.ToString();
            lblWordCount.Text = wordCount.ToString();
            lblUniqueWordCount.Text = uniqueWordCount.ToString();

            // use a loop to add each item from the dictionary to
            // the listview
            foreach (var item in wordDic) {
                // make a new list view item adding the key first
                ListViewItem lvItem = new ListViewItem(item.Key.Substring(0,1).ToUpper() + item.Key.Substring(1));
                // use subitems to add the value
                lvItem.SubItems.Add(item.Value.ToString());
                // add the item to the listview
                ltvDictionary.Items.Add(lvItem);            
            } // end foreach                      
           
            // call the method to write to the file
            WriteToFile();

        } // end analyze button click method

        private void btnClear_Click(object sender, EventArgs e)  {
            // reset the board
            txtText.Clear();
            ltvDictionary.Items.Clear();
            lblSentenceCount.Text = string.Empty;
            lblWordCount.Text = string.Empty;
            lblUniqueWordCount.Text = string.Empty;
            ltvDictionary.Items.Clear();
        }// end clear method

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // end exit method

         private void btnOpenFile_Click(object sender, EventArgs e) {
            MessageBox.Show("Open a text file to be analyzed.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // method to read the contents of a file and read them
            // to the words variable
            string words = OpenFileToAdd();
            
            // set the contents of the file to the text box
            txtText.Text = words;
        } // end event handler

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////
        /// event handler and method for textchanged event handler for listview ///      
        //////////////////////////////////////////////////////////////////////////

        private void txtSearch_TextChanged(object sender, EventArgs e)  {
            // call the filter text method each time
            // the users adds or removes text from 
            // the search text box
            FilterText();
        } // end method

        private void FilterText() {
            // clear the items from the listview
            ltvDictionary.Items.Clear();

            // foreach to iterate the dictionary
            foreach (var item in wordDic) { 
                // if the entered text matches in character in the dictionary item
                // creates a new listview item and adds it to the listview
                if (item.Key.ToLower().Contains(txtSearch.Text.ToLower())) { 
                    ListViewItem lvItem = new ListViewItem(item.Key.Substring(0,1).ToUpper() + item.Key.Substring(1).ToLower());
                    lvItem.SubItems.Add(item.Value.ToString());
                    ltvDictionary.Items.Add(lvItem);                    
                } // end if 


                 //if the listview item count is greater than 0 and
                 //the search text box is not empty, highlight the 
                 //topmost items
                if (ltvDictionary.Items.Count > 0 && txtSearch.Text != "") {
                    ltvDictionary.Items[0].Selected = true;
                } // end if
            } // end foreach
        } // end method  
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////
        ///                  methods to handle the files                    ///
        ///////////////////////////////////////////////////////////////////////
        public string OpenFileToRead() {

            // sets the filename to the file that is in the same location
            // as the executable file
            string fileName = "WordsToIgnore.dat";    
            
            // new filestream to open and read the fileContents
            FileStream inputStream = new FileStream(fileName,FileMode.Open, FileAccess.Read);
            m_fileReader= new StreamReader(inputStream);

            // return the contents to the method call
            return m_fileReader.ReadToEnd();
        } // end method

        public string OpenFileToAdd() {

            // decalre local variables
            DialogResult result;
            string fileName;
            string words = "";

            // open the open file dialog for the user to select a file to open
            using (OpenFileDialog filePicker = new OpenFileDialog()) {
                filePicker.InitialDirectory= Application.StartupPath;
                result = filePicker.ShowDialog(); // show the dialog box
                fileName= filePicker.FileName; // set the file to the fileName variable
            } // end using

            // if the user clicks ok in the file dialog box
             if (result == DialogResult.OK) { 
                if (string.IsNullOrEmpty(fileName)) {
                    MessageBox.Show("Invalid file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { 
                    try { // open the file with read access
                        FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        // set the file to where data is read
                        m_fileReader = new StreamReader(inputStream);
                                                
                    } catch (IOException) {
                        // Notify user if file does not exist
                        MessageBox.Show("Error reading from file.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end try
                }// end if             
            }  else if (result == DialogResult.Cancel) {
                // returning null with allow the program
                // to put nothing in the textbox without 
                // throwing an exception
                return null;
            } // end else if 

            // read the file and save contents to the words variable           
            words = m_fileReader.ReadToEnd();             
            return words;
        } // end method

        public void WriteToFile() {
            MessageBox.Show("Choose or create the csv file to save the analyzed text.", "Choose a file.", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            // declare local variables
            DialogResult result;
            string fileName;

            string words = OpenFileToRead();
             if (words != null) {
                wordsArray = words.Split("\r\n");
            } // end if 

            // open the save file dialog box for the user to save the file
            using (SaveFileDialog filePicker = new SaveFileDialog()) {
                filePicker.InitialDirectory = Application.StartupPath;
                result = filePicker.ShowDialog();
                fileName = filePicker.FileName;
            } // end using

            // if the user clicked ok in the dialig box
            if (result == DialogResult.OK) {
                try {
                    // open filestream with write access to save the file
                    FileStream outputStream = new FileStream(fileName,
                        FileMode.OpenOrCreate, FileAccess.Write);
                    // write each key and value from the word dictionary 
                    // to the file 
                    StreamWriter fileWriter = new StreamWriter(outputStream);
                     foreach (var item in wordDic) {
                        checker = false;
                        for (int i = 0; i < wordsArray.Length; i++) {
                            if (item.Key.ToLower() == wordsArray[i].ToLower())  {
                                checker = true;
                            } // end if 

                        } // end for
                        if (checker == false) {
                            fileWriter.WriteLine($"{item.Key.Substring(0, 1).ToUpper() + item.Key.Substring(1)} , {item.Value}");
                        } // end if 
                    } // end foreach
                     fileWriter.Close();
                       
                } catch (IOException) {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } catch (ArgumentException) {

                } // end try catch
            } else {
                if (string.IsNullOrEmpty(fileName)) {
                    MessageBox.Show("No file was chosen. Data will not be saved to a file. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// end if
            } // end if else          
        } // end method
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////////////
        ///             Tool Strip Menu option event handlers             ///
        //////////////////////////////////////////////////////////////////////
        private void tsmOpenFile_Click(object sender, EventArgs e)  {
            // method to read the contents of a file and read them
            // to the words variable
            string words = OpenFileToAdd();

            // set the contents of the file to the text box
            txtText.Text = words;
        } // end event handler

        private void tsmExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // end event handler

        private void tsmClear_Click(object sender, EventArgs e) {
            // reset the board
            txtText.Clear();
            ltvDictionary.Items.Clear();
            lblSentenceCount.Text = string.Empty;
            lblWordCount.Text = string.Empty;
            lblUniqueWordCount.Text = string.Empty;
        } // end event handler

        private void tsmClassicMode_Click(object sender, EventArgs e) {
            this.BackColor = Color.WhiteSmoke;
            // buttons background color
            btnAnalyze.BackColor = Color.WhiteSmoke;
            btnClear.BackColor = Color.WhiteSmoke;
            btnExit.BackColor = Color.WhiteSmoke;
            btnOpenFile.BackColor = Color.WhiteSmoke;
            // buttons forecolor
            btnAnalyze.ForeColor = Color.Black;
            btnClear.ForeColor = Color.Black;
            btnExit.ForeColor = Color.Black;
            btnOpenFile.ForeColor = Color.Black;
            // labels
            grpResults.ForeColor = Color.Black;
            lblSearch.ForeColor = Color.Black;
            lblWordCount.ForeColor = Color.Black;
            lblWordCount.BackColor= Color.WhiteSmoke;
            lblUniqueWordCount.ForeColor = Color.Black;
            lblUniqueWordCount.BackColor= Color.WhiteSmoke;
            lblWords.ForeColor = Color.Black;
            lblSentenceCount.ForeColor = Color.Black;
            lblSentenceCount.BackColor= Color.WhiteSmoke;
            lblSentences.ForeColor = Color.Black;
            lblUniqueWords.ForeColor = Color.Black;
            // textboxes    
            txtText.BackColor = Color.White;
            txtText.ForeColor = Color.Black;
            txtSearch.BackColor = Color.White;
            txtSearch.ForeColor = Color.Black;
            // listview 
            ltvDictionary.BackColor = Color.White;
            ltvDictionary.ForeColor = Color.Black;
        }

        private void tsmDarkMode_Click(object sender, EventArgs e) {
            this.BackColor = Color.Black;
            // buttons background color
            btnAnalyze.BackColor = Color.Black;
            btnClear.BackColor = Color.Black;
            btnExit.BackColor = Color.Black;
            btnOpenFile.BackColor = Color.Black;
            // buttons forecolor
            btnAnalyze.ForeColor = Color.White;
            btnClear.ForeColor = Color.White;
            btnExit.ForeColor = Color.White;
            btnOpenFile.ForeColor = Color.White;
            // labels
            grpResults.ForeColor = Color.White;
            lblSearch.ForeColor = Color.White;
            lblWordCount.ForeColor = Color.White;
            lblUniqueWordCount.ForeColor = Color.White;
            lblWords.ForeColor = Color.White;
            lblSentenceCount.ForeColor = Color.White;
            lblSentences.ForeColor = Color.White;
            lblUniqueWords.ForeColor = Color.White;
            // textboxes
            txtText.BackColor = Color.Black;
            txtText.ForeColor = Color.White;
            txtSearch.BackColor = Color.Black;
            txtSearch.ForeColor = Color.White;
            // listview 
            ltvDictionary.BackColor = Color.Black;
            ltvDictionary.ForeColor = Color.White;
        }

        private void tsmDarkKnightMode_Click(object sender, EventArgs e) {
            grpButtons.Text = "I am Vengance!";
            grpButtons.ForeColor = Color.White;
            this.BackColor = Color.Black;
            // buttons background color
            btnAnalyze.BackColor = Color.Yellow;
            btnClear.BackColor = Color.Yellow;
            btnExit.BackColor = Color.Yellow;
            btnOpenFile.BackColor = Color.Yellow;
            // buttons forecolor
            btnAnalyze.ForeColor = Color.Black;
            btnClear.ForeColor = Color.Black;
            btnExit.ForeColor = Color.Black;
            btnOpenFile.ForeColor = Color.Black;
            // labels
            grpResults.ForeColor = Color.White;
            lblSearch.ForeColor = Color.White;
            lblWordCount.ForeColor = Color.Black;
            lblWordCount.BackColor = Color.Yellow;
            lblUniqueWordCount.ForeColor = Color.Black;
            lblUniqueWordCount.BackColor = Color.Yellow;
            lblWords.ForeColor = Color.White;
            lblSentenceCount.ForeColor = Color.Black;
            lblSentenceCount.BackColor= Color.Yellow;
            lblSentences.ForeColor = Color.White;
            lblUniqueWords.ForeColor = Color.White;
            // textboxes    
            txtText.BackColor = Color.Yellow;
            txtText.ForeColor = Color.Black;
            txtSearch.BackColor = Color.Yellow;
            txtSearch.ForeColor = Color.Black;
            // listview 
            ltvDictionary.BackColor = Color.Yellow;
            ltvDictionary.ForeColor = Color.Black;            
        }
    } // end class
} // end namespace