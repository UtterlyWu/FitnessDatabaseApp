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
                        Height: reader.GetInt32(reader.GetOrdinal("height")),
                        Routine_id: reader.GetInt32(reader.GetOrdinal("routine_id"))
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

        public async Task<bool> makePayment(int member_id, float amount, int cardnumber)
        {
            try
            {
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                await conn.OpenAsync();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO public.billings(amount, member_id, card_number,date_paid) VALUES ({amount}, {member_id}, {cardnumber},'{currentDate}')";
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
                else if (type == "trainers" || type == "admins")
                {
                    cmd.CommandText = $"INSERT INTO public.{type}(username,pword,first_name,last_name,joined_date)\r\nVALUES\r\n\t('{username}','{password}','{first_name}','{last_name}',{currentDate});";
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
