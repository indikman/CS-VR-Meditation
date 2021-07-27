using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{


    public ParticleSystem particleIn;
    public ParticleSystem particlOut;

    ParticleSystem.EmissionModule emitIn;
    ParticleSystem.EmissionModule emitOut;

    private int breathingState;

    // Start is called before the fist frame update
    void Start()
    {
        emitIn = particleIn.emission;
        emitOut = particlOut.emission;
        emitIn.enabled = false;
        emitOut.enabled = false;

        breathingState = 0; // 0-idle, 1 - Breath in, 2- BreathOut
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("XRI_Right_GripButton") && Input.GetButton("XRI_Left_GripButton"))
        {
            breathingState = 1;
        }else if (!Input.GetButton("XRI_Right_GripButton") && !Input.GetButton("XRI_Left_GripButton"))
        {
            breathingState = 2;
        }
        else 
        {
            breathingState = 0;
        }


        //states
        switch (breathingState)
        {
            case 0:
                emitIn.enabled = false;
                emitOut.enabled = false;
                break;
            case 1:
                emitIn.enabled = true;
                emitOut.enabled = false;
                break;
            case 2:
                emitIn.enabled = false;
                emitOut.enabled = true;
                break;
            default:
                break;
        }

        
    }
}
