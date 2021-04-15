using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Transform objParent;
    GameObject zoomObj;
    // アイテムを選択していたら
    // Zoomボタン押されtらパネルを表示
    public void Showpannel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if(item != null)
        {   // slotで何かを選択していてzoomボタンが押されていると表示される。
            Destroy(zoomObj);
            panel.SetActive(true);
            // /ObjParentにアイテムを生成する
            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item.type);
            zoomObj =   Instantiate(zoomObjPrefab, objParent); // transform親子関係で生成する場所


        }

    }
    public void HidePannel()
    {
        panel.SetActive(false);
        Destroy(zoomObj);

    }
    //(アイテムを表示)
    // closeを押したらパネルを非表示
    // 
}
