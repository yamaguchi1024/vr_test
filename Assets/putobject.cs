using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putobject : MonoBehaviour {

	// Use this for initialization
  private GameObject cube;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 pos = transform.position;
    pos.y = 0.0f;
    transform.position = pos;

    if (Input.GetKeyDown("space")) {
      cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
      cube.transform.position = transform.position + transform.forward;
    }
	}
}
