using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameController gameController;  
    public GameObject gameMenu; 

    float rotationY;
    Rigidbody rb;   
    AudioSource audio;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>(); 
    }

    void FixedUpdate() 
    {  
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical"); 
 
        var transform1 = transform; 
        var movement = moveVertical * transform1.forward + moveHorizontal * transform1.right;

        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z * speed);
    }
     
    void Update() 
    {
        if (gameMenu.activeSelf) return;
        
        rotationY += rotationSpeed * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0f, rotationY, 0f);
    }   
    
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("coins")) return;

        Destroy(other.gameObject);
        gameController.CollectCoin();
        audio.Play();
    }
}