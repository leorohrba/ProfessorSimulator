using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private GameObject player;

    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position;
        temp.x = player.transform.position.x;
        temp.y = player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        temp.x = player.transform.position.x;
        temp.y = player.transform.position.y;
        transform.position = temp;
    }
}
