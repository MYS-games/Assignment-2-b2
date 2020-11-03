using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    public GameObject player1;
    public GameObject player2;

    private Quaternion p1InitRotation;
    private Quaternion p2InitRotation;


    // Start is called before the first frame update
    void Start()
    {
        p1InitRotation = player1.transform.rotation;
        p2InitRotation = player2.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (player1.transform.rotation != p1InitRotation)
        {
            player1.transform.rotation = p1InitRotation;
        }
        if (player2.transform.rotation != p2InitRotation)
        {
            player2.transform.rotation = p2InitRotation;
        }
        // Player1 Movment
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player1.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player1.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player1.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player1.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        //Player2 Movment
        if (Input.GetKey(KeyCode.W))
        {
            player2.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player2.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player2.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player2.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
