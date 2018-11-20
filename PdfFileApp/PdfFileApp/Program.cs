using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int excelfileCount = Directory.GetFiles(@"c:\Users\rajvarma\Downloads", "*.xls*", SearchOption.AllDirectories).Length;
            Console.WriteLine("the number of excel sheets:{0}",fileCount);
            int pdffileCount = Directory.GetFiles(@"c:\Users\rajvarma\Downloads", "*.pdf*", SearchOption.AllDirectories).Length;
            Console.WriteLine("the number of pdf files :{0}",filCount);
            Console.ReadKey();
        }
    }
}
