using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatCommande : MonoBehaviour
{
    public GameObject Mat;


    void Update()
    {
        float input = Input.GetAxis("Mat Rot");
        EtatMat rotationEtat = MoveStateForInput(input);
        MatControleur controller = Mat.GetComponent<MatControleur>();
        controller.rotationEtat = rotationEtat;

        
    }

    EtatMat MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatMat.Positif;
        }
        else if (input < 0)
        {
            return EtatMat.Negatif;
        }
        else
        {
            return EtatMat.Fixe;
        }
    }
}
