using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{

    Transform currentTarget;
    [SerializeField] float attackRange;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveToTarget()
    {
        //transform.Translate();
    }

    void FindNewTarget()
    {
        var colls = Physics2D.OverlapCircleAll(currentTarget.position, attackRange);

        Transform tempTarget = colls[0].transform;
        float shortestDist = Vector2.Distance(transform.position, tempTarget.position);

        foreach (var coll in colls)
        {
            float currentCheckDis = Vector2.Distance(transform.position, coll.transform.position);

            if (currentCheckDis < shortestDist)
            {
                shortestDist = currentCheckDis;
                tempTarget = coll.transform;
            }
        }

        currentTarget = tempTarget;

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, attackRange);
    }

}
