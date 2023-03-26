using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangerBouger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouvements
        if (Input.GetKey(KeyCode.DownArrow))//Si fleche haut enfoncée alors
		{
			transform.Translate(Vector3.forward * 0.007f);//Avancer
		}
		if (Input.GetKey(KeyCode.UpArrow))//Si fleche bas enfoncée alors
		{
			transform.Translate(Vector3.back * 0.007f);//Reculer
		}
		if (Input.GetKey(KeyCode.LeftArrow))//Si fleche gauche enfoncée alors:
		{
			transform.Rotate(Vector3.up, -0.5f);//Tourner à gauche
		}
		if (Input.GetKey(KeyCode.RightArrow))//Si fleche droite enfoncée alors:
		{
			transform.Rotate(Vector3.up, 0.5f);//Tourner à droite
		}
    }
}
