call dotnet build ../ProductService/ProductService/ProductService.Api
call dotnet build ../PricingService/PricingService/PricingService.Api
call dotnet build ../PolicyService/PolicyService/PolicyService.Api
call dotnet build ../PaymentService/PaymentService/PaymentService.Api
call dotnet build ../PolicySearchService/PolicySearchService/PolicySearchService.Api

call dotnet build ../AgentPortalApiGateway
call dotnet build ../AuthService/AuthService
call dotnet build ../ProductService/ProductService
call dotnet build ../PricingService/PricingService
call dotnet build ../PolicyService/PolicyService
call dotnet build ../PaymentService/PaymentService
call dotnet build ../PolicySearchService/PolicySearchService

call dotnet build ../ProductService/ProductService/ProductService.Test
call dotnet build ../PricingService/PricingService/PricingService.Test
call dotnet build ../PolicyService/PolicyService/PolicyService.Test
call dotnet build ../PaymentService/PaymentService/PaymentService.Test

call dotnet test ../ProductService/ProductService/ProductService.Test
call dotnet test ../PricingService/PricingService/PricingService.Test
call dotnet test ../PolicyService/PolicyService/PolicyService.Test
call dotnet test ../PaymentService/PaymentService/PaymentService.Test