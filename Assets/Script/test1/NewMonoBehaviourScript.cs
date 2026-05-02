using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int n = 10;

    void Start()
    {
        for (int i = 0; i < n; i++)
        {
            Vector3 pos = new Vector3(-0.5f * i, -1 * i, 0.5f * i);
            for (int j = 0; j < (i+1) * (i+1); j++)
            {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.transform.position = pos + new Vector3(j % (i + 1) * 1, 0, j / (i + 1) * -1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}