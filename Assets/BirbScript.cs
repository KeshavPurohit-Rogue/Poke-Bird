using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStr;
    public LogicScript Logic;
    public bool BirbIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetKeyDown(KeyCode.Space) == true && BirbIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * FlapStr;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.GameOver();
        BirbIsAlive = false;
    }
}
