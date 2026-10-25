dotnet build ../ProductService/ProductService/ProductService.Api
dotnet build ../PricingService/PricingService/PricingService.Api
dotnet build ../PolicyService/PolicyService/PolicyService.Api
dotnet build ../PaymentService/PaymentService/PaymentService.Api
dotnet build ../PolicySearchService/PolicySearchService/PolicySearchService.Api

dotnet build ../AgentPortalApiGateway
dotnet build ../AuthService/AuthService
dotnet build ../ProductService/ProductService
dotnet build ../PricingService/PricingService
dotnet build ../PolicyService/PolicyService
dotnet build ../PaymentService/PaymentService
dotnet build ../PolicySearchService/PolicySearchService

dotnet build ../ProductService/ProductService/ProductService.Test
dotnet build ../PricingService/PricingService/PricingService.Test
dotnet build ../PolicyService/PolicyService/PolicyService.Test
dotnet build ../PaymentService/PaymentService/PaymentService.Test

dotnet test ../ProductService/ProductService/ProductService.Test
dotnet test ../PricingService/PricingService/PricingService.Test
dotnet test ../PolicyService/PolicyService/PolicyService.Test
dotnet test ../PaymentService/PaymentService/PaymentService.Test

