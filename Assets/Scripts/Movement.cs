using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject linkZelda;
    public float speed = 5f;
    private Rigidbody2D linkRB;
    // Start is called before the first frame update
    void Start()
    {
        linkRB = linkZelda.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            linkRB.AddForce(new Vector2(0, 10));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            linkRB.AddForce(new Vector2(1, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            linkRB.AddForce(new Vector2(-1, 0));
        }
    }
}
