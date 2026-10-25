# Bài thực hành 4 – Microservices đại lý bảo hiểm

Solution .NET 8 gồm các microservice của case study, API Gateway, Blazor WebAssembly client, Vue client và các tài nguyên PostgreSQL, Eureka, Docker Compose được cung cấp.

## Build

Từ thư mục này chạy:

```powershell
dotnet build .\TH4InsuranceMicroservices.sln --nologo
```

Các project nhắm `net8.0`. Cần cài .NET 8 SDK/runtime và có kết nối NuGet ở lần restore đầu tiên.

## Microservices

Chín service Auth, Chat, Dashboard, Payment, Policy Search, Policy, Pricing, Product và Document được gom theo thư mục `<Service>/`, mỗi thư mục chứa `<Service>.Api/`, `<Service>/` (implementation) và `<Service>.Test/` Pricing còn có project kiểm thử tích hợp riêng. Ba project của Document Service hiện là khung theo yêu cầu Task #1; tích hợp JS Report chưa được triển khai.

## Hạ tầng và dữ liệu

- Script tạo bốn database PostgreSQL đi kèm: `postgres/createdatabases.sql`.
- Product Service dùng Npgsql/EF Core và database `lab_netmicro_products`; tạo database này bằng `postgres/createproductsdatabase.sql`.
- Database provider theo service: Policy dùng NHibernate/Npgsql; Payment dùng Marten và Hangfire PostgreSQL; Pricing dùng Marten; Product dùng EF Core/Npgsql. Cấu hình các chuỗi kết nối cục bộ qua `ConnectionStrings__DefaultConnection`, `ConnectionStrings__PgConnection` và `ConnectionStrings__Products` theo service; không đưa giá trị có mật khẩu vào Git.
- Cấu hình Docker Compose và script chạy: `scripts/`.
- Eureka: `eureka-server/`.
- Elasticsearch, RabbitMQ và Docker cần chạy riêng hoặc qua Compose trước khi chạy toàn bộ ứng dụng.

Không đưa file `.env`, `appsettings*.json`, database dump hoặc credential vào Git. Khai báo giá trị môi trường cục bộ trong máy chạy, không lưu trong repository.

## Nguồn code

Các microservice được khôi phục từ dự án công khai [asc-lab/dotnetcore-microservices-poc](https://github.com/asc-lab/dotnetcore-microservices-poc/tree/6500daaf5ca6287385bfdfe5246cd1f3959c73fd), commit `6500daaf5ca6287385bfdfe5246cd1f3959c73fd`. Giấy phép Apache-2.0 được giữ tại `LICENSE`. Các file cấu hình có thể chứa thông tin xác thực không được sao chép từ bản tham chiếu.
