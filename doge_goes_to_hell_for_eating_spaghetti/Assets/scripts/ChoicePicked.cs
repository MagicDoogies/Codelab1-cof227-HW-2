using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePicked : MonoBehaviour
{
    public GameObject Wife;
    public GameObject Sonic;
    public GameObject Dog;

    public GameObject DogText;
    public GameObject SonicText;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("You choose edge" + ChoicePoints.Edge);
        Debug.Log("You choose normie" + ChoicePoints.Normie);
        Debug.Log("You choose soft" + ChoicePoints.Soft);
        Debug.Log("You choose trash" + ChoicePoints.Trash);

    }
    private void OnTriggerEnter(Collider other)
    {
        // if the objects have these tags give points to the player accordingly.
        if (tag == "edge")
        {
            ChoicePoints.Edge += 1;
            
        }
        if (tag == "normie")
        {
            ChoicePoints.Normie += 1;
            
        }
        if (tag == "soft")
        {
            ChoicePoints.Soft += 1;
            
        }
        if (tag == "trash")
        {
            ChoicePoints.Trash += 1;
            
        }
        // once the player chooses a character and immediatly hits the hidden barrier the choices will disappear.
        if (tag == "wife")
        {
            Wife.SetActive(false);
            SonicText.SetActive(true);
        }
        if (tag == "dog")
        {
            Dog.SetActive(false);
            DogText.SetActive(false);
        }
        if (tag == "sonic")
        {
            Sonic.SetActive(false);
            SonicText.SetActive(false);
            DogText.SetActive(true);
        }

    }
}

