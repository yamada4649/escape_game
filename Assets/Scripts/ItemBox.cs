using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
 // どこでも実行できるようにする。
 // PickUpObjがクリックされたら、スロットにアイテムを入れる。
 public static ItemBox instance;
 [SerializeField] Slot[] slots;
 [SerializeField] Slot selectedSlot = null; //何のスロットを選んでいるのかどうかを決める


 private void Awake()
 {
     if(instance == null)
     {
         instance = this;
         slots = GetComponentsInChildren<Slot>(); //itemBoxについている子要素を取得してくれる。
     }
 }

 public void SetItem(Item item) // どんなタイプのアイテムを受けとったのか
 {
     foreach(Slot slot in slots)
     {
         if(slot.IsEmpty())
         {
             slot.SetItem(item);
             break;// 処理を終了
         }
     }
     // クリックしたアイテムを受け取り、Slotで表示させる
     Debug.Log(item);
 }
 public void OnSelectSlot(int position)
 {
     // 一旦全てのスロットの選択パネルを非表示
     foreach (Slot slot in slots)
     {
         slot.HideBGPanel();
         
     }
     selectedSlot = null; 
     if(slots[position].OnSelected())
     {
         selectedSlot = slots[position];

     }
     // 選択されたスロットの選択パネルを表示)

 }
 // アイテムの使用を試みる
 public bool TryUseItem(Item.Type type)
 {   // 選択スロットがあるかどうか
     if(selectedSlot == null)
     {
         return false;
     }
     if(selectedSlot.GetItem().type == type)
     {
         selectedSlot.SetItem(null);
         selectedSlot.HideBGPanel();
         selectedSlot = null;
         return true;
     }
     return false;
 }
     public Item GetSelectedItem() //itemにデータを渡してやる。slotが選ばれたら
     {
         if(selectedSlot == null)
         {
             return null;
         }
         return selectedSlot.GetItem();
     }
}
