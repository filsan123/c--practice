CHAPTER 4: Using Files for Data Storage1.
 Overview of File UsageWhen a program needs to save data for later use, it writes the data into a file.
  File operations always involve three steps:  
   Open: Create a connection between the file and theprogram.  
    Process: Either write to or read from the file. 
      Close: Disconnect the file and the program. 
        2. Types of FilesThere are two main types of files:   Text File: Contains data encoded as text using a scheme like Unicode; its contents can be viewed with a text editor.  
         Binary File: Contains data that has not been converted to text and cannot be viewed with a text editor. This chapter only works with text files.   3. .NET Framework Classes for FilesTo work with file objects, .NET provides two main classes:   StreamWriter: Used for writing data to a text file.   StreamReader: Used for reading data from a text file.  
          4. Writing Data to a FileStart by creating a StreamWriter object.   File Opening Methods:File.CreateText: Creates a text file with a specified name. If the file already exists, its contents are erased (overwritten).   File.AppendText: Used when you do not want to erase the contents of an existing file, as it appends new data.   Writing Methods:WriteLine: Writes an item of data to a file followed by a newline character.   Write: Writes an item to a file without a newline character. 

            Specifying File Location: Prefix the string path with the @ character (e.g., StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");).   5. Reading Data from a FileStart by creating a StreamReader object using File.OpenText.   Reading Methods:ReadLine: Reads a line of characters from the stream and returns it as a string.   Read: Reads the next character or set of characters.   ReadToEnd / File.ReadAllText: Reads all text content from the file at once.   Reading with a Loop (EndOfStream):
StreamReader has a boolean property named EndOfStream that signals whether the end of the file has been reached. You can use it in a loop to read a file line-by-line:   C#while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    listBox1.Items.Add(line);
}
6. OpenFileDialog and SaveFileDialog ControlsThese controls allow applications to display standard Windows dialog boxes for opening and saving files.  
 Unlike visible controls (like buttons or text boxes), they are invisible controls that appear in the component tray.

    ShowDialog(): Displays the dialog box and returns a DialogResult value indicating user choice (e.g., DialogResult.OK or DialogResult.Cancel).  
     Filename: Stores the path and filename of the file selected by the user.  
      InitialDirectory: Specifies the initial directory to display when the dialog opens.  

       7. The Load EventThe Load event occurs when an application's form is loaded into memory. 
       Any code written inside a Load event handler (e.g., Form1_Load) will execute automatically when the form is launched.  
        Chapter Reflection: What I Learned About FilesData Persistence: I learned that applications cannot rely solely on temporary RAM; using external text files is crucial for preserving data across program executions. 

         Choosing the Right Write Method: Understanding the difference between CreateText (which overwrites existing data) and AppendText (which preserves prior data history) prevents accidental data loss.
           
 Structured Line-by-Line Reading: Learning to combine StreamReader with an EndOfStream loop allows files to be processed line-by-line and neatly displayed inside graphical controls like a ListBox. 
