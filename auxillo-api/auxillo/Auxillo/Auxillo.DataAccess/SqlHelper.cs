using AutoMapper;
using AutoMapper.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Auxillo.DataAccess
{
    public static class SqlHelper
    {
        private static IMapper _mapper;
        public static IMapper GetMapper<TData>()
        {
            try
            {
                //if (_mapper == null)
                //{
                _mapper = new MapperConfiguration(cfg =>
                {
                    cfg.AddDataReaderMapping(false);
                    cfg.CreateMap<IDataReader, TData>();

                }).CreateMapper();
                //}
            }
            catch (Exception ex)
            {

            }            

            return _mapper;
        }

        public static string ExecuteProcedureReturnString(string connString, string procName, params SqlParameter[] parameters)
        {
            string result = "";

            try
            {
                using (var sqlConnection = new NpgsqlConnection(connString))
                {
                    //using (var command = sqlConnection.CreateCommand())
                    //{

                    //if (parameters != null)
                    //{
                    //    command.Parameters.AddRange(parameters);
                    //}
                    sqlConnection.Open();

                    //var ret = command.ExecuteScalar();
                    //result = Convert.ToString(ret);

                    NpgsqlCommand command = new NpgsqlCommand(procName, sqlConnection);
                    var dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr != null)
                        {
                            var dt = dr.GetInt32(0);
                            result = result + " " + dr.GetInt32(0) + " " + dr.GetString(1) + " ";
                        }
                    }

                    //}
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
            return result.ToString();
        }

        public static TData ExecuteProcedureReturnSingleObject<TData>(string connString, string procName, params SqlParameter[] parameters)
        {
            var mapper = GetMapper<TData>();

            using (var sqlConnection = new NpgsqlConnection(connString))
            {
                //using (var sqlCommand = sqlConnection.CreateCommand())
                //{
                //    sqlCommand.CommandType = CommandType.StoredProcedure;
                //    sqlCommand.CommandText = procName;
                //    if (parameters != null)
                //    {
                //        sqlCommand.Parameters.AddRange(parameters);
                //    }
                TData elements = mapper.Map<TData>(null);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand(procName, sqlConnection);
                using (var reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            elements = mapper.Map<TData>(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                sqlConnection.Close();
                return elements;
            }
        }
        

        //public static string ExecuteProcedureReturnString(string connString, string procName, params SqlParameter[] parameters)
        //{
        //    string result = "";

        //    using (var sqlConnection = new SqlConnection(connString))
        //    {
        //        using (var command = sqlConnection.CreateCommand())
        //        {
        //            command.CommandType = System.Data.CommandType.StoredProcedure;
        //            command.CommandText = procName;
        //            if (parameters != null)
        //            {
        //                command.Parameters.AddRange(parameters);
        //            }
        //            sqlConnection.Open();

        //            //var ret = command.ExecuteScalar();
        //            //result = Convert.ToString(ret);
        //            var ret = command.ExecuteReader();

        //            while (ret.Read())
        //            {
        //                if (ret != null)
        //                {
        //                    var dt = ret[0];
        //                    result = result + "" + Convert.ToString(ret[0]);
        //                }
        //            }

        //        }
        //    }
        //    return result.ToString();
        //}

        //public static TData ExecuteProcedureReturnSingleObject<TData>(string connString, string procName, params SqlParameter[] parameters)
        //{
        //    var mapper = GetMapper<TData>();

        //    using (var sqlConnection = new SqlConnection(connString))
        //    {
        //        using (var sqlCommand = sqlConnection.CreateCommand())
        //        {
        //            sqlCommand.CommandType = CommandType.StoredProcedure;
        //            sqlCommand.CommandText = procName;
        //            if (parameters != null)
        //            {
        //                sqlCommand.Parameters.AddRange(parameters);
        //            }
        //            TData elements = mapper.Map<TData>(null);
        //            sqlConnection.Open();
        //            using (var reader = sqlCommand.ExecuteReader())
        //            {
        //                try
        //                {
        //                    while (reader.Read())
        //                    {
        //                        elements = mapper.Map<TData>(reader);
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    throw ex;
        //                }
        //            }
        //            sqlConnection.Close();
        //            return elements;
        //        }
        //    }
        //}

        public static List<TData> ExecuteProcedureReturnList<TData>(string connString, string procName, params SqlParameter[] parameters)
        {
            var mapper = GetMapper<TData>();

            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = procName;
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    List<TData> elements = mapper.Map<List<TData>>(null);
                    sqlConnection.Open();
                    try
                    {
                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                elements.Add(mapper.Map<TData>(reader));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    sqlConnection.Close();
                    return elements;
                }
            }
        }

        public static DataTable ExecuteProcedureReturnDataTable(string connString, string procName, params SqlParameter[] parameters)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = procName;
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                    adapter.Fill(data);

                    conn.Close();
                }
            }
            return data;
        }

        public static DataSet ExecuteProcedureReturnDataSet(string connString, string procName, params SqlParameter[] parameters)
        {
            DataSet data = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = procName;
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                    adapter.Fill(data);

                    conn.Close();
                }
            }
            return data;
        }

        public static async Task<string> ExecuteProcedureReturnStringAsync(string connString, string procName,
            params SqlParameter[] parameters)
        {
            string result = "";
            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = procName;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    sqlConnection.Open();
                    var ret = await command.ExecuteScalarAsync();
                    if (ret != null)
                    {
                        result = Convert.ToString(ret);
                    }
                }
            }
            return result;
        }

        public static async Task<TData> ExecuteProcedureReturnDataAsync<TData>(string connString, string procName,
            Func<SqlDataReader, TData> translator,
            params SqlParameter[] parameters)
        {
            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = procName;
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    sqlConnection.Open();
                    using (var reader = await sqlCommand.ExecuteReaderAsync())
                    {
                        TData elements;
                        try
                        {
                            elements = translator(reader);
                        }
                        finally
                        {
                            while (reader.NextResult())
                            { }
                        }
                        return elements;
                    }
                }
            }
        }


        ///Methods to get values of 
        ///individual columns from sql data reader
        #region Get Values from Sql Data Reader
        public static string GetNullableString(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? null : Convert.ToString(reader[colName]);
        }

        public static int GetInt32(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToInt32(reader[colName]);
        }

        public static int? GetNullableInt32(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? (int?)null : Convert.ToInt32(reader[colName]);
        }

        public static double GetNullableDouble(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0.0 : Convert.ToDouble(reader[colName]);
        }

        public static DateTime GetDateTime(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? DateTime.MinValue : Convert.ToDateTime(reader[colName]);
        }

        public static DateTime? GetNullableDateTime(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? (DateTime?)null : Convert.ToDateTime(reader[colName]);
        }

        public static bool GetBoolean(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? default(bool) : Convert.ToBoolean(reader[colName]);
        }

        public static bool? GetNullableBoolean(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? (bool?)null : Convert.ToBoolean(reader[colName]);
        }

        //this method is to check wheater column exists or not in data reader
        public static bool IsColumnExists(this System.Data.IDataRecord dr, string colName)
        {
            try
            {
                return (dr.GetOrdinal(colName) >= 0);
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        #endregion
    }
}
