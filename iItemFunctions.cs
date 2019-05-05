using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iItemFunctions
{

    void UseHealthPotion(PlayerStatus player, int amount);
    void UseManaPotion(PlayerStatus player, int amount);
    void EquipArmour(PlayerStatus player, int amount);
    void UnequipArmour(PlayerStatus player, int amount);
}
