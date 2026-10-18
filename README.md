# 游戏 AI 演示

从零开始学习 Unity 游戏开发与游戏 AI，记录所有练习 Demo 和学习笔记。

## 当前作品：MiniLevel 小游戏（W4 整合版）

第三人称 3D 动作小游戏：在场景中收集金币、击杀巡逻敌人，最终迎战 Boss。包含完整的主菜单、暂停、设置（音量+音乐开关）、胜负结算和本地存档。

### 游戏截图

**主菜单**（最高分 / 最近得分本地存档）

![主菜单](docs/screenshots/01_mainmenu.png)

**游戏中**（金币、巡逻小怪、Boss 登场倒计时）

![游戏中](docs/screenshots/02_gameplay.png)

**Boss 战**（五态 AI + 头顶血条）

![Boss战](docs/screenshots/03_boss.png)

**暂停菜单**（Esc 暂停、设置、返回主菜单）

![暂停菜单](docs/screenshots/04_pause.png)

**胜利结算**（本局得分 / 最高分 / 最近得分）

![胜利结算](docs/screenshots/05_victory.png)

### 玩法

- **目标**：收集金币、击杀小怪，最终击败 Boss
- **胜利条件**：击杀 Boss（6 点血量）
- **失败条件**：玩家血量归零
- **Boss 机制**：游戏开始 5 秒后倒计时 3 秒登场，五态有限状态机（巡逻 / 追击 / 攻击前摇 / 受击 / 死亡），攻击前摇 0.7 秒可躲避

### 操作

| 按键 | 功能 |
|------|------|
| W A S D | 移动 |
| 空格 | 跳跃 |
| K / 鼠标左键 | 攻击（触发前扑动画，3 米范围内造成伤害） |
| Esc | 暂停 / 关闭设置面板 |

### 敌人 AI（有限状态机 FSM）

**小怪（Enemy）三态**：按与玩家的距离自动切换

- **Patrol 巡逻**：在出生点附近两个巡逻点之间来回走
- **Chase 追击**：玩家进入侦测范围（5 米）后转身追击，8 米外丢失目标回巡逻
- **Attack 攻击**：贴脸（1.5 米）后站住，每隔 1 秒造成 10 点伤害

**Boss（Boss）五态**：

- **Patrol 巡逻**：在场内来回移动
- **Chase 追击**：发现玩家后以 2m/s 追击
- **Attack 攻击**：进入 3.5 米后前摇 0.7 秒，造成 15 点伤害，后摇 0.9 秒
- **Hurt 受击**：被击中后硬直 0.4 秒，播放受击音效
- **Die 死亡**：血量归零后播放胜利音效、显示结算面板

每帧流程：计算与玩家距离 → 互斥切换状态 → switch 分发到对应行为。

### 技术亮点

- **双 AudioSource 音频系统**：一个喇叭 PlayOneShot 播一次性音效（6 种），一个喇叭 loop 播 BGM，独立开关互不干扰
- **音乐开关存档**：Toggle 组件 + PlayerPrefs（int 存 1/0），跨局保留设置
- **攻击动画**：Animator 状态机 Idle / Move / Jump / Attack，Trigger 参数瞬间触发，AnyState 过渡实现移动中攻击
- **空气墙边界**：4 个无渲染 BoxCollider 围住场地，防止玩家和 Boss 掉出地图
- **Boss 出生点保护**：激活前检测玩家距离，小于 5.5 米时沿水平方向归一化推出，避免碰撞体重叠弹飞
- **事件驱动 UI**：金币拾取、血量变化、Boss 血量均通过 C# event / Action 通知 UI 更新，逻辑与界面解耦

## 目录结构

```
game-ai-demos/
├─ DailyPractice/                 # 每日 C# 控制台练习 + LeetCode
│  ├─ LeetCode/                   # 力扣刷题
│  ├─ Day14_Exam/                 # D14 闭卷自测：四件套角色系统
│  └─ Day14_Examples/             # D14 换皮练习：static / enum / 单例
├─ FristScene/                    # Unity 主项目（文件夹名沿用最初拼写）
│  └─ Assets/
│     ├─ Scenes/
│     │  ├─ MenuScene             # 主菜单（Build 0）
│     │  └─ MiniLevel             # 关卡（Build 1）
│     ├─ Scripts/
│     │  ├─ Player/               # 玩家移动、血量、攻击输入
│     │  ├─ Enemy/                # 小怪 AI、Boss AI、生成器、BossDirector
│     │  ├─ Items/                # 金币、陷阱
│     │  ├─ UI/                   # 菜单、血条、BossHpUI、结算、设置
│     │  └─ Game/                 # GameManager、AudioManager、SaveManager、GameConfig
│     ├─ Animations/              # 玩家动画控制器 + Attack.anim
│     ├─ Audio/                   # 音效 + BGM 素材
│     └─ Materials/               # 材质
├─ Helloworld/                    # C# 控制台 HelloWorld 入门项目
├─ selfintro/                     # 自我介绍练习
├─ notes/                          # 学习笔记与打卡记录
│  ├─ checkin.md                  # 每日打卡表
│  ├─ StudyNotes.md               # 每日学习笔记
│  ├─ cheatsheets.md              # 速查表
│  ├─ CSharp_Basics.md            # C# 基础笔记
│  ├─ week1.md                    # 第 1 周总结
│  ├─ week2.md                    # 第 2 周总结
│  ├─ week3.md                    # 第 3 周总结
│  └─ week4.md                    # 第 4 周总结
├─ Recordings/                    # 游戏录屏
├─ .gitignore
└─ README.md
```

## 阶段作品

- **MiniLevel（W4 整合版）**：完整可玩动作小游戏。主菜单 → 关卡，WASD 移动 / 空格跳跃 / K 攻击（Animator 四态动画），吃金币加分（事件驱动 UI），小怪三态 AI + Boss 五态 AI，双 AudioSource 音效+BGM，音乐开关存档，空气墙边界，Boss 出生点保护，胜负结算，音量+最高分+音乐开关 PlayerPrefs 存档。
- **MiniLevel（W3 整合作品）**：完整可玩小游戏。主菜单 → 关卡，WASD 移动 / 空格跳跃（Animator 动画），吃金币加分（事件驱动 UI），敌人 AI 三态（巡逻 / 追击 / 攻击），K 键反击，AudioManager 音效，胜负结算，音量 + 最高分 PlayerPrefs 存档。
- **MiniLevel（W2 里程碑）**：第一个完整可玩小关，镜头跟随、WASD 移动、空格跳跃（射线地面检测防空跳）、吃金币加分、终点弹胜利文字并锁定操作，全局由 GameManager 单例统一管理。
- **Practice_Rebuild**：空场景脱稿训练场，不看教程独立搭出刚体移动 + 触发检测。
- **Day14_Exam**：W2 闭卷自测，脱稿写出 Character 基类 + Player/Enemy 子类 + IDamageable 接口的回合制对战系统，一次跑通。

## 学习进度

### 第 1 周（W1）：C# 基础 + Unity 入门

- ✅ D1（9/3）：环境搭建 + GitHub 仓库 + C# HelloWorld
- ✅ D2（9/4）：Unity 安装 + 第一个场景 + 角色移动脚本
- ✅ D3（9/5）：简历骨架 + 打卡表 + 仓库整理
- ✅ D4（9/6）：C# 变量 / 类型 / 运算符 + Unity Transform 实操
- ✅ D5（9/8）：C# 条件 / 循环 + Unity 刚体物理移动与跳跃
- ✅ D6（9/9）：C# 数组 / 方法 + Unity 预制体 / 输入控制
- ✅ D7（9/10）：第一周复盘

### 第 2 周（W2）：面向对象 + 物理 + 可玩小关

- ✅ D8（9/11）：C# 面向对象 + 物理碰撞
- ✅ D9（9/12）：C# 继承 + 多态 + Unity 角色移动优化
- ✅ D10（9/13）：C# 多态 + 抽象类 + Unity 触发器 / 吃金币
- ✅ D11（9/14）：C# 接口 interface + Unity 接口实现
- ✅ D12（9/15）：封装 / 继承 / 多态 / 接口四件套整合 + 简单工厂
- ✅ D13（9/16）：C# 查漏（static / enum / namespace）+ 单例 + 可玩小关
- ✅ D14（9/17）：W2 复盘 + 闭卷自测（四件套 / static / enum / 单例）

### 第 3 周（W3）：委托事件 + 集合 + 动画 + UI + 整合

- ✅ D15（9/19）：委托 delegate / 事件 event / Action / Func + Unity 事件驱动
- ✅ D16（9/21）：Lambda + List 泛型集合 + Unity 批量生成管理
- ✅ D17（9/23）：Dictionary 字典 + Animator 动画 + 静态配置表
- ✅ D18（10/12）：Unity UI 系统（菜单 / 按钮 / Slider / 场景切换 / 暂停）
- ✅ D19（10/13）：状态机完善 + 主菜单设置 + PlayerPrefs 存档 + 事件解耦
- ✅ D20（10/14）：W3 整合，敌人 AI 状态机 + 玩家攻击 + 音效系统 + 完整流程

### 第 4 周（W4）：生命周期 + 协程 + 输入系统 + 场景存档 + 地基收官

- ✅ D21（10/15）：Unity 生命周期（Awake / Start / Update / FixedUpdate / LateUpdate / OnDestroy）
- ✅ D22（10/16）：协程 Coroutine（IEnumerator / yield return / WaitForSeconds / StopCoroutine）+ 技能 CD + BossDirector
- ✅ D23（10/17）：Input 系统 + 场景管理（SceneManager / 异步加载 / DontDestroyOnLoad）
- ✅ D24（10/17）：存档系统进阶（PlayerPrefs / JSON / SaveManager 整包存取）
- ✅ D25（10/18）：Boss 血条 / 攻击模式 / 死亡结算 + Input 移动闪避攻击 + Unity Recorder 录屏
- ✅ D26（10/18）：W4 复盘（速查表 + 闭卷自测 + 周总结 + 面试口述）
- ✅ D27（10/18）：地基期收官整合——攻击动画补全 + 试玩修 bug（空气墙 / 出生点保护）+ BGM 音乐开关存档 + 完整录屏 + README 更新

## 技术栈

- **语言**：C#
  - 面向对象：封装 / 继承 / 多态 / 接口 / 抽象类
  - 核心语法：流程控制、数组、方法、属性、static、enum、namespace、单例
  - 进阶：委托与事件、Lambda、List\<T>、Dictionary\<K,V>、协程 IEnumerator
- **引擎**：Unity（团结引擎 Tuanjie 1.10.2 / 编辑器 2022.3.62t14）
  - 物理：Rigidbody、Collider、OnCollision / OnTrigger、Raycast、空气墙
  - UI：UGUI（Canvas、Button、Text、Slider、Toggle、Panel）
  - 动画：Animator 状态机（Bool / Trigger 参数、AnyState 过渡、Transition Duration）
  - 音频：AudioSource（PlayOneShot / loop / mute）、AudioListener、双喇叭 AudioManager
  - 其他：SceneManager 场景切换、PlayerPrefs 本地存档、协程、Unity Recorder 录屏
- **版本控制**：Git / GitHub
- **开发工具**：VS Code / Rider

## 后续计划

- 游戏 AI：状态机（已入门）→ 行为树、寻路算法（A*、NavMesh）
- 继续：2D / 3D 小游戏 Demo 开发
- 打磨期：public 字段重构为 [SerializeField] private、代码规范统一、性能优化
