using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 mouseStart_;
    private Vector3 mouseEnd_;
    private Vector3 Movement_;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        mouseStart_ = new Vector3();
        mouseEnd_ = new Vector3();
        Movement_ = new Vector3();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouseStart_ = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            mouseEnd_ = Input.mousePosition;
            Movement_ = (mouseStart_ - mouseEnd_);
            (Movement_.y, Movement_.z) = (Movement_.z, Movement_.y);
            rb.AddForce(Movement_, ForceMode.Impulse);
        }

        

        if(transform.position.z > 10 || transform.position.y < -5)
        {
            rb.velocity = Vector3.zero;
            mouseStart_ = Vector3.zero;
            mouseEnd_ = Vector3.zero;
            Movement_ = Vector3.zero;
            transform.position = new Vector3(0,0,-5);
        }
    }
}
