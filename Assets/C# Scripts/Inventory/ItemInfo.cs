using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.UI;
public class ItemInfo : MonoBehaviour
{
    public static ItemInfo instance;

    public static bool CanShow;

    private Image BG;
    private Text Title;
    private Text Description;
    private Image Icon;

    private void Start()
    {
        BG = GetComponent<Image>();
        Title = transform.GetChild(0).GetComponent<Text>();
        Description = transform.GetChild(1).GetComponent<Text>();
        Icon = transform.GetChild(2).GetComponent<Image>();
    
    
    }

    public void ChangeInfo(ItemInv item)
    {
        Title.text = item.name;
        Description.text = item.ItemDescription;
        Icon.sprite = item.Icon;
    }

    public void ShowInfo(ItemInv item)
    {
        ChangeInfo(item);
        gameObject.transform.localScale = Vector3.one;
        //CanShow = false;
    }
    public void CloseInfo(ItemInv item)
    {
        
        gameObject.transform.localScale = Vector3.zero;
        //CanShow = true;
    }
}
