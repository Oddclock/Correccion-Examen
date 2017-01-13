using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explota : MonoBehaviour {

    public GameObject BaseNave;
    public GameObject Explosion;
    public Animator panel_animator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D (Collision2D col){

        panel_animator.SetBool ("Visible", true);
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy (BaseNave);
        Destroy (gameObject);
    }
}
