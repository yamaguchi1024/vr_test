using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycontrol : MonoBehaviour {

  // Use this for initialization
  void Start () {
  }

  private float x;
  private float y;
  private Vector3 rotateValue;

  void Update()
  {
    transform.position += transform.forward * Input.GetAxis("Vertical");
    transform.position += transform.right * Input.GetAxis("Horizontal");

    y = Input.GetAxis("MouseX");
    x = Input.GetAxis("MouseY");
    Debug.Log(x + ":" + y);
    rotateValue = new Vector3(x, y * -1, 0);
    transform.eulerAngles = transform.eulerAngles - rotateValue;
  }
}
