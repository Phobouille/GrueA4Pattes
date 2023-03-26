using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatCrochet { Fixe = 0, Positif = 1, Negatif = -1 };

public class CrochetControleur : MonoBehaviour
{

    public EtatCrochet translationEtat = EtatCrochet.Fixe;
    public float vitesse = 1.0f;

    private void FixedUpdate()
    {
        if (translationEtat != EtatCrochet.Fixe)
        {
            ArticulationBody articulation = GetComponent<ArticulationBody>();

            float xDrivePostion = articulation.jointPosition[0];
            Debug.Log(xDrivePostion);

            float targetPosition = xDrivePostion + (float)translationEtat * Time.fixedDeltaTime * vitesse;

            var drive = articulation.xDrive;
            drive.target = targetPosition;
            articulation.xDrive = drive;
        }
    }
}
