using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public enum state
{
    Skill1,
    Skill2,
    Skill3
}
public class CharacterScripts : MonoBehaviour
{
    public PlayerSOs character;

    int health;

    public GameObject AoECircle;

    public NavMeshAgent agent;

    public bool parryBuff = false;

    SpriteRenderer image;

    public Animator anim;
    // Start is called before the first frame update
    
    void Start()
    {
        //image = GetComponent<SpriteRenderer>();
        //image.sprite = character.art;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
