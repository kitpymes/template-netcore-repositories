// -----------------------------------------------------------------------
// <copyright file="ICommandRelationalRepository.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Repositories
{
    /*
       Repositorio de comandos para bases de datos relacionales
       Contiene las acciones de Agregar, Actualizar y Eliminar
    */

    /// <summary>
    /// Repositorio de comandos para bases de datos relacionales <c>ICommandRelationalRepository</c>.
    /// Contiene las acciones de Agregar, Actualizar y Eliminar.
    /// </summary>
    /// <remarks>
    /// <para>En esta interfaz se pueden agregar todas las acciones comunes para las opciones Agegar, Actualizar y eliminar.</para>
    /// </remarks>
    public interface ICommandRelationalRepository<T> : ICommandRepository<T>
        where T : class { }
}
