
using UnityEngine;

public class Enemymanager : MonoBehaviour
{
    [Header("怪物1")]
    public Enemy monster1;
    [Header("怪物2")]
    public Enemy monster2;
    
    private void Start()
    {
        print(monster1.Mp) ;
        print(monster2.Equip);

        monster1.Hp = 100;
        monster2.Hp = 300;
        monster1.Defence =  50;
        monster1.Weapon = "木棍";
        monster2.Weapon = "短刀";
        monster1.key = true;
        monster2.chest = true;
            
    }
}
