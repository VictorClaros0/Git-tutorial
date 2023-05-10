namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            int nro1, nro2;
            Random rd = new Random();
            nro1= rd.Next(0,10000);
            nro2 = rd.Next(0, 10000);
            Console.WriteLine(nro1+ " " + nro2);
            Console.WriteLine(nro1+nro2);
            x= Console.ReadLine();
        }
    }
}