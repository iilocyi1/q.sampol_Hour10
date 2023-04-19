using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    public float elapsedTime = 0;
    private bool isRunning = false;
    private bool isGameOver = true;


    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isRunning = true;
        isGameOver = false;

    }
    
    

    // Update is called once per frame
    void Update()
    {
        if(isRunning)
        {
            elapsedTime = elapsedTime + Time.deltaTime; 

        
        }
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

    void OnGUI()
    {
        
            if(isGameOver)
            {
                GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
                GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
                Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
                GUI.Box(rect, "Game Over");
                Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
                GUI.Label(rect2, "Good Job!");
            }
            else if(isRunning)
            {
                GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
                GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
            }
            
        
    }
}
