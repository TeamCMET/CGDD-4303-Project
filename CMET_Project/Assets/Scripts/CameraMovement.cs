using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    Transform target;
    Vector3 targetPos;
    private Vector3 vel;
    public float smoothTime = 0.3f;
	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        vel = Vector3.zero;
	}

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(target.position.x, target.position.y + 10, target.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref vel, smoothTime);

    }
}
