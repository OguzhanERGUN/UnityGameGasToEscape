using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float RotateThrust = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
public void Update()
    {
        ProccesInput();
        ProccesRotation();
    }
public void ProccesInput()
    {
       if (Input.GetKey(KeyCode.Space))
       {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
       } 
    }
public void ProccesRotation()
    {
        if (Input.GetKey(KeyCode.D))
            {
                ApplyRotation(-1f);
            } 
            else if(Input.GetKey(KeyCode.A))
            {
                ApplyRotation(1f);
            } 

    }
    
public void ApplyRotation(float rotationV)
{
    transform.Rotate(Vector3.forward * RotateThrust * Time.deltaTime * rotationV);
}
}
