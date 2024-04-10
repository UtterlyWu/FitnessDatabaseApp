using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenter.Classes;
using System.Diagnostics;
using System.Data;

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
            String password = "postgres";
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

        public async Task<Account> LoginAccount(string username, string password, String account_type)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = $"SELECT * FROM public.Accounts WHERE username='{username}' AND pword = '{password}' AND account_type = '{account_type}'";

                Account result;
                using var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                result = new Account(
                Username: reader.GetString(reader.GetOrdinal("username")),
                Password: reader.GetString(reader.GetOrdinal("pword")),
                First_name: reader.GetString(reader.GetOrdinal("first_name")),
                Last_name: reader.GetString(reader.GetOrdinal("last_name")),
                Account_type: reader.GetString(reader.GetOrdinal("account_type")));
                return result;
            }

            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return null;
            }

            finally
            {
                conn.Close();
            }

        }

        public async Task<Member> getMember(string username)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.Members WHERE username='{username}'";

                Member result;
                using var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                result = new Member(
                        Username: reader.GetString(reader.GetOrdinal("username")),
                        Password: reader.GetString(reader.GetOrdinal("pword")),
                        First_name: reader.GetString(reader.GetOrdinal("first_name")),
                        Last_name: reader.GetString(reader.GetOrdinal("last_name")),
                        Joined_date: reader.GetDateTime(reader.GetOrdinal("joined_date")).ToString("yyyy-MM-dd"),
                        Sex: reader.GetString(reader.GetOrdinal("sex")),
                        Member_id: reader.GetInt32(reader.GetOrdinal("member_id")),
                        Current_weight: reader.GetFloat(reader.GetOrdinal("current_weight")),
                        Desired_weight: reader.GetFloat(reader.GetOrdinal("desired_weight")),
                        Height: reader.GetFloat(reader.GetOrdinal("height")));
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public async Task<Trainer> getTrainer(string username)

        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.trainers WHERE username='{username}'";

                Trainer result;
                using var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                result = new Trainer(
                        Username: reader.GetString(reader.GetOrdinal("username")),
                        Password: reader.GetString(reader.GetOrdinal("pword")),
                        First_name: reader.GetString(reader.GetOrdinal("first_name")),
                        Last_name: reader.GetString(reader.GetOrdinal("last_name")),
                        Trainer_id: reader.GetInt32(reader.GetOrdinal("trainer_id")));
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<List<Achievement>> getAchievements(int member_id)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.Achievements WHERE member_id = {member_id}"; //may not work

                var result = new List<Achievement>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Achievement(
                        Achievement_id: reader.GetInt32(reader.GetOrdinal("achievement_id")),
                        Name: reader.GetString(reader.GetOrdinal("achievement_id")),
                        Description: reader.GetString(reader.GetOrdinal("description")),
                        Member_id: reader.GetInt32(reader.GetOrdinal("member_id")),
                        Date: reader.GetString(reader.GetOrdinal("date")),
                        Trainer_id: reader.GetInt32(reader.GetOrdinal("trainer_id"))
                    ));
                }
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<Admin> getAdmin(string username)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.adminstaff WHERE username='{username}'";

                Admin result;
                using var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                result = new Admin(
                        Username: reader.GetString(reader.GetOrdinal("username")),
                        Password: reader.GetString(reader.GetOrdinal("pword")),
                        First_name: reader.GetString(reader.GetOrdinal("first_name")),
                        Last_name: reader.GetString(reader.GetOrdinal("last_name")),
                        Admin_id: reader.GetInt32(reader.GetOrdinal("admin_id")),
                        Position: reader.GetString(reader.GetOrdinal("position")));
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public async void addAchievement(String name, String description, int member_id, int trainer_id)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO public.Achievements(name, description, member_id, date, trainer_id) " +
                                  $"VALUES ({name}, {description}, {member_id}, {DateTime.Now.Date}, {trainer_id})";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public async void register(string username, string password, string first_name, string last_name, string type)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                if (type == "members")
                {
                    cmd.CommandText = $"INSERT INTO public.{type}(username,pword,first_name,last_name,joined_date)\r\nVALUES\r\n\t('{username}','{password}','{first_name}','{last_name}','2024-04-06');";
                }
                else if (type == "trainers" || type == "admins")
                {
                    cmd.CommandText = $"INSERT INTO public.{type}(username,pword,first_name,last_name,joined_date)\r\nVALUES\r\n\t('{username}','{password}','{first_name}','{last_name}');";
                }

                using var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                return true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error creating data: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    
                }

            }
        }
    }
}
