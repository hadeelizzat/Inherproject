using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player subhi =new Player("subhi",90);
        Enemy Zarifeh=new Enemy("lama",100);
        subhi.Heal(20);
        Zarifeh.Attack(120);
        
    }


}
