using UnityEngine;
using UnityEngine.InputSystem;

public class Test6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 滑鼠位置
        // print(Input.mousePosition);


        // 滑鼠按鍵點擊
        if (Input.GetMouseButtonDown(0))
        {
            print("按下左鍵");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            print("按下右鍵");
        }
        else if (Input.GetMouseButtonDown(2))
        {
            print("按下中鍵");
        }

        // 滑鼠按鍵放開
        if (Input.GetMouseButtonUp(0))
        {
            print("放開左鍵");
        }
        else if (Input.GetMouseButtonUp(1))
        {
            print("放開右鍵");
        }
        else if (Input.GetMouseButtonUp(2))
        {
            print("放開中鍵");
        }

        //滑鼠按鍵持續按下
        if (Input.GetMouseButton(0))
        {
            print("持續按下左鍵");
        }
        else if (Input.GetMouseButton(1))
        {
            print("持續按下右鍵");
        }
        else if (Input.GetMouseButton(2))
        {
            print("持續按下中鍵");
        }

        // 中鍵滾輪
        // 會回傳Vector 2，滑鼠滾動改變Y
        if (Input.mouseScrollDelta != Vector2.zero)
        {
            print(Input.mouseScrollDelta);
        }

        // 鍵盤按下
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("按下C鍵");
        }

        //鍵盤抬起瞬間
        if (Input.GetKeyUp(KeyCode.C))
        {
            print("放開C鍵");
        }

        // 長按鍵盤
        if (Input.GetKey(KeyCode.C))
        {
            print("持續按下C鍵");
        }

        
        // Unity預設的水平軸，會回傳-1到1之間的值，按下A或左鍵會回傳-1，按下D或右鍵會回傳1，沒按下會回傳0
        print("Horizontal : " + Input.GetAxis("Horizontal"));
        // S、W
        print ("Vertical : " + Input.GetAxis("Vertical"));
        // 滑鼠水平移動
        print("Mouse X : " + Input.GetAxis("Mouse X"));
        // 滑鼠垂直移動
        print("Mouse Y : " + Input.GetAxis("Mouse Y"));
        // A、D無float
        print("GetAxisRaw(Horizontal) : " + Input.GetAxisRaw("Horizontal"));
        
    }
}