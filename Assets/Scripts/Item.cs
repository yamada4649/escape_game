using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable] // 複数のプロパティを選択することができる。Inspecterで
public class Item
{
    // 列挙型　；種類を列挙する
   public enum Type
   {
       Cube,
       Ball,
   }
   public Type type; //種類
   public Sprite sprite; // Slotに表示する画像
   public GameObject zoomObj;

   public Item(Type type,Sprite sprite, GameObject zoomObj)
   {
       this.type = type;
       this.sprite = sprite;
       this.zoomObj = zoomObj;

   }
}
