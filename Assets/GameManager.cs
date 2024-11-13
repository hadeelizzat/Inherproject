using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player subhi = new Player("subhi", 60);
        Enemy Zarifeh = new Enemy("Zarifeh", 100);
        subhi.Heal(25);
        Zarifeh.Attack(60, subhi);
        
    }


}
