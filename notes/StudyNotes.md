# 游戏开发学习笔记

> 从零开始学习 Unity + C# 游戏开发，按天按步骤记录

---

# 📅 D1（第一天）：环境搭建 + C# 入门 + GitHub

## ☀️ 上午：环境搭建（3小时）

### 步骤1：安装团结引擎（Unity中国版）

1. 浏览器访问团结引擎官网
2. 下载「旧版本团结 Hub(Windows)」
   - ⚠️ 注意：新版 Tuanjie Cowork 是 AI 编程工具，需要许可证，不是传统 Unity Hub，不要下错
3. 安装团结 Hub
4. 打开 Hub，点「以后登录」可以先进入（也可以注册账号登录）
5. 在 Hub 里安装团结编辑器 1.10.2（约4.83GB，安装路径默认即可）
6. 安装完成后桌面会有 Tuanjie 快捷方式

**许可证说明：**
- 个人版完全免费
- 在 Hub → 设置（齿轮图标）→ 许可证 → 添加 → 获取免费个人版许可证
- 勾选同意协议，自动激活

---

### 步骤2：安装 VS Code

1. 浏览器访问 VS Code 官网，下载 Windows 版
2. 双击安装包，一路下一步
3. 安装路径保持默认即可
4. 可以勾选"创建桌面快捷方式"
5. 安装完成后打开 VS Code

---

### 步骤3：VS Code 装中文语言包

1. 打开 VS Code
2. 点左侧扩展图标（四个方块那个）
3. 搜索框输入 `Chinese`
4. 找到微软官方的「中文（简体）语言包」，点安装
5. 安装后重启 VS Code，界面就变成中文了

---

### 步骤4：VS Code 装 C# 扩展

1. 左侧扩展商店搜索 `C#`
2. 找到微软官方的 C# 扩展，点安装
3. 安装完成即可

---

### 步骤5：安装 .NET SDK

1. 浏览器访问 `https://dotnet.microsoft.com/zh-cn/download`
2. 下载 .NET SDK（不是 Runtime），选长期支持版
3. 双击安装包，一路下一步，安装路径默认
4. 安装完成后，**关闭所有 cmd 窗口，重新打开一个新的**
5. 输入 `dotnet --version` 验证，如果显示版本号就成功了

**如果提示"不是内部或外部命令"：**
1. 确认 `C:\Program Files\dotnet\dotnet.exe` 文件存在
2. 右键「此电脑」→ 属性 → 高级系统设置 → 环境变量
3. 在「系统变量」里找到 `Path`，点编辑
4. 点新建，添加 `C:\Program Files\dotnet`
5. 一路确定保存
6. 关闭所有 cmd，重新打开，再输入 `dotnet --version`

---

## 🌤️ 下午：GitHub + Git（3小时）

### 步骤6：注册 GitHub 账号并创建仓库

1. 浏览器访问 `https://github.com`，注册账号（用邮箱注册）
2. 登录后，点右上角 `+` → `New repository`
3. 仓库名输入：`game-ai-demos`
4. 选 Public（公开）
5. 勾选「Add a README file」
6. 描述可以写：游戏AI学习练习代码
7. 点「Create repository」创建完成

---

### 步骤7：安装 Git

1. 浏览器访问 Git 官网，下载 Windows 版
2. 双击安装包，一路下一步，所有选项保持默认
3. 安装完成后，打开 cmd，输入 `git --version` 验证

---

### 步骤8：配置 Git 身份（整台电脑只配一次）

打开 cmd，输入：
```bash
git config --global user.name "你的GitHub用户名"
git config --global user.email "你的注册邮箱"
```

> 配置一次永久生效，以后所有仓库都不用再配。

---

### 步骤9：克隆仓库到本地

1. 打开你的 GitHub 仓库页面，点绿色「Code」按钮，复制 HTTPS 地址
2. 打开 cmd，切换到你想存放的目录：
```bash
D:
cd D:\projects\xuexi\code
```
3. 克隆仓库：
```bash
git clone https://github.com/你的用户名/game-ai-demos.git
```
4. 克隆完成后，本地会多出 `game-ai-demos` 文件夹，这就是你的本地仓库

> 一个仓库只克隆一次，以后所有项目都放在这个文件夹里。

---

## 🌙 晚上：第一个 C# 程序（1.5小时）

### 步骤10：新建 C# 控制台项目

1. 打开 cmd，进入仓库根目录：
```bash
cd D:\projects\xuexi\code\game-ai-demos
```
也可以进入这个文件夹

清空上方地址栏 
输入cmd回车
dotnet new console   - n 文件夹名#创建一个新的文件项目
cd 文件夹名#进入文件夹 
code   .#用VScode打开文件夹
Ctrl+s#保存
dotnet run输出
2. 创建新项目：
```bash
dotnet new console -n HelloWord
```
3. 进入项目文件夹：
```bash
cd HelloWord
```
4. 运行看看默认效果：
```bash
dotnet run
```
会输出 `Hello, World!`

> 新建项目会自动生成一行默认代码 `Console.WriteLine("Hello, World!");`，这是模板自带的，可以全部删掉重写。

---

### 步骤11：用 VS Code 打开项目写代码

1. 打开 VS Code
2. 文件 → 打开文件夹 → 选择 `D:\projects\xuexi\code\game-ai-demos\HelloWord`
3. 如果弹出「是否信任此文件夹」，点「是，我信任此作者」
4. 左侧点开 `Program.cs`，这就是你写代码的文件
5. 练习变量声明，把代码改成：
```csharp
string name = "小明";
int age = 20;
double height = 1.75;

Console.WriteLine("大家好我叫" + name);
Console.WriteLine("我今年" + age + "岁");
Console.WriteLine("我的身高是" + height + "米");
Console.ReadKey();
```
6. 按 `Ctrl + S` 保存
7. 在 cmd 里输入 `dotnet run` 运行，看输出结果

**项目文件说明：**
- `Program.cs` = 你写代码的地方（唯一需要编辑的）
- `HelloWord.csproj` = 项目配置（自动生成，不用管）
- `.vscode/` = VS Code 配置（自动生成）
- `bin/` = 编译后的程序（运行后才生成，不用管）
- `obj/` = 编译临时文件（不用管）

---

### 步骤12：把代码推送到 GitHub

1. **退回仓库根目录**（重要！不能在 HelloWord 文件夹里执行 git）：
```bash
cd ..
```
2. 查看状态：
```bash
git status
```
3. 添加文件：
```bash
git add .
```
4. 提交：
```bash
git commit -m "添加第一个C#控制台程序"
```
5. 推送：
```bash
git push
```
6. 第一次 push 会弹出 GitHub 登录窗口，用浏览器授权登录即可
7. 推送成功后，刷新 GitHub 网页就能看到代码了

**Git 三步曲记住：**
- `git add .` = 选中文件
- `git commit -m "备注"` = 本地存档
- `git push` = 上传到云端

**铁律：git 命令必须在仓库根目录（game-ai-demos）执行，不能进到子项目文件夹里！**

---

# 📅 D2（第二天）：Unity 入门 + 第一个可移动物体

## ☀️ 上午：Unity 界面认识（3小时）

### 步骤1：打开 Unity 新建 3D 项目

1. 双击桌面的「Tuanjie Hub」打开
2. 点左侧「项目」→ 右上角「新建项目」
3. 模板选「3D」
4. 项目名：`FirstScene`
5. 位置选：`D:\projects\xuexi\code\game-ai-demos\`（放在仓库里方便推送）
6. 点「创建」，等待加载（第一次可能1-2分钟）

---

### 步骤2：认识六大界面区域

| 区域 | 位置 | 作用 |
|------|------|------|
| 层级面板（Hierarchy） | 左上角 | 列出场景里所有游戏物体 |
| 检查器（Inspector） | 右边 | 显示选中物体的属性和组件 |
| 场景视图（Scene） | 中间 | 编辑用的3D工作台 |
| 游戏视图（Game） | 中间 | 玩家实际看到的画面 |
| 项目面板（Project） | 左下角 | 资源仓库，管理所有文件 |
| 控制台（Console） | 左下角 | 报错和打印输出 |

**场景视图操作：**
- 按住鼠标右键拖动 = 旋转视角
- 滚轮滚动 = 放大缩小
- 按住鼠标中键拖动 = 平移视角

---

### 步骤3：理解核心概念

**GameObject（游戏物体）：**
- 场景里的每一个东西都是 GameObject（相机、灯光、玩家、地面）
- 本身是空容器，功能由挂在身上的组件决定

**Component（组件）：**
- 每个组件负责一个功能
- 每个物体必有 `Transform` 组件
- 相机有 `Camera` 组件，灯光有 `Light` 组件
- 检查器底部点「添加组件」可以加更多功能

**Transform（变换组件）：**
- 控制物体的位置（Position）、旋转（Rotation）、缩放（Scale）
- 选中物体后场景里出现彩色箭头：
  - 🔴 红色 = X轴（左右）
  - 🟢 绿色 = Y轴（上下）
  - 🔵 蓝色 = Z轴（前后）
- 拖动箭头就能移动物体

---

### 步骤4：创建/删除/重命名物体练习

1. 层级面板空白处右键 → 3D 对象 → 立方体（Cube）
2. 双击 Cube 重命名为 `Player`
3. 在检查器里把位置 Y 改成 `1`
4. 用鼠标拖动彩色箭头移动方块
5. 想删除物体：选中后按键盘 Delete 键（这个练习不用删，留着下午用）

---

## 🌤️ 下午：搭第一个小场景 + 移动脚本（3小时）

### 步骤5：创建地面（Plane）

1. 层级面板空白处右键 → 3D 对象 → 平面（Plane）
2. 检查器里位置 Y 保持 `0`
3. 平面默认很大，足够用

---

### 步骤6：调整相机视角

1. 层级面板选中 `Main Camera`
2. 检查器 Transform 设置：
   - 位置：X=`0`，Y=`6`，Z=`-8`
   - 旋转：X=`30`，Y=`0`，Z=`0`
3. 切到「游戏」标签，看看画面是不是俯视角度，能看到地面和方块

---

### 步骤7：创建 C# 移动脚本

1. 项目面板空白处右键 → 创建 → C# 脚本
2. 命名：`PlayerMove`（P和M大写）
3. 双击脚本，用 VS Code 打开
4. 把默认代码全部删掉，粘贴下面这段：

```csharp
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.World);
    }
}
```

5. 按 `Ctrl + S` 保存

**代码解释：**
- `moveSpeed` = 移动速度变量，可以在检查器里调整
- `Update()` = 每帧自动执行（一秒约60次）
- `Input.GetAxis("Horizontal")` = 检测 A/D 键
- `Input.GetAxis("Vertical")` = 检测 W/S 键
- `transform.Translate()` = 让物体移动
- `Time.deltaTime` = 让速度不受电脑帧率影响

---

### 步骤8：把脚本挂到 Player 上

1. 回到 Unity 编辑器
2. 从项目面板里按住 `PlayerMove` 脚本，拖到层级面板的 `Player` 物体上，松开
3. 选中 Player，看检查器最下面，应该多出 `Player Move (脚本)` 组件
4. 如果不小心拖了两次出现两个组件，点组件右上角三个点 → 移除组件，删掉多余的

---

### 步骤9：运行测试

1. 切到「游戏」视图
2. 点顶部中间的 ▶️ 播放按钮
3. 按键盘 **W/A/S/D**：
   - W = 往前
   - S = 往后
   - A = 往左
   - D = 往右
4. 看看方块是不是跟着移动了
5. 再点一次 ▶️ 停止运行

---

### 步骤10：调整移动速度

1. 停止运行状态下（必须停止，不然改的不保存）
2. 选中 Player，检查器里找到 `Move Speed`
3. 把数值从 3 改成 8，运行试试更快
4. 测试完改回 3 或你觉得舒服的速度

---

### 步骤11：配置 .gitignore 并推送 Unity 项目

**创建 .gitignore 文件：**
1. 用 VS Code 打开仓库文件夹 `game-ai-demos`
2. 左侧空白处右键 → 新建文件
3. 文件名输入 `.gitignore`（前面有个点，没有后缀）
4. 粘贴下面内容：
```
[Ll]ibrary/
[Tt]emp/
[Oo]bj/
[Bb]uild/
[Bb]uilds/
[Ll]ogs/
[Uu]ser[Ss]ettings/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db
[Dd]ebug/
[Rr]elease/
bin/
*.csproj.user
```
5. Ctrl+S 保存

**推送：**
1. 打开 cmd，进入仓库根目录：
```bash
cd D:\projects\xuexi\code\game-ai-demos
```
2. 查看状态（确认 Library/Temp 被忽略了）：
```bash
git status
```
3. 添加、提交、推送：
```bash
git add .
git commit -m "添加第一个Unity场景和WASD移动脚本"
git push
```

---

## 🌙 晚上：复习 + 笔记（1.5小时）

### 步骤12：整理学习笔记

1. 在仓库根目录新建 `notes` 文件夹
2. 把学习笔记放到 `notes` 文件夹里
3. 提交推送：
```bash
git add notes/
git commit -m "添加学习笔记"
git push
```

---

# 📌 常用命令速查表

## C# / .NET
```bash
dotnet new console -n 项目名   # 新建控制台项目
dotnet run                      # 运行程序
dotnet build                    # 编译
dotnet --version                # 查看版本
```

## Git
```bash
git clone 仓库地址              # 克隆仓库
git status                      # 查看状态
git add .                       # 添加全部
git add 文件夹名/               # 添加指定文件夹
git commit -m "备注"            # 提交
git push                        # 推送
git config --global user.name "名字"   # 配置用户名（一次）
git config --global user.email "邮箱"  # 配置邮箱（一次）
```

---

# ⚠️ 常见问题

1. **`dotnet` 不是内部或外部命令**
   → 没装 .NET SDK 或环境变量没配，参考 D1 步骤5

2. **`fatal: not a git repository`**
   → 在子文件夹里执行 git 了，退回到仓库根目录再执行

3. **双击 .exe 一闪而过**
   → 程序太短执行完就退出，用 `dotnet run` 运行，或代码末尾加 `Console.ReadKey()`

4. **.dll 用 Word 打开是乱码**
   → .dll 是电脑用的二进制文件，不是给人看的，不要打开

5. **GitHub 首页文件夹右侧提交消息变了**
   → 那是显示该文件夹最后一次改动的提交，不是修改历史，点「提交」按钮看完整历史

6. **Unity 运行时改参数不保存**
   → 必须在停止状态下改参数才会保存

7. **脚本挂了两次**
   → 检查器里点组件右上角三个点 → 移除组件，删掉多余的

---

# 第三日学习笔记
## Unity 核心概念

### 1. GameObject（游戏对象）
- 游戏里的一切「东西」都是 GameObject：玩家、敌人、子弹、地图、摄像机、灯光、UI
- 本身是空壳，什么都干不了，所有功能都靠挂组件
- 代码里用 `gameObject` 表示当前脚本所在的物体

### 2. Component（组件）
- 挂在 GameObject 上的「功能模块」，给物体赋予能力
- 一个物体可以挂多个组件，组合出各种功能
- 常见组件：
  - Mesh Renderer：让物体可见
  - Rigidbody：受重力、能被碰撞
  - Collider：能碰到东西、能被打中
  - Animator：播放动画
  - 自定义脚本（比如 PlayerMove.cs）：自己写的逻辑
- 在 Inspector 里点 Add Component 添加

### 3. Transform（变换组件）
- 每个 GameObject 天生自带，删不掉
- 管三件事：
  - Position（位置）：物体在哪
  - Rotation（旋转）：物体面朝哪
  - Scale（缩放）：物体多大
- 代码里用 `transform` 直接访问
- 移动物体：`transform.Translate(方向 * 速度 * Time.deltaTime)`

### 三者关系
GameObject 是容器（演员），Component 是功能（道具和技能），Transform 是最基础的组件（管位置、旋转、缩放）。


# 📅 D4（第四天）：C# 变量/类型/运算符 + Unity Transform 实操

## ☀️ 上午：C# 基础①（3小时）

### 步骤1：变量的声明、赋值与命名规则

**什么是变量：** 程序里的"小盒子"，用来存数据，每个盒子有名字和类型。

**声明语法：**
```csharp
// 类型 变量名;
int score;          // 声明整数变量
string playerName;  // 声明字符串变量
```

**赋值：**
```csharp
int score;       // 声明
score = 100;     // 赋值
int score = 100; // 声明+赋值合并（最常用）
score = 85;      // 重新赋值，覆盖旧值
```

**命名规则：**
- 只能用字母、数字、下划线
- 不能以数字开头
- 不能用C#关键字（int、class、void等）
- 区分大小写（Score和score是两个变量）

**命名习惯：** 局部变量用小驼峰（camelCase），第一个单词小写，后面首字母大写
- ✅ 正确：`playerName`、`moveSpeed`、`isGameOver`
- ❌ 不推荐：`playername`、`PlayerName`、`player_name`

---

### 步骤2：6种基本数据类型

| 类型 | 存什么 | 例子 | 后缀 | 用途 |
|------|--------|------|------|------|
| int | 整数 | `int a = 5;` | 无 | 分数、等级、人数 |
| float | 小数 | `float b = 3.14f;` | 必须加f | Unity里的位置、速度 |
| double | 高精度小数 | `double c = 3.14159;` | 无 | 科学计算、金融 |
| bool | 真/假 | `bool d = true;` | 无 | 开关、判断条件 |
| string | 一串文字 | `string e = "你好";` | 双引号 | 名字、对话文本 |
| char | 单个字符 | `char f = 'A';` | 单引号 | 性别、等级评定 |

**注意：**
- float 数字后面必须加 `f`，否则报错
- string 用双引号，char 用单引号且只能一个字符
- 整数除法会砍掉小数：`5 / 2 = 2`（不是2.5）
- 想要小数结果，至少一个数是小数：`5.0 / 2 = 2.5`

**类型转换：**
- 小类型→大类型自动转：`int → float → double`
- 大类型→小类型需强制转换：`int d = (int)3.14f;`（结果是3，小数被砍）

---

### 步骤3：运算符

**算术运算符：**
| 符号 | 作用 | 例子 | 结果 |
|------|------|------|------|
| + | 加 | `5 + 3` | 8 |
| - | 减 | `5 - 3` | 2 |
| * | 乘 | `5 * 3` | 15 |
| / | 除 | `5 / 2` | 2（整数砍小数） |
| % | 取余 | `5 % 2` | 1 |

**比较运算符（结果是bool）：**
| 符号 | 作用 | 例子 | 结果 |
|------|------|------|------|
| == | 等于 | `5 == 5` | true |
| != | 不等于 | `5 != 3` | true |
| > | 大于 | `5 > 3` | true |
| < | 小于 | `5 < 3` | false |
| >= | 大于等于 | `5 >= 5` | true |
| <= | 小于等于 | `5 <= 3` | false |

**⚠️ 超级重要：`=` vs `==`**
- `=` 是赋值：`x = 5;`（把5放进x）
- `==` 是比较：`x == 5`（判断x是不是5，结果true/false）

**逻辑运算符：**
| 符号 | 作用 | 口诀 | 例子 | 结果 |
|------|------|------|------|------|
| && | 与（并且） | 全真才真，一假就假 | `true && false` | false |
| \|\| | 或（或者） | 一真就真，全假才假 | `true \|\| false` | true |
| ! | 非（取反） | true变false，false变true | `!true` | false |

---

### 步骤4：综合练习 - 输入两数计算和差积商余

**控制台输入：**
```csharp
Console.Write("请输入第一个数：");
string input = Console.ReadLine();  // 读取用户输入的一行文字
int num = int.Parse(input);         // 把文字转成整数
```

**完整代码：**
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入第一个数：");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("请输入第二个数：");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("和：" + (num1 + num2));
        Console.WriteLine("差：" + (num1 - num2));
        Console.WriteLine("积：" + (num1 * num2));
        Console.WriteLine("商：" + (num1 / num2));
        Console.WriteLine("余：" + (num1 % num2));
        
        Console.ReadKey();
    }
}
```

**⚠️ 常见坑：**
- `Console.WriteLine("和：" + num1 + num2)` 不加括号会变成字符串拼接
- 正确写法：`Console.WriteLine("和：" + (num1 + num2))`

---

## 🌤️ 下午：Unity Transform 实操（3小时）

### 步骤1：打开项目，复习场景搭建

1. 打开 Unity Hub，点击项目打开
2. 右键 Hierarchy → 3D Object → Cube 创建立方体
3. 选中Cube，Inspector面板最上方是 Transform 组件
4. Transform 三个属性：Position（位置）、Rotation（旋转）、Scale（缩放）
5. 快捷键：W=移动工具，E=旋转工具，R=缩放工具

---

### 步骤2：代码设置物体位置 + 每帧匀速移动

**Unity脚本基本结构：**
```csharp
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 2f;  // public变量会显示在Inspector面板

    void Start()
    {
        // 游戏开始时执行一次
        transform.position = new Vector3(3, 1, 0);
    }

    void Update()
    {
        // 每帧执行
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
```

**关键概念：**
- `MonoBehaviour`：Unity脚本基类，必须继承
- `Start()`：游戏开始第一帧执行一次，用于初始化
- `Update()`：每帧执行（约每秒60次），用于持续逻辑
- `transform`：代表物体的Transform组件
- `transform.position`：物体的位置（Vector3类型）
- `transform.Translate(方向)`：让物体相对当前位置移动
- `Vector3.forward`：正前方（Z轴正方向）
- `Time.deltaTime`：上一帧到这一帧的时间（秒），乘了之后速度不受帧率影响

**⚠️ 为什么乘Time.deltaTime：**
- 不乘：每帧移动固定距离，帧率高跑得快，帧率低跑得慢
- 乘了：速度×时间=距离，表示"每秒移动多少米"，所有设备速度一致

---

### 步骤3：物体绕Y轴旋转

```csharp
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float rotateSpeed = 50f;

    void Update()
    {
        // 绕Y轴旋转，每秒转50度
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
    }
}
```

**三个轴的效果：**
- `new Vector3(50, 0, 0)`：绕X轴转（翻跟头）
- `new Vector3(0, 50, 0)`：绕Y轴转（转圈，最常用）
- `new Vector3(0, 0, 50)`：绕Z轴转（钟表指针）

---

### 步骤4：WASD键盘控制位移

```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
```

**关键概念：**
- `if (条件) { 代码 }`：条件成立时执行
- `Input.GetKey(KeyCode.W)`：检测W键是否被按住，返回bool
- 常用键：KeyCode.W/A/S/D

**⚠️ 运行不移动的常见原因：**
1. 脚本没挂到物体上
2. 运行后没点击Game视图获取焦点
3. Move Speed在Inspector里被改成0了
4. 其他脚本冲突（比如MoveCube速度设太快）

---

## 🌙 晚上：2个小练习（1.5小时）

### 步骤1：判断一个数是奇数还是偶数

**原理：** 除以2，余数0是偶数，余数1是奇数

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入一个整数：");
        int num = int.Parse(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " 是偶数");
        }
        else
        {
            Console.WriteLine(num + " 是奇数");
        }
        
        Console.ReadKey();
    }
}
```

**if...else 结构：**
```csharp
if (条件)
{
    // 条件成立执行
}
else
{
    // 条件不成立执行
}
```

---

### 步骤2：摄氏温度转华氏温度

**公式：** F = C × 9/5 + 32

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入摄氏温度：");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 9.0 / 5 + 32;
        Console.WriteLine(celsius + "°C = " + fahrenheit + "°F");
        Console.ReadKey();
    }
}
```

**⚠️ 注意：** `9.0 / 5` 必须有一个是小数，否则 `9 / 5 = 1`（整数除法砍小数）

---

### 步骤3：Git 提交 + 打卡

```bash
git add DailyPractice/
git commit -m "D4晚上：判断奇偶+温度转换练习"
git push
```

更新 `notes/checkin.md`，勾选D4完成，写学习总结。

---

## 📌 D4 核心要点总结

1. **C#变量：** 声明要指定类型，赋值用=，float加f
2. **6种类型：** int/float/double/bool/string/char，各有用途
3. **运算符：** 算术/比较/逻辑，注意`=`和`==`的区别
4. **Unity脚本：** Start()执行一次，Update()每帧执行
5. **移动：** transform.Translate(方向 × 速度 × Time.deltaTime)
6. **旋转：** transform.Rotate(旋转角度 × Time.deltaTime)
7. **键盘控制：** if (Input.GetKey(KeyCode.W)) + Translate
8. **if...else：** 条件判断，奇偶判断、温度转换都用到

## D5 学习笔记（2026-09-08）

### 一、C# 条件语句

#### 1. if / else if / else（多条件分支）
- if：第一个条件；else if：中间条件，可写多个；else：全部不满足时兜底
- 从上往下判断，命中一个就跳出，后面不再判断
- 范围判断（>=、<）只能用if，switch做不到
```csharp
if (score >= 90) { Console.WriteLine("优秀"); }
else if (score >= 60) { Console.WriteLine("及格"); }  // 走到这说明<90
else { Console.WriteLine("不及格"); }
```

#### 2. switch（固定值匹配）

- 只能判断"变量等于哪个固定值"，适合星期、菜单、状态
- case后必须跟break；default相当于else

```
switch (day)
{
    case 1: Console.WriteLine("星期一"); break;
    case 7: Console.WriteLine("星期日"); break;
    default: Console.WriteLine("输入有误"); break;
}
```

#### 3. 三元运算符（if-else简写，二选一赋值）

- 语法：`条件 ? 成立的值 : 不成立的值`

```
string result = num % 2 == 0 ? "偶数" : "奇数";
int max = a > b ? a : b;   // 取较大值
```

### 二、C# 循环

#### 1. for（知道循环次数时用）

- 结构：for(初始化; 条件; 更新){}，执行顺序：初始化1次→判断→执行→更新→再判断
- i++ 是 i=i+1；i-- 是 i=i-1；i+=2 是每次加2

```
for (int i = 1; i <= 10; i++) { Console.Write(i + " "); }
```

- 累加器求和：int sum=0; 循环里 sum=sum+i;
- 计数器数个数：int count=0; 满足条件时 count++;

#### 2. while（不知道次数、只知道停止条件时用）

- 循环变量写在外面，更新(i++)必须写在循环体里，否则死循环
- 死循环时按 Ctrl+C 停止

```
int i = 1;
while (i <= 10) { Console.Write(i + " "); i++; }
```

#### 3. do-while（先执行一次，再判断）

- 无论条件是否成立，循环体至少执行1次；末尾while(条件)后有分号

```
do { 输入密码; } while (pwd != 888);
```

#### 4. break 和 continue

- break：立刻结束整个循环（找到目标就停）
- continue：只跳过本次，继续下一次（跳过不想要的）
- 对比1-10遇到7：break输出123456；continue输出123456 8 9 10

#### 5. 嵌套循环（外层管行，内层管列）

- 外层走1步，内层走完一整圈；内层结束后换行

```
// 九九乘法表
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write(j + "x" + i + "=" + (j*i) + "\t");
    Console.WriteLine();
}
```

### 三、综合实战：密码登录（最多3次）

- while循环反复输入 + 计数器记次数 + if判对错 + break跳出
- 关键：用 bool isSuccess 标志位区分"输对退出"还是"次数用完"
- 教训：不能用 times==0 判断结果（第3次才输对时times也是0，会误判）

```
string correct = "123456";
int times = 0;
bool isSuccess = false;
do {
    Console.Write("请输入密码：");
    string input = Console.ReadLine();
    times++;
    if (input == correct) { isSuccess = true; break; }
    else Console.WriteLine("错误，还剩" + (3-times) + "次");
} while (times < 3);
Console.WriteLine(isSuccess ? "欢迎" : "锁定");
```

### 四、Unity 物理系统

#### 1. Rigidbody（刚体）与 Collider（碰撞体）

- transform.Translate 只是改坐标，无重力无碰撞，会穿过物体
- Rigidbody：物理身体，让物体受重力、受力、有碰撞反应（需手动Add Component添加）
- Collider：碰撞轮廓，Cube/Plane基础物体自带，不用手动加
- 只有Collider没Rigidbody=不动的墙（地面）；有Rigidbody才会掉、会被推动

#### 2. Rigidbody 常用参数

- Mass质量(kg)：自由落体快慢与质量无关
- Use Gravity使用重力：勾上才往下掉
- Is Kinematic运动学：勾上后物理引擎不推动它，只能用transform控制
- Constraints约束：Freeze Rotation勾X/Z可防止角色移动时翻倒（玩家要保持直立）

#### 3. velocity 物理移动（WASD）

- GetComponent()：在Start里取出同物体上的刚体存进rb
- 物理代码写 FixedUpdate（固定物理帧），不写Update
- Input.GetKey 按住持续触发；rb.velocity设速度
- 必须保留 rb.velocity.y，否则重力被每帧清零，掉不下去

```
public float moveSpeed = 5f;
private Rigidbody rb;
void Start() { rb = GetComponent<Rigidbody>(); }
void FixedUpdate()
{
    float moveX = 0f, moveZ = 0f;
    if (Input.GetKey(KeyCode.W)) moveZ = 1f;
    if (Input.GetKey(KeyCode.S)) moveZ = -1f;
    if (Input.GetKey(KeyCode.A)) moveX = -1f;
    if (Input.GetKey(KeyCode.D)) moveX = 1f;
    rb.velocity = new Vector3(moveX*moveSpeed, rb.velocity.y, moveZ*moveSpeed);
}
```

- Vector3(x,y,z)对应红X左右、绿Y上下、蓝Z前后；正数沿箭头、负数反向

#### 4. AddForce 跳跃

- AddForce(方向*力, ForceMode.Impulse)：Impulse瞬间爆发，适合跳跃
- 跳跃用 Input.GetKeyDown（按下瞬间一次），放Update里防止漏按

```
public float jumpForce = 5f;
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
}
```

#### 5. 落地检测（防止空中无限跳）

- bool isGrounded记录是否在地面
- OnCollisionEnter碰到的瞬间=true；OnCollisionExit离开的瞬间=false
- 跳跃条件加 && isGrounded，只有地面能跳

```
private bool isGrounded = false;
void Update() {
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
}
void OnCollisionEnter(Collision c) { isGrounded = true; }
void OnCollisionExit(Collision c) { isGrounded = false; }
```

#### 6. 物理地形测试结论

- 斜坡：方块平底+摩擦大，缓坡会停住；球体易滚下；坡越陡下滑力越大
- 开不上坡的原因：坡太陡/速度太小/坡脚有断面；解决：坡15-20°、速度调大、坡底插进地面
- 冻结旋转不影响上坡，玩家本就该保持直立
- 撞台阶被Collider挡住不穿透；冲出悬空边缘会坠落
- 真正贴任意坡面移动要用到射线+法线投影/CharacterController，后续学

### 五、晚间练习：猜数字

- Random random=new Random(); int answer=random.Next(1,101);
- Next(最小,最大+1)：上限不包含，Next(1,101)才取得到100
- while(true)死循环+猜中break，count记次数

```
Random r = new Random();
int answer = r.Next(1, 101), count = 0, guess = 0;
while (true) {
    guess = int.Parse(Console.ReadLine());
    count++;
    if (guess > answer) Console.WriteLine("大了");
    else if (guess < answer) Console.WriteLine("小了");
    else { Console.WriteLine("猜中，共"+count+"次"); break; }
}
```

### 六、今日易错点

1. while循环体里忘写i++导致死循环 → Ctrl+C
2. switch每个case后忘break
3. velocity的y写成0导致物体不掉
4. 跳跃用GetKey会飞天，必须GetKeyDown
5. 空中能二段跳 → 用isGrounded落地检测
6. Is Kinematic勾着时velocity/AddForce都无效
7. random.Next(1,100)最大只到99，要写101

## D6（2026-09-09）数组·方法·冒泡 + Unity预制体与平滑输入

### 一、C# 数组
- 三种声明：int[] a=new int[5]; / int[] b=new int[]{80,90}; / int[] c={1,2,3};
- 下标从0开始，最后一个=Length-1；遍历条件用 i<Length（写成<=会越界 IndexOutOfRangeException）
- foreach(int x in 数组)：只读遍历，拿不到下标、不能改元素
- 用户输入存数组：先 new int[n] 开空格 → for里 scores[i]=int.Parse(Console.ReadLine())
- string.Join("分隔符", 数组)：把数组拼成一串文字方便打印

### 二、C# 方法
- 四件套：方法名+参数+返回值+逻辑；写在Main外、class内，要加 static
- return 一执行方法立刻结束；开头先拦非法数据叫"卫语句"
- 坑：int是值类型，传进方法的是副本，方法里交换a/b改不到外面数组（以后学ref解决）

### 三、冒泡排序（第一个算法）
- 思路：相邻两个比较，左边比右边大就交换，每轮把最大的"冒"到最右
- 结构：外层走 Length-1 轮；内层 j<Length-1-i；用temp三行交换
- 用到 j+1 时 j 必须小于 Length-1，否则越界

### 四、Max(int[] arr) 打擂台
- int max=arr[0];（初始用第一个，不能用0，否则全负数会错）
- 从 i=1 遍历，arr[i]>max 就更新，最后 return max

### 五、Unity 预制体 Prefab
- 把做好的物体拖进Project窗口=存成模板（图标/名字变蓝），可无限复制
- public GameObject xxx; → 检查器出现槽 → 把预制体拖进去（没拖会报 NullReferenceException）
- 给"预制体文件"加组件=它生成的所有副本都带这个组件

### 六、Instantiate 生成物体
- Instantiate(物体, 位置, 旋转)；Quaternion.identity=不旋转
- 要用变量接住生成结果才能继续控制：GameObject ball=Instantiate(...)
- 批量生成：for循环 + 位置随 i 变化（否则全叠在一起）

### 七、输入与发射器
- Input.GetAxis("Horizontal")管左右x、("Vertical")管前后z，返回-1~1平滑值，一行替代4个if
- GetKey=按住一直触发；GetKeyDown=按下那一帧触发一次
- Debug.Log=打印到Unity Console（等同C#的Console.WriteLine）
- 发射器：按空格 Instantiate球 → 取刚体 → rb.velocity=transform.forward*速度
- transform.position=自己的位置；transform.forward=自己的正前方（会随旋转变）

### 八、今日易错清单
1. 循环用 j+1 却写 j<Length → 越界
2. 把值类型交换封进普通方法 → 改不到原数组
3. Max初始值写0 → 全负数组出错，要用arr[0]
4. public槽忘拖预制体 → 空引用
5. GetKey/GetKeyDown混用 → 按住会疯狂生成

## D7 学习笔记（9/10 周四 · 第1周复盘日）
> 今日定位：不学大量新内容，把D4-D6串成体系、补漏洞、修bug、做周总结

### 一、C# 查漏补缺（系统版见 notes/CSharp_Basics.md）
今天亲手写例子时纠正的点：
1. for循环里 i 是"下标"、arr[i] 才是"元素值"：打印 i 出序号0123，打印 arr[i] 才出数组内容
2. Console.ReadLine()/WriteLine() 前面的 Console. 不能丢
3. 值类型传方法是"副本"：Change(int x){x=100;} 改不到外面的 n（n 仍是1）
4. string.Join("分隔符", 数组) 是两个参数、用逗号；误写成 " "+数组 只剩一个参数，会报 CS0121 二义性
5. 冒泡排序能独立默写：外层 Length-1 轮、内层 Length-1-i、temp 三行交换
6. 打擂台：擂主初始用 arr[0]，不能用0（全负数会错）

### 二、Unity：整合三功能 + 修碰撞bug（今天重点）
1. 控制整理：
   - 玩家只保留 PlayerPhysicsMove（刚体移动+跳跃），禁用 AxisMove
     （Translate直接改坐标 和 刚体velocity 同时开会互相打架）
   - 发射键由空格改成 J，把空格专门留给跳跃
2. ⭐bug：玩家被自己发射的球撞到后就不能跳了
   - 根因：落地开关 isGrounded 没区分碰撞对象；球离开玩家时 OnCollisionExit
     误把 isGrounded 置成 false，可脚其实还踩在地上
   - 解决：先给地面加标签 Tag=Ground，碰撞方法里只认地面：
     void OnCollisionEnter(Collision other){
         if (other.gameObject.CompareTag("Ground")) isGrounded = true;
     }
     void OnCollisionExit(Collision other){
         if (other.gameObject.CompareTag("Ground")) isGrounded = false;
     }
   - 场景里有多个碰撞体时，OnCollision里必须用Tag/名字
     判断"撞到的到底是谁"，否则状态会互相干扰（落地/命中/吃道具都靠它）

### 三、工程与产出
- 三功能成品：WASD刚体移动 + 空格跳跃 + J发射预制体，全部能跑
- 录屏存档（Win自带录屏调不出，最终手机拍屏）
- 新增 notes/CSharp_Basics.md（系统笔记）、notes/week1.md（周总结）
- 当天代码与笔记 git 提交推送

## 📅 D8（2026-09-11 周五）：C# 面向对象入门 + Unity 碰撞事件与刚体

---

## 🌞 上午：C# 面向对象（类、对象、构造函数、this）

### 步骤1：类和对象
- **一句大白话**：类(class)是「图纸」，对象是按图纸造出来的「实物」，`new` 就是「按图纸造一个」。
- **和 Unity 对应着记**（🔰 不用死记，用多就通）：

| C# 概念 | Unity 里对应 |
|---|---|
| 类 class（图纸） | 预制体 Prefab |
| 对象/实例（实物） | 场景里飞出去的一颗颗子弹 |
| new（造对象） | Instantiate（生成预制体） |

### 步骤2：字段、方法、构造函数、this
```csharp
class Player
{
    public string name;    // 字段：名字（public=公开，类外面也能用）
    public int hp;         // 字段：血量
    public int attack;     // 字段：攻击力

    // 构造函数：和类【同名】、没有返回类型，new 的瞬间自动执行一次
    public Player(string name, int hp, int attack)
    {
        this.name = name;  // this.name 是"自己的字段"，等号右边是参数
        this.hp = hp;      // 同名时用 this 区分：左边字段、右边参数
        this.attack = attack;
    }

    // 方法：掉血
    public void TakeDamage(int damage)
    {
        hp = hp - damage;  // 血量 = 血量 - 受到的伤害
    }

    // 方法：攻击别人，把"对方对象"当参数传进来
    public void Attack(Player target)
    {
        target.TakeDamage(this.attack); // 让对方掉血，伤害值用我自己的(this.attack)
    }
}
```
Main 里使用：
```csharp
Player p1 = new Player("小明", 100, 10); // 按图纸造对象1
Player p2 = new Player("小红", 100, 15); // 造对象2，各自有独立的血量
p1.Attack(p2);                           // 小明攻击小红
```

### ⚠️ 注意（上午踩的坑）
- **类成员前面不写 public/private，默认是 private（私有）**：只有自己类内部能用，类外面(Main)访问会报 CS0122。要在外面读 `对象.字段`，字段必须加 `public`。
- 构造函数必须**和类同名、不写返回类型（连 void 都不写）**。
- `this` 只在「字段和参数同名」时用来区分，不会就先照着写。

---

## 🌤 下午：Unity 碰撞事件 + 刚体参数

### 步骤1：认识 OnCollisionEnter（碰撞开始事件）
- **大白话**：当物体「刚碰到」另一个物体的**那一帧**，Unity 自动调用一次，不用我们手动调（和 Start/Update 一样是固定名字，不能拼错）。
- ⚠️ **现在就要记**：Enter 只在接触的那一帧执行**一次**，一直顶住不会狂刷；退开再撞才再触发一次。

### 步骤2：碰撞事件能触发的 3 个条件（⚠️现在就要记）
1. 两个物体**都要有碰撞体 Collider**
2. **至少一方带刚体 Rigidbody**（玩家有）
3. 两个碰撞体**都不能勾 Is Trigger**（勾了变触发器，得用 OnTriggerEnter，以后学）

### 步骤3：用 Tag 标签 + CompareTag 区分撞到谁
- Tag=给物体贴的「分类名」，比用名字判断更规范（名字可乱改、Tag 是统一分类）。
- 操作：选中红方块 → 顶部 Tag → Add Tag 新建 `Trap` → 再把红方块 Tag 选为 Trap。

### 步骤4：PlayerHealth 完整代码（碰陷阱掉血）
```csharp
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 100;       // 生命值，public 才能在检查器里看到、调整
    public int damage = 10;    // 每次撞机关掉的血

    // 碰撞开始那一帧自动执行；other=被我们撞到的那个物体
    private void OnCollisionEnter(Collision other)
    {
        // 只有对方标签是 Trap（机关）才进来掉血
        if (other.gameObject.CompareTag("Trap"))
        {
            hp = hp - damage;                        // 掉血
            Debug.Log("碰到机关，剩余血量：" + hp);   // 打印剩余血量
        }
        // 撞到地面标签不是 Trap，if 不成立，什么都不发生
    }
}
```
### ⚠️ 注意
- `CompareTag("Trap")` 引号里的词必须和 Tag **大小写完全一致**，写成 "trap" 永远匹配不上。
- 一个物体可挂多个脚本：PlayerPhysicsMove 管移动、PlayerHealth 管掉血，各管各的。

### 步骤5：刚体 Mass（质量）/ Drag（阻力）手感
| 移动方式 | 受 Mass/Drag 影响吗 | 特点 / 用途 |
|---|---|---|
| `rb.velocity = ...` | **基本不受影响** | 直接命令速度，手感稳定 → 角色移动常用 |
| `rb.AddForce(...)` | **受影响** | 施加力，越重越难推、Drag 越大越被拖慢 → 跳跃/爆炸/撞飞 |

- 实验结论：Mass 从 1 改成 10，WASD（velocity）照样跑，但**跳跃（AddForce 冲量）几乎跳不起来**——因为「速度变化=力÷质量」，重10倍就要10倍的力。
- 体验完还原：Mass=1、Drag=0。

---

## 🌙 晚上：独立写 Enemy 类 + 回合制对打

### 实现思路（拆步骤，治"没思路"）
1. 写 Enemy 类：字段 name/hp/attack（都 public）+ 构造函数(this) + TakeDamage
2. `Attack(对方)` 把对方对象当参数，调对方的 TakeDamage
3. Main 里 new 一个玩家、一个敌人
4. `while` 循环轮流对打，**先手打完立刻判对方死没死，死了立刻 break，不让尸体反击**

### ⚠️ 注意（今晚的逻辑重点）
- 正确顺序：玩家打 → **立刻判敌人死没死(死就break)** → 敌人才反击 → 再判玩家死没死。
- 反例（错误）：两个人都打完再统一判断 → 会出现"敌人都死了还反击一下"，甚至同归於尽时胜负判反。

### 🛠 排错经验：Unity 进 Safe Mode 报 Internal build system error
- 现象：进安全模式、报 `BuildProgram exited with code -532462766`，且**没有 CS 开头的脚本错误**。
- 结论：不是代码错，是 Unity 编译缓存/构建进程崩了。
- 解决顺序：① 完全关 Unity 和 Hub → ② 删项目里的 `Library、Temp、obj` 缓存（**Assets 绝不能删**）→ ③ 重启电脑让它重新导入。空项目也崩=环境问题，不是某个项目的问题。

# 📅 D9 学习笔记（2026-09-12 周六）：C# 继承与多态 + Unity 射线地面检测 / 平滑移动

---

## 🌞 上午：C# 继承（面向对象核心）

> 大白话：继承 = 子类白捡父类的字段和方法，解决"多个类有重复代码"的问题。父类也叫基类，子类也叫派生类。

### 步骤1：继承的基本语法 `class 子类 : 父类`
- 写法：`class Player : Character`，Player（玩家）就自动拥有 Character（角色）里的字段和方法。
- ⚠️ 现在就要记：**构造函数不会被继承**，子类要自己写构造（用 base 转交，见步骤2）。
- 父类一旦自己写了带参数的构造，编译器就不再送"无参构造"，所以空的子类可能报错，需要用 base。

### 步骤2：base —— 子类构造把参数上交父类
```csharp
// 子类构造后面加 : base(参数)，把参数转交给父类构造去初始化
public Player(string name, int hp, int attack) : base(name, hp, attack)
{
    // 方法体可以是空的，因为初始化都交给父类构造做了
}
```
- `base(...)` 用在构造函数后 = 调父类构造；
- `base.Move()` 用在重写方法内部 = 调父类那个被重写的原版方法。

### 步骤3：virtual / override —— 子类改写父类方法
- 父类方法加 **`virtual`**（虚方法）= 允许被子类重写，给一个默认版本；
- 子类写同名同参方法加 **`override`** = 用自己的版本替换。
- ⚠️ 现在就要记：**方法签名（方法名 + 参数 + 返回类型）必须和父类完全一致**，只把 virtual 换成 override；**方法体 {} 里面随便改、随便加代码**。
- 两种重写风格：

| 风格 | 写法 | 效果 |
|---|---|---|
| 完全替换 | 不写 base.Move()，只写自己的代码 | 父类版本不要了，全用子类的（今天用的） |
| 扩展增强 | 先写 base.Move(); 再追加自己的代码 | 先跑父类逻辑，再追加子类逻辑 |

- 🔰 IDE 输入 override 会自动生成重写骨架（里面自带一句 base.Move();），这是语法模板不是 AI 补全，可以用；完全替换时把那句 base.Move(); 删掉即可。

### 步骤4：protected —— 继承配套的访问修饰符

| 修饰符 | 本类内部 | 子类内部 | 类外（Main / 对象.字段） |
|---|---|---|---|
| `public` 公开 | ✅ | ✅ | ✅ 谁都能访问 |
| `protected` 受保护 | ✅ | ✅ | ❌ 访问不到 |
| `private` 私有（不写默认它） | ✅ | ❌ | ❌ |

- ⚠️ 现在就要记：**protected = 本类 + 子类可见，类外不可见**。字段一般用 protected/private 保护起来，外部只能通过 public 方法（如 TakeDamage）间接改，这叫"封装"。
- 注意：protected 管的是"字段访问权限"，**不影响能不能 new 父类**；想禁止 new 父类要用 `abstract`（以后学）。

### 上午完整代码（Character 父类 + Player/Enemy 子类）
```csharp
using System;

class Character // 父类：抽出公共部分
{
    protected string name;   // protected：本类+子类能用，类外不能直接碰
    protected int hp;
    protected int attack;

    public Character(string name, int hp, int attack) // 父类构造
    {
        this.name = name;   // this.name 是对象自己的字段，右边 name 是参数
        this.hp = hp;
        this.attack = attack;
    }

    public void TakeDamage(int damage, Character attacker)
    {
        hp = hp - damage;
        Console.WriteLine(this.name + " 受到 " + attacker.name + damage + " 点伤害，剩余血量：" + hp);
    }

    public void Attack(Character target)
    {
        Console.WriteLine(this.name + " 攻击 " + target.name);
        target.TakeDamage(this.attack, this); // 让挨打方扣血，把攻击者自己传进去
    }

    public virtual void Move() // virtual：允许子类重写的默认版本
    {
        Console.WriteLine(name + " 移动了");
    }
}

class Player : Character // 子类继承父类
{
    public Player(string name, int hp, int attack) : base(name, hp, attack) { } // base 转交

    public override void Move() // override：完全替换成玩家的移动
    {
        Console.WriteLine(name + " 玩家用 WASD 走路");
    }
}

class Enemy : Character
{
    public Enemy(string name, int hp, int attack) : base(name, hp, attack) { }

    public override void Move()
    {
        Console.WriteLine(name + " 敌人朝玩家慢慢巡逻过来");
    }
}
```

### 继承关系图（晚上自己能手画出来）
```
            Character（父类）
   protected: name / hp / attack
   构造 Character(...)
   public: TakeDamage / Attack
   virtual Move()
              ▲ :（继承）
        ┌─────┴─────┐
     Player        Enemy
   :base(...)     :base(...)
   override Move  override Move
   → WASD走路      → 巡逻过来
```

---

## 🌤 下午：Unity 角色控制器升级（射线地面检测 + 平滑移动）

### 步骤1：Physics.Raycast 射线地面检测（今天核心）
- 大白话：从一个点朝一个方向发一条看不见的线，碰到碰撞体(Collider)就返回 true，还能知道碰到谁、多远。
- 地面检测思路：**每帧从玩家脚下向正下方打一条短线**，碰到地面=站地上(能跳)，没碰到=在空中(禁跳)。
- 🔰 API 写法（照抄、用多就熟）：
```csharp
// Physics.Raycast(起点, 方向, 长度)，返回 bool
isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance);
// Debug.DrawRay(起点, 方向*长度, 颜色)：只在 Scene 视图画线，调试用，发布不显示
Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.red);
```
- 参数说明：`transform.position`=玩家中心(起点)；`Vector3.down`=正下方；`groundDistance`=射线多长。
- ⚠️ 现在就要记：射线放在 Update 里**每帧检测是正常且必须的**（实时知道在地上还是空中）；但 `Debug.Log` 不要每帧打印，否则 Console 会被刷成 999+（还会把别的日志淹没，今天扣血日志就是这样被"藏"起来的）。

### 步骤2：用射线接管 isGrounded，删掉碰撞回调
- 旧做法（D7）：OnCollisionEnter/Exit + CompareTag("Ground") 被动改 isGrounded。
- 新做法：Update 里每帧用射线结果直接给 isGrounded 赋值，**把 OnCollisionEnter/Exit 两个方法整个删掉**（两套同时改 isGrounded 会打架）。
- 效果：站地能跳、**空中狂按空格不会二段跳**、落地恢复能跳。
- 调 `Ground Distance`：落地却跳不起来=射线太短(调大)；空中还能连跳=射线太长插进地里(调小)。

### 步骤3：Vector3 的本质（今天的困惑点）
- ⚠️ 现在就要记：**Vector3 不是"位置专用"，它就是装了 x/y/z 三个 float 的盒子**。位置、速度、方向、旋转、缩放、力都用它，具体含义看它存在哪个属性里：

| 写法 | 这个 Vector3 表示 |
|---|---|
| transform.position | 位置坐标（在哪） |
| rb.velocity | 速度（每秒在 x/y/z 各移动多少米） |
| Vector3.up / down / forward | 方向 |
| transform.eulerAngles | 旋转角度 |
| AddForce 里的 Vector3 | 力 |

### 步骤4：平滑移动（加速度，不再瞬间满速/瞬间停死）
- 旧做法 `rb.velocity = 目标速度`：瞬间满速、松手瞬间停，很生硬。
- 新做法：速度**每帧朝目标靠近一小步**，产生加速起步、滑行减速的手感。
- 🔰 `Mathf.MoveTowards(当前值, 目标值, 每步最大变化量)`：返回朝目标靠近、但每步不超过最大变化量的值，到目标就停、不会冲过头。
- ⚠️ 现在就要记（Unity 固定套路）：**不能直接 `rb.velocity.x = ...`，要先把速度拷进临时变量 v、改 v、再 `rb.velocity = v;` 整体写回**。
- **只平滑水平 x、z，竖直 y 保持 `rb.velocity.y` 不动**，否则会破坏重力和跳跃。
- `每帧最大变化量 = 加速度 × Time.fixedDeltaTime`（FixedUpdate 里用 fixedDeltaTime，保证不同帧率手感一致）。
- 踩坑：加速度太小(如10)时，每帧加的速度被地面"静摩擦"抵消，速度攒不起来、看着像不动；**调大加速度（实测 15 能跑起来）**即可。以后做正式角色可给 Collider 配零摩擦物理材质。

### 下午最终脚本 PlayerPhysicsMove.cs
```csharp
using UnityEngine;

public class PlayerPhysicsMove : MonoBehaviour
{
    public float moveSpeed = 8f;         // 最大移动速度
    public float jumpForce = 5f;         // 跳跃冲力
    public float groundDistance = 0.55f; // 地面射线长度
    public float moveAcceleration = 15f; // 移动加速度（越大起步越快）
    private Rigidbody rb;                // 刚体引用
    private bool isGrounded = false;     // 是否在地面（射线每帧刷新）

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 取同一物体上的刚体
    }

    void FixedUpdate() // 持续物理移动
    {
        float moveX = 0f, moveZ = 0f;
        if (Input.GetKey(KeyCode.W)) moveZ = 1f;
        if (Input.GetKey(KeyCode.S)) moveZ = -1f;
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;

        // 目标速度：水平由按键决定，竖直 y 保持当前物理速度
        Vector3 targetVelocity = new Vector3(moveX * moveSpeed, rb.velocity.y, moveZ * moveSpeed);
        float maxChange = moveAcceleration * Time.fixedDeltaTime; // 本帧速度最多变多少

        Vector3 v = rb.velocity;                          // 先拷一份
        v.x = Mathf.MoveTowards(v.x, targetVelocity.x, maxChange); // 只平滑 x
        v.z = Mathf.MoveTowards(v.z, targetVelocity.z, maxChange); // 只平滑 z（y 不动）
        rb.velocity = v;                                  // 写回刚体
    }

    void Update() // 跳跃(瞬间按键) + 地面检测
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance);
        Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.red);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // 落地才跳，防空跳
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
```

### 最终手感参数（实测）
| 参数 | 值 |
|---|---|
| Move Speed | 8 |
| Move Acceleration | 15 |
| Jump Force | 5 |
| Ground Distance | 0.55 |

---

## 🌙 晚上：Animal 练习 + 多态雏形

### 步骤1：Animal 父类 + Dog/Cat 重写（和上午同构，独立默写出来的）
```csharp
class Animal
{
    protected string name;
    public Animal(string name) { this.name = name; }
    public virtual void Speak() { Console.WriteLine(name + " 发出了叫声"); }
}
class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void Speak() { Console.WriteLine(name + " 汪汪汪地叫"); }
}
class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void Speak() { Console.WriteLine(name + " 喵喵喵地叫"); }
}
```

### 步骤2：多态（今天面向对象最重要的结论）
- ⚠️ 现在就要记：**父类类型的变量可以装子类对象**（狗是动物、猫是动物）；调用 virtual/override 方法时，**以 new 出来的"真实对象"为准**执行对应重写版本，不看变量声明类型。
```csharp
Animal a1 = new Dog("旺财"); // 声明是 Animal，实际是 Dog
Animal a2 = new Cat("咪咪");
a1.Speak(); // 汪汪汪（以真实对象 Dog 为准）
a2.Speak(); // 喵喵喵

// 父类数组装一堆不同子类，foreach 统一调用，各叫各的
Animal[] zoo = { new Dog("旺财"), new Cat("咪咪"), new Dog("大黄") };
foreach (Animal a in zoo) { a.Speak(); } // 不用 if 判断是狗是猫
```
- 好处：以后新增一种动物（如 Cow），只要写子类 + override Speak，再塞进数组，**foreach 那段一个字都不用改**（对扩展开放）。游戏里统一管理一堆敌人/怪物/子弹都靠它。

### 步骤3：认识 C# 12 主构造函数简写（看懂即可，初学仍写完整版）
- `class Dog(string name) : Animal(name) { }` 是主构造函数简写，等价于：
```csharp
class Dog : Animal {
    public Dog(string name) : base(name) { }
}
```
- 现阶段练习仍写完整版，把构造/base 的基础打牢，简写以后看得懂、想用再用。

---

## ⚠️ 今日踩坑 & 环境备忘
1. **Unity 编译报 `Win32Exception: BeeLocalCacheTool.exe` / "应用程序控制策略已阻止此文件" / Internal build system error -532462766**：
   根因是团结引擎装在 `C:\Program Files\Tuanjie` 下，编译小工具需要管理员权限。解决：**右键 TuanjieHub → 以管理员身份运行**；并在 属性→兼容性→勾"以管理员身份运行此程序"一劳永逸。删 Library/Temp/obj 缓存、重启只是临时缓解。
2. **Console 被 Debug.Log 刷成 999+**：射线每帧打印导致，还会淹没扣血等日志。调试看明白后把每帧的 Log 删掉/注释，DrawRay 保留（不进 Console）。
3. **改 rb.velocity 的分量必须先拷到临时变量 v，再整体赋回**，不能直接 rb.velocity.x = ...
4. **平滑移动只动 x、z，y 保持 rb.velocity.y**，否则重力和跳跃会坏。


# 📅 D10（9/13 周日）：多态深入 + Unity 触发器吃金币 + UI 分数

## 🌞 上午：多态深入（Polymorphism）

### 步骤1：声明类型 vs 实际类型——方法到底调谁的

**大白话**：一句 `Shape s = new Circle("小圆");` 里，等号左边的类型叫"声明类型"，右边 new 出来的真实对象叫"实际类型"。

**两条铁律（⚠️ 现在就要记）**
- 能不能点出某个成员（编译阶段）→ 看**声明类型（左边）**：父类引用只能访问父类定义过的成员，子类特有点不出来。
- 重写的虚方法执行哪个版本（运行阶段）→ 看**实际类型（new 的是谁）**：new 子类就执行子类的 override 版本。
- 口诀：**能不能调看左边，虚方法执行谁看 new。**

```csharp
Shape s = new Circle("小圆");   // 声明类型 Shape，实际类型 Circle
s.Show();    // ✅ Show 父类有；执行 Circle 的重写版 → "小圆 是圆形"
// s.Roll(); // ❌ 报错：Roll 是 Circle 特有，父类 Shape 里没有，父类引用看不到
Circle c = new Circle("小圆2"); // 用子类类型声明
c.Roll();    // ✅ 子类声明能点出自己特有的方法
```

### 步骤2：abstract 抽象类与抽象方法

**大白话**：virtual 是父类给默认做法、子类可改可不改；abstract 是父类只立规矩"子类必须会这个动作"，但不写怎么做，强制每个子类自己实现。

**四条规则（⚠️ 现在就要记）**

1. 抽象方法**没有方法体，以分号结尾**：`public abstract void Attack();`
2. 类里只要有抽象方法，这个类必须加 `abstract`
3. 抽象类**不能直接 new**（new 抽象类报错），只能被继承
4. 子类必须用 `override` 实现所有抽象方法，少一个就报错

**virtual vs abstract 对比表**

|  | virtual 虚方法 | abstract 抽象方法 |
| --- | --- | --- |
| 父类方法体 | 有默认实现 `{}` | 没有，只有一个 `;` |
| 子类要不要重写 | 可选 | **必须**重写 |
| 类的修饰 | 普通类就行 | 必须 `abstract class` |
| 能不能 new | 能 | **不能 new** |

```
abstract class Shape
{
    protected string name;
    public Shape(string name) { this.name = name; }  // 构造函数照样有，给子类 base 用
    public abstract void Show();   // 抽象方法：无方法体、分号结尾，强制子类重写
}
class Circle : Shape
{
    public Circle(string name) : base(name) { }      // 把名字转交父类构造
    public override void Show()                      // 子类必须实现
    {
        Console.WriteLine(name + " 是圆形");
    }
}
```

> 
> 补充：抽象类里普通字段、构造函数、普通方法照样能写；只有抽象方法那部分"只定规矩不写实现"。

### 步骤3：is / as 类型判断与转换

**大白话**：拿到一个父类引用，想调子类特有方法前，要先判断它到底是哪个子类、再转换。

```
if (s is Circle c)   // s 是 Circle 吗？是→转成 Circle 交给变量 c（推荐写法，一步到位）
{
    c.Roll();        // c 是 Circle 类型，能点子类特有方法
}

Circle c2 = s as Circle;  // as：尝试转换，失败返回 null（不崩）
if (c2 != null) { c2.Roll(); }

Circle c3 = (Circle)s;    // 直接强转：类型不符会抛异常崩溃，没把握别用
```

**三种方式对比（⚠️ 现在就要记）**

| 写法 | 类型不符时 |
| --- | --- |
| `(Circle)s` 强转 | 直接抛异常、崩溃 |
| `s as Circle` | 返回 null，要判空 |
| `s is Circle c` | 返回 false，不进 if（最推荐） |

**设计原则**：所有子类都有、只是做法不同的动作（Show/Attack）→ 用**多态**；只有某个子类特有的动作（只有圆会滚、只有狗会咬）→ 才用 **is/as**。

### 步骤4：List 泛型集合 + Character 综合

**大白话**：数组长度固定，List 长度可变，能随时 Add 加元素，游戏里刷怪、加角色都用它。

**核心用法（⚠️ 现在就要记）**

```
using System.Collections.Generic;   // List 所在命名空间，必须加

List<Character> list = new List<Character>();  // 建一个专门装 Character 的空集合
list.Add(new Player("勇者", 100));  // Add 加元素，长度自动变
list.Count;                         // 取个数（⚠️数组是 Length，List 是 Count）
foreach (Character c in list) { c.Attack(); }  // 遍历和数组一样

// 集合初始化器：一开始就知道放哪几个，可一次性写
List<Animal> a = new List<Animal> { new Dog("旺财"), new Cat("咪咪") };
// 取单个元素用下标，从 0 开始，范围 0 ~ Count-1，超了越界
list[0].Attack();
```

**数组 vs List 对比**

|  | 数组 `[]` | `List<T>` |
| --- | --- | --- |
| 长度 | 固定 | 可变（Add/Remove） |
| 个数 | `.Length` | `.Count` |
| 加元素 | 不能 | `.Add(元素)` |
| 命名空间 | 不用 | 要 using Collections.Generic |

**综合例子（抽象父类 + 子类重写 + List 统一多态调用）**

```
abstract class Character
{
    protected string name;
    protected int hp;
    public Character(string name, int hp) { this.name = name; this.hp = hp; }
    public abstract void Attack();              // 抽象：攻击方式各不同，强制子类实现
    public void TakeDamage(int damage)          // 普通方法：子类直接继承共用
    {
        hp -= damage;
        Console.WriteLine(name + " 受到" + damage + "点伤害，剩余血量" + hp);
    }
}
class Player : Character
{
    public Player(string name, int hp) : base(name, hp) { }
    public override void Attack() { Console.WriteLine(name + " 挥剑攻击！"); }
}
class Enemy : Character
{
    public Enemy(string name, int hp) : base(name, hp) { }
    public override void Attack() { Console.WriteLine(name + " 扑上来撕咬！"); }
}
// Main：
// List<Character> list = new List<Character>();
// list.Add(new Player("勇者",100)); list.Add(new Enemy("史莱姆",100));
// foreach (Character c in list) { c.Attack(); c.TakeDamage(10); }
```

**抽象类动态创建（刷怪雏形，⚠️）**：抽象类不能 new 自己（`new Animal()` 报错），但子类随便 new 多少个；运行时按用户输入的"种类"用 if/switch 决定 new 谁，再用父类引用接住 Add。

```
Animal a;
if (kind == "狗") a = new Dog(nm);
else if (kind == "猫") a = new Cat(nm);
else a = new Cow(nm);
list.Add(a);
```

> 
> 🔰 List 的 RemoveAt/Remove（删除）、AddRange（批量加）以后做刷怪/对象池时专门学，现在不用深究。

## 🌤 下午：Unity 触发器 Trigger + 吃金币 + UI 分数

### 步骤1：Collider（碰撞体）vs Trigger（触发器）——面试高频

**大白话**：碰撞体组件上的 Is Trigger 勾不勾，决定它是"会挡人的墙"还是"只感应不挡路的区域"。

|  | Collider（不勾 Is Trigger） | Trigger（勾 Is Trigger） |
| --- | --- | --- |
| 物理碰撞 | 有：挡住、弹开、能站上面 | 没有：物体直接穿过 |
| 回调函数 | OnCollisionEnter/Stay/Exit | **OnTriggerEnter/Stay/Exit** |
| 函数参数 | Collision collision | Collider other |
| 用途 | 地面、墙、斜坡 | 吃金币、捡道具、进门、区域检测 |

**Trigger 事件触发的 3 个条件（⚠️ 现在就要记，缺一不可）**

1. 两个物体都要有 Collider；
2. 其中一方（金币）勾上 Is Trigger；
3. 双方至少有一个挂 Rigidbody（玩家有刚体即可）。

### 步骤2：创建金币并设为触发器

1. Hierarchy 右键 → 3D Object → Cylinder，命名 `Coin`；
2. Transform：Scale `(1,0.2,1)` 压扁，拖到玩家前方贴地；
3. Project 右键 → Create → Material 建金黄色材质 `CoinMaterial`，拖到金币上；
4. 金币的 Capsule Collider **勾上 Is Trigger**，金币**不加刚体**；
5. 让金币竖直立着转：Rotation `(90,0,0)`，Rotate 脚本里加 `Space.World` 绕世界竖直轴转。

**局部轴 vs 世界轴（⚠️）**：物体被手动旋转后，局部轴会歪；`transform.Rotate(..., Space.World)` 强制绕世界轴转。纯色对称圆盘绕自己中心对称轴自转肉眼看不出，要让它竖直绕 Y 轴转才明显。

### 步骤3：Coin 脚本——碰到玩家加分并销毁（挂在金币上）

```
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int score = 0;   // static 静态：所有金币共用同一份分数（公共记分牌）

    // 对方进入金币触发区时自动调用一次；other = 撞进来的物体（玩家）
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))   // 判断撞进来的标签是不是 Player
        {
            score = score + 1;            // 分数 +1（也可写 score++）
            Debug.Log("吃到金币！当前分数：" + score);
            Destroy(gameObject);          // 销毁金币自己（gameObject = 脚本挂着的物体）
        }
    }
}
```

- 玩家要先在 Inspector 顶部 Tag 下拉设成 `Player`；
- 复制金币：Hierarchy 选中金币按 `Ctrl+D`，static 分数会跨金币累计。

### 步骤4：Canvas + Text 显示分数文字

1. Hierarchy 右键 → UI → **旧版 → 文本（Text，Legacy，别用 TextMeshPro）**，自动生成 Canvas + EventSystem；
2. 选中 Text，Rect Transform 锚点定到**左上角**（锚点预设里直接点左上格，再手动填 Pos X=150、Pos Y=-60、宽 300、高 80）；
3. Text 组件：内容 `分数：0`、字号 40、颜色白/黄、水平和垂直 Overflow 都设 `Overflow`。

**⚠️ 文字看不见的两个坑**：①文本框宽高必须大于字号，否则字被裁；②位置靠锚点定，左上锚点时 Pos Y 填负数才往下。

### 步骤5：ScoreUI 脚本——让文字实时刷新（挂在 Text 物体上）

```
using UnityEngine;
using UnityEngine.UI;        // ⚠️ 用 UI 的 Text 组件必须加这个命名空间

public class ScoreUI : MonoBehaviour
{
    private Text scoreText;  // 分数文本组件

    void Start()
    {
        scoreText = GetComponent<Text>();   // 取同一物体上的 Text 组件
    }

    void Update()            // 每帧刷新一次，分数一变文字就跟着变
    {
        scoreText.text = "分数：" + Coin.score;  // 改文字 = 给 Text 的 text 属性赋字符串
    }
}
```

**核心理解（⚠️ 现在就要记）**：组件就是一个装着"属性（数据）+方法（功能）"的对象；**Inspector 面板里每一栏 = 代码里的一个属性**，`组件.属性 = 值` 等价于运行时在面板改那一栏。改屏幕文字用 `Text组件.text = "字符串"`；访问静态变量用 `类名.变量名`（Coin.score）。

## 🌙 晚上：练习 + 环境 + 规范

### 动物多态脱稿练习（abstract + List + is 综合）

- abstract Animal（抽象 Speak）→ Dog/Cat/Cow 各自 override；用 List 装、foreach 统一 Speak；
- Dog/Cat 各有特有 attack()、Cow 没有 → 用 `if(a is Dog d) d.Attack();` 区分（通用靠多态、特有靠 is）。

### 环境排错：智能应用控制（Smart App Control）拦截编译产物

- 现象：dotnet run 报 `FileLoadException … 应用程序控制策略已阻止此文件 (0x800711C7)`，加 Defender 白名单、管理员运行都没用；
- 原因：Win11 智能应用控制拦"无签名、无信誉的本地新编译 dll"，它不认排除项、管理员也绕不过；
- 解决：Windows 安全中心 → 应用和浏览器控制 → 智能应用控制 → **关闭**（注意：关闭后想再开需重置系统；开发机建议关，仍有 Defender 等防护）→ 重启。

### 命名规范（⚠️ 现在就要记）

- 类名、方法名、属性名 → **大驼峰 PascalCase**：Attack、TakeDamage、Speak；
- 变量名、参数名 → **小驼峰 camelCase**：playerName、moveSpeed、循环变量用 dog/cat 而非单字母。

# 📅 D11 学习笔记：接口 interface + Unity 接口重构 + 炸弹群伤

## 🌞 上午：C# 接口（interface）

### 步骤1：什么是接口、怎么定义
接口 = 一份"能力约定/合同"：规定"谁实现我，就必须有这些方法"，但**不写方法具体怎么做**。
```csharp
interface IMovable
{
    void Move();   // 只有方法签名，没有方法体 { }，以分号结尾
}
```
- 接口名习惯以 **I** 开头（IMovable、IDamageable）；
- 接口方法**不写 public、不写 abstract**；
- 接口里**不能写字段（数据）、不能写构造函数**。

### 步骤2：类实现接口
类名后用冒号 `:接口名`，并**必须**把接口里的方法全部实现（方法要 public、签名一致）。
```csharp
class Player : IMovable
{
    public void Move()   // 少写或签名不一致会报"未实现接口成员"
    {
        Console.WriteLine("玩家移动");
    }
}
```

### 步骤3：一个类实现多个接口
多个接口用**逗号**隔开；如果同时继承父类，**父类必须写在冒号后第一位**。
```csharp
class Player : IMovable, IDamageable   // 控制台类：直接逗号列接口
{
    public void Move() { }
    public void TakeDamage(int dmg) { }
}
// Unity 脚本：父类 MonoBehaviour 必须排第一
public class PlayerPhysicsMove : MonoBehaviour, IMovable { }
```

### 步骤4：接口多态（接口也是一种"类型"）
接口可以当数组/List 的元素类型，把"毫无继承关系、但都实现了同一接口"的对象装在一起统一调用。
```csharp
IMovable[] movers = { new Player(), new Enemy(), new Car() };
foreach (IMovable m in movers)
{
    m.Move();   // 不关心你具体是谁，反正都能 Move，各走各的实现
}
```

### 步骤5：接口 vs 抽象类（⚠️ 面试高频，必背）
| 对比项 | 抽象类 abstract class | 接口 interface |
|---|---|---|
| 含义 | is-a，"是什么"（狗是动物） | can-do，"能做什么"（能受伤/能移动） |
| 方法实现 | 可有普通实现方法 + 抽象方法 | 默认只有方法签名、无实现 |
| 字段/构造函数 | 可以有 | 不能有 |
| 数量 | 只能继承**一个**父类 | 能实现**多个**接口（逗号隔开） |
| 抽象方法写法 | 要加 abstract | 不写 public/abstract |

**选择口诀：做法相同、想复用同一段代码 → 用父类/抽象类；做法不同、但想被统一调用 → 用接口。**

---

## 🌤 下午：Unity 用接口重构 + 血量 UI

### 步骤6：定义两个接口并重构玩家脚本
接口文件**不继承 MonoBehaviour、不是组件、不能往物体上挂**，一个接口一个文件。
```csharp
// IMovable.cs
public interface IMovable { void Move(); }
// IDamageable.cs
public interface IDamageable { void TakeDamage(int damage); }
```
把原来写在 FixedUpdate 里的水平移动整段搬进 `Move()`，物理帧只负责调用：
```csharp
public class PlayerPhysicsMove : MonoBehaviour, IMovable
{
    public void Move() { /* WASD→速度 的整段移动逻辑放这 */ }
    void FixedUpdate() { Move(); }
}
```
受伤逻辑封进 IDamageable：
```csharp
public class PlayerHealth : MonoBehaviour, IDamageable
{
    public int hp = 100;                 // 属于角色自己的数据，不用 static
    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        Debug.Log("受到伤害，掉" + dmg + "点血，剩余血量：" + hp);
    }
}
```

### 步骤7：用 public 组件引用做血量 UI（拖槽）
`public 其他脚本类 变量;` = 在 Inspector 开一个可拖的"引用槽"，拖物体就是连线。
```csharp
using UnityEngine;
using UnityEngine.UI;
public class HpUI : MonoBehaviour
{
    private Text hpText;
    public PlayerHealth player;   // 槽：把挂着 PlayerHealth 的玩家拖进来
    void Start() { hpText = GetComponent<Text>(); }
    void Update() { hpText.text = "血量：" + player.hp; }
}
```
- 拖之前是 null，不拖直接用会报**空引用异常**；
- 拖的是物体，槽类型是某脚本，Unity 自动取该物体上的对应组件。

### 步骤8：static 和"拖引用"怎么选
- **全局唯一、跨物体累计**的数据（金币总分 Coin.score、击杀数）→ 用 `static`，直接 `类名.字段` 访问，不用拖；
- **属于某个具体物体/角色**的数据（血量 hp、速度 moveSpeed）→ 用 public 拖引用，多个角色各连各的不会串。

---

## 🔥 加深：炸弹群伤 List<IDamageable>

### 步骤9：爆炸范围的两个关键认知
1. **模型大小看 Scale，碰撞/触发范围看 Collider 的 Radius，两者独立**：想做"小炸弹、大判定"，Scale 保持小，把 SphereCollider 的 Radius 调大并勾 Is Trigger（Scene 视图绿色线框=范围）；
2. **固定的触发区域要自己挂 Rigidbody 并勾 Is Kinematic**（运动学：不掉落、不移动，但拥有刚体身份，这样无刚体的木箱进范围也能被检测到）。

### 步骤10：用接口名单统一群伤
```csharp
using UnityEngine;
using System.Collections.Generic;
public class Bomb : MonoBehaviour
{
    public int bombDamage = 30;
    public KeyCode explodeKey = KeyCode.K;
    List<IDamageable> targets = new List<IDamageable>();  // 范围内"能受伤"的名单

    void OnTriggerEnter(Collider other)
    {
        IDamageable d = other.GetComponent<IDamageable>(); // 用接口类型找组件
        if (d != null && !targets.Contains(d)) targets.Add(d);   // 判空+去重再加入
    }
    void OnTriggerExit(Collider other)
    {
        IDamageable d = other.GetComponent<IDamageable>();
        if (d != null && targets.Contains(d)) targets.Remove(d);
    }
    void Update()
    {
        if (Input.GetKeyDown(explodeKey))
        {
            foreach (IDamageable d in targets)
                if (d != null) d.TakeDamage(bombDamage); // 不认识玩家/木箱，统一喊受伤
            targets.Clear();
        }
    }
}
```
**解耦**：Bomb 里没有出现 PlayerHealth、BoxHealth 任何具体类名，只认 IDamageable；以后新增"敌人/油桶"，只要实现 IDamageable，Bomb 一个字不改就能炸到。

---

## 🌙 晚上：IInteractable + 接口方法返回 bool

### 步骤11：接口方法也能带返回值
接口签名写什么返回类型，实现方法就 return 什么；调用方用变量接住再判断。
```csharp
interface IInteractable { bool Interact(); }   // 返回 true=成功 false=失败

class Chest : IInteractable
{
    private bool isOpened = false;   // 字段写在类里、方法外
    public bool Interact()
    {
        if (!isOpened) { isOpened = true; Console.WriteLine("获得100金币"); return true; }
        else { Console.WriteLine("宝箱是空的"); return false; }
    }
}
// Main：List<IInteractable> 统一遍历，接住返回值
foreach (IInteractable item in list)
{
    bool ok = item.Interact();
    if (ok) Console.WriteLine("交互成功"); else Console.WriteLine("交互失败");
}
```

---

## ⚠️ D11 易错点汇总
1. 接口方法只有签名、分号结尾、无 `{}`、不写 public/abstract；
2. 实现接口的方法必须 public 且签名一致，漏一个就报"未实现接口"；
3. 父类 + 接口同时写时，父类必须在冒号后第一位：`: MonoBehaviour, 接口`；
4. 一个类只能继承一个父类，但能实现多个接口；
5. **类的 `{}` 里只能直接放字段/方法；if、Console.WriteLine、return 等执行语句必须写在方法 `{}` 内**；
6. List 取元素用 `变量名[下标]`，不是 `类型名[下标]`；下标从 0 开始；
7. `GetComponent<接口>()` 合法，找不到返回 null，用前必须判空；
8. Scale（视觉）和 Collider Radius（判定范围）独立；固定触发器挂 Rigidbody 勾 Is Kinematic；
9. 一个物体只有一个某类型组件：两个字段都 GetComponent<Text>() 会指向同一文本框互相覆盖，要多行显示就建多个 Text 物体；
10. public 引用槽不拖就是 null，调用会空引用报错。

# 📅 D12（2026-09-15 周二）面向对象大综合：封装/继承/多态/接口 + 工厂模式 + Unity 组件化

> 今日主线：把 OOP 四件套整合成一个完整角色系统；下午把 Unity 角色按"单一职责"拆成移动、血量、UI 组件，并把 UI 从每帧轮询改成"变化时才刷新"。

---

## 🌞 上午：C# 面向对象四件套 + 回合对战 + 工厂模式

### 步骤1：封装——private 字段 + public 属性（受控访问）
**大白话**：字段用 private 藏起来，外面不能直接改；通过 public 属性这个"窗口"读，想改只能走方法，保证数据不被改坏（如血量不为负）。

```csharp
class Character
{
    private int hp;            // 私有字段：只有类内部能直接碰，外面看不见
    private string name;

    public int Hp              // 公开只读属性：外面能读
    {
        get { return hp; }     // 只有 get、没有 set → 外面只能看、不能赋值
    }
    public string Name
    {
        get { return name; }
    }

    // 想掉血只能走这个方法（受控修改），规则写在类内部
    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        if (hp < 0) hp = 0;    // 规则：血量最低为 0
        Console.WriteLine(name + "受到" + damage + "点伤害，剩余血量：" + hp);
    }
}
```
- `get`：读；`set`：写，set 里用 `value` 代表新值；只写 get = 只读属性。
- 对比：public 字段=裸奔谁都能改；只读属性=只能看；get+set（可加判断）=门卫受控改。

### 步骤2：接口 IDamageable——"能受伤"的契约
**大白话**：接口只规定"必须有哪个方法"，只有签名没有方法体、以分号结尾、不写 public；谁实现它谁就必须交出这个方法。

```csharp
interface IDamageable
{
    void TakeDamage(int damage);   // 只有签名 + 分号，不写实现、不写 public
}

class Character : IDamageable      // Character 实现接口，必须写出 TakeDamage（上面已写）
{
    // ...
}
```

### 步骤3：继承 + 多态——基类与子类
**大白话**：子类 `: 基类` 自动继承字段/属性/方法（含基类已实现的接口），`base(...)` 把参数交给父类构造；父类方法标 virtual、子类用 override 各自重写，调用时 new 的是谁就执行谁的版本。

```csharp
// 父类：攻击方法标 virtual，表示"可以被子类重写"
public virtual void Attack(Character target)
{
    Console.WriteLine(name + "攻击了" + target.Name);
    target.TakeDamage(10);        // 父类默认打 10
}

// 玩家子类
class Player : Character
{
    // base：把 name、hp 交给父类构造去赋值，子类不用重复写
    public Player(string name, int hp) : base(name, hp) { }

    public override void Attack(Character target)  // override：重写父类方法
    {
        Console.WriteLine(Name + "挥剑攻击" + target.Name);
        target.TakeDamage(15);    // 玩家打 15
    }
}

class Enemy : Character
{
    public Enemy(string name, int hp) : base(name, hp) { }
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "扑上来攻击" + target.Name);
        target.TakeDamage(8);     // 敌人打 8
    }
}
```
- ⚠️**多态铁律**：必须"父类引用 + 子类对象"，右边 new 一定要写全新子类名：
  `Character p = new Player("勇者",100);`（对）
  不能写 `Character p = new("勇者",100);`，它会被补成 new 基类 Character，override 全部失效。
- 接口实现随继承传递：Character 实现了 IDamageable，子类即使不写 :IDamageable 也自动"是"IDamageable。

### 步骤4：回合制对战——while + 攻击后立刻判血
**大白话**：玩家先攻 → 立刻判敌人是否阵亡（防止死人还手）→ 没死才轮到敌人反击 → 再判玩家，循环直到一方血量为 0 用 break 跳出。

```csharp
Character p = new Player("勇者", 100);
Character e = new Enemy("史莱姆", 50);

while (true)
{
    p.Attack(e);                  // 玩家先攻
    if (e.Hp <= 0)                // 用只读属性 Hp 判断，不能直接改血
    {
        Console.WriteLine("勇者胜利");
        break;                    // 敌人已死，立刻结束，不再往下让它反击
    }
    e.Attack(p);                  // 敌人还活着才反击
    if (p.Hp <= 0)
    {
        Console.WriteLine("勇者失败");
        break;
    }
}
```

### 步骤5：简单工厂 CharacterFactory——集中管理"创建对象"
**大白话**：把"根据类型 new 谁"的逻辑集中到一个工厂类；传字符串给它，它返回对应角色。返回类型写父类 Character（多态），调用方不用关心具体造了谁。

```csharp
class CharacterFactory
{
    // 返回类型是父类 Character，方法内部 return 各种子类对象
    public Character Create(string type)
    {
        if (type == "player") return new Player("勇者", 100);
        else if (type == "enemy") return new Enemy("史莱姆", 50);
        else if (type == "boss") return new Boss("魔王", 500);
        else
        {
            Console.WriteLine("没有这种角色：" + type);
            return null;          // 不认识的类型返回 null
        }
    }
}
```
Main 里使用（⚠️ 判空要判"创建结果"，不是判字符串）：
```csharp
CharacterFactory factory = new CharacterFactory();  // 类是图纸，先 new 出工厂对象才能用
string[] types = { "player", "enemy", "boss", "enemy", "player" };
List<Character> list = new List<Character>();

foreach (string type in types)
{
    Character role = factory.Create(type);  // 先接住造出来的对象
    if (role != null)                       // 判断"角色"非 null（字符串 type 永远不为 null）
    {
        list.Add(role);                     // 合法才加入，非法的被挡在外面
    }
}

foreach (Character role in list)            // 统一用父类类型操作
{
    Console.WriteLine(role.Name + " 血量：" + role.Hp);
}
```
- warning CS8603"可能返回 null 引用"是警告不是错误；调用处已判空即可忽略，彻底消除要学可空类型 `Character?`（以后学）。

---

## 🌤 下午：Unity 角色组件化 + UI 事件触发

### 步骤6：单一职责——一个脚本只干一件事
**大白话**：把角色拆成互相独立的组件，各管各的、互不掺杂：
| 组件 | 只负责 | 不负责 |
|---|---|---|
| PlayerPhysicsMove（=PlayerController） | WASD 移动、射线地面检测、空格跳跃 | 血量 |
| PlayerHealth（=Health） | hp 数据、TakeDamage 受伤、碰 Trap | 移动 |
| HpUI / Score | 只负责把数据显示到 Text | 算移动、改数据 |
- ⚠️ 不要随便重命名脚本：Unity 中"文件名 = 类名"，改名会让物体上的组件引用、拖好的槽断开。结构对了名字可以以后再规范。

### 步骤7：UI 从「轮询」改成「事件触发」
**大白话**：
- 轮询（旧）：写在 Update 里，每帧都刷一次，数据没变也刷，浪费；
- 事件触发（新）：平时不动，数据变化的那一刻（掉血/吃金币）主动调 UI 方法刷新一次。

HpUI（删掉 Update，改成带参 public 方法，不再拖玩家）：
```csharp
using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    private Text hpText;
    void Start()
    {
        hpText = GetComponent<Text>();   // 取自己身上的 Text 组件
    }

    // 血量由参数传进来，谁掉血谁调用它刷新
    public void RefreshHp(int hp)
    {
        hpText.text = "血量：" + hp;
    }
}
```
PlayerHealth（受伤后主动通知 UI，Start 里先刷一次显示初始值）：
```csharp
public class PlayerHealth : MonoBehaviour, IDamageable
{
    public int hp = 100;
    public HpUI hpUI;                 // 拖引用：把挂 HpUI 的 HpText 物体拖进来

    void Start()
    {
        hpUI.RefreshHp(hp);           // 开局先刷一次，否则没受伤前血条是空的
    }

    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        if (hp < 0) hp = 0;
        hpUI.RefreshHp(hp);           // 掉血这一刻才通知 UI 刷新
    }
}
```
- 分数同理：Coin 吃金币时调 `scores.ReportScore(score)` 主动推给分数 UI（举一反三，同一个套路）。
- 现在 Health 直接认识 UI 类有一点耦合；更解耦的标准写法是 C# event 事件（委托），以后专门学。

---

## 🌙 晚上：OOP 四件套对比表（C# 毕业考核心）

| | 封装 | 继承 | 多态 | 接口 |
|---|---|---|---|---|
| 一句话 | 藏数据、受控改 | 复用父类(is-a) | 同调用、不同表现 | 定能力契约(can-do) |
| 核心语法 | private 字段 + public 属性(get/set/value) | `: 父类`、`base()` | `virtual` / `override` | `interface`、冒号实现 |
| 解决问题 | 数据不被改坏 | 少写重复代码 | 统一管理不同子类 | 解耦、可实现多个 |
| 数量限制 | — | 只能继承 1 个父类 | — | 能实现多个接口 |

**四件套协作流程**：Character 用封装藏 name/hp → 实现 IDamageable 承诺能受伤 → Player/Enemy/Boss 继承它并 override 出不同攻击（多态）→ Main/工厂统一用父类 Character 接收和操作，运行时各走各的版本。

### ⚠️ 今日易错点清单
1. 多态时右边必须 `new 具体子类`，写 `new(...)` 会被补成基类导致 override 失效。
2. 接口方法只有签名、分号结尾、不写 public、不写方法体。
3. 接口实现会随继承传递：父类实现了，子类白捡。
4. 回合对战：攻击后要立刻判对方血量再决定是否反击，避免"死人还手"。
5. 工厂判空判的是 `Create()` 的返回对象，不是输入字符串；先接结果再判 `!= null`。
6. 类是图纸要先 new 出对象才能调普通方法；static 才用"类名.方法"直接调。
7. Unity 文件名必须等于类名；using 别手滑选错（SocialPlatforms.Impl 里有官方 Score 会和自己的类撞名）。
8. UI 事件触发别忘了在 Start 里先刷新一次初始值。

好，开始今晚收尾。D13 内容多，笔记我分两块给你（上午 C#、下午 Unity），你逐块复制进 StudyNotes.md。先给上午：

---

```markdown
# 📅 D13 学习笔记（C# 查漏补缺 static/属性/enum/namespace + Unity 可玩小关）

## 🌞 上午：C# 查漏补缺

### 步骤1：static 静态成员
**大白话**：普通成员是"每个对象各有一份"；static 成员是"整个类只有一份、大家共享"，不用 new，直接用"类名.成员"访问。常用来做计数、全局数据。

```csharp
class Character
{
    public static int Count = 0;   // 静态字段：全程序就一份，记录创建了多少个角色

    public Character()            // 构造方法：每 new 一个对象执行一次
    {
        Count++;                  // 每造一个角色，计数 +1
    }
}

// 使用：直接 类名.静态字段，不需要对象
Console.WriteLine(Character.Count);
```

| | 实例成员（无 static） | 静态成员（static） |
|---|---|---|
| 属于谁 | 对象 | 类 |
| 份数 | 每个对象一份 | 全程序一份 |
| 怎么访问 | 对象名.成员 | 类名.成员（不用 new） |
| 例子 | name、hp | Console.WriteLine、Character.Count |

**⚠️易错点**：静态方法里不能直接访问实例字段（静态方法没有具体对象，不知道用谁的数据）。

---

### 步骤2：属性深入（private set / 计算属性）
**大白话**：属性是字段的"门卫"，控制外部能不能读、能不能改。

```csharp
// ① private set 自动属性：一行替代"私有字段+只读属性"
//    外部只能读、不能乱改；类内部可以改
public int Hp { get; private set; }

// ② 计算属性（只读）：不存数据，每次读取时现算
public bool IsDead
{
    get { return Hp <= 0; }   // 血量<=0 就是死亡
}

// 构造里给属性赋初值
public Character(int hp)
{
    Hp = hp;
}
```

| 写法 | 外部能读？ | 外部能改？ | 用途 |
|---|---|---|---|
| public int Hp;（裸字段） | 能 | 能，随便改 | 不安全，少用 |
| public int Hp { get; private set; } | 能 | 不能（内部能） | 只读血量 |
| 只写 get（计算属性） | 能 | 不能 | IsDead 这种现算的标志 |

**⚠️易错点**：bool 类型属性命名用 Is/Has 开头（IsDead、HasKey）；get/set 里别漏写 return 或赋值。

---

### 步骤3：enum 枚举 + 游戏状态机
**大白话**：enum 是自己定义的"只能取固定几个值"的类型，比用字符串防拼错、比用数字直观。和 switch 是绝配。

```csharp
// 枚举：和 class 平级，写在 class 大括号外面
enum GameState
{
    Menu,     // 菜单（默认=0）
    Playing,  // 游戏中
    Paused,   // 暂停
    Win       // 胜利
}

// 状态机：一个状态变量 + while 循环 + switch 分发
GameState state = GameState.Menu;
bool running = true;
while (running)
{
    switch (state)
    {
        case GameState.Menu:
            Console.WriteLine("按回车开始");
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                state = GameState.Playing;   // 按键只负责"改状态"
            break;                          // break 结束这个 case
        case GameState.Win:
            Console.WriteLine("胜利，按Q退出");
            if (Console.ReadKey(true).Key == ConsoleKey.Q)
                running = false;            // 想退出整个循环，改循环开关
            break;
        // ……其他状态同理
    }
}
```

**状态机运转**：state 记录当前在哪个"房间" → 每圈 switch 看 state 进对应房间 → 按键只改 state → 下一圈 switch 按新 state 切画面。

**⚠️易错点（重点坑）**：
- 每个 case 末尾必须 `break;`，否则会穿透到下一个 case；
- **break 只结束 switch/case，跳不出外面的 while**；想结束循环要用 `bool running` 标志（running=false）或 return。

---

### 步骤4：namespace 命名空间（了解即可）
**大白话**：给代码分类、防止类名撞车（自己写的 Score 和 Unity 官方的 Score 撞名就是命名空间冲突）。

- `using System;` → 才能直接用 Console；
- `using System.Collections.Generic;` → 才能用 List；
- `using UnityEngine;` → 才能用 MonoBehaviour；
- 不 using 就得写全名：`System.Console.WriteLine()`。
- 现阶段不用给自己的代码包 namespace，看得懂即可。

下午 Unity 部分，复制进笔记：

---

```markdown
## 🌤 下午：Unity 可玩小关 + GameManager 单例

### 步骤1：触发检测复习（OnTriggerEnter）
**大白话**：物体勾了 Is Trigger 就能被穿过，穿的瞬间自动调用 OnTriggerEnter；用来做金币、终点、伤害区。

```csharp
void OnTriggerEnter(Collider other)   // other = 撞进来的对方的碰撞体
{
    if (other.CompareTag("Player"))   // 判断对方是不是玩家（标签 Player 大写 P）
    {
        Destroy(gameObject);          // 销毁挂脚本的物体自己（金币）
    }
}
```

| | 触发器（勾 Is Trigger，能穿过） | 实体碰撞（不勾，被挡住） |
|---|---|---|
| 进入时调用 | OnTriggerEnter | OnCollisionEnter |
| 参数类型 | **Collider** | **Collision** |

**⚠️易错点**：
- 方法名和参数必须配对，OnCollisionEnter 的参数是 Collision，写错就报 "parameter has to be of type Collision"；
- 触发三条件：两物体都有 Collider + 触发物勾 Is Trigger + 至少一方有 Rigidbody；
- 内置标签是大写 `Player`，写小写 player 会报 "Tag is not defined"；
- `other.CompareTag(...)` 和 `other.gameObject.CompareTag(...)` 等价（组件自带 CompareTag），但销毁整个物体必须 `Destroy(other.gameObject)`，写 Destroy(other) 只删碰撞体组件。

---

### 步骤2：摄像机跟随 CameraFollow
**大白话**：每帧把镜头位置设成"玩家位置 + 固定偏移"，再让镜头看着玩家，玩家走到哪镜头跟到哪。

```csharp
public class CameraFollow : MonoBehaviour
{
    public Transform player;        // 拖玩家（只用位置，所以字段类型用 Transform）
    public Vector3 offset = new Vector3(0f, 8f, -8f);  // 镜头在玩家后上方

    void LateUpdate()               // 镜头跟随固定用 LateUpdate（在所有移动之后执行，不抖）
    {
        transform.position = player.position + offset; // 镜头位置 = 玩家位置 + 偏移
        transform.LookAt(player);                       // 镜头始终对准玩家
    }
}
```
**要点**：脚本挂 Main Camera；offset 的 Y 管高低、Z 管远近，运行时边改边调。

---

### 步骤3：胜利 UI 与 SetActive
**大白话**：物体名左边的小勾 = 是否激活；代码用 SetActive 控制显隐。

```csharp
winText.SetActive(true);    // 显示（勾上）
winText.SetActive(false);   // 隐藏（取消勾）
```
胜利文字先在编辑器取消勾选（开局隐藏），通关时代码再 SetActive(true)。
**⚠️易错点**：复制别的 UI 物体会连带复制它身上的脚本，记得 Remove Component 删掉多余脚本。

---

### 步骤4：GameManager 单例（今天重点）
**大白话**：游戏里放一个"总经理"，统一管分数、状态、UI；别的脚本不自己管全局数据，有事通过门牌 `GameManager.Instance` 找它。

```csharp
public enum GameState { Playing, Win }   // 状态枚举，写在 class 外面

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;     // ① 静态门牌：全局唯一入口

    public int score = 0;                          // 全局分数
    public GameState state = GameState.Playing;    // 当前状态，默认游戏中
    public ScoreUI scoreUI;                        // 拖分数 UI
    public GameObject winText;                     // 拖胜利文字

    void Awake()                            // Awake 比 Start 更早，适合做注册
    {
        Instance = this;                    // ② 把自己登记到门牌
        DontDestroyOnLoad(gameObject);      // ③ 切场景时不销毁（单例标配）
    }

    public void AddScore(int amount)        // 对外服务：加分
    {
        score = score + amount;
        scoreUI.RefreshScore(score);
    }

    public void WinGame()                   // 对外服务：胜利
    {
        state = GameState.Win;
        winText.SetActive(true);
    }
}
```
**别的脚本怎么用**：
```csharp
GameManager.Instance.AddScore(1);   // 金币里：加分交给总管
GameManager.Instance.WinGame();     // 终点门里：胜利交给总管
```
**职责分离**：金币只负责"通知吃到了"、终点门只负责"通知到了"，分数/状态/UI 全在 GameManager 里。以后加暂停、失败、重开都往总管里加。

**⚠️易错点**：
- GameManager 脚本挂在一个空物体上（Create Empty）；
- 静态成员用"类名.成员"访问：GameManager.Instance；
- 分数 UI、胜利文字的引用只拖到 GameManager 上，金币/终点门不再拖 UI。

---

### 步骤5：胜利后锁玩家（enum 状态 + 卫语句）
**大白话**：在移动、跳跃方法开头放个"保安"，一旦状态是 Win 就提前 return，后面操作代码不执行。

```csharp
void FixedUpdate()
{
    // 卫语句：胜利了就直接结束本次方法，移动代码不执行
    if (GameManager.Instance.state == GameState.Win)
    {
        return;
    }
    // ……正常移动逻辑
}
// 处理跳跃的 Update 开头也加一段一样的
```
**原理**：return 只结束"这一次"方法调用；Unity 每帧/每物理步都会重新调用，胜利后 state 一直是 Win，每次都在开头被挡回，玩家就一直动不了。
**⚠️易错点**：
- 判断语句必须写在方法 `{ }` 内部，不能写在类体里（类体只能放字段/方法）；
- return 结束整个方法，break 只跳出 switch/循环，别混。

---

### 今日小关完整流程
起点（镜头跟随）→ WASD 移动、空格跳障碍 → 吃金币（AddScore + 分数 UI）→ 穿过终点门（WinGame：弹胜利文字 + 状态切 Win）→ 卫语句锁操作。
```

