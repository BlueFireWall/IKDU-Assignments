using UnityEngine;

public class IKDUAssignment1 : MonoBehaviour
{
    public int age = 20;
    public int ageIncrease = 1;

     void IncreaseAge()
    {
        Debug.Log("My age was " +age);
        age = age+1;
        Debug.Log("My age is now " + age);
    }
    void IncreaseAge(int Amount)
    {
        Debug.Log("My age was " +age);
        age = age+Amount;
        Debug.Log("My age is now " +age);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IncreaseAge();
        IncreaseAge(ageIncrease);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
