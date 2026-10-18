using System;

namespace FSMConsoleApp
{
    // 1. 枚举 EnemyState：Patrol / Chase / Attack / Dead 四个状态
    enum EnemyState
    {
        Patrol,
        Chase,
        Attack,
        Dead
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. 几个字段
            EnemyState currentState = EnemyState.Patrol; // 当前状态指针，初始 Patrol
            float distance = 10f;                        // 玩家距离，初始 10（使用 float 以精确匹配 1.5 的边界条件）
            int hp = 100;                                // 血量

            // 3. 模拟玩家走位机制
            bool isPlayerApproaching = true;             // 标记玩家是否正在靠近

            // 4. 主循环控制
            int turn = 1;                                // 轮次计数器
            int maxTurns = 20;                           // 循环跑 20 轮后停

            Console.WriteLine("=== 状态机控制台模拟开始 ===\n");

            // 4. 主循环：一个 while，跑20轮
            while (turn <= maxTurns)
            {
                // 额外处理：任意状态 -> (血量<=0) -> 死亡（虽然你说可以先不做，但这可以留作扩展）
                if (hp <= 0 && currentState != EnemyState.Dead)
                {
                    currentState = EnemyState.Dead;
                }

                if (currentState == EnemyState.Dead)
                {
                    Console.WriteLine($"第{turn}轮, 距离={distance}");
                    Console.WriteLine("【死亡】状态机停止，不再切出。");
                    break;
                }

                // 步骤1：先更新 distance（玩家在靠近就减1，远离就加1；到0翻转）
                if (isPlayerApproaching)
                {
                    distance--;
                    if (distance <= 0)
                    {
                        isPlayerApproaching = false;
                    }
                }
                else
                {
                    distance++;
                }

                // 步骤2：打印 第N轮，距离=X
                Console.WriteLine($"第{turn}轮, 距离={distance}");

                // 步骤3：循环里的 switch (currentState)
                switch (currentState)
                {
                    case EnemyState.Patrol:
                        Console.WriteLine("巡逻中");
                        if (distance < 5)
                        {
                            currentState = EnemyState.Chase;
                            Console.WriteLine("  -> 距离<5，发现玩家，切换为【追击】");
                        }
                        break;

                    case EnemyState.Chase:
                        Console.WriteLine("追击中");
                        if (distance < 1.5)
                        {
                            currentState = EnemyState.Attack;
                            Console.WriteLine("  -> 距离<1.5，进入攻击范围，切换为【攻击】");
                        }
                        else if (distance > 8)
                        {
                            currentState = EnemyState.Patrol;
                            Console.WriteLine("  -> 距离>8，玩家跑远，跟丢目标，切换为【巡逻】");
                        }
                        break;

                    case EnemyState.Attack:
                        Console.WriteLine("攻击！");
                        if (distance > 1.5)
                        {
                            currentState = EnemyState.Chase;
                            Console.WriteLine("  -> 距离>1.5，玩家跑开，切换为【追击】");
                        }
                        break;
                }

                Console.WriteLine("--------------------");

                // 步骤4：轮次+1，跑到20轮结束
                turn++;
            }

            Console.WriteLine("=== 模拟结束 ===");
            Console.ReadLine();
        }
    }
}