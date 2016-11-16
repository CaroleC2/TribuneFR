using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

namespace WcfWebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ServiceForum : IServiceForum
    {

        private SqlConnection cn;

        public ServiceForum()
        {
            cn = new SqlConnection();

            //La chaine de connection est lue dans le fichier Web.config (modifiable sans recompilation)
            //Pour ce faire, une section ConnectionStrings a été ajoutée dans le fichier Web.config            
            cn.ConnectionString = WebConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            cn.Open();
        }

        #region SUJET

        public Sujet GetSujet(int idsujet)
        {
            Sujet sujet = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETSUJETBYID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlParameter pIdSujet = new SqlParameter("IdSujet", idsujet);
            cmd.Parameters.Add(pIdSujet);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                sujet = new Sujet();
                sujet.IdSujet = Convert.ToInt32(reader.GetValue(0));
                sujet.TitreSujet = Convert.ToString(reader.GetValue(1));
                sujet.TextSujet = Convert.ToString(reader.GetValue(2));

            }
            return sujet;
        }
        // TODO ####################################################################################################
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

        // TODO ####################################################################################################
        public IList<Emp> GetEmpsByDeptno(int deptno)
        {
            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public DataSet FillEmpByDeptno(int deptno)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }

        public int NewEmp(string ename, int sal, int deptno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "NEWEMP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Ename", ename));
            cmd.Parameters.Add(new SqlParameter("Sal", sal));
            cmd.Parameters.Add(new SqlParameter("Deptno", deptno));
            //Cette procédure pourrait retourner la valeur de EMPNO (@IDENTITY)
            cmd.Connection = cn;

            return cmd.ExecuteNonQuery();
        }

        #endregion

        #region RUBRIQUE

        public Emp GetEmp(int empno)
        {
            Emp emp = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPBYID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlParameter pEmpno = new SqlParameter("Empno", empno);
            cmd.Parameters.Add(pEmpno);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                emp = new Emp();
                emp.Empno = Convert.ToInt32(reader.GetValue(0));
                emp.Ename = Convert.ToString(reader.GetValue(1));

            }
            return emp;
        }

        public IList<Emp> GetEmps()
        {

            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public IList<Emp> GetEmpsByDeptno(int deptno)
        {
            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public DataSet FillEmpByDeptno(int deptno)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }

        public int NewEmp(string ename, int sal, int deptno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "NEWEMP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Ename", ename));
            cmd.Parameters.Add(new SqlParameter("Sal", sal));
            cmd.Parameters.Add(new SqlParameter("Deptno", deptno));
            //Cette procédure pourrait retourner la valeur de EMPNO (@IDENTITY)
            cmd.Connection = cn;

            return cmd.ExecuteNonQuery();
        }

        #endregion

        #region REPONSE

        public Emp GetEmp(int empno)
        {
            Emp emp = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPBYID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlParameter pEmpno = new SqlParameter("Empno", empno);
            cmd.Parameters.Add(pEmpno);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                emp = new Emp();
                emp.Empno = Convert.ToInt32(reader.GetValue(0));
                emp.Ename = Convert.ToString(reader.GetValue(1));

            }
            return emp;
        }

        public IList<Emp> GetEmps()
        {

            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public IList<Emp> GetEmpsByDeptno(int deptno)
        {
            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public DataSet FillEmpByDeptno(int deptno)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }

        public int NewEmp(string ename, int sal, int deptno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "NEWEMP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Ename", ename));
            cmd.Parameters.Add(new SqlParameter("Sal", sal));
            cmd.Parameters.Add(new SqlParameter("Deptno", deptno));
            //Cette procédure pourrait retourner la valeur de EMPNO (@IDENTITY)
            cmd.Connection = cn;

            return cmd.ExecuteNonQuery();
        }

        #endregion

        #region UTILISATEUR

        public Emp GetEmp(int empno)
        {
            Emp emp = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPBYID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlParameter pEmpno = new SqlParameter("Empno", empno);
            cmd.Parameters.Add(pEmpno);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                emp = new Emp();
                emp.Empno = Convert.ToInt32(reader.GetValue(0));
                emp.Ename = Convert.ToString(reader.GetValue(1));

            }
            return emp;
        }

        public IList<Emp> GetEmps()
        {

            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public IList<Emp> GetEmpsByDeptno(int deptno)
        {
            List<Emp> liste = new List<Emp>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Emp emp = new Emp(Convert.ToInt32(row["EMPNO"]), row["ENAME"].ToString(), Convert.ToInt32(row["DEPTNO"]));
                liste.Add(emp);
            }
            return liste;
        }


        public DataSet FillEmpByDeptno(int deptno)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GETEMPSBYDEPTNO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pDeptno = new SqlParameter("Deptno", deptno);
            cmd.Parameters.Add(pDeptno);
            cmd.Connection = cn;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);

            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }

        public int NewEmp(string ename, int sal, int deptno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "NEWEMP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Ename", ename));
            cmd.Parameters.Add(new SqlParameter("Sal", sal));
            cmd.Parameters.Add(new SqlParameter("Deptno", deptno));
            //Cette procédure pourrait retourner la valeur de EMPNO (@IDENTITY)
            cmd.Connection = cn;

            return cmd.ExecuteNonQuery();
        }

        #endregion

        
        public void Disconnect()
        {
            cn.Close();
        }

        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
