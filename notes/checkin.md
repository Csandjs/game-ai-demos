# 学习打卡表

| 日期 | Day | 完成度 | 卡点 | 明日重点 |
|------|-----|--------|------|----------|
| 2026-09-03 | D1 | ✅ 完成 | 无 | Unity安装 + 第一个场景 |
| 2026-09-04 | D2 | ✅ 完成 | 无 | 简历骨架 + 打卡表 + 仓库整理 |
| 2026-09-05 | D3 | ✅ 完成 | 无 | 启动周收尾，进入正式学习周期 |
| 2026-09-06 | D4 | ✅ 完成 | 无 | C#流程控制 + Unity物理/碰撞入门 |
| 2026-09-08 | D5 | ✅ 完成 | 无 | C#数组与方法 + Unity预制体/脚本通信 |
| 2026-09-09 | D6 | ✅ 完成 | 冒泡边界/值类型交换（已解决） | D7周复盘 + 本周知识录屏回顾 |
| 2026-09-10 | D7 | ✅ 完成 | 被球撞到无法跳跃(用Tag区分地面解决) | D8：C#面向对象-类与对象入门 |
| 2026-09-11 | D8 | ✅ 完成 | 下午Unity突发Safe Mode编译崩溃(Internal build system error)，靠删Library/Temp/obj缓存+重启解决，非代码问题 | D9 学继承 |
| 2026-09-12 | D9 | ✅ 完成 | ①Unity编译工具BeeLocalCacheTool被系统策略拦截→右键TuanjieHub管理员身份运行解决；②平滑移动加速度=10时被地面静摩擦卡住、速度攒不起来→调到15能跑；③每帧Debug.Log把Console刷成999+、淹没扣血日志→删掉每帧打印只留DrawRay | 多态 + Unity触发器/吃金币 |

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

## D7 完成（9/10 周四）第1周复盘日
- 上午：把D4-D6的C#整理成系统笔记 notes/CSharp_Basics.md（变量运算/流程控制/数组/方法/算法五大块+16条避坑清单），每个知识点亲手写例子并逐块批改
- 查漏补缺：纠正 for里i与arr[i]混淆、Console.ReadLine漏前缀、string.Join把逗号写成+导致CS0121等问题；独立默写出冒泡排序
- 下午：跑通本周Unity三功能（WASD刚体移动 / 空格跳跃 / J键发射）；整理脚本——禁用AxisMove只留PlayerPhysicsMove，发射键由空格改J避免和跳跃冲突
- 修复bug：玩家被自己发射的球撞到后不能跳——根因是碰撞检测没区分对象，用 CompareTag("Ground") 只认地面解决
- 第一周成果录屏存档（手机拍屏，移动+跳跃+发射）
- 晚上：写第1周周总结 notes/week1.md，规划第2周面向对象主线
- git：提交并推送 CSharp_Basics、week1、脚本改动到 GitHub

## D8 完成（9/11 周五）

- 🌞 上午 C# 面向对象入门：类=图纸/对象=实物/new=造对象；字段、构造函数(同名无返回类型、new时自动执行)、this 区分同名字段与参数；对象可以当参数传，实现两个对象互相攻击。
- 🌤 下午 Unity 碰撞：OnCollisionEnter 在接触那一帧自动执行一次；碰撞三条件(双方Collider+至少一个Rigidbody+都不勾IsTrigger)；用 Tag + CompareTag("Trap") 区分机关；实现碰红方块掉血并打印剩余血量；体会刚体 Mass/Drag——velocity 不吃质量阻力、AddForce 吃(质量×10跳不起来)。
- 🌙 晚上：第一次脱稿独立写出 Enemy 类 + while 回合制对打，掌握"先手打完立刻判死亡再break"，不让尸体反击；踩了 private 默认访问、死亡顺序两个坑并自己改对。
- 🛠 排错：Unity Safe Mode / Internal build system error 排查全过程(看有无CS错误→删缓存→空项目测试→重启)，确认是环境不是代码，项目没丢。
- 📌 明日(D9)重点：学继承；早上先做 ≤10 分钟复现——脱稿写一个"字段+构造函数(this)+方法"的类，并 new 两个对象调用。

## D9 完成（9/12 周六）
- C# 继承：`class 子类:父类` 子类白捡父类字段和方法，构造函数不继承；`:base(参数)` 把参数转交父类构造，`base.方法()` 可调父类原版
- 方法重写：父类 `virtual`、子类 `override` 成对出现，签名（方法名/参数/返回类型）必须一致、方法体自由；分清完全替换（删base）与扩展增强（留base再追加）
- 访问修饰符：对比 `public`/`protected`/`private` 可见范围，字段用 `protected` 做封装（本类+子类可见、类外不可见），外部只能通过 public 方法间接改
- 上午练习：Character 父类（protected字段+构造+TakeDamage/Attack+virtual Move）+ Player/Enemy 子类（base构造+各自override Move）
- Unity 射线地面检测：`Physics.Raycast(起点,方向,长度)` 每帧从脚下向下探测，取代 OnCollisionEnter/Exit，落地才返回true、空中false，实现落地能跳、空中不连跳
- `Debug.DrawRay(起点,方向*长度,颜色)` 在 Scene 视图画红线辅助调试、不进Console；每帧的 `Debug.Log` 会刷成999+还会淹没别的日志，看明白就删、只留画线
- 平滑移动：先算目标速度（水平按键决定、y保持`rb.velocity.y`），再用 `Mathf.MoveTowards(当前,目标,每步最大变化)` 让 x/z 逐帧逼近目标，产生加速起步/滑行减速手感
- Unity 固定套路：改刚体速度要先拷进临时变量 `v`、改完再 `rb.velocity=v` 整体写回，不能直接 `rb.velocity.x=...`；只平滑水平 x/z，竖直 y 不动以免破坏重力跳跃
- 每帧最大变化量 `= 加速度 * Time.fixedDeltaTime`，保证不同帧率手感一致
- 理解 Vector3 本质：就是装 x/y/z 三个 float 的盒子，位置、速度、方向、旋转、力都用它，含义看存在哪个属性里
- 踩坑：加速度太小每帧增量被静摩擦抵消、看着像不动，调大到15能跑；最终手感参数 MoveSpeed=8、MoveAcceleration=15、JumpForce=5、GroundDistance=0.55
- 晚上多态练习（独立默写）：Animal 父类 virtual Speak + Dog/Cat override Speak；父类变量能装子类对象，调虚方法以 `new` 出来的真实对象为准执行对应版本
- 多态用法：父类数组 `Animal[]` 混装 Dog/Cat，`foreach` 里一句 `a.Speak()` 各叫各的，新增子类只要override+塞进数组、循环不用改（对扩展开放）
- 认识 C#12 主构造函数简写 `class Dog(string name):Animal(name){}`，等价于完整版构造+base，现阶段仍写完整版打基础
- 环境排错：团结引擎报 Win32Exception / BeeLocalCacheTool 被"应用程序控制策略"拦截（即昨天 -532462766 根因），右键 TuanjieHub 以管理员身份运行解决，并在 属性→兼容性 勾"以管理员身份运行此程序"一劳永逸
- Git：提交推送 Day9_Practice、Day9_Animal、FristScene 脚本改动、StudyNotes 与 checkin
