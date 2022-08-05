using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2 : MonoBehaviour
{
    string heroName = "iron man";
    float heroHeight = 1.85f;
    int heroAge = 29;
    string heroSuperPower = "powered armor";

    string villianName = "Doctor doom";
    float villianHeight = 1.88f;
    int villianAge = 40;
    string villianSuperPower = "superhuman strength";

    // Start is called before the first frame update
    void Start()
    {
    int ageDifference = heroAge - villianAge;

    print("the hero's name is " + heroName + " his age is " + heroAge);
    print(" his height is " + heroHeight + " and his superppower is " + heroSuperPower);

    print(" the villians name is" + villianName + " his age is " + villianAge);
    print(" his height is " + villianHeight + " and his superpower is " + villianSuperPower);

    print("and the age difference between the hero and villian is" + ageDifference);

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
