using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;

    public Rigidbody rb;

    public int numeroItems = 0;

    Vector3 velocity;

    private ScoreManagement _scoreManagement;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _scoreManagement = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement of the player in x and z axes
        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);

        // Rotation of the player in the y axe with movement of the mouse
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }

    }

    void OnTriggerEnter(Collider other) 
    {

        if(other.name == "StartPoint")
        {
            Debug.Log("You've enter the world");
            GetComponent<AudioSource>().Play();
        }

        if(other.tag == "Item")
        {
            Debug.Log("You took an Item");
            Destroy(other.gameObject);
            numeroItems++;
            _scoreManagement.IncreaseScore (1);
            GetComponent<AudioSource>().Play();
            
            
        }
    }

    
}
