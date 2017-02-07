using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour {
    public Transform focusTarget;
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime*10);
        transform.LookAt(focusTarget);
	}
}
