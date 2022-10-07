using System;
using System.IO;

namespace Evaluation_Q6
{
    class Copy_File

    {



        static void Main()

        {

            // Copy contents from file1 to file2

            File.Copy("sample1.txt", "sample2.txt");





            // Display file2 contents

            Console.WriteLine(File.ReadAllText("sample2.txt"));

            var file = File.ReadAllText(@"C:\Users\Charitha.Neelisetty\source\repos\C Sharp Evaluation\Evaluation_Q6\Evaluation_Q6\bin\Debug\netcoreapp3.1\sample2.txt");

            FileInfo filetodecrypt = new FileInfo(file);

            filetodecrypt.Encrypt(); //Encrypt



            filetodecrypt.Decrypt(); //Decrypt



        }

    }
}