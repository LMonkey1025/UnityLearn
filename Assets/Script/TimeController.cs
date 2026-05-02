using UnityEngine;

public class TimeController : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        print("受timeScale影響的時間： "+Time.deltaTime);
        print("不受timeScale影響的時間： "+Time.unscaledDeltaTime);
    }
}
