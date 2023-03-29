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
    public IEnumerator CooldawnForTime();
}