using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
  string name; // private protection 
  int health;

  public string Name
  {
    get { return name; }
    set { name = value; }
  }
  public int Health
  {

    get { return health; }
    set
    {
      if (value > 100) health = 100;
      else if (value < 0) health = 0;
      else health = value;
    }
  }
  public Character(string name, int health)
  {
    this.Name = name;
    this.Health = health;
    Debug.Log($"the name Character is {this.Name} and his health is {this.Health}");
  }

}
