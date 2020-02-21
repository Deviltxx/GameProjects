using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour {

    public GameObject ShellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 20;
	public AudioClip shotAudio;

    private Transform firePosition;



	// Use this for initialization
	void Start () {
	    firePosition = transform.Find("firePosition");
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(fireKey)) 
		{
			AudioSource.PlayClipAtPoint(shotAudio,transform.position);
	        GameObject go = GameObject.Instantiate(ShellPrefab, firePosition.position, firePosition.rotation) as GameObject;
	        go.GetComponent<Rigidbody>().velocity = go.transform.forward*shellSpeed;

	    }
	}
}

