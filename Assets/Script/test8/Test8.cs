using UnityEngine;

public class Test8 : MonoBehaviour
{
    
    private float _cameraDepth;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 獲取 Tag 為 "MainCamera" 的 GameObject   
        print(Camera.main.name);
        
        // 獲取Camera數量
        print(Camera.allCamerasCount);
        
        // 獲取所有Camera
        Camera[] allCamera = Camera.allCameras;
        print(allCamera.Length);
        
        
        // 委派
        // 在相機剔除 (culling) 完成後、正式開始渲染之前會呼叫 onPreCull。
        // 用途：在渲染前做最後的場景/相機調整（例如動態剔除、更新材質參數等）。
        // 參數 c 是觸發事件的 Camera 實例；c.gameObject.name 可取得相機物件名稱，常用於除錯。
        // 
        Camera.onPreCull += (c) =>
        {
        };
        // 在相機開始渲染每一幀之前會呼叫 onPreRender（在實際提交 draw calls 之前）。
        // 用途：在渲染前做最後設定，如設定 shader 全域參數或相機矩陣等。
        // 注意：若在多次啟用時重複註冊會導致多次呼叫，建議在 OnEnable 註冊、OnDisable 取消註冊。
        Camera.onPreRender += (c) =>
        {
        };
        // 與前者類似，但在相機完成渲染後呼叫（在 GPU 完成渲染後）。用途：在渲染完成後做清理或後處理效果等。
        Camera.onPostRender += (c) =>
        {
        };
        
        //
        _cameraDepth = Camera.main.depth;
        
        // 世界座標轉螢幕座標
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        // 螢幕座標轉世界座標
        Vector3 v2 = Input.mousePosition;
        v2.z = 10;
        print(Camera.main.ScreenToWorldPoint(v2));
    }
}
