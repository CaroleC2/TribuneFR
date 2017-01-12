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
        public void TestRubriques()
        {
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

            rub1.NomRub = "Developpement";
            rub2.NomRub = "Developpement Web";
            rub3.NomRub = "Questions Diverses";
            rub4.NomRub = "Stage En Entreprise";
            rub5.NomRub = "Espace Detente";
            rub6.NomRub = "Adresses Utiles";
            
            rubriques.Add(rub1);
            rubriques.Add(rub2);
            rubriques.Add(rub3);
            rubriques.Add(rub4);
            rubriques.Add(rub5);
            rubriques.Add(rub6);
            
            //Agir
            List<Rubrique> resultat = BLLOutils.BLL.ListAllRubriques();

             // Auditer

             CollectionAssert.AreEqual(rubriques, resultat);
 
        }
    }
}
