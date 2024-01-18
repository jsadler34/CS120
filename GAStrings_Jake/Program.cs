namespace GAStrings_Jake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfirstname = "Jake";
            string mylastname = "Sadler";
            string myfullname = myfirstname + " " + mylastname;
            Console.WriteLine(myfullname);

            //Reassigning my profs name
            myfirstname = "William";
            mylastname = "Cram";
            myfullname = myfirstname + " " + mylastname + " is my professor";
            Console.WriteLine(myfullname);
        }
    }
} // End of Main
