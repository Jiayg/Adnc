﻿global using Adnc.Infra.Core.Configuration;
global using Adnc.Shared.Application.Contracts.Dtos;
global using Adnc.Shared.Consts.Permissions.Usr;
global using Adnc.Usr.Application.Contracts.Dtos;
global using Adnc.Usr.Application.Contracts.Services;
global using Adnc.Usr.WebApi.Authorize;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Tokens;
global using System;
global using System.Collections.Generic;
global using System.IdentityModel.Tokens.Jwt;
global using System.Linq;
global using System.Security.Claims;
global using System.Text;
global using System.Threading.Tasks;