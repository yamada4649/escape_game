using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item item; //左詰め
    [SerializeField] Image image; //画像を表示するための箱
    [SerializeField] GameObject backgroundPanel;
   // 画像をスロットに表示する
   private void Awake()
   {
      // image = GetComponent<Image>();
   }
   private void Start()
   {
       backgroundPanel.SetActive(false);
   }
   public bool IsEmpty()
   {
       if(item == null)
       {
           return true;
       }
       return false;
   }
   public void SetItem(Item item)
   {
       this.item = item;
       UpdateImage(item);
   }
   public Item GetItem()
   {
       return item;
   }
   void UpdateImage(Item item)
   {   // ギミックの解除に必要
       // 画像の貼り付け
       if(item == null)
       {
           image.sprite = null;
       }
       else
       {
       image.sprite = item.sprite;

       }

   }
   public bool OnSelected()
   {
       if (item == null)
       {
           return false;
           
       }

       backgroundPanel.SetActive(true);
       return true;


   }
    public void HideBGPanel()
   {
      backgroundPanel.SetActive(false);

   }
}
