using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float timer = 0;
    public float SpawnRate = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {   if (timer < SpawnRate) {
            timer = timer +Time.deltaTime;
        }
        else {
            Spawn();
            timer = 0;
        }
       
    }
    void Spawn()
    {
        float lowestpoint = transform.position.y - 8;
        float highestpoint = transform.position.y + 8;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint), 0), transform.rotation);
    }
}
