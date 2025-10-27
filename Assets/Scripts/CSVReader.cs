using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CSVReader
{
    public const string FILE_NAME = "Codes";

    public void LoadCodes(List<MeatItem> meatList)
    {
        TextAsset csvFile = Resources.Load<TextAsset>(FILE_NAME);

        if (csvFile != null)
        {
            AddCodesToList(csvFile.text, meatList);
            Debug.Log("Loaded file");
        }
        else
        {
            Debug.Log("File Does not exits");
        }
    }

    private void AddCodesToList(string csvText, List<MeatItem> meatList)
    {
        string[] lines = csvText.Split('\n');

        for(int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim();

            if (string.IsNullOrEmpty(lines[i]) || lines[i] == "," || lines[i].Contains("Region")) continue;
            Debug.Log(lines[i]);

            string[] parts = lines[i].Split(",");

            if (parts.Length < 2) continue;

            string name = parts[0].Trim();
            string idString = parts[1].Trim();

            meatList.Add(new MeatItem(name, idString));
        }        
    }
}