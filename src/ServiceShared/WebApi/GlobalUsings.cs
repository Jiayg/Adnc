global using System.IdentityModel.Tokens.Jwt;
global using System.Net;
global using System.Security.Claims;
global using System.Text.Encodings.Web;
global using Adnc.Infra.Core.DependencyInjection;
global using Adnc.Infra.Core.Json;
global using Adnc.Infra.EventBus.RabbitMq;
global using Adnc.Infra.Redis.Caching;
global using Adnc.Infra.Redis.Configurations;
global using Adnc.Shared;
global using Adnc.Shared.Application.Contracts.ResultModels;
global using Adnc.Shared.Remote.Handlers.Token;
global using Adnc.Shared.Remote.Http.Services;
global using FluentValidation.AspNetCore;
global using HealthChecks.UI.Client;
global using LiteX.HealthChecks.Redis;
global using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Mvc.ModelBinding;
global using Microsoft.AspNetCore.Routing;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Logging;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using Prometheus;
global using Prometheus.DotNetRuntime;
