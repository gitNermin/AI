using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPerson : MonoBehaviour
{
    [SerializeField]
    float _movementSpeed = 1;
    
    CharacterController _characterController;


    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = (transform.forward * vertical + transform.right * horizontal) * (_movementSpeed*Time.deltaTime);
        //transform.rotation = Quaternion.LookRotation(movement);
        _characterController.Move(movement);
    }
}
