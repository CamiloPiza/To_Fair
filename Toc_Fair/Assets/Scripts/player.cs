using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float HorizontalMove;
    public float verticalMove;
    public CharacterController player;
    

    void Start()
    {
        player = GetComponent<CharacterController>()
;    }

    
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Verticcal");
    }

    private void FixedUpdate()
    {
        
    }
}
