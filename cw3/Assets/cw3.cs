using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string heroName = "aisha";
    int heroPower = 10;

    string villianName = "lulu";
    string villianPower = 12;


    float playerSpeed = (3.5f);

    // Start is called before the first frame update
    void Start()
    {
         setSpeed(2.5f);
        CompareSpeed(20,10);

        
       if (heroPower > villianPower)
       {
           print(heroName + "is stronger");
       }
       else if (heroPower == villianPower)
       {
           print(heroName + "eqauls" + villianName);
       }
       else
       {
           print(villianName + "is stronger");
       }

        // Update is called once per frame
    }
    void setSpeed(float speed)
    {
        print("old speed is" + playerSpeed);
        playerSpeed = speed;
        print("new speed is" + playerSpeed);
    }
    void CompareSpeed(int speed1,int speed2)
    {
       if (speed1 > speed2)
       {
           print("speed1 is faster");
       }
       else if (speed2 > speed1)
       {
           print("speed2 is faster");
       }
       else (speed1 == speed2)
       {
           print("speed1 and speed2 are the same");
       }
    }   
}