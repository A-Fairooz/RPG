using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapon", order = 3)]
public class Weapon : Items
{
    public int damage;
    public int attackSpeed;
    public int range;
   
}
