using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Classes {

    Warrior = 0,
    Wizard = 1,
    Archer = 2
}

[System.Serializable]
public class Classe
{
    public Classes classeBase;
    public Raças raceChar;
    public Atributos atributos;
}
