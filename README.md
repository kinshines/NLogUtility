# A Log Utility Using NLog
[![Build status](https://ci.appveyor.com/api/projects/status/h24237n59f7vjask?svg=true)](https://ci.appveyor.com/project/kinshines/nlogutility)   [![NuGet package](https://badge.fury.io/nu/NLogUtility.svg)](https://www.nuget.org/packages/NLogUtility)

## break change in v2.0
Since the class name 'Logger' is conflict with the definition in NLog, we change the static class name to 'LogUtil'

### 1.static void Info(string module, string message, params object[] args)
the method will log info-level infomation to the file: '{basedir}\\logs\\{module}\\{module}.log'

the historical log file will be archive to '{basedir}\\logs\\{module}\\{module}_{shortdate}.log' and remain for 30 days
### 2.static void Trace(string module, string message, params object[] args)
the method will log trace-level infomation to the file: '{basedir}\\logs\\{module}\\{module}.log'

the historical log file will be archive to '{basedir}\\logs\\{module}\\{module}_{shortdate}.log' and remain for 30 days
### 3.static void Error(Exception ex, string message, params object[] args)
the method will log exception infomation with appended message to the file: '{basedir}\\logs\\error\\error.log'

the historical log file will be archive to '{basedir}\\logs\\error\\error_{shortdate}.log' and remain for 30 days
### 4.static void Error(Exception ex)
the method will log exception infomation to the file: '{basedir}\\logs\\error\\error.log'

the historical log file will be archive to '{basedir}\\logs\\error\\error_{shortdate}.log' and remain for 30 days
### 5.static void Error(string message, params object[] args)
the method will log will log message infomation to the file: '{basedir}\\logs\\error\\error.log'

the historical log file will be archive to '{basedir}\\logs\\error\\error_{shortdate}.log' and remain for 30 days
### 6.static void Alert(Exception ex, string message, params object[] args)
the method will send email with exception infomation include appended message to the related person
### 7.static void Alert(string message, params object[] args)
the method will send email with message to the related person
### 8.static void PureInfo(string module, string message, params object[] args)
the method will log just message without time information to the file: '{basedir}\\logs\\{module}\\{module}.pure.log'

the historical log file will be archive to '{basedir}\\logs\\{module}.pure\\{module}.pure_{shortdate}.log' and remain for 30 days
## Attention: 
## the Trace method will take effect When change 'minlevel' value to 'Trace' in NLog.config file
## the Alert method will take effect When change 'to','from','smtpUserName','smtpPassword' to appropriate value in Mail Target
