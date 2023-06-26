/*
 * This file is automatically generated; any changes will be lost. 
 */

namespace MyEf.Hr.Business.DataSvc;

/// <summary>
/// Defines the <see cref="Employee"/> data repository services.
/// </summary>
public partial interface IEmployeeDataSvc
{
    /// <summary>
    /// Gets the specified <see cref="Employee"/>.
    /// </summary>
    /// <param name="id">The <see cref="Employee"/> identifier.</param>
    /// <returns>The selected <see cref="Employee"/> where found.</returns>
    Task<Result<Employee?>> GetAsync(Guid id);

    /// <summary>
    /// Creates a new <see cref="Employee"/>.
    /// </summary>
    /// <param name="value">The <see cref="Employee"/>.</param>
    /// <returns>The created <see cref="Employee"/>.</returns>
    Task<Result<Employee>> CreateAsync(Employee value);

    /// <summary>
    /// Updates an existing <see cref="Employee"/>.
    /// </summary>
    /// <param name="value">The <see cref="Employee"/>.</param>
    /// <returns>The updated <see cref="Employee"/>.</returns>
    Task<Result<Employee>> UpdateAsync(Employee value);

    /// <summary>
    /// Deletes the specified <see cref="Employee"/>.
    /// </summary>
    /// <param name="id">The Id.</param>
    Task<Result> DeleteAsync(Guid id);

    /// <summary>
    /// Gets the <see cref="EmployeeBaseCollectionResult"/> that contains the items that match the selection criteria.
    /// </summary>
    /// <param name="args">The Args (see <see cref="Entities.EmployeeArgs"/>).</param>
    /// <param name="paging">The <see cref="PagingArgs"/>.</param>
    /// <returns>The <see cref="EmployeeBaseCollectionResult"/>.</returns>
    Task<Result<EmployeeBaseCollectionResult>> GetByArgsAsync(EmployeeArgs? args, PagingArgs? paging);

    /// <summary>
    /// Terminates an existing <see cref="Employee"/>.
    /// </summary>
    /// <param name="value">The <see cref="TerminationDetail"/>.</param>
    /// <param name="id">The <see cref="Employee"/> identifier.</param>
    /// <returns>The updated <see cref="Employee"/>.</returns>
    Task<Result<Employee>> TerminateAsync(TerminationDetail value, Guid id);
}