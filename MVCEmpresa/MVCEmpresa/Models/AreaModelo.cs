using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEmpresa.Models
{
    public class AreaModelo
    {
        DataEmpresaDataContext contexto = new DataEmpresaDataContext();
        public List<area> listaAreas()
        {
            List<area> lista = new List<area>();
            var consulta = contexto.PR_LISTAR_AREA();
            foreach (var area in consulta)
            {
                area a = new area();
                a.are_cod = area.are_cod;
                a.are_des = area.are_des;
                lista.Add(a);
            }
            return lista;
        }
        public area buscarAreas(int codigo)
        {
            area a = new area();
            try
            {
                var consulta = contexto.PR_BUSCAR_AREA(codigo);
                foreach (var area in consulta)
                {
                  
                    a.are_cod = area.are_cod;
                    a.are_des = area.are_des;

                }
            }
            catch (Exception) { throw; }
            return a;
        }

        public string insertarArea(area a)
        {
            string resultado = String.Empty;
            try
            {
                contexto.PR_INSERTAR_AREA(a.are_des);
                resultado = "OK";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public string ActualizarDatos(area a)
        {
            string resultado = String.Empty;
            try
            {
                contexto.PR_ACTUALIZAR_AREA(a.are_cod,a.are_des);

            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }


            return resultado;
        }
        public string EliminarArea(int codigo) {
            string resultado = String.Empty;
            try
            {
                contexto.PR_ELIMINAR_AREA(codigo);
                resultado = "OK";
            }
            catch(Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }
    }
}