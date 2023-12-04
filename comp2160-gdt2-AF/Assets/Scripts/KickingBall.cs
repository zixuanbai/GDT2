using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KickingBall : MonoBehaviour
{
    public GameObject ball;
    public float grabDistance = 2.0f;
    public float kickStrength = 5.0f;
    private bool isGrabbing = false;
    private Rigidbody ballRigidbody;
    private PlayerMovement playerMovement; 
    private LineRenderer trajectoryLineRenderer;
    public int trajectorySegments = 20;
    private Animator animator;
    public float maxPitch = 45.0f;
    public float maxYaw = 45.0f;
    private float currentPitch = 0.0f;
    private float currentYaw = 0.0f;
    private int kicksCounter = 0;

    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
        playerMovement = GetComponent<PlayerMovement>();
        trajectoryLineRenderer = ball.GetComponent<LineRenderer>();
        trajectoryLineRenderer.enabled = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, ball.transform.position);
        bool withinGrabDistance = distance <= grabDistance;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (playerMovement != null)
                playerMovement.canMove = false;

            if (withinGrabDistance)
            {
                
                isGrabbing = true;
                ballRigidbody.isKinematic = true;
                animator.SetTrigger("Interact");
                trajectoryLineRenderer.enabled = true;
                ShowTrajectory(CalculateKickForce());
            }
            else
            {
                
                isGrabbing = false;
                trajectoryLineRenderer.enabled = false;
            }
        }

        if (isGrabbing)
        {
            AdjustKickDirection();
            ShowTrajectory(CalculateKickForce());

            if (Input.GetKeyUp(KeyCode.Space))
            {
                
                isGrabbing = false;
                ballRigidbody.isKinematic = false;
                animator.SetTrigger("Throw");
                KickTheBall(CalculateKickForce());
                trajectoryLineRenderer.enabled = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            if (playerMovement != null)
                playerMovement.canMove = true;
        }
    }


    Vector3 CalculateKickForce()
    {
        
        Quaternion horizontalRotation = Quaternion.Euler(0, transform.eulerAngles.y + currentYaw, 0);
        Vector3 horizontalDirection = horizontalRotation * Vector3.forward;

        
        Vector3 verticalDirection = Quaternion.Euler(-currentPitch, 0, 0) * Vector3.up;

        
        Vector3 finalDirection = horizontalDirection + verticalDirection;
        finalDirection = finalDirection.normalized; 

        return finalDirection * kickStrength;
    }



    void AdjustKickDirection()
    {

        float adjustSpeed = 50.0f; 

        if (Input.GetKey(KeyCode.W))
        {
            currentPitch = Mathf.Clamp(currentPitch + adjustSpeed * Time.deltaTime, -maxPitch, maxPitch);
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentPitch = Mathf.Clamp(currentPitch - adjustSpeed * Time.deltaTime, -maxPitch, maxPitch);
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentYaw = Mathf.Clamp(currentYaw - adjustSpeed * Time.deltaTime, -maxYaw, maxYaw);
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentYaw = Mathf.Clamp(currentYaw + adjustSpeed * Time.deltaTime, -maxYaw, maxYaw);
        }

    }

    void KickTheBall(Vector3 force)
    {
        
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;

        ballRigidbody.AddForce(force, ForceMode.Impulse);

        currentPitch = 0.0f;
        currentYaw = 0.0f;

        
        kicksCounter++;
    }

    void ShowTrajectory(Vector3 force)
    {
        Vector3[] trajectoryPoints = new Vector3[trajectorySegments];
        Vector3 startingVelocity = force / ballRigidbody.mass;

        for (int i = 0; i < trajectorySegments; i++)
        {
            float time = i * Time.fixedDeltaTime * 5;
            trajectoryPoints[i] = ball.transform.position + startingVelocity * time + Physics.gravity * time * time / 2f;
            
        }

        trajectoryLineRenderer.positionCount = trajectorySegments;
        trajectoryLineRenderer.SetPositions(trajectoryPoints);
    }

    public int KickingBallCounter
    {
        get { return kicksCounter; }
        set { kicksCounter = value; }
    }
}






