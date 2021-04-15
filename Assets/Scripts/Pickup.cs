using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] Item.Type itemType; //回収したものが判断できる
    // [SerializeField] Item item;
    Item item;
    private void Start()
    {
        // itemTypeにおうじてitemを生成する
        item = ItemGenerater.instance.Spawn(itemType);
        Debug.Log(item);

    }
    public void OnClickObj()
    {
        // ItemBoxにクリックしたデータを送ることができる
       //ItemBox.instance.SetItem(item); //どこでも呼び出せるメソッド
       ItemBox.instance.SetItem(item);
       gameObject.SetActive(false);

    }
}
