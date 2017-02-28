// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitOfWorkAsync.cs" company="EPAM Systems">
//   Copyright 2015
// </copyright>
// <summary>
//   Defines the IUnitOfWorkAsync type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PKCDashboard.Repository.Pattern.UnitOfWork
{
    using System.Threading;
    using System.Threading.Tasks;
    using PKCDashboard.Repository.Pattern.Infrastructure;
    using PKCDashboard.Repository.Pattern.Repositories;

    /// <summary>
    /// The UnitOfWorkAsync interface.
    /// </summary>
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        /// <summary>
        /// The save changes async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// The save changes async.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        /// <summary>
        /// The repository async.
        /// </summary>
        /// <typeparam name="TEntity">Type for which the repository is being created for.</typeparam>
        /// <returns>
        /// The instance of repository
        /// <see cref="PKCDashboard.Repository.Pattern.Repositories.IRepositoryAsync`1" />
        /// for TEntity.
        /// </returns>
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}