using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    //Atributos
    float time = 0f;
    float zero = 0f; //referencia para 0
    float limit = 3f;
    public GameObject areaEffector;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (time < limit)
        {
            if (time > zero)
            {
                //Activa el effector por 3 segundos
                areaEffector.gameObject.SetActive(true);
            }
            time += Time.deltaTime;
        }
        else
        {
            //Desactiva el effector por 2 segundos
            areaEffector.gameObject.SetActive(false);
            time = -2f;
        }
	}
}
