/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Beef.RefData;
using Beef.RefData.Caching;
using Beef.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Cdr.Banking.Common.Entities;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Agents
{
    /// <summary>
    /// Provides the <see cref="ReferenceData"/> implementation using the corresponding Web API agent.
    /// </summary>
    public partial class ReferenceDataAgentProvider : RefDataNamespace.ReferenceData
    {
        private readonly Dictionary<string, Type> _nameDict = new Dictionary<string, Type>();
        private readonly Dictionary<Type, string> _typeDict = new Dictionary<Type, string>();
        private readonly IReferenceDataAgent _agent;
        private readonly Dictionary<Type, object> _cacheDict = new Dictionary<Type, object>();

        #region Ctor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataAgentProvider"/> class.
        /// </summary>
        /// <param name="agent">The <see cref="IReferenceDataAgent"/>.</param>
        public ReferenceDataAgentProvider(IReferenceDataAgent agent)
        {
            _agent = Beef.Check.NotNull(agent, nameof(agent));

            _nameDict.Add(nameof(OpenStatus), typeof(RefDataNamespace.OpenStatus));
            _typeDict.Add(typeof(RefDataNamespace.OpenStatus), nameof(OpenStatus));
            _cacheDict.Add(typeof(RefDataNamespace.OpenStatus), new ReferenceDataCache<RefDataNamespace.OpenStatusCollection, RefDataNamespace.OpenStatus>(() => _agent.OpenStatusGetAllAsync().ContinueWith((t) => t.Result.Value, TaskScheduler.Current)));

            _nameDict.Add(nameof(ProductCategory), typeof(RefDataNamespace.ProductCategory));
            _typeDict.Add(typeof(RefDataNamespace.ProductCategory), nameof(ProductCategory));
            _cacheDict.Add(typeof(RefDataNamespace.ProductCategory), new ReferenceDataCache<RefDataNamespace.ProductCategoryCollection, RefDataNamespace.ProductCategory>(() => _agent.ProductCategoryGetAllAsync().ContinueWith((t) => t.Result.Value, TaskScheduler.Current)));

            _nameDict.Add(nameof(AccountUType), typeof(RefDataNamespace.AccountUType));
            _typeDict.Add(typeof(RefDataNamespace.AccountUType), nameof(AccountUType));
            _cacheDict.Add(typeof(RefDataNamespace.AccountUType), new ReferenceDataCache<RefDataNamespace.AccountUTypeCollection, RefDataNamespace.AccountUType>(() => _agent.AccountUTypeGetAllAsync().ContinueWith((t) => t.Result.Value, TaskScheduler.Current)));

            _nameDict.Add(nameof(MaturityInstructions), typeof(RefDataNamespace.MaturityInstructions));
            _typeDict.Add(typeof(RefDataNamespace.MaturityInstructions), nameof(MaturityInstructions));
            _cacheDict.Add(typeof(RefDataNamespace.MaturityInstructions), new ReferenceDataCache<RefDataNamespace.MaturityInstructionsCollection, RefDataNamespace.MaturityInstructions>(() => _agent.MaturityInstructionsGetAllAsync().ContinueWith((t) => t.Result.Value, TaskScheduler.Current)));

            _nameDict.Add(nameof(TransactionType), typeof(RefDataNamespace.TransactionType));
            _typeDict.Add(typeof(RefDataNamespace.TransactionType), nameof(TransactionType));
            _cacheDict.Add(typeof(RefDataNamespace.TransactionType), new ReferenceDataCache<RefDataNamespace.TransactionTypeCollection, RefDataNamespace.TransactionType>(() => _agent.TransactionTypeGetAllAsync().ContinueWith((t) => t.Result.Value, TaskScheduler.Current)));

            _nameDict.Add(nameof(TransactionStatus), typeof(RefDataNamespace.TransactionStatus));
            _typeDict.Add(typeof(RefDataNamespace.TransactionStatus), nameof(TransactionStatus));
            _cacheDict.Add(typeof(RefDataNamespace.TransactionStatus), new ReferenceDataCache<RefDataNamespace.TransactionStatusCollection, RefDataNamespace.TransactionStatus>(() => _agent.TransactionStatusGetAllAsync().ContinueWith((t) => t.Result.Value, TaskScheduler.Current)));

            ReferenceDataAgentProviderCtor();
        }

        partial void ReferenceDataAgentProviderCtor(); // Enables the ReferenceDataAgentProvider constructor to be extended.

        #endregion

        #region Collections

        /// <summary>
        /// Gets the <see cref="RefDataNamespace.OpenStatusCollection"/>.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.OpenStatusCollection"/>.</returns>
        public override RefDataNamespace.OpenStatusCollection OpenStatus => (RefDataNamespace.OpenStatusCollection)this[typeof(RefDataNamespace.OpenStatus)];

        /// <summary>
        /// Gets the <see cref="RefDataNamespace.ProductCategoryCollection"/>.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.ProductCategoryCollection"/>.</returns>
        public override RefDataNamespace.ProductCategoryCollection ProductCategory => (RefDataNamespace.ProductCategoryCollection)this[typeof(RefDataNamespace.ProductCategory)];

        /// <summary>
        /// Gets the <see cref="RefDataNamespace.AccountUTypeCollection"/>.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.AccountUTypeCollection"/>.</returns>
        public override RefDataNamespace.AccountUTypeCollection AccountUType => (RefDataNamespace.AccountUTypeCollection)this[typeof(RefDataNamespace.AccountUType)];

        /// <summary>
        /// Gets the <see cref="RefDataNamespace.MaturityInstructionsCollection"/>.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.MaturityInstructionsCollection"/>.</returns>
        public override RefDataNamespace.MaturityInstructionsCollection MaturityInstructions => (RefDataNamespace.MaturityInstructionsCollection)this[typeof(RefDataNamespace.MaturityInstructions)];

        /// <summary>
        /// Gets the <see cref="RefDataNamespace.TransactionTypeCollection"/>.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.TransactionTypeCollection"/>.</returns>
        public override RefDataNamespace.TransactionTypeCollection TransactionType => (RefDataNamespace.TransactionTypeCollection)this[typeof(RefDataNamespace.TransactionType)];

        /// <summary>
        /// Gets the <see cref="RefDataNamespace.TransactionStatusCollection"/>.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.TransactionStatusCollection"/>.</returns>
        public override RefDataNamespace.TransactionStatusCollection TransactionStatus => (RefDataNamespace.TransactionStatusCollection)this[typeof(RefDataNamespace.TransactionStatus)];

        #endregion

        #region This/GetCache/PrefetchAsync
    
        /// <summary>
        /// Gets the <see cref="IReferenceDataCollection"/> for the associated <see cref="ReferenceDataBase"/> <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The <see cref="ReferenceDataBase"/> <see cref="Type"/>.</param>
        /// <returns>The <see cref="IReferenceDataCollection"/>.</returns>
        public override IReferenceDataCollection this[Type type] => GetCache(type).GetCollection();

        /// <summary>
        /// Gets the <see cref="IReferenceDataCache"/> for the associated <see cref="ReferenceDataBase"/> <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The <see cref="ReferenceDataBase"/> <see cref="Type"/>.</param>
        /// <returns>The <see cref="IReferenceDataCache"/>.</returns>
        public IReferenceDataCache GetCache(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
        
            if (!_cacheDict.ContainsKey(type))
                throw new ArgumentException($"Type {type.Name} does not exist within the ReferenceDataProvider cache.");

            return (IReferenceDataCache)_cacheDict[type];
        }
        
        /// <summary>
        /// Prefetches all of the named <see cref="ReferenceDataBase"/> objects where not already cached or have expired.
        /// </summary>
        /// <param name="names">The list of <see cref="ReferenceDataBase"/> type names.</param>
        public override async Task PrefetchAsync(params string[] names)
        {
            if (names == null || names.Length == 0)
                return;

            var getNames = new List<string>();
            foreach (string name in names.Distinct())
            {
                if (_nameDict.ContainsKey(name) && GetCache(_nameDict[name]).IsExpired)
                    getNames.Add(name);
            }

            if (getNames.Count == 0)
                return;
                        
            var result = await _agent.GetNamedAsync(getNames.ToArray()).ConfigureAwait(false);
            foreach (var rdj in JObject.Parse("{ \"content\": " + result.Content ?? "[ ]" + " }")["content"]!.Children())
            {
                var name = rdj["name"]?.Value<string>();
                var items = rdj["items"]?.ToString();
                if (name != null)
                {
                    switch (name)
                    {
                        case nameof(OpenStatus): GetCache(_nameDict[nameof(OpenStatus)]).SetCollection(JsonConvert.DeserializeObject<RefDataNamespace.OpenStatus[]>(items!)); break;
                        case nameof(ProductCategory): GetCache(_nameDict[nameof(ProductCategory)]).SetCollection(JsonConvert.DeserializeObject<RefDataNamespace.ProductCategory[]>(items!)); break;
                        case nameof(AccountUType): GetCache(_nameDict[nameof(AccountUType)]).SetCollection(JsonConvert.DeserializeObject<RefDataNamespace.AccountUType[]>(items!)); break;
                        case nameof(MaturityInstructions): GetCache(_nameDict[nameof(MaturityInstructions)]).SetCollection(JsonConvert.DeserializeObject<RefDataNamespace.MaturityInstructions[]>(items!)); break;
                        case nameof(TransactionType): GetCache(_nameDict[nameof(TransactionType)]).SetCollection(JsonConvert.DeserializeObject<RefDataNamespace.TransactionType[]>(items!)); break;
                        case nameof(TransactionStatus): GetCache(_nameDict[nameof(TransactionStatus)]).SetCollection(JsonConvert.DeserializeObject<RefDataNamespace.TransactionStatus[]>(items!)); break;
                    }
                 }
            }
        }
        
        #endregion
    }
}

#pragma warning restore
#nullable restore