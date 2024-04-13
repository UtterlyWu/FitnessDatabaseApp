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
using System.Security.Cryptography.Xml;
using System.Reflection.Metadata.Ecma335;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Principal;
using System.Xml.Linq;

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

        public async Task<List<Member>> getMembers(string query)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

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
                        Height: reader.GetInt32(reader.GetOrdinal("height")),
                        Routine_id: reader.GetInt32(reader.GetOrdinal("routine_id"))
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
                    Sex: reader.IsDBNull(reader.GetOrdinal("sex")) ? null : reader.GetString(reader.GetOrdinal("sex")),
                    Member_id: reader.GetInt32(reader.GetOrdinal("member_id")),
                    Current_weight: reader.IsDBNull(reader.GetOrdinal("current_weight")) ? -1 : reader.GetFloat(reader.GetOrdinal("current_weight")),
                    Desired_weight: reader.IsDBNull(reader.GetOrdinal("desired_weight")) ? -1 : reader.GetFloat(reader.GetOrdinal("desired_weight")),
                    Height: reader.IsDBNull(reader.GetOrdinal("height")) ? -1 : reader.GetFloat(reader.GetOrdinal("height")),
                    Routine_id: reader.IsDBNull(reader.GetOrdinal("routine_id")) ? -1 : reader.GetInt32(reader.GetOrdinal("routine_id"))
                    );
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

        public async Task<Trainer> getTrainerByID(int id)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.trainers WHERE trainer_id='{id}'";

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

        public async Task<List<Session>> getSessions(string query)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                var result = new List<Session>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Session(
                        session_id: reader.GetInt32(reader.GetOrdinal("session_id")),
                        trainer_id: reader.GetInt32(reader.GetOrdinal("trainer_id")),
                        room_number: reader.GetInt32(reader.GetOrdinal("room_number")),
                        type: reader.GetString(reader.GetOrdinal("type")),
                        name: reader.GetString(reader.GetOrdinal("name")),
                        description: reader.GetString(reader.GetOrdinal("description")),
                        date: reader.GetDateTime(reader.GetOrdinal("date")).ToString("yyyy-MM-dd"),
                        capacity: reader.GetInt32(reader.GetOrdinal("capacity"))
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

        public async Task<bool> registerForSession(int member_id,  int session_id)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO public.registrations(session_id, member_id) " +
                                  $"VALUES ({session_id},{member_id})";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding data: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<int> countSession(int session_id)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM public.registrations WHERE session_id = {session_id}";

                var result = await cmd.ExecuteScalarAsync();

                int registrationsCount = Convert.ToInt32(result);

                return registrationsCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting registrations: " + ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<bool> makePayment(int member_id, float amount, int cardnumber, string purpose)
        {
            try
            {
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO public.billings(amount, member_id, card_number,date_paid,purpose) VALUES ({amount}, {member_id}, {cardnumber},'{currentDate}', '{purpose}')";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding data: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<bool> unRegisterForSession(int member_id, int session_id)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"DELETE FROM public.registrations WHERE session_id = {session_id} AND member_id = {member_id};";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding data: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<List<Achievement>> getAchievements(List<string> arguments, List<string> values, string operator_t = "")
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                if (arguments.Count > 1 && values.Count > 1 && operator_t == "")
                {
                    operator_t = "AND";
                }
                string conditional = arguments.Count > 0 ? " WHERE" : "";
                for (int i = 0; i < arguments.Count; i++)
                {
                    conditional += i - 1 == arguments.Count ? $" {arguments[i]} = {values[i]}" : $" {arguments[i]} = {values[i]} {operator_t}";
                }
                cmd.CommandText = $"SELECT * FROM public.Achievements{conditional}";
                    
                var result = new List<Achievement>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Achievement(
                        Achievement_id: reader.GetInt32(reader.GetOrdinal("achievement_id")),
                        Name: reader.GetString(reader.GetOrdinal("name")),
                        Description: reader.GetString(reader.GetOrdinal("description")),
                        Member_id: reader.GetInt32(reader.GetOrdinal("member_id")),
                        Date: reader.GetDateTime(reader.GetOrdinal("date")).ToString("yyyy-MM-dd"),
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

        public async Task<Int32> nonGetQuery(string query, bool returning)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                if (returning)
                {
                    return (int)cmd.ExecuteScalar();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing: " + ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public async void updateAchievement(int to_update_id, String new_name, String new_description)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE public.Achievements " +
                                  $"SET name = '{new_name}', description = '{new_description}' " +
                                  $"WHERE achievement_id = {to_update_id}";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating data: " + ex.Message);
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

        public async void deleteRow(string table, List<string> arguments, List<string> values, string operator_t = "")
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                string conditional = arguments.Count > 0 ? " WHERE" : "";
                for (int i = 0; i < arguments.Count; i++)
                {
                    conditional += i - 1 == arguments.Count ? $" {arguments[i]} = {values[i]}" : $" {arguments[i]} = {values[i]} {operator_t}";
                }
                cmd.CommandText = $"DELETE FROM public.{table}{conditional}";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error deleting data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public async Task<bool> updateAttributeStr(String attribute, String newThing, String type, String account)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE public.{type}\r\nSET {attribute} = '{newThing}'\r\nWHERE username = '{account}'";
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

        public async Task<IEnumerable<Routine>> GetRoutines()
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT * FROM public.fitnessroutines";
                var result = new List<Routine>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Routine(
                        routine_id: reader.GetInt32(reader.GetOrdinal("routine_id")),
                        title: reader.GetString(reader.GetOrdinal("title")),
                        description: reader.GetString(reader.GetOrdinal("description")),
                        catagory: reader.GetString(reader.GetOrdinal("category"))));
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

        public async Task<bool> isInSession(int member_id, int session_id)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM public.registrations\r\nWHERE member_id='{member_id}' AND session_id = '{session_id}'";
                var result = await cmd.ExecuteScalarAsync();
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error querying data: " + ex.Message);
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

        public async Task<IEnumerable<Session>> GetSessions()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM public.sessions ORDER BY date ASC;";

                    var result = new List<Session>();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(new Session(
                                name: reader.GetString(reader.GetOrdinal("name")),
                                session_id: reader.GetInt32(reader.GetOrdinal("session_id")),
                                trainer_id: reader.GetInt32(reader.GetOrdinal("trainer_id")),
                                room_number: reader.GetInt32(reader.GetOrdinal("room_number")),
                                type: reader.GetString(reader.GetOrdinal("type")),
                                description: reader.GetString(reader.GetOrdinal("description")),
                                capacity: reader.GetInt32(reader.GetOrdinal("capacity")),
                                date: reader.GetDateTime(reader.GetOrdinal("date")).ToString("yyyy-MM-dd")));
                        }
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching data: " + ex.Message);
                return Enumerable.Empty<Session>(); // Return an empty enumerable instead of null
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public async Task<bool> updateAttributeInt(String attribute, int newThing, String account)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE public.members\r\nSET {attribute} = '{newThing}'\r\nWHERE username = '{account}'";
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

        public async Task<bool> register(string username, string password, string first_name, string last_name, string type)
        {
            try
            {
                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                if (type == "members")
                {
                    cmd.CommandText = $"INSERT INTO public.{type}(username,pword,first_name,last_name,joined_date)\r\nVALUES\r\n\t('{username}','{password}','{first_name}','{last_name}','{currentDate}');";
                }
                else if (type == "trainers")
                {
                    cmd.CommandText = $"INSERT INTO public.{type}(username,pword,first_name,last_name) VALUES ('{username}','{password}','{first_name}','{last_name}');";
                }
                else
                {
                    cmd.CommandText = $"INSERT INTO public.{type}(username,pword,first_name,last_name,position) VALUES ('{username}','{password}','{first_name}','{last_name}','');";
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

        public async Task<List<Availability>> getAvailability(string query)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                var result = new List<Availability>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Availability(
                        date: reader.GetDateTime(reader.GetOrdinal("date")).ToString("yyyy-MM-dd"),
                        trainer_id: reader.GetInt32(reader.GetOrdinal("trainer_id"))
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

        public async Task<List<Billing>> getBillings(string query)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                var result = new List<Billing>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Billing(
                        reader.GetFloat(reader.GetOrdinal("amount")),
                        reader.GetInt32(reader.GetOrdinal("card_number")),
                        reader.GetInt32(reader.GetOrdinal("bill_id")),
                        reader.GetString(reader.GetOrdinal("purpose")),
                        reader.GetInt32(reader.GetOrdinal("member_id")),
                        reader.GetDateTime(reader.GetOrdinal("date_paid")).ToString("yyyy-MM-dd")
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

        public async Task<List<Machine>> getMachines(string query)
        {
            try
            {
                await conn.OpenAsync();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                var result = new List<Machine>();
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result.Add(new Machine(
                        reader.GetInt32(reader.GetOrdinal("machine_id")),
                        reader.GetString(reader.GetOrdinal("name")),
                        reader.GetString(reader.GetOrdinal("status")),
                        reader.GetInt32(reader.GetOrdinal("room_number"))
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
    }
}
