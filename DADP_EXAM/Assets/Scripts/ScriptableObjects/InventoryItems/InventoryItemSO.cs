using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class InventoryItemSO : ScriptableObject
{
    public Sprite[] icon;
    public int[] noOfItems;
}
