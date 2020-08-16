// -----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Repositories
{
    /*
       Repositorio de comandos y de consultas
       Contiene todas las acciones de Obtener o buscar, Agregar, Actualizar y Eliminar
    */

    /// <summary>
    /// Repositorio de comandos y de consultas <c>IRepository</c>.
    /// Contiene todas las acciones de Obtener o buscar, Agregar, Actualizar y Eliminar.
    /// </summary>
    /// <remarks>
    /// <para>En esta interfaz se pueden agregar todas las acciones de comandos y consultas para la base de datos.</para>
    /// </remarks>
    public interface IRepository<T> : ICommandRepository<T>, IQueryRepository<T>
        where T : class { }
}
