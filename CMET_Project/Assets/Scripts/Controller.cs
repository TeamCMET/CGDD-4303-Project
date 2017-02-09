using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    Renderer r;
    Vector3 movement;
    public float speed;
    public float maxSpeed;
    public float rotateSpeed;
    bool up;
    bool down;
    bool left;
    bool right;
 
	// Use this for initialization
	void Start () {
        r = gameObject.GetComponent<Renderer>();
        r.material.color = Color.red;
        movement = Vector3.zero;
    }

    void HandleRotation()
    {
        if (up)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        else if (down)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
        else if (right)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.right);
        }
        else if (left)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.left);
        }

        if (up && right)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(1, 0, 1));
        }

        else if (down && right)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(1, 0, -1));
        }

        else if (up && left)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(-1, 0, 1));
        }

        else if (down && left)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(-1, 0, -1));
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        movement = transform.position;

        movement.x += Input.GetAxis("Horizontal") * speed;
        movement.z += Input.GetAxis("Vertical") * speed;
        Debug.Log(movement);
        //if (Input.GetKey(KeyCode.UpArrow)){
        //    movement.z +=speed;
        //    transform.rotation = Quaternion.LookRotation(Vector3.forward * Time.deltaTime);
        //    up = true;
        //    down = false;
        //}
        //else if (Input.GetKey(KeyCode.DownArrow)){
        //    movement.z -= speed;
        //    transform.rotation = Quaternion.LookRotation(Vector3.back * Time.deltaTime);
        //    up = false;
        //    down = true;
        //}

        //if (Input.GetKey(KeyCode.RightArrow)){
        //    movement.x += speed;
        //    transform.rotation = Quaternion.LookRotation(Vector3.right * Time.deltaTime);
        //    right = true;
        //    left = false;
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow)){
        //    movement.x -= speed;
        //    transform.rotation = Quaternion.LookRotation(Vector3.left * Time.deltaTime);
        //    right = false;
        //    left = true;
        //}
      //  HandleRotation();
       
        transform.position = movement;
        movement.Normalize();
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), rotateSpeed);

        }
       // transform.rotation = Quaternion.LookRotation(movement);
    }
}
