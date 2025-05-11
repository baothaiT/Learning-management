# Learning-management
Learning-management


# Architectures
1. Language.API
2. User.API
3. Gateway.API
4. Orchestrator-Even-Stream.Worker
5. Email.API



src/
├── MyApp.Domain/                # 1. Domain layer
│   ├── Entities/
│   │   └── Order.cs
│   ├── ValueObjects/
│   │   └── Address.cs
│   ├── Interfaces/
│   │   └── IOrderRepository.cs
│   ├── Services/
│   │   └── IOrderDomainService.cs
│   ├── Events/
│   │   └── OrderCreatedEvent.cs
│   └── MyApp.Domain.csproj
│
├── MyApp.Application/           # 2. Application layer
│   ├── DTOs/
│   │   └── OrderDto.cs
│   ├── Commands/
│   │   ├── CreateOrderCommand.cs
│   │   └── CreateOrderCommandHandler.cs
│   ├── Queries/
│   │   ├── GetOrderByIdQuery.cs
│   │   └── GetOrderByIdQueryHandler.cs
│   ├── Interfaces/
│   │   └── IOrderService.cs
│   └── MyApp.Application.csproj
│
├── MyApp.Infrastructure/        # 3. Infrastructure layer
│   ├── Data/
│   │   ├── AppDbContext.cs
│   │   └── RepositoryBase.cs
│   ├── Repositories/
│   │   └── OrderRepository.cs
│   ├── DependencyInjection/
│   │   └── InfrastructureServices.cs
│   └── MyApp.Infrastructure.csproj
│
└── MyApp.Api/                   # 4. API (presentation)
    ├── Controllers/
    │   └── OrdersController.cs
    ├── Program.cs
    └── MyApp.Api.csproj


## Aspire
dotnet new aspire-apphost -o Learning.AppHost
dotnet new aspire-servicedefaults -o Learning.ServiceDefaults


.NET Aspire App Host               aspire-apphost          [C#]      Common/.NET Aspire/Cloud
.NET Aspire Empty App              aspire                  [C#]      Common/.NET Aspire/Cloud/Web/Web API/API/Service
.NET Aspire Service Defaults       aspire-servicedefaults  [C#]      Common/.NET Aspire/Cloud/Web/Web API/API/Service
.NET Aspire Starter App            aspire-starter          [C#]      Common/.NET Aspire/Blazor/Web/Web API/API/Service/Cloud/Test/MSTest/NUnit/xUnit
.NET Aspire Test Project (MSTest)  aspire-mstest           [C#]      Common/.NET Aspire/Cloud/Web/Web API/API/Service/Test/MSTest
.NET Aspire Test Project (NUnit)   aspire-nunit            [C#]      Common/.NET Aspire/Cloud/Web/Web API/API/Service/Test/NUnit
.NET Aspire Test Project (xUnit)   aspire-xunit            [C#]      Common/.NET Aspire/Cloud/Web/Web API/API/Service/Test/xUnit