using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed; 
    public GameObject gameMenu; 
    
    float rotationX;
    
    void Update()
    {
        if (gameMenu.activeSelf) return;
        
        rotationX += rotationSpeed * Input.GetAxis("Mouse Y");
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        
        var transform1 = transform;
        var eulerAngles = transform1.eulerAngles;

        transform1.eulerAngles = new Vector3(-rotationX, eulerAngles.y, eulerAngles.z);
    }
}