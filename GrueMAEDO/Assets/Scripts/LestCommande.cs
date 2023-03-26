using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LestCommande : MonoBehaviour
{
    public GameObject Lest;
    public string axe;

    void Update()
    {
        float input = Input.GetAxis(axe);
        EtatLest moveState = EtatTranslationPrInput(input);
        LestControleur controller = Lest.GetComponent<LestControleur>();
        controller.translationEtat = moveState;


    }

    EtatLest EtatTranslationPrInput(float input)
    {
        if (input > 0)
        {
            return EtatLest.Positif;
        }
        else if (input < 0)
        {
            return EtatLest.Negatif;
        }
        else
        {
            return EtatLest.Fixe;
        }
    }
}
