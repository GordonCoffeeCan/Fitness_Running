using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {

    private Transform gear;

    private float mouseX = 0;
    private float mouseY = 0;

    private const float PrefixSPEED = 30;

    private float physicalSpeed = 0;
    private float gearSpeed = 0;

    private void Awake() {
        gear = this.transform;
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        if (Mathf.Abs(mouseY) > 0) {
            physicalSpeed = 1f / Mathf.Abs(mouseY);
            gearSpeed = Mathf.Lerp(gearSpeed, physicalSpeed, 0.01f);
        } else {
            gearSpeed = Mathf.Lerp(gearSpeed, 0, 0.3f);
        }

        
        Debug.Log(gearSpeed);
    }

    private void FixedUpdate() {
        gear.Rotate(new Vector3(0, 0, gearSpeed * PrefixSPEED));
    }
}
