using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisplayCycle : MonoBehaviour
{
    public GameObject[] objects; 
    private int currentIndex = 0; 

    void Start()
    {
        
        foreach (var obj in objects)
        {
            obj.SetActive(false);
        }

        
        StartCoroutine(DisplayCycle());
    }

    IEnumerator DisplayCycle()
    {
        while (true)
        {
            
            foreach (var obj in objects)
            {
                obj.SetActive(false);
            }

           
            if (objects.Length > 0)
            {
                objects[currentIndex].SetActive(true);
                currentIndex = (currentIndex + 1) % objects.Length; 
            }

           
            yield return new WaitForSeconds(5);
        }
    }
}
