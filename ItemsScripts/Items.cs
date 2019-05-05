using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Weapons, Armour, Storage, Consumable}

public class Items : ScriptableObject
{
    public ItemType type;
    public int weight;
    public int price;
    public int size;
    public Sprite sprite;

    
}




