using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]　// データベース作成に必要
public class ItemListEntity : ScriptableObject // データベース作成に必要
{
  // データベース関係
   public  List<Item> itemList = new List<Item>();
}
