using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Animator playerAnimator; 
    [SerializeField] private GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        
        TriggerCheerAnimation();
        gameManager.OpenCompletePanel();
    }

    private void TriggerCheerAnimation()
    {
        playerAnimator.SetBool("ScoredGoal", true);
    }
}

