using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class RotatorScript : MonoBehaviour
{

    public float rotationSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //this.GetComponent<Transform>().Rotate(0,rotationSpeed,0);
      if(Input.GetKey(KeyCode.R)) {
        this.GetComponent<Transform>().Rotate(0,rotationSpeed,0);
      }
      if(Input.GetKey(KeyCode.T)) {
        this.GetComponent<Transform>().Rotate(0,-rotationSpeed,0);
      }
    }

    public void Rotate1(InputAction.CallbackContext context) {
      this.GetComponent<Transform>().Rotate(0,rotationSpeed,0);
    }

    public void Rotate2(InputAction.CallbackContext context) {
      this.GetComponent<Transform>().Rotate(0,-rotationSpeed,0);
    }
}
