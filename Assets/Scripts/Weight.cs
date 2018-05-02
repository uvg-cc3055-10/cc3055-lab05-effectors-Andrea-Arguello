using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
    //Atributos
    LineRenderer line;
    DistanceJoint2D distanceJoint;

	// Use this for initialization
	void Start () {
        //Une la pesa y la plataforma
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //Crea la linea entre la pesa y la plataforma
        line.SetPosition(0, transform.position);
        line.SetPosition(1, distanceJoint.connectedBody.transform.position);
    }
}
