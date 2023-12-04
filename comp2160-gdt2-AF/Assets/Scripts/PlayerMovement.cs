using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerActions actions;
    private InputAction movementInput;
    private InputAction runningInput;
    private Animator animator; 
    public bool canMove = true;
    private Vector3 moveDirection;
    [SerializeField] private float speed;
    [SerializeField] private float turningRate;
    private float runSpeed = 1;
    [SerializeField] private float maxRunSpeed;

    void Awake()
    {
        actions = new PlayerActions();
        movementInput = actions.Moving.movement;
        runningInput = actions.Moving.running;
        runningInput.performed += OnRunning;
        runningInput.canceled += EndRunning;
        animator = GetComponent<Animator>(); 
    }

    void OnEnable()
    {
        movementInput.Enable();
        runningInput.Enable();
    }

    void OnDisable()
    {
        movementInput.Disable();
        runningInput.Disable();
    }

    void OnRunning(InputAction.CallbackContext context)
    {
        runSpeed = maxRunSpeed;
        animator.SetBool("IsRunning", true);
    }

    void EndRunning(InputAction.CallbackContext context)
    {
        runSpeed = 1;
        animator.SetBool("IsRunning", false);
    }

    void Start()
    {     
        animator.SetBool("IsRunning", false); 
    }

    void Update()
    {
        moveDirection = new Vector3(movementInput.ReadValue<Vector2>().x, 0, movementInput.ReadValue<Vector2>().y);
        bool isMoving = moveDirection.sqrMagnitude > 0;
        moveDirection *= (speed * runSpeed * Time.deltaTime);

        if (canMove)
        {
            if (isMoving)
            {
                transform.Translate(moveDirection, Space.World);

                
                Quaternion turn = Quaternion.LookRotation(moveDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, turn, turningRate * Time.deltaTime);

                
                if (runSpeed > 1)
                {
                    animator.SetBool("IsWalking", false);
                    animator.SetBool("IsRunning", true);
                }
                else
                {
                    animator.SetBool("IsWalking", true);
                    animator.SetBool("IsRunning", false);
                }
            }
            else
            {
                
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsRunning", false);
            }
        }
        else
        {
            
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsRunning", false);
        }
    }

}

