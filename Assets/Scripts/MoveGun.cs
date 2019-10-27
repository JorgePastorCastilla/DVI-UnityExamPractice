using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{

    public float moveSpeed = 1.0f;
    public float rotateSpeed = 30.0f;
    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        //Debug.Log(hInput);
        transform.Translate( new Vector3( -hInput, 0, -vInput) * Time.deltaTime * moveSpeed) ;

        //transform.Rotate(new Vector3(0, hInput, 0) * Time.deltaTime * rotateSpeed);

    }
}
