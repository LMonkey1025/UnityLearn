using UnityEngine;

public class test2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 角度取得及變更
        /*
        Debug.Log("為變更1 "+this.transform.eulerAngles);
        Debug.Log("為變更2 "+this.transform.localEulerAngles);
        this.transform.localEulerAngles = new Vector3(0, 30, 0);
        Debug.Log("1 "+this.transform.eulerAngles);
        Debug.Log("2 "+this.transform.localEulerAngles);
        */
        
        //旋轉
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
    }
    
    void testfunction()
    {
        Debug.Log("testfunction called in test2");
    }
}
