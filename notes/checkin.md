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
| 2026-09-13 | D10 | ✅ 完成 | 智能应用控制拦截编译dll（关闭SAC解决）；UI文字曾因文本框太小/锚点不对不显示；金币绕对称轴自转看不出（改Space.World） | C#接口Interact + Unity接口实现 |
| 2026-09-14 | D11 | ✅ 完成 | Unity能看懂但独立写还不熟、一个Text被两个字段抢占覆盖、if误写在方法外 | 封装/继承/多态/接口四件套整合成角色系统 |
| 2026-09-15 | D12 | ✅ 完成 | 无 |C#查缺补漏（静态/枚举/命名空间）+Unity可玩小关 |
| 2026-09-16 | D13 | ✅ 完成 | 单例刚开始有点绕； | D14 周复盘+闭卷自测 |
| 2026-09-17 | D14 | ✅ 完成 | static 和访问修饰符混淆；单例一开始看不懂后搞懂 | D15 委托 delegate |
| 2026-09-19 | D15 | ✅ 完成 | 委托/事件一开始理解困难，用"通知群"类比后打通，Unity事件订阅已能脱稿 | Lambda 表达式 + List 泛型集合 + Unity 批量生成管理 |
| 2026-09-21 | D16 | ✅ 完成（9/22补收尾） | GetComponent漏写物体前缀导致只生成1个；边遍历边删集合；List该装物体还是组件 | Dictionary字典 + Animator动画入门 |
| 2026-09-23 | D17 | ✅ 完成 | Animator与旧Animation组件混淆、时间轴秒:帧、float配置传int需强转 | D18（按新计划图） |
| 2026-10-12 | D18 | ✅ 完成（10/10开工，10/12收尾） | 序列化坑：改代码默认值对已挂组件不生效；复制按钮连脚本一起复制，点继续变重开；timeScale粘性，切场景不重置 | D19（按新计划图） |
| 2026-10-13 | D19 | ✅ 完成 | PlayerPrefs 键名大小写不一致（"Volume"≠"volume"）；AudioListener.volume 是 static 不在 Inspector 显示；设置面板开着按 Esc 残留，用 activeSelf 判优先级 | D20（按计划图） |
| 2026-10-14 | D20 | ✅ 完成 | 音效空引用曾中断核心玩法（已用 `?.` 修复）；互砍被先咬（调整攻击距离解决）；序列化坑 | 按 W4 计划图开始 |
| 2026-10-14 | D21 | ✅ 完成 | 命令系统把注册语句误写在类体（已修正为构造函数） | W4 Unity 脚本进阶 |
| 2026-10-16 | D22 | ✅ 完成 | 编辑器编译后端僵死（手动 Roslyn 编译 36 脚本零错误，确认环境问题，刷新/重启解决） | D23 地基期收尾，随后进 Demo1 FSM |
| 2026-10-16 | D23 | ✅ 完成 | ①0.9 与 0.9f 浮点精度差导致进度条 while 死循环（已改 0.9f）；②持久总管跨场景拖不了 UI，用"场景报到"模式（LevelSceneSetup + RegisterLevel）解决 | D24：W4 地基期最后一天（PlayerPrefs 存档体系），随后进 Demo1 FSM |
| 2026-10-17 | D24（压缩日上午+下午） | ✅ 完成 | ①SaveManager 初版把 key 当参数、SetInt 误存旧值（已修）；②结算面板字号160溢出，重构为"遮罩根物体+内容"标准弹窗；③JSON 序列化与反序列化原理 | D25 压缩日：Boss 状态机补 Hurt/Dead + 攻击前摇后摇 + Boss 血条 + 录屏 |
| 2026-10-18 | D25（跨夜，Boss 日） | ✅ 完成 | ①Boss 死亡分支漏 return 导致"死后复活"、Hurt 守卫位置错导致硬直无敌、协程醒来覆盖 Dead（已修）；②Boss 血条 maxValue 默认 1 导致一直满；③录屏半灰翻转，Play Maximized 解决 | D26（顺延周日上午）：W4 速查表 + 闭卷自测 3 题 + week4 周总结 + 面试口述 |
| 2026-10-18 | D26（W4 复盘日上午） | ✅ 完成 | 协程闭卷首答漏 WaitForFixedUpdate、IEnumerator 拼写错；面试口述协程机制首答 60 分（没讲清 yield return 交还控制权+Unity 每帧轮询）；虚构"玩家攻击用了协程"被当场纠正 | D27：地基期收官整合（攻击动画+试玩修bug+BGM+录屏+README） |
| 2026-10-18 | D27（地基期收官日下午） | ✅ 完成 | ①AudioManager 初版两行 GetComponent 拿到同一个喇叭→改 AddComponent；②出生点保护初版永远传西南角→改方向向量版，又把 dir.z 写成 dir.y 导致正北方玩家被放进 Boss 中心；③SettingsMenu 漏设 Toggle 初始 isOn→UI 不反映存档 | D28：地基期阶段总结+作品集+git tag v0.1+LeetCode |
| 2026-10-18 | D28（作品集整理日晚） | ✅ 完成 | ①git tag 和 Release 关系搞混（tag=代码标记，Release=套在 tag 上给人看的版本说明）；②tag 要单独 `git push origin v0.1`，不是推 main 就带上；③视频/截图拖错到正文 Markdown 框（限 10MB）→改拖下方大虚线附件区（限 2GB）；④疑惑 GitHub 为何不能直接玩（源码 vs exe，要 Build 打包，打磨期做） | D29：简历收尾 + FSM 状态机预热 |
| 2026-10-18 | D29（Demo1 预热晚） | ✅ 完成 | ①误以为 D29 要写简历初稿（实为 D65 11/8，Demo1 后才有东西写），D29 是"简历收尾"（仓库公开+录屏/README 齐全）；②控制台 FSM 里 hp 永不减→死亡分支写了但不触发（可选扩展）；③git push 曾遇 GitHub 502 服务器错误，重试/调大 http.postBuffer 后成功 | D30 起：阶段2 Demo1 状态机小怪 AI |
| 2026-10-20 | D30（跨夜 10/19 晚→10/20 凌晨） | ✅ 完成 | ①Gizmos 连线误写 i++（后置自增）→零长度线+跳点，改 i+1；②预制体引用场景物体拖不进→EnemySpawner 注入 waypoints；③暂停设置滑块被 Boss UI 挡→关 BossText raycast；④Normalize() 返回 void 不能当参数；⑤Mathf.Lerp 不夹紧进度，讨论 else-if 跳帧边界 | D31：阶段1 最后冲刺 |
| 2026-10-20 | D31（Demo1 核心战斗+金币掉落） | ✅ 完成 | ①金币掉落 while 忘自增→Instantiate 死循环瞬间卡死（加 coinDropcount--）；②Patrol/Chase 每帧 Debug.Log 洪水拖死编辑器（删）；③Mathf.Clamp01 返回值没接住（改 p=）；④Boss 换猪后 GetComponent 拿不到子物体渲染器→Start 中断全功能失效（改 GetComponentInChildren）；⑤狂暴缩放根物体把碰撞体一起放大→打不到玩家（只缩放模型子物体，逻辑/外观分离）；⑥金币躺着根因=CoinSpawner 用 Quaternion.identity 覆盖预制体立起旋转（改根+模型子结构） | D32：录屏验收+首批投递准备；动画 Idle/Run 推 D34/D35；Boss 奖励等背包系统 |
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

## D10 完成（9/13 周日）

- 多态调用规则：声明类型（左边）决定能不能点出成员，实际类型（new 的是谁）决定虚方法执行哪个版本，口诀"能不能调看左边，执行谁看new"
- 抽象类：`abstract class` + 抽象方法 `public abstract void Speak();`（无方法体、分号结尾），抽象类不能 `new`，子类必须 `override` 全部抽象方法；普通字段/构造/普通方法仍可写
- virtual 与 abstract 区别：virtual 有默认实现、子类可选重写；abstract 无实现、子类必须重写、类必须加 abstract
- 类型判断：`if(s is Circle c)` 判断并转换一步到位（推荐），`as` 失败返回 null 要判空，直接强转失败会崩；通用行为靠多态、子类特有行为才用 is/as
- List<T> 集合：要 `using System.Collections.Generic;`，`Add` 加元素、`Count` 取个数（数组是 Length）、`foreach` 遍历、`{ }` 集合初始化器、`list[下标]` 取单个；长度可变
- 抽象类动态创建：不能 `new 抽象类自己`，但子类可无限 new，运行时按输入的种类用 if/switch 决定 new 哪个子类、父类引用接住再 Add（刷怪雏形）
- Unity 触发器：Collider 勾 `Is Trigger` 变触发器，物体穿过不阻挡、只发事件；触发三条件=双方都有Collider+一方勾Is Trigger+至少一个刚体
- Collider vs Trigger（面试高频）：碰撞体不勾、有物理碰撞、用 `OnCollisionEnter`；触发器勾上、无碰撞只触发、用 `OnTriggerEnter(Collider other)`
- 吃金币：玩家 Tag 设 `Player`，金币挂 Coin 脚本，`OnTriggerEnter` 里 `other.CompareTag("Player")` 命中则 `static int score` 加一并 `Destroy(gameObject)` 销毁金币；static 让所有金币共用一份分数
- UI 分数：右键 UI→旧版→文本 Text，自动建 Canvas/EventSystem；锚点定左上角、文本框宽高要大于字号、溢出设 Overflow；ScoreUI 脚本 `using UnityEngine.UI`、`GetComponent<Text>()`、每帧 `scoreText.text = "分数：" + Coin.score` 刷新
- 组件认知：组件是装着属性和方法的对象，Inspector 每一栏对应代码里一个属性，`组件.属性=值` 等于运行时改面板；改屏幕文字用 `Text组件.text`
- 金币旋转：物体被手动旋转后局部轴会歪，`transform.Rotate(..., Space.World)` 绕世界竖直轴转才明显，纯色圆盘绕中心对称轴自转肉眼看不出
- 环境排错：Win11 智能应用控制（SAC）拦截无签名的本地编译 dll（0x800711C7），不认 Defender 白名单、管理员也绕不过，开发机在"应用和浏览器控制"里关闭 SAC 并重启解决
- 命名规范：类名/方法名/属性名用大驼峰 PascalCase（Attack、Speak），变量/参数用小驼峰 camelCase（playerName、循环变量 dog 而非单字母）

## D11 完成（9/14 周一）

- 学会接口 `interface`：方法只有签名以分号结尾、不写 public、不能有字段和构造函数，类用冒号实现、一个类可实现多个接口
- 理解接口多态：接口也是类型，可用 `接口[]` / `List<接口>` 装不同对象并 `foreach` 统一调用
- 梳理接口 vs 抽象类：接口是 can-do（能做什么）、可多实现；抽象类是 is-a（是什么）、只能单继承（面试高频）
- 控制台项目 `Day11_Interface`、`Day11_InterfaceDrill`、`Day11_Interact`：实现 `IMovable`/`IDamageable`/`IInteractable`，并学会接口方法带 `bool` 返回值、调用方用变量接住判断
- Unity 新建 `IMovable.cs`、`IDamageable.cs`（纯接口不继承 `MonoBehaviour`、不是组件不能挂物体）
- `PlayerPhysicsMove` 实现 `IMovable`，水平移动封进 `Move()`，`FixedUpdate` 里调用
- `PlayerHealth` 实现 `IDamageable`，掉血封进 `TakeDamage(int)`，`hp` 用普通 public 字段不用 static
- 新增木箱 `BoxHealth`（耐久归零 `Destroy`）和炸弹 `Bomb`
- `Bomb` 用 `List<IDamageable>` 配合 `OnTriggerEnter/Exit` 维护范围内名单，按 K 用 `foreach` 统一 `TakeDamage`，一颗炸弹同时让玩家掉血、木箱碎裂，体会接口解耦
- 弄清模型 `Scale`（视觉大小）与碰撞体 `Radius`（判定范围）相互独立；固定触发区域挂刚体并勾 `Is Kinematic` 才能检测无刚体对象
- 用 `public PlayerHealth player;` 在 Inspector 拖引用做血量 UI（`HpUI`），区分 static（全局唯一总分）与拖引用（具体物体的数据）
- 踩坑：一个物体只有一个某类型组件，两个字段都 `GetComponent<Text>()` 会指向同一文本框互相覆盖，多行 UI 要建多个 Text 物体

## D12 完成（9/15 周二）
- 封装：`private` 字段 + `public` 只读属性（只有 `get`），掉血只能走 `TakeDamage` 受控修改
- 接口：`IDamageable` 只有 `TakeDamage` 签名，`Character` 实现，子类靠继承白捡
- 继承多态：`Character` 基类 + `Player/Enemy/Boss` 子类，`virtual/override` 不同攻击力，父类引用必须 `new` 具体子类
- 回合对战：`while(true)` 轮流攻击，攻击后立刻判 `Hp<=0` 用 `break` 结束，防止死人还手
- 简单工厂：`CharacterFactory.Create(类型)` 返回父类 `Character`，内部按字符串 new 子类，调用处先接结果再判 `!= null`
- Unity 单一职责：`PlayerPhysicsMove` 管移动跳跃、`PlayerHealth` 管血量、UI 管显示，组件独立协作
- UI 改事件触发：删掉 `Update` 轮询，掉血时调 `RefreshHp(hp)`、吃金币时调 `ReportScore(score)`，`Start` 里先刷一次初始值
- 易错点：文件名=类名；`using` 不手滑选错；工厂判空判创建结果而不是输入字符串

## D13 完成（9/16 周三）
- 上午查漏：`static` 静态成员、`private set` 自动属性、计算属性 `IsDead`、`enum` 游戏状态机、`namespace`
- 下午：空场景脱稿重建刚体移动+触发检测；`CameraFollow` 摄像机跟随（`LateUpdate`/`LookAt`）；`GameManager` 单例（`static Instance`/`Awake`/`DontDestroyOnLoad`）；`enum GameState` + 卫语句实现胜利锁操作；整合成可玩小关并手机录屏

## D14 完成（9/17 周四）

- 闭卷脱稿写出 `Character`/`Player`/`Enemy`/`IDamageable` 回合制对战（Day14_Exam），一次跑通
- 换皮练习：static 计数、enum + switch 敌人状态机、单例 `SaveSystem`/`AudioManager`（私有构造 + 静态 Instance）
- 搞懂单例"锁门、存独苗、开窗口"，以及控制台版与 Unity `GameManager`（Awake 注册）的区别
- MiniLevel 通关录屏存档；更新 README、写完 week2.md，W2 收官

## D15 完成（9/19 周六）

- 委托与事件：`delegate`、多播 `+=/-=`、`event` 访问保护、`Action`/`Action<int>`/`Func<T,T,TResult>`、`?.Invoke()`
- Unity 事件驱动：`GameManager` 金币事件 + `CollectCoin` 中继方法，`ScoreUI`/`CoinSound` 订阅，`OnDestroy` 退订
- 脱稿练习：`Day15_Quit` 按 Q 退出三系统响应、`Day15_Func` 武器伤害公式插槽

## D16 完成（9/21 周一，9/22 补收尾）

- Lambda 四种形态（单参省括号、零参/多参带括号、多行加大括号并 return），配合 `Func`/`Action`
- `List<T>` 动态数组：`Add`/`Remove`/`RemoveAt`/`RemoveAll`/`Contains`/`Count`/初始化器/`foreach`
- 查找四件套：`Contains`、`Exists` 返回 bool，`Find` 返单个（找不到 null），`FindAll` 返新列表；`Sort` 升序 `a-b`、降序 `b-a`，原地排序
- Unity 生成器模式：`Instantiate` → `obj.GetComponent<T>()` → 回填 `spawner` → 列表登记
- `List<GameObject>` 管理 10 枚金币；`List<Enemy>` 管理 5 个敌人波次，全灭 `Count==0` 调 `WinGame()`
- 群体技能按 K：`FindAll` 出副本再 `foreach` 调 `Die()`，避免边遍历边修改原列表
- 踩坑：GetComponent 漏前缀在自己身上找组件返回 null、场景残留旧金币、`this`（组件）与 `gameObject`（柜子）的区别、类体里不能写执行语句

# D17 完成（9/23 周三）
- `Dictionary<K,V>` 增删查改、TryGetValue 兜底、背包堆叠计数器、值类型复印件
- Unity Animator：Idle/Move/Jump 三片段、状态机四根过渡线、`SetBool` 随移动/跳跃切换、胜利复位
- 静态类 `GameConfig` 配置表查表（控制台+Unity），理解序列化覆盖与静态类/单例区别
- 加深：`Dictionary<string,Action>` 按键映射（命令模式雏形）

# D18 完成（10/10 周六，10/12 周一补收尾）Unity UI 系统

- UI 基础：`Canvas`（屏幕空间-覆盖）+`EventSystem` 点击感应；Button(Legacy)=父 Image+Button、子 Text；`Panel` 容器、`SetActive` 显隐、同级 UI 越靠下越上层
- 按钮订阅：`GetComponent<Button>().onClick.AddListener(方法)`（using UnityEngine.UI）；自造 event 没人 Invoke，UI 固定用 AddListener
- 血条 `Slider`：关 Interactable、Min0/Max100、禁 Handle，Fill Area 左右边距归 0 才铺满，`hpSlider.value=hp` 绑定
- 取组件三途径：同物体 GetComponent、跨物体 public 拖引用、Instantiate 返回物体再 GetComponent
- 场景跳转：`SceneManager.LoadScene("名")` 加载别的场景，`LoadScene(GetActiveScene().name)` 重载自己；Build Settings 必须 Add Open Scenes
- 拆两场景：MenuScene（序号0）放菜单，MiniLevel（序号1）进游戏 Awake 直接 state=Playing
- 暂停菜单：enum 加 `Paused`，`Input.GetKeyDown(KeyCode.Escape)`，`Time.timeScale` 0停/1恢复（Update 和 UI 点击不受影响）；三按钮 继续/重开/返回菜单
- 📌 序列化坑：public 字段默认值只在首次挂载写入一次，之后改代码不影响已挂组件，以 Inspector 为准，Awake 里强制赋值
- 📌 复制 UI 会连脚本和 OnClick 绑定一起复制（点继续却重开=按钮还挂着 RestarButton）；timeScale 粘性、切场景不重置，LoadScene 前先拨 1 + Awake 保底
- 📝 D18 闭卷大考《战场结算模拟器》140 通过；

# D19 完成（10/13 周二）状态机完善 + 主菜单 + 存档 + 事件解耦

- Lose 状态：enum 加 `Lose`，血量归零弹失败面板（复用 Win 套路）；`if(IsDead)return` + `if(state!=Playing)return` 双重防重入
- 主菜单完整化：开始/设置/退出三按钮；设置面板 `Slider`(0~1) 绑 `AudioListener.volume`，`onValueChanged` 是 `UnityEvent<float>`；`Application.Quit()` 编辑器无效正常
- 暂停内设置：timeScale=0 时 UGUI 点击/拖滑块照常（unscaled 时间，面试点）；Esc 按优先级用 `activeSelf` 先关设置面板再恢复
- PlayerPrefs：`SetFloat/GetFloat`、`SetInt/GetInt` 键值对本地持久化；音量+最高分存盘，Win/Lose 结算时比较刷新最高分，主菜单 HighScoreText 上屏
- 📌 键名大小写敏感：`"Volume"≠"volume"`，魔法字符串集中到 GameConfig 的 `const`
- 📌 `AudioListener.volume` 是 static 全局属性，Inspector 看不到；跨场景新 AudioListener 会覆盖，GameManager Awake 读档保底
- 加深：血条改事件驱动 `event Action<int> OnHpChanged`，PlayerHealth 只广播不认识 UI，HpUI 订阅+开局刷初始值（金币同款模式）
- 工程：Assets 整理为 `Scripts/{UI,Player,Enemy,Items,Game}` + Materials；移动只在 Project 窗口（.meta 存 GUID），Ctrl+拖是复制
- LeetCode 21 合并两个有序链表：双指针 + 哑节点 dummy，一次跑通 `1 1 2 3 4 4`

# D20 完成（10/14 周三）

- 敌人 AI 有限状态机：`enum EnemyState` + 距离判断三态互斥切换 + `switch` 分发到 Patrol/Chase/Attack
- Patrol 用 `Vector3.MoveTowards` 在两个巡逻点间往返，Chase 换目标为玩家，Attack 贴脸站住
- 冷却计时器套路：`attackTimer -= Time.deltaTime`，到 0 调 `TakeDamage` 并重置
- 玩家 K 键攻击：`FindAll` 的 lambda 里对每个敌人实时算 `Vector3.Distance`，删除敌人碰撞自杀逻辑
- 音频三件套：`AudioClip` 素材 / `AudioSource` 喇叭 / `AudioListener` 耳朵，`PlayOneShot` 播放一次性音效
- 单例 AudioManager（`DontDestroyOnLoad` + 判重），语义化方法 `PlayCoin/PlayJump/PlayHit/PlayHurt/PlayWin/PlayLose`
- 随机生成：`Random.Range` 在安全边界内随机敌人/金币位置
- 判空保护：`AudioManager.Instance?.PlayXxx()`，附属功能不阻断核心玩法
- 修复 Bug：音效空引用中断核心逻辑、public 默认值序列化坑（改代码不影响已挂组件）
- 完成 W3 整合：完整流程闭环（主菜单→关卡→胜负结算→重开/回菜单），手机录屏 + README

# D21 完成（10/14 周三）
- W3 知识速查表：委托事件 / 集合 List vs Dictionary / Animator / UI，每块写"什么时候用"
- 闭卷自测 3 题：事件系统（`event Action<int>` + 双订阅）、`Dictionary<string,Action>` 命令系统（TryGetValue）、`List<Enemy>` FindAll 存活 + Sort 升序
- 巩固：类体里不能写执行语句（注册放构造函数）、`Sort((a,b)=>a.hp-b.hp)` 升序规则
- 写 W3 周总结 week3.md

# D22 完成（10/16 周五）MonoBehaviour 生命周期 + 协程入门

- 生命周期：8 个方法执行顺序，Awake/Start 时机保证（所有 Awake 跑完才 Start），FixedUpdate 固定步长与慢帧同帧补跑；实测 Fixed 30 vs Update 302
- 协程三要素：using System.Collections + IEnumerator 返回 + yield return，StartCoroutine 启动
- 三种等待：yield null（下一帧）、WaitForSeconds（等秒）、WaitForEndOfFrame（帧末）
- 停止：StopCoroutine(句柄) 精准停、StopAllCoroutines 全停
- 反直觉点：禁用脚本组件不停协程，SetActive(false)/销毁才停
- 实战：EnemySpawner while(true) 协程刷怪（U 停一个/Y 停全部）；SkillCooldown L 键 3 秒 CD + UI 倒计时，isCooling 锁防止重复释放；BossDirector 倒计时后 SetActive 激活 Boss
- 事件退订自查：HpUI 缺退订已补；按钮 AddListener 随对象销毁不用退订；GameManager 自订阅不用
- 环境排错：编译后端僵死，手动 Roslyn 编译零错误，确认是环境不是代码

# D23 完成（10/16 周五）Input 输入系统 + 场景管理

- 旧版 Input：GetKey 按住/ GetKeyDown 单击/ GetKeyUp 松开/ GetAxis 平滑轴（-1~1）/ GetMouseButtonDown 鼠标；GetAxis 重构移动、鼠标左键攻击
- 静态方法必须带类名前缀：GetMouseButtonDown 裸写报错（不是自己类的方法）
- 新版 Input System：装包后主动输入处理选 Both；InputAction 动作抽象 + 绑定 + performed/canceled 回调 + Enable/Disable；2DVector 复合绑定 WASD、手柄左摇杆 AddBinding；CallbackContext.ReadValue 取值；事件驱动 vs 轮询（面试点）
- 场景切换本质：旧场景全销毁、新场景照图纸重建；DontDestroyOnLoad 免死金牌 + 持久单例三件套（判重/登记/免死），AudioManager 为范本
- 架构分界：全局数据（总管、分数、音量）免死；场景物件（金币、敌人、面板）每关重建
- 场景引用难点：总管跨场景拖不到关卡 UI，由 Canvas 上的 LevelSceneSetup 在 Start 调 RegisterLevel 报到；隐藏面板不能自报到（Start 不跑）；ScoreUI 出生主动刷一次分数
- PauseMenu 是场景物件，随 GameManager 物体删除前用"复制组件→粘贴为新组件"搬到 Canvas
- 异步加载：LoadSceneAsync 返回 AsyncOperation；progress 卡在 0.9 等放行；allowSceneActivation=false 扣住→进度条铺满→等 1 秒→放行；progress/0.9f 映射 0~1
- 浮点坑：0.9f 实际是 0.89999997，和 double 0.9 比永远小于 → while 死循环，Unity float 比较字面量一律带 f
- 验证：DontDestroyOnLoad 始终只有一个 GameManager；菜单→关卡→菜单→关卡分数保留；金币每关刷新正常；暂停/胜负面板正常

# D24 完成（10/17 周六，压缩日）PlayerPrefs 封装 + JSON 存档

- PlayerPrefs：SetInt/GetInt/SetFloat/GetFloat/SetString/GetString + Save 强制落盘；键名全部收进 GameConfig 常量
- SaveManager 封装（static class）：SaveVolume/LoadVolume、SaveHighScore（内部比较才存）/LoadHighScore、SaveLastScore（无条件覆盖）/LoadLastScore；踩坑：static 成员默认 private、SetInt 第二参数才是新值、key 不能当参数传
- 全局 PlayerPrefs 只允许出现在 SaveManager 一个文件里
- GameManager 收尾：RegisterLevel 每局 score 归零 + timeScale 恢复；结算三行文字用 \n；Restart 用 GetActiveScene().name 重载本关；GetComponentInChildren<Text>(true) 搜隐藏子物体
- 报错洪水排查：必须从 MenuScene 播放（GameManager 在主菜单），直接放关卡场景会导致一堆 Instance 空引用；找最早时间戳、共同根因
- Rider 自动 using 陷阱：游戏脚本只认 UnityEngine 开头命名空间，不选 UnityEditor
- 标准弹窗结构：Image 半透明遮罩根物体 → ResultText 子物体 + 按钮平级；UIManager 是以后的升级
- 主菜单新增最近得分：HighScoreText 加 LastScoreText 字段同时刷新
- JSON 存档：数据箱 SaveData 是普通类（不继承 MonoBehaviour）+ [Serializable]，只打包 public 字段，不支持 Dictionary/属性
- JsonUtility.ToJson 序列化（箱子→文本）、FromJson<T> 反序列化（文本→新箱子，像复印）；PlayerPrefs.HasKey 首次启动判空，返回 new SaveData 默认箱
- 完整数据流：内存箱子→ToJson→SetString→硬盘，重启 GetString→FromJson→新箱子；验证：通关→停止重播放→Awake 读档日志正确→失败一局 unlockedLevel 不掉
- 接线顺序：先 SaveHighScore 比较更新散键，再 LoadHighScore 读出拍进 JSON 快照，两处数据一致
- 删档：DeleteKey 删单页（ClearSave）、DeleteAll 清全部（ClearAll）；不用字符串当开关（拼错静默失败），拆两个方法或用枚举
- 架构边界：设置类走散键、进度类走整包；唯一数据源原则；最高分过渡阶段两边都写，以后重构收进箱子
- 升级路线：嵌套箱子 → Newtonsoft.Json → 文件存档（persistentDataPath 多槽） → 云存档/加密/压缩
- 工程整理：四个测试脚本（Coroutine/Lifecycle/NewInput/JsonSave）统一移入 Scripts/Test；EnemySpawner 加非 Playing 状态守卫

# D25 完成（10/17 晚→10/18 凌晨，跨夜）Boss 五态状态机 + 攻击协程 + 血条 + 录屏

- Boss 五态 FSM：Idle/Chase/Attack/Hurt/Dead，enum 定义；激活即 Chase（物体未激活由 Director 倒数后 SetActive，Start 直接进入战斗）；Update 门禁 Idle/Hurt/Dead 直接 return
- 追击：MoveTowards 匀速移动 + LookAt；XZ 平面拍平（目标 y 改成自己的 y，玩家跳起不朝天歪）；小怪 Enemy 同步修了这个坑
- 攻击三段式协程：前摇 0.7s 变红+Lerp 放大 1.15 倍+每帧面向玩家 → 判定瞬间第二次查距离（跑出范围空大）+ 玩家未死才 TakeDamage(15) → 后摇 0.9s 缩回原地不动（输出窗口）
- 新 API：GetComponent<Renderer>().material.color 变色；Vector3.Lerp 插值做逐帧动画；while(t<时间){t+=Time.deltaTime; yield return null;} 协程逐帧模板
- 视觉与判定分离：缩放/颜色只影响观感，判定只看 transform.position 距离
- 受击：Dead 守卫→扣血→Invoke 事件→死亡分支（启 DieRoutine 后 return）→PlayHit 音效→Hurt 中只掉血不刷新硬直→Attack 中 StopCoroutine 打断+恢复外观→HurtRoutine 闪黄 0.4s
- 三个协程竞态 bug：①死亡漏 return 被 HurtRoutine 复活（漏的活移交 DieRoutine 开头停攻击协程）②Hurt 守卫写在扣血前导致硬直无敌（先扣血再判状态）③HurtRoutine 醒来无脑回 Chase 覆盖 Dead（末尾 if(state!=Hurt) yield break 守卫）
- 核心教训：协程是并行的另一条时间线，切换状态必须想"还有谁在跑、醒来会不会覆盖我"
- 接线：EnemySpawner 加 public Boss boss，攻击判断同时查 activeInHierarchy（物体层激活）和 IsAlive（state!=Dead）；删掉"小怪清空即胜利"（小怪无限刷+提前胜利 bug），改为杀 Boss 才 WinGame
- BossDirector：加 bossHpSlider 字段，激活 Boss 后激活血条
- BossHpUI：Slider 血条订阅 OnHpChanged 事件，Start 设 maxValue=boss.maxHp/value=hp，死亡隐藏，OnDestroy 退订
- 坑：Slider MaxValue 默认 1，value=5 被截断血条一直满；玩家血条是检查器手动设的 100，Boss 血条代码里设（改血量自动跟上）
- GetComponent 与拖引用分界：组件在自己身上用 GetComponent（BossHpUI 挂滑块根物体），在别的物体上才 public 拖引用（HpUI 挂 Text 物体）
- 音效：Boss 挨打漏接，补 PlayHit（死亡分支后、Hurt 判定前），致命一击只播胜利音
- Unity Recorder 4.0.3：Game View + FHD 1080p + 30FPS + H.264 MP4 + 含音频；游戏视图 16:9；选 Play Maximized（播放最大化）；START RECORDING 自动进播放，STOP 自动退出
- 录屏坑：游戏视图面板太小+1.5x 缩放导致半灰翻转画面，Play Maximized 后正常；缩放不影响录制分辨率
- 工程：Recordings/ 已加 .gitignore（视频不进 git）；D25 已提交 commit cfae8ff 并 push
- 正式成片 Movie_007（约 44 秒，本地 Recordings）；打磨期录完整作品集版

## D26 完成（10/18 周日上午）W4 复盘日

- 速查表闭卷回忆：生命周期口述正确（Awake/Start 区别、FixedUpdate/Update/LateUpdate 分工到位）；协程漏 WaitForFixedUpdate、IEnumerator 拼写错，补全后生成 W4速查表.md（四模块：生命周期/协程/Input/场景存档+高频坑清单）
- 闭卷自测 3 题：题1 生命周期分析 90 分（GetKeyDown 放 FixedUpdate 漏按、相机为何 LateUpdate）；题2 协程刷怪器（每2秒1个共5个、X停止、防重复）初版 78 分（缺判空、门禁写协程内部导致句柄被覆盖、bool 没置 true），两轮指导修正；题3 单例+PlayerPrefs 主动要求看参考完成（标注"参考完成未闭卷"）
- week4.md 周总结：知识地图/踩坑全清单/自测结果/待办池/面试题，交付后贴入 notes/
- 面试口述 3 题：题1 生命周期 85 分（结算界面例子不当）；题2 协程机制首答 60 分（没讲清 yield return 交还控制权+Unity 每帧轮询），重讲后 80 分；题3 单例 75 分（缺"第二个管理员怎么冒出来"的具体场景：返回主菜单重新加载 MenuScene）
- 当场纠正：面试时虚构"玩家攻击用了协程"，核实工程确认是 EnemySpawner.Update 里 GetKeyDown 瞬间调 TakeDamage，无协程

## D27 完成（10/18 周日下午）地基期收官整合

- 攻击动画补全：Attack.anim 三关键帧（Cube 缩放 0:00→0:10 压扁拉长→0:20 还原），Animator 加 Attack 状态+isAttacking Trigger 参数，AnyState→Attack（无 Exit Time、Duration 0）、Attack→Idle（Exit Time 1、Duration 0.1），PlayerPhysicsMove.Update 加 K/鼠标左键→animator.SetTrigger("isAttacking")
- 试玩 3 遍发现 3 问题：①跑到边缘掉下去→四面空气墙（空物体+BoxCollider 无渲染，公式：墙位置=地面中心+半边长，地面 5×1×35 → 北/南 z=±17.5、东/西 x=±2.5）；②Boss 降临与玩家重合被挤入虚空→出生点保护（先挪人再 SetActive，水平方向拍平 y，向量归一化推出 5.5m，零向量默认 Vector3.back）；③Boss 挨打音效只播 5 下→确认是设计（第 6 刀致命一击走死亡分支 return，只播胜利音，避免叠加）
- BGM+开关存档：双 AudioSource 架构（音效喇叭 PlayOneShot 可叠加 + BGM 喇叭 loop 循环独立开关），AudioManager 用 AddComponent 动态新建第二个喇叭，GameConfig 加 MusicOnKey，SaveManager 加 SaveMusicOn/LoadMusicOn（PlayerPrefs 不认识 bool，int 存 1/0，默认 1 开），SettingsMenu 加 Toggle 开关（onValueChanged 带 bool 参数，和 Button.onClick 不带参数的区别），Start 读档设 musicToggle.isOn 初始值
- 踩坑三连：①AudioManager 初版 bgmSource=GetComponent<AudioSource>() 和 audioSource 拿到同一个喇叭→改 gameObject.AddComponent<AudioSource>() 动态新建；②出生点保护初版永远传西南角 (boss.x-5.5, boss.z-5.5)→改方向向量版，又把 z 分量写成 dir.y（dir 拍平后 y=0）导致正北方玩家被放进 Boss 中心→改 dir.z；③SettingsMenu 漏设 musicToggle.isOn 初始值→关音乐重开后 Toggle 仍显示开
- 完整流程录屏：主菜单→设置（演示音量+音乐开关）→开始游戏→吃金币杀小怪→Boss 战→胜利结算
- README 大更新：胜利条件改杀 Boss、加 Boss 五态 FSM 描述、技术亮点（双 AudioSource/空气墙/出生点保护/事件驱动 UI）、W4 学习进度、目录结构加 Animations/Recordings
- Git 提交 b9e2f80（17 个文件，982 insertions）并 push 到 main

## D28 完成（10/18 晚）作品集整理：阶段总结 + 速查表 + tag/Release + 截图

- 地基期阶段总结 notes/stage1.md：W1-W4 知识地图、已完成成果、踩坑表、面试自评、下一阶段（Demo1）规划、关键数字
- UnityAPI速查表.md：16 大类 API（生命周期/协程/Input/物理/UGUI/Animator/场景/存档/音频/单例等），每个含参数说明、代码示例、坑、高频固定模式
- git tag v0.1：学会 tag（本地给某个 commit 贴名字标签，`git tag v0.1`）和推送（`git push origin v0.1`，tag 不随 main 自动推，要单独推）
- GitHub Release v0.1：理解 tag（代码层标记）与 Release（展示层版本说明，挂标题/正文/附件）的关系，自己在网页发布"v0.1 地基期——MiniLevel"，含玩法/功能/技术栈
- 5 张截图进 README：docs/screenshots/ 放 01 主菜单/02 游戏中/03 Boss 战/04 暂停/05 胜利，README 用 `![文字](docs/screenshots/xx.png)` 相对路径引用；学会图片要"文件进 git + README 写引用"两件事，git add→commit→push 三步
- 理解 GitHub 为什么不能直接玩：仓库存的是源码，要 File→Build Settings 打包成 exe+Data 才能免 Unity 运行，打包任务放打磨期；Release 附件区 2GB 可挂 exe/视频，正文 Markdown 框限 10MB
- 提交：13fcb64（文档）、ff028e2（截图）；tag v0.1 已推；期间 push 遇 GitHub 502 服务器错误，重试后成功

## D29 完成（10/18 晚）简历收尾 + FSM 状态机预热

- 简历收尾（技术 C）：核对仓库公开可访问（HTTP 200）；README 含 5 张截图；完整通关录屏 Movie_017.mp4（18.8MB）挂到 Release v0.1 附件区（一开始误拖进正文 Markdown 文本框报"小于 10MB"，改拖下方大虚线附件区成功）；README 加视频链接（提交 840c395）。至此作品集闭环：代码+截图+视频+Release 齐全
- 澄清简历四个节点：D3 骨架（已完成）/ D65 11/8 初稿（含 Demo1 录屏+GitHub）/ D95 12/8 二版（含 Demo2）/ 2027/1/31 终版 v3；D29 不写简历，只做作品集展示检查
- FSM 状态机入门（技术 A）：有限状态机=同一时刻只能处于一种状态、满足条件就切换；把嵌套 if-else 拆成状态表；三个核心概念——状态 State、转换条件 Transition、当前状态指针 currentState；对照 Boss.cs 的 enum+switch 确认自己早就在用
- 纯 C# 控制台版 FSM（DailyPractice/FsmPractice）：enum EnemyState（Patrol/Chase/Attack/Dead）+ while 循环（等价 Unity Update 每帧）+ switch 状态流转；用 bool 标记模拟玩家先靠近后远离、distance 每轮 ±1；运行 20 轮输出完整走出"巡逻→追击→攻击→追击→巡逻"
- 设计亮点：发现用 5m、丢失用 8m，中间 3m 缓冲带（滞回），防止玩家在边界横跳导致状态闪烁；严格 `<`/`>` 边界无歧义；hp 分支已写但未触发（death 扩展留待）
- 下午 EnemyFSM（技术 B）：工程里 Enemy.cs 已是 3D 三态 FSM（巡逻/追击/攻击），比任务卡要求的横版 Vector2 超额，仅留默写自检
- 待办：LeetCode 283/121 穿插做；EnemyFSM 默写自检；打磨期 exe 打包 + 画面中间多余红横线 + Boss 专用受击音效

## D30 完成（10/19 晚→10/20 凌晨）状态机小怪升级：巡逻点 + 扇形视野 + 追击加速度 + 换低模

- 巡逻点系统：`public Transform[] waypoints` 替代硬编码 2 点；新增 Idle 状态 + waitTimer 表达"到达停留"（不用协程，等待可被打断，协程睡死会覆盖状态）；修 3 个巡逻 bug（patrolTarget 到点不更新、回绕 > 改 >=、Update 每帧无脑覆盖 Idle）
- 预制体引用场景物体：EnemySpawner 持有 waypoints，生成时 `e.waypoints = this.waypoints` 注入（预制体拖不到场景物体）
- Gizmos：OnDrawGizmos 画黄色检测球、青色巡逻路径、红色视野射线；踩坑 DrawLine 用 i++（后置自增）→同点零长度线+i 被加两次跳点，改 i+1
- 扇形视野：`Vector3.Angle` 判夹角；发现 `distance<5 且 angle<60`，丢失只看 `distance>8`；正面被追、背后不追、绕到正面瞬间被发现
- 追击加速度：`Mathf.Lerp(a,b,t)` 插值，p=(8-distance)/(8-1.5)，远慢近快
- 换静态低模：Cube Pig 替换胶囊；理解资源包模块化（身体/脸/尾巴分开，Full 已拼好）；逻辑/外观分离（根挂脚本碰撞体、模型当子物体）
- Bug 修复：BGM 重开无声（Play 逻辑并入 SetMusicOn，原只在 Awake 播一次）；暂停滑块被挡（关 BossText raycast）
- 里程碑验收：继承多态口头抽查通过（virtual/override、is-a 关系、左边定能调谁/右边定执行谁）
- 待办：Mathf.Clamp01 夹紧追击进度（可选）；暂停面板补音乐 Toggle；D31 阶段1 最后冲刺

## D31 完成（10/20）Demo1 核心战斗收尾 + 金币模型与掉落

- 任务重设计（用户主导）：取消小怪 Flee 逃离（"玩过的游戏没有打他会跑的，除了 MC 村民"），改为玩家跑出 >8m 怪物回巡逻并**脱战回血**；Boss 血量 <30% 进入**狂暴**（伤害↑、前摇↓、速度↑、体型↑、变橙）；去掉场景散落金币，只保留打怪掉落。
- 脱战回血：Enemy 加 maxHp=5，Chase 状态且 distance>lostRange 时 hp=maxHp 并切回 Patrol（黑魂/WOW 标准脱战重置，鼓励持续输出）。
- Boss 狂暴：不是新 enum 状态，而是**模式开关 bool enraged**（Boss 仍在 Chase/Attack 里，只是参数变）；TakeDamage 先扣血再判 `!enraged && hp<=maxHp*0.3` 触发一次；改 attackATK 15→25、windupTime 0.7→0.3、chaseSpeed 2→4、模型放大 1.5 倍、颜色变橙 Color(1,0.4,0)；HurtRoutine 结束按 enraged 恢复狂暴色。
- 狂暴三连 bug：①狂暴晚一刀（先判狂暴再扣血，用扣血前血量判断）；②缺 !enraged 守卫，每刀重复触发、baseScale 无限翻倍；③缩放根物体连 BoxCollider 一起放大，玩家被物理挡在攻击范围外打不到——修复原则：**缩放只改模型子物体，根物体（碰撞体/位置/攻击距离）永远不动**。
- Boss 换猪：猪渲染器在子物体深处，GetComponent<Renderer>() 只搜自身返回 null，下一行 material.color 空引用中断 Start，导致 baseScale 和 state=Chase 未执行、Boss 永久卡 Idle；改 GetComponentInChildren<Renderer>()。
- 金币模型：根+模型子结构（Coin 根挂 SphereCollider 触发器+Coin+CoinMotion；CoinModel 子物体圆柱 Rotation X=90 立起、Scale(1,0.15,1) 压扁、金色材质 Metallic=1/Smoothness=0.7）。
- 金币躺着根因：CoinSpawner 用 `Instantiate(prefab, pos, Quaternion.identity)`，identity 覆盖了预制体里 90°X 立起的旋转，生成的全平躺；根+子结构后根怎么生成都不影响模型立起。
- CoinMotion 悬空：根自转 transform.Rotate(0, spinSpeed*dt, 0)；模型上下浮动 model.localPosition.y = Mathf.Sin(Time.time*bobFreq)*bobAmount。新 API Mathf.Sin（匀速规律起伏的数字发生器，-1~1）。
- 关键坑：不能直接写 `model.position.y = ...`（position 是属性，返回 Vector3 复印件，改复印件无效，C# 直接报错）；必须用临时变量 Vector3 p 接住、改 p.y、再整个赋回。用 localPosition（相对父物体）而非 position（世界），否则浮动围绕世界 y=0 会脱离根。
- 掉落弹跳：用户决定暂不做（悬空够了，以后需要再写）。
- 怪物掉金币：Die() 里 for/while 循环 coinDropcount 次，Random.insideUnitCircle 算水平散开偏移，y+0.5 抬到拾取高度，Instantiate 金币；Coin.cs 用 spawner?.RemoveCoin 可空，掉落金币无 spawner 不报错。
- 死循环卡死：while(coinDropcount>0) 循环体里忘写 coinDropcount--，条件永远成立，Instantiate 每秒几千枚→内存爆→Unity 卡死。铁律：写 while 必须确认循环体里有"让条件变 false 的动作"；for 循环把初始化/条件/自增写一行最不容易漏。
- 每帧 Debug.Log 洪水：PatrolBehavior/ChaseBehavior 里 Debug.Log 每帧跑，多只怪叠加把 Console 刷爆拖死编辑器；原则：Debug.Log 很昂贵（抓堆栈），绝不放 Update 或每帧方法，只在状态切换那一刻打。
- 追击夹紧：Mathf.Clamp01(p) 返回值没接住等于没夹紧，改 p = Mathf.Clamp01(p)。
- 动画调研（推 D34/D35）：Cube Pig 包实际只有 3 个片段——Idle、Run Forward In Place、Run Forward W Root（无 Walk/Eat/Attack/Die）；Animator 已在 Pig W Root 上（Avatar=PigAvatar，Apply Root Motion 已关，Controller 当前为"无"）；D34/D35 自建 EnemyAnimator 控制器（float Speed 参数 + Idle/Run 两态），用 Run Forward In Place（脚本移动，不用根运动版）。
- Boss 掉金币：暂不做（Boss 死亡直接结束游戏无操作空间；应做成奖励形式但当前无背包系统，等以后有背包再做）。
- 旧脚本去向：RotateCube 通用旋转脚本文件保留（别处可复用），从金币移除、旋转逻辑并进 CoinMotion；CoinSpawner 场景物体已删（去散落金币），.cs 文件保留；Coin 拾取脚本保留。
- 待办：D32 录屏验收 + 首批投递准备；动画 Idle/Run 控制器（D34/D35）；Boss 奖励等背包系统；LeetCode 283/121；打磨期 exe 打包。
