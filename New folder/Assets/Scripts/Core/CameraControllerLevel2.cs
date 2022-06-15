using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerLevel2 : MonoBehaviour
{
    
    [SerializeField] private float speed;

    private float currentPosX;

    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform player;

    private void Update(){

        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

    }

    public void MoveToNewRoom(Transform _newRoom, bool ok = false){
        currentPosX = _newRoom.position.x;
        if(ok == true)
            _newRoom.GetComponent<Room>().ActivateRoom(true);   
    }

}