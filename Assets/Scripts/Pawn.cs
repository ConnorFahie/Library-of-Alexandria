using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    private Controller currentController;

    /// <summary>
    /// Gives a given Controller possession of this Pawn
    /// </summary>
    /// <param name="newController"> The controller trying to Possess this Pawn</param>
    /// <param name="overrideCurrent">If true forces current controller to unpossess the pawn and take the given controller as it's new controller</param>
    /// <returns>Returns true if the pawn is successfully possessed</returns>
    public virtual bool Possess(Controller newController, bool overrideCurrent)
    {
        if (overrideCurrent)
        {
            currentController.ForceUnpossess();
            currentController = newController;
            return true;
        }

        return Possess(newController);
    }

    /// <summary>
    /// Gives a given Controller possession of this Pawn if it is currently not possessed
    /// </summary>
    /// <param name="newController"> The controller trying to Possess this Pawn</param>
    /// <returns>Returns true if the pawn is successfully possessed</returns>
    public virtual bool Possess(Controller newController)
    {
        if (currentController != null) return false;
        currentController = newController;
        return true;
    }

    /// <summary>
    /// Frees this pawn from it's current controller
    /// </summary>
    public virtual void Unpossess()
    {
        currentController = null;
    }
}
