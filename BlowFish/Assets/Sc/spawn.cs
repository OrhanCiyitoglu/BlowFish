using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class spawn : MonoBehaviour
{

    public GameObject[] prefabss;

    public float spwanRate = 2f;
    public float timer = 0f;

    void Start()
    {
        spawnRandomObject(prefabss);  // sadece prefab yazma rotastyon ve pozisyonu belirt daha iyi
    }

    
    void Update()
    {
        if (timer < spwanRate)
        {
            timer=timer+Time.deltaTime;
        }
        else
        {
            spawnRandomObject(prefabss);
            timer = 0f;
        }
    }
    void spawnRandomObject(GameObject[] objects)
    {
        prefabss = objects;
        int randomIndex = Random.Range(0, objects.Length);
        float RandomYSpawn= Random.Range(-4.8f,4.8f);
        Instantiate(objects[randomIndex], new Vector3( transform.position.x,RandomYSpawn,transform.position.z), transform.rotation);
    }
}
