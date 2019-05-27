using System;

namespace CIEN
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float _x,float _y,float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public void PrintElements()
        {
            Console.WriteLine("x: "+x+", y: "+y+", z: " + z);
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }

       
    }

    public struct Image
    {
        string path;
        
        public Image(string _path)
        {
            path = _path;
        }
    }

    public class Charater
    {
        //position scale rotation
        public Vector3 position;
        public Vector3 scale;
        public Vector3 rotation;

        public int health;
        public int mana;
        public int damage;
        public bool isDead;
        public string name;
        public Image myCharactorImage;

        public void SetPosition(Vector3 targetPos)
        {
            position = targetPos;
        }
        
        public void Move(Vector3 direction)
        {
            SetPosition(new Vector3(position.x + direction.x, position.y + direction.y, position.z + direction.z));
        }

        public virtual bool Skill(string SkillType)
        {
            if (SkillType == "throw")
            {
                Console.WriteLine("Skill Throw");
                return true;
            }
            else if (SkillType == "shield")
            {
                Console.WriteLine("Skill Throw");
                return true;
            }
            else if (SkillType == "fireball")
            {
                Console.WriteLine("Skill fireball");
                return true;
            }
            else
            {
                Console.WriteLine("Error, unrecognized skillType");
                return false;
            }
        }

        public void Die()
        {
            isDead = true;

            //그 외의 필요한 작업들
            health = 100;
            mana = 100;
        }

        public Charater(Vector3 _pos, Vector3 _rot, Vector3 _scale, int _hp, int _mana,int _damage,bool isDead,string _name,Image _img)
        {
            position = _pos;
            rotation = _rot;
            scale = _scale;
            health = _hp;
            mana = _mana;
            damage = _damage;
            this.isDead = isDead;
            name = _name;
            myCharactorImage = _img;
        }
    }
    
}
