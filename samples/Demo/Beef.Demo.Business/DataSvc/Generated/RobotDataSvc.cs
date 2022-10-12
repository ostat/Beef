/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the <see cref="Robot"/> data repository services.
    /// </summary>
    public partial class RobotDataSvc : IRobotDataSvc
    {
        private readonly IRobotData _data;
        private readonly IEventPublisher _events;
        private readonly IRequestCache _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IRobotData"/>.</param>
        /// <param name="events">The <see cref="IEventPublisher"/>.</param>
        /// <param name="cache">The <see cref="IRequestCache"/>.</param>
        public RobotDataSvc(IRobotData data, IEventPublisher events, IRequestCache cache)
            { _data = data ?? throw new ArgumentNullException(nameof(data)); _events = events ?? throw new ArgumentNullException(nameof(events)); _cache = cache ?? throw new ArgumentNullException(nameof(cache)); RobotDataSvcCtor(); }

        partial void RobotDataSvcCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Robot"/>.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>The selected <see cref="Robot"/> where found.</returns>
        public Task<Robot?> GetAsync(Guid id) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            if (_cache.TryGetValue(id, out Robot? __val))
                return __val;

            var __result = await _data.GetAsync(id).ConfigureAwait(false);
            return _cache.SetValue(__result);
        });

        /// <summary>
        /// Creates a new <see cref="Robot"/>.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/>.</param>
        /// <returns>The created <see cref="Robot"/>.</returns>
        public Task<Robot> CreateAsync(Robot value) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _data.CreateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            _events.PublishValueEvent(__result, new Uri($"/robots/{__result.Id}", UriKind.Relative), $"Demo.Robot", "Create");
            return _cache.SetValue(__result);
        }, new BusinessInvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Updates an existing <see cref="Robot"/>.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/>.</param>
        /// <returns>The updated <see cref="Robot"/>.</returns>
        public Task<Robot> UpdateAsync(Robot value) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _data.UpdateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            _events.PublishValueEvent(__result, new Uri($"/robots/{__result.Id}", UriKind.Relative), $"Demo.Robot", "Update");
            return _cache.SetValue(__result);
        }, new BusinessInvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Deletes the specified <see cref="Robot"/>.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        public Task DeleteAsync(Guid id) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            await _data.DeleteAsync(id).ConfigureAwait(false);
            _events.PublishValueEvent(new Robot { Id = id }, new Uri($"/robots/{id}", UriKind.Relative), $"Demo.Robot", "Delete");
            _cache.Remove<Robot>(id);
        }, new BusinessInvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Gets the <see cref="RobotCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="Entities.RobotArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="RobotCollectionResult"/>.</returns>
        public Task<RobotCollectionResult> GetByArgsAsync(RobotArgs? args, PagingArgs? paging) => DataSvcInvoker.Current.InvokeAsync(this, _ => _data.GetByArgsAsync(args, paging));
    }
}

#pragma warning restore
#nullable restore