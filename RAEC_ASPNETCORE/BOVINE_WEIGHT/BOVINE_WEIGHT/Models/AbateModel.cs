using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BOVINE_WEIGHT.Util;
using cloudscribe.Web.Pagination;
using System.Data;
namespace BOVINE_WEIGHT.Models
{
    public class AbateModel
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int id_Empresa { get; set; }
        public String Nome_Empresa { get; set; }
        public int id_Produtor { get; set; }
        public String Nome_Produtor { get; set; }
        public int Quantidade { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public string Data_Abate { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh.MM}", ApplyFormatInEditMode = true)]
        public string Hora_Abate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public string Data_Ini { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public string Data_Fim { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public AbateModel()
        {
        }

        public AbateModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public List<AbateModel> ListaEmpresas()
        {
            try
            {
                List<AbateModel> lista = new List<AbateModel>();
                AbateModel item;
                string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdNomeUsuarioLogado");
                string sql = $"SELECT " +
                                $"ID," +
                                $"DESCRICAO " +
                                $" FROM EMPRESAS " +
                                $"WHERE DELETED='N' ";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                item = new AbateModel();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new AbateModel();
                    item.id_Empresa = int.Parse(dt.Rows[i]["ID"].ToString());
                    item.Nome_Empresa = dt.Rows[i]["DESCRICAO"].ToString();
                    lista.Add(item);
                }
                objDAL.FechaComandoSQL();
                return lista;
            }
            catch
            {
                List<AbateModel> lista = new List<AbateModel>();
                return lista;
            }
        }
        public List<AbateModel> ListaProdutor()
        {
            try
            {
                List<AbateModel> lista = new List<AbateModel>();
                AbateModel item;
                string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdNomeUsuarioLogado");
                string sql = $"SELECT " +
                                $"ID," +
                                $"NOME " +
                                $" FROM FORNECEDORES " +
                                $"WHERE DELETED='N' ORDER BY NOME ";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                item = new AbateModel();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new AbateModel();
                    item.id_Produtor = int.Parse(dt.Rows[i]["ID"].ToString());
                    item.Nome_Produtor = dt.Rows[i]["NOME"].ToString();
                    lista.Add(item);
                }
                objDAL.FechaComandoSQL();
                return lista;
            }
            catch
            {
                List<AbateModel> lista = new List<AbateModel>();
                return lista;
            }
        }


        public List<AbateModel> ListaAbate(string Limite,
           DateTime DataIni,
           DateTime DataFim)
        {
            try
            {
                List<AbateModel> lista = new List<AbateModel>();
                AbateModel item;
                //Utilizado pela View Extrato
                string filtro = "";
                string filtro1 = "";
                string filtroData = "";
                if ((DataIni != null && DataFim != null))
                {
                    //  filtro += $" AND T.DATA BETWEEN '{DataIni.ToString("yyyy/MM/dd")}' AND '{DataFim.ToString("yyyy/MM/dd")}' ";

                    filtroData += $"  WHERE A.DATA_ABATE BETWEEN '{DataIni.ToString("dd/MM/yyyy")}' AND '{DataFim.ToString("dd/MM/yyyy")}' ";
             
                }


                if (int.Parse(Limite) >=5)
                { 
                    Limite =Convert.ToString(int.Parse(Limite) - 5);
                    filtro += $" AND A.DELETED='N' AND NOT A.ID in(SELECT TOP {Limite} " +
                           $" ID FROM ABATE AS A " +
                           $" ORDER BY A.ID DESC ) ";
                }

                
                string sql = $"SELECT "+
                                $" TOP 5 "+
                                $" A.ID,"+
                                $" A.ID_EMPRESA,"+
                                $" E.DESCRICAO AS[EMPRESA],"+
                                $" A.ID_FORNECEDOR,"+
	                            $" P.NOME[PRODUTOR],"+
	                            $" A.QUANTIDADE[QUANT.ANIMAIS],"+
	                            $" A.DATA_ABATE[DATA ABATE] "+
                                $" FROM ABATE  AS A "+
                                $" INNER JOIN EMPRESAS E ON "+
                                $" A.ID_EMPRESA = E.ID "+
                                $" INNER JOIN FORNECEDORES P ON "+
                                $" A.ID_FORNECEDOR = P.ID "+
                                $" {filtroData}{filtro}"+
                                $" ORDER BY A.ID DESC ";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new AbateModel();
                    item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                    item.id_Empresa = int.Parse(dt.Rows[i]["ID_EMPRESA"].ToString());
                    item.Nome_Empresa = dt.Rows[i]["EMPRESA"].ToString();
                    item.id_Produtor = int.Parse(dt.Rows[i]["ID_FORNECEDOR"].ToString());
                    item.Nome_Produtor= dt.Rows[i]["PRODUTOR"].ToString();
                    item.Quantidade= int.Parse(dt.Rows[i]["QUANT.ANIMAIS"].ToString());
                    item.Data_Abate = DateTime.Parse(dt.Rows[i]["DATA ABATE"].ToString()).ToString("dd/MM/yyyy");
                    lista.Add(item);
                }
                objDAL.FechaComandoSQL();
                return lista;
            }
            catch (Exception error)
            {
                List<AbateModel> lista = new List<AbateModel>();
                Validacoes.ErroPagina = "SIM";
                return lista;
            }
        }

        public void Insert()
        {
            try
            {
                string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdNomeUsuarioLogado");
                string sql = "";
                if (Quantidade.ToString() == "")
                    Quantidade = 0;
                if (Data_Abate == null)
                    Data_Abate = System.DateTime.Now.ToString();

                Data_Abate += " " + Hora_Abate.ToString();

                if (Id == 0)
                {
                    sql = $"INSERT INTO ABATE " +
                         $"(ID_EMPRESA,ID_FORNECEDOR,QUANTIDADE,DATA_ABATE,HORA_ABATE) " +
                         $"VALUES ('{id_Empresa.ToString().ToUpper()}'," +
                         $"'{id_Produtor.ToString().Replace(",", ".")}'" +
                         $",'{Quantidade.ToString().ToUpper()}'," +
                         $"'{Convert.ToDateTime(Data_Abate).ToString("dd/MM/yyyy hh:mm")}'," +
                         $" '{Hora_Abate.ToString()}')";
                }
                else
                {
                    sql = $"UPDATE ABATE SET " +
                         $" ID_EMPRESA='{id_Empresa}'," +
                         $" ID_FORNECEDOR='{id_Produtor.ToString().Replace(",", ".")}'," +
                         $" QUANTIDADE='{Quantidade.ToString().Replace(",", ".")}'," +
                         $" DATA_ABATE='{Convert.ToDateTime(Data_Abate).ToString("dd/MM/yyyy hh:mm")}', " +
                         $" HORA_ABATE='{Hora_Abate.ToString()}' " +
                         $" WHERE ID='{Id}'";
                }
                DAL objDAL = new DAL();
                objDAL.ExecutarComandoSQL(sql);
                objDAL.FechaComandoSQL();
            }
            catch (Exception error)
            {

            }
        }
        public AbateModel CarregaRegistroAbate(int? id)
        {
            try
            {
                AbateModel item = new AbateModel();
                string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdNomeUsuarioLogado");
                string sql = $"SELECT  A.ID," +
                             $" A.ID_EMPRESA," +
                             $" E.DESCRICAO," +
                             $" ID_FORNECEDOR," +
                             $" F.NOME," +
                             $" QUANTIDADE," +
                             $" DATA_ABATE " +
                             $" FROM ABATE A " +
                             $" INNER JOIN EMPRESAS E ON " +
                             $" E.ID=A.ID_EMPRESA " +
                             $" INNER JOIN FORNECEDORES F ON " +
                             $" F.ID=ID_FORNECEDOR " +
                             $" WHERE A.ID={id}";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);

                item.Id = int.Parse(dt.Rows[0]["ID"].ToString());
                item.id_Empresa = int.Parse(dt.Rows[0]["ID_EMPRESA"].ToString());
                item.Nome_Empresa = dt.Rows[0]["DESCRICAO"].ToString();
                item.Nome_Produtor= dt.Rows[0]["NOME"].ToString();
                item.id_Produtor= int.Parse(dt.Rows[0]["ID_FORNECEDOR"].ToString());
                item.Quantidade = int.Parse(dt.Rows[0]["QUANTIDADE"].ToString());
                item.Data_Abate= dt.Rows[0]["DATA_ABATE"].ToString();
                objDAL.FechaComandoSQL();
                return item;
            }
            catch
            {
                AbateModel item = new AbateModel();
                return item;
            }
        }
        public void ExcluirAbate(int Id)
        {
            try
            {
                new DAL().ExecutarComandoSQL("UPDATE ABATE SET DELETED='S' WHERE ID=" + Id);
                new DAL().FechaComandoSQL();
            }
            catch
            {

            }
        }

    }
}
