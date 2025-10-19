using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class MeatCodes : MonoBehaviour
{
    public TMP_Text Results;

    private List<MeatItem> items = new();
    private List<MeatItem> filteredItems = new();
    private StringBuilder sb = new StringBuilder();

    private void Start()
    {
        items.Add(new MeatItem("Whole Bird", 5200));
        items.Add(new MeatItem("Twin Whole Birds", 801130));
        items.Add(new MeatItem("Liver Cups", 308120));
        items.Add(new MeatItem("Drum Thigh Combo", 200035));
        items.Add(new MeatItem("Sanderson Chicken Breast", 200030));
        items.Add(new MeatItem("Sanderson Drumsticks", 201140));
        items.Add(new MeatItem("Sanderson Boneless Thighs", 201120));
        items.Add(new MeatItem("Sanderson Breast Tenders", 201155));
        items.Add(new MeatItem("Sanderson Boneless Breast", 201125));
        items.Add(new MeatItem("Sanderson Thin Sliced Boneless Breast", 201145));
        items.Add(new MeatItem("Sanderson Wings", 201150));
        items.Add(new MeatItem("Sanderson Leg Quarters", 201130));
        items.Add(new MeatItem("Sanderson Thighs", 201115));
        items.Add(new MeatItem("Sanderson Wingettes", 6423));

        items.Add(new MeatItem("Atlantic Salmon", 8031));
        items.Add(new MeatItem("Coho Salmon", 991380));
        items.Add(new MeatItem("Beef Flap Meat Marinated", 997080));
        items.Add(new MeatItem("Beef Skirt Steak Marinated", 939500));
        items.Add(new MeatItem("Beef Chuck Steak Marinated", 993315));
        items.Add(new MeatItem("Chicken Leg Meat Marinated", 299574));

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

        foreach (MeatItem meat in items)
        {
            if (meat.MeatName.Contains(words))
            {
                filteredItems.Add(meat);
            }
        }
    }

    private void UpdateResults()
    {
        sb.Clear();

        for (int i = 0; i < filteredItems.Count; i++)
        {
            sb.Append($"{filteredItems[i].MeatName}\n-{filteredItems[i].MeatCode}\n\n");
        }

        Results.text = sb.ToString();
    }
}
