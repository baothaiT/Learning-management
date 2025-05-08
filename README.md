# Learning-management
Learning-management


# Architectures
1. LanguageAPI
2. UserAPI
3. GatewayAPI



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
