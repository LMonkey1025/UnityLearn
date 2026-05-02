using UnityEngine;

public class test4 : MonoBehaviour
{
    public Transform Obj;
    public int n;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 獲取父物件名稱
        // Debug.Log(transform.parent.name);
        
        // 解除父子關係
        // transform.parent = null;

        // 設定父物件
        // 1.通過獲取其他物件的transform
        // transform.parent = GameObject.Find("parent2").transform;
        // Debug.Log(transform.parent.name);
        
        // 2.使用API SetParent
        // transform.SetParent(null);
        // transform.SetParent(GameObject.Find("parent2").transform, false);
        
        
        // 斷絕所有父子關係
        // transform.DetachChildren();
        

        
        // 使用名字獲取子物件
        // this.transform.Find("cube");
        
        
        // 獲取子物件數量
        print(transform.childCount);
        
        // 使用索引獲取子物件
        // this.transform.GetChild(2); 
        // for (int i = 0; i < transform.childCount; i++)
        // {
        //     print("索引值" + i + "的子物件名" + transform.GetChild(i).name);
        // }
        
        //判斷父物件是誰
        // if (Obj.IsChildOf(this.transform))
        // {
        //     print(Obj.name + "是" + this.name + "的子物件");
        // }

        
        // Obj作為子物件的索引值
        print(Obj.GetSiblingIndex());

        
        // 把Obj設成作為子物件的第一個索引值
        Obj.SetAsFirstSibling();
        
        // 把Obj設成作為子物件的最後一個索引值
        Obj.SetAsLastSibling();

        
        // 把Obj設成作為子物件的第n個索引值
        Obj.SetSiblingIndex(n);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
