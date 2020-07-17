using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class plant : MonoBehaviour {

    [SerializeField]
    protected int hp;
    protected float timer;
    public GameObject smoke;


    [SerializeField] private bool die_flag = false;

    public bool getDieFlag()
    {
	    return die_flag;
    }

	void Start () {
		
	}
	
	void Update () {
        
	}

    public void updateHp(int amount) {
        hp += amount;
        if (hp <= 0) {
            Instantiate(smoke, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
    public void updateHp_with_Substitude(int amount) {
	    hp += amount;
	    if (hp <= 0)
	    {
		    die_flag = true;
	    }
    }

    public int getHp()
     {
        return hp;
     }
    
    public void setHp(int hp)
    {
	    this.hp = hp;
    }
}
