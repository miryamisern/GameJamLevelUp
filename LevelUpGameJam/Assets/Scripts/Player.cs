using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 205f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //how much I am steering every single frame, it needs to be updating and changing
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, steerAmount, 0);

        transform.Translate(moveAmount, 0, 0);
    }


    void OnCollisionEnter(Collision other)
    {
        //moveSpeed = slowSpeed; 
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Obtens un Boost!");

        }


    }
}
