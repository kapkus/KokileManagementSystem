using System;
using System.Data;
using System.Data.SQLite;

namespace Kokile
{
    public class SQLiteManager
    {
        private string connectionString;

        public SQLiteManager(string dbFilePath)
        {
            connectionString = $"Data Source={dbFilePath};Version=3;";
        }

        public void changeDatabasePath(string databasePath)
        {
            this.connectionString = $"Data Source={databasePath};Version=3;";
        }

        public void InsertKokilaRecord(string[] data)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO kokile (date, typFelgi, selekcja, kodKreskowy, zmiana, brygada) VALUES (@date, @typFelgi, @selekcja, @kodKreskowy, @zmiana, @brygada)";
                    command.Parameters.AddWithValue("@date", data[0]);
                    command.Parameters.AddWithValue("@typFelgi", data[1]);
                    command.Parameters.AddWithValue("@selekcja", data[2]);
                    command.Parameters.AddWithValue("@kodKreskowy", data[3]);
                    command.Parameters.AddWithValue("@zmiana", data[4]);
                    command.Parameters.AddWithValue("@brygada", data[5]);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateKokilaRecord(string[] data)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE kokile SET typFelgi=@typFelgi, selekcja=@selekcja, kodKreskowy=@kodKreskowy, zmiana=@zmiana, brygada=@brygada  WHERE id = @id";
                    command.Parameters.AddWithValue("@id", data[0]);
                    command.Parameters.AddWithValue("@typFelgi", data[1]);
                    command.Parameters.AddWithValue("@selekcja", data[2]);
                    command.Parameters.AddWithValue("@kodKreskowy", data[3]);
                    command.Parameters.AddWithValue("@zmiana", data[4]);
                    command.Parameters.AddWithValue("@brygada", data[5]);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteKokilaRecord(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM kokile WHERE id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllKokilaRecords()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM kokile", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public string GetKokilaFromBarcode(string barcodeId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT kokila FROM radlist WHERE barcodeId = @barcodeId";
                    command.Parameters.AddWithValue("@barcodeId", barcodeId);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }

        public string GetBarcodeString(string barcodeId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT barcode FROM barcodes WHERE id = @id";
                    command.Parameters.AddWithValue("@id", barcodeId);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        } 

        public int SearchForBarcodeId(string barcodeNumber) 
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT id FROM barcodes WHERE barcode = @barcodeNumber", connection))
                {
                    command.Parameters.AddWithValue("@barcodeNumber", barcodeNumber);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public DataTable GetAllRadlistRecords()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM radlist", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void DeleteRadlistRecord(int barcodeId, string kokilaName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM radlist WHERE barcodeId = @barcodeId AND kokila = @kokilaName";
                    command.Parameters.AddWithValue("@barcodeId", barcodeId);
                    command.Parameters.AddWithValue("@kokilaName", kokilaName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRadlistRecord(string currentBarcodeId, string[] editedData)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE radlist SET barcodeId=@barcodeId, kokila=@kokila WHERE barcodeId = @currentBarcodeId";
                    command.Parameters.AddWithValue("@barcodeId", editedData[0]);
                    command.Parameters.AddWithValue("@kokila", editedData[1]);
                    command.Parameters.AddWithValue("@currentBarcodeId", currentBarcodeId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertRadlistRecord(string barcodeId, string typFelgi)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO radlist VALUES (@barcodeId, @typFelgi)";
                    command.Parameters.AddWithValue("@barcodeId", barcodeId);
                    command.Parameters.AddWithValue("@typFelgi", typFelgi);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
