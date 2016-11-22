using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Web.Configuration;
using Metier;

namespace WcfWSTribuneREST
{
   
    public class ServiceTribune : IServiceTribune
    {
        // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
        // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
        

            private SqlConnection cn;

            public ServiceTribune()
            {
                cn = new SqlConnection();

                //La chaine de connection est lue dans le fichier Web.config (modifiable sans recompilation)
                //Pour ce faire, une section ConnectionStrings a été ajoutée dans le fichier Web.config            
                cn.ConnectionString = WebConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

                cn.Open();
            }

            #region SUJET

            //public Sujet GetSujet(string idsujet)
            //{
            //    Sujet sujet = null;
            //    int idsujetInt = int.Parse(idsujet);

            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "GETSUJETBYID";
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Connection = cn;
            //    SqlParameter pIdSujet = new SqlParameter("IdSujet", idsujet);
            //    cmd.Parameters.Add(pIdSujet);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        sujet = new Sujet();
            //        sujet.IdSujet        = Convert.ToInt32(reader.GetValue(0));
            //        sujet.IdRub          = Convert.ToInt32(reader.GetValue(1));
            //        sujet.IdUser         = Convert.ToInt32(reader.GetValue(2));
            //        sujet.TitreSujet     = Convert.ToString(reader.GetValue(3));
            //        sujet.TextSujet      = Convert.ToString(reader.GetValue(4));
            //        sujet.DateCreatSujet = Convert.ToDateTime(reader.GetValue(5));

            //}
            //    return sujet;
            //}

            public IList<Sujet> GetSujets()
            {

                List<Sujet> liste = new List<Sujet>();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETSUJETS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Sujet sujet = new Sujet(Convert.ToInt32(row["IDSUJET"]), Convert.ToInt32(row["IDRUB"]), Convert.ToInt32(row["IDUSER"]), row["TITRESUJET"].ToString(), row["TEXTSUJET"].ToString(), Convert.ToDateTime(row["DATECREATSUJET"]));
                    liste.Add(sujet);
                }
                return liste;
            }

            public IList<Sujet> GetSujetsById(string idsujet)
            {
                List<Sujet> liste = new List<Sujet>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "GETSUJETSBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdsujet = new SqlParameter("IdSujet", idsujet);
                cmd.Parameters.Add(pIdsujet);

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Sujet sujet = new Sujet(Convert.ToInt32(row["IDSUJET"]), Convert.ToInt32(row["IDRUB"]), Convert.ToInt32(row["IDUSER"]), row["TITRESUJET"].ToString(), row["TEXTSUJET"].ToString(), Convert.ToDateTime(row["DATECREATSUJET"]));
                    liste.Add(sujet);
                }
                return liste;
            }

            public IList<Sujet> GetSujetsByIdRub(string idrub)
            {
                List<Sujet> liste = new List<Sujet>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "GETSUJETSBYIDRUB";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdrub = new SqlParameter("IdRub", idrub);
                cmd.Parameters.Add(pIdrub);

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Sujet sujet = new Sujet(Convert.ToInt32(row["IDSUJET"]), Convert.ToInt32(row["IDRUB"]), Convert.ToInt32(row["IDUSER"]), row["TITRESUJET"].ToString(), row["TEXTSUJET"].ToString(), Convert.ToDateTime(row["DATECREATSUJET"]));
                    liste.Add(sujet);
                }
                return liste;
            }

            public DataSet FillSujetByIdSujet(int idsujet)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETSUJETSBYIDSUJET";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdsujet = new SqlParameter("IdSujet", idsujet);
                cmd.Parameters.Add(pIdsujet);
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);
                return objDataSet;
            }

            public DataSet FillSujetByIdRub(int idrub)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETSUJETSBYIDRUB";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdrub = new SqlParameter("IdRub", idrub);
                cmd.Parameters.Add(pIdrub);
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);
                return objDataSet;
            }

            public int NewSujet(int idsujet, int iduser, int idrub, string titresujet, string textsujet, DateTime datecreatsujet)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "NEWSUJET";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("IdSujet", idsujet));
                cmd.Parameters.Add(new SqlParameter("IdUser", iduser));
                cmd.Parameters.Add(new SqlParameter("IdRub", idrub));
                cmd.Parameters.Add(new SqlParameter("TitreSujet", titresujet));
                cmd.Parameters.Add(new SqlParameter("TextSujet", textsujet));
                cmd.Parameters.Add(new SqlParameter("DateCreatSujet", datecreatsujet));

                cmd.Connection = cn;

                return cmd.ExecuteNonQuery();
            }

            #endregion

            #region RUBRIQUE

            //public Rubrique GetRubrique(int idrub)
            //{
            //    Rubrique rubrique = null;
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "GETRUBRIQUEBYID";
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Connection = cn;
            //    SqlParameter pIdRub = new SqlParameter("IdRub", idrub);
            //    cmd.Parameters.Add(pIdRub);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        rubrique = new Rubrique();
            //        rubrique.IdRub = Convert.ToInt32(reader.GetValue(0));
            //        rubrique.NomRub = Convert.ToString(reader.GetValue(1));
            //        rubrique.TextRub = Convert.ToString(reader.GetValue(2));

            //    }
            //    return rubrique;
            //}

            public IList<Rubrique> GetRubriques()
            {

                List<Rubrique> liste = new List<Rubrique>();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETRUBRIQUES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Rubrique rubrique = new Rubrique(Convert.ToInt32(row["IDRUB"]), row["NOMRUB"].ToString(), row["TEXTRUB"].ToString());
                    liste.Add(rubrique);
                }
                return liste;
            }

            public IList<Rubrique> GetRubriquesById(string idrub)
            {
                List<Rubrique> liste = new List<Rubrique>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "GETRUBRIQUESBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdrub = new SqlParameter("IdRub", idrub);
                cmd.Parameters.Add(pIdrub);

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Rubrique rubrique = new Rubrique(Convert.ToInt32(row["IDRUB"]), row["NOMRUB"].ToString(), row["TEXTRUB"].ToString());
                    liste.Add(rubrique);
                }
                return liste;
            }

            public DataSet FillRubriqueByIdRub(int idrub)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETRUBRIQUESBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdrub = new SqlParameter("IdRub", idrub);
                cmd.Parameters.Add(pIdrub);
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);
                return objDataSet;
            }

            public int NewRubrique(int idrub, string nomrub, string textrub)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "NEWRUBRIQUE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("IdRub", idrub));
                cmd.Parameters.Add(new SqlParameter("NomRub", nomrub));
                cmd.Parameters.Add(new SqlParameter("TextRub", textrub));


                cmd.Connection = cn;

                return cmd.ExecuteNonQuery();
            }
            #endregion

            #region REPONSE

            //public Reponse GetReponse(int idrep)
            //{
            //    Reponse reponse = null;
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "GETREPONSEBYID";
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Connection = cn;
            //    SqlParameter pIdRep = new SqlParameter("IdRep", idrep);
            //    cmd.Parameters.Add(pIdRep);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        reponse = new Reponse();
            //        reponse.IdRep        = Convert.ToInt32(reader.GetValue(0));
            //        reponse.IdSujet      = Convert.ToInt32(reader.GetValue(1));
            //        reponse.IdUser       = Convert.ToInt32(reader.GetValue(2));
            //        reponse.IdSujet      = Convert.ToInt32(reader.GetValue(3));
            //        reponse.TextRep      = Convert.ToString(reader.GetValue(4));
            //        reponse.DateEnvoiRep = Convert.ToDateTime(reader.GetValue(5));

            //    }
            //    return reponse;
            //}

            public IList<Reponse> GetReponses()
            {

                List<Reponse> liste = new List<Reponse>();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETREPONSES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Reponse reponse = new Reponse(Convert.ToInt32(row["IDREP"]), Convert.ToInt32(row["IDSUJET"]), Convert.ToInt32(row["IDUSER"]), row["TEXTRUB"].ToString(), Convert.ToDateTime(row["DATEENVOIREP"]));
                    liste.Add(reponse);
                }
                return liste;
            }

            public IList<Reponse> GetReponsesById(string idrep)
            {
                List<Reponse> liste = new List<Reponse>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "GETREPONSESBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdRep = new SqlParameter("IdRep", idrep);
                cmd.Parameters.Add(pIdRep);

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Reponse reponse = new Reponse(Convert.ToInt32(row["IDREP"]), Convert.ToInt32(row["IDSUJET"]), Convert.ToInt32(row["IDUSER"]), row["TEXTRUB"].ToString(), Convert.ToDateTime(row["DATEENVOIREP"]));
                    liste.Add(reponse);
                }
                return liste;
            }

            public IList<Reponse> GetReponsesByIdSujet(string idsujet)
            {
                List<Reponse> liste = new List<Reponse>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "GETREPONSESBYIDSUJET";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdsujet = new SqlParameter("IdSujet", idsujet);
                cmd.Parameters.Add(pIdsujet);

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Reponse reponse = new Reponse(Convert.ToInt32(row["IDREP"]), Convert.ToInt32(row["IDSUJET"]), Convert.ToInt32(row["IDUSER"]), row["TEXTRUB"].ToString(), Convert.ToDateTime(row["DATEENVOIREP"]));
                    liste.Add(reponse);
                }
                return liste;
            }


            public DataSet FillReponseById(int idrep)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETREPONSESBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdrep = new SqlParameter("IdRep", idrep);
                cmd.Parameters.Add(pIdrep);
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);
                return objDataSet;
            }

            public DataSet FillReponseByIdSujet(int idsujet)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETREPONSESBYIDSUJET";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIdsujet = new SqlParameter("IdSujet", idsujet);
                cmd.Parameters.Add(pIdsujet);
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);
                return objDataSet;
            }


            public int NewReponse(int idrep, int iduser, int idsujet, DateTime dateenvoirep, string textrep)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "NEWREPONSE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("IdRep", idrep));
                cmd.Parameters.Add(new SqlParameter("IdUser", iduser));
                cmd.Parameters.Add(new SqlParameter("IdSujet", idsujet));
                cmd.Parameters.Add(new SqlParameter("DateEnvoiRep", dateenvoirep));
                cmd.Parameters.Add(new SqlParameter("TextRep", textrep));


                cmd.Connection = cn;

                return cmd.ExecuteNonQuery();
            }

            #endregion

            #region UTILISATEUR

            //public Utilisateur GetUtilisateur(int iduser)
            //{
            //    Utilisateur utilisateur = null;
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "GETUTILISATEURBYID";
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Connection = cn;
            //    SqlParameter pIdUser = new SqlParameter("IdUser", iduser);
            //    cmd.Parameters.Add(pIdUser);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        utilisateur = new Utilisateur();
            //        utilisateur.IdUser = Convert.ToInt32(reader.GetValue(0));
            //        utilisateur.NomUser = Convert.ToString(reader.GetValue(1));
            //        utilisateur.MdpUser = Convert.ToString(reader.GetValue(2));
            //        utilisateur.DroitUser = Convert.ToInt32(reader.GetValue(3));

            //    }
            //    return utilisateur;
            //}

            public IList<Utilisateur> GetUtilisateurs()
            {

                List<Utilisateur> liste = new List<Utilisateur>();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETUTILISATEURS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Utilisateur utilisateur = new Utilisateur(Convert.ToInt32(row["IDUSER"]), row["NOMUSER"].ToString(), row["MDPUSER"].ToString(), Convert.ToInt32(row["DROITUSER"]));
                    liste.Add(utilisateur);
                }
                return liste;
            }


            public IList<Utilisateur> GetUtilisateursById(string iduser)
            {
                List<Utilisateur> liste = new List<Utilisateur>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "GETUTILISATEURSBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIduser = new SqlParameter("IdUser", iduser);
                cmd.Parameters.Add(pIduser);

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);

                foreach (DataRow row in objDataSet.Tables[0].Select())
                {
                    Utilisateur utilisateur = new Utilisateur(Convert.ToInt32(row["IDUSER"]), row["NOMUSER"].ToString(), row["MDPUSER"].ToString(), Convert.ToInt32(row["DROITUSER"]));
                    liste.Add(utilisateur);
                }
                return liste;
            }

            public DataSet FillUtilisateurById(int iduser)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GETUTILISATEURSBYID";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pIduser = new SqlParameter("IdUser", iduser);
                cmd.Parameters.Add(pIduser);
                cmd.Connection = cn;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

                DataSet objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet);
                return objDataSet;
            }

            public int NewUtilisateur(int iduser, string nomuser, string mdpuser, int droituser)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "NEWUTILISATEUR";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("IdUser", iduser));
                cmd.Parameters.Add(new SqlParameter("NomUser", nomuser));
                cmd.Parameters.Add(new SqlParameter("MdpUser", mdpuser));
                cmd.Parameters.Add(new SqlParameter("DroitUser", droituser));

                cmd.Connection = cn;

                return cmd.ExecuteNonQuery();
            }
            #endregion

            public void Disconnect()
            {
                cn.Close();
            }


        //public Salarie GetEmpById(string empno)
        //{
        //    int empnoInt = int.Parse(empno);
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = "Data Source=176.31.114.215; Initial Catalog=user10 ;Persist Security Info = true; User Id=user10;Password=026user10";
        //    cn.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "GetEmpById";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlParameter param = cmd.CreateParameter();
        //    param.ParameterName = "@EMPNO";
        //    param.Value = empnoInt;
        //    cmd.Parameters.Add(param);

        //    cmd.ExecuteNonQuery();

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable datatable = new DataTable();
        //    adapter.Fill(datatable);
        //    Salarie salarie = new Salarie();
        //    foreach (DataRow row in datatable.Rows)
        //    {
        //        salarie.Empno = (int)row["EMPNO"];
        //        salarie.Deptno = (int)row["DEPTNO"];
        //        salarie.Ename = row["ENAME"].ToString();
        //    }
        //    return salarie;
        //}

        ////CREATE procedure GetEmpById(@empno int) as 
        ////select empno, ename, deptno from employe where empno = @empno;



        //public List<Salarie> GetEmpsByDeptno(string deptno)
        //{
        //    int deptnoInt = int.Parse(deptno);
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = "Data Source=176.31.114.215; Initial Catalog=user10 ;Persist Security Info = true; User Id=user10;Password=026user10";
        //    cn.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "GetEmpsByDeptno";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlParameter param = cmd.CreateParameter();
        //    param.ParameterName = "@DEPTNO";
        //    param.Value = deptnoInt;
        //    cmd.Parameters.Add(param);

        //    cmd.ExecuteNonQuery();

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);

        //    List<Salarie> listeSalarie = new List<Salarie>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Salarie salarie = new Salarie();
        //        salarie.Deptno = (int)row["DEPTNO"];
        //        salarie.Ename = row["ENAME"].ToString();
        //        salarie.Empno = (int)row["EMPNO"];
        //        listeSalarie.Add(salarie);
        //    }
        //    return listeSalarie;

        //}

        ////CREATE procedure GetEmpsByDeptno(@DEPTNO INT) AS
        ////SELECT* FROM employe WHERE deptno=@DEPTNO;

        //public List<Salarie> GetEmps()
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = "Data Source=176.31.114.215; Initial Catalog=user10 ;Persist Security Info = true; User Id=user10;Password=026user10";
        //    cn.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "GetEmps";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.ExecuteNonQuery();

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable datatable = new DataTable();
        //    adapter.Fill(datatable);

        //    List<Salarie> listeSalarie = new List<Salarie>();

        //    foreach (DataRow row in datatable.Rows)
        //    {
        //        Salarie salarie = new Salarie();
        //        salarie.Empno = (int)row["EMPNO"];
        //        salarie.Deptno = (int)row["DEPTNO"];
        //        salarie.Ename = row["ENAME"].ToString();
        //        salarie.Sal = double.Parse(row["SAL"].ToString());
        //        listeSalarie.Add(salarie);
        //    }
        //    return listeSalarie;
        //}


    }
    }

