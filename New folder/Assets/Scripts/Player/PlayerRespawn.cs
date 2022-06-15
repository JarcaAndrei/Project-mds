using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private AudioClip checkpointSound;
    private Transform currentCheckpoint;
    private Health playerHealth;

    private Vector3 playerPos;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        playerPos = transform.position;
    }

    public void Respawn()
    {
        if(currentCheckpoint != null)
            transform.position = currentCheckpoint.position; //Move player to checkpoint location
        else{
            transform.position = playerPos;
        }


        playerHealth.Respawn(); //Restore player health and reset animation

        //Move the camera to the checkpoint's room
        if(currentCheckpoint != null){
            Camera.main.GetComponent<CameraController>().MoveToNewRoom(currentCheckpoint.parent, true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform;
            SoundManager.instance.PlaySound(checkpointSound);
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("appear");
        }
    }
}
