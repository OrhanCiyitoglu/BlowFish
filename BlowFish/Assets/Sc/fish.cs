using UnityEngine;
using UnityEngine.InputSystem;

public class fish : MonoBehaviour
{
    float minYekseni = -4.5f;
    float maxYekseni =  4.5f;
    public DynamicJoystick joystick;

    float speed = 15f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        float moveYJoyStick = joystick.Vertical;
        float moveYklavye= Input.GetAxis("Vertical");
        float moveSadeceY = moveYJoyStick+moveYklavye;


        Vector3 hareket = new Vector3(0, moveSadeceY, 0)*speed*Time.deltaTime;
        transform.position += hareket;
        
        float Y_sinir = transform.position.y;
        Y_sinir = Mathf.Clamp(Y_sinir,minYekseni,maxYekseni);
        
        
        transform.position=new Vector3(transform.position.x,Y_sinir,transform.position.z);






    }
}
