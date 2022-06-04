using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn startingPawn;
    Pawn possessedPawn;

    protected virtual void Start()
    {
        if (startingPawn != null) PossessPawn(startingPawn);
    }
    /// <summary>
    /// Forces this controller to lose control of it's current Pawn
    /// </summary>
    public void ForceUnpossess()
    {
        possessedPawn.Unpossess();
        possessedPawn = null;
    }

    /// <summary>
    /// Attempts to Possess a given Pawn
    /// </summary>
    /// <param name="newPawn">The Pawn to attempt possession</param>
    /// <returns> Returns True if the Pawn is successfully Possessed</returns>
    public virtual bool PossessPawn(Pawn newPawn)
    {
        if (newPawn.Possess(this)) return true;
        else return false;
    }
}
