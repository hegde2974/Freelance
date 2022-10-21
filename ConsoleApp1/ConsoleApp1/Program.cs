using System;

namespace ConsoleApp1
{
    class Program
    {

        public static string timeConversion(string s)
        {

            string[] splited = s.Split(':');
            string retString = "";

            string checkret = s.Remove(s.Length-2);


            if (s.Contains('P'))
            {
                // splited[0]=splited[0].Select(x=>x.Equals("12")?"13":"00");
                // if(s=="12:00:00PM"){
                //     retString="12:00:00";
                if (splited[0] == "12")
                {
                    retString = s;
                }
                else
                {
                    int timeCal = int.Parse(splited[0]) + 12;
                    retString = checkret.Replace(splited[0], timeCal.ToString());
                }

                }
            else
            {
                if (splited[0] == "12")
                {
                    int timeCal = int.Parse(splited[0]) + 12;
                    retString = checkret.Replace(splited[0],"00");
                    //retString = s;
                }
                else
                {
                    retString = checkret;
                }
            }

            return retString;
        }
        
        //string amTime=split.Trim()
    

  public static void Main(string[] args)
        {

            string s = Console.ReadLine();
            var res = timeConversion(s);

            Console.WriteLine(res);
        }
    }
}
