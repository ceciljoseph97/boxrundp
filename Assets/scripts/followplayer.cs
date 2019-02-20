using UnityEngine;

public class followplayer : MonoBehaviour {

    public Transform player;//for mapping the player object
    public Vector3 offset;// for changing main cameras prespective view

	// Update is called once per frame
	void Update () {
        //Debug.Log(player.position);//for position
        transform.position = player.position+ offset;//adds the offset value and player current position and 
        //replaces the main camera position when object moves


	}
}
