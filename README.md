## Dapr 安装步骤

- Dapr Window 本地安装

  - Dapr Cli 安装 [官方文档](https://learn.microsoft.com/zh-cn/dotnet/architecture/dapr-for-net-developers/getting-started)

- ```
      powershell -Command "iwr -useb https://raw.githubusercontent.com/dapr/cli/master/install/install.ps1 | iex"
      默认安装在 C:\dapr 需要加收到环境变量中
      使用管理员启动终端 执行： dapr init  该命令初始话会运行 daprio/dapr、openzipkin/zipkin和redis图像的容器实例
      查看是否安装正常
      PS C:\WINDOWS\system32> dapr --version
      CLI version: 1.10.0
      Runtime version: n/a
      查看daper 初始化启动的容器： dockers ps
        如果 openzipkin/zipkin 没安装成功  执行命令 dapr uninstall,之后dapr init

      最后安装 net6 sdk
  ```

  [net6sdk](https://download.visualstudio.microsoft.com/download/pr/4a725ea4-cd2c-4383-9b63-263156d5f042/d973777b32563272b85617105a06d272/dotnet-sdk-6.0.406-win-x64.exe)

- 安装失败可参考 [点击查看](https://www.cnblogs.com/cfam/p/15423041.html)
- [Dapr 配置](https://www.107000.com/T-Doc/2087)
