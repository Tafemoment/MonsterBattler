using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    publid enum Roster
    {
        Player,
        Ai
    }

    public int currentTurn = 0;

    public Roster[] turnOrder;

    private void Awake()
    {
        currentTurn = 0;
        SetupTurnOrder();
    }

    public void SetupTurnOrder()
    {
        turnOrder = new Roster[2];
        turnOrder[0] = Roster.Player;
        turnOrder[1] = Roster.Ai;
    }

    public void NextTurn()
    {
        currentTurn++;
        currentTurn %= turnOrder.Length;
        return turnOrder[currentTurn];
    }

    public bool isMyTurn(Roster me)
    {
        return turnOrder[currentTurn] == me;

    }

}
