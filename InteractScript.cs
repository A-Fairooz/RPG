using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    private ItemType type { get; set; }
    private iItemFunctions iFun { get; }
    public PlayerStatus player { get; set; }

    public Object currentItem;

    public InteractScript()
    {
        iFun = new ItemFunctions();        
    }

    void Start()
    {
        player = gameObject.GetComponent<PlayerStatus>();
        player.health = 50;
        player.maxHealth = 100;
        Debug.Log(currentItem.item.type);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.health > player.maxHealth)
        {
            player.health = player.maxHealth;
        }
        InputManager();
    }



    public void InputManager()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseItem(currentItem.item);
            Debug.Log("Used a Health Potion! New Health: " + player.health);
        }

    }

    public void UseItem(Items item)
    {
        switch (item.type)
        {
            case ItemType.Consumable:
                iFun.UseHealthPotion(player, item.consu);
                
                break;

            default:
                Debug.Log("No Item Equipped!");
                break;
        }

    }
}





