// -----------------------------------------------------------------------
// <copyright file="ICommandRepository.cs" company="Kitpymes">
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
        Repositorio de comandos
        Contiene las acciones de Agregar, Actualizar y Eliminar
    */

    /// <summary>
    /// Repositorio de comandos <c>ICommandRepository</c>.
    /// Contiene las acciones de Agregar, Actualizar y Eliminar.
    /// </summary>
    /// <remarks>
    /// <para>En esta interfaz se pueden agregar todas las acciones comunes para las opciones Agegar, Actualizar y eliminar.</para>
    /// </remarks>
    public interface ICommandRepository<T>
        where T : class
    {
        #region Add

        /// <summary>
        /// Agregar un objeto.
        /// </summary>
        /// <param name="item">Objeto que se quiere agregar.</param>
        void Add(T item);

        /// <summary>
        /// Agregar un objeto.
        /// </summary>
        /// <param name="item">Objeto que se quiere agregar.</param>
        /// <returns>Task.</returns>
        Task AddAsync(T item);

        /// <summary>
        /// Agregar un lista de objetos.
        /// </summary>
        /// <param name="items">Objetos que se quieren agregar.</param>
        void AddRange(IEnumerable<T> items);

        /// <summary>
        /// Agregar un lista de objetos.
        /// </summary>
        /// <param name="items">Objetos que se quieren agregar.</param>
        /// <returns>Task.</returns>
        Task AddRangeAsync(IEnumerable<T> items);

        #endregion Add

        #region Update

        /// <summary>
        /// Actualizar un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <param name="item">Objeto con los nuevos valores.</param>
        void Update(object key, T item);

        /// <summary>
        /// Actualizar un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <param name="item">Objeto con los nuevos valores.</param>
        /// <returns>Task.</returns>
        Task UpdateAsync(object key, T item);

        /// <summary>
        /// Actualizar un campo de un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <param name="item">Campo del objeto a actualizar.</param>
        void UpdatePartial(object key, object item);

        /// <summary>
        /// Actualizar un campo de un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <param name="item">Campo del objeto a actualizar.</param>
        /// <returns>Task.</returns>
        Task UpdatePartialAsync(object key, object item);

        #endregion Update

        #region Delete

        /// <summary>
        /// Eliminar un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        void Delete(object key);

        /// <summary>
        /// Eliminar un objeto.
        /// </summary>
        /// <param name="key">Clave unica del objeto.</param>
        /// <returns>Task.</returns>
        Task DeleteAsync(object key);

        /// <summary>
        /// Eliminar un objeto.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para que sea eliminado el objeto.</param>
        void Delete(Expression<Func<T, bool>> where);

        /// <summary>
        /// Eliminar un objeto.
        /// </summary>
        /// <param name="where">Condición que se debe cumplir para que sea eliminado el objeto.</param>
        /// <returns>Task.</returns>
        Task DeleteAsync(Expression<Func<T, bool>> where);

        #endregion Delete
    }
}
