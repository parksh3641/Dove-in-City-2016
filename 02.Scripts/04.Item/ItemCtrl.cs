using UnityEngine;
using System.Collections;

public class ItemCtrl : MonoBehaviour {
    public UISprite sprite; //메인아이콘
    public UISprite check; //선택시 테두리

    public int ItemNumber = 0; // 아이템 종류 설정

    public InventoryManager Inventory;

    void Start()
    {
        check.gameObject.SetActive(false);
    }
    void OnEnable()
    {
        InventoryManager.One += One;
        InventoryManager.Two += Two;
        InventoryManager.Three += Three;
        InventoryManager.Four += Four;
        InventoryManager.Five += Five;
        InventoryManager.Six += Six;
        InventoryManager.Seven += Seven;
        InventoryManager.Eight += Eight;
        InventoryManager.Eleven += Eleven;
        InventoryManager.Fifteen += Fifteen;
    }
    void OnDisable()
    {
        InventoryManager.One -= One;
        InventoryManager.Two -= Two;
        InventoryManager.Three -= Three;
        InventoryManager.Four -= Four;
        InventoryManager.Five -= Five;
        InventoryManager.Six -= Six;
        InventoryManager.Seven -= Seven;
        InventoryManager.Eight -= Eight;
        InventoryManager.Eleven -= Eleven;
        InventoryManager.Fifteen -= Fifteen;
    }
    void One()
    {
        if(ItemNumber ==1)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Two()
    {
        if (ItemNumber == 2)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Three()
    {
        if (ItemNumber == 3)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Four()
    {
        if (ItemNumber == 4)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Five()
    {
        if (ItemNumber == 5)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Six()
    {
        if (ItemNumber == 6)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Seven()
    {
        if (ItemNumber == 7)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Eight()
    {
        if (ItemNumber == 8)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Eleven()
    {
        if (ItemNumber == 11)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void Fifteen()
    {
        if (ItemNumber == 15)
        {
            check.gameObject.SetActive(true);
        }
        else
        {
            check.gameObject.SetActive(false);
        }
    }
    void OnClick()
    {
        //check.gameObject.SetActive(Selected);
        Inventory.SelectItem(ItemNumber);
    }
}
