using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private Transform playerB;

    public int playerSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        playerB = transform;

        playerB.position = new Vector3(-3, -3, -1);


    }

    // Update is called once per frame
    void Update()
    {
        
        playerB.Translate(transform.right * playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);



    }
}
