using System.IO;
using System.Data.SQLite;


public class Journal
{
  //attributes
  public List<Entry> _entries = new List<Entry>();


  //methods
  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);

  }
  

  public void DisplayAll()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("No journal entries to display.");
      return;
    }

    foreach (var entry in _entries)
    {
      Console.WriteLine("Date     : " + entry._date);
      Console.WriteLine("Prompt   : " + entry._promptText);
      Console.WriteLine("Entry    : " + entry._entryText);
      Console.WriteLine(new string('-', 40));
    }
  }

  public void SaveToFile(string file)
  {
    try
    {
      using (StreamWriter outputFile = new StreamWriter(file))
      {
        foreach (Entry item in _entries)
        {

          outputFile.WriteLine(item._date);
          outputFile.WriteLine(item._promptText);
          outputFile.WriteLine(item._entryText);
          outputFile.WriteLine("---");
        }
      }
      Console.WriteLine("Journal saved successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error saving file: {ex.Message}");
    }


  }
  public void LoadFromFile(string file)
  {
    try
    {
      if (!File.Exists(file))
      {
        Console.WriteLine("File not found.");
        return;
      }

      _entries.Clear(); // clear old entries
      string[] lines = File.ReadAllLines(file);
      int i = 0;

      while (i < lines.Length)
      {
        if (i + 3 >= lines.Length) break; //avoid error

        Entry entry = new Entry();
        entry._date = lines[i];
        entry._promptText = lines[i + 1];
        entry._entryText = lines[i + 2];

        _entries.Add(entry);

        i += 4; // Skip "---"
      }

      Console.WriteLine("Journal loaded successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error loading file: {ex.Message}");
    }
  }


  public void SaveToDatabase(string dbFile)
  {
    string connectionString = $"Data Source={dbFile};Version=3;";

    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
    {
      connection.Open();

      // create table if it not exist
      string createTableQuery = @"CREATE TABLE IF NOT EXISTS entries (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        date TEXT NOT NULL,
                                        prompt TEXT NOT NULL,
                                        entry TEXT NOT NULL
                                    );";
      SQLiteCommand createTable = new SQLiteCommand(createTableQuery, connection);
      createTable.ExecuteNonQuery();

      // Insert each entry
      foreach (var e in _entries)
      {
        string insertQuery = "INSERT INTO entries (date, prompt, entry) VALUES (@date, @prompt, @entry)";
        SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
        insertCommand.Parameters.AddWithValue("@date", e._date);
        insertCommand.Parameters.AddWithValue("@prompt", e._promptText);
        insertCommand.Parameters.AddWithValue("@entry", e._entryText);
        insertCommand.ExecuteNonQuery();
      }

      Console.WriteLine("All entries saved to database.");
    }
  }
  


public void LoadFromDatabase(string dbFile)
{
    string connectionString = $"Data Source={dbFile};Version=3;";

    if (!File.Exists(dbFile))
    {
        Console.WriteLine(" Database file not found.");
        return;
    }

    try
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT date, prompt, entry FROM entries";
            SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            _entries.Clear(); // Vider les anciennes entrées

            while (reader.Read())
            {
                Entry entry = new Entry
                {
                    _date = reader["date"].ToString(),
                    _promptText = reader["prompt"].ToString(),
                    _entryText = reader["entry"].ToString()
                };

                _entries.Add(entry);
            }

            Console.WriteLine(" Entries loaded from database.\n");

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($" Error loading from database: {ex.Message}");
    }
}



}