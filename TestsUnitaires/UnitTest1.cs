using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TribuneDevMETIER;
using System.Collections.Generic;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //try
            //{

            //Arranger
            List<Rubrique> rubriques = new List<Rubrique>();
            Rubrique rub1 = new Rubrique();
            Rubrique rub2 = new Rubrique();
            Rubrique rub3 = new Rubrique();
            Rubrique rub4 = new Rubrique();
            Rubrique rub5 = new Rubrique();
            Rubrique rub6 = new Rubrique();

            rub1.IdRub = 1;
            rub2.IdRub = 2;
            rub3.IdRub = 3;
            rub4.IdRub = 4;
            rub5.IdRub = 5;
            rub6.IdRub = 6;

            rub1.NomRub = "developpement";
            rub2.NomRub = "developpement web";
            rub3.NomRub = "questions diverses";
            rub4.NomRub = "stage en entreprise";
            rub5.NomRub = "espace detente";
            rub6.NomRub = "adresses utiles";

            rubriques.Add(rub1);
            //Agir
            List<Rubrique> resultat = BLLOutils.BLL.ListAllRubriques();

             // Auditer

             Assert.AreEqual(rubriques, resultat);

               // Assert.Fail("Une exception du type ArgumentException est attendue");


            //}
            //catch (ArgumentException) { }



        }
    }
}
