namespace Evaluation_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            string fileName = @"C:\Users\Charitha.Neelisetty\OneDrive - Entain Group\" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);





                sw.WriteLine("First line is added");
                sw.WriteLine("This is Second line");
                sw.WriteLine("This is Third Line");
                sw.WriteLine("fourth line are added");
                sw.WriteLine("fifth line are added");
                sw.WriteLine("six line are added");
                sw.WriteLine("seven line are added");
                sw.WriteLine("eigth line are added");
                sw.WriteLine("ninth line are added");
                sw.WriteLine("tenth line are added");



                sw.Close();





            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }







            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the old word ");
            string OldText = Console.ReadLine();
            Console.WriteLine("------------------------------->");







            Console.WriteLine("Enter the new word");
            string NewText = Console.ReadLine();
            Console.WriteLine("------------------------------->");







            string text = File.ReadAllText(fileName);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(fileName, text);
            Console.WriteLine("After replacement the data is");
            Console.WriteLine("------------------------------->");
            using (StreamReader sa = File.OpenText(fileName))
            {
                string k = "";
                while ((k = sa.ReadLine()) != null)
                {
                    Console.WriteLine(k);
                }
                sa.Close();
            }










        }
    }
}
