using UnityEngine;

public class Test7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("螢幕解析度 : " + Screen.currentResolution);
        
        print("螢幕寬度 : " + Screen.width);
        print("螢幕高度 : " + Screen.height);
        
        // 螢幕的休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;  // 永不休眠
        // Screen.sleepTimeout = SleepTimeout.SystemSetting;  // 系統設定
        
        
        // 視窗模式
        Screen.fullScreenMode = FullScreenMode.Windowed;  // 視窗模式
        
        
        // 允許自動旋轉
        Screen.autorotateToLandscapeLeft = true;  // 允許自動旋轉到左橫向
        Screen.autorotateToLandscapeRight = true; // 允許自動旋轉到右橫向
        Screen.autorotateToPortrait = true;       // 允許自動旋轉到直向
        Screen.autorotateToPortraitUpsideDown = true; // 允許自動旋轉到倒立直向
        
        // 指定螢幕顯示方向
        Screen.orientation = ScreenOrientation.LandscapeLeft;  // 只設定螢幕顯示方向為左橫向
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
