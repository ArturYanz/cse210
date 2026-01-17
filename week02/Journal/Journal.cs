using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



public class Journal
{
    private List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] _lines = System.IO.File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in _lines)
        {
            string[] _parts = line.Split("|");

            Entry _newEntry = new Entry();
            _newEntry._date = _parts[0];
            _newEntry._promptText = _parts[1];
            _newEntry._entryText = _parts[2];

            _entries.Add(_newEntry);
        }
    }

}





