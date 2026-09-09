# 学习打卡表

| 日期 | Day | 完成度 | 卡点 | 明日重点 |
|------|-----|--------|------|----------|
| 2026-09-03 | D1 | ✅ 完成 | 无 | Unity安装 + 第一个场景 |
| 2026-09-04 | D2 | ✅ 完成 | 无 | 简历骨架 + 打卡表 + 仓库整理 |
| 2026-09-05 | D3 | ✅ 完成 | 无 | 启动周收尾，进入正式学习周期 |
| 2026-09-06 | D4 | ✅ 完成 | 无 | C#流程控制 + Unity物理/碰撞入门 |
| 2026-09-08 | D5 | ✅ 完成 | 无 | C#数组与方法 + Unity预制体/脚本通信 |
| 2026-09-09 | D6 | ✅完成 | 冒泡边界/值类型交换（已解决） | D7周复盘 + 本周知识录屏回顾 |


## D1 回顾（9/3 周四）
- 环境搭建：Git、.NET SDK、VS Code 全套安装完成
- GitHub 仓库 `game-ai-demos` 创建，本地克隆成功
- C# 控制台 HelloWorld 编写并运行成功
- 首次 Git add → commit → push 全流程跑通

## D2 回顾（9/4 周五）
- Unity 安装完成，创建第一个场景 `FristScene`
- 编写 `PlayerMove.cs` 角色移动脚本（WASD 控制方向）
- 掌握 `Input.GetAxis`、`transform.Translate`、`Time.deltaTime` 基础用法

## D3 完成（9/5 周六）
- BOSS直聘简历搭建，求职方向锁定 U3D 游戏开发
- 教育经历、项目经历、专业技能、自我评价全部填写
- 建立打卡表 notes/checkin.md
- 整理仓库结构，更新 README
- 学习 Unity 核心概念：GameObject、Component、Transform

## D4 完成（9/6 周日）

- C# 基础：变量声明/赋值、6种数据类型（int/float/double/bool/string/char）
- 运算符：算术（+ - * / %）、比较（== != > <）、逻辑（&& || !）
- 控制台输入输出：Console.ReadLine() + int.Parse() 实现键盘交互
- 综合练习：输入两数计算和差积商余、判断奇偶、摄氏转华氏
- Unity Transform 实操：代码设置 position、Translate() 匀速移动
- Rotate() 绕轴旋转、WASD 键盘控制物体位移
- 新建 DailyPractice 目录管理每日练习，Git 提交推送

## D5 完成（9/8 周二）

- C# 条件：if/else if/else 多分支、switch 固定值匹配、三元运算符 `条件?a:b`
- C# 循环：for（定次数）、while（看条件）、do-while（至少一次）、break/continue
- 嵌套循环：外层管行内层管列，写出九九乘法表与星号三角形
- 两个套路：累加器(sum=sum+i)求和、计数器(count++)数个数
- 综合实战：密码登录（最多3次），用 bool 标志位区分"成功/次数用完"
- Unity 物理：认识 Rigidbody 刚体与 Collider 碰撞体分工
- 刚体参数：Mass、Use Gravity、Is Kinematic、Constraints 冻结旋转X/Z
- velocity 物理移动：GetComponent取刚体、FixedUpdate写物理、保留rb.velocity.y
- AddForce(ForceMode.Impulse) + GetKeyDown 实现物理跳跃
- OnCollisionEnter/Exit + isGrounded 做落地检测，杜绝空中连跳
- 斜坡/台阶/边缘测试：摩擦决定滑动、碰撞阻挡不穿透、悬空会坠落
- 晚间练习：猜数字游戏（Random.Next(1,101) + while + if + 计数器）

## D6 完成（9/9 周三）

- C#数组：三种声明、下标从0/Length、for与foreach遍历、用户输入存数组、string.Join打印
- C#方法：参数/返回值/return提前退出与卫语句、方法间互相复用；理解值类型传参是副本
- 冒泡排序：相邻比较交换、双层for（外层Length-1轮、内层Length-1-i），亲手写通
- 独立写出 Max(int[]) 打擂台求最大值（初始用arr[0]而非0，避免全负出错）
- Unity预制体Prefab：物体拖入Project存成模板、public槽拖拽赋值、忘拖会空引用
- Instantiate生成物体、用变量接住返回值、for循环批量生成一排
- Input.GetAxis平滑输入(-1~1)替代4个if，Debug.Log输出到Console
- 综合成品：按空格Instantiate小球+刚体velocity，做出"发射器"
