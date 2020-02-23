using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour
{
    public GameObject JudgementTrash;
    public GameObject JudgementEdge;
    public GameObject JudgementNormie;
    public GameObject JudgementSoft;
    public GameObject JudgementUndecided;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if either choices total to zero or one you get the undecided judgement.
        if (ChoicePoints.Trash == 0 || ChoicePoints.Trash == 1)
        {
            JudgementUndecided.SetActive(true);
        }
        else
        if (ChoicePoints.Edge == 0 || ChoicePoints.Edge == 1)
        {
            JudgementUndecided.SetActive(true);
        }
        else
        if (ChoicePoints.Normie == 0 || ChoicePoints.Normie == 1)
        {
            JudgementUndecided.SetActive(true);
        }
        else
        if (ChoicePoints.Soft == 0 || ChoicePoints.Soft == 1)
        {
            JudgementUndecided.SetActive(true);
        }

        //otherwise if a given choice has two or more points they get their respective judgements.
        if (ChoicePoints.Trash >= 2)
        {
            JudgementTrash.SetActive(true);
            JudgementEdge.SetActive(false);
            JudgementNormie.SetActive(false);
            JudgementSoft.SetActive(false);
            JudgementUndecided.SetActive(false);
        }
        if (ChoicePoints.Soft == 2 || ChoicePoints.Soft == 3)
        {
            JudgementSoft.SetActive(true);
            JudgementTrash.SetActive(false);
            JudgementEdge.SetActive(false);
            JudgementNormie.SetActive(false);
            JudgementUndecided.SetActive(false);
        }
        if (ChoicePoints.Edge == 2 || ChoicePoints.Edge == 3)
        {
            JudgementEdge.SetActive(true);
            JudgementNormie.SetActive(false);
            JudgementSoft.SetActive(false);
            JudgementUndecided.SetActive(false);
            JudgementTrash.SetActive(false);
        }
        if (ChoicePoints.Normie == 2 || ChoicePoints.Normie ==3)
        {
            JudgementNormie.SetActive(true);
            JudgementSoft.SetActive(false);
            JudgementUndecided.SetActive(false);
            JudgementTrash.SetActive(false);
            JudgementEdge.SetActive(false);
        }
    }
}
