using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JambeCommande : MonoBehaviour
{
    public GameObject Jambe;


    void Update()
    {
        float input = Input.GetAxis("Jambe");
        EtatJambe rotationEtat = MoveStateForInput(input);
        JambeControleur controller = Jambe.GetComponent<JambeControleur>();
        controller.rotationEtat = rotationEtat;

        
    }

    EtatJambe MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatJambe.Positif;
        }
        else if (input < 0)
        {
            return EtatJambe.Negatif;
        }
        else
        {
            return EtatJambe.Fixe;
        }
    }
}
