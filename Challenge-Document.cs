using System;

using System.IO;

namespace DocumentApplication
{
    class Document
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document");

                Console.WriteLine("\nEnter Document title: ");


                string title = Console.ReadLine();
                //reads input from user to title the document

                Console.WriteLine("\nEnter Content of the Document: ");

                string items = Console.ReadLine();
                //reads input for items in the documents

                string fileTitle = title + ".txt";
                // adds .txt to the title for the file name

                string path = Environment.CurrentDirectory + "/" + fileTitle;
                //creates path to add the file to the current directory 


                //write the file

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, items);
                }

                //prints out the message
                Console.WriteLine(fileTitle + " was successfully saved. The document contains " + items.Length + " characters");
            }

            //if an exception occurs
            catch (Exception e)
            { 
                Console.WriteLine(e);

            }
        }
    }
}