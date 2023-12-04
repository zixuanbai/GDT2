using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; 
    public Transform ball; 
    public GameObject arrowSprite; 
    public float height = 5f; 
    public float distance = 4f; 
    public float aimHeight = 10f; 
    public float aimDistance = 10f; 
    public float smoothTime = 0.3f; 
    public float lookAtHeightOffset = 1f; 

    private Vector3 offset;
    private Vector3 aimOffset;
    private Vector3 velocity = Vector3.zero;
    private bool isAiming = false;

    void Start()
    {
        
        offset = new Vector3(0, height, -distance);
        aimOffset = new Vector3(0, aimHeight, -aimDistance);
        transform.position = player.position + offset;
        transform.LookAt(player.position);
        arrowSprite.SetActive(false); 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isAiming = true; 
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isAiming = false; 
        }
    }

    void LateUpdate()
    {
       
        Vector3 desiredPosition = isAiming ? player.position + aimOffset : player.position + offset;
        
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        transform.position = smoothPosition;
        
        transform.LookAt(player.position + Vector3.up * lookAtHeightOffset);

        UpdateArrowVisibility();
    }

    
    private void UpdateArrowVisibility()
    {
        Vector3 ballScreenPosition = Camera.main.WorldToScreenPoint(ball.position);
        bool isBallOffScreen = ballScreenPosition.x <= 0 || ballScreenPosition.x >= Screen.width ||
                               ballScreenPosition.y <= 0 || ballScreenPosition.y >= Screen.height;
        bool isBallBehindCamera = ballScreenPosition.z < 0; 

       
        arrowSprite.SetActive(isBallOffScreen || isBallBehindCamera);

        if (isBallOffScreen || isBallBehindCamera)
        {
            
            if (isBallBehindCamera)
            {
                ballScreenPosition.x = Screen.width / 2; 
                ballScreenPosition.y = 0; 
            }
            else
            {
                
                ballScreenPosition.x = Mathf.Clamp(ballScreenPosition.x, 0, Screen.width);
                ballScreenPosition.y = Mathf.Clamp(ballScreenPosition.y, 0, Screen.height);
            }

            
            arrowSprite.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(
                ballScreenPosition.x, ballScreenPosition.y, Camera.main.nearClipPlane + 0.01f));

            
            Vector3 direction = isBallBehindCamera ?
                                (Camera.main.transform.forward * -1) : 
                                (ball.position - Camera.main.transform.position).normalized; 

            
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            arrowSprite.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90)); 
        }
    }
}

