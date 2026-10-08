using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class MeatCodes : MonoBehaviour
{
    public TMP_Text Results;

    private List<MeatItem> items = new();
    private List<MeatItem> filteredItems = new();
    private StringBuilder srtingBuilder = new StringBuilder();
    private CSVReader csvReader;

    private List<MeatItem> codes = new();

    private void Start()
    {
        csvReader = new CSVReader();
        csvReader.LoadCodes(items);

        Show("");
    }

    public void Show(string words)
    {
        FindItems(words);
        UpdateResults();
    }
    
    private void FindItems(string words)
    {
        filteredItems.Clear();
        words = words.ToLower();

        string[] keywords = words.Split(" ");

        foreach (MeatItem meat in items)
        {
            for(int i = 0; i < keywords.Length; i++)
            {
                if (!meat.MeatName.Contains(keywords[i]))
                {
                    break;
                }
                else if(i == keywords.Length - 1)
                {
                    filteredItems.Add(meat);
                }
            }
        }
    }

    private void UpdateResults()
    {
        srtingBuilder.Clear();

        for (int i = 0; i < filteredItems.Count; i++)
        {
            srtingBuilder.Append($"{filteredItems[i].MeatName}\n-{filteredItems[i].MeatID}\n\n");
        }

        Results.text = srtingBuilder.ToString();
    }
}
