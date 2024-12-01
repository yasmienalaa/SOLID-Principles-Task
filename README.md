# SOLID Principles Violations Exercise

This project deliberately violates all SOLID principles to serve as a learning exercise. Students should identify these violations and refactor the code to follow SOLID principles.

## SOLID Violations Present

### Single Responsibility Principle (SRP) Violations
- `SubscriptionManager` handles multiple responsibilities:
  - Subscription management
  - Payment processing
  - Email notifications
  - Analytics tracking
  - Report generation
  - Data persistence
  - Billing records

### Open/Closed Principle (OCP) Violations
- `SubscriptionManager` uses switch statements for different subscription types
- Direct implementation of subscription-specific features
- Adding new subscription types requires modifying existing code

### Liskov Substitution Principle (LSP) Violations
- `GenerateUsageReport` method throws exceptions for certain subscription types
- Subscription class hierarchy doesn't allow for proper substitution
- Features that aren't available in all subscription types are exposed in the base class

### Interface Segregation Principle (ISP) Violations
- `Subscription` class contains properties that aren't relevant for all subscription types:
  - Payment history for free subscriptions
  - Analytics for basic subscriptions
  - Report generation capabilities
  - Support features

### Dependency Inversion Principle (DIP) Violations
- Direct dependency on concrete `Database` class
- No interfaces for:
  - Data access
  - Email services
  - Payment processing
  - Analytics tracking
  - Report generation

## Student Tasks

1. Identify all SOLID principle violations in the code
2. Refactor the code to follow SOLID principles:
   - Separate responsibilities into different classes
   - Create appropriate interfaces
   - Implement dependency injection
   - Use proper abstractions
   - Create separate classes for different subscription types

### Expected Improvements

1. Create separate classes/interfaces for:
   - Subscription management
   - Payment processing
   - Email notifications
   - Analytics tracking
   - Report generation
   - Data persistence

2. Implement proper inheritance/interfaces for different subscription types

3. Use dependency injection for:
   - Database access
   - Email service
   - Payment processing
   - Analytics service

4. Create smaller, focused interfaces for different capabilities

5. Remove direct dependencies on concrete implementations

