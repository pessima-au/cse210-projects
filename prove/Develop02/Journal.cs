using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public DateTime _lastEntryDate;
    public int _currentStreak;


    public Journal()
    {
        _entries = new List<Entry>();
        _lastEntryDate = DateTime.MinValue;
        _currentStreak = 0;
    }


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        UpdateStreak(entry.GetDate());
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }


    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }


    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Date, Prompt, Entry");
            foreach (var entry in _entries)
            {
                string date = QuoteField(entry._date);
                string promptText = QuoteField(entry._promptText);
                string entryText = QuoteField(entry._entryText);

               
                writer.WriteLine($"{date},{promptText},{entryText}");
            }
        }
    }


    public void LoadFromFile(string filePath)
    {
        _entries.Clear();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                
                reader.ReadLine();//code to skip header

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = ParseCsvLine(line);

                    string date = fields[0];
                    string promptText = fields[1];
                    string entryText = fields[2];

                    _entries.Add(new Entry(date, promptText, entryText));
                }
            }
            if (_entries.Count > 0)
            {
                _lastEntryDate = _entries[_entries.Count - 1].GetDate();
                UpdateStreak(_lastEntryDate);

            }
        }
        else
        {
            throw new FileNotFoundException("The specified file was not found."); 
        }
    }

    private string QuoteField(string field)
    {
        if (field.Contains(",") || field.Contains("\""))
        {
            field = field.Replace("\"", "\"\"");
            return $"\"{field}\"";
        }
        return field;
    }

    private string[] ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        bool inQuotes = false;
        string field = string.Empty;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (c == '"' && (i == 0 || line[i - 1] != '\\'))
             {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                fields.Add(field);
                field = string.Empty;
            }
            else
            {
                field += c;
            }
        }

        fields.Add(field);
        return fields.ToArray();
    }

    private void UpdateStreak(DateTime entryDate)
    {
        if (_lastEntryDate == DateTime.MinValue)
        {
            _currentStreak = 1;
        }
        else if ((entryDate - _lastEntryDate).Days == 1)
        {
            _currentStreak++;
        }
        else if ((entryDate - _lastEntryDate).Days > 1)
        {
            _currentStreak = 1;
        }
        _lastEntryDate = entryDate;
    }

    public int GetCurrentStreak()
    {
        return _currentStreak;
    }

    public bool IsEntryForToday()
    {
        return _lastEntryDate.Date == DateTime.Today;
    }


}