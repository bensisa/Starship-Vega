using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightning : MonoBehaviour {
    Collider2D Lightning;
	// Use this for initialization
	void Start () {
        Lightning = this.GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onCol()
    {
        Lightning.enabled = true;
    }
    public void offCol()
    {
        Lightning.enabled = false;
    }
    void onTriggerEnter2d(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
