using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, 1);
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
        transform.Rotate(Vector3.up, Time.deltaTime * 25f * horizontalInput);
    }
}