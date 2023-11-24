using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PersonelSystem.DataBase;
using PersonelSystem.DataBase.Models;
using System;

namespace StoredProcedures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HR sistema:
            //Skyrius(turi daug darbuotoju ir daug projektu)
            //Projektas(turi daug skyriu)
            //Darbuotojas(turi daug projektu, viena skyriu)


            //gebeti prideti darbuotoja perkelti i kita skyriu, prideti / nuimti nuo jo projekta




            using var depContext = new DepartContext();

        }
    }

}
