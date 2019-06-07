using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Rotate : MonoBehaviour
{
    public Vector3 rotation = new Vector3(20, 55, 35);
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}