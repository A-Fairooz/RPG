using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFunctions : MonoBehaviour, iItemFunctions
{
    
    public void UseHealthPotion(PlayerStatus player, int amount)
    {
        player.health += amount;
    }
    public void UseManaPotion(PlayerStatus player, int amount)
    {
        player.mana += amount;
    }

    public void EquipArmour(PlayerStatus player, int amount)
    {
        player.defence += amount;
    }
    public void UnequipArmour(PlayerStatus player, int amount)
    {
        player.defence -= amount;
    }



}
