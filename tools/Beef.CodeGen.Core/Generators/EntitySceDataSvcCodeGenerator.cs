﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using OnRamp.Generators;
using System.Collections.Generic;
using System.Linq;

namespace Beef.CodeGen.Generators
{
    /// <summary>
    /// Represents the <b>DataSvc</b> Service Collection Extensions code generator; where not excluded and at least one operation exists.
    /// </summary>
    public class EntitySceDataSvcCodeGenerator : CodeGeneratorBase<Config.Entity.CodeGenConfig, Config.Entity.CodeGenConfig>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="config"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        protected override IEnumerable<Config.Entity.CodeGenConfig> SelectGenConfig(Config.Entity.CodeGenConfig config)
            => (config ?? throw new System.ArgumentNullException(nameof(config))).Entities!.Any(x => IsFalse(x.ExcludeDataSvc) && x.Operations!.Count > 0) ? [config] : System.Array.Empty<Config.Entity.CodeGenConfig>();
    }
}