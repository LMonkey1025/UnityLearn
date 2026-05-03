using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(Vector3.zero);
        
        // 將某個點在世界座標的位置，轉為相對於某個物件坐標系的位置
        print(this.transform.InverseTransformPoint(Vector3.zero));
        
        // 將某個點在世界座標的方向向量，轉為相對於某個物件坐標系的方向向量
        print(this.transform.InverseTransformVector(Vector3.forward));
         
        // 將相對於物件坐標系的(0, 0, 1)位置轉為世界座標的位置
        print(this.transform.TransformPoint(Vector3.forward));
        
        // 將相對於物件坐標系的(0, 0, 1)方向向量轉為世界座標的方向向量，不受縮放影響
        print(this.transform.TransformDirection(Vector3.forward));
        
        //  將相對於物件坐標系的(0, 0, 1)方向向量轉為世界座標的方向向量，受縮放影響
        print(this.transform.TransformVector(Vector3.forward));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
