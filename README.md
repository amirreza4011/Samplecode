# Samplecode
توضیحات پروژه:
متاسفانه به دلیل بالا بودن حجم کاری در زمان باقیمانده تا اتمام کار با شرکت جلسات فشرده اجازه انجام کد را به بنده نداده و فقط قسمتی از کد را برای ابراز نوع تفکرم به عنوان معمار سیستم انجام و ارسال کردم :
خط مش معماری :
مایکروسیستم 
تعداد لایه :
دو لایه 
معماری استفاده شده در هر لایه :
Clean Architecture
ارتباط بین سرویسها :
RabbitMq
پترنهای استفاده شده :
CQRS(MediatR)-SAGA(choreography)
تکنولوزژیها:
Entity Freamwork(command) –Dapper(quary)-Automaper-Ocelot(Apiwetway-)
برای تراکنش های توزیع شده :
Distributed Transaction usin Saga pattern and Rabbitmq
یک لایه برای تست سرویسها و هچنین ارتباط بین انها :
Unit test
برای سیستم احراز هویت از:
Jwt-refresh
برای محیط اجرا :
Docker-Kuber(loadbalance)
Ci/Cd
GitHub-Jenkins

 

