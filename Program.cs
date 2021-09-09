using System;

namespace cs_con_0909
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("こんにちは");

            string a = "就活キックオフ";

            Console.WriteLine( a );

            string[] b = { "AB", "CD", "EX" };

            for( int i = 0; i < b.Length; i++ )
            {
                Console.Write( b[i] );
            }

            Console.WriteLine();

            foreach ( string value in b )
            {
                Console.Write( value );
            }


            Console.ReadLine();
        }
    }
}
