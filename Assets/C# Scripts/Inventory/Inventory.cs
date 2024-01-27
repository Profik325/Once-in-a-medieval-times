using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public bool isOpened;

    public Transform SlotsParent;
    public InventorySlot[] InventorySlots = new InventorySlot[20];

    private void Start()
    {
        instance = this;
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            InventorySlots[i] = SlotsParent.GetChild(i).GetComponent<InventorySlot>();
        }
    }

    public void PutInEmptySlot(ItemInv item)
    {
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            if (InventorySlots[i].SlotItem == null)
            {
                InventorySlots[i].PutInSlot(item);
                return;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isOpened)
                Close();
            else
                Open();
        }
    }

    void Open()
    {
        gameObject.transform.localScale = Vector3.one;
        isOpened = true;
    }
    void Close()
    {
        gameObject.transform.localScale = Vector3.zero;
        isOpened = false;
    }


}
