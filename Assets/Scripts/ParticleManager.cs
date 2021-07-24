using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{

    public ParticleSystem particleIn;
    public ParticleSystem particlOut;

    ParticleSystem.EmissionModule emitIn;
    ParticleSystem.EmissionModule emitOut;

    // Start is called before the fist frame update
    void Start()
    {
        emitIn = particleIn.emission;
        emitOut = particlOut.emission;
        emitIn.enabled = false;
        emitOut.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_GripButton"))
        {

            emitIn.enabled = true;
            emitOut.enabled = false;
        }
        else if (Input.GetButtonUp("XRI_Right_GripButton"))
        {
           
            emitIn.enabled = false;
            emitOut.enabled = true;
        }
        
    }
}
