using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Player player;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.direction.sqrMagnitude > 0 )
        {
            anim.SetInteger("Transition", 1);
        }
        else{
            anim.SetInteger("Transition", 0);
        }
    }
}
