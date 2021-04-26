using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHit : MonoBehaviour
{

	[SerializeField] private float damage;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("breakable"))
		{
			other.GetComponent<pot>().Smash();
		}

        if (other.CompareTag("enemy"))
        {
			other.GetComponent<Enemy>().TakeDamage(damage);
        }
	}
}


