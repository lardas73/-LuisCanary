using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    private CharacterController _characterController;

    public float speed = 10f;

    private float inputHorizontal, inputVertical;
    private Vector3 movePlayer;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        movePlayer = transform.right * inputHorizontal + 
            transform.forward * inputVertical;
        movePlayer *= speed * Time.deltaTime;
        _characterController.Move(movePlayer);
    }
}
