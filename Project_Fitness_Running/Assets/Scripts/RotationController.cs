using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {

    private Transform gear;

    private float mouseX;
    private float mouseY;

    private void Awake() {
        gear = this.transform;
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        gear.Rotate(new Vector3(0, 0, Mathf.Abs(mouseY)));

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        Debug.Log("X = " + mouseX + "; " + "Y = " + mouseY);
    }
}
