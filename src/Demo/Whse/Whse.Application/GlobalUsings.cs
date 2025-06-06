global using System.Linq.Expressions;
global using System.Reflection;
global using Adnc.Demo.Const;
global using Adnc.Demo.Remote.Http.Services;
global using Adnc.Demo.Whse.Application.Dtos;
global using Adnc.Demo.Whse.Application.Services;
global using Adnc.Demo.Whse.Application.Subscribers;
global using Adnc.Demo.Whse.Domain.Aggregates.ProductAggregate;
global using Adnc.Demo.Whse.Domain.Aggregates.WarehouseAggregate;
global using Adnc.Demo.Whse.Domain.EntityConfig;
global using Adnc.Demo.Whse.Domain.Services;
global using Adnc.Infra.Redis.Caching;
global using Adnc.Infra.Repository;
global using Adnc.Infra.Repository.Interceptor;
global using Adnc.Shared.Application.Contracts.Attributes;
global using Adnc.Shared.Application.Contracts.Dtos;
global using Adnc.Shared.Application.Contracts.Interfaces;
global using Adnc.Shared.Application.Services;
global using Adnc.Shared.Application.Services.Trackers;
global using Adnc.Shared.Domain;
global using AutoMapper;
global using DotNetCore.CAP;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.DependencyInjection;
