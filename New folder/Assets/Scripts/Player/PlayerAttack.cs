using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;

    [SerializeField] private Transform projectilePoint;
    [SerializeField] private GameObject[] projectiles;
    private Animator anim;

    private PlayerMovement playerMovement;

    private float cooldownTimer = Mathf.Infinity;

    private void Awake(){
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update(){
        if(Input.GetMouseButton(1) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            SwordAttack();

        if(Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            ProjectileAttack();


        cooldownTimer += Time.deltaTime;
    }

    private void SwordAttack(){
        anim.SetTrigger("attack");
        cooldownTimer = 0;
    }

    private void ProjectileAttack(){
        anim.SetTrigger("projectile_attack");
        cooldownTimer = 0;

        projectiles[FindProjectile()].transform.position = projectilePoint.position;
        projectiles[FindProjectile()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));

    }

    private int FindProjectile(){
        for(int i = 0; i < projectiles.Length; i++){
            if(!projectiles[i].activeInHierarchy)
                return i;
        }
        return 0;
    }

}
