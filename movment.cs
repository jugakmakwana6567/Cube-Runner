using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{


    // Start is called before the first frame update

    // Update is called once per frame

        float speed = 2f;
        Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = new Vector3(0, 0, 2);
            }
            else
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = new Vector3(0, 0, -2);
            }
        }

    }

