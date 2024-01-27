using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public ItemInv Item;
    private GameObject ItemObject;
   
    private void Start()
    {
        ItemObject = gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.PutInEmptySlot(Item);
            Destroy(gameObject);
        }
    }
}
