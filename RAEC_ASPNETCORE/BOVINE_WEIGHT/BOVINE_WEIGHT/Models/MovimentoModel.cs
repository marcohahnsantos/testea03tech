using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BOVINE_WEIGHT.Util;
using cloudscribe.Web.Pagination;
using Rotativa.AspNetCore;
using System.Data;
namespace BOVINE_WEIGHT.Models
{
    public class MovimentoModel
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int Id_Origem { get; set; }
        public String EMPRESA { get; set; }
        public String FORNECEDOR { get; set; }
        public String QUANTIDADE { get; set; }
        public String DATA { get; set; }
        public String TAG { get; set; }
        public int PESO { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public string Data_Abate { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh.MM}", ApplyFormatInEditMode = true)]
        public string Hora_Abate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public string Data_Ini { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public string Data_Fim { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public MovimentoModel()
        {
        }

        public MovimentoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
       

        public List<MovimentoModel> ListaMovimento(string Limite)
        {
            try
            {
                List<MovimentoModel> lista = new List<MovimentoModel>();
                MovimentoModel item;
                //Utilizado pela View Extrato
                string filtro = "";
                if (int.Parse(Limite) > 10 && int.Parse(Limite) < 20)
                {
                    filtro += $" WHERE A.DELETED='N' AND NOT A.ID in(SELECT TOP {Limite} " +
                           $" A.ID FROM MOVIMENTACAO ABATE AS A " +
                           $" ORDER BY A.DATA_ANATE,A.ID DESC ) ";
                }

                if (int.Parse(Limite) >= 20)
                {
                    filtro += $" WHERE A.DELETED='N' AND " +
                              $" NOT A.ID in(SELECT TOP {int.Parse(Limite)} " +
                              $" A.ID FROM MOVIMENTACAO_ABATE AS A " +
                              $" ORDER BY A.DATA_ABATE,A.ID DESC ) ";
                }
                if (int.Parse(Limite) > 0 && int.Parse(Limite) <= 10)
                {
                    filtro += $" WHERE A.DELETED='N' ";

                }
                string sql = $"SELECT " +
                                $" TOP 10 " +
                                $" A.ID," +
                                $" A.ID_EMPRESA," +
                                $" E.DESCRICAO AS[EMPRESA]," +
                                $" A.ID_FORNECEDOR," +
                                $" P.NOME[PRODUTOR]," +
                                $" A.QUANTIDADE[QUANT.ANIMAIS]," +
                                $" A.DATA_ABATE[DATA ABATE] " +
                                $" FROM ABATE  AS A " +
                                $" INNER JOIN EMPRESAS E ON " +
                                $" A.ID_EMPRESA = E.ID " +
                                $" INNER JOIN FORNECEDORES P ON " +
                                $" A.ID_FORNECEDOR = P.ID " +
                                $" {filtro}" +
                                $" ORDER BY A.ID DESC ";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new MovimentoModel();
                    item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                    item.Id_Origem = int.Parse(dt.Rows[i]["ID_ORIGEM"].ToString());
                    item.TAG = dt.Rows[i]["TAG"].ToString();
                    item.PESO =int.Parse(dt.Rows[i]["PESO"].ToString());
                    item.Data_Abate = dt.Rows[i]["DATA_ABATE"].ToString();
                    lista.Add(item);
                }
                objDAL.FechaComandoSQL();
                return lista;
            }
            catch (Exception error)
            {
                List<MovimentoModel> lista = new List<MovimentoModel>();
                Validacoes.ErroPagina = "SIM";
                return lista;
            }
        }

        public List<MovimentoModel>ListaMovAbate(string Limite, int? Id)
        {
            try
            {
                List<MovimentoModel> lista = new List<MovimentoModel>();
                MovimentoModel item;

                string filtro = "";
                

                if (int.Parse(Limite) >= 5)
                {
                    Limite = Convert.ToString(int.Parse(Limite) - 5);
                    if (Limite != "0")
                    {
                        filtro += $" AND DELETED='N' AND NOT ID in(SELECT TOP {Limite} " +
                               $" ID FROM MOVIMENTACAO_ABATE  " +
                               $" ORDER BY ID DESC ) ";
                    }
                }


                string sql = $"SELECT " +
                                $" TOP 5 " +
                                $" ID," +
                                $" ID_ORIGEM," +
                                $" TAG," +
                                $" PESO," +
                                $" DATA_ABATE[DATA ABATE] " +
                                $" FROM MOVIMENTACAO_ABATE WHERE " +
                                $" ID_ABATE ={Id} " + filtro+
                                $" ORDER BY ID DESC ";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new MovimentoModel();
                    item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                    item.Id_Origem = int.Parse(dt.Rows[i]["ID_ORIGEM"].ToString());
                    item.TAG = dt.Rows[i]["TAG"].ToString();
                    item.PESO = int.Parse(dt.Rows[i]["PESO"].ToString());
                    item.Data_Abate = DateTime.Parse(dt.Rows[i]["DATA ABATE"].ToString()).ToString("dd/MM/yyyy hh:mm:ss");
                    lista.Add(item);
                }
                objDAL.FechaComandoSQL();
                return lista;
            }

            catch (Exception error)
            {
                List<MovimentoModel> lista = new List<MovimentoModel>();
                Validacoes.ErroPagina = "SIM";
                return lista;
            }
        }
        public MovimentoModel TotalRegistrosMovimento(
           int Limite,
           string Tabela,
           string Campo,
           string where,
           string CampoOrdem)
        {

            try
            {
                MovimentoModel item;
               


                string sql = $"SELECT COUNT(T.{Campo}) AS TOTAL " +
                    $"  FROM {Tabela}  AS T " +
                    $" {where}";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                item = new MovimentoModel();
                item.Total = int.Parse(dt.Rows[0]["TOTAL"].ToString());
                return item;
            }
            catch (Exception error)
            {
                MovimentoModel item;
                item = new MovimentoModel();
                Validacoes.ErroPagina = "SIM";
                return item;
            }
        }
        public List<MovimentoModel> ListaMovimentacaoAbate()
        {
            try
            {
                List<MovimentoModel> lista = new List<MovimentoModel>();
                MovimentoModel item;

                //Utilizado pela View Extrato
                string filtro = "";

                string sql = $" SELECT ID AS [CODIGO]," +
                             $"  DATA_CAD AS[DATA]," +
                             $" TAG," +
                             $" PESO " +
                            $" FROM    MOVIMENTACAO_ABATE " +
                            $"  WHERE ID_ABATE={Validacoes.Codigo_Abate} ";
                DAL objDAL = new DAL();



                DataTable dt = objDAL.RetDataTable(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new MovimentoModel();
                    item.Id = int.Parse(dt.Rows[i]["CODIGO"].ToString());
                    item.DATA = DateTime.Parse(dt.Rows[i]["DATA"].ToString()).ToString("dd/MM/yyyy hh:mm:ss");
                    item.TAG = dt.Rows[i]["TAG"].ToString();
                    item.PESO =int.Parse(dt.Rows[i]["PESO"].ToString());
                    lista.Add(item);
                }
                objDAL.FechaComandoSQL();
                return lista;
            }
            catch
            {
                List<MovimentoModel> lista = new List<MovimentoModel>();

                return lista;
            }
        }
        public MovimentoModel CarregaRegistroDadosAbate(int? id)
        {
            try
            {
                MovimentoModel item = new MovimentoModel();
                string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdNomeUsuarioLogado");
                string sql = $"SELECT "+
                             $"E.DESCRICAO AS [EMPRESA],"+
                             $"A.QUANTIDADE AS [QUANTIDADE]," +
                             $"A.DATA_ABATE AS [DATA]," +
                             $"F.NOME [FORNECEDOR]" +
                             $" FROM ABATE A " +
                             $"INNER JOIN EMPRESAS E ON A.ID_EMPRESA=E.ID "+
                             $"INNER JOIN FORNECEDORES F ON  A.ID_FORNECEDOR=F.ID"+
                             $" WHERE A.ID={id}";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);
                item.EMPRESA = dt.Rows[0]["EMPRESA"].ToString();
                item.FORNECEDOR= dt.Rows[0]["FORNECEDOR"].ToString();
                item.QUANTIDADE = dt.Rows[0]["QUANTIDADE"].ToString();
                item.DATA = dt.Rows[0]["DATA"].ToString();
                objDAL.FechaComandoSQL();
                return item;
            }
            catch (Exception erro)
            {
                MovimentoModel item = new MovimentoModel();
                return item;
            }
        }

    }
}
