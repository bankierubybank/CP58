using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    //player position
    public PlayerController thePlayer;
    private Vector3 lastPlayerPosition;

    //camera distance
    private float distanceToMove;

	// Use this for initialization
	void Start () {

        //player position
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        
        //camera
        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = thePlayer.transform.position;
	}
}
