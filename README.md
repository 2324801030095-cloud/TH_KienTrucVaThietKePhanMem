# Bài thực hành 4 – Microservices đại lý bảo hiểm

Solution .NET 8 gồm các microservice của case study, API Gateway, Blazor WebAssembly client, Vue client và các tài nguyên PostgreSQL, Eureka, Docker Compose được cung cấp.

## Build

Từ thư mục này chạy:

```powershell
dotnet build .\TH4InsuranceMicroservices.sln --nologo
```

Các project nhắm `net8.0`. Cần cài .NET 8 SDK/runtime và có kết nối NuGet ở lần restore đầu tiên.

## Microservices

Mỗi service có project API definition (`*.Api`), implementation và test (`*.Test`). Các service: Auth, Chat, Dashboard, Payment, Policy Search, Policy, Pricing và Product. Pricing còn có project kiểm thử tích hợp riêng.

## Hạ tầng và dữ liệu

- Script khởi tạo database PostgreSQL: `postgres/postgres/createdatabases.sql`.
- Cấu hình Docker Compose và script chạy: `scripts/scripts/`.
- Eureka: `eureka-server/eureka-server/`.
- Elasticsearch, RabbitMQ và Docker cần chạy riêng hoặc qua Compose trước khi chạy toàn bộ ứng dụng.

Không đưa file `.env`, `appsettings*.json`, database dump hoặc credential vào Git. Khai báo giá trị môi trường cục bộ trong máy chạy, không lưu trong repository.

## Nguồn code

Các microservice được khôi phục từ dự án công khai [asc-lab/dotnetcore-microservices-poc](https://github.com/asc-lab/dotnetcore-microservices-poc/tree/6500daaf5ca6287385bfdfe5246cd1f3959c73fd), commit `6500daaf5ca6287385bfdfe5246cd1f3959c73fd`. Giấy phép Apache-2.0 được giữ tại `LICENSE`. Các file cấu hình có thể chứa thông tin xác thực không được sao chép từ bản tham chiếu.
