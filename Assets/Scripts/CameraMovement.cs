using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPosX;

    private Vector3 tempPosY;

    [SerializeField]
    private float minX, maxX;

    [SerializeField]
    private float minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player)
            return;

        tempPosX = transform.position;
        tempPosX.x = player.position.x;

        if (tempPosX.x < minX)
        {
            tempPosX.x = minX;
        }

        if (tempPosX.x > maxX)
        {
            tempPosX.x = maxX;
        }

        transform.position = tempPosX;

        tempPosY = transform.position;
        tempPosY.y = player.position.y;

        if (tempPosY.y < minY)
        {
            tempPosY.y = minY;
        }

        if (tempPosY.y > maxY)
        {
            tempPosY.y = maxY;
        }

        transform.position = tempPosY;
    }
}
