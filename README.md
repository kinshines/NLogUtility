# NLogUtility
[![AppVeyor](https://ci.appveyor.com/api/projects/status/h24237n59f7vjask?svg=true)](https://ci.appveyor.com/project/kinshines/nlogutility/branch/master)   
### 1.static void Info(string module, string message, params object[] args)
the method will log info-level infomation to the file: 'D:\item\ApplicationName\\{module}_{shortdate}.log'
### 2.static void Trace(string module, string message, params object[] args)
the method will log trace-level infomation to the file: 'D:\item\ApplicationName\\{module}_{shortdate}.log'
### 3.static void Error(Exception ex, string message, params object[] args)
the method will log exception infomation with appended message to the file: 'D:\item\ApplicationName\\{shortdate}.log'
### 4.static void Error(Exception ex)
the method will log exception infomation to the file: 'D:\item\ApplicationName\\{shortdate}.log'
## Attention: the Trace method will take effect on addtion of Modify the value of minlevel with 'Trace' in NLog.config file
