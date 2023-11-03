using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Items", menuName = "inventoryItems/ Items")]
public class Items : ScriptableObject
{
    public Sprite itemSprite;
    public int noOfItems;
}
