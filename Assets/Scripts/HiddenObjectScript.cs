using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class HiddenObjectScript : MonoBehaviour
{
    private float gazeDuration = 0f;
    private bool isCubeHidden = false;

    // Update is called once per frame
    void Update()
    {
        
        //Check if user is gazing at the cube
        if (IsGazingAtCube())
        {
            gazeDuration += Time.deltaTime;

            // If the gaze duration reaches 2 seconds and the cube is not hidden, hide the cube
            if (gazeDuration >= 2f && !isCubeHidden)
            {
                HideCube();
            }
        }
        else
        {
            //Reset the gaze duration if the user looks away from the cube
            gazeDuration = 0f;
        }
    }

    //Check if the users gaze is withing the bounds of the cube
    private bool IsGazingAtCube()
    {
        Collider cubeCollider = GetComponent<Collider>();
        Ray ray = Camera.main.ScreenPointToRay(TobiiAPI.GetGazePoint().Screen);
        RaycastHit hit;

        return cubeCollider.Raycast(ray, out hit, Mathf.Infinity);
    }

    //Hides the Cube
    private void HideCube()
    {
        gameObject.SetActive(false);
        isCubeHidden = true;
    }
}
