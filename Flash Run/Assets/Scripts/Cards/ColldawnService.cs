using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColldawnService : IColldawnService
{
    public bool cooldawn;
    public bool GetColldawnStatus()
    {
        return cooldawn;
    }

    public void CooldawnTillDestroy()
    {
        cooldawn = true;
    }
    public void CancelCooldawn()
    {
        cooldawn = false;
    }

    public IEnumerator CooldawnForTime()
    {
        cooldawn = true;
        yield return new WaitForSeconds(1f);
        cooldawn = false;
    }

}


public interface IColldawnService
{
    public bool GetColldawnStatus();
    public void CooldawnTillDestroy();
    public void CancelCooldawn();
    public IEnumerator CooldawnForTime();
}