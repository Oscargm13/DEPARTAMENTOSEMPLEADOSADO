using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEPARTAMENTOSEMPLEADOSADO.Models;
using Microsoft.Data.SqlClient;

namespace DEPARTAMENTOSEMPLEADOSADO.Repository
{
    public class RepositoryDepartamentos
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryDepartamentos()
        {
            string sqlConnectionString = Helppers.HelpperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(sqlConnectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            List<string> departamentos = new List<string>();

            
                using (SqlCommand com = new SqlCommand(sql, cn))
                {
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    await cn.OpenAsync();
                    using (SqlDataReader reader = await com.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string nombre = reader["DNOMBRE"].ToString();
                            departamentos.Add(nombre);
                        }
                    }
               }
            
            return departamentos;
        }
        public async Task<Departamentos> GetDatosDepartamento(string nombre)
        {
            string sql = "SP_DEPARTAMENTO_EMPLEADOS";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            Departamentos departamento = new Departamentos();

            if (await this.reader.ReadAsync())
            {
                departamento.Id = int.Parse(this.reader["DEPT_NO"].ToString());
                departamento.Nombre = this.reader["DNOMBRE"].ToString();
                departamento.Localidad = this.reader["LOC"].ToString();
            }

            if (await this.reader.NextResultAsync())
            {
                departamento.Empleados = new List<string>();
                while (await this.reader.ReadAsync())
                {
                    string nombreEmpleado = this.reader["APELLIDO"].ToString();
                    departamento.Empleados.Add(nombreEmpleado);
                }
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return departamento;
        }
        public async Task InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@id, @nombre, @localidad)";
            this.com.CommandType = System.Data.CommandType.Text; // Cambiar a Text
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);

            try
            {
                await this.cn.OpenAsync();
                await this.com.ExecuteNonQueryAsync();
            }
            finally
            {
                await this.cn.CloseAsync();
                this.com.Parameters.Clear();
            }
        }
        public async Task<Empleado> GetDatosEmpleado(string apellido)
        {
            string sql = "SELECT * FROM EMP WHERE APELLIDO = @apellido";

            // Crea una nueva conexión dentro del using
            using (SqlConnection cn = new SqlConnection(this.cn.ConnectionString))
            using (SqlCommand com = new SqlCommand(sql, cn))
            {
                com.CommandType = System.Data.CommandType.Text;
                com.Parameters.AddWithValue("@apellido", apellido);

                Empleado empleado = null;

                try
                {
                    await cn.OpenAsync();
                    using (SqlDataReader reader = await com.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            empleado = new Empleado
                            {
                                Id = int.Parse(reader["EMP_NO"].ToString()),
                                Apellido = reader["APELLIDO"].ToString(),
                                Oficio = reader["OFICIO"].ToString(),
                                Salario = int.Parse(reader["SALARIO"].ToString())
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos del empleado", ex);
                }

                return empleado;
            }
        }
        public async Task UpdateEmpleado(int numero, string apellido, string oficio, int salario)
        {
            string sql = "UPDATE EMP SET APELLIDO = @apellido, OFICIO = @oficio, SALARIO = @salario WHERE EMP_NO = @numero";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@salario", salario);
            try
            {
                await this.cn.OpenAsync();
                await this.com.ExecuteNonQueryAsync();
            }
            finally
            {
                await this.cn.CloseAsync();
                this.com.Parameters.Clear();
            }
        }


    }
}
