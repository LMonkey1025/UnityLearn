using UnityEngine;

public class test3 : MonoBehaviour
{
    
    public Transform LookAtObj;

    void Start()
    {
        print(transform.lossyScale);
        print(transform.localScale);
        print(this.transform.eulerAngles);
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime;
        
        
        //面相世界座標0,0,0
        // this.transform.LookAt(Vector3.zero);
        
        this.transform.LookAt(LookAtObj);
        
    }
}
