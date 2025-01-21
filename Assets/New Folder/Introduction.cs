using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int STR;
    public int healthPoints;
    public int Damage;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");
        healthPoints = 5 * STR;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (healthPoints< 0)
        {
            Debug.Log("Aww man... You Died! :(");
            healthPoints = 0;
        }
    }
    void TakeDamage()
    {
        healthPoints = healthPoints - Damage;

    }
}
