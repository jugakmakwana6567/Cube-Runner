using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private Vector3 offset;
    private void Update()
    {

        Vector3 newposition = new Vector3(transform.position.x, transform.position.y, offset.z + target.position.z);
        transform.position = newposition;

    }
}
