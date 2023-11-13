using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

[System.Serializable]
public class DropdownData
{
    public Dropdown dropdown;
    public int pointValue;
}

public class LetterManager : MonoBehaviour
{
    public Text pointsText;
    public List<DropdownData> dropdowns = new List<DropdownData>();

    private int totalPoints = 0;

    private void Start()
    {
        UpdatePointsUI(); // Update points UI when the game starts
    }

    public void CheckWordSelection(int dropdownIndex)
    {
        string selectedWord = dropdowns[dropdownIndex].dropdown.options[dropdowns[dropdownIndex].dropdown.value].text;
        int pointValue = dropdowns[dropdownIndex].pointValue;

        if (IsSelectedWordCorrect(dropdownIndex, selectedWord))
        {
            totalPoints += pointValue;
            Debug.Log("Increased by" +  totalPoints);
        }
        else
        {
            totalPoints -= pointValue;
            Debug.Log("Decreased by" + totalPoints);
        }

        UpdatePointsUI(); // Update points UI after each selection
    }

    bool IsSelectedWordCorrect(int dropdownIndex, string selectedWord)
    {
        string[] correctWords = GetCorrectWordsForDropdown(dropdownIndex);
        foreach (string word in correctWords)
        {
            if (word.Equals(selectedWord))
            {
                return true;
            }
        }
        return false;
    }

    string[] GetCorrectWordsForDropdown(int dropdownIndex)
    {

        if (dropdownIndex == 0)
            return new string[] { "Word1", "Word2" };
        else if (dropdownIndex == 1)
            return new string[] { "Word3", "Word4" };

        return new string[] { };
    }

    void UpdatePointsUI()
    {
        pointsText.text = "Points: " + totalPoints.ToString();
    }
}
