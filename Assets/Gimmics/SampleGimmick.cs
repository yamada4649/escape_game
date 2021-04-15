using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
   // クリックすると消える
   [SerializeField] Item.Type clearItem;
   public void OnClickObj()
   {
       Debug.Log("クリックしたよ！");
       bool clear = ItemBox.instance.TryUseItem(clearItem);
       if(clear == true)
       {
           Debug.Log("ギミック解除");
           gameObject.SetActive(false);
       }
   }
}
