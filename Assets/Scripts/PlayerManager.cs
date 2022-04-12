using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        playerMovement.MoveArrowKey();
    }
}
