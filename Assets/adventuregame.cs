using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text txtComponent;

    // Start is called before the first frame update
    void Start()
    {
        txtComponent.text = ("This game is awesome!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
