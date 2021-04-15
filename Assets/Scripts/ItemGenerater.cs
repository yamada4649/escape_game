using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
     public static ItemGenerater instance;
     private void Awake()
       {
         if(instance == null)
         {
            instance = this;
          }
        }
    [SerializeField] ItemListEntity itemListEntity;

    public Item Spawn(Item.Type type)
    {
        // itemListの中からtypeと一致したら同じitemを生成して渡す。
        foreach(Item item in itemListEntity.itemList)
        {
            if(item.type == type)
            {
                Debug.Log(item.sprite);
                return new Item(item.type, item.sprite, item.zoomObj);
            }
        }
        return null;

    }
    public GameObject GetZoomItem(Item.Type type)
    {
      foreach(Item item in itemListEntity.itemList)
      {
        if(item.type == type)
        {
          return item.zoomObj;
        }
      }
      return null;

    }
}
