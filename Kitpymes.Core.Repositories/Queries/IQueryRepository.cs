// -----------------------------------------------------------------------
// <copyright file="IQueryRepository.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /*
        Repositorio de consultas para bases de datos
        Contiene las acciones de Obtener o Buscar
    */

    /// <summary>
    /// Repositorio de consultas para bases de datos <c>IRelationalQueryRepository</c>.
    /// Contiene las acciones de Obtener o Buscar.
    /// </summary>
    /// <remarks>
    /// <para>En esta interfaz se pueden agregar todas las acciones comunes para consultar la bade de datos.</para>
    /// </remarks>
    public interface IQueryRepository<T>
        where T : class
    {
        #region GetOne

        /// <summary>
        /// Obtiene un objeto.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder obtenerlo.</param>
        /// <returns>T: el objeto.</returns>
        T GetOne(Expression<Func<T, bool>> where);

        /// <summary>
        /// Obtiene un objeto.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder obtenerlo.</param>
        /// <returns>Task{T}.</returns>
        Task<T> GetOneAsync(Expression<Func<T, bool>> where);

        #endregion GetOne

        #region GetAll

        /// <summary>
        /// Obtiene una lista de objetos.
        /// </summary>
        /// <returns>IEnumerable{T}: lista de objetos.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Obtiene una lista de objetos.
        /// </summary>
        /// <returns>Task{IEnumerable{T}}: lista de objetos.</returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Obtiene una lista de objetos.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
        /// <returns>IEnumerable{T}: lista de objetos.</returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);

        /// <summary>
        /// Obtiene una lista de objetos.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
        /// <returns>Task{IEnumerable{T}}: lista de objetos.</returns>
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> where);

        #endregion GetAll

        #region GetPaged

        /// <summary>
        /// Obtener una lista de objetos paginada.
        /// </summary>
        /// <param name="parameters">Configuración de los parámetros.</param>
        /// <returns>IEnumerable{T}: lista de objetos.</returns>
        IEnumerable<T> GetPaged(Action<(string? property, bool? ascending, int? index, int? size)> parameters);

        /// <summary>
        /// Obtener una lista de objetos paginada.
        /// </summary>
        /// <param name="parameters">Configuración de los parámetros.</param>
        /// <returns>Task{IEnumerable{T}}: lista de objetos.</returns>
        Task<IEnumerable<T>> GetPagedAsync(Action<(string? property, bool? ascending, int? index, int? size)> parameters);

        #endregion GetPaged

        #region Find

        /// <summary>
        /// Obtiene un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <returns>T: el objeto.</returns>
        T Find(object key);

        /// <summary>
        /// Obtiene un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <returns>Task{T}: el objeto.</returns>
        Task<T> FindAsync(object key);

        #endregion Find

        #region Any

        /// <summary>
        /// Verifica si la lista contiene algún objeto.
        /// </summary>
        /// <returns>true | false.</returns>
        bool Any();

        /// <summary>
        /// Verifica si la lista contiene algún objeto.
        /// </summary>
        /// <returns>Task{true} | Task{false}.</returns>
        Task<bool> AnyAsync();

        /// <summary>
        /// Verifica si la lista contiene algún objeto.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder verificar.</param>
        /// <returns>true | false.</returns>
        bool Any(Expression<Func<T, bool>> where);

        /// <summary>
        /// Verifica si la lista contiene algún objeto.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder verificar.</param>
        /// <returns>Task{true} | Task{false}.</returns>
        Task<bool> AnyAsync(Expression<Func<T, bool>> where);

        #endregion Any

        #region Count

        /// <summary>
        /// Obtiene la cantidad de objetos que contiene la tabla.
        /// </summary>
        /// <returns>long.</returns>
        long Count();

        /// <summary>
        /// Obtiene la cantidad de objetos que contiene la tabla.
        /// </summary>
        /// <returns>Task{long}.</returns>
        Task<long> CountAsync();

        /// <summary>
        /// Obtiene la cantidad de objetos que contiene la tabla.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder obtener el valor.</param>
        /// <returns>long.</returns>
        long Count(Expression<Func<T, bool>> where);

        /// <summary>
        /// Obtiene la cantidad de objetos que contiene la tabla.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para poder obtener el valor.</param>
        /// <returns>Task{long}.</returns>
        Task<long> CountAsync(Expression<Func<T, bool>> where);

        #endregion Count
    }
}
