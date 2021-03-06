using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss : log
{
    public GameObject righthit;
    public GameObject lefthit;
    public GameObject uphit;
    public GameObject downhit;




    // Update is called once per frame
    void Update()
    {

    }

    public override void CheckDistance()
    {
        if (Vector3.Distance(target.position,
                            transform.position) <= chaseRadius
             && Vector3.Distance(target.position,
                               transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk
                && currentState != EnemyState.stagger)
            {
                Vector3 temp = Vector3.MoveTowards(transform.position,
                                                         target.position,
                                                         moveSpeed * Time.deltaTime);
                changeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);
                ChangeState(EnemyState.walk);
            }
        }
        else if (Vector3.Distance(target.position,
                    transform.position) <= chaseRadius
                    && Vector3.Distance(target.position,
                    transform.position) <= attackRadius)
        {
            if (currentState == EnemyState.walk
            && currentState != EnemyState.stagger)
            {

                StartCoroutine(AttackCo());
            }
        }

    }

    public IEnumerator AttackCo()
    {
        currentState = EnemyState.attack;
        anim.SetBool("attack", true);

        if (target.position.x - transform.position.x > 0)
        {
            righthit.SetActive(true);
        }

        if (target.position.y - transform.position.y > 0)
        {
            uphit.SetActive(true);
        }

        if (target.position.x - transform.position.x < 0)
        {
            lefthit.SetActive(true);
        }

        if (target.position.y - transform.position.y < 0)
        {
            downhit.SetActive(true);
        }

        yield return new WaitForSeconds(1f);
        currentState = EnemyState.walk;
        anim.SetBool("attack", false);

        lefthit.SetActive(false);
        righthit.SetActive(false);
        uphit.SetActive(false);
        downhit.SetActive(false);
    }



}
