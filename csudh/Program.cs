using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace csudh
{
    public class Program
    {
       static List<IPaddress> listam = new List<IPaddress>(); 
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("csudh.txt");
            
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                listam.Add(new IPaddress(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3.Feladat:A lista tartalma:");
            foreach (var item in listam)
            {
                Console.WriteLine(item.domainname+" "+item.ipaddress);
            }
            Console.WriteLine("A lista címtartalma: "+listam.Count());
            Console.WriteLine();

            foreach (var item in listam)
            {
                string[] words = item.domainname.Split('.');
                string firstWord = "";
                string secondWord = "";
                string thirdWord = "";
                string fourthWord = "";
                string fifthhWord = "";

                if (words.Length >= 3)
                {
                    firstWord = words[0];
                    secondWord = words[1];
                    thirdWord = words[2];
                    fourthWord = "nincs";
                    
                    if (words.Length >= 4)
                    {
                        fourthWord = words[3];
                       
                    }
                    fifthhWord = "nincs";


                }

                Domain(firstWord, secondWord, thirdWord, fourthWord,fifthhWord);


                ;
                

                //string result = item.domainname.Substring(0, item.domainname.IndexOf('.'));

            }

            Console.ReadKey();  
        }

        public static void Domain(string firstWord,string secondWord,string thirdWord,string fourtWord,string fifthWord)
        {
            Console.WriteLine("1.szint:"+firstWord+"\n"+ "2.szint:" + secondWord + "\n" + "3.szint:" + thirdWord + "\n" + "4.szint:" + fourtWord + "\n" + "5.szint:" + fifthWord);
            Console.WriteLine();
            
        }
    }
}
