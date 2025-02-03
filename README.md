# 🏠 HomeCraft API - Your Smart Home Solution 🌟

![Screenshot 2025-01-07 025707](https://github.com/user-attachments/assets/ac7a8f5b-ab14-446f-8419-5e3928270797)

## 🎯 Overview
HomeCraft is a modern REST API for smart home appliances management built with ASP.NET Core. It provides a comprehensive set of features for e-commerce, user management, and product administration. 🚀

## ⭐ Key Features

### 🔐 Authentication & Authorization
- 📝 User registration and login
- 🎫 JWT-based authentication
- 👮‍♂️ Role-based access control (Admin/User)
- 🔑 Password recovery with email confirmation

### 🛍️ E-Commerce Features
- 📦 Product catalog with advanced filtering and search
- 🛒 Shopping cart management
- 💳 Secure checkout with Stripe integration
- 📊 Order tracking and management
- ⭐ Review and rating system

### 👤 User Features
- 🎭 Profile management
- 📜 Order history
- ❤️ Wishlist functionality
- 📧 Email notifications

### 👨‍💼 Admin Dashboard
- ✨ Product management (CRUD operations)
- 👥 User management
- 📦 Order processing
- 📈 Analytics and reporting
- 📊 Inventory management

## 🛠️ Technical Stack

### 🎯 Core Technologies
- ⚡ ASP.NET Core 8.0
- 🔒 JWT Authentication
- 🎲 Entity Framework Core
- 💾 SQL Server

### 🌟 Additional Features
- 📨 SMTP Email Service
- 💳 Stripe Payment Integration
- 🔄 RESTful API Architecture
- 📝 Swagger Documentation

## 🚀 Getting Started

### 📥 1. Clone the Repositor
```bash
git clone https://github.com/StiliyanIliev27/SmartHomeApplianceBE
```

### ⚙️ 2. Backend Setup
```bash
cd SmartHomeApplianceBE
dotnet restore
```

### 🔧 Backend Configuration
1. Open `.sln` file in Visual Studio
2. Right-click on SmartHomeAppliance.API → Manage User Secrets
3. Add the following structure:
```json
{
  "Stripe": {
    "SecretKey": "your_stripe_secret_key",
    "PublishableKey": "your_stripe_publishable_key",
    "WebhookSecret": "your_stripe_webhook_secret"
  },
  "SMTP": {
    "Username": "your_email@gmail.com",
    "Port": "465",
    "Password": "your_app_specific_password",
    "Host": "smtp.gmail.com",
    "BypassCertificateValidation": "true"
  },
  "Jwt": {
    "Key": "your_jwt_secret_key",
    "Issuer": "YourAppIssuer",
    "ExpiryMinutes": "60",
    "Audience": "YourAppAudience"
  },
  "FrontendUrl": "http://localhost:5173",
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=SmartHomeApplianceDatabase;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;"
  },
  "Cloudinary": {
    "CloudName": "your_cloud_name",
    "ApiKey": "your_api_key",
    "ApiSecret": "your_api_secret"
  }
}
```

### 🗄️ 4. Database Setup
1. Open Package Manager Console in Visual Studio
2. Select `SmartHomeAppliance.Infrastructure` as Default Project
3. Run migrations:
```bash
Update-Database
```

### 🔑 Required Services
- 💳 Stripe Account - for payment processing
- ☁️ Cloudinary Account - for image storage
- 📧 Gmail Account - for email services
- 🗃️ SQL Server - for database

### 🚀 5. Run the Application
After completing the setup, you can run the application using Visual Studio or the following command:
```bash
dotnet run --project SmartHomeAppliance.API
```

## 📚 API Documentation
- 📖 Swagger UI available at `/swagger`
- 🔍 Detailed API documentation in `/docs`

## 🔒 Security Features
- 🛡️ JWT Authentication
- 🔐 Password Hashing
- 📧 Email Verification
- 🚫 Rate Limiting
- 🛑 CORS Policy

## 💎 Best Practices
- ✨ Clean Architecture
- 🎯 SOLID Principles
- 🧪 Unit Testing
- 🔄 Repository Pattern
- 🎭 Dependency Injection

## 📫 Contact & Support
- 📧 Email: stiliyaniliev2705@gmail.com

## 📄 License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details. 📜

---
### 🌟 Made with ❤️ by Stiliyan Iliev
