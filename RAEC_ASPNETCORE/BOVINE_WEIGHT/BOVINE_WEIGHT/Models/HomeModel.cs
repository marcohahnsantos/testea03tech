﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOVINE_WEIGHT.Util;
using System.Data;


namespace BOVINE_WEIGHT.Models
{
    public class HomeModel
    {
        public string LerNomeUsuario()
        {
            try
            {
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable("SELECT * FROM USUARIO;");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0]["Nome"].ToString();
                    }
                }
                return "Nome não encontrado !";
            }
            catch
            {
                return "Nome não encontrado !";
            }
        }

    }
}
