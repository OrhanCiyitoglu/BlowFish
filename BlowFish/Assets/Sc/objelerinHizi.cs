using UnityEngine;

public class objelerinHizi : MonoBehaviour
{
    
   // float minYekseni = -4.5f;
   // float maxYekseni = 4.5f;
    public float objehizi= 10f;
    public float yoketme = -11f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position = transform.position + (Vector3.left * objehizi * Time.deltaTime);
        if (transform.position.x < yoketme)
        {
            Destroy(gameObject);
        }
    }
}
