using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day9_1_Game
{
    class Tyranno
    {
        string name = "Tyranno";
        public string GetName { get { return name; } }

        int hp = 320;

        int att = 52;
        public int GetAtt { get { return att; } }

        int mp = 2;

        public int GetHP()
        {
            return hp;
        }
        public void SetHP(int hp)
        {
            this.hp = hp;
        }

        public int GetMP()
        {
            return mp;
        }

        public void SetMP(int mp)
        {
            this.mp = mp;
        }

        public void UseSkill(int skill)
        {
            string skillname = "깨물기!!";
            string ultimatename = "물어뜯기!!";

            if (skill == 1)
            {
                Console.WriteLine($"{this.name}의 {skillname}");
            }
            else if (skill == 2)
            {
                Console.WriteLine($"{this.name}의 {ultimatename}");
            }

        }

        public void PrintTyranno()
        {
            //그리기
            string[] tyranno = new string[] { " ", " ", " ", " ", " ", "█", "█", "█", "█", "█", "█", " ", " ", " ", " ",
                                              " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", " ",
                                              " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", "█", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", " ", " ", "█", " ", "█", " ", " ", "█", " ", "█", " ", " ",
                                              " ", " ", " ", " ", " ", "█", " ", "█", " ", " ", "█", " ", "█", " ", " ",
                                              " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ",
                                              " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█", " ",
                                              " ", " ", " ", " ", "█", " ", " ", "█", "█", " ", " ", "█", "█", " ", "█",
                                              " ", " ", " ", " ", "█", " ", "█", " ", " ", "█", " ", "█", " ", "█", "█",
                                              " ", " ", " ", "█", " ", " ", "█", " ", "█", " ", " ", "█", " ", " ", "█",
                                              " ", " ", " ", " ", "█", "█", " ", " ", " ", "█", "█", " ", " ", " ", " ",
            };

            for (int i = 0; i < tyranno.Length; i++)
            {
                Console.Write(tyranno[i]);
                if ((i + 1) % 15 == 0)
                    Console.WriteLine("");
            }

        }

        public void PrintInfo()
        {
            Console.WriteLine("<<Name: " + this.name + ">>");
            Console.WriteLine("준수한 체력과 높은 공격력을 가진 캐릭터");
        }

        public void PrintSkill()
        {
            Console.WriteLine("기본 공격: 깨물기");
            Console.WriteLine("스킬: 물어뜯기");
            Console.WriteLine("===================");
        }

        public void PrintStat()
        {
            Console.WriteLine("체력: " + this.hp);
            Console.WriteLine("공격력: " + this.att);

            //체력바
            string[] hpbar = new string[8];
            for (int i = 0; i < hpbar.Length; i++)
            {
                hpbar[i] = "♥";
            }

            //체력바 출력
            Console.Write("HP: ");
            for (int i = 0; i < hpbar.Length; i++)
            {
                Console.Write(hpbar[i]);

            }
            Console.WriteLine("");

            //마나바
            string[] mpbar = new string[] { "■", "■", "■" };

            //마나바 출력
            Console.Write("MP: ");
            for (int i = 0; i < mpbar.Length; i++)
            {
                Console.Write(mpbar[i]);
            }
            Console.WriteLine("");

        }

        public void PrintHPBar(int a)
        {
            string[] heart = new string[8];
            for (int i = 0; i < a; i++)
            {
                heart[i] = "♥";
                Console.Write(heart[i]);
            }
            Console.WriteLine("");
        }
        public void PrintMpBar(int a)
        {
            string[] mp = new string[] { "", "" };

            for (int i = 0; i < a; i++)
            {
                mp[i] = "■";
                Console.Write(mp[i]);
            }
            Console.WriteLine("");
        }

    }
    class Brachio
    {
        string name = "Brachio";
        public string GetName { get { return name; } }

        int hp = 520;

        int att = 25;
        public int GetAtt { get { return att; } }

        int mp = 4;

        public int GetHP()
        {
            return hp;
        }

        public void SetHP(int hp)
        {
            this.hp = hp;
        }

        public int GetMP()
        {
            return mp;
        }

        public void SetMP(int mp)
        {
            this.mp = mp;
        }

        public void UseSkill(int skill)
        {
            string skillname = "목 휘두르기!!";
            string ultimatename = "짓밟기!!";

            if (skill == 1)
            {
                Console.WriteLine($"{this.name}의 {skillname}");
            }
            else if (skill == 2)
            {
                Console.WriteLine($"{this.name}의 {ultimatename}");
            }
        }
        public void PrintBrachio()
        {

            //도트처럼 출력하기 위한 배열
            int[] brachio1 = new int[] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                         0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                         0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,
                                         0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,
                                         1,0,1,0,0,0,1,0,0,0,0,0,0,0,0,
                                         1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,
                                         0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,
                                         0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,
                                         0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,
                                         0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,
                                         0,0,1,0,0,1,1,1,1,1,1,1,0,0,0,
                                         0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,
                                         0,0,1,0,0,0,0,0,0,0,1,1,0,1,0,
                                         0,0,1,0,0,0,0,0,0,0,1,0,1,1,1,
                                         0,0,1,0,1,0,0,1,0,0,1,0,0,0,1};

            string[] brachio2 = new string[225];

            //그리기
            for (int i = 0; i < brachio1.Length; i++)
            {
                if (brachio1[i] == 0)
                {
                    brachio2[i] = " ";
                }
                else if (brachio1[i] == 1)
                {
                    brachio2[i] = "█";
                }

            }
            for (int i = 0; i < brachio2.Length; i++)
            {
                Console.Write(brachio2[i]);
                if ((i + 1) % 15 == 0)
                    Console.WriteLine("");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("<<Name: " + this.name + ">>");
            Console.WriteLine("높은 체력과 낮은 공격력을 가진 캐릭터");
        }

        public void PrintSkill()
        {
            Console.WriteLine("기본 공격: 목 휘두르기");
            Console.WriteLine("스킬: 짓밟기");
            Console.WriteLine("===================");
        }

        public void PrintStat()
        {
            Console.WriteLine("체력: " + this.hp);
            Console.WriteLine("공격력: " + this.att);

            //체력바
            string[] hpbar = new string[10];
            for (int i = 0; i < hpbar.Length; i++)
            {
                hpbar[i] = "♥";
            }

            //체력바 출력
            Console.Write("HP: ");
            for (int i = 0; i < hpbar.Length; i++)
            {
                Console.Write(hpbar[i]);
            }
            Console.WriteLine("");

            //마나바
            string[] mpbar = new string[] { "■", "■", "■", "■" };

            //마나바 출력
            Console.Write("MP: ");
            for (int i = 0; i < mpbar.Length; i++)
            {
                Console.Write(mpbar[i]);
            }
            Console.WriteLine("");

        }

        public void PrintHPBar(int a)
        {
            string[] heart = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" };

            for (int i = 0; i < a; i++)
            {
                heart[i] = "♥";
                Console.Write(heart[i]);
            }
            Console.WriteLine("");
        }
        public void PrintMPBar(int a)
        {
            string[] mp = new string[] { "", "", "", "" };

            for (int i = 0; i < a; i++)
            {
                mp[i] = "■";
                Console.Write(mp[i]);
            }
            Console.WriteLine("");
        }
    }
    class Ankylo
    {
        string name = "Ankylo";
        public string GetName { get { return name; } }

        int hp = 320;

        int att = 48;
        public int GetAtt { get { return att; } }

        int mp = 3;

        public int GetHP()
        {
            return hp;
        }

        public void SetHP(int hp)
        {
            this.hp = hp;
        }

        public int GetMP()
        {
            return mp;
        }

        public void SetMP(int mp)
        {
            this.mp = mp;
        }

        public void UseSkill(int skill)
        {
            string skillname = "몸통박치기!!";
            string ultimatename = "꼬리치기!!";

            if (skill == 1)
            {
                Console.WriteLine($"{this.name}의 {skillname}");
            }
            else if (skill == 2)
            {
                Console.WriteLine($"{this.name}의 {ultimatename}");
            }

        }
        public void PrintAnkylo()
        {

            int[] ankylo1 = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                       0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                       0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                       0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                       0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                       0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,
                                       0,0,1,0,1,0,1,0,0,1,0,1,0,1,0,
                                       0,1,0,0,0,0,1,0,1,0,1,0,1,0,1,
                                       0,1,0,1,0,0,0,1,0,0,0,0,0,0,1,
                                       0,1,0,0,0,0,1,0,0,0,1,0,1,0,1,
                                       0,0,1,1,1,0,1,0,0,1,0,1,0,1,1,
                                       0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,
                                       0,0,0,0,1,0,0,0,1,1,1,1,1,1,1,
                                       0,0,0,0,1,0,1,0,1,0,0,0,1,0,1,
                                       0,0,0,0,1,0,1,0,1,0,0,0,1,0,1 };

            string[] ankylo2 = new string[225];
            for (int i = 0; i < ankylo1.Length; i++)
            {
                if (ankylo1[i] == 0)
                {
                    ankylo2[i] = " ";
                }
                else if (ankylo1[i] == 1)
                {
                    ankylo2[i] = "█";
                }
                Console.Write(ankylo2[i]);
                if ((i + 1) % 15 == 0)
                    Console.WriteLine("");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("<<Name: " + this.name + ">>");
            Console.WriteLine("준수한 체력과 준수한 공격력을 가진 캐릭터");
        }

        public void PrintSkill()
        {
            Console.WriteLine("기본 스킬: 몸통박치기");
            Console.WriteLine("필살기: 꼬리치기");
            Console.WriteLine("===================");
        }

        public void PrintStat()
        {
            Console.WriteLine("체력: " + this.hp);
            Console.WriteLine("공격력: " + this.att);


            //체력바
            string[] hpbar = new string[8];
            for (int i = 0; i < hpbar.Length; i++)
            {
                hpbar[i] = "♥";
            }

            //체력, 마나바 출력
            Console.Write("HP: ");
            for (int i = 0; i < hpbar.Length; i++)
            {
                Console.Write(hpbar[i]);
            }
            Console.WriteLine("");

            //마나바
            string[] mpbar = new string[] { "■", "■", "■" };

            Console.Write("MP: ");
            for (int i = 0; i < mpbar.Length; i++)
            {
                Console.Write(mpbar[i]);
            }
            Console.WriteLine("");

        }

        public void PrintHPBar(int a)
        {
            string[] heart = new string[] { "", "", "", "", "", "", "", "" };

            for (int i = 0; i < a; i++)
            {
                heart[i] = "♥";
                Console.Write(heart[i]);
            }
            Console.WriteLine("");
        }

        public void PrintMpBar(int a)
        {
            string[] mp = new string[] { "", "", "" };

            for (int i = 0; i < a; i++)
            {
                mp[i] = "■";
                Console.Write(mp[i]);
            }
            Console.WriteLine("");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //=================================================//

            Massage();

            Console.WriteLine("=========캐릭터 목록========= \n\n");

            //1p 캐릭터
            Tyranno tyranno = new Tyranno();
            tyranno.PrintTyranno();
            tyranno.PrintInfo();
            tyranno.PrintStat();
            tyranno.PrintSkill();
            Thread.Sleep(4000);

            Brachio brachio = new Brachio();
            brachio.PrintBrachio();
            brachio.PrintInfo();
            brachio.PrintStat();
            brachio.PrintSkill();
            Thread.Sleep(4000);

            Ankylo ankylo = new Ankylo();
            ankylo.PrintAnkylo();
            ankylo.PrintInfo();
            ankylo.PrintStat();
            ankylo.PrintSkill();
            Thread.Sleep(4000);

            //2p 캐릭터
            Tyranno tyranno2 = new Tyranno();

            Brachio brachio2 = new Brachio();

            Ankylo ankylo2 = new Ankylo();

            //1p
            int character1;

            //2p
            int character2;

            //체력 계산을 위한 변수
            int HP;
            string[] heart = new string[10];

            //스킬
            int myskill;

            //공격자, 방어자
            int attacker;
            int defender;

            //데미지
            int damage = 0;

            //스킬포인트
            int mp = 0;

            //누구 턴인가
            bool isP1turn = true;

            //캐릭터 선택
            while (true)
            {
                Console.Write("1P 캐릭터를 선택하세요: (1)티라노사우루스 (2)브라키오사우루스 (3)안킬로사우루스: ");
                character1 = int.Parse(Console.ReadLine());
                Console.WriteLine("==================");
                if (character1 != 1 && character1 != 2 && character1 != 3)
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("2P 캐릭터를 선택하세요: (1)티라노사우루스 (2)브라키오사우루스 (3)안킬로사우루스: ");
                character2 = int.Parse(Console.ReadLine());
                Console.WriteLine("==================");
                if (character2 != 1 && character2 != 2 && character2 != 3)
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("====================");

                    continue;
                }
                break;
            }

            //게임~
            while (true)
            {
                if (isP1turn == true)
                {
                    Console.WriteLine("<<<1P의 차례>>>");

                    attacker = character1;
                    defender = character2;

                    if (character1 == 1) damage = tyranno.GetAtt;
                    else if (character1 == 2) damage = brachio.GetAtt;
                    else if (character1 == 3) damage = ankylo.GetAtt;

                    if (character1 == 1)
                    {
                        HP = tyranno.GetHP() / 40;
                        mp = tyranno.GetMP();

                        tyranno.PrintTyranno();
                        Console.Write("1P " + tyranno.GetName + "의 체력: ");
                        tyranno.PrintHPBar(HP);
                        Console.Write("1P " + tyranno.GetName + "의 마나: ");
                        tyranno.PrintMpBar(mp);
                        Console.WriteLine("--------------------");

                    }

                    else if (character1 == 2)
                    {
                        HP = brachio.GetHP() / 40;
                        mp = brachio.GetMP();

                        brachio.PrintBrachio();
                        Console.Write("1P " + brachio.GetName + "의 체력: ");
                        brachio.PrintHPBar(HP);
                        Console.Write("1P " + brachio.GetName + "의 마나: ");
                        brachio.PrintMPBar(mp);
                        Console.WriteLine("--------------------");

                    }

                    else if (character1 == 3)
                    {
                        HP = ankylo.GetHP() / 40;
                        mp = ankylo.GetMP();

                        ankylo.PrintAnkylo();
                        Console.Write("1P" + ankylo.GetName + "의 체력: ");
                        ankylo.PrintHPBar(HP);
                        Console.Write("1P " + ankylo.GetName + "의 마나: ");
                        ankylo.PrintMpBar(mp);
                        Console.WriteLine("--------------------");

                    }

                    Console.Write("어떤 공격을 하시겠습니까? (1)기본 공격 (2)스킬 사용: ");
                    myskill = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------");

                    if (myskill == 1)
                    {

                        if (attacker == 1)
                        {
                            tyranno.UseSkill(myskill);

                            if (defender == 1) tyranno2.SetHP(tyranno2.GetHP() - damage);
                            else if (defender == 2) brachio2.SetHP(brachio2.GetHP() - damage);
                            else ankylo2.SetHP(ankylo2.GetHP() - damage);

                            isP1turn = false;

                        }

                        else if (attacker == 2)
                        {
                            brachio.UseSkill(myskill);

                            if (defender == 1) tyranno2.SetHP(tyranno2.GetHP() - damage);
                            else if (defender == 2) brachio2.SetHP(brachio2.GetHP() - damage);
                            else ankylo2.SetHP(ankylo2.GetHP() - damage);

                            isP1turn = false;

                        }

                        else
                        {
                            if (defender == 1) tyranno2.SetHP(tyranno2.GetHP() - damage);
                            else if (defender == 2) brachio2.SetHP(brachio2.GetHP() - damage);
                            else ankylo2.SetHP(ankylo2.GetHP() - damage);

                            isP1turn = false;

                        }

                    }
                    else if (myskill == 2)
                    {

                        if (attacker == 1)
                        {
                            tyranno.UseSkill(myskill);

                            mp = tyranno.GetMP();

                            if(mp > 0)
                            {

                                if (defender == 1) tyranno2.SetHP(tyranno2.GetHP() - (damage + 20));
                                else if (defender == 2) brachio2.SetHP(brachio2.GetHP() - (damage + 20));
                                else ankylo2.SetHP(ankylo2.GetHP() - (damage + 20));
                                tyranno.SetMP(tyranno.GetMP()-1);

                            }
                            else
                            {
                                Console.WriteLine("마나가 부족합니다.");
                                Console.WriteLine("====================");
                                continue;
                            }
                                isP1turn = false;

                        }

                        else if (attacker == 2)
                        {
                            brachio.UseSkill(myskill);

                            mp = brachio.GetMP();

                            if(mp > 0)
                            {

                                if (defender == 1) tyranno2.SetHP(tyranno2.GetHP() - (damage + 20));
                                else if (defender == 2) brachio2.SetHP(brachio2.GetHP() - (damage + 20));
                                else ankylo2.SetHP(ankylo2.GetHP() - (damage + 20));
                                brachio.SetMP(brachio.GetMP() - 1);

                            }
                            else
                            {
                                Console.WriteLine("마나가 부족합니다.");
                                Console.WriteLine("====================");
                                continue;
                            }

                                isP1turn = false;

                        }

                        else
                        {
                            ankylo.UseSkill(myskill);

                            mp = ankylo.GetMP();

                            if(mp > 0)
                            {

                                if (defender == 1) tyranno2.SetHP(tyranno2.GetHP() - (damage + 20));
                                else if (defender == 2) brachio2.SetHP(brachio2.GetHP() - (damage + 20));
                                else ankylo2.SetHP(ankylo2.GetHP() - (damage + 20));
                                ankylo.SetMP(ankylo.GetMP() - 1);

                            }
                            else
                            {
                                Console.WriteLine("마나가 부족합니다.");
                                Console.WriteLine("====================");
                                continue;
                            }

                                isP1turn = false;

                        }

                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        continue;
                    }

                    if(tyranno2.GetHP() <=0 || brachio2.GetHP() <= 0 || ankylo2.GetHP() <= 0)
                    {
                        Console.WriteLine("P2의 패배입니다!");
                        break;
                    }

                }
                else if (isP1turn == false)
                {
                    Console.WriteLine("<<<2P의 차례>>>");

                    attacker = character2;
                    defender = character1;

                    if (character2 == 1) damage = tyranno2.GetAtt;
                    else if (character2 == 2) damage = brachio2.GetAtt;
                    else if (character2 == 3) damage = ankylo2.GetAtt;

                    //p2가 tyranno일 때
                    if (character2 == 1)
                    {
                        HP = tyranno2.GetHP() / 40;
                        mp = tyranno2.GetMP();

                        tyranno2.PrintTyranno();
                        Console.Write("1P " + tyranno2.GetName + "의 체력: ");
                        tyranno2.PrintHPBar(HP);
                        Console.Write("1P " + tyranno2.GetName + "의 마나: ");
                        tyranno2.PrintMpBar(mp);
                        Console.WriteLine("--------------------");

                    }

                    //p2가 brachio일 때
                    else if (character2 == 2)
                    {
                        HP = brachio2.GetHP() / 40;
                        mp = brachio2.GetMP();

                        brachio2.PrintBrachio();
                        Console.Write("1P " + brachio2.GetName + "의 체력: ");
                        brachio2.PrintHPBar(HP);
                        Console.Write("1P " + brachio2.GetName + "의 마나: ");
                        brachio2.PrintMPBar(mp);
                        Console.WriteLine("--------------------");

                    }

                    //p2가 ankylo일 때
                    else if (character2 == 3)
                    {
                        HP = ankylo2.GetHP() / 40;
                        mp = ankylo2.GetMP();

                        ankylo2.PrintAnkylo();
                        Console.Write("1P " + ankylo2.GetName + "의 체력: ");
                        ankylo2.PrintHPBar(HP);
                        Console.Write("1P " + ankylo2.GetName + "의 마나: ");
                        ankylo2.PrintMpBar(mp);
                        Console.WriteLine("--------------------");

                    }

                    Console.Write("어떤 공격을 하시겠습니까? (1)기본 공격 (2)스킬 사용: ");
                    myskill = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------");

                    //기본 공격 시
                    if (myskill == 1)
                    {

                        //p2가 tyranno일 때
                        if (attacker == 1)
                        {
                            tyranno2.UseSkill(myskill);

                            if (defender == 1) tyranno.SetHP(tyranno.GetHP() - damage);
                            else if (defender == 2) brachio.SetHP(brachio.GetHP() - damage);
                            else ankylo.SetHP(ankylo.GetHP() - damage);

                            isP1turn = true;

                        }

                        //p2가 brachio일 때
                        else if (attacker == 2)
                        {
                            brachio2.UseSkill(myskill);

                            if (defender == 1) tyranno.SetHP(tyranno.GetHP() - damage);
                            else if (defender == 2) brachio.SetHP(brachio.GetHP() - damage);
                            else ankylo.SetHP(ankylo.GetHP() - damage);

                            isP1turn = true;

                        }

                        //p2가 ankylo일 때
                        else
                        {
                            ankylo2.UseSkill(myskill);

                            if (defender == 1) tyranno.SetHP(tyranno.GetHP() - damage);
                            else if (defender == 2) brachio.SetHP(brachio.GetHP() - damage);
                            else ankylo.SetHP(ankylo.GetHP() - damage);

                            isP1turn = true;

                        }

                    }

                    //스킬 사용 시
                    else if (myskill == 2)
                    {

                        //p2가 tyranno일 때
                        if (attacker == 1)
                        {
                            tyranno2.UseSkill(myskill);

                            mp = tyranno2.GetMP();

                            if(mp > 0)
                            {
                                if (defender == 1) tyranno.SetHP(tyranno.GetHP() - (damage + 20));
                                else if (defender == 2) brachio.SetHP(brachio.GetHP() - (damage + 20));
                                else ankylo.SetHP(ankylo.GetHP() - (damage + 20));
                                tyranno2.SetMP(tyranno2.GetMP() - 1);
                            }
                            else
                            {
                                Console.WriteLine("마나가 부족합니다.");
                                Console.WriteLine("====================");
                                continue;
                            }

                            isP1turn = true;

                        }

                        //p2가 brachio일 때
                        else if (attacker == 2)
                        {
                            brachio2.UseSkill(myskill); 

                            mp = brachio2.GetMP();

                            if(mp > 0)
                            {

                                if (defender == 1) tyranno.SetHP(tyranno.GetHP() - (damage + 20));
                                else if (defender == 2) brachio.SetHP(brachio.GetHP() - (damage + 20));
                                else ankylo.SetHP(ankylo.GetHP() - (damage + 20));
                                brachio2.SetMP(brachio2.GetMP() - 1);

                            }
                            else
                            {
                                Console.WriteLine("마나가 부족합니다.");
                                Console.WriteLine("====================");
                                continue;
                            }
                            isP1turn = true;

                        }

                        //p2가 ankylo일 때
                        else
                        {
                            ankylo2.UseSkill(myskill);

                            mp = ankylo2.GetMP();

                            if(mp > 0)
                            {

                                if (defender == 1) tyranno.SetHP(tyranno.GetHP() - (damage + 20));
                                else if (defender == 2) brachio.SetHP(brachio.GetHP() - (damage + 20));
                                else ankylo.SetHP(ankylo.GetHP() - (damage + 20));
                                ankylo2.SetMP(ankylo2.GetMP()-1);

                            }
                            else
                            {
                                Console.WriteLine("마나가 부족합니다.");
                                Console.WriteLine("====================");
                                continue;
                            }

                            isP1turn = true;

                        }

                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.WriteLine("====================");
                        continue;
                    }

                }

                if (tyranno.GetHP() <= 0 || brachio.GetHP() <= 0 || ankylo.GetHP() <= 0)
                {
                    Console.WriteLine("P1의 패배입니다!");
                    break;
                }

            }//while 끝

        }


        public static void Massage()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("|| 이 게임은 과학적 사실을 반영하고 있지 않습니다 ||");
            Console.WriteLine("====================================================");
            Console.WriteLine("");
            Console.WriteLine("잠시 후 캐릭터 목록을 출력합니다.");

            Thread.Sleep(2300);
            Console.Clear();

            Console.WriteLine("Loading....");
            Thread.Sleep(2200);
            Console.Clear();

        }
    }
}
