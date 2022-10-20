using Castle.DynamicProxy;
using Core.Logging;
using Core.Logging.Log4Net;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;

namespace Core.Aspects.Autofac.Logging
{
    public class LogAspect : MethodInterception
    {
        //Eğer gelen tip loggerservicebase den kalıtım almamışsa senin log tipin yanlış diye exception fırlatıyor
        //instance oluşturuyoruz
        private LoggerServiceBase _loggerServiceBase;
        public LogAspect(Type loggerService)
        {
            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new System.Exception("Wrong logger type");
            }

            _loggerServiceBase = (LoggerServiceBase)Activator.CreateInstance(loggerService);
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _loggerServiceBase.Info(GetLogDetail(invocation));
        }

        protected override void OnAfter(IInvocation invocation)
        {
            _loggerServiceBase.Info(GetLogDetail(invocation));
        }

        private LogDetail GetLogDetail(IInvocation invocation)
        {
            var logParameters = new List<LogParameter>();
            for (int i = 0; i < invocation.Arguments.Length; i++)
            {
                logParameters.Add(new LogParameter
                {
                    Name = invocation.GetConcreteMethod().GetParameters()[i].Name,
                    Value = invocation.Arguments[i],
                    Type = invocation.Arguments[i].GetType().Name
                });
            }
            //todo: Username cookieden çekilecek
            var logDetail = new LogDetail
            {
                UserName = "Emine",
                MethodName = invocation.Method.Name,
                LogParameters = logParameters,
                TransactionDate = DateTime.Now,
            };

            return logDetail;
        }
    }
}
