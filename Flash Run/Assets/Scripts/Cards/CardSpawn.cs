using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawn : MonoBehaviour
{
   private IColldawnService _colldawnService;
    private Vector3 _direction;
 
    public void SetDirection(Vector3 direction, IColldawnService colldawnService)
    {
        _direction = direction;
        _colldawnService = colldawnService;
    }

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(_direction * 10, ForceMode.Impulse);
       StartCoroutine(_colldawnService.CooldawnForTime());
    }
}
