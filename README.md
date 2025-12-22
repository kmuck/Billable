# Billable

Billable is a time-based billing tool for freelancers.

It allows tracking work activities and generating invoices from them.

## Features

- Track billable activities
  - Hour-based work
  - Fixed-price missions
- Generate invoices from recorded activities
- Simple and explicit domain model
- Focused on solo freelance workflows

## Architecture

Billable is built as a microservices-based system using the .NET ecosystem.

### Components

- Billable.AppHost
- Billable.Clients.Web
- Billable.ApiGateway
- Billable.Services.Identity
- Billable.Services.Project
- Billable.Services.Activity
- Billable.Services.Invoice
- Billable.Services.Notification
- Billable.Shared.Contracts
- Billable.Shared.Defaults

## Storage

- PostgreSQL
- MongoDB

## Purpose

This project is developed as a **personal portfolio** to experiment with:
- domain-driven design concepts
- service boundaries
- authentication and API architecture in .NET

## 📄 License

This project is licensed under the **MIT License**.
