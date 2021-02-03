﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using Beef.RefData;
using System.Threading.Tasks;

namespace Beef.Validation.Rules
{
    /// <summary>
    /// Provides validation for a <see cref="ReferenceDataBase"/>; validates that the <see cref="ReferenceDataBase.IsValid"/>.
    /// </summary>
    public class ReferenceDataRule<TEntity, TProperty> : ValueRuleBase<TEntity, TProperty>
        where TEntity : class
        where TProperty : ReferenceDataBase?
    {
        /// <summary>
        /// Validate the property value.
        /// </summary>
        /// <param name="context">The <see cref="PropertyContext{TEntity, TProperty}"/>.</param>
        public override Task ValidateAsync(PropertyContext<TEntity, TProperty> context)
        {
            Beef.Check.NotNull(context, nameof(context));

            if (context.Value == null)
                return Task.CompletedTask;

            if (!context.Value.IsValid)
                context.CreateErrorMessage(ErrorText ?? ValidatorStrings.InvalidFormat);

            return Task.CompletedTask;
        }
    }
}