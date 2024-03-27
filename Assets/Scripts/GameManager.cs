using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TobiiSettings settings = new TobiiSettings();

        TobiiAPI.Start(settings);
    }

}
