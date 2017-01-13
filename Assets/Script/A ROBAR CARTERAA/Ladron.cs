using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladron : MonoBehaviour {

    GameObject pringao;
    Cartera cartera_pringao;

	// Use this for initialization
	void Start () {

       pringao = GameObject.Find("Richard");

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Espacio Pulsado");
            cartera_pringao = pringao.GetComponent<Cartera> ();
			cartera_pringao.donacion (5);

        }
		
	}
}
