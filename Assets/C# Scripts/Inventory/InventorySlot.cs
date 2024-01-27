using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ItemInv SlotItem;

    public Image icon;
    public Button button;

    private void Start()
    {
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SlotClicked);
        

    }

    public void PutInSlot(ItemInv item)
    {
        icon.sprite = item.Icon;
        SlotItem = item;
        icon.enabled = true;
    }

    void SlotClicked()
    {
        if (SlotItem != null)
        {
            ItemInfo.instance.ShowInfo(SlotItem);
        }
        /*else if (ItemInfo.CanShow == false)
        {
            ItemInfo.instance.CloseInfo(SlotItem);
        }*/
        
    }
}
