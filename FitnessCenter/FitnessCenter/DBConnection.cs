using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenter.Classes;
using System.Diagnostics;

namespace FitnessCenter
{
    internal class DBConnection
    {
        NpgsqlConnection conn;
        public DBConnection()
        {
            String server = "localhost";
            String port = "5432";
            String username = "postgres";
            String password = "student";
            String database = "3005Helper";

            var connectionString = $"Server={server};Port={port};User Id={username};Password={password};Database={database};";
            var con = new NpgsqlConnection(connectionString);
            conn = con;

        }

        public async Task<IEnumerable<Member>> GetMembers()
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM public.members ORDER BY member_id ASC";

                var result = new List<Member>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Member(
                        Username: reader.GetString(reader.GetOrdinal("username")),
                        Password: reader.GetString(reader.GetOrdinal("pword")),
                        First_name: reader.GetString(reader.GetOrdinal("first_name")),
                        Last_name: reader.GetString(reader.GetOrdinal("last_name")),
                        Joined_date: reader.GetDateTime(reader.GetOrdinal("joined_date")).ToString("yyyy-MM-dd"),
                        Sex: reader.GetString(reader.GetOrdinal("sex")),
                        Member_id: reader.GetInt32(reader.GetOrdinal("member_id")),
                        Current_weight: reader.GetInt32(reader.GetOrdinal("current_weight")),
                        Desired_weight: reader.GetInt32(reader.GetOrdinal("desired_weight")),
                        Height: reader.GetInt32(reader.GetOrdinal("height"))
                    ));
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching data: " + ex.Message);
                return Enumerable.Empty<Member>();
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<IEnumerable<Member>> LoginMember(string username, string password)
        {

            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.members WHERE username='{username}' AND pword = '{password}'";

                var result = new List<Member>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Member(
                        Username: reader.GetString(reader.GetOrdinal("username")),
                        Password: reader.GetString(reader.GetOrdinal("pword")),
                        First_name: reader.GetString(reader.GetOrdinal("first_name")),
                        Last_name: reader.GetString(reader.GetOrdinal("last_name")),
                        Joined_date: reader.GetDateTime(reader.GetOrdinal("joined_date")).ToString("yyyy-MM-dd"),
                        Sex: reader.GetString(reader.GetOrdinal("sex")),
                        Member_id: reader.GetInt32(reader.GetOrdinal("member_id")),
                        Current_weight: reader.GetFloat(reader.GetOrdinal("current_weight")),
                        Desired_weight: reader.GetFloat(reader.GetOrdinal("desired_weight")),
                        Height: reader.GetFloat(reader.GetOrdinal("height"))
                    ));
                }
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return Enumerable.Empty<Member>();
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
