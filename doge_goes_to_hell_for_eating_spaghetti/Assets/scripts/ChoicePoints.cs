using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChoicePoints : MonoBehaviour
{
    //points system for each choice
    public static float Trash = 0;
    public static float Edge = 0;
    public static float Normie = 0;
    public static float Soft = 0;

    public static bool GameOver = false; //switch that tells game when it's ended for restart.

    //referenced game objects so I can toggle on and off the different endings text.
   /* public GameObject JudgementTrash;
    public GameObject JudgementEdge;
    public GameObject JudgementNormie;
    public GameObject JudgementSoft;
    public GameObject JudgementUndecided;*/

    public float EndTimer = 0;
    public float StartTimer = 15;

    private int SceneIndex = 0;

    public static ChoicePoints instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (GameOver == false)
        {
            if (instance == null)
            {
                instance = this;
            }
            else
    if (instance != null)
            {
                Destroy(this.gameObject);
            }
        }

    }
    void Start()
    {
        SceneIndex = SceneManager.GetActiveScene().buildIndex;
     
    }

    // Update is called once per frame
    void Update()
    {
       

        Debug.Log("Final Results" + Trash + Edge + Soft + Normie);
     
        if (SceneIndex == 1)
        {
            RestartTimer();
            
        }

         void RestartTimer()
        {
            StartTimer -= 1 * Time.deltaTime;//timer begins countdown.

            if (StartTimer <= EndTimer)//when timer hits zero set the boolean to true.
            {
                GameOver = true;
                StartTimer = 15;
            }

            if (GameOver == true)
            {
                Trash = 0;
                Soft = 0;
                Edge = 0;
                Normie = 0;
                GameOver = false;
                SceneManager.LoadScene("Hell");
            }
        }
    }
}
