﻿global using Azure.Monitor.OpenTelemetry.AspNetCore;
global using CoreEx;
global using CoreEx.AspNetCore.WebApis;
global using CoreEx.AspNetCore.HealthChecks;
#if (implement_services)
#if (implement_database || implement_sqlserver)
global using CoreEx.Azure.ServiceBus;
global using CoreEx.Azure.Storage;
global using CoreEx.Database;
global using CoreEx.Database.HealthChecks;
global using CoreEx.Database.SqlServer.Outbox;
#endif
#endif
global using CoreEx.Entities;
global using CoreEx.Events;
#if (implement_services)
#if (implement_database || implement_sqlserver)
global using CoreEx.Hosting;
#endif
#endif
global using CoreEx.Http;
global using CoreEx.RefData;
global using CoreEx.Validation;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Mvc;
#if (implement_database || implement_sqlserver)
global using Microsoft.Data.SqlClient;
#endif
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.OpenApi.Models;
#if (implement_mysql)
global using MySql.Data.MySqlClient;
#endif
#if (implement_postgres)
global using Npgsql;
#endif
global using OpenTelemetry.Trace;
global using System.Net;
global using System.Reflection;
global using Company.AppName.Api;
global using Company.AppName.Business;
global using Company.AppName.Business.Data;
global using Company.AppName.Business.Entities;
global using Company.AppName.Business.Validation;
global using RefDataNamespace = Company.AppName.Business.Entities;
#if (implement_cosmos)
global using AzCosmos = Microsoft.Azure.Cosmos;
#endif
#if (implement_services)
global using AzServiceBus = Azure.Messaging.ServiceBus;
#if (implement_database || implement_sqlserver)
global using AzBlobs = Azure.Storage.Blobs;
#endif
#endif