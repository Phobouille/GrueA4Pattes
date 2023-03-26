using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrochetCommande : MonoBehaviour
{
    public GameObject Crochet;
    public string axe;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
        
        float input = Input.GetAxis(axe);
        EtatCrochet moveState = EtatTranslationPrInput(input);
        CrochetControleur controller = Crochet.GetComponent<CrochetControleur>();
        controller.translationEtat = moveState;
    }

    EtatCrochet EtatTranslationPrInput(float input)
    {
        if (input > 0)
        {
            return EtatCrochet.Positif;
        }
        else if (input < 0)
        {
            return EtatCrochet.Negatif;
        }
        else
        {
            return EtatCrochet.Fixe;
        }
    }

        void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.GetComponent<ArticulationBody>() != null)
        {
            FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedArticulationBody = Collision.articulationBody;
        }
    }
}
